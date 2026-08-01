using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;

namespace KimChiTalk.Repository;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // 🔴 TRƯỚC ĐÂY: Guid.NewGuid() -> mỗi lần chạy sinh GUID khác nhau
    // => HasData không xác định (non-deterministic), migration nào cũng
    //    sinh ra DELETE + INSERT lại toàn bộ seed. PHẢI dùng GUID cố định.
    public static readonly Guid UserId1   = new("aaaaaaaa-0000-0000-0000-000000000001");
    public static readonly Guid UserId2   = new("aaaaaaaa-0000-0000-0000-000000000002");
    public static readonly Guid CourseId1 = new("11111111-1111-1111-1111-111111111111");
    public static readonly Guid CourseId2 = new("22222222-2222-2222-2222-222222222222");
    public static readonly Guid CourseId3 = new("33333333-3333-3333-3333-333333333333");

    private static readonly DateTimeOffset SeedTime =
        new(2026, 1, 1, 0, 0, 0, TimeSpan.Zero);

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
    public DbSet<UserGrammar> UserGrammars { get; set; }
    public DbSet<AdminMessage> AdminMessages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(builder =>
        {
            builder.Property(u => u.Name).HasMaxLength(128).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(128).IsRequired();
            builder.Property(u => u.HashshedPassword).HasMaxLength(128).IsRequired();

            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasMany(u => u.UserCourses)
                .WithOne(uc => uc.User)
                .HasForeignKey(uc => uc.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.UserProgresses)
                .WithOne(up => up.User)
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(u => u.UserVocabulary)
                .WithOne(uv => uv.User)
                .HasForeignKey(uv => uv.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            // (bỏ dòng HasMany<UserCourse> bị lặp lại lần 2 trong bản cũ)

            builder.HasData(
                new User
                {
                    Id = UserId1,
                    Name = "Anh",
                    Email = "phamnguyenhunganh475@gmail.com",
                    HashshedPassword = "phamnguyenhunganh475",
                    CreatedAt = SeedTime,
                    UpdatedAt = SeedTime
                },
                new User
                {
                    Id = UserId2,
                    Name = "Anh2",
                    Email = "Email@gmail.com",
                    HashshedPassword = "Email",
                    CreatedAt = SeedTime,
                    UpdatedAt = SeedTime
                });
        });

        modelBuilder.Entity<Course>(builder =>
        {
            builder.Property(c => c.Title).HasMaxLength(128).IsRequired();
            builder.Property(c => c.Description).HasMaxLength(256).IsRequired();

            builder.HasMany(c => c.UserCourses)
                .WithOne(uc => uc.Course)
                .HasForeignKey(uc => uc.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(c => c.Lessons)
                .WithOne(l => l.Course)
                .HasForeignKey(l => l.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Course
                {
                    Id = CourseId1, Title = "Beginner",
                    Description = "Introductory Korean Language Course",
                    Level = CourseLevel.Beginner, Order = 1,
                    CreatedAt = SeedTime, UpdatedAt = SeedTime
                },
                new Course
                {
                    Id = CourseId2, Title = "Intermediate",
                    Description = "Intermediate Korean Language Course",
                    Level = CourseLevel.Intermediate, Order = 2,
                    CreatedAt = SeedTime, UpdatedAt = SeedTime
                },
                new Course
                {
                    Id = CourseId3, Title = "Advanced",
                    Description = "Advanced Korean Language Course",
                    Level = CourseLevel.Advanced, Order = 3,
                    CreatedAt = SeedTime, UpdatedAt = SeedTime
                });
        });

        modelBuilder.Entity<Lesson>(builder =>
        {
            builder.Property(l => l.Title).HasMaxLength(128).IsRequired();
            builder.HasIndex(l => new { l.CourseId, l.Order });

            builder.HasMany(l => l.Vocabulary)
                .WithOne(v => v.Lesson)
                .HasForeignKey(v => v.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(l => l.Grammars)
                .WithOne(g => g.Lesson)
                .HasForeignKey(g => g.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(l => l.Questions)
                .WithOne(q => q.Lesson)
                .HasForeignKey(q => q.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
            // ❌ KHÔNG HasData ở đây — 55 Lesson + 1.000 Vocabulary
            //    + 2.667 Question + 10.668 Answer đã chuyển sang DbSeeder.
        });

        modelBuilder.Entity<Grammar>(builder =>
        {
            builder.Property(g => g.Title).HasMaxLength(128).IsRequired();
            builder.Property(g => g.Explanation).HasMaxLength(1024).IsRequired();
            builder.Property(g => g.Example).HasMaxLength(512).IsRequired();
        });

        modelBuilder.Entity<AdminMessage>(builder =>
        {
            builder.Property(a => a.Content).HasMaxLength(1024).IsRequired();
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
            builder.Property(r => r.ImageUrl).HasMaxLength(512).IsRequired();
            builder.Property(r => r.Message).HasMaxLength(512).IsRequired();
        });

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}