using KimChiTalk.Extensions;
using KimChiTalk.Middlewares;
using KimChiTalk.Options;
using KimChiTalk.Repository;
using Microsoft.EntityFrameworkCore;

using AnswerService = KimChiTalk.Service.Answer;
using CourseService = KimChiTalk.Service.Course;
using LessonService = KimChiTalk.Service.Lesson;
using QuestionService = KimChiTalk.Service.Question;
using UserService = KimChiTalk.Service.User;
using VocabularyService = KimChiTalk.Service.Vocabulary;
using IdentityService = KimChiTalk.Service.Identity;
using JwtService = KimChiTalk.Service.JWTService;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

ConfigureValidatedOptions(builder.Services, builder.Configuration, builder.Environment);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddJwtServices(builder.Configuration);
builder.Services.AddSwaggerServices();

builder.Services.AddScoped<AnswerService.IService, AnswerService.Service>();
builder.Services.AddScoped<QuestionService.IService, QuestionService.Service>();
builder.Services.AddScoped<UserService.IService, UserService.Service>();
builder.Services.AddScoped<CourseService.IService, CourseService.Service>();
builder.Services.AddScoped<LessonService.IService, LessonService.Service>();
builder.Services.AddScoped<VocabularyService.IService, VocabularyService.Service>();
builder.Services.AddScoped<IdentityService.IService, IdentityService.Service>();
builder.Services.AddScoped<JwtService.IService, JwtService.Service>();
builder.Services.AddCors(options =>
{
    var corsOptions = builder.Configuration
        .GetSection(CorsOptions.SectionName)
        .Get<CorsOptions>() ?? new CorsOptions();

    options.AddPolicy("AllowFrontend", policy =>
    {
        if (corsOptions.AllowedOrigins.Length == 0)
        {
            return;
        }

        policy
            .WithOrigins(corsOptions.AllowedOrigins)
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});
var app = builder.Build();

// ── Tạo DB + apply migration + seed 14.390 record ─────────────────
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    await db.Database.MigrateAsync();
    await DbSeeder.SeedAsync(db);
}
// ──────────────────────────────────────────────────────────────────

// Swagger UI (bạn đã AddSwaggerGen nhưng thiếu 2 dòng này)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.Run();

static void ConfigureValidatedOptions(IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
{
    services.AddOptions<JwtService.JwtOptions>()
        .Bind(configuration.GetSection(nameof(JwtService.JwtOptions)));

    // services.AddOptions<CloudinaryService.CloudinaryOptions>()
    //     .Bind(configuration.GetSection(nameof(CloudinaryService.CloudinaryOptions)));
    //
    // services.Configure<MailServiceOptions>(
    //     configuration.GetSection("MailOptions"));

    if (environment.IsDevelopment())
    {
        return;
    }

    // services.AddOptions<MailServiceOptions>()
    //     .ValidateDataAnnotations()
    //     .Validate(options =>
    //             HasConfiguredValue(options.Mail)
    //             && HasConfiguredValue(options.DisplayName)
    //             && HasConfiguredValue(options.ApiKey),
    //         "MailOptions must be configured with secure non-placeholder values.")
    //     .ValidateOnStart();

    services.AddOptions<JwtService.JwtOptions>()
        .ValidateDataAnnotations()
        .Validate(options =>
                HasConfiguredValue(options.SecretKey)
                && HasConfiguredValue(options.Issuer)
                && HasConfiguredValue(options.Audience)
                && options.ExpireMinutes > 0
                && options.RefreshTokenExpireDays > 0,
            "JwtOptions must be configured with secure non-placeholder values.")
        .ValidateOnStart();

    // services.AddOptions<CloudinaryService.CloudinaryOptions>()
    //     .ValidateDataAnnotations()
    //     .Validate(options =>
    //             HasConfiguredValue(options.CloudName)
    //             && HasConfiguredValue(options.ApiKey)
    //             && HasConfiguredValue(options.ApiSecret),
    //         "CloudinaryOptions must be configured with secure non-placeholder values.")
    //     .ValidateOnStart();
}

static bool HasConfiguredValue(string? value)
{
    return !string.IsNullOrWhiteSpace(value) && !HasPlaceholder(value);
}

static bool HasPlaceholder(string? value)
{
    if (string.IsNullOrWhiteSpace(value))
    {
        return true;
    }

    return value.Contains("__SET", StringComparison.OrdinalIgnoreCase)
           || value.Contains("CHANGE_ME", StringComparison.OrdinalIgnoreCase)
           || value.Contains("PLACEHOLDER", StringComparison.OrdinalIgnoreCase);
}