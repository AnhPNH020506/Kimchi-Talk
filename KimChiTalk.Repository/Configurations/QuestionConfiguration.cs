using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KimChiTalk.Repository.Configurations;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.Property(q => q.Content).HasMaxLength(512).IsRequired();
        builder.Property(q => q.QuestionType).HasConversion<string>().HasMaxLength(64);
        builder.Property(q => q.QuestionStage).HasConversion<string>().HasMaxLength(64);
        builder.HasIndex(q => q.LessonId);
        builder.HasIndex(q => q.GrammarId);

        // ⚠️ PHẢI trỏ vào Grammar.Questions.
        // Nếu để .WithMany() rỗng, Grammar.Questions bị "mồ côi" và EF sẽ tự
        // tạo quan hệ THỨ HAI với shadow FK 'GrammarId1' (đúng warning bạn gặp).
        builder.HasOne(q => q.Grammar)
            .WithMany(g => g.Questions)
            .HasForeignKey(q => q.GrammarId)
            .OnDelete(DeleteBehavior.SetNull);

        // ❌ 2.667 record HasData đã chuyển sang SeedData/questions.json + DbSeeder.
    }
}