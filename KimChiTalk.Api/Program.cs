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

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddScoped<AnswerService.IService, AnswerService.Service>();
builder.Services.AddScoped<QuestionService.IService, QuestionService.Service>();
builder.Services.AddScoped<UserService.IService, UserService.Service>();
builder.Services.AddScoped<CourseService.IService, CourseService.Service>();
builder.Services.AddScoped<LessonService.IService, LessonService.Service>();
builder.Services.AddScoped<VocabularyService.IService, VocabularyService.Service>();
builder.Services.AddScoped<IdentityService.IService, IdentityService.Service>();
builder.Services.AddScoped<JwtService.IService, JwtService.Service>();
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

app.MapControllers();

app.Run();