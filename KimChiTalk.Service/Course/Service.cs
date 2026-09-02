using KimChiTalk.Repository;
using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Service.Course;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Response.CourseResponse>> GetCourses(Guid? userId)
    {
        var courses = await _dbContext.Courses.OrderBy(c => c.Order).ToListAsync();
        var enrolledCourseIds = new HashSet<Guid>();
        if(userId.HasValue)
        {
            var enrolledIds = await _dbContext.UserCourses.Where(x => x.UserId == userId.Value).Select (x => x.CourseId).ToListAsync();
            enrolledCourseIds = enrolledIds.ToHashSet();
        }

        var result = courses.Select(c => new Response.CourseResponse
        {
            Id = c.Id,
            Title = c.Title,
            Description = c.Description,
            Level = c.Level.ToString(),
            Order = c.Order,
            IsEnrolled = enrolledCourseIds.Contains(c.Id),
        }).ToList();
            
        return result;

    }

    public async Task<string> Enroll(Guid userId, Guid courseId)
    {
        var findCourse = await _dbContext.Courses.FirstOrDefaultAsync(c => c.Id == courseId);
        if (findCourse == null)
        {
            throw new KeyNotFoundException("Không tìm thấy khóa học");
        }

        var userCourse = await _dbContext.UserCourses.AnyAsync(u => u.UserId == userId && u.CourseId == findCourse.Id);
        if (userCourse)
        {
            throw new InvalidOperationException("Bảo bối à em đã đăng kí khóa học này rùi mòo");
        }

        if (findCourse.Level != CourseLevel.Beginner)
        {
            var previousLevel =  findCourse.Level - 1;
            var findPreviousLevel = await _dbContext.Courses.FirstOrDefaultAsync(u => u.Level == previousLevel);
            if (findPreviousLevel == null)
            {
                throw new KeyNotFoundException ("Không tìm thấy khóa học ở cấp trước");
            }
            var lessonIds = await _dbContext.Lessons.Where(l => l.CourseId == findPreviousLevel.Id).Select(l => l.Id).ToListAsync();
            var completedCount = await _dbContext.UserProgresses.CountAsync(p => p.UserId == userId && p.Completed && lessonIds.Contains(p.LessonId));
            var isPreviousCompleted = lessonIds.Count > 0 && lessonIds.Count == completedCount;
            if (!isPreviousCompleted)
            {
                throw new InvalidOperationException($"Bảo bối phải hoàn thành khóa học \"{findPreviousLevel.Title}\" trước khi đăng ký khóa học này aaaaa");
            }
            
        }

        var newUserCourse = new UserCourse
        {
            UserId = userId,
            CourseId = findCourse.Id,
            EnrollAt = true
        };
        _dbContext.UserCourses.Add(newUserCourse);
        await _dbContext.SaveChangesAsync();

        return "Bảo bối đã đăng ký khóa học thành công";


    }

    public async Task CreateCourse(Guid adminId, Request.CourseRequest request)
    {
        var course = new Repository.Entity.Course
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            Description = request.Description,
            Level = request.Level,
            Order = request.Order,

        };
        _dbContext.Courses.Add(course);
        await _dbContext.SaveChangesAsync();
        
    }

    public async Task UpdateCourse(Guid adminId, Guid courseId, Request.CourseRequest request)
    {
       var course = await _dbContext.Courses.FirstOrDefaultAsync(c => c.Id == courseId);
       if (course == null)
       {
           throw new Exception("Course này không có trong hệ thống. Vui lòng thử lại!");
       }

       course = new Repository.Entity.Course()
       {
           Id = courseId,
           Title = request.Title,
           Description = request.Description,
           Level = request.Level,
           Order = request.Order,

       };
    }

    public async Task DeleteCourse(Guid adminId, Guid courseId)
    {
        var course = await _dbContext.Courses.FirstOrDefaultAsync(c => c.Id == courseId);
        if (course == null)
        {
            throw new Exception("Course này không có trong hệ thống. Vui lòng thử lại!");
        }
        _dbContext.Courses.Remove(course);
        await _dbContext.SaveChangesAsync();
    }
}