// Auto-generated — LessonConfiguration
using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KimChiTalk.Repository.Configurations;

public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.Property(l => l.Title).HasMaxLength(128).IsRequired();

        var lessons = new List<Lesson>()
        {
            new()
            {
                Id = new Guid("5F719033-8948-49C6-9B1C-A70E0DA9B58C"),
                Title = "Công việc & Học tập",
                CourseId = AppDbContext.CourseId1,
                Order = 1,
            },
            new()
            {
                Id = new Guid("71AED010-44CA-4125-A0BF-0D684AFFB031"),
                Title = "Cơ thể & Sức khỏe",
                CourseId = AppDbContext.CourseId1,
                Order = 2,
            },
            new()
            {
                Id = new Guid("902BD8BE-46B9-4606-8C84-C83B1851966D"),
                Title = "Cảm xúc & Tính cách",
                CourseId = AppDbContext.CourseId1,
                Order = 3,
            },
            new()
            {
                Id = new Guid("B0A8FDB7-1A9A-40BC-8B99-D7660820F72B"),
                Title = "Danh từ thông dụng 1",
                CourseId = AppDbContext.CourseId1,
                Order = 4,
            },
            new()
            {
                Id = new Guid("181DF7A7-B4D5-4575-987D-87B8871692B8"),
                Title = "Danh từ thông dụng 2",
                CourseId = AppDbContext.CourseId1,
                Order = 5,
            },
            new()
            {
                Id = new Guid("A08893FC-A436-4A85-BC5F-C1FFAD35D1E8"),
                Title = "Gia đình & Con người 1",
                CourseId = AppDbContext.CourseId1,
                Order = 6,
            },
            new()
            {
                Id = new Guid("918C686B-AEA1-4658-8467-E4A0AF482178"),
                Title = "Gia đình & Con người 2",
                CourseId = AppDbContext.CourseId1,
                Order = 7,
            },
            new()
            {
                Id = new Guid("894BD7AD-1C9D-4393-9735-3715C818BA93"),
                Title = "Hành động thường ngày",
                CourseId = AppDbContext.CourseId1,
                Order = 8,
            },
            new()
            {
                Id = new Guid("70E7309C-7FCB-48EF-A22A-AECC8B57FEE9"),
                Title = "Nhà cửa & Đồ vật",
                CourseId = AppDbContext.CourseId1,
                Order = 9,
            },
            new()
            {
                Id = new Guid("338075FD-99BB-4FE7-BF44-640F1CEF2C1F"),
                Title = "Số lượng & Đo lường",
                CourseId = AppDbContext.CourseId1,
                Order = 10,
            },
            new()
            {
                Id = new Guid("1AF5B5D6-EDE1-4E7C-939B-9C0F8BDAD23A"),
                Title = "Thời gian & Ngày tháng",
                CourseId = AppDbContext.CourseId1,
                Order = 11,
            },
            new()
            {
                Id = new Guid("79CABD7D-83E3-4320-BB24-78E581D87453"),
                Title = "Trạng từ thông dụng",
                CourseId = AppDbContext.CourseId1,
                Order = 12,
            },
            new()
            {
                Id = new Guid("A4C81B67-A1E6-457C-806E-DB105F77DA83"),
                Title = "Tính từ mô tả chung",
                CourseId = AppDbContext.CourseId1,
                Order = 13,
            },
            new()
            {
                Id = new Guid("6FC00419-1D75-4E9E-8770-4BD956553449"),
                Title = "Tính từ thông dụng",
                CourseId = AppDbContext.CourseId1,
                Order = 14,
            },
            new()
            {
                Id = new Guid("29F282DC-BB1B-4A7F-B8EE-AFA9C3F71505"),
                Title = "Đi lại & Địa điểm",
                CourseId = AppDbContext.CourseId1,
                Order = 15,
            },
            new()
            {
                Id = new Guid("10C5DE2F-E85B-4944-BCCA-BA0FA12CBE6F"),
                Title = "Đồ ăn & Thức uống",
                CourseId = AppDbContext.CourseId1,
                Order = 16,
            },
            new()
            {
                Id = new Guid("8C7BE511-46D1-4E46-879D-BFD295171B09"),
                Title = "Động từ thông dụng",
                CourseId = AppDbContext.CourseId1,
                Order = 17,
            },
            new()
            {
                Id = new Guid("CAA9DC19-B472-4888-9590-23B5A585559E"),
                Title = "Từ vựng bổ sung",
                CourseId = AppDbContext.CourseId1,
                Order = 18,
            },
            new()
            {
                Id = new Guid("E4AC0098-B443-4A0D-AD5D-DD24930595DC"),
                Title = "Công việc & Học tập",
                CourseId = AppDbContext.CourseId2,
                Order = 1,
            },
            new()
            {
                Id = new Guid("764C970F-7227-4E7D-BA2F-36F08628A089"),
                Title = "Cơ thể & Sức khỏe",
                CourseId = AppDbContext.CourseId2,
                Order = 2,
            },
            new()
            {
                Id = new Guid("4D149C1E-7BE5-4CD4-9D8C-1DCFB7CA8D61"),
                Title = "Cảm xúc & Tính cách",
                CourseId = AppDbContext.CourseId2,
                Order = 3,
            },
            new()
            {
                Id = new Guid("0F09C264-36BA-420A-9974-50D6C795E737"),
                Title = "Danh từ riêng",
                CourseId = AppDbContext.CourseId2,
                Order = 4,
            },
            new()
            {
                Id = new Guid("C0489C93-10D7-43C0-A251-C776892428A8"),
                Title = "Danh từ thông dụng 1",
                CourseId = AppDbContext.CourseId2,
                Order = 5,
            },
            new()
            {
                Id = new Guid("2F153276-31BF-4103-A454-597FBD2CA9DB"),
                Title = "Danh từ thông dụng 2",
                CourseId = AppDbContext.CourseId2,
                Order = 6,
            },
            new()
            {
                Id = new Guid("2B73F837-1B01-4ADD-83A9-C261CFA48B2D"),
                Title = "Danh từ thông dụng 3",
                CourseId = AppDbContext.CourseId2,
                Order = 7,
            },
            new()
            {
                Id = new Guid("90007D6F-AD22-4EBF-A64D-E34E5FD4F54C"),
                Title = "Danh từ thông dụng 4",
                CourseId = AppDbContext.CourseId2,
                Order = 8,
            },
            new()
            {
                Id = new Guid("76975282-F2D8-4670-9BA6-E1377C6F2735"),
                Title = "Danh từ thông dụng 5",
                CourseId = AppDbContext.CourseId2,
                Order = 9,
            },
            new()
            {
                Id = new Guid("30BF25BB-8BB7-4617-9042-9A0435C88A05"),
                Title = "Gia đình & Con người 1",
                CourseId = AppDbContext.CourseId2,
                Order = 10,
            },
            new()
            {
                Id = new Guid("0683B25D-AFD3-4757-BC4D-DD9591876D73"),
                Title = "Gia đình & Con người 2",
                CourseId = AppDbContext.CourseId2,
                Order = 11,
            },
            new()
            {
                Id = new Guid("E1065344-1F3D-4044-9AFD-6DE46482650A"),
                Title = "Gia đình & Con người 3",
                CourseId = AppDbContext.CourseId2,
                Order = 12,
            },
            new()
            {
                Id = new Guid("EA8671EC-0C1E-4758-84F9-33E99279DC85"),
                Title = "Hành động thường ngày",
                CourseId = AppDbContext.CourseId2,
                Order = 13,
            },
            new()
            {
                Id = new Guid("9BFFC0DB-C3D4-4132-81AC-B275DFB37866"),
                Title = "Nhà cửa & Đồ vật",
                CourseId = AppDbContext.CourseId2,
                Order = 14,
            },
            new()
            {
                Id = new Guid("91DCD658-2C32-4C8B-9711-1C64B458B72F"),
                Title = "Số lượng & Đo lường",
                CourseId = AppDbContext.CourseId2,
                Order = 15,
            },
            new()
            {
                Id = new Guid("8FBA85F1-D694-4A68-A949-48A98E52C527"),
                Title = "Thời gian & Ngày tháng",
                CourseId = AppDbContext.CourseId2,
                Order = 16,
            },
            new()
            {
                Id = new Guid("FFA3FFA2-F5E1-48C9-ABA8-7FD1DB6BD4D7"),
                Title = "Thời tiết & Thiên nhiên",
                CourseId = AppDbContext.CourseId2,
                Order = 17,
            },
            new()
            {
                Id = new Guid("CEDAACFF-EA5A-491E-B22B-6AAC1F5CAA90"),
                Title = "Trạng từ thông dụng",
                CourseId = AppDbContext.CourseId2,
                Order = 18,
            },
            new()
            {
                Id = new Guid("EBAF5DB7-E403-42A5-86EA-E2F686ED0247"),
                Title = "Tính từ mô tả chung",
                CourseId = AppDbContext.CourseId2,
                Order = 19,
            },
            new()
            {
                Id = new Guid("A4A7DDDF-D683-40D4-BBC8-4C618D5B0912"),
                Title = "Tính từ thông dụng",
                CourseId = AppDbContext.CourseId2,
                Order = 20,
            },
            new()
            {
                Id = new Guid("6015F4DA-70F1-41F8-9CE8-4849DDC2E4F7"),
                Title = "Từ hạn định",
                CourseId = AppDbContext.CourseId2,
                Order = 21,
            },
            new()
            {
                Id = new Guid("E000202B-A1F4-477B-ADC3-D7E201E0130C"),
                Title = "Đi lại & Địa điểm 1",
                CourseId = AppDbContext.CourseId2,
                Order = 22,
            },
            new()
            {
                Id = new Guid("DEA501A2-3BBD-4442-95CA-9BC0F9108B92"),
                Title = "Đồ ăn & Thức uống 1",
                CourseId = AppDbContext.CourseId2,
                Order = 23,
            },
            new()
            {
                Id = new Guid("6EB6FE3D-3C6A-4982-A5AE-4CDB39A1D6F3"),
                Title = "Đồ ăn & Thức uống 2",
                CourseId = AppDbContext.CourseId2,
                Order = 24,
            },
            new()
            {
                Id = new Guid("FC262EC9-9161-474C-8EBB-A53D36D8ED97"),
                Title = "Động từ thông dụng 1",
                CourseId = AppDbContext.CourseId2,
                Order = 25,
            },
            new()
            {
                Id = new Guid("4EA096C4-5B36-43BC-BF34-522ADAA42239"),
                Title = "Động từ thông dụng 2",
                CourseId = AppDbContext.CourseId2,
                Order = 26,
            },
            new()
            {
                Id = new Guid("75DDEA7D-8C89-4A2F-A617-DD91A6A370B3"),
                Title = "Từ vựng bổ sung",
                CourseId = AppDbContext.CourseId2,
                Order = 27,
            },
            new()
            {
                Id = new Guid("684014C9-C798-4842-A1B9-5079B98BAEF8"),
                Title = "Công việc & Học tập",
                CourseId = AppDbContext.CourseId3,
                Order = 1,
            },
            new()
            {
                Id = new Guid("D906AFAB-9216-4C95-80D8-9A437FAB57D7"),
                Title = "Danh từ thông dụng",
                CourseId = AppDbContext.CourseId3,
                Order = 2,
            },
            new()
            {
                Id = new Guid("2DD8D259-422F-4071-8DE7-5545AFB14897"),
                Title = "Gia đình & Con người",
                CourseId = AppDbContext.CourseId3,
                Order = 3,
            },
            new()
            {
                Id = new Guid("4963314E-8221-4F0B-AC91-9F1FE2EFE038"),
                Title = "Số lượng & Đo lường",
                CourseId = AppDbContext.CourseId3,
                Order = 4,
            },
            new()
            {
                Id = new Guid("6B28324A-F59C-49F1-9087-03D50D413D6F"),
                Title = "Thời tiết & Thiên nhiên",
                CourseId = AppDbContext.CourseId3,
                Order = 5,
            },
            new()
            {
                Id = new Guid("DD31B585-BEA0-4A23-8FFD-5328163F2BB0"),
                Title = "Trạng từ thông dụng",
                CourseId = AppDbContext.CourseId3,
                Order = 6,
            },
            new()
            {
                Id = new Guid("7AAD1513-28F2-4DA1-B1C7-D033C763D8C5"),
                Title = "Đi lại & Địa điểm",
                CourseId = AppDbContext.CourseId3,
                Order = 7,
            },
            new()
            {
                Id = new Guid("EF23A4EA-47ED-4CD8-BF55-B8E6138A15DE"),
                Title = "Đồ ăn & Thức uống",
                CourseId = AppDbContext.CourseId3,
                Order = 8,
            },
            new()
            {
                Id = new Guid("28C5E21F-5AB2-43C6-A1FA-B27BAC4E6764"),
                Title = "Động từ thông dụng",
                CourseId = AppDbContext.CourseId3,
                Order = 9,
            },
            new()
            {
                Id = new Guid("B5B05246-0A88-4913-B2C8-6258FBA2EE95"),
                Title = "Từ vựng bổ sung",
                CourseId = AppDbContext.CourseId3,
                Order = 10,
            },
        };
        builder.HasData(lessons);
    }
}
