using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KimChiTalk.Repository.Configurations;

public class VocabularyConfiguration : IEntityTypeConfiguration<Vocabulary>
{
    public void Configure(EntityTypeBuilder<Vocabulary> builder)
    {
        builder.Property(v => v.Word).HasMaxLength(128).IsRequired();
        builder.Property(v => v.Level).HasMaxLength(64).IsRequired();
        builder.Property(v => v.Type).HasMaxLength(64).IsRequired();
        builder.Property(v => v.MeaningVietNamese).HasMaxLength(512).IsRequired();

        builder.HasIndex(v => v.LessonId);
        builder.HasIndex(v => v.Word);

        // ❌ 1.000 record HasData đã chuyển sang SeedData/vocabularies.json + DbSeeder.
    }
}