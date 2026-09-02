using KimChiTalk.Repository;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Service.Lesson;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Response.GetLessonsResponse>> GetLessons(Guid userId, Guid courseId)
    {
        var lessons = await _dbContext.Lessons.Where(l => l.CourseId == courseId).OrderBy(l => l.Order).ToListAsync();
        var completedLessonIds = (await _dbContext.UserProgresses
            .Where(x => x.Completed && x.UserId == userId)
            .Select(x => x.LessonId)
            .ToListAsync())
            .ToHashSet();
        var result = new List<Response.GetLessonsResponse>();
        var previousCompleted = true;
        foreach (var lesson in lessons)
        {
            var isCompleted = completedLessonIds.Contains(lesson.Id);
            var isUnlocked = previousCompleted;
            result.Add(new Response.GetLessonsResponse()
            {
                Id = lesson.Id,
                Order = lesson.Order,
                Title = lesson.Title,
                IsCompleted = isCompleted,
                IsUnlocked = isUnlocked,
            });
            previousCompleted = isCompleted;
        }
        return result;


    }

    public async Task CreateLesson(Guid adminId, Request.LessonRequest request)
    {
        var result = new Repository.Entity.Lesson
        {
            CourseId = request.CourseId,
            Id = Guid.NewGuid(),
            Title = request.Title,
            Order = request.Order,
        };
        _dbContext.Lessons.Add(result);
        await _dbContext.SaveChangesAsync();

    }

    public async Task DeleteLesson(Guid adminId, Guid lessonId)
    {
        var lesson = await  _dbContext.Lessons.Where(l => l.Id == lessonId).FirstOrDefaultAsync();
        if (lesson == null)
        {
            throw new Exception("Lesson Không tồn tại. Vui lòng nhập lại!");
        }
        _dbContext.Lessons.Remove(lesson);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateLesson(Guid adminId, Request.LessonRequest request, Guid lessonId)
    {
        var lesson = await  _dbContext.Lessons.Where(l => l.Id == lessonId).FirstOrDefaultAsync();
        if (lesson == null)
        {
            throw new Exception("Lesson Không tồn tại. Vui lòng nhập lại!");
        }

        lesson = new Repository.Entity.Lesson
        {
            Id = lessonId,
            Title = request.Title,
            Order = request.Order,

        };
        _dbContext.Lessons.Update(lesson);
        await _dbContext.SaveChangesAsync();
    }
}