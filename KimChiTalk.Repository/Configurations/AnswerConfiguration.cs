using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KimChiTalk.Repository.Configurations;

public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder.Property(a => a.Content).HasMaxLength(512).IsRequired();
        builder.HasIndex(a => a.QuestionId);

        builder.HasOne(a => a.Question)
            .WithMany(q => q.Answers)
            .HasForeignKey(a => a.QuestionId)
            .OnDelete(DeleteBehavior.Cascade);

        // ❌ 10.668 record HasData đã chuyển sang SeedData/answers.json + DbSeeder.
    }
}