using KimChiTalk.Repository;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Service.User;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<List<Response.CourseProgressResponse>> CourseProgress(Guid userId)
    {
        var courseOfCustomer = await _dbContext.UserCourses.Where(u => u.UserId == userId).ToListAsync();
        var course = courseOfCustomer.Select(u => u.CourseId).ToList();
        var lessonOfCourse = await _dbContext.Lessons.Where(l => course.Contains(l.CourseId)).OrderBy(l => l.Order)
            .ToListAsync();
        var lessonIds = lessonOfCourse.Select(u => u.Id).ToList();
        var completedLesssonIds = (await _dbContext.UserProgresses.Where(x => x.Completed && x.UserId == userId && lessonIds.Contains(x.LessonId)).Select(x => x.LessonId).ToListAsync()).ToHashSet();
        var lessonByCourse = lessonOfCourse.GroupBy(l => l.CourseId);
        var courseMap = await _dbContext.Courses.Where(c => course.Contains(c.Id)).ToDictionaryAsync(x => x.Id);
        var result = new List<Response.CourseProgressResponse>();
        foreach (var group in lessonByCourse)
        {
            var courseId =  group.Key;
            var courseInfor = courseMap[courseId];
            var lessonResponse = group.Select(l => new Response.LessonProgressResponse
            {
                LessonId = l.Id,
                Title = l.Title,
                Order = l.Order,
                IsCompleted = completedLesssonIds.Contains(l.Id),
            }).ToList();
            result.Add(new Response.CourseProgressResponse
            {
                CourseId = courseId,
                CourseTitle = courseInfor.Title,
                Level = courseInfor.Level,
                Lessons = lessonResponse
            });
            
        }
        return result;
    }
}