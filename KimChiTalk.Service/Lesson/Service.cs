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
        var completedLessonIds = new HashSet<Guid>();
        var completedLesson = await _dbContext.UserProgresses.Where(x => x.Completed && x.UserId == userId).Select(x => x.LessonId ).ToListAsync();
        completedLessonIds = completedLesson.ToHashSet();
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
}