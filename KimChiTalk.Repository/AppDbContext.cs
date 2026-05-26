using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public static Guid UserId1 = Guid.NewGuid();
    public static Guid UserId2 = Guid.NewGuid();
    public static Guid CourseId1 = Guid.NewGuid();
    public static Guid CourseId2 = Guid.NewGuid();
    public static Guid CourseId3 = Guid.NewGuid();
    public static Guid LessonId1 = Guid.NewGuid();
    public static Guid LessonId2 = Guid.NewGuid();
    public static Guid LessonId3 = Guid.NewGuid();


    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Grammar> Grammars { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<UserCourse> UserCourses { get; set; }
    public DbSet<UserProgress> UserProgresses { get; set; }
    public DbSet<UserVocabulary> UserVocabulary { get; set; }
    public DbSet<Vocabulary> Vocabulary { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(builder =>
        {
            builder.Property(u => u.Id).HasMaxLength(128).IsRequired();
            builder.Property(u => u.Name).HasMaxLength(128).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(128).IsRequired();
            builder.Property(u => u.HashshedPassword).HasMaxLength(128).IsRequired();
            builder.HasMany<UserCourse>(u => u.UserCourses)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany<UserProgress>(u => u.UserProgresses)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany<UserVocabulary>(u => u.UserVocabulary)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany<UserCourse>(u => u.UserCourses)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            var user = new List<User>()
            {
                new()
                {
                    Id = UserId1,
                    Name = "Anh",
                    Email = "phamnguyenhunganh475@gmail.com",
                    HashshedPassword = "phamnguyenhunganh475",
                },
                new()
                {
                    Id = UserId2,
                    Name = "Anh2",
                    Email = "Email@gmail.com",
                    HashshedPassword = "Email",
                }
            };
            builder.HasData(user);
        });
        modelBuilder.Entity<Course>(builder =>
        {
            builder.Property(c => c.Title).HasMaxLength(128).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(128).IsRequired();

            builder.HasMany<UserCourse>(c => c.UserCourses)
                .WithOne(c => c.Course)
                .HasForeignKey(u => u.CoursesId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany<Lesson>(u => u.Lessons)
                .WithOne(u => u.Courses)
                .HasForeignKey(u => u.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            var courses = new List<Course>()
            {
                new()
                {
                    Id = CourseId1,
                    Title = "Beginner",
                    Description = "Introductory Korean Language Course",
                },
                new()
                {
                    Id = CourseId2,
                    Title = "Intermediate",
                    Description = "Introductory Korean Language Course",
                },
                new()
                {
                    Id = CourseId3,
                    Title = "Advanced",
                    Description = "Introductory Korean Language Course",
                },
            };
            builder.HasData(courses);
        });
        modelBuilder.Entity<Lesson>(builder =>
        {
            builder.Property(l => l.Title).HasMaxLength(128).IsRequired();
            builder.HasMany(l => l.Vocabulary)
                .WithOne(l => l.Lesson)
                .HasForeignKey(l => l.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(l => l.Grammars)
                .WithOne(l => l.Lesson)
                .HasForeignKey(l => l.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(l => l.Questions)
                .WithOne(l => l.Lesson)
                .HasForeignKey(l => l.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
            var lesson = new List<Lesson>()
            {
                new()
                {
                    Id = LessonId1,
                    Title = "Beginner",
                },
                new()
                {
                    Id = LessonId2,
                    Title = "Beginner",
                },
                new()
                {
                    Id = LessonId3,
                    Title = "Beginner",
                }
            };
            builder.HasData(lesson);
        });
        modelBuilder.Entity<UserCourse>(builder => { });
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}