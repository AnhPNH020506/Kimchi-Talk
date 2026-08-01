using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KimChiTalk.Repository.Configurations;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.Property(q => q.Content).HasMaxLength(512).IsRequired();
        builder.Property(q => q.QuestionType).HasConversion<string>().HasMaxLength(64);
        builder.Property(q => q.QuestionStage).HasConversion<string>().HasMaxLength(64);
        builder.HasIndex(q => q.LessonId);

        builder.HasOne(q => q.Grammar)
            .WithMany()
            .HasForeignKey(q => q.GrammarId)
            .OnDelete(DeleteBehavior.SetNull);

        // ❌ 2.667 record HasData đã chuyển sang SeedData/questions.json + DbSeeder.
    }
}