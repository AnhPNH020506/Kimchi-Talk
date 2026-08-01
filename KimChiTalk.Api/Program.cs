using KimChiTalk.Repository;
using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;

using AnswerService = KimChiTalk.Service.Answer;
using CourseService = KimChiTalk.Service.Course;
using LessonService = KimChiTalk.Service.Lesson;
using QuestionService = KimChiTalk.Service.Question;
using UserService = KimChiTalk.Service.User;
using VocabularyService = KimChiTalk.Service.Vocabulary;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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


var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();