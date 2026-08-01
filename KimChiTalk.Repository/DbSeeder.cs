using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Repository;

/// <summary>
/// Seed dữ liệu lớn (Lesson / Vocabulary / Question / Answer) ở RUNTIME.
/// KHÔNG dùng HasData cho các bảng này: 14.000+ record sẽ làm EF sinh ra
/// một method BuildTargetModel khổng lồ -> StackOverflow khi chạy dotnet ef.
/// </summary>
public static class DbSeeder
{
    private static readonly JsonSerializerOptions JsonOpts = new()
    {
        PropertyNameCaseInsensitive = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public static async Task SeedAsync(AppDbContext context, CancellationToken ct = default)
    {
        var autoDetect = context.ChangeTracker.AutoDetectChangesEnabled;
        context.ChangeTracker.AutoDetectChangesEnabled = false;

        try
        {
            var now = DateTimeOffset.UtcNow;

            // Thứ tự QUAN TRỌNG: cha trước, con sau (FK).
            if (!await context.Lessons.AnyAsync(ct))
            {
                var lessons = Load<Lesson>("lessons.json");
                Stamp(lessons, now);
                await context.Lessons.AddRangeAsync(lessons, ct);
                await context.SaveChangesAsync(ct);
            }

            if (!await context.Vocabulary.AnyAsync(ct))
            {
                var vocab = Load<Vocabulary>("vocabularies.json");
                Stamp(vocab, now);
                await BulkInsertAsync(context, vocab, ct);
            }

            if (!await context.Questions.AnyAsync(ct))
            {
                var questions = Load<Question>("questions.json");
                Stamp(questions, now);
                await BulkInsertAsync(context, questions, ct);
            }

            if (!await context.Answers.AnyAsync(ct))
            {
                var answers = Load<Answer>("answers.json");
                Stamp(answers, now);
                await BulkInsertAsync(context, answers, ct);
            }
        }
        finally
        {
            context.ChangeTracker.AutoDetectChangesEnabled = autoDetect;
        }
    }

    /// <summary>Insert theo lô để không giữ 10.000 entity trong ChangeTracker cùng lúc.</summary>
    private static async Task BulkInsertAsync<T>(
        AppDbContext context, List<T> items, CancellationToken ct, int batchSize = 1000)
        where T : class
    {
        for (var i = 0; i < items.Count; i += batchSize)
        {
            var batch = items.Skip(i).Take(batchSize).ToList();
            await context.Set<T>().AddRangeAsync(batch, ct);
            await context.SaveChangesAsync(ct);
            context.ChangeTracker.Clear();
        }
    }

    private static void Stamp<T>(List<T> items, DateTimeOffset now)
    {
        foreach (var item in items)
        {
            if (item is Abstractions.IAuditableEntity a)
            {
                a.CreatedAt = now;
                a.UpdatedAt = now;
            }
        }
    }

    private static List<T> Load<T>(string fileName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = assembly
            .GetManifestResourceNames()
            .FirstOrDefault(n => n.EndsWith(fileName, StringComparison.OrdinalIgnoreCase))
            ?? throw new InvalidOperationException(
                $"Không tìm thấy embedded resource '{fileName}'. " +
                $"Kiểm tra <EmbeddedResource Include=\"SeedData\\*.json\" /> trong .csproj.");

        using var stream = assembly.GetManifestResourceStream(resourceName)!;
        return JsonSerializer.Deserialize<List<T>>(stream, JsonOpts)
               ?? throw new InvalidOperationException($"Không parse được '{fileName}'.");
    }
}