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
    public DbSet<UserReward> UserRewards { get; set; }
    public DbSet<Reward> Rewards { get; set; }
    public DbSet<UserGrammar>  UserGrammars { get; set; }
    public DbSet<AdminMessage> AdminMessages { get; set; }


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
                .HasForeignKey(u => u.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany<Lesson>(u => u.Lessons)
                .WithOne(u => u.Course)
                .HasForeignKey(u => u.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            var courses = new List<Course>()
            {
                new()
                {
                    Id = CourseId1,
                    Title = "Beginner",
                    Description = "Introductory Korean Language Course",
                    Level = CourseLevel.Beginner,
                    Order = 1
                },
                new()
                {
                    Id = CourseId2,
                    Title = "Intermediate",
                    Description = "Introductory Korean Language Course",
                    Level = CourseLevel.Intermediate,
                    Order = 1
                },
                new()
                {
                    Id = CourseId3,
                    Title = "Advanced",
                    Description = "Introductory Korean Language Course",
                    Level = CourseLevel.Advanced,
                    Order = 1
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
            // Seed data cho Lesson đã chuyển sang LessonConfiguration.cs (55 Lesson theo chủ đề, thay cho 3 Lesson cũ)
        });
        modelBuilder.Entity<Grammar>(builder =>
        {
            builder.Property(g => g.Title).HasMaxLength(128).IsRequired();
            builder.Property(g => g.Explanation).HasMaxLength(128).IsRequired();
            builder.Property(g => g.Example).HasMaxLength(128).IsRequired();

        });
        
        modelBuilder.Entity<UserCourse>(builder =>
        {
            
        });
        modelBuilder.Entity<UserVocabulary >(builder =>
        {
            
        });
        modelBuilder.Entity<AdminMessage>(builder =>
        {
            builder.Property(a => a.Content).HasMaxLength(128).IsRequired();
            builder.HasOne(a => a.Admin)
                .WithMany()
                .HasForeignKey(a => a.AdminId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        });
        modelBuilder.Entity<Reward>(builder =>
        {
            builder.Property(r => r.Title).HasMaxLength(128).IsRequired();
            builder.Property(r => r.ImageUrl).HasMaxLength(128).IsRequired();
            builder.Property(r => r.Message).HasMaxLength(128).IsRequired();

        });
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
