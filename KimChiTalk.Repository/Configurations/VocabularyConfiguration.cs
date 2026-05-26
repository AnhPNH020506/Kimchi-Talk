using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KimChiTalk.Repository.Configurations;

// Seed hiện tại: 1000 từ — Beginner: 280 | Intermediate: 580 | Advanced: 140
// Data còn lại (1790 B / 3762 I / 892 A) xem file: VocabularyData_Remaining.cs
public class VocabularyConfiguration : IEntityTypeConfiguration<Vocabulary>
{
    public void Configure(EntityTypeBuilder<Vocabulary> builder)
    {
        builder.Property(v => v.Word).HasMaxLength(256).IsRequired();
        builder.Property(v => v.Level).HasMaxLength(64).IsRequired();
        builder.Property(v => v.Type).HasMaxLength(64).IsRequired();
        builder.Property(v => v.MeaningVietNamese).HasMaxLength(512).IsRequired();

        var vocabularies = new List<Vocabulary>()
        {
            new()
                {
                    Id = new Guid("46A4E085-5B21-42F2-863A-75CE93E8AD7B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가게",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "cửa hàng, cửa hiệu,  cửa tiệm, quầy",
                },
            new()
                {
                    Id = new Guid("A836093E-CBDC-4040-97E4-5E5F497A1643"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가격",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự đánh đập, sự ra đòn",
                },
            new()
                {
                    Id = new Guid("4DC109EA-5531-4841-9DA4-253010B2D6F7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가구",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "hộ gia đình",
                },
            new()
                {
                    Id = new Guid("DA71DC6D-3EDB-42B3-B85A-072E33ED1B4A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가깝다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "gần",
                },
            new()
                {
                    Id = new Guid("CAAF7FD3-48AD-43CB-9837-B934293909C4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가끔",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "thỉnh thoảng, đôi lúc",
                },
            new()
                {
                    Id = new Guid("87D08DA0-7648-4121-8FEC-F457237BB4DC"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가늘다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "mỏng manh, mảnh dẻ, thanh mảnh, thuôn dài",
                },
            new()
                {
                    Id = new Guid("57322E04-B2E6-4D94-9915-A1FE44282DF0"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "đi",
                },
            new()
                {
                    Id = new Guid("2A8FC5D7-5393-44B6-B408-B1125D79E28B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가다",
                    Level = "Beginner",
                    Type = "Auxiliary",
                    MeaningVietNamese = "đi",
                },
            new()
                {
                    Id = new Guid("87516792-54D3-4F6C-95FE-61F766F36644"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가득",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "đầy",
                },
            new()
                {
                    Id = new Guid("DBDBBC6A-168B-47F7-8A57-457C0CB9D249"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가르치다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "dạy",
                },
            new()
                {
                    Id = new Guid("8CC4E81C-2177-4C2C-8D98-E92CE1194FF8"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가리키다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "chỉ, chỉ trỏ",
                },
            new()
                {
                    Id = new Guid("2D0790D7-ACBF-49E8-A5F1-272AE7123A70"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가방",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "túi xách, giỏ xách, ba lô",
                },
            new()
                {
                    Id = new Guid("99CAB041-761B-42A6-BA75-EED578354F46"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가볍다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "nhẹ",
                },
            new()
                {
                    Id = new Guid("DA7B23AE-0BB0-46B0-9675-04440C4716B4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가수",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "ca sĩ",
                },
            new()
                {
                    Id = new Guid("92D6FD4D-D3D1-4BAD-B0D8-59C1DF3C2683"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가슴",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "ngực",
                },
            new()
                {
                    Id = new Guid("CF6E2F71-2F22-4F38-9FF2-DEABE7D3E91C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가요",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "bài hát đại chúng, ca khúc được yêu thích",
                },
            new()
                {
                    Id = new Guid("C3CEA89F-0DB0-4A0D-AC37-692ECA7E9428"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가운데",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "phần giữa, chỗ giữa",
                },
            new()
                {
                    Id = new Guid("18B1221A-2803-4B7C-86F0-A0DF86149019"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가위",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "cái kéo",
                },
            new()
                {
                    Id = new Guid("3E3A1191-B5D9-4E16-9AC4-39FF6D1694F1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가을",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "mùa thu",
                },
            new()
                {
                    Id = new Guid("EDB3FC14-91EA-4C74-BC1C-37B6DEAE1246"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가장",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "người chủ gia đình",
                },
            new()
                {
                    Id = new Guid("DB0630A8-FD06-4C4B-9963-8F5F95504305"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가져가다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "mang đi, đem đi",
                },
            new()
                {
                    Id = new Guid("41240B1E-8B82-4C66-93BB-F8AABA2E3C86"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가져오다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "mang đến, đem đến",
                },
            new()
                {
                    Id = new Guid("D3258423-FAC9-4B2F-A9F8-080B5D5787D5"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가족",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "gia đình",
                },
            new()
                {
                    Id = new Guid("8D59A7C8-87B5-4DCA-9C5B-55F6A304D9B6"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가지",
                    Level = "Beginner",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "cành",
                },
            new()
                {
                    Id = new Guid("A6FAD0DB-0803-4998-A342-0207A4B92F44"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가지다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "mang, cầm",
                },
            new()
                {
                    Id = new Guid("6726801F-1A4B-4F35-B302-967058B6BE3D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "가지다",
                    Level = "Beginner",
                    Type = "Auxiliary",
                    MeaningVietNamese = "mang, cầm",
                },
            new()
                {
                    Id = new Guid("7D6066AA-C36D-4B1D-ADC2-1FBA9D923093"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "각각",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "từng, mỗi",
                },
            new()
                {
                    Id = new Guid("F60D5094-2C25-43E9-B45A-27F8EC0A2AB5"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "각각",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "từng, mỗi",
                },
            new()
                {
                    Id = new Guid("2C03D6BE-232B-4DFC-9413-C142785B291E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "간단하다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "đơn giản",
                },
            new()
                {
                    Id = new Guid("62EE4D4A-6D32-4028-BD48-8A5EB148CB1D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "간단히",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách đơn giản",
                },
            new()
                {
                    Id = new Guid("9783A072-F771-4114-9E5D-93983E66A5A1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "간식",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "thức ăn giữa buổi, thức ăn nhẹ",
                },
            new()
                {
                    Id = new Guid("6937E2A1-5FE3-439C-B700-99D38C60A98E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "간장",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "Ganjang; nước tương, xì dầu",
                },
            new()
                {
                    Id = new Guid("6922733D-76A0-4F6E-B18B-FBAE79B34586"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "간호사",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "y tá",
                },
            new()
                {
                    Id = new Guid("3F392883-27EC-4E5F-8424-75265D99273F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "갈비",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sườn, món sườn",
                },
            new()
                {
                    Id = new Guid("88364184-2943-4A9B-BBE8-3FC06C4C1CCB"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "갈비탕",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "Galbitang; canh sườn ninh",
                },
            new()
                {
                    Id = new Guid("8FDF516A-D020-4C67-8125-A142337B224F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "갈색",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "màu nâu",
                },
            new()
                {
                    Id = new Guid("716EACEC-4B87-4209-9754-B8D915A056AC"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "갈아입다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "thay (quần áo)",
                },
            new()
                {
                    Id = new Guid("FFFD78A2-3853-428C-BA30-E56B37502DF5"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "갈아타다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "chuyển, đổi (tàu, xe…)",
                },
            new()
                {
                    Id = new Guid("72055975-3894-42D9-AE7D-44FC4A54550B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "감",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quả hồng",
                },
            new()
                {
                    Id = new Guid("3EAF8198-1114-4298-A1C4-4F96A4E7B862"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "감기",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "bệnh cảm",
                },
            new()
                {
                    Id = new Guid("4D4F00C3-4817-479B-9AC5-DA3AD1E5936A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "감기약",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "thuốc cảm",
                },
            new()
                {
                    Id = new Guid("E9516E71-9916-485D-93E1-3D3924E2D655"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "감다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "nhắm (mắt)",
                },
            new()
                {
                    Id = new Guid("770C26E3-BD2E-4751-908A-BF07295875CE"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "감다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "nhắm (mắt)",
                },
            new()
                {
                    Id = new Guid("7EE5146F-F140-430C-8FB8-287114CBE224"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "감사",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự cảm tạ",
                },
            new()
                {
                    Id = new Guid("9CE428C4-F902-410F-8FF0-F7A40BCE21F1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "감사하다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "cảm tạ",
                },
            new()
                {
                    Id = new Guid("01A367A6-5183-4604-A8DE-99EA5F158ECC"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "감사하다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "cảm tạ",
                },
            new()
                {
                    Id = new Guid("2BB217AB-D404-47F5-A37A-0BF14246095B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "감자",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "khoai tây",
                },
            new()
                {
                    Id = new Guid("784BBDAE-12F0-44C6-885A-AA5C65ED600E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "갑자기",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "đột ngột, bất thình lình, bỗng nhiên",
                },
            new()
                {
                    Id = new Guid("E5F56814-6956-4320-BDC2-03C2CDF0523E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "값",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "giá cả",
                },
            new()
                {
                    Id = new Guid("5A743D0F-F946-49BC-9927-9C6E6604315E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "강",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sông",
                },
            new()
                {
                    Id = new Guid("F705758F-36E1-4A41-A965-A8CBCA4FA01D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "강아지",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "chó con, cún con",
                },
            new()
                {
                    Id = new Guid("10A6D6EC-3F68-436B-8F32-A3ED05635A9A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "강하다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "cứng, rắn, chắc",
                },
            new()
                {
                    Id = new Guid("511EB375-5289-4090-B62F-73CE3E2528AB"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "갖다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "mang, cầm",
                },
            new()
                {
                    Id = new Guid("B896C865-D428-49CD-AD0C-131C0C67F3F2"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "같다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "giống",
                },
            new()
                {
                    Id = new Guid("A0F14590-7AFD-48E0-B4BC-C7169AF85270"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "같이",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "cùng",
                },
            new()
                {
                    Id = new Guid("6FF3BD3E-DC4B-42EB-9443-1955824B5564"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "갚다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "trả",
                },
            new()
                {
                    Id = new Guid("8B3B55FF-8780-4843-88DE-E68B65B69AB4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "개",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "chó",
                },
            new()
                {
                    Id = new Guid("F841225D-E5F1-4DF0-BD5F-269B4BE6B04D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "개",
                    Level = "Beginner",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "chó",
                },
            new()
                {
                    Id = new Guid("6D404997-C5F4-4F4D-B47D-1A4B5AF3CDB0"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "개월",
                    Level = "Beginner",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "tháng",
                },
            new()
                {
                    Id = new Guid("D84BCFDE-C8DF-4FDB-96D4-83BB24CC1217"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거",
                    Level = "Beginner",
                    Type = "Pronoun",
                    MeaningVietNamese = "cái, điều",
                },
            new()
                {
                    Id = new Guid("E1FED213-22A3-464F-9516-F7B52AC831D3"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거",
                    Level = "Beginner",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "cái, điều",
                },
            new()
                {
                    Id = new Guid("C34D7840-5B14-4CC2-8C5E-27A49495052C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거기",
                    Level = "Beginner",
                    Type = "Pronoun",
                    MeaningVietNamese = "nơi đó",
                },
            new()
                {
                    Id = new Guid("F5186090-28DB-4969-AD27-E9CBCE66AAF0"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거리",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "con phố",
                },
            new()
                {
                    Id = new Guid("47638797-AAB2-4925-8402-5DE653762734"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거리",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "con phố",
                },
            new()
                {
                    Id = new Guid("B9B397C6-6475-4939-98EF-9D215D51A156"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거실",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "gian giữa, phòng khách",
                },
            new()
                {
                    Id = new Guid("FBF89B35-DB52-4877-BBD1-B6EDA1021235"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거울",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "cái gương, gương soi",
                },
            new()
                {
                    Id = new Guid("D59140CE-E64F-458C-A954-99D2CA18BB2F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거의",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "hầu hết, gần như",
                },
            new()
                {
                    Id = new Guid("D4AD1B64-670E-4635-9FA8-33D354E2E28F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거의",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "hầu hết, gần như",
                },
            new()
                {
                    Id = new Guid("B57C2127-9FAB-4B20-AF00-43E94CA4E56D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거절",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự từ chối, sự cự tuyệt",
                },
            new()
                {
                    Id = new Guid("5A1CBD0F-9BE6-4CC1-83F2-70AF032F78AE"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "거짓말",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "lời nói dối",
                },
            new()
                {
                    Id = new Guid("DE635822-03B6-4413-B573-5521428A1DFC"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "걱정",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "nỗi lo",
                },
            new()
                {
                    Id = new Guid("63A64AFB-985E-483B-A575-B737ACBC8923"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "걱정하다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "lo lắng, lo ngại, lo sợ, lo",
                },
            new()
                {
                    Id = new Guid("CBFF0649-0A7A-4719-B169-EEFBE7556F0D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "건강",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự khỏe mạnh, sức khỏe",
                },
            new()
                {
                    Id = new Guid("C5254D1A-31A7-4CFD-8CBF-B9C0315B7932"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "건강하다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "khỏe mạnh, khỏe khoắn",
                },
            new()
                {
                    Id = new Guid("27528B5F-BC9A-4211-9DA0-662ABD17AD27"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "건너가다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "đi qua, vượt qua",
                },
            new()
                {
                    Id = new Guid("1B09337F-67DF-43C9-B7AA-0273702587D9"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "건너다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "sang",
                },
            new()
                {
                    Id = new Guid("55886EA0-794C-408A-8DC5-E7A1670BF9CF"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "건너편",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "bên kia đường, phía đối diện",
                },
            new()
                {
                    Id = new Guid("E0C4E511-8555-49B6-8814-451C9C7CDA73"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "건물",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "tòa nhà",
                },
            new()
                {
                    Id = new Guid("8DFB4578-5D63-4715-A7EA-19AEC15E2BA5"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "걷다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "tan",
                },
            new()
                {
                    Id = new Guid("E34A0916-52DB-4585-B0E3-4847985B260F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "걸다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "treo, đeo, mắc",
                },
            new()
                {
                    Id = new Guid("F09CBFCB-A64A-4563-B846-0805E3AEC4C9"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "걸리다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "được mắc, được treo",
                },
            new()
                {
                    Id = new Guid("D5201CDC-88DB-46D2-8FED-77BF9D0558C9"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "걸어가다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "bước đi",
                },
            new()
                {
                    Id = new Guid("C914B270-EC57-4AE9-BD2F-9C38A33905B5"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "걸어오다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "bước đến",
                },
            new()
                {
                    Id = new Guid("45975E95-93E5-42E2-BC8C-381392D287DE"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "걸음",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "bước chân",
                },
            new()
                {
                    Id = new Guid("211CEB6F-CF45-4752-8BD3-F52B88E390AA"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "검사",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "kiểm sát viên, công tố viên",
                },
            new()
                {
                    Id = new Guid("3FD62838-D694-4365-822B-5D700C978433"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "검은색",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "màu đen, màu mun",
                },
            new()
                {
                    Id = new Guid("BCE0799B-6653-4DB0-B4C6-E12958608F7C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "검정",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "màu đen",
                },
            new()
                {
                    Id = new Guid("D95765E6-F701-441B-B32C-7D598DDB1726"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "것",
                    Level = "Beginner",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "cái, điều",
                },
            new()
                {
                    Id = new Guid("490147C9-2120-4FD5-B4F0-DB25E6F868A7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "겉",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "bên ngoài, mặt ngoài",
                },
            new()
                {
                    Id = new Guid("5CE2F7CF-E3AB-44D1-B17F-D05EABB4B820"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "게으르다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "lười biếng",
                },
            new()
                {
                    Id = new Guid("6BD241DD-5083-4961-8B4E-63F20E54A825"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "게임",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "trò chơi",
                },
            new()
                {
                    Id = new Guid("BDD1E884-5EE8-4BAC-9AC2-2DD2A000F0E8"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "겨울",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "mùa đông",
                },
            new()
                {
                    Id = new Guid("54E7E541-6944-4154-BD55-743937F1C8C8"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "결과",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "kết quả",
                },
            new()
                {
                    Id = new Guid("27F178E1-3211-45F7-AC53-86BA1133ECF0"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "결석",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự vắng mặt",
                },
            new()
                {
                    Id = new Guid("DD085F7A-CE81-4BC9-82B1-239985800A85"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "결심",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quyết tâm, lòng quyết tâm",
                },
            new()
                {
                    Id = new Guid("D3A211E9-AD7E-433B-9356-D949B14ABEF7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "결정",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự quyết định, quyết định",
                },
            new()
                {
                    Id = new Guid("8DFFA73D-43AF-4AE7-9A26-9A43B51C7094"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "결혼",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "việc kết hôn",
                },
            new()
                {
                    Id = new Guid("D3E938D6-B91E-4F2E-ADBD-2BB256C6A3E1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "결혼식",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "lễ cưới, tiệc cưới",
                },
            new()
                {
                    Id = new Guid("B95B7657-5B69-46DC-9E22-DEC22B56419B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "결혼하다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "kết hôn, thành hôn, lập gia đình",
                },
            new()
                {
                    Id = new Guid("CDFAD4B6-9F52-4AD4-8A86-73F99BC67720"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "경기",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "tình hình kinh tế, nền kinh tế",
                },
            new()
                {
                    Id = new Guid("88EDEB0F-9901-41F0-9C79-EB2BE704A07D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "경복궁",
                    Level = "Beginner",
                    Type = "Proper Noun",
                    MeaningVietNamese = "Gyeongbok-gung, cung Cảnh Phúc",
                },
            new()
                {
                    Id = new Guid("72CF485B-CE59-4C91-BAA6-38D1FFFF33CA"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "경주",
                    Level = "Beginner",
                    Type = "Proper Noun",
                    MeaningVietNamese = "Gyeongju; Khánh Châu",
                },
            new()
                {
                    Id = new Guid("FF0C656F-1C84-4F1A-A8ED-014662ADAC34"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "경찰",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "(cơ quan) cảnh sát",
                },
            new()
                {
                    Id = new Guid("72EDEF32-3BE9-4B54-9267-6656688D3F96"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "경찰서",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "đồn cảnh sát",
                },
            new()
                {
                    Id = new Guid("6CD9D72D-6602-4E32-9EFB-04D8128FFAA6"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "경치",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "cảnh trí",
                },
            new()
                {
                    Id = new Guid("71308806-EA22-4DF8-83CF-7595E8B843C1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "경험",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "kinh nghiệm",
                },
            new()
                {
                    Id = new Guid("3CE19573-1CAC-47D6-B2B7-7037A8584398"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "계단",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "cầu thang, thang",
                },
            new()
                {
                    Id = new Guid("D061570D-46BF-4952-8ECE-6B20CBCE8920"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "계란",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "trứng gà",
                },
            new()
                {
                    Id = new Guid("88740988-8E04-4368-A20E-AE3EEECF2A54"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "계산",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "(sự) tính",
                },
            new()
                {
                    Id = new Guid("A0371CE5-D755-44C5-B3F2-C11FC19F4EC9"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "계속",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự liên tục",
                },
            new()
                {
                    Id = new Guid("F0805F82-957E-4114-813F-17BEA53EA3D1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "계속",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "sự liên tục",
                },
            new()
                {
                    Id = new Guid("3E8260B8-3888-4705-A402-6372D738F4E2"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "계시다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "ở (sống)",
                },
            new()
                {
                    Id = new Guid("36B08B29-E147-44C5-AEBD-EB6153AB6FBA"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "계시다",
                    Level = "Beginner",
                    Type = "Auxiliary",
                    MeaningVietNamese = "ở (sống)",
                },
            new()
                {
                    Id = new Guid("28B698F7-6785-488C-B9D2-AE0719196334"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "계절",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "mùa",
                },
            new()
                {
                    Id = new Guid("57104BC9-FC14-4F16-99F7-CB995A671D26"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "계획",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "kế hoạch",
                },
            new()
                {
                    Id = new Guid("19D0FF2D-8551-4AD4-AB1E-FC7857FFA9FE"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고개",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "cổ, gáy",
                },
            new()
                {
                    Id = new Guid("22C08416-D922-47EC-B10B-9323C07027E3"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고기",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "thịt",
                },
            new()
                {
                    Id = new Guid("828CA9B4-9B6F-40F1-8D85-6C775E941642"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고등학교",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "trường trung học phổ thông",
                },
            new()
                {
                    Id = new Guid("5DECD6EC-D1CE-4EBA-B896-3F25EBE34918"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고등학생",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "học sinh trung học phổ thông",
                },
            new()
                {
                    Id = new Guid("AC316C11-72B1-4833-A0B5-D9620F8580BB"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고르다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "chọn",
                },
            new()
                {
                    Id = new Guid("8565534E-6A3B-4EF7-9DE3-EFA939FD1C7A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고맙다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "cảm  ơn, biết ơn",
                },
            new()
                {
                    Id = new Guid("3FEBF80D-6EA0-49B5-85DE-E3FE0A28F411"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고모",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "cô",
                },
            new()
                {
                    Id = new Guid("84A5E986-8D12-4CA3-92F5-3AEB2F7BEEA7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고민",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự lo lắng, sự khổ tâm",
                },
            new()
                {
                    Id = new Guid("38B998A9-5533-4363-AD2E-83EC1AD89041"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고속버스",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "xe buýt cao tốc, xe buýt tốc hành",
                },
            new()
                {
                    Id = new Guid("D1F42F09-08C4-40D9-AFD5-B16D9C66BBF4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고양이",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "con mèo",
                },
            new()
                {
                    Id = new Guid("9E059080-773E-464C-9051-B7DAF6C392B4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고장",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quê quán, quê hương, vùng quê",
                },
            new()
                {
                    Id = new Guid("3FDB717E-F5BC-4125-89BA-A5E8CA4D9811"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고추장",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "Gochujang; tương ớt",
                },
            new()
                {
                    Id = new Guid("07D65067-526B-4E69-895D-410DE5FEAD55"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고치다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "sửa",
                },
            new()
                {
                    Id = new Guid("D3A93602-F505-43F8-B273-ACA8FBE8C93B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고프다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "đói bụng",
                },
            new()
                {
                    Id = new Guid("9F62EEF1-2D57-463E-94D4-812CAD766016"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "고향",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quê hương",
                },
            new()
                {
                    Id = new Guid("13EBCA3F-A69B-44BF-944B-16453367CA46"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "곧",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "ngay",
                },
            new()
                {
                    Id = new Guid("018E10CD-74A8-41C7-A865-357F7EB861D3"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "곳",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "nơi, chốn",
                },
            new()
                {
                    Id = new Guid("4D796795-3513-4EFF-AD79-308799F089D7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quả bóng, quả banh",
                },
            new()
                {
                    Id = new Guid("C1D970C8-47FA-4B02-8A40-A046E638E2BD"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공무원",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "công chức, viên chức",
                },
            new()
                {
                    Id = new Guid("CB0EC480-323F-4B0E-833D-8C0168F533C0"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공부",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "việc học, sự học",
                },
            new()
                {
                    Id = new Guid("B8B99131-6CE7-4BFC-A16B-77774E5D0BF3"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공부하다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "học, học tập, học hành",
                },
            new()
                {
                    Id = new Guid("6477E266-EAF7-4E6C-A61F-CDB289248412"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공원",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "công nhân",
                },
            new()
                {
                    Id = new Guid("80D355E9-B88E-4293-AA05-02A0921B1947"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공장",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "nhà máy, công xưởng, xưởng",
                },
            new()
                {
                    Id = new Guid("13DE8CD4-AA36-424F-8E70-625E14CC40C0"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공짜",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "miễn phí",
                },
            new()
                {
                    Id = new Guid("6B324AFC-92C3-41E1-BF24-2F4CCBBF2387"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공책",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quyển tập, quyển vở",
                },
            new()
                {
                    Id = new Guid("B6AEAA87-1181-4CCD-9B6B-DF5DA1B7FC81"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공항",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sân bay",
                },
            new()
                {
                    Id = new Guid("AC7E5EAD-C0EC-41CA-A933-4786FA172CA7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "공휴일",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "ngày lễ",
                },
            new()
                {
                    Id = new Guid("BE504CB1-CEAC-416C-B974-C7F9A0B1932B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "과거",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "khoa cử",
                },
            new()
                {
                    Id = new Guid("221F7ACE-416F-4FFA-B6D4-2110AD7AD703"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "과일",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "trái cây, hoa quả",
                },
            new()
                {
                    Id = new Guid("FC8794CF-5C7F-4247-AAD5-EFBB79046232"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "과자",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "bánh ngọt, bánh quy",
                },
            new()
                {
                    Id = new Guid("DB39DFE5-6EEC-4176-990C-676A2B53E64B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "관계",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "giới quan chức, giới công chức",
                },
            new()
                {
                    Id = new Guid("9AD2E956-D2CD-4778-9435-E4FEEA00317F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "관광",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự tham quan, chuyến du lịch",
                },
            new()
                {
                    Id = new Guid("D2531224-6489-4E6B-B56F-A27281711F0A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "관광객",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "khách tham quan, khách du lịch",
                },
            new()
                {
                    Id = new Guid("A901CBFA-50DD-4704-98B3-992E57F13E30"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "관광지",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "điểm tham quan, điểm du lịch",
                },
            new()
                {
                    Id = new Guid("A7EFD0F8-25BC-481C-8A50-A34F33DE3A6C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "관심",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "mối quan tâm",
                },
            new()
                {
                    Id = new Guid("E04D0A08-4887-4D3D-B4E2-7E5B44A145B6"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "광고",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự quảng bá, sự quảng cáo",
                },
            new()
                {
                    Id = new Guid("5EF6761C-D647-454B-9263-1DA60545CD04"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "광주",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "Gwangju; Quang Châu",
                },
            new()
                {
                    Id = new Guid("ED94CB3C-8EDD-4381-92B8-3B22CBB3874E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "괜찮다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "được",
                },
            new()
                {
                    Id = new Guid("D1A3C3E2-161C-4A9B-A765-6CBD0FA8607C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "괴로워하다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "đau buồn, đau đớn",
                },
            new()
                {
                    Id = new Guid("B1E6DAE1-E174-47B6-8C85-029B670C6C08"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교과서",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sách giáo khoa",
                },
            new()
                {
                    Id = new Guid("2FC21A63-3473-4475-BE01-B3F0C79A5E38"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교사",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "tòa nhà ở trường",
                },
            new()
                {
                    Id = new Guid("84EC938C-8DF4-45FC-B03B-CDCDD66BDA83"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교수",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "việc giảng dạy",
                },
            new()
                {
                    Id = new Guid("3DEBE94D-734F-485C-AC47-1A76AD6AF1C2"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교실",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "phòng học, lớp học",
                },
            new()
                {
                    Id = new Guid("769BB32B-97A3-4E4F-92AF-7F045772C518"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교육",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự giáo dục",
                },
            new()
                {
                    Id = new Guid("029CFD61-B489-4E4C-BD76-3F6E8E465D0D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교통",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "giao thông",
                },
            new()
                {
                    Id = new Guid("1B1C1EF4-FC1F-4E01-9590-6CE593FB769F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교통비",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "phí giao thông",
                },
            new()
                {
                    Id = new Guid("745CA68E-83E0-4CE8-8FDB-5A5B9BD720FE"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교통사고",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "tai nạn giao thông",
                },
            new()
                {
                    Id = new Guid("78AFC70C-63A5-4EBF-9D0F-461FE6D69C90"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교환",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự thay đổi, sự hoán đổi",
                },
            new()
                {
                    Id = new Guid("E798C89F-D497-4F3C-B1C5-7CCD33CC5358"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "교회",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "giáo hội, nhà thờ",
                },
            new()
                {
                    Id = new Guid("941B57B4-416B-4BDE-933B-BC47973A4509"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "구",
                    Level = "Beginner",
                    Type = "Determiner",
                    MeaningVietNamese = "từ ghép, cụm từ, mệnh đề",
                },
            new()
                {
                    Id = new Guid("F90F37F8-2692-4AB8-A0CB-54CDE3ADDE16"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "구",
                    Level = "Beginner",
                    Type = "Numeral",
                    MeaningVietNamese = "từ ghép, cụm từ, mệnh đề",
                },
            new()
                {
                    Id = new Guid("1AC59F9F-67DA-45E2-8C64-4FA1B08DE86E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "구경",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự ngắm nghía, sự nhìn ngắm",
                },
            new()
                {
                    Id = new Guid("7C6D7CE3-3781-44CD-BF80-40ECD320AE54"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "구두",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "giày",
                },
            new()
                {
                    Id = new Guid("8B323504-17BE-4490-81D0-68D7CD9F6C68"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "구름",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "đám mây",
                },
            new()
                {
                    Id = new Guid("0993D360-F8D5-4701-BE96-9FB1E21E6E40"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "구십",
                    Level = "Beginner",
                    Type = "Determiner",
                    MeaningVietNamese = "chín mươi, 90",
                },
            new()
                {
                    Id = new Guid("B05E2F4D-3E3B-4B58-BA80-BEAEA9B35BE9"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "구십",
                    Level = "Beginner",
                    Type = "Numeral",
                    MeaningVietNamese = "chín mươi, 90",
                },
            new()
                {
                    Id = new Guid("ACE7803D-ED58-4C93-8645-A94C22AEC58F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "구월",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "tháng chín",
                },
            new()
                {
                    Id = new Guid("6912755E-8A8D-4D4D-B40A-B2FFE916DC78"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "국",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "canh, món canh",
                },
            new()
                {
                    Id = new Guid("5F932802-CFB8-4ECB-BB4F-8A698AC31C91"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "국내",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quốc nội, trong nước, nội địa",
                },
            new()
                {
                    Id = new Guid("508B27F9-BE51-4ABE-8AE1-59BC4CE37461"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "국수",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "mì",
                },
            new()
                {
                    Id = new Guid("69EC13AE-6CD6-4636-8962-AF0E8D7AA33A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "국적",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quốc tịch",
                },
            new()
                {
                    Id = new Guid("FF8948BF-D8C5-4FA8-9DBE-DFC510339A3E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "국제",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quốc tế",
                },
            new()
                {
                    Id = new Guid("BC6C0344-7D2A-4802-9D75-D25DF16B471F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "군인",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quân nhân, bộ đội",
                },
            new()
                {
                    Id = new Guid("A51F7222-985E-4A20-82C6-17DB5FC81DBC"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "굳다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "đông, cứng",
                },
            new()
                {
                    Id = new Guid("2EC45826-A124-4174-85BC-D620B50ECC03"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "굳다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "đông, cứng",
                },
            new()
                {
                    Id = new Guid("513EA4B9-096F-455A-9326-55E1A60B4B36"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "굵다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "to, lớn, thô",
                },
            new()
                {
                    Id = new Guid("7EBE85D6-C682-436E-AFD0-811358CB1C0D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "굽다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "nướng",
                },
            new()
                {
                    Id = new Guid("97211386-3CCE-4B1D-8537-E9D2754AD9B7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "궁금하다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "tò mò",
                },
            new()
                {
                    Id = new Guid("982C4959-8E91-49EE-A779-5785E2B1D6A0"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "권",
                    Level = "Beginner",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "cuốn, quyển",
                },
            new()
                {
                    Id = new Guid("67D5AEEB-F037-4D79-A83D-304DC881D77C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "귀",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "tai",
                },
            new()
                {
                    Id = new Guid("1C1791E1-2070-4205-A905-228DF09487CF"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "귀걸이",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "hoa tai, bông tai, khuyên tai, vòng tai",
                },
            new()
                {
                    Id = new Guid("B2896CDF-7C15-4C40-BB36-284E54E36E33"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "귀여워하다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "yêu quý, yêu mến",
                },
            new()
                {
                    Id = new Guid("A24B6D95-35A4-40E5-8A2E-2D3A5E7CAD9B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "귀엽다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "dễ thương",
                },
            new()
                {
                    Id = new Guid("3E77B10B-F0CE-4B71-8A51-F0D82C4C90A1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "귀찮다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "phiền phức, bực mình",
                },
            new()
                {
                    Id = new Guid("AE89CC9A-4D86-48A4-A6A7-09C83122DAAD"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "규칙",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quy tắc",
                },
            new()
                {
                    Id = new Guid("4FCB4E7B-7478-46B4-944F-9616F2E5C856"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "귤",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "quả quýt",
                },
            new()
                {
                    Id = new Guid("A4BF413E-F3E3-42AE-8C46-661C33F8CA2C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그",
                    Level = "Beginner",
                    Type = "Determiner",
                    MeaningVietNamese = "người đó, anh (chị, ông, bà ...) ấy",
                },
            new()
                {
                    Id = new Guid("616D0662-03C7-4362-B093-514C411F7EEE"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그",
                    Level = "Beginner",
                    Type = "Pronoun",
                    MeaningVietNamese = "người đó, anh (chị, ông, bà ...) ấy",
                },
            new()
                {
                    Id = new Guid("1DDE4A81-6B0A-4B69-9208-0C81DE34C09D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그",
                    Level = "Beginner",
                    Type = "Interjection",
                    MeaningVietNamese = "người đó, anh (chị, ông, bà ...) ấy",
                },
            new()
                {
                    Id = new Guid("0330B00B-2CEE-4797-A619-1EEC83686BBE"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그거",
                    Level = "Beginner",
                    Type = "Pronoun",
                    MeaningVietNamese = "cái đó, cái đấy",
                },
            new()
                {
                    Id = new Guid("F3130D98-9D41-4169-8C11-6E5D51E8549E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그것",
                    Level = "Beginner",
                    Type = "Pronoun",
                    MeaningVietNamese = "cái đó",
                },
            new()
                {
                    Id = new Guid("E7A8B470-A894-46A9-946C-EBA207F35364"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그곳",
                    Level = "Beginner",
                    Type = "Pronoun",
                    MeaningVietNamese = "nơi đó, chỗ đó",
                },
            new()
                {
                    Id = new Guid("23BAF643-2818-4496-A6C5-5EFFA6C37E3C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그날",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "ngày đó, ngày ấy",
                },
            new()
                {
                    Id = new Guid("6B225791-111B-4B4D-B095-D0DAAA8F49CB"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그냥",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "cứ, chỉ",
                },
            new()
                {
                    Id = new Guid("B88EC85C-0971-489F-ABBF-74C5E794D997"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그대로",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "cứ vậy, đúng như",
                },
            new()
                {
                    Id = new Guid("190801B4-3B56-4099-9C07-C689EB674E8F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그동안",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "trong thời gian qua, trong khoảng thời gian đó",
                },
            new()
                {
                    Id = new Guid("27767F15-1B63-49E1-AB41-FFA010A0733B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그때",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "lúc đó, khi đó",
                },
            new()
                {
                    Id = new Guid("C037A0EE-0F8D-4E38-BA5B-A19AF08D46FA"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그래",
                    Level = "Beginner",
                    Type = "Interjection",
                    MeaningVietNamese = "vậy nhé, đúng vậy, vậy đấy",
                },
            new()
                {
                    Id = new Guid("E4D13420-F4C4-43A1-9426-CCA687661F22"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그래",
                    Level = "Beginner",
                    Type = "Abbreviated",
                    MeaningVietNamese = "vậy nhé, đúng vậy, vậy đấy",
                },
            new()
                {
                    Id = new Guid("F13E6504-F618-4DDD-8B81-D6E8D29CEE41"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그래서",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "vì vậy, vì thế, cho nên, thế nên",
                },
            new()
                {
                    Id = new Guid("16AD2A81-E63B-4F83-A188-60C6C7466D5B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그래서",
                    Level = "Beginner",
                    Type = "Abbreviated",
                    MeaningVietNamese = "vì vậy, vì thế, cho nên, thế nên",
                },
            new()
                {
                    Id = new Guid("EF33BBB6-791C-4D95-B502-4517C3221D47"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그러나",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "nhưng..., thế nhưng...",
                },
            new()
                {
                    Id = new Guid("5CFD71DA-58F4-4810-98D4-07F58E4509D4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그러니까",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "vì vậy, vì thế, bởi vậy",
                },
            new()
                {
                    Id = new Guid("6216A9C8-0D14-409A-894E-E52050779BA1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그러면",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "nếu vậy, như vậy, vậy thì",
                },
            new()
                {
                    Id = new Guid("7CDBA26D-DAB2-4300-9DA7-A6D45BF085E5"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그러므로",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "vì thế, do đó",
                },
            new()
                {
                    Id = new Guid("E3AECBAE-DAB6-44B6-BA29-626D3A7188D6"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그런",
                    Level = "Beginner",
                    Type = "Determiner",
                    MeaningVietNamese = "như vậy",
                },
            new()
                {
                    Id = new Guid("20E3A4C4-A7E3-4A2A-BE4B-6068B7F80093"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그런데",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "nhưng mà, thế nhưng",
                },
            new()
                {
                    Id = new Guid("7F308BF3-CD82-4454-8C72-9D7932ECE721"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그럼",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "nếu vậy thì",
                },
            new()
                {
                    Id = new Guid("7C0EEC00-E260-46DD-9798-FDE9487D1CA0"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그럼",
                    Level = "Beginner",
                    Type = "Interjection",
                    MeaningVietNamese = "nếu vậy thì",
                },
            new()
                {
                    Id = new Guid("E6221BF1-0C3E-491B-B965-14914E7B42D1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그렇다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "cũng vậy, cũng thế, như vậy, như thế",
                },
            new()
                {
                    Id = new Guid("977A7A11-F116-41AD-80CD-8DDF18CC5D86"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그렇지만",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "nhưng, tuy nhiên",
                },
            new()
                {
                    Id = new Guid("86327581-FD08-46AE-B810-D7898E05A6B3"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그릇",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "chén, bát, tô",
                },
            new()
                {
                    Id = new Guid("EB9873EF-66B0-4B6C-98D1-7504A88BD839"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그리고",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "và, với, với cả",
                },
            new()
                {
                    Id = new Guid("A086E63D-79AB-45A5-A021-A4A9D327DE10"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그리다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "nhớ nhung, thương nhớ",
                },
            new()
                {
                    Id = new Guid("417094FF-4A4D-45F8-B347-F8E8290882A6"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그림",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "tranh vẽ",
                },
            new()
                {
                    Id = new Guid("E7A0E214-6013-4458-A60D-75B055D6F54B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그립다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "mong nhớ, nhớ nhung",
                },
            new()
                {
                    Id = new Guid("52766436-E1A9-47A7-82DE-C23B450C8C8B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그만",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "chỉ thế, có thế",
                },
            new()
                {
                    Id = new Guid("E0CE46F4-D713-4E75-8340-E10E6E9A7B0A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그만두다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "bỏ dở, từ bỏ",
                },
            new()
                {
                    Id = new Guid("940F5176-43A5-4528-82F0-183EC99DCD68"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그분",
                    Level = "Beginner",
                    Type = "Pronoun",
                    MeaningVietNamese = "vị đó, vị kia",
                },
            new()
                {
                    Id = new Guid("E20671BE-7E96-4C89-A681-428936DE43D7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그저께",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "hôm kia",
                },
            new()
                {
                    Id = new Guid("910EBCA1-C851-4E61-B0A7-782068F1E9F7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그저께",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "hôm kia",
                },
            new()
                {
                    Id = new Guid("E11E10AA-E0D6-410F-ADD2-C368CC158AC4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그쪽",
                    Level = "Beginner",
                    Type = "Pronoun",
                    MeaningVietNamese = "hướng đó",
                },
            new()
                {
                    Id = new Guid("4C6F32C1-F4E3-492E-A208-9903E346B0EB"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "그치다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "dừng, ngừng, hết, tạnh",
                },
            new()
                {
                    Id = new Guid("117F69DD-9A2F-43DF-8B71-0CD4B56B94D6"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "극장",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "nhà hát",
                },
            new()
                {
                    Id = new Guid("7E079C85-5744-4BF0-AB8A-CAF53293ADC4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "근처",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "nơi gần",
                },
            new()
                {
                    Id = new Guid("204B4FC0-149A-4600-9346-7B9DCDC5A29E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "글",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "bài viết, đoạn viết, bài văn",
                },
            new()
                {
                    Id = new Guid("FCC2BD0D-AE6C-44EE-AD78-28BB04B09A99"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "글쎄",
                    Level = "Beginner",
                    Type = "Interjection",
                    MeaningVietNamese = "để xem, xem nào",
                },
            new()
                {
                    Id = new Guid("A48DF5AE-70B6-47FB-9598-C89164D7949D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "글쎄요",
                    Level = "Beginner",
                    Type = "Interjection",
                    MeaningVietNamese = "để xem đã..., xem nào...",
                },
            new()
                {
                    Id = new Guid("85F26C14-12FD-4120-A124-6149221D5699"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "글씨",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "chữ viết, nét chữ",
                },
            new()
                {
                    Id = new Guid("55C2BB8C-45E7-46BE-9141-0014D5F44B0F"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "글자",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "chữ viết, chữ",
                },
            new()
                {
                    Id = new Guid("5778159F-2F4F-4DA8-9218-2DEC7645C1CB"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "금방",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "vừa mới đây, vừa khi nãy",
                },
            new()
                {
                    Id = new Guid("F2BBD56E-E57C-4874-8CFD-9BAA057980A0"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "금요일",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "thứ Sáu",
                },
            new()
                {
                    Id = new Guid("85853903-FE22-47D7-832D-F55F10FA94C4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "금지",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "(sự) cấm chỉ, cấm đoán",
                },
            new()
                {
                    Id = new Guid("63DFBD0D-9938-4DEB-ACF9-FB18B7CE3E0C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "급",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "và, bên cạnh",
                },
            new()
                {
                    Id = new Guid("32E3EC45-402D-40F6-AD4B-F0BDF82C9644"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "급하다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "gấp, khẩn cấp",
                },
            new()
                {
                    Id = new Guid("FB65F739-E55C-46CB-B2C7-141CE0D4266A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기간",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "then chốt, trụ cột, rường cột",
                },
            new()
                {
                    Id = new Guid("D2770C40-B23D-4084-ADB5-FBBF26F25B9E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기다리다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "chờ đợi, đợi chờ, đợi, chờ",
                },
            new()
                {
                    Id = new Guid("D38D7951-BB00-4B4B-9DA7-2D5CD2CE2497"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기르다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "nuôi",
                },
            new()
                {
                    Id = new Guid("F969A834-CBA2-43B5-B335-41FE7B4BA588"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기름",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "dầu",
                },
            new()
                {
                    Id = new Guid("9ACEFD92-BE4D-469B-9743-A2FF3393693A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기말시험",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "kỳ thi cuối kỳ",
                },
            new()
                {
                    Id = new Guid("D1923A0F-ABE2-46B2-B0CD-243A8C34C2A6"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기분",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "tâm trạng",
                },
            new()
                {
                    Id = new Guid("1C6A2177-CC09-47A1-BF68-0EAF1B677C2D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기뻐하다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "vui mừng, vui sướng",
                },
            new()
                {
                    Id = new Guid("BDD550F2-4E22-4DD7-BBDD-3E51AABDEE14"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기쁘다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "vui",
                },
            new()
                {
                    Id = new Guid("E59BDF33-40B2-4F95-AD6D-56BD3E07A455"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기쁨",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "niềm vui",
                },
            new()
                {
                    Id = new Guid("2EDBF9F0-F29A-4663-A7FB-BF1F550FF5BD"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기숙사",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "ký túc xá",
                },
            new()
                {
                    Id = new Guid("570084D4-02E1-4FA8-AD99-788B71F9F6FD"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기억",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự ghi nhớ, trí nhớ",
                },
            new()
                {
                    Id = new Guid("340F19A7-6F2F-42F8-B1FE-E1560DCA82BC"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기억나다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "nhớ, nhớ ra",
                },
            new()
                {
                    Id = new Guid("5F08DCC0-93A9-4BD9-8844-90430A26608A"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기온",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "nhiệt độ thời tiết, nhiệt độ khí hậu, nhiệt độ không khí",
                },
            new()
                {
                    Id = new Guid("8B624893-62E4-4E6B-8596-497D362D39EC"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기자",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "ký giả, nhà báo, phóng viên",
                },
            new()
                {
                    Id = new Guid("865E1211-B41E-4289-A8A0-AC5EDB7F3DB1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기차",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "tàu hoả, xe lửa",
                },
            new()
                {
                    Id = new Guid("5DB03266-9D1E-4389-AF10-EC19CA236D7E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기차역",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "ga tàu hoả, ga xe lửa",
                },
            new()
                {
                    Id = new Guid("F3B919BC-137A-4085-A13A-0CE2180C8807"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기차표",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "vé tàu hoả, vé xe lửa",
                },
            new()
                {
                    Id = new Guid("B6933D08-B131-4827-9508-D20F756A6851"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기침",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự ho",
                },
            new()
                {
                    Id = new Guid("5A714159-85E7-4510-BE88-1FD1284BF0CE"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기타",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "khác, vân vân",
                },
            new()
                {
                    Id = new Guid("E102D679-8800-4BDF-B0B6-E68C1379E23C"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "기회",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "cơ hội",
                },
            new()
                {
                    Id = new Guid("BC6D39BE-734D-4EE7-B755-CA01820A37B5"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "긴장",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "sự căng thẳng",
                },
            new()
                {
                    Id = new Guid("6DA48F4E-4BA1-438A-8BFC-9AB60C050307"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "길",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "đường, con đường",
                },
            new()
                {
                    Id = new Guid("F52A48B8-CBBD-4036-9357-2EF47A18B382"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "길다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "mọc dài ra, dài ra",
                },
            new()
                {
                    Id = new Guid("7665E92C-20F7-4D49-B2F5-C87B31264911"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "길이",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "chiều dài",
                },
            new()
                {
                    Id = new Guid("B28133FD-BDEE-4208-969D-69A38DB82870"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "김",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "hơi, hơi nước",
                },
            new()
                {
                    Id = new Guid("8C6DF289-168A-44BB-9D8A-2CE0B63E25A1"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "김밥",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "Gimbap, món cơm cuộn rong biển",
                },
            new()
                {
                    Id = new Guid("7B62A186-AB1A-4F94-A98A-FEF06248503D"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "김치",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "kimchi",
                },
            new()
                {
                    Id = new Guid("407C6407-0A00-4512-A7B7-D3D5F60FE969"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "김치찌개",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "kimchijjigae; món canh kimchi",
                },
            new()
                {
                    Id = new Guid("9D55D82F-277A-44B0-82A0-D07B92D26CFF"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "깊다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "sâu",
                },
            new()
                {
                    Id = new Guid("0B2094BA-7837-4967-94D7-8F363475EFF7"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "깊이",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "độ sâu",
                },
            new()
                {
                    Id = new Guid("7195EF5C-9872-4E82-836E-CC42CD4F8CA4"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "까만색",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "màu đen",
                },
            new()
                {
                    Id = new Guid("888CE1E5-FB5E-4A5A-9C38-CD970B9A1311"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "까맣다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "đen ngòm, đen sì sì",
                },
            new()
                {
                    Id = new Guid("E386C203-BFDD-42A3-9296-5D21604AC140"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "깎다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "gọt",
                },
            new()
                {
                    Id = new Guid("3E562E03-5950-438B-8029-2F7DF864B8C8"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "깜짝",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "giật mình, hết hồn",
                },
            new()
                {
                    Id = new Guid("C51D6BCC-F78A-47E3-AD7F-17ADE815FD1B"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "깨끗이",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách sạch sẽ",
                },
            new()
                {
                    Id = new Guid("DB8E27D5-54F1-41E7-894B-7A3F3207EA51"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "깨끗하다",
                    Level = "Beginner",
                    Type = "Adjective",
                    MeaningVietNamese = "sạch sẽ",
                },
            new()
                {
                    Id = new Guid("EFB29AE7-1D73-48F4-8E02-DF402619E483"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "깨다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "tỉnh ra, tỉnh lại",
                },
            new()
                {
                    Id = new Guid("DCD47A9A-1318-4B05-A899-D30224645F5E"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "꺼내다",
                    Level = "Beginner",
                    Type = "Verb",
                    MeaningVietNamese = "rút ra, lôi ra, lấy ra",
                },
            new()
                {
                    Id = new Guid("4BEB911D-F6CD-4A9E-B938-2BE269977E84"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "껌",
                    Level = "Beginner",
                    Type = "Noun",
                    MeaningVietNamese = "kẹo cao su",
                },
            new()
                {
                    Id = new Guid("6A8966B7-369F-4FFB-AD68-34B00323CB84"),
                    LessonId = AppDbContext.LessonId1,
                    Word = "꼭",
                    Level = "Beginner",
                    Type = "Adverb",
                    MeaningVietNamese = "thật mạnh, thật chặt, thật chắc",
                },
            new()
                {
                    Id = new Guid("CC28F431-D08A-4736-9212-A6644BEF8ACB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가까워지다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trở nên gần, gần lại",
                },
            new()
                {
                    Id = new Guid("D46AA8BA-6F7A-418F-88CF-36AC0980DC6D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가까이",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "chỗ gần",
                },
            new()
                {
                    Id = new Guid("A0B04623-9378-4EEC-8017-7827FABB72BE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가까이",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "chỗ gần",
                },
            new()
                {
                    Id = new Guid("DF443457-25D9-4EB6-8BCB-9CB5B2E4A433"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가꾸다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "chăm sóc, cắt tỉa",
                },
            new()
                {
                    Id = new Guid("A5F3EC5F-AB1C-4922-91D7-DD648426F113"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가난",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự nghèo khó, cái nghèo",
                },
            new()
                {
                    Id = new Guid("4E936650-8850-4CFE-B943-9CAB714B30C0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가난하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "nghèo, nghèo khó",
                },
            new()
                {
                    Id = new Guid("F48FE003-BEAD-44FF-AE89-CF27011C84C5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가능",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khả dĩ, sự có thể",
                },
            new()
                {
                    Id = new Guid("BEA67C18-2171-4469-8B82-724F63A8F4A8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가능성",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tính khả thi",
                },
            new()
                {
                    Id = new Guid("C264047B-BB4C-4A3E-9412-3F76195BD294"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가능하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "khả dĩ, có thể",
                },
            new()
                {
                    Id = new Guid("91EDAB10-8F61-4CB3-A8AE-F24F62EF1040"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가득하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "đầy",
                },
            new()
                {
                    Id = new Guid("83334619-F54D-47C9-93EE-AEB63F869065"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가득히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "đầy",
                },
            new()
                {
                    Id = new Guid("69359C70-ABBC-4214-B1E0-88F3E2973FC9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가라앉다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "chìm, lắng",
                },
            new()
                {
                    Id = new Guid("6E39D89D-3FAD-43C0-97C0-52105975CBFD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가렵다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "ngứa",
                },
            new()
                {
                    Id = new Guid("55F2B90E-8F0C-4D18-98A9-BE59DEF897B5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가로",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "chiều ngang, khổ rộng",
                },
            new()
                {
                    Id = new Guid("72B1EBA6-374D-43B2-AC1C-1CFDBF27BB64"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가로",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "chiều ngang, khổ rộng",
                },
            new()
                {
                    Id = new Guid("903C6EBF-A289-44D1-9A3F-8F2D27269487"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가로등",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đèn đường",
                },
            new()
                {
                    Id = new Guid("51989373-3CAB-4E29-BD1A-441D7F2BC405"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가로막다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "chắn ngang, chặn ngang",
                },
            new()
                {
                    Id = new Guid("CC6511C3-500A-4DDD-B4E3-3D0ED081822D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가루",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bột",
                },
            new()
                {
                    Id = new Guid("5640589B-642B-4FF3-AF9D-30D191660B76"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가르다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "xẻ",
                },
            new()
                {
                    Id = new Guid("7FA840ED-1964-47F7-B177-AD8AC623CF86"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가리다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "che, che khuất",
                },
            new()
                {
                    Id = new Guid("96A74A1B-9601-4C10-8ECE-224C558D4E65"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가리다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "che, che khuất",
                },
            new()
                {
                    Id = new Guid("3852A4BB-E038-495A-ADA6-0C258A6C8F39"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가만",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách lặng lẽ, một cách lặng thinh",
                },
            new()
                {
                    Id = new Guid("5C66E769-BC4C-4EAA-A59A-CDFCF5AF1F74"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가만있다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "ở yên",
                },
            new()
                {
                    Id = new Guid("51A70614-D3D6-47E3-BCC3-182B5AF122C7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가만히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách lặng lẽ, một cách lặng thinh",
                },
            new()
                {
                    Id = new Guid("3DEE5BD8-2B3E-4671-B28A-946D5B80733C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가뭄",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "hạn hán",
                },
            new()
                {
                    Id = new Guid("CD954D2D-05C8-40B6-A5D2-7BAE2CCC8FF1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가사",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc nhà",
                },
            new()
                {
                    Id = new Guid("4069CBD0-A253-43A5-82D8-5E9DFF30BF8A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가스",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khí",
                },
            new()
                {
                    Id = new Guid("03304566-2576-4F10-991E-5AB6EE103683"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가스레인지",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bếp ga",
                },
            new()
                {
                    Id = new Guid("B0436D46-F3B5-4F1F-8586-CAB2D1DF2603"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가슴속",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "trong cõi lòng",
                },
            new()
                {
                    Id = new Guid("C735944E-F5A1-45FA-84A1-B3D7BC6F9E03"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가습기",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "máy tạo hơi ẩm",
                },
            new()
                {
                    Id = new Guid("FF1198A7-8359-41D4-9D95-A49D96445DE6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가이드",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "hướng dẫn viên",
                },
            new()
                {
                    Id = new Guid("85B9DE84-2D47-4341-865F-96B0E20BA719"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가입",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự gia nhập, sự tham gia",
                },
            new()
                {
                    Id = new Guid("2FF24714-FFE4-4A14-8EB6-160D73C04396"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가입자",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "người gia nhập, người tham gia",
                },
            new()
                {
                    Id = new Guid("6BE47A49-06D4-425F-AD2A-17953882006E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가장",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "người chủ gia đình",
                },
            new()
                {
                    Id = new Guid("3FD33806-C4D6-4FBC-AE73-F03ED14B76F6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가전제품",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sản phẩm điện gia dụng",
                },
            new()
                {
                    Id = new Guid("09282442-5429-474E-AEF8-76BDF9695941"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가정",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "gia đình, nhà",
                },
            new()
                {
                    Id = new Guid("44AA99C6-73CC-4B0C-A546-865256CD6789"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가정",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "gia đình, nhà",
                },
            new()
                {
                    Id = new Guid("D0C8B815-4FF5-4509-9FA1-5622B354262B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가정주부",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nội trợ gia đình",
                },
            new()
                {
                    Id = new Guid("14B986B3-4961-49C2-A48D-CBB555A3848F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가져다주다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "mang cho, đem cho",
                },
            new()
                {
                    Id = new Guid("B62B78D9-C775-45D5-B8CD-8F89D706C29D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가죽",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "da",
                },
            new()
                {
                    Id = new Guid("E66CDCD0-A80B-4953-9E29-5EF171E3A480"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가지",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cành",
                },
            new()
                {
                    Id = new Guid("2A12450B-852D-4318-A81F-F17E63DA80B6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가짜",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đồ giả, thứ giả",
                },
            new()
                {
                    Id = new Guid("B2609092-FB5A-4C77-A9A3-E90A7AB42937"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가치",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "giá trị",
                },
            new()
                {
                    Id = new Guid("23412B19-3A81-49BA-8ED9-0D218792D8ED"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가치관",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "giá trị quan",
                },
            new()
                {
                    Id = new Guid("F8BEF673-2426-4A7F-912E-5E62CE3561E7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "가톨릭",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đạo Thiên Chúa, tín đồ đạo Thiên Chúa",
                },
            new()
                {
                    Id = new Guid("55600BF0-0449-49ED-9AC2-D5392A1E9DE5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "각",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "góc",
                },
            new()
                {
                    Id = new Guid("96C877F9-7B83-410A-89E2-01DDD1F6054E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "각국",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "mỗi nước, mỗi quốc gia, từng quốc gia",
                },
            new()
                {
                    Id = new Guid("174B95D8-33C7-469D-A4FB-7A50DF26EAF8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "각오",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự giác ngộ, sự nhận thức",
                },
            new()
                {
                    Id = new Guid("93201C92-34B8-4489-84DB-D74D68BF3D31"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "각자",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "từng người, bản thân mỗi người",
                },
            new()
                {
                    Id = new Guid("7931FF53-6729-4811-A3A2-13C3123E7457"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "각자",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "từng người, bản thân mỗi người",
                },
            new()
                {
                    Id = new Guid("B71093D1-AA9F-4CAC-8712-33A3ED690F96"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "각종",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "các loại, các thứ",
                },
            new()
                {
                    Id = new Guid("7E40E19C-B4A1-460E-A4E8-56261C3946EE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "mắm muối, gia vị tạo vị mặn",
                },
            new()
                {
                    Id = new Guid("19181D51-98DE-476D-BB57-43FF92EF0083"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "mắm muối, gia vị tạo vị mặn",
                },
            new()
                {
                    Id = new Guid("F2130BED-3B55-4F21-9991-0B0D12ED380D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간",
                    Level = "Intermediate",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "mắm muối, gia vị tạo vị mặn",
                },
            new()
                {
                    Id = new Guid("9F0075E4-B624-480A-A5BC-5E8DBBDA76E1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간격",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "giãn cách",
                },
            new()
                {
                    Id = new Guid("C5506B69-B88C-4BD5-B07C-67BCD599DB15"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간섭",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự can thiệp",
                },
            new()
                {
                    Id = new Guid("E3756D5B-F886-4426-A244-7ABD5D5BA820"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간신히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách chật vật, họa hoằn lắm mới",
                },
            new()
                {
                    Id = new Guid("751239DA-B23A-4030-A3E7-525E89E3C063"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간절하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "khẩn thiết",
                },
            new()
                {
                    Id = new Guid("991E4C03-8A01-4FE8-AC30-C12F1027F908"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간접적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "tính gián tiếp",
                },
            new()
                {
                    Id = new Guid("8EC9BDD7-8588-4370-8469-24B7A2A2F4A4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간접적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tính gián tiếp",
                },
            new()
                {
                    Id = new Guid("29639DCF-1D8E-4089-9FC9-3583900507DE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간지럽다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "nhột",
                },
            new()
                {
                    Id = new Guid("168C28AE-7454-4196-A8BF-A7FACB6AB488"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간판",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bảng hiệu",
                },
            new()
                {
                    Id = new Guid("6217D340-0088-4D13-B52B-0C29EBC6A956"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간편하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "giản tiện",
                },
            new()
                {
                    Id = new Guid("8A060709-F0CE-4A87-9C39-D3A19A9A968F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간호",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự điều dưỡng, sự chăm bệnh",
                },
            new()
                {
                    Id = new Guid("3C02DCFB-A8A6-4419-A7B8-D0FCF7E9CF6A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간혹",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "thi thoảng, thỉnh thoảng",
                },
            new()
                {
                    Id = new Guid("0775124A-2A2A-4836-B33F-3E8BC7D94E36"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "간혹",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "thi thoảng, thỉnh thoảng",
                },
            new()
                {
                    Id = new Guid("E000E84B-7A5E-454F-964E-140F50D6A60F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갇히다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "bị nhốt, bị giam, bị trói buộc",
                },
            new()
                {
                    Id = new Guid("65F54A84-F3C2-45CD-BDA6-8778B47788BD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갈다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "thay",
                },
            new()
                {
                    Id = new Guid("B56707DE-FE62-4CCF-ACF2-EE63E33605F4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갈다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "thay",
                },
            new()
                {
                    Id = new Guid("9CF90B9E-BC10-4AB3-A674-F1AFDDE04A44"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갈등",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự bất đồng, sự căng thẳng",
                },
            new()
                {
                    Id = new Guid("FBE9E4B3-9B56-4B01-9887-3C1B5A4AA2E5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갈라지다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "bị nứt, bị nẻ, bị rạn",
                },
            new()
                {
                    Id = new Guid("389E898C-73CD-4467-8975-F66DD3998D76"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갈수록",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "ngày càng, càng lúc càng, càng ngày càng",
                },
            new()
                {
                    Id = new Guid("3349C91D-EA45-4236-BAC8-4258CF59150B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갈증",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "chứng khát, sự khát  nước",
                },
            new()
                {
                    Id = new Guid("04F7F648-0CC3-469E-A7D1-47612CE1B0A8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감각",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cảm giác",
                },
            new()
                {
                    Id = new Guid("E97F3D20-AC6D-420F-8683-35905E8F064C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "nhắm (mắt)",
                },
            new()
                {
                    Id = new Guid("0C428FD3-B8C6-478B-84C4-3E4071630BE6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감독",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự giám sát",
                },
            new()
                {
                    Id = new Guid("138153C4-66BA-4C27-8BA9-5684EE4514A4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감동",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cảm động",
                },
            new()
                {
                    Id = new Guid("4216D637-003B-4921-B46D-BFFD283C93F6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감동적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "tính cảm động, tính xúc động",
                },
            new()
                {
                    Id = new Guid("77B2DF84-EEE8-40EA-8ABC-BA01D9DC6C7A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감동적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tính cảm động, tính xúc động",
                },
            new()
                {
                    Id = new Guid("B31790DF-04E6-4C24-8B16-F3E486601780"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감상",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cảm thương, sự đa cảm",
                },
            new()
                {
                    Id = new Guid("BD9254FB-B939-4281-B559-AEB7D6821A4D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감상문",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bài cảm tưởng, bài cảm thụ",
                },
            new()
                {
                    Id = new Guid("CED2595E-2FC0-4849-90CF-AE64DEB10163"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감상하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "cảm thụ, thưởng ngoạn, thưởng thức",
                },
            new()
                {
                    Id = new Guid("5C5F454C-F8BE-4757-8D5B-DD6B8D8EBC59"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감소",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự giảm bớt, sự cắt giảm",
                },
            new()
                {
                    Id = new Guid("FC639284-42E9-467B-84DC-A3D2AC05A897"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감시",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự giám sát",
                },
            new()
                {
                    Id = new Guid("4F21A010-C77D-41B5-9CCB-4C44FF95E118"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감싸다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "quấn quanh, quấn kín",
                },
            new()
                {
                    Id = new Guid("D5B30076-A669-4A62-91D5-C2A0D0B80E94"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감옥",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nhà tù, nhà giam, nhà lao",
                },
            new()
                {
                    Id = new Guid("BF15285D-FD5A-4A1B-B73D-AAB4A1CA752E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감정",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tình cảm, cảm xúc",
                },
            new()
                {
                    Id = new Guid("9FB8B534-978B-4799-BDFE-08F5DEE10456"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감추다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "giấu, giấu giếm, che giấu",
                },
            new()
                {
                    Id = new Guid("525C024D-6968-4C32-AF5F-EA6D8B2A859A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "감히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "dám",
                },
            new()
                {
                    Id = new Guid("2861F84E-F8B7-414B-AAC5-1496EA1ED976"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갑작스럽다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "bất ngờ, đột ngột, bỗng dưng",
                },
            new()
                {
                    Id = new Guid("BF509226-87E2-47D5-9CAA-7BEA1D77B0AA"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "값싸다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "giá rẻ, rẻ",
                },
            new()
                {
                    Id = new Guid("361891AD-A66D-4E90-9C68-8201871FE279"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강당",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "giảng đường",
                },
            new()
                {
                    Id = new Guid("0C6015B5-7534-4BF7-8D02-1911659BEF27"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강도",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "độ bền, độ vững chắc",
                },
            new()
                {
                    Id = new Guid("5C541F19-2B7A-4C4A-B6A2-F570E5A6D28E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강물",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nước sông",
                },
            new()
                {
                    Id = new Guid("97BBA0DA-A7DD-4ABA-9B53-50FA85242C23"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강사",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "giảng viên, người thuyết trình",
                },
            new()
                {
                    Id = new Guid("9A54301B-2EBF-4A6C-92CE-CF36DFB9AA45"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강수량",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "lượng mưa",
                },
            new()
                {
                    Id = new Guid("E372F71C-415E-4CA5-8154-1797A7959D30"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강요",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cưỡng ép, sự ép buộc, sự bắt buộc",
                },
            new()
                {
                    Id = new Guid("516AAAF6-0A01-4D22-8C05-FF3AB225BB54"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강원도",
                    Level = "Intermediate",
                    Type = "Proper Noun",
                    MeaningVietNamese = "Gangwon-do, tỉnh Gangwon",
                },
            new()
                {
                    Id = new Guid("3D66CCCD-B26B-4D88-92B4-4B3A0FB514DA"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강의",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc giảng dạy",
                },
            new()
                {
                    Id = new Guid("805B5817-E875-45F7-985F-2FE469E7BF4C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강의실",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "giảng đường",
                },
            new()
                {
                    Id = new Guid("AE139825-DD5B-4D46-BBE8-B158811940E2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강제",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cưỡng chế, sự bắt ép",
                },
            new()
                {
                    Id = new Guid("201DD4EB-E4A0-416B-A09F-48B1DC2E8922"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강조",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khẳng định, sự nhấn mạnh",
                },
            new()
                {
                    Id = new Guid("C4D83F53-F5F0-4564-82E6-E018A4CF2881"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "강조하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "khẳng định, nhấn mạnh",
                },
            new()
                {
                    Id = new Guid("976E31AC-48DA-4A44-8312-D9FA6BF6DB67"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갖가지",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "các loại",
                },
            new()
                {
                    Id = new Guid("DC067CA0-5AA2-4C3C-AD54-FFAD03C080D9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갖다",
                    Level = "Intermediate",
                    Type = "Auxiliary",
                    MeaningVietNamese = "mang, cầm",
                },
            new()
                {
                    Id = new Guid("37475387-62A7-4105-85DC-CD18DB0E29E0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "갖추다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trang bị",
                },
            new()
                {
                    Id = new Guid("9C0CDB48-BE6D-4BD5-B22B-422943706A41"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개구리",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "con ếch",
                },
            new()
                {
                    Id = new Guid("D878B9EA-B93D-4A23-8A10-BE7F76AC3739"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개나리",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cây hoa ge-na-ri, cây đầu xuân, hoa ge-na-ri, hoa đầu xuân",
                },
            new()
                {
                    Id = new Guid("045C127F-E36E-45CA-97F2-3119017FEDC0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개념",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khái niệm",
                },
            new()
                {
                    Id = new Guid("0C3E4AD7-C588-4225-B051-F336AB3300EE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trời quang",
                },
            new()
                {
                    Id = new Guid("66AE2931-684B-4E04-89A9-0578B60C40FE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trời quang",
                },
            new()
                {
                    Id = new Guid("FA4DBB86-DE52-4FA6-A75B-44837943E153"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개미",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "con kiến",
                },
            new()
                {
                    Id = new Guid("5056E0CB-9F30-4B84-85C6-73DB4CB52417"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개발",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khai khẩn, sự khai thác",
                },
            new()
                {
                    Id = new Guid("F78CE54F-B588-4813-94CA-AD4B7D6A732B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개발하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "khai khẩn, khai thác",
                },
            new()
                {
                    Id = new Guid("2B37ECD4-9CA9-4DC9-B376-AD02C838C7D0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개방",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự mở ra",
                },
            new()
                {
                    Id = new Guid("6626CC17-8556-4458-8392-C0146046C0E7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개별",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "riêng biệt, riêng lẻ, riêng",
                },
            new()
                {
                    Id = new Guid("AE3F2A01-85D3-42F8-9165-206A7F833D11"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개선",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cải tiến, sự cải thiện",
                },
            new()
                {
                    Id = new Guid("2D0E5322-65B4-43AF-892D-CD381C7527D7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개성",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cá tính",
                },
            new()
                {
                    Id = new Guid("0903209D-7D51-4BCE-8A19-517A42B898B2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개인",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cá nhân",
                },
            new()
                {
                    Id = new Guid("D89E9D66-F48D-495D-910F-97638B6EF4D2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개인적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "sự riêng tư, cá nhân",
                },
            new()
                {
                    Id = new Guid("9BBFD426-A4C1-4F72-84BB-8FB34748EDF5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개인적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự riêng tư, cá nhân",
                },
            new()
                {
                    Id = new Guid("0DD55F86-DAFB-4EFE-9AD8-48C8E0E7F555"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개최",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc tổ chức",
                },
            new()
                {
                    Id = new Guid("4A86FEB0-B80A-41D0-9601-A8EEC7600E08"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "개혁",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cải cách, đổi mới",
                },
            new()
                {
                    Id = new Guid("080E2B57-4C5A-46A0-9484-3C008394720B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "객관적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "tính khách quan",
                },
            new()
                {
                    Id = new Guid("43815666-1197-4F9A-BCB9-C293EE92F0C9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "객관적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tính khách quan",
                },
            new()
                {
                    Id = new Guid("249CB3D9-7DBE-4DDD-8E6C-3C5D899D2408"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "걔",
                    Level = "Intermediate",
                    Type = "Abbreviated",
                    MeaningVietNamese = "đứa đó",
                },
            new()
                {
                    Id = new Guid("74DB9488-57BD-46BE-97EE-F7FC8D26949B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거꾸로",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "ngược lại",
                },
            new()
                {
                    Id = new Guid("A35E7A67-C033-4F2B-98CF-AB2CA8962616"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거대",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự to lớn",
                },
            new()
                {
                    Id = new Guid("81FC34B5-F29C-4390-8074-BC2D7190BECF"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거두다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "thu dọn, thu gom",
                },
            new()
                {
                    Id = new Guid("BAAD7099-0823-4F94-A434-1E5CE8A63406"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거들다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "đỡ đần, giúp việc",
                },
            new()
                {
                    Id = new Guid("D848CDC2-21EC-4B0C-BF30-803212BFACE7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거래",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự giao dịch",
                },
            new()
                {
                    Id = new Guid("421FFA80-AE22-46A4-B8FA-C0F6B76D3F19"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거래처",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khách hàng, người giao dịch",
                },
            new()
                {
                    Id = new Guid("77BDD876-C1F7-41A9-B918-0A25BDC501A6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거리",
                    Level = "Intermediate",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "con phố",
                },
            new()
                {
                    Id = new Guid("25CF957A-A52E-45E7-BF2F-97D24F4B283C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거미",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "con nhện",
                },
            new()
                {
                    Id = new Guid("7DA0AEEE-A5C9-43F2-B2FB-8040A0E66EBD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거북이",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "con rùa",
                },
            new()
                {
                    Id = new Guid("78F66714-25C1-4C81-84B3-740959BF43E0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거스름돈",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tiền thối lại, tiền trả lại",
                },
            new()
                {
                    Id = new Guid("B38A0548-9EAC-40D1-B149-6406DE24210B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거지",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "người ăn xin, người ăn mày",
                },
            new()
                {
                    Id = new Guid("6C544A03-99B0-4581-A331-77CE1D1E28F5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거짓",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự dối trá, sự giả dối",
                },
            new()
                {
                    Id = new Guid("A1E7A61A-356E-40CC-B485-0B523CC5AE3E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거치다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "vướng vào, mắc vào",
                },
            new()
                {
                    Id = new Guid("26833CF9-BC7F-4327-B7B4-0B641B3E9E65"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거칠다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "sần sùi",
                },
            new()
                {
                    Id = new Guid("C1B05DE7-C951-4B8D-8ED4-11F0CBDCB32C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "거품",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bọt",
                },
            new()
                {
                    Id = new Guid("6DBE5046-53F0-45AE-8C59-AA362E665B7F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "걱정되다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trở nên lo lắng",
                },
            new()
                {
                    Id = new Guid("CDAAB96D-9A46-40DA-89E8-FCC778612948"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "걱정스럽다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "lo lắng",
                },
            new()
                {
                    Id = new Guid("60BA2F99-77A4-4CDF-991E-0BEC287EF7D1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건너",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "phía đối diện",
                },
            new()
                {
                    Id = new Guid("39C35EA8-D1D6-4CE9-ADBF-FB6BF44D5013"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건너오다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "qua",
                },
            new()
                {
                    Id = new Guid("9A40AC5F-CB28-441C-B0CA-12D81ADDB37B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건널목",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "lối qua đường, đường ngang dân sinh",
                },
            new()
                {
                    Id = new Guid("7F154AAA-70BF-468C-933F-E04E4D05EC43"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건네다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trao, đưa",
                },
            new()
                {
                    Id = new Guid("681C71D3-A0B8-4F77-9DC6-20F5A1D06E2A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건네주다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trao cho, chuyển cho",
                },
            new()
                {
                    Id = new Guid("5ED78CC4-07BD-45F0-927F-DB1BC024947C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건드리다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "chạm, đụng",
                },
            new()
                {
                    Id = new Guid("9D5D06B0-05CE-40C2-B58F-A50F376B8AC1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건설",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự xây dựng",
                },
            new()
                {
                    Id = new Guid("E69830D6-5B0D-485E-B579-05E6D797876F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건전지",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "pin, viên pin, cục pin",
                },
            new()
                {
                    Id = new Guid("95C06258-01B1-4D1E-9CA8-04B586DFA1EA"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건조",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự kiến thiết, sự kiến tạo",
                },
            new()
                {
                    Id = new Guid("62364BDF-807F-4E9F-8BBB-5A820E33C429"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건지다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "vớt ra",
                },
            new()
                {
                    Id = new Guid("608B8B09-50E8-44D1-93F7-3D530FDBD42C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "건축",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc kiến trúc, việc kiến thiết",
                },
            new()
                {
                    Id = new Guid("39D283CB-87F3-4CF9-96F1-B030109E58C3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "걷다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "tan",
                },
            new()
                {
                    Id = new Guid("6D3F6E9E-D6E0-4D4B-B448-A0E0C81AC066"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "걷다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "tan",
                },
            new()
                {
                    Id = new Guid("4C654F0D-82E6-42B1-8362-1DF4DEDB8A2D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "걸레",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "giẻ lau",
                },
            new()
                {
                    Id = new Guid("D6397453-F70F-4AC7-BB74-4165ECFE8544"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "걸치다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "lơ lửng",
                },
            new()
                {
                    Id = new Guid("A7FD0040-ED51-419E-BB9F-BC7FF42EC67D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "검다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "đen",
                },
            new()
                {
                    Id = new Guid("CF579932-FFE5-45B8-8C07-D18035A08D97"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "검사",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kiểm sát viên, công tố viên",
                },
            new()
                {
                    Id = new Guid("8EACCCA9-0F10-40CF-B739-97FF66FBF2AC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "검색",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự tra xét, sự khám xét",
                },
            new()
                {
                    Id = new Guid("AC113DAC-A7A2-47FF-A425-94083F947A08"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "검정색",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "màu đen",
                },
            new()
                {
                    Id = new Guid("D21F8B8E-C632-4295-AE4F-08AF6217DEA2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "검토",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "xem xét",
                },
            new()
                {
                    Id = new Guid("72C182C2-871C-412B-BB1C-1D6217BB33E4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "겁",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nỗi sợ",
                },
            new()
                {
                    Id = new Guid("721922C4-ADCE-4F5C-8894-76967AFA94E3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "겁나다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "sợ hãi",
                },
            new()
                {
                    Id = new Guid("96E3CE17-4738-476E-B142-E4675ADADDD4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "겉모습",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "vẻ ngoài, bề ngoài",
                },
            new()
                {
                    Id = new Guid("63A6151C-F256-497F-9537-323E881FA55B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "겉옷",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "áo ngoài",
                },
            new()
                {
                    Id = new Guid("DBCD9B34-051F-4A2C-811D-C6F72440B43F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "게",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "con cua, con ghẹ",
                },
            new()
                {
                    Id = new Guid("05DF18E7-81E4-4D45-BBF6-A99A8C9F604A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "게다가",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "hơn nữa, vả lại, thêm nữa",
                },
            new()
                {
                    Id = new Guid("2CB30C81-3D34-44D2-BCBB-43A637E8D3BB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "게시",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự đưa lên, sự dán lên, sự công bố ra",
                },
            new()
                {
                    Id = new Guid("3A5D7E76-C5D9-4A43-BAB5-85EA8C143033"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "게시판",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bảng thông báo",
                },
            new()
                {
                    Id = new Guid("B1B5447D-C878-4E46-987C-AA92BFC55463"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "겨우",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách khó khăn, một cách chật vật",
                },
            new()
                {
                    Id = new Guid("3AB0498B-90E9-4DC5-B270-01A12878EAC2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "겨울철",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "mùa đông",
                },
            new()
                {
                    Id = new Guid("37E69292-FC1D-44D7-928F-110313B01E83"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "격려",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khích lệ, sự động viên, sự khuyến khích, sự cổ vũ",
                },
            new()
                {
                    Id = new Guid("CFA6234C-BB08-4C91-B959-5C6E65D746C6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "겪다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trải qua, trải nghiệm",
                },
            new()
                {
                    Id = new Guid("C0D4E9FE-A5F4-41B6-BC40-0BCD5AE68C07"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "견디다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "chịu đựng, cầm cự",
                },
            new()
                {
                    Id = new Guid("6FDE6706-261C-4C53-8B3A-DF1A8B4FE5E7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "견학",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự kiến tập, sự đi thực tế",
                },
            new()
                {
                    Id = new Guid("2B736484-9AC5-411B-A8B5-45083B0B56F0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "견해",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quan điểm, cái nhìn, cách nhìn nhận",
                },
            new()
                {
                    Id = new Guid("318173B7-6F75-442B-B8BC-EED0570D2F56"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결국",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đoạn kết, phần kết, sự kết thúc",
                },
            new()
                {
                    Id = new Guid("F8FA50D6-88DD-4D54-A4EF-C5512E622E8D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결국",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "đoạn kết, phần kết, sự kết thúc",
                },
            new()
                {
                    Id = new Guid("D8409380-5CCB-4773-A485-199D1A1395B5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결근",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự nghỉ làm",
                },
            new()
                {
                    Id = new Guid("2CE9B16E-7CFC-4080-81A0-5789D783E374"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결론",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kết luận",
                },
            new()
                {
                    Id = new Guid("D29B574C-875E-4935-AE1D-8B1DED5C96A4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결승",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự phân thắng bại",
                },
            new()
                {
                    Id = new Guid("83B82084-9BD8-4A4B-BC3F-0886A84C4A70"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결심하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "quyết tâm",
                },
            new()
                {
                    Id = new Guid("FF79070E-E49A-444C-9B4F-6C7D53F7053D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결정되다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "được quyết định",
                },
            new()
                {
                    Id = new Guid("400E1783-57C8-45CF-BC7B-F6E2977C5E18"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결정하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "quyết định",
                },
            new()
                {
                    Id = new Guid("D39DBBCD-351D-450C-9CF4-F53484340D02"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결제",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự thanh toán",
                },
            new()
                {
                    Id = new Guid("A83452D8-D4CB-44CF-9AF0-8F7BDC5E3F97"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결코",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "tuyệt đối",
                },
            new()
                {
                    Id = new Guid("3317D841-7FCC-481E-AF45-D1DC5A4696EF"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결합",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự kết hợp, sự hoà hợp, sự hợp nhất",
                },
            new()
                {
                    Id = new Guid("7361D407-B96D-4E4A-8A03-302D45B50228"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "결혼식장",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nhà hàng tiệc cưới",
                },
            new()
                {
                    Id = new Guid("8882473F-DB29-4ADE-92B7-2601CBF3515F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "겸손",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khiêm tốn",
                },
            new()
                {
                    Id = new Guid("A3DA7AA7-3E91-478E-8BED-1EC340CBB112"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "겹치다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "bị chồng lên, bị chất lên, bị trùng lặp",
                },
            new()
                {
                    Id = new Guid("8E411A56-3D17-479A-8440-992D867ABFAD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경계",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "ranh giới, biên giới",
                },
            new()
                {
                    Id = new Guid("502F6842-57CA-4A5B-A956-BB9D8EB616F4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경고",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cảnh báo",
                },
            new()
                {
                    Id = new Guid("91533595-E024-4F44-B318-ED9433546E47"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경기",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tình hình kinh tế, nền kinh tế",
                },
            new()
                {
                    Id = new Guid("A9E0D9C5-77E4-4B62-ABAF-FEFB8B03F375"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경기도",
                    Level = "Intermediate",
                    Type = "Proper Noun",
                    MeaningVietNamese = "Gyeonggi-do; tỉnh Gyeonggi",
                },
            new()
                {
                    Id = new Guid("60CB275B-DEA2-492F-816B-E7109E7934D3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경기장",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sân vận động, trường đua, đấu trường",
                },
            new()
                {
                    Id = new Guid("3BDF60F7-0DCC-4C56-8518-9671FE8AA0B8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경력",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kinh nghiệm",
                },
            new()
                {
                    Id = new Guid("5A6ABC72-2B3D-4ED3-8036-3986D4860CDD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경복궁",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "Gyeongbok-gung, cung Cảnh Phúc",
                },
            new()
                {
                    Id = new Guid("1E7E2875-2F76-411A-AB2B-BAA109E6EA64"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경비",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kinh phí",
                },
            new()
                {
                    Id = new Guid("7842C9F6-CB4B-4BE7-81BB-14AB90E2E6BB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경비실",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "phòng bảo vệ, phòng canh gác",
                },
            new()
                {
                    Id = new Guid("EB1DE2A8-DEE0-44B2-825B-E251E80C5A9A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경상도",
                    Level = "Intermediate",
                    Type = "Proper Noun",
                    MeaningVietNamese = "Gyeongsang-do, tỉnh Gyeongsang",
                },
            new()
                {
                    Id = new Guid("CEF6D6A7-E83A-4C7D-B53D-6E158300C8E2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경영",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc kinh doanh, sự kinh doanh",
                },
            new()
                {
                    Id = new Guid("DD3E24AB-8381-4743-ABA1-BF0B6B3AEBFD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경우",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đạo lý, sự phải đạo",
                },
            new()
                {
                    Id = new Guid("6405DA79-38FC-4607-BC49-DB5C77A457D9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경우",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đạo lý, sự phải đạo",
                },
            new()
                {
                    Id = new Guid("4A881FEC-A750-435B-A1F4-B1E639523F6E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경쟁",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cạnh tranh",
                },
            new()
                {
                    Id = new Guid("FA56B610-0B38-427B-BDC4-F03C6743D017"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경쟁력",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sức cạnh tranh",
                },
            new()
                {
                    Id = new Guid("D396368E-162C-4E96-B6DF-E9D628C9F713"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경제",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kinh tế, nền kinh tế",
                },
            new()
                {
                    Id = new Guid("387FAF2E-D844-48A7-8904-B6D215343E66"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경제력",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "năng lực kinh tế",
                },
            new()
                {
                    Id = new Guid("EFFE9A95-1EB9-4259-9826-B89850E01B25"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경제적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "tính kinh tế, mặt kinh tế",
                },
            new()
                {
                    Id = new Guid("67C47D72-FA89-4898-B26F-73691A36DDA7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경제적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tính kinh tế, mặt kinh tế",
                },
            new()
                {
                    Id = new Guid("2960C924-3CBD-476C-B31B-43087A81C5B1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경찰관",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "viên cảnh sát",
                },
            new()
                {
                    Id = new Guid("43CD58E1-CE6B-48C2-95FF-D2DE498304AA"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경향",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khuynh hướng, xu hướng",
                },
            new()
                {
                    Id = new Guid("F8E728DC-01A8-452E-A768-20C8C08F0B08"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "경험하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trải nghiệm, kinh qua",
                },
            new()
                {
                    Id = new Guid("6F5D1907-323E-41BA-9AAE-4ED08DA04D34"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곁",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kề bên, bên cạnh",
                },
            new()
                {
                    Id = new Guid("C3C20FDA-869C-4046-9A3F-5280429844FD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계곡",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "thung lũng",
                },
            new()
                {
                    Id = new Guid("73A807B9-BF23-4A64-890E-0DA8C39492F0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계기",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bước ngoặt, dấu mốc, mốc",
                },
            new()
                {
                    Id = new Guid("FE26EFBB-9F41-4CA5-8872-48C0396DC58E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계산기",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "máy tính",
                },
            new()
                {
                    Id = new Guid("22E410E0-1E44-4029-B2E3-43DC7E1A74ED"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계산대",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quầy tính tiền, quầy thu ngân",
                },
            new()
                {
                    Id = new Guid("7072BC08-87C4-43D3-8A5E-44D79628F762"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계산하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "tính",
                },
            new()
                {
                    Id = new Guid("70821D93-54BD-48CA-BD5C-DE26E528726D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계속되다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "được liên tục",
                },
            new()
                {
                    Id = new Guid("7AECB41D-5722-47D1-A603-BAF0B88E7A16"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계속하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "liên tục",
                },
            new()
                {
                    Id = new Guid("FD624529-6007-4344-9838-54E5629E672B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계약",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc lập khế ước, việc hợp đồng",
                },
            new()
                {
                    Id = new Guid("73C6AAEB-9BCE-402C-9364-8E475035CBF3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계약금",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tiền đặt cọc",
                },
            new()
                {
                    Id = new Guid("ED151A85-B309-4DEF-A1E6-23A471AEC903"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계약서",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bản hợp đồng",
                },
            new()
                {
                    Id = new Guid("5AF647C2-B29C-43D6-9FC0-161363FDFFAD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계좌",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tài khoản",
                },
            new()
                {
                    Id = new Guid("8F72E7EE-6C72-4E70-A003-814A0D2B9887"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계층",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "giai cấp, tầng lớp, giới",
                },
            new()
                {
                    Id = new Guid("EBF3CCC8-943C-4F4A-8D3F-A7A2DEEC1487"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "계획하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "lên kế hoạch",
                },
            new()
                {
                    Id = new Guid("902E07BA-ADC4-4128-8A93-94F319CC2177"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고객",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khách hàng",
                },
            new()
                {
                    Id = new Guid("65595BAA-0707-4FEB-B85A-3C14735A06B3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고교",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "trường cấp ba",
                },
            new()
                {
                    Id = new Guid("DB5536BC-AA2D-4F59-8E7F-8A9172167D2B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고구마",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khoai lang",
                },
            new()
                {
                    Id = new Guid("DBC25F16-7D77-47E3-9AC9-4563F98546D7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고국",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cố hương, cố quốc, tổ quốc",
                },
            new()
                {
                    Id = new Guid("38A5652C-9EC3-4E91-A6F4-3C4BEAB3A53D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고궁",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cố cung, cung điện cổ",
                },
            new()
                {
                    Id = new Guid("4D6D9173-772F-4689-A819-47FA7B9C9A11"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고급",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cao cấp, sự sang trọng",
                },
            new()
                {
                    Id = new Guid("6318C94E-3F78-4180-A7B0-F5C3927C8ED2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고급스럽다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "cao cấp",
                },
            new()
                {
                    Id = new Guid("B7B1B162-431F-4152-9213-3B908152BD25"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고대",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "thời kỳ cổ đại",
                },
            new()
                {
                    Id = new Guid("7526D109-1378-4604-AF74-D9066DCB0E41"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고독",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cô độc, sự đơn độc",
                },
            new()
                {
                    Id = new Guid("B52B2F8C-8CF6-4E2F-AD41-EE0CDD3CE4BF"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고등",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bậc cao",
                },
            new()
                {
                    Id = new Guid("05AD9672-7A2F-4037-AB90-2643FE1B0ECE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고등어",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cá thu",
                },
            new()
                {
                    Id = new Guid("26BBB614-6336-4356-9804-56A9EF75CAB6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고래",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cá voi",
                },
            new()
                {
                    Id = new Guid("11354CED-4B56-4EBD-A1B9-0554E0C80A84"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고려",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cân nhắc, sự đắn đo",
                },
            new()
                {
                    Id = new Guid("CE0DAE4B-89F0-4813-B16D-8AB2DC98C5EC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고려하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "cân nhắc, suy tính đến",
                },
            new()
                {
                    Id = new Guid("A8D3DDBF-CFD0-43D9-8C7A-31D9AD8B5532"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고르다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "chọn",
                },
            new()
                {
                    Id = new Guid("912EC3BE-9DBD-414E-BC0C-18A2968701BD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고마워하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "mang ơn, biết ơn",
                },
            new()
                {
                    Id = new Guid("445854D2-57A1-4959-94D7-EAE53C9AC5C4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고모부",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "dượng, bác",
                },
            new()
                {
                    Id = new Guid("02509815-A3DE-4C73-B225-9A36DA348EBA"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고무",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cao su",
                },
            new()
                {
                    Id = new Guid("A9890368-F777-42D2-8B16-180F37BF8B53"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고민하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "lo lắng, khổ tâm",
                },
            new()
                {
                    Id = new Guid("68100443-86E7-4A71-8CEF-07FCC555E41D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고백",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự thổ lộ, sự bộc bạch, sự thú nhận, sự thú tội, (tôn giáo) sự xưng tội, sự tỏ tình",
                },
            new()
                {
                    Id = new Guid("AE7BB9E6-E1C6-4A70-9AEF-DF61F9DC4B4C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고생",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nỗi khổ cực, sự cực khổ",
                },
            new()
                {
                    Id = new Guid("98C8B38C-4CD7-4355-915D-AFE11867F0AF"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고생하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "khổ sở, vất vả, nhọc công",
                },
            new()
                {
                    Id = new Guid("59AE1F33-44E7-4768-99BC-79A1AEEB5B3C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고소하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "tố cáo, kiện",
                },
            new()
                {
                    Id = new Guid("60EAEF4D-604F-4F4A-9425-2271060286F2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고속",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cao tốc",
                },
            new()
                {
                    Id = new Guid("BB0DBCDA-BBC9-4A62-8C32-7FA21B1BB89B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고속도로",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "고속도로",
                },
            new()
                {
                    Id = new Guid("54592F30-3C9F-4066-A277-EF25914A6E81"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고요",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự yên tĩnh, sự tĩnh mịch",
                },
            new()
                {
                    Id = new Guid("F844CA50-414C-4FD6-A695-E6CAB5B0E8A8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고유",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đặc trưng vốn có, cái vốn có",
                },
            new()
                {
                    Id = new Guid("EBA765D8-EA2A-4054-8DA2-502B98D99621"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고장",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quê quán, quê hương, vùng quê",
                },
            new()
                {
                    Id = new Guid("ECAE03C9-7B1E-4FDE-AE1C-31176E81CC37"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고전",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cổ truyền",
                },
            new()
                {
                    Id = new Guid("B3E4D7CD-771F-44B8-B9F3-B252DA80F9C6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고정",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cố định",
                },
            new()
                {
                    Id = new Guid("7CD47D5C-4437-4007-9919-7B366207CDE9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고집",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cố chấp",
                },
            new()
                {
                    Id = new Guid("07EACB06-DE83-461A-AF0D-823ADC70B496"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고추",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quả ớt, trái ớt",
                },
            new()
                {
                    Id = new Guid("180B3A47-19C5-4AE0-8A71-B3482DAE7C7D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고춧가루",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bột ớt",
                },
            new()
                {
                    Id = new Guid("EE26C462-37B3-4BFB-9BA7-CEC6ACB5929A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고층",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tầng cao",
                },
            new()
                {
                    Id = new Guid("AFD4DF8F-2537-4886-9FC5-BF142D6355E1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고통",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự đau khổ, sự thống khổ, sự đau đớn",
                },
            new()
                {
                    Id = new Guid("637B8463-B779-4E1F-BC0A-9CA943E11CAB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "고통스럽다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "khó khăn, đau khổ",
                },
            new()
                {
                    Id = new Guid("54867F43-B123-44E2-94A7-CA6232D253DF"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곡",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khúc nhạc, bản nhạc",
                },
            new()
                {
                    Id = new Guid("BCF8AAC5-1EF1-49CE-A771-E68BFE8F5224"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곡식",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "ngũ cốc",
                },
            new()
                {
                    Id = new Guid("6BC04C24-2EE0-4093-B9AA-7CD26F252B2F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곤란",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khó khăn, sự trở ngại",
                },
            new()
                {
                    Id = new Guid("73A4C24E-D4B9-41C0-BED0-4A6ABE5B0040"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곧다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "thẳng, ngay thẳng",
                },
            new()
                {
                    Id = new Guid("682B416D-D5EA-4090-BA1D-DDAE3283D2F9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곧바로",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "ngay lập tức",
                },
            new()
                {
                    Id = new Guid("7FC8C3CD-6D02-4335-9CFE-C70D576DA890"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곧이어",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "ngay sau đó",
                },
            new()
                {
                    Id = new Guid("15EE239C-06FF-46FC-A06E-AC946DD5CB1F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곧잘",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "tốt, giỏi, hay",
                },
            new()
                {
                    Id = new Guid("8F43EB85-45D8-42F2-AB79-2281DF3013E6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곧장",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "thẳng tiến",
                },
            new()
                {
                    Id = new Guid("38784896-51F9-4162-BF15-F6436CCECFFB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "골",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự hờn dỗi",
                },
            new()
                {
                    Id = new Guid("EB6EE63D-010C-4314-9233-A8508E7E1C8A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "골고루",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "(một cách) đồng đều, đều đặn, cân đối",
                },
            new()
                {
                    Id = new Guid("E7D06ED0-CF1B-4E1B-83E0-41759C8B37BF"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "골다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "ngáy",
                },
            new()
                {
                    Id = new Guid("61D282E0-84E8-4D57-9B97-E993404A8302"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "골목",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "con hẻm, ngõ, hẻm, ngách",
                },
            new()
                {
                    Id = new Guid("FA3B4D23-D96B-4A82-867D-C0824D445043"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "골목길",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "con đường hẻm, ngõ hẻm",
                },
            new()
                {
                    Id = new Guid("1CB83803-0830-451D-B2E2-1D7A58ED8FFF"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "골프",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "môn đánh gôn",
                },
            new()
                {
                    Id = new Guid("ABB3D96D-88B6-4EF3-859E-D73CA6E2A01F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "골프장",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sân gôn",
                },
            new()
                {
                    Id = new Guid("238F1F69-C7F0-4760-963F-AF30BCAC7119"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곰",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "con gấu",
                },
            new()
                {
                    Id = new Guid("4A73C36C-B855-4E70-9C3E-1211941F445B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곱다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "cong",
                },
            new()
                {
                    Id = new Guid("46C9DC4C-058E-4026-8BA5-0905A0151C56"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곱하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "nhân",
                },
            new()
                {
                    Id = new Guid("A9C2DCFF-255F-4DA6-9F38-4BF02FA133F6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "곳곳",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nơi nơi, khắp nơi",
                },
            new()
                {
                    Id = new Guid("AC526D4A-C492-49A9-BDA4-46B3E1059F28"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quả bóng, quả banh",
                },
            new()
                {
                    Id = new Guid("A665E6C6-A841-4BB0-8CC2-1A45A1BE8399"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공간",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "không gian",
                },
            new()
                {
                    Id = new Guid("BAABC16E-4355-4266-846D-C8F755D01346"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공감",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự đồng cảm",
                },
            new()
                {
                    Id = new Guid("C617A7AC-EC4E-4F33-A5F4-35D1894CF476"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공개",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự công khai",
                },
            new()
                {
                    Id = new Guid("A4E70C1A-BC21-4865-B795-07751174085C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공격",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự công kích, sự tấn công",
                },
            new()
                {
                    Id = new Guid("C8D0A7AF-E6D6-4E64-9D64-87FC1C37D36F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공공",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "công cộng",
                },
            new()
                {
                    Id = new Guid("7DA07362-BA94-4AD1-B295-A4958B708500"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공공요금",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "chi phí dịch vụ công cộng",
                },
            new()
                {
                    Id = new Guid("B808BAE5-CF1D-4781-9D4A-5825AA081EA5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공공장소",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nơi công cộng",
                },
            new()
                {
                    Id = new Guid("CE19301A-4B19-4989-8AFD-F4A6AA36A14E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공과금",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "chi phí tiện ích",
                },
            new()
                {
                    Id = new Guid("80C5582A-35D0-45B9-A893-BB9857B6595F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공급",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cung cấp",
                },
            new()
                {
                    Id = new Guid("61A7C733-4313-44EF-81E1-0C4031302665"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공기",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "gonggi; viên đá hay viên sỏi (dùng để chơi trò chơi tung hứng)",
                },
            new()
                {
                    Id = new Guid("F8C60CFD-BE97-4C1C-9FA9-66D9D6DD230F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공기",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "gonggi; viên đá hay viên sỏi (dùng để chơi trò chơi tung hứng)",
                },
            new()
                {
                    Id = new Guid("A57739E3-8152-4F77-8659-AB56046FF023"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공동",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "chung",
                },
            new()
                {
                    Id = new Guid("0B741246-4DB5-4165-922C-5F60F9BF8D03"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공동체",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cộng đồng",
                },
            new()
                {
                    Id = new Guid("7CCA31EB-680B-40EA-99B5-5BBC1A763633"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공사",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "công trình",
                },
            new()
                {
                    Id = new Guid("84C72152-E7B9-4981-9DAE-8D0A11B4E7ED"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공손하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "lễ phép và khiêm tốn",
                },
            new()
                {
                    Id = new Guid("C6D628DD-54F1-4547-BC2D-D1EA8EEA0217"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공식",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "chính thức",
                },
            new()
                {
                    Id = new Guid("C85B1294-50BE-44D3-93CD-831259028CC1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공업",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "công nghiệp",
                },
            new()
                {
                    Id = new Guid("4623476F-07C4-4924-A77C-CBD42EB0582B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공연",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự công diễn, sự biểu diễn",
                },
            new()
                {
                    Id = new Guid("EF81F32B-1E0D-47A4-AF0E-D6490B7EC8F4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공연장",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sàn diễn, nơi trình diễn",
                },
            new()
                {
                    Id = new Guid("F490F93B-0A01-46A6-8670-746F89E4C3C6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "công, công cộng, công chúng, nơi công cộng, cái chung",
                },
            new()
                {
                    Id = new Guid("D3F39EEE-5D92-4403-930A-774FF4093EE1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "công, công cộng, công chúng, nơi công cộng, cái chung",
                },
            new()
                {
                    Id = new Guid("8CD80EB1-36BA-4BAA-9D4C-E1727869052D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공주",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "công chúa",
                },
            new()
                {
                    Id = new Guid("963339A3-4AE5-4B0B-A0DB-F0E62902B35D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공중전화",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "điện thoại công cộng",
                },
            new()
                {
                    Id = new Guid("01F2D7FE-65BD-4434-94AF-3661C1950FC8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공지",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự thông báo, sự công bố",
                },
            new()
                {
                    Id = new Guid("332E93C4-86D1-4E07-9647-AAA8869BAB6A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공통",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự chung, sự giống nhau",
                },
            new()
                {
                    Id = new Guid("7427D7BD-88D4-49FA-AD09-C4E81CE08700"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공통점",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "điểm chung, điểm giống nhau, điểm tương đồng",
                },
            new()
                {
                    Id = new Guid("41B35A47-C267-447B-9124-DE30FB4ED236"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공포",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự công bố",
                },
            new()
                {
                    Id = new Guid("2C87F500-DCAC-4DF5-B00B-9EAEA331A567"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공항버스",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "xe buýt sân bay",
                },
            new()
                {
                    Id = new Guid("C1247E27-9006-4E2A-A7E8-98491E72ACA6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "공해",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự ô nhiễm môi trường",
                },
            new()
                {
                    Id = new Guid("5458F20D-88C9-461E-8C88-65187F0DB501"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khoa",
                },
            new()
                {
                    Id = new Guid("AED584D2-B8CA-441A-859D-88C76949E638"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과로",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự quá sức, sự kiệt sức",
                },
            new()
                {
                    Id = new Guid("99154FA6-3DB5-4D42-A8A1-F88BBE17661D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과목",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "môn, môn học",
                },
            new()
                {
                    Id = new Guid("E1842C14-72C1-4325-9356-B352F71B83F4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과소비",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc tiêu xài quá mức",
                },
            new()
                {
                    Id = new Guid("977B9125-B2D8-4F8E-AACE-1E13CFD46C2F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과속",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc chạy vượt tốc độ, sự quá tốc",
                },
            new()
                {
                    Id = new Guid("E19DCD17-3E84-4428-8FA9-E82E12D3197E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과식",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự bội thực",
                },
            new()
                {
                    Id = new Guid("682AED77-7A30-423C-905C-FD176572551A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과연",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "đúng là, quả nhiên",
                },
            new()
                {
                    Id = new Guid("5D588EF0-10B2-4B1A-B49B-A11471B0CDD5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과외",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự phụ thêm, sự tăng thêm",
                },
            new()
                {
                    Id = new Guid("DC27017E-E35C-4D4F-AFAC-A398CD61E1A5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과장",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "trưởng khoa",
                },
            new()
                {
                    Id = new Guid("B203474C-AC10-428C-942E-45A9FC445D55"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과장",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "trưởng khoa",
                },
            new()
                {
                    Id = new Guid("6E8063B8-46C7-447F-9F2B-C44D00A737C0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과정",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quá trình",
                },
            new()
                {
                    Id = new Guid("2CAB3BD6-F56E-4606-AA0B-36D0D542ADE1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과제",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bài toán",
                },
            new()
                {
                    Id = new Guid("6EA86F4E-0E96-4471-9C5B-96B1B4E6D9C0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과학",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khoa học",
                },
            new()
                {
                    Id = new Guid("A752206F-0157-4A6D-BAB2-04DA736B66FB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과학자",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nhà khoa học",
                },
            new()
                {
                    Id = new Guid("DEDD592A-2CC4-4DCD-AB8C-3377C75EA3DD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과학적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "khoa học,  tính khoa học",
                },
            new()
                {
                    Id = new Guid("7C7D3BCB-3F66-4EC6-9028-EDA160928006"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "과학적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khoa học,  tính khoa học",
                },
            new()
                {
                    Id = new Guid("AE683D6F-FFC9-4F1C-A664-1D04469083F1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관객",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khán  giả, người xem, quan khách",
                },
            new()
                {
                    Id = new Guid("9D97EFEC-043C-4A5C-A01B-8FEAB3137EB2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관계없다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "không liên quan, không có quan hệ",
                },
            new()
                {
                    Id = new Guid("75230DCC-8F40-4016-ABE4-14E800A4DB44"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관계없이",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "không có liên quan, không có quan hệ gì, không có can hệ gì",
                },
            new()
                {
                    Id = new Guid("9065B8F7-AEB6-4DB4-99FA-D814829E656E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관계있다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "có liên quan, có quan hệ",
                },
            new()
                {
                    Id = new Guid("B9F38A82-8776-41F1-8F43-91CCC1B2B51F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관계자",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "người có liên quan, người có phận sự",
                },
            new()
                {
                    Id = new Guid("96293EFF-0524-418A-B384-1FDA31E453E6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관람",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự thưởng lãm, sự tham quan, sự thưởng thức",
                },
            new()
                {
                    Id = new Guid("268B53C9-4B20-4CCE-BF2E-4CB61BDFB530"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관람객",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khách tham quan, người xem",
                },
            new()
                {
                    Id = new Guid("BC4B320E-67D8-4AF6-9FAC-49B9B6A3724E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관련",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự liên quan",
                },
            new()
                {
                    Id = new Guid("A209F942-A35F-4786-A9D0-03BED9914413"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관련되다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "có liên quan",
                },
            new()
                {
                    Id = new Guid("46520E8E-6414-461E-92D6-EC828B0C1135"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관련하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "liên quan",
                },
            new()
                {
                    Id = new Guid("AE90AFAD-8AA4-41F2-9618-B53F1C5425E5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관리",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cán bộ quản lý, quan lại, quan chức",
                },
            new()
                {
                    Id = new Guid("AA82550F-20A0-4382-853E-78D5096DCB26"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관심사",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "mối quan tâm",
                },
            new()
                {
                    Id = new Guid("AD83306A-3EBE-4EFE-B70F-052365A3DFC9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관점",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quan điểm",
                },
            new()
                {
                    Id = new Guid("14F1F028-F67E-4F2B-8079-B2546E9BAF68"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관찰",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự quan sát",
                },
            new()
                {
                    Id = new Guid("3DD66F05-9E55-40C2-9C7E-BBE2396BDAE2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관찰하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "quan sát",
                },
            new()
                {
                    Id = new Guid("9BD9B185-35B5-40E7-8B0F-FAE2355A08C6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "관하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "liên quan đến",
                },
            new()
                {
                    Id = new Guid("301597A3-8EB4-41D9-BF2A-7B18CF622228"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "광경",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quang cảnh",
                },
            new()
                {
                    Id = new Guid("07FF3BF3-60E1-4372-AF6C-0ABA422EC1DC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "광주",
                    Level = "Intermediate",
                    Type = "Proper Noun",
                    MeaningVietNamese = "Gwangju; Quang Châu",
                },
            new()
                {
                    Id = new Guid("A00D97FB-6CAC-4269-8E67-C3390157ED8B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "괜히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách vô ích",
                },
            new()
                {
                    Id = new Guid("D159E6C1-1329-4BDA-BDCA-45DE4353E380"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "괴로움",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự đau khổ, niềm đau, nỗi khổ",
                },
            new()
                {
                    Id = new Guid("7CA152E3-5BAF-4EE5-8235-017DF565FAFB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "괴롭다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "đau khổ, khổ sở",
                },
            new()
                {
                    Id = new Guid("4CF26780-A5BA-475A-88C4-7C38D4281907"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "괴롭히다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "làm đau buồn, gây đau đớn",
                },
            new()
                {
                    Id = new Guid("2065C424-48B0-4A36-B42C-94D555CF274C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "굉장하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "hùng vĩ, nguy nga",
                },
            new()
                {
                    Id = new Guid("85950ADD-65FF-4C00-BA9E-5FA6FC0367DB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "굉장히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "vô cùng, rất, hết sức",
                },
            new()
                {
                    Id = new Guid("F7AECB92-CD68-43A5-B78F-4BCE95B06E5B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교내",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "trong trường",
                },
            new()
                {
                    Id = new Guid("03931570-315C-424C-9802-31143652864F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교대",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "ca (làm việc)",
                },
            new()
                {
                    Id = new Guid("6633581F-45D1-48FE-A13F-E99945E77863"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교류",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự hợp lưu, dòng hợp lưu",
                },
            new()
                {
                    Id = new Guid("F78B078E-346F-4899-8444-AE0FBACAC16F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교문",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cổng trường",
                },
            new()
                {
                    Id = new Guid("63BFC3ED-1AD3-4727-BC76-509363F5FF54"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교복",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đồng phục học sinh",
                },
            new()
                {
                    Id = new Guid("24510C89-362A-4A18-BD55-9A37965BF4B3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교시",
                    Level = "Intermediate",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "sự chỉ dạy",
                },
            new()
                {
                    Id = new Guid("1DDC04AC-D17B-4B0E-82AE-44687D469D26"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교양",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "học thức, tri thức, học vấn, kiến thức đại cương, kiến thức chung",
                },
            new()
                {
                    Id = new Guid("BD948869-07A3-4EDE-86DC-3DEA7B45B545"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교외",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "vùng ngoại ô",
                },
            new()
                {
                    Id = new Guid("8506DB7C-AC6A-4E67-9F6C-3A3207F8F019"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교육비",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "phí giáo dục",
                },
            new()
                {
                    Id = new Guid("09862E20-CC4A-45BD-83A1-2C8B1F404728"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교육자",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nhà giáo",
                },
            new()
                {
                    Id = new Guid("AD88E995-54FC-4F76-8A36-6FBC0A48392D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교장",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "hiệu trưởng",
                },
            new()
                {
                    Id = new Guid("808C7030-1BE2-42EA-991F-A4A9E1A2AC61"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교재",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "giáo trình",
                },
            new()
                {
                    Id = new Guid("5E4892F7-189D-4A75-AD97-DB502637304C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교체",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự thay thế, sự thay đổi",
                },
            new()
                {
                    Id = new Guid("56756EC5-E18C-4F91-A76B-E4F6740E7513"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교통수단",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "phương tiện giao thông",
                },
            new()
                {
                    Id = new Guid("0B2ECFD1-588B-4EBD-8AEF-6917FBC2BD4D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교통편",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "phương tiện giao thông",
                },
            new()
                {
                    Id = new Guid("B30246A6-93DF-4260-A53A-3796E8D9404B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교포",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kiểu bào",
                },
            new()
                {
                    Id = new Guid("A3F0A9E7-4F05-4C7A-9AE8-E9F27E829D9A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "교훈",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "lời giáo huấn, câu triết lý giáo dục của trường",
                },
            new()
                {
                    Id = new Guid("3C6D0286-835C-409F-B97B-F4AED65883AE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "từ ghép, cụm từ, mệnh đề",
                },
            new()
                {
                    Id = new Guid("A907AA2F-E855-4317-97A4-9A98E076E52A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구경거리",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cái để ngắm, cái đáng xem",
                },
            new()
                {
                    Id = new Guid("3E6B9D28-1785-4302-A403-DEC27BA3B26F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구경하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "ngắm, ngắm nghía",
                },
            new()
                {
                    Id = new Guid("F5315746-62E5-49CA-BB2F-617CCD07F4C1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구르다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "lăn tròn",
                },
            new()
                {
                    Id = new Guid("5B8FB754-ADA7-421A-BC7E-2D6923E5CE6C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구매",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự mua, việc mua",
                },
            new()
                {
                    Id = new Guid("5DF0EC49-BDA7-4000-A1AB-71D0D6089E09"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구멍",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "lỗ",
                },
            new()
                {
                    Id = new Guid("06BB6F25-2723-4220-BFE8-5E131790BCE7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구별",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự phân biệt, sự tách biệt",
                },
            new()
                {
                    Id = new Guid("1C3147F8-ACF7-493E-9516-163768C9FC4B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구부리다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "gập, bẻ cong",
                },
            new()
                {
                    Id = new Guid("3B67C102-99A8-4089-81B8-ECAC07EE2A8A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구분",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự phân loại",
                },
            new()
                {
                    Id = new Guid("3668ADDC-6818-4B72-B888-9821F17D628E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구석",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "góc, xó",
                },
            new()
                {
                    Id = new Guid("C74FB9AF-7723-4513-8C8F-D788312C1A71"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구성",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cấu thành, sự hình thành",
                },
            new()
                {
                    Id = new Guid("2DDFEDDD-B9F6-4775-96FB-7C312609646B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구세대",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "thế hệ cũ",
                },
            new()
                {
                    Id = new Guid("6D13223E-36D4-47DF-9D18-5F3B05313A55"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구속",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khống chế, sự gò ép",
                },
            new()
                {
                    Id = new Guid("ADEAEEAD-9A0A-456A-94BA-51C0186DFEF1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구수하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "thơm ngon",
                },
            new()
                {
                    Id = new Guid("94B65DCB-C9DE-4963-A155-242BFCF284B8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구역",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khu vực",
                },
            new()
                {
                    Id = new Guid("DBF394C4-A45F-4BB6-9E9F-D203314621B6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구입",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự mua vào, sự thu mua",
                },
            new()
                {
                    Id = new Guid("1B116D46-2BBD-4429-8FC2-D0FA8780AA89"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구조",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cứu trợ, sự cứu hộ",
                },
            new()
                {
                    Id = new Guid("033C56B3-5F64-4566-AE96-96BFCEA9BC04"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구조",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cứu trợ, sự cứu hộ",
                },
            new()
                {
                    Id = new Guid("1EB02A25-2BBC-4238-A122-26A5C72250E8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구조대",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đội cứu trợ, đội cứu hộ, nhóm cứu hộ",
                },
            new()
                {
                    Id = new Guid("98F13458-B600-4914-955E-F10E73357EAE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구체적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "tính cụ thể",
                },
            new()
                {
                    Id = new Guid("7A224A8A-33A7-4CE8-BE59-364383A39438"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구체적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tính cụ thể",
                },
            new()
                {
                    Id = new Guid("ABDEA737-74DC-40FB-8822-81266C83D7A1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "tìm, tìm kiếm, tìm thấy",
                },
            new()
                {
                    Id = new Guid("B4F6E9C6-2330-4763-86AD-64C4FFCB95FD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "구하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "tìm, tìm kiếm, tìm thấy",
                },
            new()
                {
                    Id = new Guid("7D555279-11ED-4AED-9B8D-EED50F0F85E8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국가",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quốc gia",
                },
            new()
                {
                    Id = new Guid("D914180E-6CBA-47E6-9997-BC30BE71ED4A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국경일",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "ngày quốc khánh",
                },
            new()
                {
                    Id = new Guid("713600D0-9470-4C03-B9A6-F760E115C7C1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국기",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quốc kỳ",
                },
            new()
                {
                    Id = new Guid("D14B59F8-04E1-4005-90EE-E014C18641E5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국내선",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tuyến quốc nội",
                },
            new()
                {
                    Id = new Guid("DB858D02-F0D3-4734-A14C-14F3D3E80B53"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국립",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quốc lập, quốc gia",
                },
            new()
                {
                    Id = new Guid("DCD71F4A-1122-4E61-82E3-64224CD34627"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국물",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nước canh",
                },
            new()
                {
                    Id = new Guid("4B3CB6AC-12F7-4E9C-A4A6-962E34CA3FA7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국민",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quốc dân, nhân dân",
                },
            new()
                {
                    Id = new Guid("E3AF0219-27A5-482C-B199-FC9CE6CFD297"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국산",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc sản xuất trong nước, hàng nội, sản phẩm trong nước",
                },
            new()
                {
                    Id = new Guid("7CE11559-0D8C-4D07-B976-515902AB296B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국어",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quốc ngữ",
                },
            new()
                {
                    Id = new Guid("3C49A6BC-9CBF-4D85-B548-BD293AD198EC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국외",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "ngoại quốc, ngoài nước",
                },
            new()
                {
                    Id = new Guid("E54EF436-0EDD-4D72-9625-C29BF5768184"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국제결혼",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "việc kết hôn quốc tế, việc kết hôn khác quốc tịch",
                },
            new()
                {
                    Id = new Guid("8866E58E-0F6C-4ED4-840B-B2FEEF1624E3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국제선",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tuyến quốc tế",
                },
            new()
                {
                    Id = new Guid("5D7DEF8A-F0F2-4570-9119-D91C54E1EB7D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국제화",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự quốc tế hoá, sự toàn cầu hoá",
                },
            new()
                {
                    Id = new Guid("E1F3000D-BD10-478B-966D-E581C8C88CEF"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국화",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quốc hoa",
                },
            new()
                {
                    Id = new Guid("82058B44-DCC0-43AC-9404-9320D085C0D9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국회",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quốc hội",
                },
            new()
                {
                    Id = new Guid("CDC24EFE-0B20-49BA-BD2F-C6B2C3B27850"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "국회의원",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "국회의원",
                },
            new()
                {
                    Id = new Guid("6E0448F4-4986-40FD-90A8-B610251062D1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "군",
                    Level = "Intermediate",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "quân",
                },
            new()
                {
                    Id = new Guid("02D9EF1D-19A0-4E0D-8D2D-704806B78CFC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "군",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quân",
                },
            new()
                {
                    Id = new Guid("40871086-41CB-444E-943A-F225CC086755"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "군",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quân",
                },
            new()
                {
                    Id = new Guid("B559C079-341D-4DE8-BC9D-4623C48C536E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "군대",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quân đội, bộ đội, quân ngũ",
                },
            new()
                {
                    Id = new Guid("8F98CF8B-5AC1-47B1-8BDC-D0960372B0C2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "군데",
                    Level = "Intermediate",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "nơi, chỗ",
                },
            new()
                {
                    Id = new Guid("E7A07FFA-9A84-4680-98DF-2A06F5268402"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "군사",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quân sĩ",
                },
            new()
                {
                    Id = new Guid("4B45C741-5E19-49B1-983E-662150B9166C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "굳어지다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trở nên đông, trở nên cứng",
                },
            new()
                {
                    Id = new Guid("977417A5-78B9-4B5B-BE02-4E6B38AAF68C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "굳이",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "cố ý, chủ ý, có chủ tâm",
                },
            new()
                {
                    Id = new Guid("8C8B60AC-9F68-4704-9BC9-90779FE4D9E1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "굴",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "con hào",
                },
            new()
                {
                    Id = new Guid("CA32790E-4E83-4B1B-8B49-2F97784563E5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "굶다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "nhịn ăn",
                },
            new()
                {
                    Id = new Guid("A53527DF-A9CB-48D7-825C-E5A7BBD97523"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "굽",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "móng chân",
                },
            new()
                {
                    Id = new Guid("7BAAD6AF-DC2C-497A-98E1-AD9AFFDCF57D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "굽히다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "cúi, khom",
                },
            new()
                {
                    Id = new Guid("91D4D393-CA3D-467D-8B2A-7FFFC829E4DC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "권력",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quyền lực",
                },
            new()
                {
                    Id = new Guid("8B44002C-F7CB-4E06-BD2B-C0D53E4239A9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "권리",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quyền lợi",
                },
            new()
                {
                    Id = new Guid("731C48FE-7849-4CD4-AE06-53C69F7C65FB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "권위",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quyền uy",
                },
            new()
                {
                    Id = new Guid("9BA156D4-BBEC-41E3-BEE5-5EF347E1962D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "권유",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khuyên nhủ, sự khuyên bảo",
                },
            new()
                {
                    Id = new Guid("3AF87B6A-1D17-42E8-9B65-B5C4C69AC547"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "권투",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quyền anh",
                },
            new()
                {
                    Id = new Guid("666056D3-BB89-4DD1-BFE8-FBDF1B98C266"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "권하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "khuyên, khuyên nhủ, khuyên bảo",
                },
            new()
                {
                    Id = new Guid("66C5C08A-BB78-4629-B05A-F23CB09D0BCB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "귀가",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự trở về nhà",
                },
            new()
                {
                    Id = new Guid("BC6169A2-AEFB-46B8-A655-047C846DF6C8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "귀국",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự về nước",
                },
            new()
                {
                    Id = new Guid("1C35F107-53AC-4E9E-A219-A3D30F8680D8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "귀국하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "về nước",
                },
            new()
                {
                    Id = new Guid("BBAC9438-C5D2-4B24-95A1-F61925B032CA"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "귀신",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "hồn ma",
                },
            new()
                {
                    Id = new Guid("21842A10-CD4E-44A2-A2AC-5B00142EEBE3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "귀중하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "quý trọng",
                },
            new()
                {
                    Id = new Guid("5565578C-6106-4AD5-958E-F6C07829428D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "귀하",
                    Level = "Intermediate",
                    Type = "Pronoun",
                    MeaningVietNamese = "kính gửi",
                },
            new()
                {
                    Id = new Guid("38921BBA-1AE5-4B5B-B008-66623BCEE3D2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "귀하",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kính gửi",
                },
            new()
                {
                    Id = new Guid("CC8D2659-B24C-4601-83CA-E430D6B70299"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "귀하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "cao quý",
                },
            new()
                {
                    Id = new Guid("666B71A5-80C7-4D55-9C62-C7B74D417868"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "규모",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quy mô",
                },
            new()
                {
                    Id = new Guid("FE5F74D2-86F0-4365-B359-86336992C5BB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "규정",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "quy định",
                },
            new()
                {
                    Id = new Guid("BB962BDC-8403-4A4A-B6AB-02C8BE3A8F51"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "규칙적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "tính quy tắc",
                },
            new()
                {
                    Id = new Guid("2E024DD6-6130-4B74-8B0C-B9BBAEAD991B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "규칙적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tính quy tắc",
                },
            new()
                {
                    Id = new Guid("0159A444-2301-4935-91B0-69FAD62C7BDA"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "균형",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cân bằng",
                },
            new()
                {
                    Id = new Guid("686CDB23-AC5C-45C6-A524-35CB4D9B15D3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그나마",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "dù sao thì cũng, thế cũng còn",
                },
            new()
                {
                    Id = new Guid("13F41D98-9EEC-4ED8-8EE4-FC56A10EC9D2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그네",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cái xích đu",
                },
            new()
                {
                    Id = new Guid("932D7CDA-DDDB-4688-825B-157A7BF24117"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그녀",
                    Level = "Intermediate",
                    Type = "Pronoun",
                    MeaningVietNamese = "cô ấy, bà ấy",
                },
            new()
                {
                    Id = new Guid("8D5C0B3F-9758-48BB-8A75-070D0A793F39"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그늘",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bóng, bóng râm, bóng mát, bóng tối",
                },
            new()
                {
                    Id = new Guid("719946AD-45BB-4900-97AF-1978E3EFB97E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그다음",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sau đó, tiếp sau",
                },
            new()
                {
                    Id = new Guid("B0941839-8FDB-4E50-B895-D3CCF7C3AB22"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그다지",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "(không)...lắm, (không)...đến nỗi, (không)....đến mức",
                },
            new()
                {
                    Id = new Guid("C3697D9F-A100-4EF9-91DF-F2A2B2B97AAF"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그대",
                    Level = "Intermediate",
                    Type = "Pronoun",
                    MeaningVietNamese = "cậu, em",
                },
            new()
                {
                    Id = new Guid("10C619EE-5C0A-43EE-9BD2-C95957B879DD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그래도",
                    Level = "Intermediate",
                    Type = "Abbreviated",
                    MeaningVietNamese = "dù vậy, dù như thế",
                },
            new()
                {
                    Id = new Guid("C9949800-29E1-4723-BFF6-4185DCB9FC4A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그래프",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đồ thị, biểu đồ",
                },
            new()
                {
                    Id = new Guid("3BEF947E-24F9-48E1-AD83-0264D841E190"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그램",
                    Level = "Intermediate",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "gam, gram",
                },
            new()
                {
                    Id = new Guid("9CF02428-E956-474E-967D-C35EDD73E39D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그러게",
                    Level = "Intermediate",
                    Type = "Interjection",
                    MeaningVietNamese = "thì đó, thì tôi đã nói rồi mà",
                },
            new()
                {
                    Id = new Guid("69C1BEF4-9A7A-4F4D-B14A-94EE213264F2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그러게",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "thì đó, thì tôi đã nói rồi mà",
                },
            new()
                {
                    Id = new Guid("46B30285-BA67-46A8-B101-C2765ACD391B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그러다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "làm như vậy thì",
                },
            new()
                {
                    Id = new Guid("1CA376C2-BDA5-474B-BDD6-B95DC48A0AD1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그러하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "như thế, như vậy",
                },
            new()
                {
                    Id = new Guid("0D81C881-384F-4CE6-94EE-B45659A2E7D8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그럭저럭",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "đều đều",
                },
            new()
                {
                    Id = new Guid("96909A49-E5A0-4A17-9E78-9DF7546C7DB3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그런대로",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "dù sao",
                },
            new()
                {
                    Id = new Guid("804081E7-8E43-4126-8573-10A0A8D973E6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그렇게",
                    Level = "Intermediate",
                    Type = "Abbreviated",
                    MeaningVietNamese = "như thế, như vậy",
                },
            new()
                {
                    Id = new Guid("0044FBA0-B893-4212-BEC5-9C4B7D08AD03"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그렇지",
                    Level = "Intermediate",
                    Type = "Interjection",
                    MeaningVietNamese = "đúng rồi, có thế chứ",
                },
            new()
                {
                    Id = new Guid("8C4F9AAB-03ED-4193-AF5C-53EA3A77A3DC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그려지다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "그려지다",
                },
            new()
                {
                    Id = new Guid("5E7283FA-244A-4284-B22D-E57BDFAB53A2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그룹",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nhóm",
                },
            new()
                {
                    Id = new Guid("DCEBB182-4CB9-411C-A88B-C2D7ADD2BAC3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그리",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "chỗ đó, hướng đó",
                },
            new()
                {
                    Id = new Guid("54690F64-9C76-4F02-9820-EB116AE3A59A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그리",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "chỗ đó, hướng đó",
                },
            new()
                {
                    Id = new Guid("751DDDEF-5FE2-4065-A3E2-657863EEC976"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그리움",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự nhớ nhung",
                },
            new()
                {
                    Id = new Guid("3E50809C-A4CA-4D49-8CE0-006AD1EC33E3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그림자",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "bóng",
                },
            new()
                {
                    Id = new Guid("379D2FF0-E818-4B8A-AF1E-E9E0DEED7CE5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그림책",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "truyện tranh, sách tranh",
                },
            new()
                {
                    Id = new Guid("EC36A1F4-3FE9-4F2F-A8AD-7E2EDB2D9DF7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그만큼",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "chừng đó, mức đó",
                },
            new()
                {
                    Id = new Guid("A220BDAE-726D-4F57-90D6-DCEAF7D60BEC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그만큼",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "chừng đó, mức đó",
                },
            new()
                {
                    Id = new Guid("4DB15637-A4D9-4CDA-9950-A6794ECAA7FC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그만하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "ngừng, thôi",
                },
            new()
                {
                    Id = new Guid("09AF15A4-8EBD-48DD-92D0-2528B48EF035"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그만하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "ngừng, thôi",
                },
            new()
                {
                    Id = new Guid("DA9EE96E-B273-4410-ABF9-36E011053D1E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그야말로",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "quả thực, đúng là, chính là",
                },
            new()
                {
                    Id = new Guid("298540D2-4AEC-4BB6-9C5A-A57D174ED828"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그저",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "suốt, liên tục, không ngừng",
                },
            new()
                {
                    Id = new Guid("F468A737-8FE6-4539-BF25-CA5F1A596E9A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그제",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "ngày hôm kia",
                },
            new()
                {
                    Id = new Guid("0F799991-2430-4FF3-B7FA-044435426EED"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그제",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "ngày hôm kia",
                },
            new()
                {
                    Id = new Guid("C9FDA2E5-0DEB-4556-8F75-48831AD0229E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그제야",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "phải đến khi ấy, phải đến lúc ấy",
                },
            new()
                {
                    Id = new Guid("9B925E55-2244-4E88-931D-29C4E63CB5C3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그중",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "trong đó, trong số đó",
                },
            new()
                {
                    Id = new Guid("02B18744-3C20-496C-A8A1-BB3AB7C77139"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그토록",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "đến đó, đến thế",
                },
            new()
                {
                    Id = new Guid("AB33AB8B-3015-48DD-B683-F584355CE8E1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "그해",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "năm đó, năm ấy",
                },
            new()
                {
                    Id = new Guid("AE614EC1-B479-4B86-A48D-84C78BDBA055"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "극복",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khắc phục",
                },
            new()
                {
                    Id = new Guid("054FD5A0-2EBC-4209-AB62-A10F5E5FB97C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "극히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "cực kì",
                },
            new()
                {
                    Id = new Guid("3373BAC3-42D9-4DF1-811C-D051F6B05E64"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근거",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cơ sở, căn cứ",
                },
            new()
                {
                    Id = new Guid("72F9983F-FA22-4001-9BD0-A9F447D7478A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근교",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "vùng ngoại ô, ngoại thành",
                },
            new()
                {
                    Id = new Guid("49FFF759-C67E-4503-810C-4460A4247AF8"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근대",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "thời cận đại, thời đại gần đây",
                },
            new()
                {
                    Id = new Guid("C7C045F8-BDE4-4245-9CA4-2D489E418B09"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근데",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "thế nhưng",
                },
            new()
                {
                    Id = new Guid("DB475717-6B7C-4981-AAE8-FE6AE523D355"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근래",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "gần đây, vừa rồi",
                },
            new()
                {
                    Id = new Guid("73852747-09E4-4BC2-879C-1E0A0AAC10B5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근로자",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "người lao động",
                },
            new()
                {
                    Id = new Guid("6C7243C0-1FF1-4F5D-A9A3-A7EA63F82C35"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근무",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự làm việc, công việc",
                },
            new()
                {
                    Id = new Guid("A354B94B-CB63-428A-9931-4330D6F09649"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근무하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "làm việc",
                },
            new()
                {
                    Id = new Guid("4F3BA171-2A35-4326-B655-87D47742CA49"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근본",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự căn bản, nền móng, cơ sở",
                },
            new()
                {
                    Id = new Guid("EDED6C85-99B9-42D3-AE5D-959D1D854111"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근본적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "tính căn bản, tính cơ bản",
                },
            new()
                {
                    Id = new Guid("84EA1613-796B-4C94-A010-945070C97AFD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근본적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tính căn bản, tính cơ bản",
                },
            new()
                {
                    Id = new Guid("0B45290B-6A38-45C6-898B-30E70EF4D46C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근심",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự lo ngại, sự quan ngại, sự lo sợ",
                },
            new()
                {
                    Id = new Guid("97D219C0-1C3A-42A0-BA5B-7269F30AC812"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "근육",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cơ bắp",
                },
            new()
                {
                    Id = new Guid("21D42E04-BA20-479D-A61A-F0047F4ECDB9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "글쓰기",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự viết văn, việc viết văn",
                },
            new()
                {
                    Id = new Guid("A1ED40AC-AF4B-4D4B-9D6C-2E05BE3171DE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "긁다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "gãi, cạy",
                },
            new()
                {
                    Id = new Guid("F4B3BD24-BADE-4D0A-85E2-730A0E0C7F27"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "금",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "vết rạn, vết nứt, vết nhăn",
                },
            new()
                {
                    Id = new Guid("245B3C4A-BDB2-4E6F-91E6-307A584017F0"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "금",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "vết rạn, vết nứt, vết nhăn",
                },
            new()
                {
                    Id = new Guid("56DEF5CE-8DE1-49C6-AE48-1D2724C14227"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "금년",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "năm nay",
                },
            new()
                {
                    Id = new Guid("7593E53F-2125-4E08-BB18-42E25A27D569"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "금액",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "số tiền",
                },
            new()
                {
                    Id = new Guid("A0441F24-1072-4453-8C5D-849A1A2673DC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "금연",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cấm hút thuốc",
                },
            new()
                {
                    Id = new Guid("E5708A8C-D581-489C-A554-C3F4526DBED2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "금융",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tài chính tiền tệ",
                },
            new()
                {
                    Id = new Guid("40C8BB99-89D1-4290-8F39-00F6779842B3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "금지하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "cấm chỉ, cấm",
                },
            new()
                {
                    Id = new Guid("54716D66-0B5C-43AF-8792-B2428F22E34A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "금하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "cấm, cấm đoán",
                },
            new()
                {
                    Id = new Guid("55CD62AE-39AE-44E7-91CE-3340CE4EC234"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "급격히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách đột ngột, một cách chóng vánh",
                },
            new()
                {
                    Id = new Guid("C1EBE450-D015-4DD2-8B5D-2C300213E1F9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "급속히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách cấp tốc, một cách gấp gáp",
                },
            new()
                {
                    Id = new Guid("13B765A6-765D-4895-A390-B760C0A81A8D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "급증",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự tăng đột ngột",
                },
            new()
                {
                    Id = new Guid("44CCCF5D-EC79-40FB-89DF-8F55EC2A8D9E"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "급히",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách gấp gáp, một cách vội vàng",
                },
            new()
                {
                    Id = new Guid("7DA148CA-6DE7-4CA4-B364-409FC437A068"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "긋다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "vạch, gạch",
                },
            new()
                {
                    Id = new Guid("2F20D02F-F772-40E7-A86C-8D63FDC124EA"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "긍정적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "sự khẳng định",
                },
            new()
                {
                    Id = new Guid("B99DE2CE-2C19-47EF-AB23-11DDA0A8509A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "긍정적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khẳng định",
                },
            new()
                {
                    Id = new Guid("A30AA825-93E8-4CE0-BF0F-E126C3E98FB6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기계",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "máy",
                },
            new()
                {
                    Id = new Guid("42185AD6-BFF3-4DF1-90E3-F7FB27E7EF42"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기계",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "máy",
                },
            new()
                {
                    Id = new Guid("B2807F73-B01B-49FD-B919-4FDBFF800F39"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기관",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khí quản",
                },
            new()
                {
                    Id = new Guid("C158C37B-ACC0-4DA8-BDB5-66271568BF35"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기구",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "dụng cụ, đồ dùng",
                },
            new()
                {
                    Id = new Guid("F16EDAA5-573A-4417-AD29-B776E722A9E9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기념",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự kỷ niệm",
                },
            new()
                {
                    Id = new Guid("0637DD74-2F0F-4D43-B062-8A7E3FB73FB6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기념일",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "ngày kỷ niệm",
                },
            new()
                {
                    Id = new Guid("038F11F0-8DC6-4A80-B2B2-7777E05CEE8F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기념품",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đồ lưu niệm, hàng lưu niệm",
                },
            new()
                {
                    Id = new Guid("C9E69388-2BDB-45B2-9BE0-D96669B55E41"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기능",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kỹ năng",
                },
            new()
                {
                    Id = new Guid("4EFC6751-383D-4E29-B702-615097FA6A70"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trườn, bò, lê",
                },
            new()
                {
                    Id = new Guid("D7E51E1F-3C0E-4778-980D-B7C58CA83CC9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기대",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự mong đợi",
                },
            new()
                {
                    Id = new Guid("063AF9AB-3826-45DE-B93A-B16650D22BAA"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기대다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "dựa, chống",
                },
            new()
                {
                    Id = new Guid("B98881E1-9EF5-4D04-8CD4-FA09145572CE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기대하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "mong đợi",
                },
            new()
                {
                    Id = new Guid("901251B9-696A-43A1-B40C-29EB1841EF55"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기도",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự thử, sự cố gắng",
                },
            new()
                {
                    Id = new Guid("3327955E-AC88-4520-9FC0-409B76CE0A9B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기독교",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "Cơ Đốc giáo",
                },
            new()
                {
                    Id = new Guid("2436325D-7790-46AD-A803-427FD3C4B1F2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기둥",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cột, trụ",
                },
            new()
                {
                    Id = new Guid("3148586D-A0B6-4AA6-ABFE-34455979018F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기록",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự ghi chép, sự ghi hình, bản ghi chép, tài liệu lưu",
                },
            new()
                {
                    Id = new Guid("9A28385E-EDC9-426A-B022-2A2CBA719D72"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기록하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "ghi chép lại",
                },
            new()
                {
                    Id = new Guid("BF5B564A-F571-4C14-A24F-8E8F0CC0B99F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기반",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "điều cơ bản",
                },
            new()
                {
                    Id = new Guid("4B353196-883B-495E-9651-566D93C3CC88"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기본",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cái gốc, cái cơ bản",
                },
            new()
                {
                    Id = new Guid("B620E8C1-12C1-4E28-97F0-34AE44F00EC5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기본적",
                    Level = "Intermediate",
                    Type = "Determiner",
                    MeaningVietNamese = "tính căn bản, tính cơ sở",
                },
            new()
                {
                    Id = new Guid("863BC7AF-00FF-4833-80DE-E8C1030927DD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기본적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tính căn bản, tính cơ sở",
                },
            new()
                {
                    Id = new Guid("EE546001-BD0D-44ED-990F-3583937B20F1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기부",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cho tặng, sự hiến tặng",
                },
            new()
                {
                    Id = new Guid("A32FABF5-2CD6-4A2E-8D77-2703DF0EE6A4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기사",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "người lái xe, người lái máy, người điều khiển máy chuyên nghiệp",
                },
            new()
                {
                    Id = new Guid("816E5F5E-043B-4AEF-BE31-C6C1DCCA5674"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기사",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "người lái xe, người lái máy, người điều khiển máy chuyên nghiệp",
                },
            new()
                {
                    Id = new Guid("9A60AA21-ED48-49DF-815C-E99B82686663"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기술",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kỹ thuật",
                },
            new()
                {
                    Id = new Guid("664C8137-82AA-481B-90F5-330EC792EDD7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기술자",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kỹ sư, kỹ thuật viên",
                },
            new()
                {
                    Id = new Guid("6CD2F9B1-74F5-4A56-AD85-F3243844517D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기억력",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khả năng ghi nhớ, trí nhớ",
                },
            new()
                {
                    Id = new Guid("32C280A4-6786-4AB8-B353-9A3F0EC5BCB6"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기억하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "nhớ, nhớ lại, ghi nhớ",
                },
            new()
                {
                    Id = new Guid("E4207A02-5330-446B-9895-DE147F25EAF4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기업",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "doanh nghiệp",
                },
            new()
                {
                    Id = new Guid("CC6A0787-522F-4DD5-9589-86C5A159BBB5"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기업가",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "nhà doanh nghiệp",
                },
            new()
                {
                    Id = new Guid("C3E31CDF-64DA-4C87-A98B-A2F8EA6057E7"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기여",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự đóng góp, sự góp phần",
                },
            new()
                {
                    Id = new Guid("B496C91E-9040-4F35-9D35-CD0FCF44BFB2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기운",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khí lực, khí thế, sức lực",
                },
            new()
                {
                    Id = new Guid("3DE1A4E2-8EE1-4A9A-91FE-FCE8B4935DA9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기울다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "nghiêng, dốc",
                },
            new()
                {
                    Id = new Guid("EBBD0FD0-F31F-48C9-A9DB-91B1D2506E62"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기울이다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "làm nghiêng, làm xiên, làm dốc",
                },
            new()
                {
                    Id = new Guid("1BD9EF7B-3788-409E-A176-1CF1A1D6D7BE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기원",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự cầu mong, sự mong ước",
                },
            new()
                {
                    Id = new Guid("18AADF50-787C-41F7-95CF-FF815DD9B71A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기적",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kỳ tích, phép màu",
                },
            new()
                {
                    Id = new Guid("D9BB11CE-48A4-4392-BBA9-66A6F5F9C782"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기존",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "vốn có, sẵn có",
                },
            new()
                {
                    Id = new Guid("C1442014-6146-48F9-96F2-42CAE0976BA3"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기준",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tiêu chuẩn",
                },
            new()
                {
                    Id = new Guid("4B952F6C-032A-4FEF-93A9-386837F11B0F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기지개",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự vươn vai đứng thẳng dậy",
                },
            new()
                {
                    Id = new Guid("D3ADED67-0605-461A-87A6-9326445AD365"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기초",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "cơ sở, nền tảng ban đầu",
                },
            new()
                {
                    Id = new Guid("43390EF7-198B-45AB-B731-5C1F22FB9E61"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기타",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "khác, vân vân",
                },
            new()
                {
                    Id = new Guid("95E67E62-DCFF-47D0-88E1-4A9D3526185F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기혼",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự có gia đình",
                },
            new()
                {
                    Id = new Guid("17B4200A-6244-42B2-89BB-489392D7DC38"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기획",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "kế hoạch, dự án, đề án",
                },
            new()
                {
                    Id = new Guid("9B1E3D97-3033-427A-B84E-AB9D2E02594F"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "기후",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "thời tiết",
                },
            new()
                {
                    Id = new Guid("5BC37F05-56A9-432C-8748-7D5E17438F61"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "긴급",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "sự khẩn cấp, sự cần kíp, sự cấp bách",
                },
            new()
                {
                    Id = new Guid("7D170457-A7C5-411C-9592-474B3D734A6C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "긴장하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "căng thẳng",
                },
            new()
                {
                    Id = new Guid("B18531A0-3A10-43C3-9119-73BCF9FF6739"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "긴팔",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "tai dài, áo tay dài",
                },
            new()
                {
                    Id = new Guid("74EF7B69-F270-4672-8C8C-B35C67D7A9A2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "길가",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "lề đường, vệ đường, bên đường",
                },
            new()
                {
                    Id = new Guid("50CDB0CC-6F92-40BE-A13F-D97468408CC4"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "길거리",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "đường, đường phố",
                },
            new()
                {
                    Id = new Guid("33145E04-83B1-4AA8-8950-AFC40F5966BD"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "길다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "mọc dài ra, dài ra",
                },
            new()
                {
                    Id = new Guid("FB53F140-FB76-4183-B4A7-456684D9ECEB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "김",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "hơi, hơi nước",
                },
            new()
                {
                    Id = new Guid("70EA47B9-BE8A-4730-AE42-FFCD1536A25A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "김포공항",
                    Level = "Intermediate",
                    Type = "Proper Noun",
                    MeaningVietNamese = "김포공항",
                },
            new()
                {
                    Id = new Guid("475D1617-2461-4765-BE7F-F7A0A601E416"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깊이",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "độ sâu",
                },
            new()
                {
                    Id = new Guid("F8DBF939-E789-4BD3-8F84-794E00BE07BC"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "까다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "bóc, lột",
                },
            new()
                {
                    Id = new Guid("25D8B6B8-8FBE-4C36-BDC5-FA73D33011E1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "까다롭다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "cầu kỳ, rắc rối",
                },
            new()
                {
                    Id = new Guid("470F4F1A-C0E4-4BD5-B304-09ECD2CA6D8C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "까닭",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "lý do, nguyên nhân, căn nguyên",
                },
            new()
                {
                    Id = new Guid("0B38C577-BA54-4FCA-A03F-2B4D172A030B"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "까먹다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "gặm",
                },
            new()
                {
                    Id = new Guid("F4F6AD07-8B78-4699-BC31-B14A8F87EA77"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깔끔하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "tươm tất, gọn gàng",
                },
            new()
                {
                    Id = new Guid("26120913-3C38-4D11-B6BA-93616E45521A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깔다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "trải",
                },
            new()
                {
                    Id = new Guid("4A4CF3AF-1176-46CC-A769-C358C2498D3D"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깔리다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "được trải, được giải",
                },
            new()
                {
                    Id = new Guid("BDE5348C-3EA3-4D8B-BEB9-AA73E3BA5D9A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깜깜하다",
                    Level = "Intermediate",
                    Type = "Adjective",
                    MeaningVietNamese = "tối đen",
                },
            new()
                {
                    Id = new Guid("FB05CDAF-1EBC-406A-A96E-87B7970116E1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깜박하다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "lấp lánh, nhấp nháy",
                },
            new()
                {
                    Id = new Guid("820CDED8-7663-4663-80A0-084BBA87BFA2"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깜빡",
                    Level = "Intermediate",
                    Type = "Adverb",
                    MeaningVietNamese = "chớp, lóe",
                },
            new()
                {
                    Id = new Guid("60466BFE-BE04-4585-949A-1B3E50F41C0A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깨",
                    Level = "Intermediate",
                    Type = "Noun",
                    MeaningVietNamese = "vừng, mè",
                },
            new()
                {
                    Id = new Guid("C85C1160-1738-4A7C-8189-CF429CA338AE"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깨다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "tỉnh ra, tỉnh lại",
                },
            new()
                {
                    Id = new Guid("9D218363-7D74-4EE2-9C97-C1529F65CAA1"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깨닫다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "nhận biết, ngộ ra",
                },
            new()
                {
                    Id = new Guid("DE38B39C-858B-4FE7-95F8-BF6FA78B35FB"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깨뜨리다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "làm vỡ, làm bể",
                },
            new()
                {
                    Id = new Guid("75F8A523-13FC-475B-9F91-AF8CF30FE13A"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깨물다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "cắn",
                },
            new()
                {
                    Id = new Guid("C8EE9DD8-B73B-40D6-A1CB-083CE238F32C"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깨어나다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "tỉnh dậy",
                },
            new()
                {
                    Id = new Guid("78AA265D-6D52-4307-94F0-511C817937A9"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깨우다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "đánh thức, vực tỉnh dậy",
                },
            new()
                {
                    Id = new Guid("912747A5-D61E-4CF7-BA0A-FC1BB6E6E541"),
                    LessonId = AppDbContext.LessonId2,
                    Word = "깨지다",
                    Level = "Intermediate",
                    Type = "Verb",
                    MeaningVietNamese = "bị đập tan, bị đập vỡ, bị vỡ tan",
                },
            new()
                {
                    Id = new Guid("2473B5C0-4C8B-4881-9640-33A90F6330BD"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가구",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "hộ gia đình",
                },
            new()
                {
                    Id = new Guid("0CB24DF4-8979-4130-89B6-50E8D3B43C4D"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가능해지다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "가능해지다",
                },
            new()
                {
                    Id = new Guid("ADF6073A-3AED-41F6-AE75-4B3ED44E023F"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가려지다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "bị che khuất, bị che lấp",
                },
            new()
                {
                    Id = new Guid("9BDE1D2D-02F5-401E-8DCE-D1F56335CDF3"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가령",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "giả sử, nếu",
                },
            new()
                {
                    Id = new Guid("81B86CD6-66B8-4428-8745-ECDF28E02DD9"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가로수",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "cây ven đường",
                },
            new()
                {
                    Id = new Guid("593C2E91-EA4E-441D-9603-DDA428899165"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가르침",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "sự chỉ dạy, sự dạy bảo",
                },
            new()
                {
                    Id = new Guid("002512BC-4AE3-471E-8A63-2A46B51D24B6"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가상",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "sự giả tưởng",
                },
            new()
                {
                    Id = new Guid("DD39AC68-FC66-4336-BC55-6F0AE9390CF6"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가입하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "gia nhập, tham gia",
                },
            new()
                {
                    Id = new Guid("976D3630-DA55-47E1-A785-218F5684ABCD"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가정교사",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "가정교사",
                },
            new()
                {
                    Id = new Guid("046B2AB4-5B12-4064-914A-1CBD8230C17E"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "가하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "gây (áp lực, sức ép)",
                },
            new()
                {
                    Id = new Guid("E50471AA-54A6-49BD-9FE4-B5667BE2E162"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "각기",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "từng người, từng cái",
                },
            new()
                {
                    Id = new Guid("EB05C429-2589-47EF-842B-EECF7606648C"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "간부",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "cán bộ",
                },
            new()
                {
                    Id = new Guid("54DC2312-8E8B-4C0C-AC34-8D1DCEEE4F90"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "간접",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "(sự) gián tiếp",
                },
            new()
                {
                    Id = new Guid("9DC4302E-8B62-4524-834C-BE65E258C93B"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "감",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "quả hồng",
                },
            new()
                {
                    Id = new Guid("A8B62FE7-BFB7-4259-9269-4B4B43FBC190"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "감독",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "sự giám sát",
                },
            new()
                {
                    Id = new Guid("3307ED4F-D711-41C7-A173-851616739BED"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "감소되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "bị giảm sút, bị giảm bớt",
                },
            new()
                {
                    Id = new Guid("5CBBB624-0BAE-41AD-AC92-DA1E50E74929"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "감소하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "giảm, giảm sút, giảm đi",
                },
            new()
                {
                    Id = new Guid("9E019F6C-5AC5-498E-8460-E040B948A762"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "감수성",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "tính nhạy cảm, sự nhạy cảm",
                },
            new()
                {
                    Id = new Guid("8BCED3B5-C5AB-4D9B-928B-FCB9D6EF8AAC"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "감정적",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "tính tình cảm, tính cảm tính",
                },
            new()
                {
                    Id = new Guid("0F4DD2D8-5296-4F3F-B778-8902B4A179F8"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "갑",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "bên A",
                },
            new()
                {
                    Id = new Guid("114835C4-47E8-4DE4-AAEB-081E6F207F36"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강남",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "phía nam sông",
                },
            new()
                {
                    Id = new Guid("2257935F-0309-40E0-9BCA-182BBF6B63F6"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강도",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "độ bền, độ vững chắc",
                },
            new()
                {
                    Id = new Guid("70EEEDA4-5F1D-46C3-8059-B802984C59DC"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강력하다",
                    Level = "Advanced",
                    Type = "Adjective",
                    MeaningVietNamese = "cường tráng, mạnh mẽ",
                },
            new()
                {
                    Id = new Guid("4D7D8895-97C5-4C33-B32A-A2675E95F5D1"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강력히",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "một cách cường tráng, một cách mạnh mẽ",
                },
            new()
                {
                    Id = new Guid("45E51448-BB41-4F99-821B-82ECD7D5F68A"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강렬하다",
                    Level = "Advanced",
                    Type = "Adjective",
                    MeaningVietNamese = "mạnh mẽ, kiên quyết, quyết liệt",
                },
            new()
                {
                    Id = new Guid("CE6D1F39-82C2-413E-A664-228622DD0C7D"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강변",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "bờ sông, mép sông",
                },
            new()
                {
                    Id = new Guid("0A628F11-9587-4AA0-B043-8276070A6BCF"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강북",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "bờ bắc",
                },
            new()
                {
                    Id = new Guid("402F2E99-1894-466C-8298-BE7EDACF7BA9"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강요하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "bắt buộc, ép buộc, cưỡng bức",
                },
            new()
                {
                    Id = new Guid("D8631F12-73F5-4262-BF25-F048BD9B940C"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강의하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "giảng dạy",
                },
            new()
                {
                    Id = new Guid("0D8F0A2E-DFC0-495D-A7C0-D499F64581A1"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "강화하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "tăng cường",
                },
            new()
                {
                    Id = new Guid("691216CF-2439-457A-9F3A-FE863BEF18C1"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "같이하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "cùng nhau",
                },
            new()
                {
                    Id = new Guid("09C06AF6-E57B-4F78-89DD-08EB98427FA3"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "개개인",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "mỗi người, từng người",
                },
            new()
                {
                    Id = new Guid("8E25CCEF-6DC0-4D6C-B66B-97FEAC29F0C7"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "개국",
                    Level = "Advanced",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "sự khánh thành, sự khai trương",
                },
            new()
                {
                    Id = new Guid("BEF3F4B7-79ED-455D-91D1-1F76BF06E296"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "개발되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "được khai khẩn, được khai thác",
                },
            new()
                {
                    Id = new Guid("43F699C5-F241-408C-B9EE-5427F62950AF"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "개방되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "được mở ra",
                },
            new()
                {
                    Id = new Guid("2AB58B05-ADED-4126-B9F3-D15EF18C06C0"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "개방하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "mở ra",
                },
            new()
                {
                    Id = new Guid("C71A2024-430B-45BA-9486-155DE189970D"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "개선되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "được cải tiến, được cải thiện",
                },
            new()
                {
                    Id = new Guid("26F86433-83C3-406B-B743-62CED9DA25EC"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "개선하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "cải tiến, cải thiện",
                },
            new()
                {
                    Id = new Guid("243B4BF2-BD05-46F4-8580-187DB8F075FE"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "거대하다",
                    Level = "Advanced",
                    Type = "Adjective",
                    MeaningVietNamese = "lớn lao, to lớn, vĩ đại",
                },
            new()
                {
                    Id = new Guid("D348A6EB-FE5D-4895-8DF5-FD9193E3BF80"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "거듭",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "cứ, hoài",
                },
            new()
                {
                    Id = new Guid("979647B9-7ADC-4428-B9E1-F8E537339D71"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "거부하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "từ chối, khước từ",
                },
            new()
                {
                    Id = new Guid("7DF0B0BA-2163-480D-9579-890B61C4EC9A"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "거액",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "số tiền lớn",
                },
            new()
                {
                    Id = new Guid("587BC3B6-B4F4-4A09-806C-C4C4DB8AF41F"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "거절하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "từ chối, khước từ",
                },
            new()
                {
                    Id = new Guid("B3631F58-F93F-436A-9D58-B99D173B18A7"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "건",
                    Level = "Advanced",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "vụ, hồ sơ",
                },
            new()
                {
                    Id = new Guid("B6BF4C45-D83E-4387-9E11-CE7783BC77AC"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "건넌방",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "phòng đối diện",
                },
            new()
                {
                    Id = new Guid("3869A054-3145-4965-AAFB-58A6A334CEA7"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "건설되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "được xây dựng",
                },
            new()
                {
                    Id = new Guid("FCD5A023-4C15-49CC-894C-7CD8589F9FBC"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "건설하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "xây dựng",
                },
            new()
                {
                    Id = new Guid("870D18E1-085E-4CF0-B3AD-56F36DC233F2"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "건전하다",
                    Level = "Advanced",
                    Type = "Adjective",
                    MeaningVietNamese = "tích cực, lành mạnh",
                },
            new()
                {
                    Id = new Guid("E51BC5D0-5931-40A9-BD51-4ED83B53F407"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "건조하다",
                    Level = "Advanced",
                    Type = "Adjective",
                    MeaningVietNamese = "kiến tạo, kiến thiết",
                },
            new()
                {
                    Id = new Guid("48887D99-482C-4AF1-9341-95EC6BAA8A9B"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "걷기",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "việc đi bộ",
                },
            new()
                {
                    Id = new Guid("94D3E290-560D-49E5-ACDA-45A69B635845"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "겨자",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "cây  mù tạt",
                },
            new()
                {
                    Id = new Guid("8C6CFF2E-3DE8-446B-9245-1794235A570D"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "결과적",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "về mặt kết quả",
                },
            new()
                {
                    Id = new Guid("F97EC87D-236E-4061-B0D3-7CD794F44FC7"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "결석하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "vắng mặt",
                },
            new()
                {
                    Id = new Guid("F1FC44D6-6243-482B-B4D2-8D35BDA01556"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "경고하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "cảnh báo",
                },
            new()
                {
                    Id = new Guid("6F532C56-0E50-4F7A-ACFA-530A96E96268"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "경영하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "kinh doanh",
                },
            new()
                {
                    Id = new Guid("A8BAAA64-2BFA-4FB7-8D5B-929391659387"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "경제학",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "kinh tế học",
                },
            new()
                {
                    Id = new Guid("117229F5-3809-4AA4-9C55-C9273E4ED95F"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "고개",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "cổ, gáy",
                },
            new()
                {
                    Id = new Guid("EF02AAB8-4D44-40C6-8B26-4AC890481B32"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "고구려",
                    Level = "Advanced",
                    Type = "Proper Noun",
                    MeaningVietNamese = "Goguryeo, Cao Câu Ly",
                },
            new()
                {
                    Id = new Guid("25F9EEB4-D976-4D90-BB2D-89636795DC4A"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "고려",
                    Level = "Advanced",
                    Type = "Proper Noun",
                    MeaningVietNamese = "sự cân nhắc, sự đắn đo",
                },
            new()
                {
                    Id = new Guid("C10191DD-5ED4-4D58-9AB4-FDF55C2D54B7"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "고무신",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "Gomusin; giày cao su",
                },
            new()
                {
                    Id = new Guid("C60F60DA-470A-471E-AED4-D105C4B6C004"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "고요하다",
                    Level = "Advanced",
                    Type = "Adjective",
                    MeaningVietNamese = "yên ắng, tĩnh mịch, trầm mặc",
                },
            new()
                {
                    Id = new Guid("40E58AF7-5BA0-4446-ADC6-CC8174D5ED4C"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "고작",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "hầu như không",
                },
            new()
                {
                    Id = new Guid("CA7CAEFC-0659-41A9-B421-C8503D1AF45B"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "고집하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "cố chấp",
                },
            new()
                {
                    Id = new Guid("3375D141-5D07-4343-9A9D-384A82CB6E4E"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "고함",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "tiếng la hét, tiếng rống",
                },
            new()
                {
                    Id = new Guid("683ACB0A-939C-47D0-8013-224B168DA966"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "곤란하다",
                    Level = "Advanced",
                    Type = "Adjective",
                    MeaningVietNamese = "khó khăn",
                },
            new()
                {
                    Id = new Guid("F385E393-B18B-4F30-B8D1-EE3495BAEF25"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "골짜기",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "hẻm núi, thung lũng",
                },
            new()
                {
                    Id = new Guid("45AD3A65-BD07-4100-9DDD-624314448A6B"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "골치",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "cái đầu",
                },
            new()
                {
                    Id = new Guid("AE7BCAA7-C6C5-470C-9EFC-D4369809C3C2"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공개하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "công khai",
                },
            new()
                {
                    Id = new Guid("02622A8E-850B-47E7-940D-03D07F4908B0"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공격하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "công kích, tấn công",
                },
            new()
                {
                    Id = new Guid("B0EF6ED9-75FF-4886-A485-65E283892059"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공군",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "không quân",
                },
            new()
                {
                    Id = new Guid("A4EFF7DA-B695-40EB-8D2F-57D735920203"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공식적",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "tính chính thức",
                },
            new()
                {
                    Id = new Guid("68782ED6-9CB8-4967-90C2-EB0FB4A1B204"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공연되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "được biểu diễn, được công diễn",
                },
            new()
                {
                    Id = new Guid("79AB3A5E-D3EC-45AA-BC9D-18E5F242F86F"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공연하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "trình diễn, công diễn, biểu diễn",
                },
            new()
                {
                    Id = new Guid("0CF5A010-0CA5-4519-8543-D93F0AE8D92C"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공연히",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "vớ vẩn, lãng xẹt",
                },
            new()
                {
                    Id = new Guid("4D8A3E74-86D4-46FC-8E66-D5C15EC7C6ED"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공중",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "công chúng",
                },
            new()
                {
                    Id = new Guid("5E113CF6-4C1A-4AA7-B3EA-481B12C75481"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공통되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "chung, giống nhau",
                },
            new()
                {
                    Id = new Guid("14204B44-C629-4BC1-9170-F6F163C9DC76"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "공통적",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "tính chung",
                },
            new()
                {
                    Id = new Guid("9E199BA9-8AF4-4A71-B056-A3B1D1C19FB4"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "과",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "khoa",
                },
            new()
                {
                    Id = new Guid("0A75F728-BB9B-4F55-887D-CD7D143A2B21"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "과거",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "khoa cử",
                },
            new()
                {
                    Id = new Guid("24437AA8-1598-4967-8FCE-31A8CCBFBCE2"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "과정",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "quá trình",
                },
            new()
                {
                    Id = new Guid("7A85C30F-A864-4ACA-8BAD-9803D0A763C8"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "관계되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "có liên quan, có quan hệ",
                },
            new()
                {
                    Id = new Guid("41168AC3-0FDB-4DDE-AF15-DD1F2F3C9E58"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "관광버스",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "xe tham quan, xe du lịch",
                },
            new()
                {
                    Id = new Guid("E8580F6B-DBF2-4B25-938B-7C24FBBC28C4"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "관념",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "quan  niệm",
                },
            new()
                {
                    Id = new Guid("D67730B0-B8E1-49DB-AD36-92F1B2DD0E19"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "관리",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "cán bộ quản lý, quan lại, quan chức",
                },
            new()
                {
                    Id = new Guid("F042A507-2712-419B-9B37-FCC4B637BCF0"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "관리하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "quản lý",
                },
            new()
                {
                    Id = new Guid("8F38F7B7-C8E0-4F0C-9D09-20F2D5060F99"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "관습",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "thói quen, tập quán",
                },
            new()
                {
                    Id = new Guid("B2368E95-EE84-4C22-9403-755B9B22B73C"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "광장",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "quảng trường",
                },
            new()
                {
                    Id = new Guid("7640C3BA-8E8E-4541-876E-E3295277652D"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "교직",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "nghề giáo",
                },
            new()
                {
                    Id = new Guid("DB1D9351-1263-4833-9AE0-9EADCFCB2CEE"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "교환하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "đổi, hoán đổi",
                },
            new()
                {
                    Id = new Guid("C91F1CA6-D3BE-456C-80A2-9E90305250D4"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구별되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "được phân biệt",
                },
            new()
                {
                    Id = new Guid("74D85A4A-EE6B-4815-88AC-0A7764FD7F9A"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구별하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "phân biệt",
                },
            new()
                {
                    Id = new Guid("C0546D40-F99B-403D-8E25-69F91BDD4B88"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구분되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "được phân loại",
                },
            new()
                {
                    Id = new Guid("82EB5EAC-3E6C-4B39-AEF6-35B60EAFD811"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구분하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "phân loại",
                },
            new()
                {
                    Id = new Guid("2DE76ACF-8EA5-437D-BFE7-31179B3643E4"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구석구석",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "khắp nơi",
                },
            new()
                {
                    Id = new Guid("6319B01E-0158-4CDD-BBFD-55CE14106BD9"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구성되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "được cấu thành, được tạo ra",
                },
            new()
                {
                    Id = new Guid("FA6349D0-4C25-4E78-94B6-A046302E1B01"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구성하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "tạo thành, làm ra, cấu thành",
                },
            new()
                {
                    Id = new Guid("4160A384-4ACD-401E-B89A-548B5B82A6A9"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구속되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "bị giới hạn, bị kiềm chế, bị ràng buộc, bị khống chế",
                },
            new()
                {
                    Id = new Guid("45FBDE20-5E2E-4DD3-ACCB-C19D69C29B0D"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구속하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "khống chế, ràng buộc",
                },
            new()
                {
                    Id = new Guid("1A7CC1EC-6E44-485A-B188-6DB52E919791"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구입하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "mua, mua vào",
                },
            new()
                {
                    Id = new Guid("D793AF10-79D3-4605-9356-40A1A07D084F"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "구청",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "Gu-cheong, ủy ban quận",
                },
            new()
                {
                    Id = new Guid("408D8EA5-F99B-48EC-A9E0-03829211257B"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "국가적",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "tính quốc gia",
                },
            new()
                {
                    Id = new Guid("B5393CDD-5B29-4481-B1AD-F303FD5DD908"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "국내외",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "trong và ngoài nước",
                },
            new()
                {
                    Id = new Guid("F1D04515-1803-48BB-937F-2B8549815BDD"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "국민적",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "tính toàn dân",
                },
            new()
                {
                    Id = new Guid("C82F141B-4E49-42F0-97BE-39A3ABAE86A2"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "국사",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "quốc sử",
                },
            new()
                {
                    Id = new Guid("367E7881-DE5F-49A5-97DE-9C520CF85153"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "국왕",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "quốc vương",
                },
            new()
                {
                    Id = new Guid("E179EDC4-9700-4E3D-AA38-0C728A17B50A"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "국제적",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "mang tính cục bộ",
                },
            new()
                {
                    Id = new Guid("A765FE25-A4C0-43BB-9C9D-7D35BE2C10D9"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "군사",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "quân sĩ",
                },
            new()
                {
                    Id = new Guid("F73CAA6F-B4C5-416B-85F6-935B7749B2AE"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "굳히다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "làm cho đông, làm cho cứng",
                },
            new()
                {
                    Id = new Guid("4579D2E7-D953-4D60-9A9E-BFCB769DB8BD"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "궁극적",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "tính cùng cực",
                },
            new()
                {
                    Id = new Guid("87561179-7D2D-4009-BDC9-10C9F0C9023F"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "귀가하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "về nhà, trở về nhà, đi về nhà",
                },
            new()
                {
                    Id = new Guid("89933D8C-ECC1-4DFF-A648-0DCA52E97D2D"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "귓속",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "trong tai",
                },
            new()
                {
                    Id = new Guid("972691C4-6CC8-4F2C-931F-C536963A7AC4"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그간",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "trong khoảng đó, trong khi ấy, trong lúc ấy",
                },
            new()
                {
                    Id = new Guid("5182C7BF-CCB3-46FF-908B-A2F2FBD40359"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그놈",
                    Level = "Advanced",
                    Type = "Pronoun",
                    MeaningVietNamese = "그놈",
                },
            new()
                {
                    Id = new Guid("7A87F5C1-BFA4-4589-AF29-8E4F0A40EB80"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그때그때",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "những lúc ấy, những lúc đó",
                },
            new()
                {
                    Id = new Guid("5EF2ED6A-A24B-41C8-9552-F9777E1B41E2"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그래야",
                    Level = "Advanced",
                    Type = "Abbreviated",
                    MeaningVietNamese = "그리하여야",
                },
            new()
                {
                    Id = new Guid("5C05FD65-6E0F-4D66-AB8F-5EE1A8CAFEF2"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그래픽",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "đồ hoạ, hoạ đồ",
                },
            new()
                {
                    Id = new Guid("8902B8B6-D43D-4AE5-B9C5-87438438FAF5"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그럴듯하다",
                    Level = "Advanced",
                    Type = "Adjective",
                    MeaningVietNamese = "hợp lý, hợp lẽ",
                },
            new()
                {
                    Id = new Guid("EC66471A-71C8-4D1E-9ADE-D67B6906BCFA"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그루",
                    Level = "Advanced",
                    Type = "Dependent Noun",
                    MeaningVietNamese = "gốc (cây)",
                },
            new()
                {
                    Id = new Guid("D71B277E-009F-4321-B3F9-177FD009CCEE"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그리로",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "nơi ấy, chỗ ấy",
                },
            new()
                {
                    Id = new Guid("A5094B70-8CD0-48C3-8917-F22A358FFD06"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그리워하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "nhớ, nhớ nhung",
                },
            new()
                {
                    Id = new Guid("C64811DD-9A71-44CB-9338-D597606B314A"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그리하여",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "làm thế, làm vậy",
                },
            new()
                {
                    Id = new Guid("DD6FB704-D7B8-4FBC-AA39-A6F233FF9D65"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그사이",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "giữa lúc đó, trong khi đó, trong lúc ấy",
                },
            new()
                {
                    Id = new Guid("32B49C88-4B4C-4327-A757-F802CBD03FFA"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그이",
                    Level = "Advanced",
                    Type = "Pronoun",
                    MeaningVietNamese = "người ấy",
                },
            new()
                {
                    Id = new Guid("CC64917B-08AB-4BF1-82B2-D48D280DB0B0"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그전",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "trước đó, trước đấy",
                },
            new()
                {
                    Id = new Guid("5819F3A1-1E45-48EE-8B51-8EB482E26939"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "그제서야",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "그제서야",
                },
            new()
                {
                    Id = new Guid("1C0567A0-FFEA-4DD9-99C6-7C553FA2300A"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "극",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "cực độ, tột điểm, cùng cực",
                },
            new()
                {
                    Id = new Guid("08A8E370-23F0-4151-9C8D-E56323367CF9"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "극복하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "khắc phục",
                },
            new()
                {
                    Id = new Guid("D27BA922-0FDC-4A91-B56A-649B591C63BB"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "극작가",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "nhà biên kịch, nhà soạn kịch",
                },
            new()
                {
                    Id = new Guid("109893DC-DBDA-46A1-8134-34F2E70C4BA9"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "근거하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "trên cơ sở, căn cứ vào",
                },
            new()
                {
                    Id = new Guid("7A9688FA-D701-45B8-97FE-39CD0D90F6F3"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "근로",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "(sự) cần lao, sự cần cù lao động",
                },
            new()
                {
                    Id = new Guid("7200F0C8-19A2-4EF0-B957-36DEB4BDE547"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "근원",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "khởi nguồn, đầu nguồn",
                },
            new()
                {
                    Id = new Guid("F460112F-897B-404E-B3BD-F10BE7C14CB8"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "금",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "vết rạn, vết nứt, vết nhăn",
                },
            new()
                {
                    Id = new Guid("9E40CDA7-ED18-4B2E-BDC0-A30984A125C9"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "금강산",
                    Level = "Advanced",
                    Type = "Proper Noun",
                    MeaningVietNamese = "Geumgang-san, núi Geumgang (Kim Cương)",
                },
            new()
                {
                    Id = new Guid("A70D6EE2-2CFD-4540-9B7F-0A55C50D5727"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "금고",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "két, kho báu",
                },
            new()
                {
                    Id = new Guid("824718DC-C299-484E-90E5-95C94F4E45AB"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "금메달",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "huy chương vàng",
                },
            new()
                {
                    Id = new Guid("5FEB02A2-CE8B-413F-A317-7598D09D7687"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "금세",
                    Level = "Advanced",
                    Type = "Adverb",
                    MeaningVietNamese = "ngay, nhanh chóng",
                },
            new()
                {
                    Id = new Guid("B4B807D0-77C8-4A72-8B69-58CAB98949EC"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "금지되다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "bị cấm đoán, bị cấm",
                },
            new()
                {
                    Id = new Guid("42B2873B-3732-438B-9924-8B403DF7B73F"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "급증하다",
                    Level = "Advanced",
                    Type = "Verb",
                    MeaningVietNamese = "tăng nhanh, tăng gấp",
                },
            new()
                {
                    Id = new Guid("C2F7C426-5C6E-490C-8386-A44C205B7E76"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "기",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "sinh khí, nhuệ khí",
                },
            new()
                {
                    Id = new Guid("3D1C0F57-0D6D-4F95-87C1-8F7DCBB89B62"),
                    LessonId = AppDbContext.LessonId3,
                    Word = "기",
                    Level = "Advanced",
                    Type = "Noun",
                    MeaningVietNamese = "sinh khí, nhuệ khí",
                },
        };

        builder.HasData(vocabularies);
    }
}
