// Auto-generated — QuestionConfiguration
using KimChiTalk.Repository.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KimChiTalk.Repository.Configurations;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.Property(q => q.Content).HasMaxLength(512).IsRequired();
        builder.Property(q => q.Type).HasMaxLength(64).IsRequired();

        var questions = new List<Question>()
        {
            new()
            {
                Id = new Guid("2A2A682D-7CD3-429A-9777-0715A2FB6C48"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가게\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF569AC8-F3DE-414C-BFFC-DA7841B5B44E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cửa hàng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("041AB088-2679-4202-9B87-110A261ED9CC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가게\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("38028567-7603-4228-9916-F546CECC61E4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가게\" (cửa hàng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EB7F35B5-1401-4C7A-9C97-1B7E126EC625"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가격\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4DC2E33B-64D6-4AE5-B7F4-FABABBD54315"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự đánh đập\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FAA5E4BB-32D8-42EA-B4BC-CB6B42FA433B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가격\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F40BEC06-DE2F-414B-B314-F6733BA7CC10"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가격\" (sự đánh đập) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("805B3D5F-046B-420E-84B0-A1E68973374C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가구\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7173DC49-58B0-4962-A9E0-D94873BC6642"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"hộ gia đình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("16865034-BDE3-42B0-B512-6B7015844212"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가구\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DF1D87EA-3635-4ADA-AD93-B9A46CB2771B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가구\" (hộ gia đình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D1D40623-C6A4-4E61-9F8E-265776CD216B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가깝다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("768971A8-2274-4431-8E7E-654900F2A46F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"gần\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FA97DC3A-4BDB-4EB7-A3B1-5808F816A66E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가깝다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("15843366-9EC8-444C-B4F4-A53BEEA92CA3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가깝다\" (gần) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33A7CEF6-5CE2-4DDB-8323-7E11C10FC385"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가끔\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("61B43CBF-8156-4478-A06E-4AC5AE30DFBE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"thỉnh thoảng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2B5B20AC-098D-4483-B504-F88B8A336378"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가끔\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1F4FC6FE-FEFC-4696-AA6B-210F9A2520BF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가끔\" (thỉnh thoảng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5EC29F74-826D-4C48-B202-181C38C2D85F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가늘다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C9673421-9978-49FB-BF2D-741E23996ADE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mỏng manh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CA134BE3-61C2-4C7C-8B53-50502D529F6F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가늘다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1DC200D5-1EA1-412C-BD69-6F05FB363C09"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가늘다\" (mỏng manh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF2277EE-717E-454F-B941-B7740082E273"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("027A5792-978B-4CA4-BAB6-F0D9436920BC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9D385644-1578-4E3B-BA98-403F7291EB34"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0B3BDAE2-9486-41A9-9208-9C49D58C9AD6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가다\" (đi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("32436F6F-6CA1-4E42-9737-0FCD823495F4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가득\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2BE23DC4-19E5-477B-8879-E299164906F5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đầy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB4BEB39-3945-43EA-BC8C-4F74CF021388"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가득\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B00FD5FE-B255-4B3E-8DF6-0D8DFE4971F5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가득\" (đầy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93B8B8FB-387E-4235-B7B1-3E58E4190329"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가르치다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("295BC4FD-5F37-4643-A279-BD7D699D5161"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"dạy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DEBD01E8-D692-4CA8-AD0A-C870663E28AA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가르치다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("073793A2-372B-4123-BF39-14E799B88B4D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가르치다\" (dạy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6BAA1445-A222-41D9-8EF0-40F685F59A9B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가리키다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("50DC10A4-33CF-43C4-AF3A-B1720CB4C8CE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chỉ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6797D9EE-C2B9-45ED-AED7-8F6E43DDA149"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가리키다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("656092D3-8A41-46D4-97F0-AEF9B99FA79D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가리키다\" (chỉ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("426B30C9-1CD5-4230-90A7-3D910257A473"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가방\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C37F312F-861E-4AB3-888B-0257DD600C91"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"túi xách\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("21E25090-841C-407E-ABE7-9798ECF6A7FB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가방\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D6CCFF3C-EF51-468A-A4A7-BE9D95ED3FCD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가방\" (túi xách) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC4D0ADF-78A7-42C5-8A4F-F1F38A2188A1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가볍다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("705F94FC-D43B-44DC-B094-3E619E2DD21A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhẹ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D033DFD6-DEE8-40CF-95C2-23DD06D68DE4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가볍다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("16252BF6-682E-4414-B9E4-54C7FACC3CD5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가볍다\" (nhẹ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC31842C-D619-4407-8325-16599B5F63EB"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가수\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB7D9268-6A98-4212-8075-D2DA2EBB9BFB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"ca sĩ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5CE11E4E-52AD-4C29-B09D-6CF3973358C7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가수\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E8EF0029-592A-4423-B783-2DD7CB98692C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가수\" (ca sĩ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E6C4FBB-6C2C-45CE-B400-9B81CE5A6030"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가슴\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B5E43A6C-975B-4632-80B4-083E2AD59469"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"ngực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("96114FDE-0608-47C1-9D99-FF438A6B80DE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가슴\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D7749BD8-E38D-4F18-9AE3-547AE1EFF92D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가슴\" (ngực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F740114D-C367-4B82-A256-FD7EEE7543D8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가요\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("533F57E4-965C-4B4E-A5BA-358A606BE803"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bài hát đại chúng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("23F95F7B-4EA6-466C-88D2-9A6A7E3FF751"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가요\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A1734AF3-B950-4CAB-ABD3-D0B01CB3924C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가요\" (bài hát đại chúng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CD99368F-8723-4E92-888E-F50468AF8F49"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가운데\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("72AB45CD-7C11-4CB2-84D5-F1C4540F3F80"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"phần giữa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("59D83675-DDB9-44C1-9871-220359D43EA1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가운데\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F8D4BFBC-422B-42FB-A021-128B5D8F76F7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가운데\" (phần giữa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9C51EEAE-CDF0-4405-ABF5-C32DF4CF174E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가위\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC209465-5E27-4E20-A428-FB53CAD9E02E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cái kéo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED3D624F-4CB0-4EBB-9D5B-82EC6B167A66"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가위\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B951358F-14B2-4439-BC44-98638B0C7BC7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가위\" (cái kéo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("325318B5-A390-42D3-87F7-26602704D116"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가을\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DE9ECAFB-26C8-4B08-B15A-F727B4087040"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mùa thu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A87E2215-687C-4A8A-B330-F6BA6DCCE017"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가을\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EA5634B4-AE93-473A-BE14-ACA8D109C677"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가을\" (mùa thu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("54A56EBC-D362-4EBE-8F0A-E975CD6FA6AA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("42694936-4602-440F-BBA8-14D6F45521DD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"người chủ gia đình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9CD97A03-FB17-4E55-98A5-E83BC0A94848"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8050E93D-1DB3-49E7-A4FF-9CCF53D28334"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가장\" (người chủ gia đình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("378144B1-F898-4BD7-9596-2F4DA2AE6D49"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가져가다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B4E47B14-3DFF-4E9A-9B4D-F6C6145AD785"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mang đi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B20DD97B-0160-4D7D-A39E-C716F951344D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가져가다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BC52D218-84C8-4344-B9C6-9C23988D6675"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가져가다\" (mang đi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("87E92B07-CDF0-4020-B8F7-DBA6B512C55F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가져오다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D560687F-CB98-45F0-9862-171D7C835727"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mang đến\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("39138EB5-F1D0-4EDF-AAC2-3D2513DB44B7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가져오다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("84A8C0A5-ADE5-4279-B921-79417C354A05"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가져오다\" (mang đến) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5D9EDD8C-ED81-4E5D-8706-40378CB9B4D7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가족\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("53B7B441-A3D4-4CB6-827D-32681C749635"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"gia đình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3BDC704-ED79-4D20-A3DF-D9078C7D51E2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가족\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FF9CA82E-312B-49C5-91AF-16E07268D4C0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가족\" (gia đình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C47D7B8-E427-4AF4-873E-8706B67E0246"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("092CDC88-B0A6-4A9D-AF18-C761D9BDADFB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cành\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB5A6ACF-9EAE-4364-9D07-C5451915A9B7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("51F7C7A8-F073-490A-9D4C-856E0378F08D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가지다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C5BBF63-CC83-4B2F-8DCF-B0DFFBE0F47A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mang\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E0C1E025-2CB3-41F5-B386-DF7711DD15DF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"가지다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4D6988F7-DD45-4B25-9AE5-E51120D1F894"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"가지다\" (mang) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9A7A9D29-1153-4200-AA4D-E2D9A62A6501"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"각각\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("12A8134E-1007-45CB-AEFC-0C54ABA408CE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"từng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("45870449-F42E-45FB-A3F1-4CB56F3CA4F1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"각각\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9110F11C-155F-411A-95D0-1DCBBCE7D4D0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"각각\" (từng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BE987CED-F775-4B8A-9C34-388841C2F87B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간단하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F7D239F8-904D-4B4A-B66A-DF66CE00E9FA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đơn giản\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A15D8A77-CEBE-4DA6-BE52-9B86D5F042F8"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"간단하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("766ED9F8-6219-4327-96FC-CE36393FB482"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간단하다\" (đơn giản) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D15057DA-65D4-4323-8015-3A77F2A76473"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간단히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("09A9FE04-A538-400E-BD15-74BB90FC7E17"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách đơn giản\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("51E8978C-8383-409A-8BF8-BFE9C2CB338C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"간단히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FBC8696C-9406-40D1-BB88-AB19717266BA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간단히\" (một cách đơn giản) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8997C810-6814-45C4-8FB0-2F43A73FEA6D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간식\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("13A83767-BFA7-4B4B-B1B0-B371106D96BF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"thức ăn giữa buổi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7B25265C-E4A4-467A-A420-B43BDEF4A53D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"간식\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7A019AD0-5342-4762-9780-AAD918C25905"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간식\" (thức ăn giữa buổi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B936CEF6-2594-43BC-941F-5D7F33A93A4E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("05A848CD-1AF8-4080-AAFD-BC3DE07AF920"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"Ganjang; nước tương\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED2F0397-EC58-4AA2-8D63-31E5FD92ABFE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"간장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C8AC391D-FF6F-479B-893C-4ACF214AC7DE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간장\" (Ganjang; nước tương) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("36169F12-D7BA-4871-BC05-DDB252C281AB"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간호사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B64D74A6-7547-44C9-B4DE-E2C7B12FE54B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"y tá\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("83EF4E7D-F037-4D48-9DC2-BCF76310C543"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"간호사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9860633A-309A-4ED6-B3FF-5A7F3A040F9D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"간호사\" (y tá) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C3C28218-6A30-400F-B797-D901BB3552FE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈비\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF8DF037-FFE6-4E3A-A4C8-B7582BE83162"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sườn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6FCDC61F-4C42-40BF-9498-2DD99B81A375"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"갈비\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8B6CD016-FF57-4427-AFE1-6EB82C225262"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈비\" (sườn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E6CC7918-3384-4D73-8DF7-A7BD1238FEDE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈비탕\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9B9BE725-F6FE-4E8A-B515-4351AFE4A490"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"Galbitang; canh sườn ninh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F538055E-A402-41F0-BE68-2637C1AC097F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"갈비탕\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1C40B5B2-13D1-4526-B895-DA175F2A0441"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈비탕\" (Galbitang; canh sườn ninh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E37963CE-1061-401F-9EFB-100E9E7224D8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈색\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6AFEEF05-7ED8-4F39-B9E9-40D17BDDAAB9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"màu nâu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C6F6BC85-803E-4ECE-9B66-758B9B2D77B1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"갈색\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E8A4CAD0-ABD1-48AC-9173-5014D895CC96"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈색\" (màu nâu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C804E7B-75E5-4A0B-AB3F-E9EB0681550D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈아입다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BE7BF0CD-645D-421A-8046-D0C5F2B6CBC2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"thay (quần áo)\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("276398AE-2150-426C-B17B-4FDF49EE3E9D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"갈아입다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D867A72B-4036-4520-8597-7F5C4B212ED5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈아입다\" (thay (quần áo)) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ABFD8DED-735D-46D2-8D2A-60D54F0CC6C7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈아타다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BE8AA2B0-E1F0-4514-9D72-BA23B0EE58E8"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chuyển\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5DE73A43-A8EF-4D76-AD0C-A8AA5EA2C5F7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"갈아타다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A7D8F2AF-8C36-45C3-A187-64D7B7D9812F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갈아타다\" (chuyển) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("979C27A2-6AA5-4846-AA12-7C8FE59D537E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F8D3E088-318A-4C6E-B22E-FCA499BB45E9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quả hồng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("305EBAFE-A879-4A47-A7FB-1BA78B0BC5A4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"감\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A13DC6D3-F813-428B-A79C-52FB1A7A3AA1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감\" (quả hồng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EE1FE1A9-8BE2-4CA1-BE91-8D3A74EB68DA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FF63960D-ED93-4F38-8250-B33FAAE8267A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bệnh cảm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("056ED9B2-D14A-40FD-8109-679A121BF93D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"감기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("996B4FC5-9606-4E23-896B-6037452854F1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감기\" (bệnh cảm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AECF7FE2-7FBC-4843-B8E5-541EAEE94CCF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감기약\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("248E61E2-B1B9-4548-9CD5-E628A9589353"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"thuốc cảm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E38143C4-1F9C-48A6-B936-147832A2D9A9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"감기약\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7B3EE991-38CB-45B6-9F92-7B6F9F15A58B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감기약\" (thuốc cảm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BF3E7BC4-74AB-47FE-B817-796F9D1F91EA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("948E28DB-5527-4796-B24F-4E7E6AB8DA66"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhắm (mắt)\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EAE62D58-9B88-485D-BF74-B849627179FB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"감다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("55BFBB29-7B1D-4312-AA70-17A50DDD221A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감다\" (nhắm (mắt)) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("01322764-838B-46A3-BB75-9E7C33F7D5E0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("702B32C0-8980-4ACB-AAE4-BC0A669140A4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cảm tạ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("23CFF631-0DD5-43CC-B617-7230878F865A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"감사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F6FD4912-CBCE-445D-B59A-B5480B4EB9A6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감사\" (sự cảm tạ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("963D07E8-09CC-4C64-9B4A-3D2A1D6F8C79"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감사하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2BFF9168-A9CD-4D3A-8DE4-E618AF6D25E4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cảm tạ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF7B7CB1-4510-4D7B-9D08-A6511182B8EE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"감사하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C8185581-259B-4881-8C33-61065FCD8EE0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감사하다\" (cảm tạ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("22657723-C0CF-4ED0-8A5D-63BC332D7D73"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4589B99B-E8AD-4DF0-AA3F-58B690F93B02"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"khoai tây\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1ED95138-2E6B-4D5F-BD45-266A26537009"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"감자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("15A65B65-29A6-4522-A035-8F333AD61250"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"감자\" (khoai tây) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B46726B4-57EF-4D6F-8F91-F4F905FA4D44"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갑자기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("022CED56-532E-4F1A-ACD5-0CF44229B196"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đột ngột\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F8ACB3D0-D059-4A12-9297-1E18BB465EFA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"갑자기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F95141AF-6699-4847-BAB2-2F54D88DF0DA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갑자기\" (đột ngột) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7BE04C8E-5E1C-4432-B121-DBBE9DDDA71A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"값\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E6011901-D845-4434-9E1A-1089B4E78315"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"giá cả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7EFE28C1-4414-4C4A-BCFC-A33CBA5A0FBC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"값\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C2049FB7-260A-4708-AF62-2A0779C225A9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"값\" (giá cả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BC7997AE-4274-4129-A8E9-CD10DE49F335"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"강\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D84A83D6-19C6-4765-934E-89B2637A1FDE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("045EBDBD-CDC1-407B-9E9D-70F710B7181F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"강\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0E1B40F8-8449-4D65-BBFB-F280982BB3FD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"강\" (sông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D1286B12-8ED2-4C3B-9400-C2C38E209FDF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"강아지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3DF056FD-B269-4AC4-A39D-DC45A3F26B78"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chó con\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E7160035-C217-4B39-A316-71855588534C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"강아지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DA46C249-F56D-4706-ACAF-8BA2D6111732"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"강아지\" (chó con) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7825FF1A-A2B4-4B06-95B3-4BF2B704303C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"강하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("53AE3181-B094-44E8-8580-BFBAEA7B190A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cứng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("640BE2ED-CCC5-4D1F-BC31-E9D4057E8FDF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"강하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("00528349-527F-4E8A-B386-9BF17C33DF27"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"강하다\" (cứng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("50F1F17E-F279-42C1-9D88-C95A788F6E27"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갖다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DAD3B788-35C4-43D0-BC25-60F9F0E7B1AA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mang\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("764D381D-B33A-4EEF-8414-B51E8227F274"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"갖다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A744BAD2-8F1B-494A-ACDE-EDC5BF4C3398"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갖다\" (mang) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("090936FB-F5D7-4743-AD2B-180E5353386C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"같다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D249203D-6DDC-4B93-BB13-F4085A7DB523"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"giống\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CF636732-CD18-4026-A2E4-21A14290FC6C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"같다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("876065EF-7127-43B4-B636-B87D22AB26CD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"같다\" (giống) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FAD1429F-77D6-4B38-BFD3-6A7B22658D73"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"같이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("16A3878E-A989-4CFB-8B81-A7FE9F816B68"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cùng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BBF2692A-8142-4698-9ACB-408AC20E6BA8"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"같이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FD83F1A1-8714-4DBA-A74A-65BA682D9D4F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"같이\" (cùng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5F847B72-4BB8-4BFE-A5E3-D2CB3B1407E3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갚다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0AFCD1C1-562D-4236-BE8A-D3BEA6D48C4A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"trả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8DFA3F1E-5AF8-47F9-A23D-22251F32A83B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"갚다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0876F3E0-83A0-4706-8D89-9F67716E8E58"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"갚다\" (trả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2330C49B-1E9E-4BCC-9F5A-B7B7293DDCB7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"개\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("35BB4160-B0A8-445D-AA4E-3DA6FDBAD396"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0FD325F9-DD31-41B4-9B81-9151CB9A7790"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"개\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("62AC540C-E44F-4BE4-8F80-7DB6AAB1A321"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"개\" (chó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("735DE96A-D04F-45BF-9A28-C5505AC563A9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"개월\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("18DC084C-D560-4865-B09C-4B2AF2E88E29"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tháng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("698766A5-0B3A-4714-9506-290922732995"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"개월\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("17F29591-A782-49BC-B0CA-989530227C76"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("15E3150F-B415-4391-8E69-9B73CBBE06B3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cái\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D36DB271-130C-4B4F-A10F-BD6847284B01"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"거\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("34D33137-CCB4-4108-B959-291717091591"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CA36E142-5094-4AD6-835D-8CA75F5161E4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nơi đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FF87A8CE-213F-41BE-B578-077EC78B5752"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"거기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("12573357-0825-4B86-8B06-E3BFE3F4E789"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거리\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8866EEE1-5D34-47F3-ABA9-4DE343A1FF77"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"con phố\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D187B736-4E32-44C5-B65E-39E97A5509C3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"거리\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E39173BE-B5C5-4691-9255-31A77F591F29"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거리\" (con phố) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C2A95A8-5153-4037-8895-90143C73EE23"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거실\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("80A716DB-2D80-4A98-9281-2319598A7878"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"gian giữa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("679A15C6-ED74-425B-9402-E61E6364694F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"거실\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B6C32F28-2477-42D4-ADD6-7E5403778283"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거실\" (gian giữa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DADD5C4E-1877-4D21-B1F2-E72A658B9E39"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거울\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D93878CC-BED0-4D7E-BFB4-921E2FB756BA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cái gương\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DCDC8E51-CD5B-49D3-87C6-8115AA630B08"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"거울\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DEC453FB-D0B3-44AB-9A63-677B2A6B04B9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거울\" (cái gương) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("48A3587B-DF59-49E4-9F27-7C74E85FFB32"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거의\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C4D46D6F-98CB-4D94-8ABB-CB62C718FC09"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"hầu hết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("834EFC85-8693-45D1-A4B6-697D9C8BDE89"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"거의\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("98D056C8-041A-414C-ABA7-F8C1699075E8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거의\" (hầu hết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("448143C2-5738-444C-B54E-0A3635EE8E44"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거절\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0B3CD5A5-4CF3-43C0-AC1A-1023BCADD39A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự từ chối\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B734AFB8-5EA0-438F-B59E-B14C4CFBE48A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"거절\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6627446B-5118-4599-987E-C029A35B0658"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거절\" (sự từ chối) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2428B04-F617-4D30-B55E-AF4B2620AAB5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거짓말\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("708D1C0C-2E79-40DF-88CF-59552179AD76"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"lời nói dối\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1E8B1A77-A556-4E06-8C4E-EC511BD79B4B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"거짓말\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D33BBB88-5407-4418-BB1F-6D9CD3A72699"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"거짓말\" (lời nói dối) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("649BB786-3259-4568-9AC4-C47417A54596"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걱정\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93C81E93-C8CF-4AAA-B010-C38FB1B26B19"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nỗi lo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9DA50FBB-A36B-476D-8AA6-24833B97E03A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"걱정\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("49416248-94F1-4F26-9183-454F8458973F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걱정\" (nỗi lo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("752BD4EC-F875-4D60-BDF7-1CCFADA76648"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걱정하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6C6572B5-EC6E-4A17-B4C4-C32B17D688A6"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"lo lắng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8CAA52D6-827E-49D2-A3E9-1A46B78ADD67"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"걱정하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C7907A4C-E1DC-4864-B5EB-E82E7F3300B7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걱정하다\" (lo lắng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("284737DC-7378-4662-A2F1-C38FBF6D2827"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건강\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10C65594-7DA4-4DBA-B4F4-F5B5B6090515"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khỏe mạnh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A33A4732-8B14-4216-A4C1-B3AA97EF44CB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"건강\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1DD0F38B-DDEE-493F-82C9-BF427DF3BCA9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건강\" (sự khỏe mạnh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("01E0C433-06AC-4FEC-A83F-710436C2404B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건강하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0D497D1F-DAC4-445A-B380-566AC17DAAED"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"khỏe mạnh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("336673A8-63BB-4986-926F-86B0BC470636"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"건강하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("69B11BDA-98A5-43A2-952E-6B5DA9DCD89F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건강하다\" (khỏe mạnh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F6E4C452-B47D-41CA-B5B1-BE463E9C720A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건너가다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("336EFF85-48CB-4AED-8E46-EBB79B23E339"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đi qua\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BC47B1F4-D11B-4023-B175-06C50980782E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"건너가다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("16FB406B-AA9A-4153-954B-50A383963562"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건너가다\" (đi qua) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E7FCC015-A239-46F7-97D7-024C69359243"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건너다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("322CFC3A-4AD6-4BFA-8796-0E1F5895C747"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sang\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8A822AEE-40EC-4EAA-9338-630AD8B5048B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"건너다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8FB154C8-769E-43EF-A7B9-DF08F4A74B87"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건너다\" (sang) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("21FA59F0-1717-4DF6-9C1F-1E9FAEF2337E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건너편\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7E7BAA2A-398F-4B55-A9A5-E70B400429D9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bên kia đường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("260F527F-F679-486A-A0CC-C02B0F7F6692"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"건너편\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D180DA4B-36D7-4FA0-A19B-160D30EFCF1C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건너편\" (bên kia đường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B83F9768-A44B-4448-851F-029FFE2099EA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건물\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("27DC3595-589B-431C-9E77-9CD5ACE1DDB1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tòa nhà\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C01FD7CF-0334-44EF-95AB-1CFF026D9A50"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"건물\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("584136FE-07F7-4864-9C46-A4356F37460E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"건물\" (tòa nhà) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("46FE72BF-3592-4B5B-8AF7-F33BABB4E58D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걷다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8EB24AF9-1984-4070-A1B3-2A167C3276CF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6C81B73E-188F-4E42-A791-143A743B5CAC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"걷다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BA3B2E21-6DE4-476D-B4A5-27BADF41E54F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걷다\" (tan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("341280C0-8865-4D15-9391-2443A95F33E6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2E33C559-D280-4EE5-B1FF-ED5EC49C1256"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"treo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("725F8A1F-9B26-4F33-A7B0-3149BD9F52E6"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"걸다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2B88E2F7-6E46-4E45-AE8E-232E8B44652E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸다\" (treo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BCD6E761-EC63-4AAB-B4D9-0AB30ADA0FED"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸리다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F17E2468-B191-4FFA-BF7F-1A770B7E71EB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"được mắc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7089C972-3FDF-4774-955D-44582398ACBC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"걸리다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6BFB455D-1473-4488-A926-C03E3230F85C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸리다\" (được mắc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F53C1B0F-D3E3-4002-AABE-2F8B2A705971"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸어가다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9F2E15CB-8080-4991-905D-13178877B10F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bước đi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("20B082E3-827C-4D54-9973-332D705D084A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"걸어가다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6787D2A5-EFDD-4442-B0F9-F13B7A714886"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸어가다\" (bước đi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB6E1D88-2648-4B9C-8633-BAF8CE3179CB"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸어오다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("478C7318-2A99-40E2-9B63-9785084AB903"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bước đến\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("412D784F-12A9-458C-A78E-7B5419B55FF5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"걸어오다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1AB7B551-7D7E-47C9-B5E8-AB79D814F9B6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸어오다\" (bước đến) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("495E7DFE-0D55-49FF-9E05-BE4E61E6DB76"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸음\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D2476CE-CDC9-46C8-B67F-07EBD64ED4F9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bước chân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF649CC8-C2EE-4291-A071-173AF2502A71"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"걸음\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("004A9165-B676-4030-AF24-8D49FBE957FF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"걸음\" (bước chân) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1927D750-FF5B-41D5-BF5B-7C5A47B5B0A0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"검사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("88BCDDD5-355B-4CB3-A76C-BA033982A999"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"kiểm sát viên\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("82420D09-7A0D-4B4D-A90B-66A2C82854B3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"검사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("55C1A2A1-4A1A-4C91-A05F-0E967796650A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"검사\" (kiểm sát viên) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D2D99F3-64AE-41DB-A282-91AEC3802BE3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"검은색\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B2B916CC-7E0A-4412-8870-2D489F977436"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"màu đen\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("31708D5D-F4BF-46A5-8A04-44F44AA887C5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"검은색\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("60470DE6-E1FA-45FE-A971-D796CDE5BEB0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"검은색\" (màu đen) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("98AD77EF-86A6-4418-B7A5-871702E0A4A5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"검정\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C733602-3A8C-4565-B19F-0FBD35757285"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"màu đen\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("31405BB9-3373-4A04-BBAA-E1CF988783F1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"검정\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D0A06480-A0CC-4F8E-AB59-7A9218BC6CEB"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"검정\" (màu đen) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B1A77931-2288-4B09-8C82-0F7D39F3D926"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"것\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E8425A3A-7144-46C9-9E24-7D2A1C27E8A4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cái\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4E89F7D0-A9F2-4C62-8B4E-A40C08863D0E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"것\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CBD9E5C3-ADF2-49C1-9487-4DE57B577A18"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"겉\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF3B839A-C7F1-4773-AA75-D17361EADFC2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bên ngoài\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3BC4EBB-593A-465C-87F8-8111F93E10AB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"겉\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F88C5944-D156-48C2-8453-3E07D87B9D2C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"겉\" (bên ngoài) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D3CF3ADE-E483-4177-AAB0-1A0C86EBBA84"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"게으르다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6609BC08-9BD3-4521-93B7-8A35CAD7A7B8"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"lười biếng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2BB45916-1386-47C3-BEDF-1616B8AB8D9E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"게으르다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F2876307-7DD2-4788-9169-BEB9E367A867"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"게으르다\" (lười biếng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("56F12DA7-BF45-4112-B14A-B7C27D39142B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"게임\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("464E27FE-0D13-41D5-BF42-AFE4F41B85D6"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"trò chơi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C43BB4F0-314A-4F20-A932-0187F815C60E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"게임\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CAD5C6C9-AF81-497B-B62D-A6614D7B7F93"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"게임\" (trò chơi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E4BC27DE-9607-4A2D-958B-558E4B65A059"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"겨울\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("70C85799-50D0-4F57-8B5F-042EFB305B65"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mùa đông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("61B19573-C31A-44A0-BAC3-D1BDB92620B6"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"겨울\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EAA18C12-CC34-4CBA-8661-4E5874A67D45"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"겨울\" (mùa đông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EB5E58C3-90E8-44C5-AF02-F557BBEF92BF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결과\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E01442CD-6A72-4D99-A234-0E3279F89529"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"kết quả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("041ABF6D-BC98-468A-A5A0-C2B141DF86F9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"결과\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("81BE79A0-DEDB-4A27-A295-A4A5C402C0EE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결과\" (kết quả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5EE1012D-0D6C-4FCA-AEDE-13DA5D5B788A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결석\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4AB0B6D0-49A7-49CD-AC5F-6F55B2FC3A3F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự vắng mặt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("66D1390F-A485-4A69-B581-18C1374B095E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"결석\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("98E21DF4-E60D-492E-9459-645791387004"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결석\" (sự vắng mặt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6EE75F77-25B2-409A-8A85-D5C15C10CEA4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결심\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C66C19CF-D292-40D5-AE96-A4D77824B555"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quyết tâm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("993DBAB2-9DBF-4BFF-AC48-3EC659C1252F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"결심\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("909A3EF0-1DB7-46DE-B9C8-3BB5100CF386"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결심\" (quyết tâm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B329D2C5-EBDA-4891-AD00-7B97476E4AF2"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결정\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8A71C290-7358-4E34-BC3B-BA6525B8E049"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự quyết định\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5A248CBE-560F-4ADF-B88A-73722AFF365F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"결정\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("ACA5BAF5-E4E2-496D-87E6-EB163F64A6D9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결정\" (sự quyết định) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("59BA52C2-6105-4157-8C43-1C5919CC7291"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결혼\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BB5B7BEE-A49A-41D3-8E54-DFC390BF9DDA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"việc kết hôn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8843D7C6-C493-46DB-A717-2140935A5B5E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"결혼\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5760EFC9-BE8C-4E00-BC8F-7050582DAB1F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결혼\" (việc kết hôn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E185D567-652D-438E-BDBB-0FDA14B7B311"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결혼식\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6083EE9C-3CAC-4339-9307-D562AA7DC1E2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"lễ cưới\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("98C13F80-1F98-4D42-9340-90358886137E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"결혼식\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B1E6D8D5-A886-4317-8A4F-25304D676DF2"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결혼식\" (lễ cưới) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D84D7DE-B1A6-4F60-813D-D24A18685E53"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결혼하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93C934BB-8F7B-4EE8-AE48-022DF3144DA5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"kết hôn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C277A90F-6B53-4F9A-ACD7-1DB28AC9A5E4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"결혼하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F9DCF733-A528-4980-B5FE-BFF045B8DE72"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"결혼하다\" (kết hôn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6F623B0E-2EFC-486C-A7FE-8D816F2946AC"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("405CD8A1-A3AE-468C-BFB7-749CB9CD58FD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tình hình kinh tế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BD10C05F-9B6E-4997-A722-7F5BEB466430"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"경기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9C1A8B5C-993C-4325-B848-2EA00D7856AD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경기\" (tình hình kinh tế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("05A196E2-323F-4A1C-8B62-A6BA852E3F78"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경복궁\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("258D4589-E81A-4D00-BBB4-823E2E006EA2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"Gyeongbok-gung\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4438FE54-183F-4085-8B45-2ECF92206EA2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"경복궁\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("49FB1839-42BE-43E4-AB2D-4041BC45D3E4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경주\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F7EC304B-B0A8-45E3-8F08-06E457D87E6C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"Gyeongju; Khánh Châu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C5BDBF30-8808-49E4-80F0-DAADFD0244CA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"경주\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4132B2C6-8F0F-4BED-882E-25E4978426BD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경찰\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EBF33993-9EC0-4F06-AA88-BF782953E406"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"(cơ quan) cảnh sát\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("204B6542-3C83-49FB-B89C-4AE37647EAE7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"경찰\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9E22A1B0-95FF-480A-B11E-98A5CA52DEDF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경찰\" ((cơ quan) cảnh sát) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("425B8EF1-956B-4CF8-8068-5C578D1D181D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경찰서\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("459E6F2F-2B33-4662-A847-EC86F01A8FD0"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đồn cảnh sát\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C4C54190-0443-477B-8659-59DE570AE647"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"경찰서\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E1D1A74E-685D-4261-BEFE-E38E5333AFF8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경찰서\" (đồn cảnh sát) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F1AE6BE9-4C48-4820-BDD4-5A122ABA5423"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경치\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6B0E7AE5-8B20-4E8E-8481-63C66A7B529B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cảnh trí\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("436F7678-8CE9-4176-ADD0-5E08AE923B13"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"경치\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4DB22F63-4873-4FFF-B9AD-4D3ABFB794D0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경치\" (cảnh trí) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AA731AC5-3307-4CF8-B52F-16D1022287E0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경험\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8F212387-949B-43AA-B81B-F6A10CCBD76B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"kinh nghiệm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ACACBB8B-6DBC-4188-A441-723EE5CB73F7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"경험\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8CCB07E1-FDC2-48D2-BD60-DC93D1E3E421"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"경험\" (kinh nghiệm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2E6951B9-AD16-43AA-9364-E924B8A6922F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계단\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7B2DB093-EAB5-442A-B864-46EB66C326D6"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cầu thang\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F12446CB-6BDE-4234-8ACC-7DBACFB48F63"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"계단\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("654D8479-AB01-468F-B603-25B4DA02C355"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계단\" (cầu thang) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B267F9A0-782B-41DB-81AD-440EAB41DC6C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계란\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("452B472D-BE73-4142-8BD8-5F02FCF8C763"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"trứng gà\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A793559A-7D2A-4A49-87CB-D641556D3E54"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"계란\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D7C92B00-7A37-4235-B960-FBF28743D335"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계란\" (trứng gà) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("42AA191A-4459-4C27-BD45-B73899FB192E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계산\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5D905EC3-E853-42DA-929E-4D5F5490D83E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"(sự) tính\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E5F6F7D6-7F68-40E4-A0C6-FA8796A16E8B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"계산\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1118B51A-58CC-4173-A9CC-83CE57198E63"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계산\" ((sự) tính) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9C7C7DF5-E40E-4341-BC72-0049CFEB29A5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계속\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6D6231DB-3710-4926-9F34-9D517E57DAC8"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự liên tục\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("328F1F7E-E546-49EC-AFB6-F197CDE172BB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"계속\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("97C83B95-DB2D-4638-8BB7-990BBDC956C8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계속\" (sự liên tục) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("523150AF-FF80-4417-951C-F9A2B8E313E5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계시다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CC92CFC8-30FF-4558-805E-C8B10BAE5A33"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"ở (sống)\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("206FAAD2-650C-4F90-95E3-117A60F8AED1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"계시다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("49278DB1-DD73-4534-BDDC-B4193DCAA4D4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계시다\" (ở (sống)) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("921DD798-D619-457F-AF6D-C88A516C57C9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계절\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5C080275-EEA5-4084-8A7A-2CFBB74DBC66"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mùa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6A450FBB-3BCE-481E-9942-A689DA5C5CCD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"계절\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C6E8C107-10E0-4005-BC94-2F6645043D24"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계절\" (mùa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("70BECAEF-5E54-4A98-9C43-81CA4D7367F7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계획\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("68380112-66AC-440A-AC04-77E2033F515A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"kế hoạch\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("92AA9500-B845-44B1-B5B6-4E97611A607B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"계획\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F3F14927-73E3-4E17-BB01-B2B9B39F277D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"계획\" (kế hoạch) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("084B7FEE-E3E3-4FB3-A7DB-6B934E011A63"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고개\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CBCB968C-A126-42ED-809E-E4AEC245CC43"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cổ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B112352E-F2BF-40CB-A604-7D2E4BA3E1E7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고개\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("83E7305D-5D02-45B2-AD53-D7A87C3A2E9F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고개\" (cổ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C3B40BC8-71F6-4022-AA92-2ECA8D55FBAC"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E3732B95-D86F-41FB-8AEB-B4004D1BF9EA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"thịt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A276CE46-3B92-46DC-A6D2-A3EE9B72F10E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("35EB2C8D-A39F-48C1-9A1E-F7F0933D5EB7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고기\" (thịt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F65C99B5-17AC-4899-B1D2-362FF02ACB0B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고등학교\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F993145A-AA85-48D8-9A40-E9F3AC354B66"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"trường trung học phổ thông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8BD7AAD0-345D-4DA3-A3F2-01E7061BE47B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고등학교\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D98C0085-4DF7-4B37-A4AF-26274D16CB9C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고등학교\" (trường trung học phổ thông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("725247D5-8E90-429C-9A07-B969247C7135"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고등학생\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33E742CB-042C-43EF-915E-D44F03B48D9E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"học sinh trung học phổ thông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("238DB29A-65A5-4FA1-9DAD-CB1442CB4B6F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고등학생\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("27D7273E-A886-47AF-A55D-05C8EC0E4197"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고등학생\" (học sinh trung học phổ thông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8FFCCFAF-2AF4-46E8-BC2C-A9D930618B33"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고르다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B4FC7652-96FA-49B6-87F6-026FF3139B2D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chọn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B6FE4743-3566-43B8-A146-8C16F524F164"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고르다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A872F5D2-3980-4E3E-99DC-3312A58E47C9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고르다\" (chọn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("326A66E3-EA88-4E44-A42C-DF5A6662BDBB"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고맙다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D740C3EA-094E-47DF-BEE5-04014EADA52B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cảm  ơn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("914A9FD8-934C-420C-8704-774094BC4A33"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고맙다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("029CF0B4-ADB1-4656-AF47-FDEDC984BE5F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고맙다\" (cảm  ơn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A69AB04A-28F6-4BFB-8525-D14E423B7275"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고모\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6F9CE871-D771-4EBC-9F9D-82DF009C5EF2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cô\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("747E18FC-F6F1-4E1E-8689-63B3BEEBB314"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고모\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("190224CB-CD54-4EEB-A277-B751F0667949"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고모\" (cô) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4497E7DF-F524-4259-998D-BB580F449736"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고민\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AEF1CA8C-067A-4EC0-87AF-BCC9E58A980F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự lo lắng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2200E29-D81D-4539-B850-9E4BE655F22E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고민\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("614EB747-B624-4F9F-B64C-5F0260D702E3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고민\" (sự lo lắng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C066190A-B51D-4121-8277-304E329193B9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고속버스\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("303115A7-5F68-46B4-B96D-516E299FF71C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"xe buýt cao tốc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A7ECCBB4-4689-4747-A5FD-3A2B14B8FACB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고속버스\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E2E0BD81-C756-4780-B1CB-12716BD6FB1F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고속버스\" (xe buýt cao tốc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC8326D0-0684-494A-9D07-12BAAA39BEEF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고양이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5192879F-D654-4D49-897F-5FE52A724D49"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"con mèo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("72F8539F-B892-420F-9465-A6BCB848D778"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고양이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A99BC9A3-0AD2-4B54-A727-EA3853F6052D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고양이\" (con mèo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AEDD2F4C-8E0A-48F6-85C1-FB105E552AC1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AE870710-88CE-4035-9F2B-5AEBC2685D4A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quê quán\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9960650D-1A1F-46AC-9D05-BF8D49F5A2A8"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6DBC6523-BC47-400B-B5FD-E38F3CF0F949"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고장\" (quê quán) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C086B444-B089-45E4-9570-72B0B31C0429"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고추장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F5081BA5-26D0-4BEA-AADA-603D379DCE72"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"Gochujang; tương ớt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CEE35FE8-F510-4752-A8E7-33FFA5876837"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고추장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0BF7AA96-56FD-4923-A297-A11E85F2E709"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고추장\" (Gochujang; tương ớt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8C414CE4-AEBF-4E41-8D14-A2B9855B1FB4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고치다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BB97424B-B8FF-4327-8724-75244ECB4F7D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sửa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D042BECE-E8DD-4CC9-ADFB-B6869163FF65"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고치다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7EB99A60-99AA-4BF4-9C94-3D360AD76CC6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고치다\" (sửa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6892A2F2-E58A-4A99-A5BA-F1FCC6273A02"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고프다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A5323F50-4F36-4A31-AEFE-DD394C321ADC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đói bụng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB22B352-AB4C-4BA9-95FC-0348AC65C369"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고프다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("04A1CDE9-B6C8-4A13-86D3-ECA4EC9EEA3B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고프다\" (đói bụng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("26887486-9548-4106-B4F1-CD087F7888B2"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고향\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AFF85425-0F10-4ED0-83CE-C722EED09909"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quê hương\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1D489F3D-2380-4AA0-8CA2-E7E483594BCD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"고향\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E8DEFD30-56E1-4954-8332-0B5C91705215"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"고향\" (quê hương) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F3740DE6-E50B-42D8-A002-8A577109E1EC"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"곧\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6774AE1E-01F3-484D-99EF-E32789172415"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"ngay\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A29C735C-9ABA-4C5D-8E52-3FA7FEB9926A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"곧\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("29C76FC7-65CA-476B-89E9-46228A1EF1BC"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"곧\" (ngay) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7D2FA5D4-E5B5-4B58-A316-9D67A1FC30A9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"곳\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DF158679-898D-4F53-A152-6A6EB2009DCD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nơi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BA4588C9-6591-4E12-ADA7-C210E276A6B2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"곳\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0AC4DB1E-BE7C-4539-8565-965A082F4007"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"곳\" (nơi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("878F5B86-687F-4323-8505-3C65521DD363"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A33529C2-A30A-4C9B-8B70-0BAA149E1352"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quả bóng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E0A33D9-2F1F-4375-A098-F3013C12887A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8BC5E389-340C-422F-A58A-96FB568A4DF5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공\" (quả bóng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7E2D4C4E-2F65-4DCF-B37C-0CB3D62FA89D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공무원\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("592C4991-6EDB-4146-9C7D-EB777CFD5F2F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"công chức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5F6FEE09-9888-4DFE-8AD2-D5E115E6698A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공무원\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("50379CB7-F7F5-4AB3-9B79-D18F3D812EEA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공무원\" (công chức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("80FBDF3B-94AA-466F-8C6F-B8A4252DB177"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공부\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C00A7576-D2F4-4BEB-95A2-55E8F645AE6A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"việc học\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("57F653E1-A8C7-4028-B5D9-991E9B5CA7EE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공부\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("82F2A8AA-5F3F-48D3-B1F5-EA6B33007BD1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공부\" (việc học) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5C0CB870-E7BF-4BDA-A382-965A3997F5A8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공부하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF46A3ED-5C97-45E0-BE62-847616420E7A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"học\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8F665FE0-ACD4-4C32-969E-CEA3BB98C2B3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공부하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4AE124C0-BED1-4CAD-A61E-226ED3BFE25D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공부하다\" (học) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A1059CEE-51CB-482C-B7C3-F1B0DDCEAEAD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공원\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D15760B5-B282-4FB8-BF10-7309B327B146"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"công nhân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("77476DDE-6E5A-42D0-B2D0-21FFC192A5B4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공원\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2F14B513-93B8-4225-BD84-72CC39E1D958"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공원\" (công nhân) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("400AD8D9-BF56-47BF-881C-3E1CD5020B68"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("42B71780-786A-4CB6-B176-7E56B44FE5EE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhà máy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1929F9E1-235E-4D84-829A-976D5D9F56AA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0AAA2838-D312-4BBA-B812-A866E0E40D7D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공장\" (nhà máy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB187860-FE0D-452F-A9E5-896B6BA0AE3B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공짜\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6185C3D0-93C3-45F5-9556-7EF51A7CA2FB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"miễn phí\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AA6A46A6-BD8A-477F-90C7-81095DD706EC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공짜\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CF97A8B2-569A-4646-BE5F-25D38C92FA97"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공짜\" (miễn phí) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E4F603DC-A24A-4FDA-BAB7-58033C567C96"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공책\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A146000A-697B-49CC-A959-322C545A25F2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quyển tập\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4E2F5820-F4B6-49DB-8BF5-34B7689ACB15"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공책\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0FFCB54F-6377-4653-AD47-4D2DBCB1B462"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공책\" (quyển tập) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C7186F88-A366-4920-B2D6-08616B36D6CD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공항\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CD49AB69-13B0-431A-8F8B-7913BA2D26FB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sân bay\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FD6744E1-9557-4CC1-BCB0-4130BED0386D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공항\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F5072274-D591-48E7-9174-701C13B9CF39"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공항\" (sân bay) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B9B99464-8149-475F-93F3-866E5C23C3F3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공휴일\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BFACB826-9F77-49D7-972E-B2DFAB9D7F49"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"ngày lễ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("12C151A1-F002-42E5-8C85-77BD2C13DFD4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"공휴일\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("00827A2B-2D06-4277-9BD7-8B1FFF44CF74"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"공휴일\" (ngày lễ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9AEBCB63-27D8-407E-8ADD-A09A8C1F9C45"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"과거\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E8AAAAE-DB3F-46F7-B06A-1B9E6EB438D4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"khoa cử\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CC46C97F-06FB-4CCF-8661-AA60B8EA399E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"과거\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F699042A-B2E1-4A42-94FF-47961709915A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"과거\" (khoa cử) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("95065811-3539-4DF0-8B70-3727034E6EBE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"과일\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FCB2CBF1-0C46-4635-A9B6-039B6926EBFC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"trái cây\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9F4C5083-503F-4359-95C0-0E729DE236AC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"과일\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BC0F1A0E-0C86-4D77-AD8D-41BDCA97C082"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"과일\" (trái cây) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D27B31D9-FCDA-4750-8EF3-25768103DD81"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"과자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3DBAA6D4-6556-44C9-B9E2-3842D4698505"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bánh ngọt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A35D50C6-EC84-4E25-B9FA-BD3E8B2ECDAC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"과자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B34073A2-A758-438A-B1AA-6C1644A926EF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"과자\" (bánh ngọt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EE35E3E7-FA46-4D79-9B0B-13AAC7AD8EAF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관계\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9424C3F9-7D0D-4010-B72A-C7EF92A6C347"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"giới quan chức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("59E694EE-F7ED-4C80-AFCE-8D6458C09A7A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"관계\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("37972D3C-9462-4268-B8F8-03CF2D934E26"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관계\" (giới quan chức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EB8F540F-8A50-490F-A1A8-5DB920BDE5BF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관광\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33EB452D-A769-48AA-B75D-C2354C2DA4AC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự tham quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6C3DD5FA-549F-44E6-B154-F0F23D48EE0E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"관광\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("121FD146-E87B-4A26-8ADC-2181C62AFB3C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관광\" (sự tham quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CCC01B6B-5FE4-4B1C-B8C4-0A6EF70ADBC6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관광객\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5142E833-5B1C-4661-9703-2B37BBDD0BC5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"khách tham quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FB0ACA4E-7D3E-4DDE-9DCA-ED4F196F8BDB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"관광객\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7FEA52C4-68DF-4826-92AF-67529AF8CAF1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관광객\" (khách tham quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("693B867B-F0DA-43D9-BCD4-424DA187250B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관광지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("622FB8C2-E3D0-4C7C-BFF0-208C53AF6D76"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"điểm tham quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8A993977-ADC8-4EA3-A561-414A986FFF86"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"관광지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("61A1915D-7268-4138-BA8B-114CF1FA348E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관광지\" (điểm tham quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF36A9E1-E6A8-4725-9349-6995E788838A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관심\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AE7D83BD-DECD-4C66-9F6F-6B4F07DDB796"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mối quan tâm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5D6F33F2-4876-47A5-93EE-0D7B6780FAF4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"관심\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EC4D1719-26AD-4024-A5DB-A59D45302511"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"관심\" (mối quan tâm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("641C8BBA-8952-4C54-83FD-3EB1E4BF380B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"광고\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("72207D80-9DEE-4C53-9C73-0A5B1155637A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự quảng bá\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E8E5B8C0-8A1D-4941-92D0-7211EEFAB368"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"광고\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A35ABEE5-603A-422D-B587-1551F84B2887"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"광고\" (sự quảng bá) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2979CF9A-51C4-4D03-AF2F-C35BB6150D08"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"광주\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5CE41863-D5A8-4326-BF44-0A3B8AA11020"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"Gwangju; Quang Châu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9D58D85A-1280-49A8-A18E-2D83A7E614C1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"광주\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("25641602-0FFE-4EDA-95A7-13A244DC7E38"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"광주\" (Gwangju; Quang Châu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C7743862-3E9C-4868-9A44-2B8520CD5B01"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"괜찮다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("26BCFFC3-2221-408D-B4E3-E6CB7FD04BEF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"được\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DD335A29-93A3-4683-B5A0-0BDA43B8AF05"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"괜찮다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B7805241-8E51-4475-ABB2-459DA50C92D1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"괜찮다\" (được) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5805ADEE-0EED-4288-8990-73A0AE965F98"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"괴로워하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D90DF54E-A49A-442B-928C-49A32370BBD7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đau buồn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F6534B8A-BADD-4E6C-8986-BE8C9A4F4F7F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"괴로워하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("46C313EA-0BB2-413D-8FEF-A7457528D1BC"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"괴로워하다\" (đau buồn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("59FE3821-6182-46AE-A88F-27662BDEB9A6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교과서\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("418E157B-60CA-4BAF-A34D-42D995D1379D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sách giáo khoa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8F6DE372-49F5-4333-B05E-4D63C8A525B7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교과서\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7BDA0F5C-22DC-40BA-8AB4-04431FD5FB69"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교과서\" (sách giáo khoa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0D10FCBB-2DF3-4F32-995A-404860F7DBFD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08262D74-E3B2-4DE0-B92A-55058EA6A614"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tòa nhà ở trường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E7155785-CDA2-4808-B4BA-522A6C8578E6"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A71A5804-0318-4C0E-A165-FAEC9C24B235"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교사\" (tòa nhà ở trường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7A3EECE9-7315-4AAA-9399-25F53FDF84DA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교수\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A821407F-5212-4811-9FC1-226045F2263A"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"việc giảng dạy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D7C9384E-3B41-49F1-AA40-8406F9A0D583"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교수\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CF5C9FBB-BB33-4FFD-A1AB-684C3C618DA1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교수\" (việc giảng dạy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("11C5046F-EC5B-4B2D-BD6E-0CEC26D677E6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교실\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C8F4607E-EDEA-4A3F-8E76-CCC0738514FD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"phòng học\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("827E4C5C-F6E0-4FF8-BBD2-8F04C2D1BB38"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교실\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A3AD4778-7C9E-4C02-982B-F5FE61283015"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교실\" (phòng học) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6F94D2C6-C5F6-4356-A7B9-3A516F55CA7B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교육\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C280A2C2-0959-478F-83FC-36F997ABB936"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự giáo dục\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D2C4A6F7-F98E-4D1F-86D0-EF115A4E46FD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교육\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E323E8D5-0BE3-4D8A-91C8-3C9A84F592D3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교육\" (sự giáo dục) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("32C8D686-3E1C-4935-963F-7CD5A99603CE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교통\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D484B2BF-06CB-447C-9402-D59615B68788"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"giao thông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D431FB4B-50BD-4B40-8EC7-E6015745F15C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교통\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5060822B-F46D-490E-BA2B-01944434AF37"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교통\" (giao thông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A693ACF6-E76A-4CB0-803B-D9F46B502020"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교통비\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E561B4B-3D30-4449-A8E9-F771993E11FE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"phí giao thông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("327DC891-5E3A-4EB2-9EB5-66017689B4B7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교통비\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B281608A-C438-43E1-B2CD-EDBAA7305C04"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교통비\" (phí giao thông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("930B7E6C-A864-48BA-8D89-E578D3A471C8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교통사고\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3A1073AE-8EFE-4190-B144-AD35066B4147"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tai nạn giao thông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B2F4681A-FBE4-4C35-A24A-171C1A3365D2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교통사고\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B6887822-9C4B-4880-88FF-05645F2A5E83"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교통사고\" (tai nạn giao thông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1F6BA9A3-9004-470F-BAD2-8BDE24BE8B7E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교환\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("188B933A-453C-4304-922B-ECFEA43EAEC0"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự thay đổi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B82DD9A1-DF04-44F5-89BD-49590A34E8C7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교환\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("24652221-8649-4E11-9D60-540F2B8BBFF8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교환\" (sự thay đổi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("22317D55-1E76-4B99-BBB5-E65F482FC711"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교회\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("14BCF8EF-37CA-4690-978D-51C6D079AE63"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"giáo hội\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3379B899-0DFE-439C-9BB4-49EE1CF3BEC1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"교회\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("721F8A5C-CFCD-41D4-88C1-B7066C39AB69"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"교회\" (giáo hội) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EA0B4B38-D126-445E-9464-0E10573093A5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3984CA3B-1200-41D9-9E01-0C78C7BE6F0E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"từ ghép\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("085CE028-7BA2-4085-9BDF-727EB96076DD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"구\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("95E0C309-27ED-4CD2-BD0B-18E5D5A86FDF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구경\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("64F1D191-E94B-45CB-918D-5CB82F998D61"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự ngắm nghía\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3B1D992A-70BF-48D8-9152-ED54E266023C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"구경\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("81E3E0D6-2D1F-4CAF-B305-E00DA01ED3AB"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구경\" (sự ngắm nghía) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E3D95C4-311D-445F-B583-7A9FD84237F0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구두\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10EE99A0-FAB3-411C-B36A-F0747D3CC907"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"giày\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("58B9C2A8-A61E-453E-BE49-76BB649C36C1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"구두\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("62169727-7D71-47A5-8C1B-2F51597D9670"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구두\" (giày) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("47A0BAC7-0F08-45AD-9751-D7B6E5442E95"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구름\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("576FF0E9-AC8B-43D5-A95F-FFAB45E8E498"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đám mây\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D48756CE-D165-405F-A274-7FBE2AE31034"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"구름\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8DC68D47-17B7-4936-8115-26BCE8BF79E2"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구름\" (đám mây) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B7202F11-5341-40C7-A0A8-1C85CAD4BE40"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구십\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5F20E783-0D5B-4BFA-AF7B-2ACD46E6B3C7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chín mươi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("06B6A2F3-EC5F-4D84-8EAC-A24A53D23928"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"구십\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("867D5BAC-BF70-41A4-A8E0-9FCCAB95A90F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구월\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C8A105D8-1DFA-40DF-9941-9E5907E39AAF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tháng chín\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4BB6C439-919C-4830-BAA2-DFF5BC98FF31"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"구월\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("73BE820F-FF97-4726-B53C-FD98F96BFAFC"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"구월\" (tháng chín) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9F0F34E4-B9EF-4EAB-A9C8-175F8E2F383D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("458E214B-86A3-4014-A736-C9B5EC7B59AE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"canh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EB33198D-4C31-4446-86FC-B764B4618187"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"국\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0180C530-BF5E-4CF5-937C-3B15886CC564"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국\" (canh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("619C401C-6639-4A27-8B3D-FBC2DBAF717F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국내\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("30B76C2E-25C3-4B18-8E4F-49285C127ECA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc nội\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("77927601-444E-48D3-A932-CFCA6798859D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"국내\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("37DC8F64-337E-4A2B-8853-C7970AA7C76F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국내\" (quốc nội) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A3010844-2395-4D21-982C-05594A9858C2"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국수\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6A8D686D-5AE5-4484-9C2A-3999132F0E97"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mì\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D1B5C19F-B323-45C6-B6DC-768E4C3D050F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"국수\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5C4E91CC-9B14-4E2B-AD39-75B09D9B5561"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국수\" (mì) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0F28D0DD-C9C3-4B83-8AD4-669705A5FDD4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AFE1324F-83C9-4111-AF3C-0FD300E16D83"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc tịch\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("38513B20-808F-46B2-8EB7-E11E0C3242FD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"국적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D0743F3F-33B2-4F75-9239-C6F355BB53C1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국적\" (quốc tịch) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("924CFA12-678F-45FA-863D-F3BC071FA52F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국제\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("83B30A8D-33C6-4A60-889B-D35E5536ACB5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc tế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2AA9F020-05EE-4158-A8E2-BE4D2AB4C512"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"국제\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3DFB4B55-7E3D-454B-ACE6-BFEFF5929669"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"국제\" (quốc tế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("517630D0-77D6-48C4-8A46-B85BC844C654"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"군인\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("538EB9F6-7085-4AE6-89B1-C86432571E47"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quân nhân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3809F170-328E-446D-9965-478DD2A8AD3E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"군인\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("723B4C76-A7BF-410F-843E-FF9278E74F30"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"군인\" (quân nhân) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("374B3999-9BB9-4C9F-9D5C-8AE00FE63BF0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"굳다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("657E80F8-63C8-465F-B056-F83EA984BA0C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F88BE47-92A6-4136-8EB8-8D5992F75126"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"굳다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("07452B79-EB18-4EE5-A686-56A58B027DF0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"굳다\" (đông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6AC51703-A0D9-4C63-849F-2B7F4D79400C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"굵다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2FA1FB0A-561C-4D57-9777-3448987A9A08"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"to\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D3D9A1C6-5AE9-4B27-8F84-60160C3CEBF3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"굵다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6BE25A79-4F8C-4D84-92BE-C578BA61AF58"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"굵다\" (to) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("16D551A3-22AD-43B4-9C65-5360FA1BF9BE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"굽다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E7750EDC-175E-4F2F-A496-57EB99F2D139"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nướng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9548A204-09E8-4424-B10A-7713A6687696"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"굽다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A06B32E2-8494-4DAA-B539-0F6841CEC443"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"굽다\" (nướng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BE2B4CCE-D5F9-4D41-97C4-9A88F00FA0CF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"궁금하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("27F86C87-6AC5-4919-B681-E288C85A51CF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tò mò\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AE31B173-9B49-4B01-B422-308169E1DCD5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"궁금하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DC788DA6-77A0-4286-8759-0A822EE11C54"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"궁금하다\" (tò mò) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F86B71E6-BA48-4CAA-BC67-CB3B02236F0C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"권\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("02921402-3AD3-4125-A960-9A2DC8B952A5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cuốn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10CA4348-8AD0-49B9-A872-6CA884998E4B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"권\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CAC7E164-DDB4-49C8-9A1A-F0DE5B308063"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3A0279EB-285F-4522-A3AD-DDC5F0032776"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tai\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7D626303-F0B3-42A3-8951-12DB21ABCDD0"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"귀\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6B3A7758-3C8D-48E0-AAA7-8529B6C933D6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀\" (tai) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E3698E31-3B07-49D4-B108-70D405069516"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀걸이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("927C3EBD-4B61-4D18-8FAB-2224FDA66095"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"hoa tai\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0EDFCFE1-4109-49C0-A8D8-1BFCB49B10EB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"귀걸이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E78DC0FF-3EC3-4628-8A54-A40B6EBBF80B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀걸이\" (hoa tai) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D2EC1BB7-9EA3-479D-AF77-7FAAD637671E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀여워하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("454ADCD9-6FE1-4935-804A-AE4FE78283EE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"yêu quý\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("45E091BC-055B-42A2-9CA3-DFFF99CAB33C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"귀여워하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8C7C4550-E800-4867-B705-549FC465DF4D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀여워하다\" (yêu quý) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("87FEE8A2-9EA5-40CB-9EA2-50E3CD56CBC9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀엽다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("719ABBA3-99AC-4FC2-A7A1-FFAACB0E8C13"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"dễ thương\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C0CF763-117C-416B-86D7-26F24007ADED"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"귀엽다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2788DDDB-98C6-49FA-B3A8-5FBF379A3C27"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀엽다\" (dễ thương) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0694707B-1DC4-4B6C-9D80-CDA5041C1914"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀찮다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3911AC8E-334B-4883-84E7-A2E516F4A729"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"phiền phức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("483CB239-CD1D-4E06-9A01-830DAB288A97"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"귀찮다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CC880F8F-0F3A-4D7F-A92C-C706A86DDFBD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귀찮다\" (phiền phức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7DD8E511-1DD8-473A-9B9B-D7BAA773FBF4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"규칙\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("09DEAF83-577C-47E6-8FF8-E4D64F5A9E93"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quy tắc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("807FB086-F827-45B9-A3BA-DC2B7297C723"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"규칙\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("24FCAABB-9765-430C-B1D8-A67E0B1415F5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"규칙\" (quy tắc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4A47D76B-4D47-4275-B551-3BC65E863156"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귤\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2A0B57E1-0382-4169-8AE1-D66B2367B729"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"quả quýt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5C58F25B-E0EA-45DD-AF6E-67A1242EB742"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"귤\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E843398B-7A3B-437A-97C5-EDF537D858A6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"귤\" (quả quýt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C069E2DB-4873-4F6E-8BC1-8123A2D68293"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AB1B48F5-AFEA-4226-9631-E3F31D185BD2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"người đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("018B3A11-36A3-4D0D-AFEA-A66F61610B5D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9A660A8E-6BF9-4FB2-B3EC-4044DB99419F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그거\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("32333DB3-CABD-48B1-B93F-1A48F2A4E5B5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cái đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("496F3F61-E338-4E9E-B7B9-2FD36DF6A069"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그거\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("642CCE23-46F2-4BBA-A074-4D0FD5BB22B1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그것\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("99A6DD8F-4522-4149-92A9-5D1A949D5EB2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cái đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D5F688D8-2F22-45A1-9FDB-6F00B6FFDED3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그것\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5BB21B71-B2C2-4317-BC3D-C62A949D330F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그곳\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4C43E610-7C7F-455E-A486-844562F61FFD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nơi đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("009CAFE8-9DC1-4EC6-B677-9DA746F19D15"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그곳\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6DB3D7B6-A391-4F59-AA3F-E8B5A47B1AE3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그날\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2EE0A1A8-0F61-4A54-97F9-31FA2C93AE5E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"ngày đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("46EDAF1D-A35E-4864-9BA3-669A62A180EB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그날\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6B6C6BB5-C587-44BE-BAA7-B6F4C61D6899"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그날\" (ngày đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3F993CD-B9A7-407E-8986-9996D965ED54"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그냥\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("24DB7E52-B3B2-4CC0-A98B-94E24C2C3C0B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cứ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("059430C7-5184-42FB-9BB7-22CA14BAD9C5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그냥\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5A209525-1B24-4A64-ADB1-BD8C4CABCC82"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그냥\" (cứ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("157A3F2F-7083-4288-804C-543BD56E16FE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그대로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B69DCD56-0F3B-4F5E-95AA-E2F9B3686FBE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cứ vậy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FFB9B218-5273-4A24-B82D-A35006E7172F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그대로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C50EFAD0-C8CE-4587-83EF-1698DA8A092E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그대로\" (cứ vậy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C034E379-EA5F-4B84-ACB8-26E96CA878D4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그동안\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C87A746-CDD7-4FEB-A186-2445E00ED4DA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"trong thời gian qua\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2AEE0875-2300-48F9-80A5-2BEDA83DCAEB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그동안\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DD6F5AE0-9B63-4BD5-A653-02626C59F53B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그동안\" (trong thời gian qua) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A5A32BA3-9BFE-4711-BC0E-CB8AB5690AC4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그때\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F9FE8DBA-6BC5-4433-BE14-61CB3C321D29"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"lúc đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B5C7F19B-95DA-4167-9ACE-E3E07786F443"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그때\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B3C1557B-8A81-4E78-8786-334E106A0E18"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그때\" (lúc đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A80637B4-6107-4724-8DF4-6A4E8BBBE46D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그래\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("58B0A482-BE94-4E85-9D2A-F5A93DCCABC9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"vậy nhé\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4088559D-FB64-40CB-ADDE-C134F26B0EB4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그래\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1154E94E-8083-4FAA-BBA0-3E42A2C1ACC8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그래서\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AD57C54F-4B4F-4BF9-8366-4DFA01077F03"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"vì vậy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4AA0D10A-E0B5-4873-A85F-21DC6B9B01AA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그래서\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("15CBADE9-F909-4186-BFA2-BA38990F35F6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그래서\" (vì vậy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ECEB01EA-65F3-4674-B217-E919413AB8F6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그러나\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("345ED5CD-D37B-41FD-9902-163A6AD25818"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhưng...\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4D7B452B-FE82-4A69-B171-295CAD088D1F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그러나\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("02831109-700C-475D-B1D6-7264685A4F20"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그러나\" (nhưng...) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6A2DBFAA-5F06-430D-ACD4-D40CF1798D5A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그러니까\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BC22A375-1451-41E3-9DBA-A0F693483CF7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"vì vậy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DA0C707C-185C-4969-AA30-629BFF006FB0"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그러니까\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DFDC04AF-061B-437B-8680-635D39F3742E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그러니까\" (vì vậy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC3C6008-32B0-49B9-8530-A8D037DA36C8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그러면\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B615ABAC-6875-43DD-9DC6-970952E956A9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nếu vậy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("63D9ECAF-BB26-4DF3-8895-A979D630043D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그러면\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9E9D4B5D-02B8-4B8F-936A-BE19AA03C0DE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그러면\" (nếu vậy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC7670A0-E6E7-4350-8B68-EC6A472B1512"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그러므로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D50446E0-52D6-459F-B04D-0D896C0D1FE2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"vì thế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("49DC5015-4C6F-46A0-9C13-0B95E7FA22FD"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그러므로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("155F05DB-FD6D-4757-BE72-963D141C3ADE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그러므로\" (vì thế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E160F47A-DB06-4241-BBC4-EE55C582BF8A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그런\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2A9C2EB3-E01E-414B-8D04-F0CDFCE00D45"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"như vậy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DA56E0CF-AB54-4DD8-ABCF-B0BA31D82C80"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그런\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D16FCE9E-16F9-40B3-BADA-2DC83E6B32D2"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그런데\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EDB1CDA7-ACDC-43E5-AB67-77F971E45ECA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhưng mà\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("66A886AE-DA4B-4EFD-AF38-265AEBFE5A1C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그런데\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B7214846-D7E6-4C9F-91E3-2E1B77408033"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그런데\" (nhưng mà) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BB37E84F-2C2D-4C73-B4E1-C75284CDB60F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그럼\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("91F7A21C-C7BD-409D-BB50-361A61FEA3B8"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nếu vậy thì\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DA424F06-6023-4BCB-BA73-8E9BFCB8215D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그럼\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E04C0911-1C2B-4F3F-BEB9-524E9D7ED18E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그럼\" (nếu vậy thì) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D36E21F3-757E-4833-8420-9CE4DEB09BB1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그렇다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A3165D1E-ECE4-4883-84EB-AB14C469E300"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cũng vậy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2F52A185-8F33-434E-8443-7E0DDC6C3886"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그렇다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("20B4C9D8-0427-4049-BD44-258509CBD694"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그렇다\" (cũng vậy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("353D5759-6D47-4A1B-8DD4-8FC11745FD6F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그렇지만\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("386F5401-0F60-48F5-8F35-07F4ABF1C89D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhưng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("848D135A-4A98-4D3E-877D-A01EE130D8EB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그렇지만\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5F004B84-979F-4F5B-8DFB-E977CAD3DB80"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그렇지만\" (nhưng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C6C9CD9-B8BF-497F-A7C8-669F13C0AACE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그릇\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("197AC271-1B2B-441F-9956-F233D2DCD4AF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chén\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EACFF284-7E54-4DDC-98C9-8224466C94D4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그릇\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D773CA63-4706-424F-828C-0F70051F4590"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그릇\" (chén) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A25F8630-D29D-4A2E-814D-E7E7D1925400"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그리고\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A9FD0AE1-6C50-4839-AB64-A046A28D751B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"và\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D786051-7277-418D-A319-294E905614F3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그리고\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1F569F25-608F-4367-9054-9B02C10EEB25"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그리고\" (và) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("293F4897-459E-4B1F-9579-68504B5741ED"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그리다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9ECC98E4-36DB-4B81-B7D0-BFC50C79E711"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhớ nhung\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F5976DB6-786D-4183-8F08-259393FE83E8"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그리다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AA296996-9C9C-4BAA-8CEA-4FB4F11554FC"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그리다\" (nhớ nhung) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0E2E58CD-A2DB-4B8B-8A5E-5AB63A86A9D3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그림\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9A51E939-A451-4C63-8C46-B3BBF0E4FEE7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tranh vẽ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("09DF31DC-4D3E-4E96-A3DD-B6DF4931F6BC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그림\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("88BA1216-5AA2-41F5-AA94-0F70139BC99D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그림\" (tranh vẽ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("27122CE8-176E-472B-8FCA-28CEE5B528C6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그립다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C8896FF1-4CB3-4503-9D09-B07E9A2E0795"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mong nhớ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8ACBB204-12F4-4686-9DD2-F0D4932D962F"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그립다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CB129E1E-BB18-409C-99F4-6FC78BEFB348"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그립다\" (mong nhớ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E4D6447B-4AF2-4FC8-B123-8EF451AD7EAC"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그만\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DAE68685-76D8-4264-9B6F-C1F38B5D54EE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chỉ thế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED261AB4-099E-41F0-867E-4BC78F85DBB9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그만\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A1244F59-6003-4ED2-979D-08D39AB4A31A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그만\" (chỉ thế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B05ADAA7-F31E-410B-847F-79DAF27E29A9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그만두다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("21C272EB-4EA5-4002-9599-82660724C9E1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bỏ dở\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("38A4977E-3A74-4CE1-9B38-40F58E394F15"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그만두다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("404D6F2E-B380-4129-B8A4-930E95817A9B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그만두다\" (bỏ dở) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("29DCCD5B-511A-4E8E-96B2-D24266E128B1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그분\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("52AA189D-0E52-4D87-94C9-4F538D34F384"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"vị đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1431DCF3-36FF-491A-AFDB-040ED1D7A4F9"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그분\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F4E403F6-063F-4310-908D-C5AB294E2B63"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그저께\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A4D3615F-5016-4648-AC23-F69CD8CCD3E2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"hôm kia\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4A4B7500-DC06-47CD-AFDC-94C426EDCA68"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그저께\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4C702353-E1AC-4123-B7F0-7EAD05F55FD0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그저께\" (hôm kia) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5016E6DB-8644-4DB2-9117-B853127CAA21"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그쪽\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D777B5D3-1BB7-4DE4-8328-EB4A8EF49B67"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"hướng đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8DFD2450-F137-46BE-860E-6648902ACB5E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그쪽\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("69670C86-D953-489A-957E-9CC1DA0D60B3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그치다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6214ABB3-E406-40BE-8AAC-DC7C3B188BDA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"dừng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED82F2BC-DD01-456B-957F-9AB0E32BED6D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"그치다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("95DCA734-1BFA-48CA-A81E-491BC1CA84CA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"그치다\" (dừng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B2F0E7CD-8377-446C-9300-AA4C91559513"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"극장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B8E19820-C0BC-4D50-AD73-D644186923A4"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhà hát\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F5E931C9-675B-45D9-A4F5-AB11AD2629EB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"극장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D762A88D-27C2-4E66-A0AF-35DFF834A5B8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"극장\" (nhà hát) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1CCD955E-BE46-4D46-A9CA-4077DD025CE7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"근처\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4D785143-DEC1-455F-BD8B-AD0C13E84494"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nơi gần\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2A6E1EF5-1651-42D3-B959-48386BDC6339"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"근처\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BBD886AC-14E0-41A6-A195-0CC899555C4F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"근처\" (nơi gần) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("37E78EDE-A729-4E9A-9C02-2D0882B70A74"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"글\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D6F3E1A3-D1D2-4D02-8F2F-8FE2CEC10D75"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"bài viết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3643B94C-DBD1-42DC-A731-AC403E5A1B66"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"글\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("13094CE5-1DE4-428C-ACFC-86C0C7A3245F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"글\" (bài viết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5633E915-C846-4104-ADB0-E9613AC46D30"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"글쎄\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A3894DEB-9D5D-4408-A229-7E4536C4FF2B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"để xem\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E17BF47-79A6-482D-9D68-3A480F9F6256"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"글쎄\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4D594595-A3AA-49C9-B3BF-5DDBF4122DF1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"글쎄요\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A82BD3CC-E685-4D23-8CE4-035B37B41557"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"để xem đã...\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("360B87D8-36D2-42F0-A149-6E58BF7246AC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"글쎄요\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2F9771E3-0C1A-4709-BDCE-AF25524E0B56"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"글씨\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C4DAB572-7D4D-4758-ADF4-713D6FCC78A3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chữ viết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7D32881F-2109-41CB-82DE-00A595BB94F5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"글씨\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("72755B01-DC82-4D59-8744-1B241F93CDBF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"글씨\" (chữ viết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E87CA59D-59E5-465F-A419-4A26B3F73CE8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"글자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("32638154-D9BB-4393-BDA7-FAC729BA184B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chữ viết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("18D0AC24-8096-41DF-84AA-7C73F8BA06E8"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"글자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6761DC2B-6624-484B-99D8-F9867189AFD5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"글자\" (chữ viết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6690A5E7-C70E-46FD-B0E0-5109F58D3C71"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"금방\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("88E7FD5D-2435-45F1-AB9E-73DC2CC2F715"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"vừa mới đây\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("353911A1-E098-4B5C-96F2-A54481F0E434"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"금방\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7C878249-7099-4A6E-9E51-74793DE72055"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"금방\" (vừa mới đây) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7560E193-5887-4F5C-99C4-F741B46CF7FC"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"금요일\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F409DF4-70D7-4FD4-BC5E-21C14A5D0E49"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"thứ Sáu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("806D3D74-27F4-4E5C-B035-3ACF6FE5E601"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"금요일\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("138C7514-FD4D-4453-BB9A-75A462FBA27B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"금요일\" (thứ Sáu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("756A69F9-C55C-4EBE-9DA8-AE3E674A13DA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"금지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DD9A0FBF-BCFC-484A-A789-73578C5E3614"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"(sự) cấm chỉ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("554ABEDD-CECE-443E-AFB1-C5F0AEB3399C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"금지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6C97A59C-D6B1-45FB-B4CF-60CAD6FA3C4D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"금지\" ((sự) cấm chỉ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F8E24232-2AC0-4C0C-AEDB-8380C9B47B82"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"급\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("17BAAC40-CE70-48F9-8685-58A8B77D2B44"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"và\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FC232961-29A7-4C3A-B858-F66618CA99C6"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"급\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D78CB039-1E5B-48E4-9D9F-03E1C1098C4E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"급\" (và) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FFA697DC-8312-44B7-B30E-FD898ACD86C7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"급하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3474BC21-18AE-4AFA-8054-11E7AB9994D3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"gấp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("06DA2CCD-C1E9-4A20-A012-7ABF6BD0C89E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"급하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CC8A7E15-6E3E-4E40-9AD5-98FDA707A68F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"급하다\" (gấp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5CEED9DB-7F58-44FC-8CBF-3E323F782204"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기간\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2FC5C3F2-17C6-48FF-93DB-A1D5D4AB8B1D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"then chốt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F5C66B39-D22A-493C-89A3-95A343AB0E11"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기간\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("987F667C-B209-4489-A59A-1AB76417A0A4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기간\" (then chốt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F3882F24-04A5-4BD1-BB8D-1BCC19A50C08"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기다리다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A2F7692D-ACFF-4778-A59D-87D9B4C0CF3B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chờ đợi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C4B02073-7ED0-48DD-9A7D-02A4A33C2306"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기다리다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C0B14D90-46DE-484A-9E35-715E617BDFD5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기다리다\" (chờ đợi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EB0364EF-1BF9-4A30-B954-E11D7DD99552"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기르다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A7C9BBEF-9A88-4558-8B62-848F8B9A25C3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nuôi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33914458-DB83-40C9-8E6D-D05B897721D6"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기르다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C32DFA78-FDDF-4204-B2CC-762856D92923"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기르다\" (nuôi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3738A3BB-0C50-4475-A176-48996F8220E0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기름\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33E6B087-D246-458D-B198-94D04569F665"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"dầu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F3FFFD1B-8994-4CD0-BC43-B17054B0AB36"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기름\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B19AB9D3-9639-40AE-B61C-A7C0D41C2EC7"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기름\" (dầu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FC595AFA-F3B9-4527-8696-9A4491A2BBF3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기말시험\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3F9BB8B-932E-4290-B662-53177BF8D157"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"kỳ thi cuối kỳ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B596334C-9093-411A-ADBB-167FEFAAF841"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기말시험\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("86F0E996-64F0-4970-B213-8569C20C1B7A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기말시험\" (kỳ thi cuối kỳ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5DBED717-F677-4037-B16D-E22839565F22"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기분\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("894A6D13-AD60-483E-AB8B-6F2D4833E46E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tâm trạng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("45ECAE88-74EC-44B4-9FDB-BE13F0F342DF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기분\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DB5910DB-D13D-4A5B-B33D-E4F6E01F202B"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기분\" (tâm trạng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D75887B1-D4AA-428F-95DB-D0BF1B658770"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기뻐하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("46D5542C-5AC7-4EBB-A173-CB881EFD69D2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"vui mừng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("004A65F6-93F1-4D35-812F-9DD5D8452D77"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기뻐하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DD881A08-0B44-41F9-884F-5A44BD47317E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기뻐하다\" (vui mừng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DBE1B3C0-4057-4252-88AD-39A97FD09CC4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기쁘다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3FD1BD2D-5956-4E14-80F6-3536A2D71775"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"vui\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0066FEFB-B3A9-43D2-9BCB-84F8313A9566"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기쁘다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C0C0137E-179C-40DD-8BC3-D867B20EF556"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기쁘다\" (vui) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6EFE7791-9801-4AEE-A89C-3FA296C1A8FF"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기쁨\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2A048ED7-D6E3-4425-B511-059F4A52CA0B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"niềm vui\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("63CE45F9-7EB3-43C2-8145-E84E7865DEE3"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기쁨\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FF2602D9-FD1F-4767-99F0-84E70167650D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기쁨\" (niềm vui) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FA9C420E-136B-4B95-8A3A-4955E81B4543"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기숙사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("616CCDA6-1C8B-468F-8621-16D708E84AFB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"ký túc xá\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B039E947-09D8-4B38-AF7D-32802F1BA95D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기숙사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F977FAB4-856A-4193-934A-D3C4A906BE4F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기숙사\" (ký túc xá) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A8E54D79-028C-423E-B7E8-7BA73DEA888D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기억\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C2E7D383-CAF9-4F24-B1CA-83DE79014708"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự ghi nhớ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("75178260-10E8-44BA-AE5A-8E53483A67CF"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기억\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("12D32372-62D0-47B9-8AEB-7AC6DDF62680"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기억\" (sự ghi nhớ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC6263CE-E8C1-4B90-8EC4-001DECD62CCA"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기억나다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("190A470F-37B4-4060-B280-18755655D681"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhớ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2A384516-36DA-4463-AD01-7C22A22F74AE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기억나다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("909FE60C-D9F9-4000-B72B-B60AB5F4A7E0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기억나다\" (nhớ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("25716066-89DC-488D-94A9-E2BD0A064A48"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기온\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9EBFCCEB-08AD-4753-9C42-C5398060C8B2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"nhiệt độ thời tiết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F71FC744-11F5-44C6-B204-D525A51152FB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기온\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("572B497F-95DA-429C-998C-024DD513C51F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기온\" (nhiệt độ thời tiết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("44EFA9EB-1BF8-4448-9FDF-D051D0EF7DAB"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BAD03880-A8B2-4DD6-B1C0-48C8A6A2CD73"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"ký giả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AD9F3E38-F80D-4379-A912-F5A5C6A54954"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F242CE53-12B5-48F4-8D81-BDCAF9F162BE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기자\" (ký giả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("46DB63AE-BCD3-434D-94DF-BBE045049781"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기차\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7CB023C5-9E48-4963-90EB-70B9ED1A8837"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tàu hoả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB7DFAF6-647E-4241-9811-455CED21A9B7"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기차\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("059E3449-5569-4EA0-A42A-66E4E088A211"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기차\" (tàu hoả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4D2F02F6-A2F1-4501-AA27-7063AECBEC0A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기차역\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B0D49B33-E335-4713-A32C-4011B756B9BE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"ga tàu hoả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5FF68310-8115-4370-9EEB-4E71C8BEEA59"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기차역\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FC23F538-1C71-40AC-B4C8-CAAADD0DEF94"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기차역\" (ga tàu hoả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("34C1DA50-77B0-4D68-8224-D5CCEC69F347"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기차표\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("87286274-9CF4-4395-94DD-F6C80697654D"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"vé tàu hoả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("329F8353-C6DC-4FB1-9808-EA39A5C7ACEE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기차표\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0A768409-838B-4094-A2E2-AD8F75E3872A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기차표\" (vé tàu hoả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B95CE44F-4462-47A6-92E2-55D122F295D0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기침\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("044731A9-7BBC-4294-82AE-B8ECBA8B4936"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự ho\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E9A82E9E-8C8B-4713-A420-43770C912AEB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기침\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D88ED29E-BF95-40FE-93CD-E6ABB3116ACD"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기침\" (sự ho) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4068EE38-B2C4-4A9C-BC67-874A9A3B31D0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기타\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BD92B51A-3266-474F-B520-0E8A11FF3072"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"khác\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8CAEF810-C2AB-433F-A9CF-41E103D2AEAE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기타\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("340EE272-4F26-4285-9C52-99BE1EE44DE1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기타\" (khác) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1CF1C55B-E880-4397-82B8-C38403C0C725"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기회\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ECD4755E-5DA7-48DB-94CF-6839F89D7CEA"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"cơ hội\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4AFF7032-F3A0-4B3A-95D9-8B322749AFBC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"기회\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8F123E2A-61FB-443D-8506-CB6026B5957E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"기회\" (cơ hội) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5870A541-C8B1-444E-ADCB-F7FE3C1A5D3C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"긴장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2C59AAB2-6D41-4DAE-988A-04F84F130F26"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sự căng thẳng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CFC46850-6880-45AC-996B-18E6FBC1B742"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"긴장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BFC8B27E-E2FA-46C0-B19A-7EF11971929D"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"긴장\" (sự căng thẳng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0EF6DBB8-12FA-450C-9EB9-9DDA47AF4DF9"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"길\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E1170B2-67FE-491D-B67F-1ED920D8CCC6"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("73CFDB4C-AF13-4D23-9FF7-529BD51647E0"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"길\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B2C16BC6-AF43-43D6-B7CF-1D02498D9127"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"길\" (đường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10F356B0-4F52-440D-89F4-C7E47AD1F3F3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"길다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6A2430CF-B2AB-432D-AE97-F0050DD5B68B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"mọc dài ra\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10AF60D0-F486-45C3-8870-A07EC35B0067"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"길다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2868B54C-1427-44A1-BBC5-5A335C44CE31"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"길다\" (mọc dài ra) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("99A165F7-0CF9-4BC6-B78B-CAA4FD664784"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"길이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("17DCC093-E003-490F-8853-3ABB9611862E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"chiều dài\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("11AC8C51-6535-4914-AA2E-56D5BA8BCDDE"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"길이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D641239B-AF71-4EA1-B392-8593B223284A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"길이\" (chiều dài) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3E06DEB4-DD53-409A-BA6E-5A887D2A9A85"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"김\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0E7D1C1E-FB2F-4DAC-8307-FECE4C455D97"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"hơi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5D5C71F2-8953-4B1E-AEE2-22E8A2CD4E10"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"김\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2739D717-3249-4D12-B35A-90D6CF775294"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"김\" (hơi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AEE2E8F6-6361-4961-B083-88DB8FA3A497"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"김밥\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D7DCCD2C-7415-4E8C-A409-8D367B20B748"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"Gimbap\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0CC24EF3-0481-4598-8BF1-1ADD1C9F5C8E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"김밥\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2A99E6E8-CA83-4753-BB76-0DAF1C295F5A"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"김밥\" (Gimbap) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("53B01D39-B81F-4AF5-84D0-1BF119BE16C8"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"김치\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("64C6C6C8-10A6-42C5-A072-224CE2A78644"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"kimchi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("02028E75-1BE4-4B05-907D-66005C0C25DB"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"김치\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CAE36D73-0FCC-46EE-BA6B-97DDE9654AC2"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"김치\" (kimchi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1F2A07BC-0350-49D1-80F7-173BE2FF828F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"김치찌개\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3408DE6-0342-4095-9A07-34BFD6C07A20"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"kimchijjigae; món canh kimchi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BA0266DE-9B6E-4125-A283-80E1686C6054"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"김치찌개\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("160A0569-E846-4245-B9E3-E44E81D17F3C"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"김치찌개\" (kimchijjigae; món canh kimchi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D756AABF-822B-409D-8D10-5376C606D059"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깊다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB6F3F3E-4830-4D96-BF8F-6DA580CA8CED"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sâu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("09C4D6B9-C044-4A6E-9F73-459B8DFFE306"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"깊다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AD8A2B22-340F-437B-91A9-19C126BFBE88"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깊다\" (sâu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("53E270A8-8BFF-4CCE-A1FF-61D090EDCC24"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깊이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("49CDE63E-FBCE-4551-9151-D7CBB94483F2"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"độ sâu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("65205607-CCFE-4238-9EF7-C754D9E5BB62"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"깊이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("66927868-AA02-4DD9-AAA0-A9E4FD3A0BD2"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깊이\" (độ sâu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8FD6F946-B8C3-4D21-AB7C-FBD6D8D7856F"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"까만색\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7DD30760-74E9-48F5-BE57-F53CB8F6E897"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"màu đen\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7F2978DA-DD72-4A23-88D9-BEDCDEEC460B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"까만색\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("37EE255A-CBA1-41DC-B66B-BC015AD0589E"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"까만색\" (màu đen) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93DA9F32-7B07-4462-A1DA-759539224735"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"까맣다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8F01DB02-54C0-4B02-9D4B-05BBA08289DC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"đen ngòm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("857D0A5A-6B8C-4B3A-A363-BD325305AAF1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"까맣다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FDDE27E1-9C06-45AF-884A-E235288FAB40"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"까맣다\" (đen ngòm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E89CB87B-7794-4409-A1EB-A517629CBE05"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깎다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DFC72E08-9D23-4DDE-A3A6-D2D5B21FC739"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"gọt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("49DF759E-7CB3-4A15-A603-DDBF3800BE1C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"깎다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9A76AC77-39D1-42FD-AD1A-09C77741D2C6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깎다\" (gọt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B4E03077-05D1-4121-B1FD-E76D18A6EDFB"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깜짝\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("884B5D91-2BE9-49B0-8E33-F081B68E5094"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"giật mình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C2C9C3A9-D8E6-44C0-B8B6-0B67ACAD00B5"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"깜짝\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FAEB1BD6-7DBB-408B-9622-E840939C0DE0"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깜짝\" (giật mình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4CE98571-EF05-425F-A25E-56E39AF80D01"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깨끗이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("15D31C61-D12F-4E2C-9C97-27F3437EF49C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách sạch sẽ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3EA75121-54D7-46B0-9789-E2806F4CA303"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"깨끗이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8EA77523-4080-4832-B5DB-D60833C46783"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깨끗이\" (một cách sạch sẽ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D9E60309-E8FE-406E-80DD-840755147039"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깨끗하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C22B5E5-B403-4541-A8A8-8FD0C9893B40"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"sạch sẽ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("738C688C-9E9B-4127-960B-E4407A439C8B"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"깨끗하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2BB8A230-AA74-4DAB-B770-DE19042DE8E5"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깨끗하다\" (sạch sẽ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8B3084AC-0439-4793-91E8-5FE90C5FC5D6"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깨다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("44FD9760-B6C3-44C3-9FDE-9777B8581C9C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"tỉnh ra\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E11A5B9-0AB3-4BDB-B03B-1181624C5BFC"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"깨다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("54FAE5DF-73C9-45A0-8208-C97599693CAE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"깨다\" (tỉnh ra) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB7D53EC-2D05-4EE1-A87E-2CA4DDB382C1"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"꺼내다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3E25D8E8-CC4D-4F21-994D-305FD5BCB08E"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"rút ra\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("534655F1-D372-478F-BB24-E1B5767A0E64"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"꺼내다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("85DB6263-C82D-4246-A425-0ED5952093FB"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"꺼내다\" (rút ra) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("51460A9B-F5F9-4332-8E2B-C53C6B41A529"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"껌\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C3F8838E-98A1-4F84-8C43-A6067D48FEC1"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"kẹo cao su\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CDD8070D-8FC6-4537-B808-02CB36936E8C"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"껌\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E7964F06-63AD-47AF-8CCB-137EAE0D02FE"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"껌\" (kẹo cao su) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("605F3A39-E92C-4D36-836E-87C1D1C8F4E3"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"꼭\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1EFB5963-878F-4E79-B489-D22866BC59ED"),
                LessonId = AppDbContext.LessonId1,
                Content = "Từ tiếng Hàn có nghĩa là \"thật mạnh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1016C691-DA5F-4720-B00C-21783934A8A0"),
                LessonId = AppDbContext.LessonId1,
                Content = "Viết nghĩa tiếng Việt của từ \"꼭\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("61736B04-8B64-4B4E-BE72-1B4928FDD1C4"),
                LessonId = AppDbContext.LessonId1,
                Content = "\"꼭\" (thật mạnh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("76932317-2A3A-4FBE-A398-2D56DF9CE148"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가까워지다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5ED881DE-07B3-43AB-99A8-CAAD41A7A673"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trở nên gần\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2233E63B-3C4B-4CC4-8E59-37CB88EBA656"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가까워지다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("431D6B40-0913-4770-8D25-19597451C6BA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가까워지다\" (trở nên gần) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5BEC28E6-10F4-4CA5-B41F-5D7B5826251D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가까이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("54F0F910-285E-45C8-84FA-F2F0478EF738"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chỗ gần\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C07D265F-6D46-4146-8869-791FD57B22C7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가까이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("658177E0-8964-4589-8CBC-9B0B20494FD4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가까이\" (chỗ gần) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("13D9665E-F7D7-4C55-892B-C8B6407DA377"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가꾸다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4ACA247B-FDE1-464C-8B8D-B529EC266A5C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chăm sóc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FF3E1AA6-9B57-49BB-BA41-0D8952040822"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가꾸다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C3EF05AF-682C-4215-AEDB-6FB083B4FD56"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가꾸다\" (chăm sóc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("697888BE-64BE-47C6-BA39-FDCEF1AF3FC3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가난\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("57EDCA58-F46C-474D-9F39-A7BA47E4F131"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự nghèo khó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D6E4EA34-3B11-47BA-8A92-3B4A82200578"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가난\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BDCB0950-54C8-4C82-90A0-115BCDD90453"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가난\" (sự nghèo khó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("26E7F600-C70B-40C3-A11A-4D657C9D5218"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가난하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3DCCD24A-14FF-4EFC-A0DD-D8754719C57C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nghèo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4C274D14-E88C-475F-BD03-2D209E910B66"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가난하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3DFCE4A2-E528-4973-9D03-A88AA1C77164"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가난하다\" (nghèo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("91738FC4-1349-449A-AC2E-F168EC9EC752"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가능\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F24274B0-90CF-416D-91AF-D8DA5AC054B8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khả dĩ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DED890C9-AD25-4E5D-9D4F-487AD3F3472C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가능\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8DAC8727-D7F7-4041-B756-0EFDC7424B5E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가능\" (sự khả dĩ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("483FF9A8-0ABA-4F0C-B98C-15A63C158681"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가능성\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7A2B58B6-736D-459F-8A56-9AA6C6DC11B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính khả thi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C8407037-6EA4-4F0C-8D91-AE2292316FEC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가능성\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A574912A-36C3-47BE-918B-1468A198A538"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가능성\" (tính khả thi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BE53AC44-E9BD-4683-A6AF-44CEEDAE6761"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가능하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("282D925D-F817-44C1-97AC-9A0A7679738F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khả dĩ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5BA0F6D5-9B0C-4E22-8D0C-1DAA0FC41ED0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가능하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("15285619-02BE-4B78-B212-02F3BBE32BFF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가능하다\" (khả dĩ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3EFD747A-38DD-4887-A6E6-65B11C2FC97C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가득하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("470C901A-2B07-4A47-87E6-A02F83034219"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đầy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("52C91A6B-8AA7-4933-BFC0-142483DFED0D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가득하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("12042A0A-4B40-4417-9E5F-90383A5CFA5E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가득하다\" (đầy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DC634557-6855-41D2-9CA3-204D3D239911"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가득히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FD0977AF-910E-490D-93B1-C63884B10BB7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đầy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B4C7EC21-E901-468C-951F-399D16CDE17F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가득히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("74844669-8691-4807-95B0-140BEA9B0233"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가득히\" (đầy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("73691E82-37BE-44FC-95F3-C435395795FA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가라앉다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4AF09213-07D6-4FBE-AF3D-C8F96D864D09"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chìm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EBBDBD0B-37F6-40BF-A091-8004D5443EEE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가라앉다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4FE70FDE-BDC1-4228-9069-B65BB598E85F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가라앉다\" (chìm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E77800D-EF01-421D-BCE5-B3C503FE0126"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가렵다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E20E85AD-7CEA-4322-800D-90A251EFD499"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngứa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("96EDD613-7FAF-4B63-97A7-10980E71EDED"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가렵다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EE59E858-5A19-4EF3-8B0B-5941F54CE464"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가렵다\" (ngứa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93AE2721-DC95-4C5F-A67C-D3CEDEAC5B8D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BACF6DE7-2BC9-4353-A567-822C13E0599C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chiều ngang\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("443F3034-514E-454E-A1CE-351500170A45"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2149041D-DD58-470C-97B8-1B4457D2B732"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가로\" (chiều ngang) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DDA9297E-E11E-4568-882D-6AF0A86E7B86"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가로등\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("065C71EC-653D-451E-85E7-9B7CE2371EC7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đèn đường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9EF5C886-BDB5-432D-A0B4-43294BE74412"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가로등\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("937AC861-334A-4E6D-BCAE-2A2201526D9F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가로등\" (đèn đường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F3A63EA-A592-4EF6-94A4-94DB0AF72CF4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가로막다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C8CB082-1D81-4DDC-9B00-F11FAD135340"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chắn ngang\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A588208A-117C-4356-85A9-F4C5484A571F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가로막다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6280D27A-C6CA-4AD8-AA6A-9C9B3A401572"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가로막다\" (chắn ngang) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("97DABD8D-F801-41E1-B0A6-822A057A3BAF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가루\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("64B84BB0-51DF-435D-B624-EED22E8EBD76"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bột\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8B99C57A-28A5-42B1-A125-F1B10A982967"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가루\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1342F3B6-BAA5-43DC-A5F9-DF0D18D123F8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가루\" (bột) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DBB9D765-C7CF-48DD-9CCD-4CA5B6A9F782"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가르다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("62D5BFDC-0848-4802-AD8B-4489DDB95776"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"xẻ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("839E3268-04C4-48A2-ACCD-B1BA29FC4F7E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가르다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FB0138A7-DC65-44F9-8746-2AABDC3CC922"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가르다\" (xẻ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6768AED3-2BAC-4789-80A3-0F3D08CDC44D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가리다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9FA82539-362A-4210-AD42-D4CB95D14A98"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"che\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ECC1863D-15F8-4F7F-944C-0114C7D3E59C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가리다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F4315637-69AB-4933-83C1-F87ED9B094BD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가리다\" (che) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F98C7F4F-DDAF-4CCA-A139-049E30E2A573"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가만\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C7BBBD4B-83B6-4012-BA7B-0E909978B2EB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách lặng lẽ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("60016E8D-57E7-43DC-88E8-D97F9EA9DD22"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가만\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("164E1F19-A3BE-495B-8BC2-D888D2E705E0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가만\" (một cách lặng lẽ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EA60F4C4-EE50-4EE6-862A-4D18E40F6C3F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가만있다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("83460E7A-00FE-458A-98D6-C76741498016"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ở yên\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0B4B58CD-E009-408A-BC7D-E79BF946EA4C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가만있다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("54575252-E675-44E2-BFCC-10FA0C424907"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가만있다\" (ở yên) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7AC75AFA-3F88-4458-89F9-690D99DD7CC0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가만히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F4CCCFC4-557B-4265-B661-968F85A804C0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách lặng lẽ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9292D575-4C15-4495-9F7B-456901D1A2F8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가만히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("188C07C3-6FC1-402D-B5C4-2474C197E4B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가만히\" (một cách lặng lẽ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB483A4D-236B-4A1C-BD72-366D8468FBB8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가뭄\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("23C728CC-5073-4B16-97D8-DDFFC35DD4AB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"hạn hán\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E0ACBC91-5956-4EEF-9273-E6B6CAA0B53F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가뭄\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E980DD89-D2E1-404D-80A3-88D0519CB1C6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가뭄\" (hạn hán) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("83C34428-23FD-41BD-8C19-5318825A8991"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A5E55027-BD32-4B88-8430-57BE7E29B56A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc nhà\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("57455E31-CE27-4AAD-9EB7-0C9DF6605C4F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4746B57D-9A5A-498D-BEA3-43FD3155FFB2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가사\" (việc nhà) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D1058121-10D1-4B00-8510-7E5FB37A5161"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가스\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB051B4A-BE16-4BD0-922D-64F0182B66C4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khí\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9214DDA9-7B95-45D8-A552-D110DF2E1269"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가스\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6D7AC7E8-C353-4684-9C2D-A05B217DD4FF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가스\" (khí) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB10DDFD-990B-41FD-A53F-D2250FAFEDBA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가스레인지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1340F3A1-AAC8-4DF6-B050-836E3B6A0C66"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bếp ga\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C92A0CE-7C38-48AF-BCFA-EFE1C12B8CBA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가스레인지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2A853821-D3B7-4C00-ABC1-423230B780A1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가스레인지\" (bếp ga) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6C4EA595-3837-44DB-932C-FBC8368D909C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가슴속\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6D9F81A7-B5DB-41FC-B78E-36FE39F35A7E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trong cõi lòng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("56484417-8754-417F-A4A2-C9885120B415"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가슴속\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("57462660-9F1A-4277-B30D-350092EDD54B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가슴속\" (trong cõi lòng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A429CC55-355F-421A-BA3B-E358AC9B6C47"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가습기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C8F686C8-94E9-45E4-8208-B1D74C76F3A8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"máy tạo hơi ẩm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EE9A3E1C-3EC2-4ADB-90B1-0D5D880DA87E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가습기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D80BB835-BF30-4EB5-BA85-1CBB2811D369"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가습기\" (máy tạo hơi ẩm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5474D511-F017-43E6-91B6-8F231A670CBB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가이드\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5F3637C1-3E13-4005-877A-FF18C98A7417"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"hướng dẫn viên\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4D342206-629C-48DA-9ABD-46A71BD3D662"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가이드\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2CF26118-6145-4C2C-A635-9CC88EA3AAAD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가이드\" (hướng dẫn viên) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C64CEBA8-C7C9-4C8C-B266-A4C48527D501"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가입\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("39768AAF-2CF9-4347-9D84-37ED354FDD8B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự gia nhập\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BC1EEF93-751D-42B5-B6EA-00AC6E54B306"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가입\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2ABEBABC-FCA8-4E1A-880B-52B4573CA8B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가입\" (sự gia nhập) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("67A7E50F-802A-46D9-B749-7B56D9D03D3D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가입자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("04AE585E-D6E1-42B9-BCD6-DE6C7387D5D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"người gia nhập\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2D6F1484-DE9F-40C8-A983-49E89EB5463E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가입자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("188422CA-723C-4B77-B693-D5F06E3DA6CB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가입자\" (người gia nhập) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C751A995-44F5-427C-BBF0-9CFE9D063032"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가전제품\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ACE2993C-0DCA-47FF-9737-5D470F40CE3C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sản phẩm điện gia dụng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2764DA5F-FB1F-4534-95FA-C00DED43F162"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가전제품\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3D7E71E8-7EC6-49EB-B3DC-5AF3464312C5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가전제품\" (sản phẩm điện gia dụng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("511CCD4D-D1A9-439E-99C7-3CD73D510CB4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가정\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("75C02D96-2F7D-436D-9265-BE23AD54A098"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"gia đình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("55B5194D-DFEE-4575-BC0C-1D9834A682F9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가정\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5F90F196-C409-4352-A44F-DEFECBA794C5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가정\" (gia đình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B8773936-CD82-4F1A-968B-EFE977F420B5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가정주부\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9CA02B1A-DE16-4686-B13D-CDAF7A0E8503"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nội trợ gia đình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("61C271BB-7F73-4126-A726-4C2994E0C530"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가정주부\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D3D5ACFA-5962-4ECD-BF37-BF039069CE21"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가정주부\" (nội trợ gia đình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2F8B788F-8B13-465A-BF1D-9429B95FDF2F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가져다주다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6DD6077F-7158-49B7-A5D8-98C4D024AA8F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"mang cho\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3921B1A0-B149-4BF4-86D2-8CFC1393E06E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가져다주다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1911E16E-0C60-45D2-9870-0EDB7AAD93B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가져다주다\" (mang cho) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F39114EB-3F72-41C2-8173-61B79AC35B7C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가죽\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A6B95765-253E-4916-A86E-249134C05C81"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"da\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("52CC43E7-CDE7-4B97-AF6A-D131FF25FFA8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가죽\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D28331D4-E3A3-460E-A9AA-BDB6B5551B1B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가죽\" (da) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DD854D7D-6DD9-40ED-A45E-72C9F197BBC3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가짜\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0C68552E-4380-446F-B14F-5D1180D18CE5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đồ giả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6145F0B6-534A-4D66-B8B7-B2083FF6A4D4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가짜\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("54482CBE-BA36-4188-8A48-4F08BF820FDB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가짜\" (đồ giả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF63CFB2-49B2-43E2-95AB-15FFFCE658E0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가치\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("52713236-CE20-4C62-880F-CBADCF0A71FC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giá trị\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("69CB4859-3664-4D93-AA01-384815965FE7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가치\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4BFE031C-4BCF-47B3-887C-D621B4FE760C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가치\" (giá trị) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("38A3D9E2-A9F0-4EC1-99DE-6F8FDA566F70"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가치관\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C64A432B-3D62-4ADC-9AB6-486F59824FF5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giá trị quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("83402569-C7CF-4508-93EB-9003E784169C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가치관\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("96C7BDED-82A4-4EBD-B1B5-CF0308DF89A0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가치관\" (giá trị quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("586A5E56-295E-4398-AAAB-A8EFF0D90C37"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가톨릭\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F73F5E5A-8496-4438-8A76-13AA6940E6C1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đạo Thiên Chúa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("79697F6B-D9D0-481B-8353-6F102B8E6218"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"가톨릭\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("80FA3A33-83F8-4AF9-A3B6-3E5D736EC475"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"가톨릭\" (đạo Thiên Chúa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2AFE568B-91D4-44C4-93D6-C43A3FD6D3F3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"각\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("48BA3D63-59CB-47DA-A276-21E0137F0079"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"góc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("96541F69-4B01-4291-B762-0A8A8A8FF67D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"각\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3F81964A-EEA7-427A-9543-B1385147A114"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"각국\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B7E1687E-AC89-44B1-9612-7D255C8C5993"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"mỗi nước\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DD33AE08-D962-443D-BF2D-B0F38603EE31"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"각국\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("28A64AA5-A116-43EB-9E01-2A6854BC67C2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"각국\" (mỗi nước) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("239340D4-2930-4E36-A8E9-099AC2C398B3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"각오\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D18B3FC3-D389-4DA9-B336-BCAD226ED590"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự giác ngộ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A63C5764-408D-4023-89FE-9A0383340618"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"각오\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B386607B-D7FC-4E20-BFAD-2111F41DB5DB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"각오\" (sự giác ngộ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08147F94-8CFF-4B3E-A779-48B35C229AF6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"각자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("48EDED86-4FA9-4AD1-8D1D-3CB57455AD3E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"từng người\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1208F9A4-5CCC-407B-840D-FE8581655B27"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"각자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E2BEC63E-F3F2-42B1-BEC4-B27E73C1A5CD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"각자\" (từng người) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("70FD33E7-E3CC-4900-93BB-5E0097D32F3F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"각종\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B0147516-D817-4E3B-86FA-A6FA3DB4900D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"các loại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("38D00416-E0EA-4A28-8931-F6271ABFDD45"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"각종\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C4DE61DB-A1E3-4A2B-8BA4-B20688213EB4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"각종\" (các loại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("343B6B24-4B2A-45FC-9A04-5924BA8752F3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C13B35EB-A445-4A5A-84A4-3E83594168E5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"mắm muối\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BB485B21-73AF-4500-997F-B6413F1A8A32"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1D374DC4-841B-402F-9F0B-77756CF4C85C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간\" (mắm muối) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("97E26614-A353-4AEB-B720-92672EB6D9E6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간격\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A549A230-0F10-48DE-9E39-2AAAE3DC34E9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giãn cách\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BA6CE5B5-541E-42C9-8A5B-63A518458871"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간격\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4DC78341-D6F6-408B-A0D5-774339C4EEF5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간격\" (giãn cách) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("955FCBE3-E4CC-4AD2-8F15-894C13138AF3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간섭\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9C630B5D-90C7-4B6B-8701-549F75446DB8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự can thiệp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F6D8D3FD-9A64-404D-BBC5-BF63816C4E28"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간섭\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("52AB1D1B-855A-4EC0-A944-A6186EF9FFBF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간섭\" (sự can thiệp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C8175AE8-32FC-4FEF-9E37-F6FC742E8724"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간신히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BC05BF1D-0D5A-42EF-8598-773A51D8AD39"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách chật vật\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("65D29955-01E9-45D9-AF90-0A0C7D62F750"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간신히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F25C0C14-654F-4611-9FCE-B7C53943125C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간신히\" (một cách chật vật) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("45DAD516-6703-4763-9417-01B682548891"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간절하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1C1BD84A-279B-4D02-8541-3C96B9DF9906"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khẩn thiết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("687AEC41-BDA7-4B8B-872B-CFD011CBBDED"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간절하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2D140A30-1CA9-4AB2-89D3-81F8B62FB3D6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간절하다\" (khẩn thiết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EA8CC654-A6E2-4CC0-B80F-CA55E2529EE4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간접적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("335EDDCF-28BC-4147-BC5E-66A72BAF30C8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính gián tiếp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("03601D37-F4BA-4AA6-BE38-3DD2536BE20D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간접적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("759E2698-C362-41D8-8AA8-39E13A2A5956"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간지럽다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("84E2E870-9B33-486D-9F7E-BFDA7387AF8E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhột\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6D813E16-D4F2-44B7-9A6F-297F92309553"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간지럽다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7B4CA503-4C12-4A7F-9436-6561A6D1D74C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간지럽다\" (nhột) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("86330D8D-85C8-4546-A5EA-5B7ED0703C5B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간판\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C6EEC9E5-CE52-4D41-BC2F-A2C6D5F32E64"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bảng hiệu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("838A5439-4F46-4BD9-A3B5-768C5954877A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간판\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C9D9D159-37E8-415E-90EB-87D683F5B776"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간판\" (bảng hiệu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7520DA85-6BBA-4F60-97BA-84445C1E06B4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간편하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A646B628-3D1F-43CF-9EB1-71B04417C873"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giản tiện\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2F12671-DEC0-45DE-8EFE-CC5C01D6FCBA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간편하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EF70C08D-6ED5-4455-900D-6A7287C16DED"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간편하다\" (giản tiện) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ADEF7B56-BB3D-42E3-A880-1B3E945B74EC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간호\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B633D135-7AD2-40CE-83B3-2B2C119A0AE6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự điều dưỡng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10401D0D-E8F5-4E8D-A408-D474DC45988F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간호\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6840135C-31BB-4E86-9B6E-D34BA5D40607"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간호\" (sự điều dưỡng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4FE394AB-5F50-4432-B969-5DC2F567D682"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간혹\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B7C87F09-BB8A-4261-B52C-045B0A046BD1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thi thoảng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DCB33287-235F-4EDB-A93E-B264622C842A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"간혹\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CE6591B8-15B5-450A-B37B-9D571AF902C8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"간혹\" (thi thoảng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("06D68CB0-6A61-462C-B24A-F58B9176EC22"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갇히다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC9716C4-0112-41DF-A93F-B54540A7C79C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bị nhốt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("06D44D38-46C1-49A3-B616-C0F0619D1DF9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"갇히다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8304FD3F-C670-4959-A1AE-F26BE9E7CA43"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갇히다\" (bị nhốt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DBF2A3CC-C543-4371-9461-0F3DF6FEC123"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("865B5FE6-76BE-4743-B5C9-AD78EF2DBCED"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thay\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B27FD96E-D2CA-441E-BFA2-466FF732C96F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"갈다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E72C03A4-79C9-49C3-A0D3-B1DC6FBA30F5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈다\" (thay) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0CEEF1DE-3013-4346-B5CB-595CBC0E53F3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈등\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5CDCB216-352E-46C0-A70C-78961A513A8C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự bất đồng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2008A829-6AF9-4324-896D-0E7EC14C1CCC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"갈등\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("33740847-8EF7-4F94-8481-1C9F1BEA0054"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈등\" (sự bất đồng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6CF8E9DA-B2C6-4B6E-90A0-47C5F99EF0B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈라지다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FC0ED505-0674-4F2F-9529-28F7622B248C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bị nứt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("57066F50-714B-44D1-A934-197CA317C3A4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"갈라지다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("52FDFE16-D502-49E8-8D35-C7E0D6477C3D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈라지다\" (bị nứt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("568D1A93-D33E-40F5-BE7D-030D6BB88F99"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈수록\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3549D023-B73B-43D3-BB78-84D0A36F13B3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngày càng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3B007EAA-4BB7-45EC-997E-8575BACF0730"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"갈수록\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("118BED1E-52B9-4FB1-B3EC-38B888087200"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈수록\" (ngày càng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FB38BA45-2A43-4626-ADD4-64F05D0349BE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈증\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0E45A7E-C3CA-4ADD-A69D-A38EAB640D26"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chứng khát\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("82C78951-5F24-4C79-AEF1-BB68357BC321"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"갈증\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D0AFDD1B-8F91-4DDC-AA8D-E11E6B330BF1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갈증\" (chứng khát) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("64392693-9C2C-47BE-9778-B51B43E53679"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감각\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5DFD9ACF-58C5-454B-8138-F8B7665D06CC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cảm giác\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FD5E5C3E-0EA5-40C5-9FD2-417B4D22F9FC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감각\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0C416A69-B612-4728-A25E-BD3FFD729C8E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감각\" (cảm giác) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DF08084D-91B3-4EC0-8A76-0CA50960E1E0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감독\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BC332932-BFFE-41E0-87B5-0767DD799260"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự giám sát\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A9387093-4F48-4D4D-AE15-947F2FE4E7A1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감독\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("51E19805-1D7A-4AE3-8C87-DAF55C0DF9AA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감독\" (sự giám sát) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1328E632-56CC-4043-A8E4-B5972C8C2112"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감동\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F1AA0F57-73E9-4FBE-BF69-6C944A356029"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cảm động\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2B85170-036E-44A7-8FA2-652591FC3C56"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감동\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FC9EF115-F5EC-4310-B961-C3B536448BCD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감동\" (sự cảm động) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3850207A-DE98-4615-A89B-D6C71C1A9742"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감동적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1BA59336-2D0F-4E56-9ADC-0712602DB517"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính cảm động\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E383BB16-E546-4477-93E2-D42D85606D72"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감동적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1B504E4D-1E07-4C84-8E27-16B7784942D3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감상\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DA234760-D501-4FE3-AC8D-214B5104C9E9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cảm thương\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F5750D83-9A40-47CB-A633-A77047FDE3B8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감상\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D826DE99-5EB4-4C99-817F-EEFF7C17F0CF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감상\" (sự cảm thương) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2D7336B0-D4B0-402F-A82D-890FA5E590A8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감상문\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("16925245-60A9-405A-A3C9-9ED66E69DC00"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bài cảm tưởng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8C7C0033-C340-4B14-9216-600642D639DC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감상문\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EE9940C8-8B6C-4002-8BE2-02C0508140F7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감상문\" (bài cảm tưởng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CE0C7A5B-C006-4C58-95DB-FADA8DEC078F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감상하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BCC728DB-5636-4E1D-B4FE-76CCBBDF9FF6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cảm thụ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("492AEF3A-0D8B-44FF-ACAE-8647D428C381"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감상하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3AE2A830-825F-4622-AC5E-88057668CEFE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감상하다\" (cảm thụ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C9BF001D-D760-43C0-A75E-1DD2828A29D9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감소\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1591D3E8-5396-4B36-B4C1-C19BD566251D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự giảm bớt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("64B3D2B1-D3C9-4A10-A071-2AD3E86364D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감소\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("34E439D2-4E53-426A-B0E6-F666A3149749"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감소\" (sự giảm bớt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ABC0EF9A-4C42-4FBA-8A48-A3AF8CAA750B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감시\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2A1549C-E281-4B1E-8602-09016E48E2E1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự giám sát\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4CA2B8E1-211C-400C-8027-B3768FC59058"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감시\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("11731CB6-B52E-4609-8BFF-0F0E6077019C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감시\" (sự giám sát) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3CDB48BF-DC75-428F-8186-0E09256B6218"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감싸다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F203A34A-8ED7-4A17-AEAC-998C5CF1E02C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quấn quanh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B47707A7-0BEE-4E4C-9EFB-B53D13A9E13A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감싸다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("921C3658-9022-4381-BF34-D33757291059"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감싸다\" (quấn quanh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1F2C541F-4037-400C-B13F-A1D8FBDCA4A5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감옥\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F5617E81-3CBC-47B1-B4B8-A3EDBA3D568B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhà tù\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("093C4E6C-7E98-4AF6-A6CB-AF3FF90E8999"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감옥\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3B30AFCA-CC80-43B0-BB88-B3081C997FA8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감옥\" (nhà tù) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0099E284-44FD-495E-9F38-5ACFF182D7AF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감정\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8B4704EF-C13A-4290-815D-02B4D52C9FE8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tình cảm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E020194-D283-497B-BEB4-AA54E1F6DA91"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감정\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A0FB42C4-D3A4-462C-8468-81411CC074EB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감정\" (tình cảm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("62B1986E-20F6-4048-B4E3-F9BC31D98399"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감추다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AFC80DA2-19E1-4785-BE00-A51898628D64"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giấu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0A5D837-EC73-4111-A155-0099BD667E9F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감추다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("77667B2E-AA3C-4C65-AF56-02725F2C63CB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감추다\" (giấu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BBA6E04D-F71B-4DD6-BFCE-F34DEB8F4F2E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0FCED9EE-12EE-4F27-8411-7B0A41773F89"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"dám\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("59250E2F-64BF-481C-9770-F5D2D356B692"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"감히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B9AB1E8D-6304-4103-9F77-960B4A39A29F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"감히\" (dám) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0956EDF4-8082-4050-BE21-40B4EE3CBB5F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갑작스럽다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B0458A0B-C0BA-43F0-82B1-DAEAF43132CB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bất ngờ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF5CFCB4-67B2-4F79-B845-A3567BC3AFA9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"갑작스럽다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("55E27399-E39B-41F6-B267-8D2741B3C098"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갑작스럽다\" (bất ngờ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CD645C34-D47D-4309-A696-EE5E650EEFF1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"값싸다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("72288EF7-FAD4-4E61-8FA6-5C0E6E156C8C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giá rẻ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0A3790A4-91FE-472B-9C7F-0685F6CE7259"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"값싸다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("33E960EE-F0ED-4651-B5AA-24F0DBE78013"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"값싸다\" (giá rẻ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("147FEEB4-36C7-4623-A72E-05EAEAC97EC8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강당\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6301ED9D-AFFE-43E9-ACF3-0F7C1C63E266"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giảng đường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C5BE7D1-E8D8-4AC5-912C-8A2CFFC94EB6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강당\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AEB4AD1B-507D-4286-B960-5BA2A5DDCCE0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강당\" (giảng đường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E31D685D-75FB-4519-85E6-313F6CFBA90A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강도\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BEE0E8E4-E0FF-47ED-B345-A3D4884AA866"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"độ bền\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("98CDF33D-7974-4277-8B03-4AC0E22B7C80"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강도\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3B8D47EC-2DA5-4F31-8109-CB89D71E3E7C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강도\" (độ bền) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D933FFF0-D97B-4D10-AB4A-23A3432F5572"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강물\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("017E86FC-4CA0-43EB-888B-79D08AE8FEF8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nước sông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ACA457CF-931E-49B7-8637-D17DC95293E3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강물\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8DFFC34D-244F-42E8-86D9-6DFCDC61E0FC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강물\" (nước sông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7D5036C1-EC8F-44C1-AADA-3199D1DB5439"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BFA2E897-B438-4FCD-8248-11D1C528FC56"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giảng viên\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("84F681AE-F2AC-4097-AEC8-77326E8356EF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E0763A5B-08B2-43D6-8B2E-5A7B2BC064AF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강사\" (giảng viên) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3325AC77-7BD6-4580-AF2C-5FE039672269"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강수량\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C72C1729-1D0A-4D6F-BF43-E7A1209A1660"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lượng mưa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("67451FC8-634D-4450-9BBC-D7C13FFF0346"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강수량\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("37B91960-DE13-45DA-BA94-6EA7F74E310D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강수량\" (lượng mưa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1BED8846-5D38-4C1E-818D-700B795A0270"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강요\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E8A834F5-0AE8-44CE-B827-BF4D46EAC70C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cưỡng ép\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A24D399E-9228-4E66-96FE-C37EC8757D0C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강요\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8A1D6800-B232-4B3A-9AB3-70F76B81B4D1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강요\" (sự cưỡng ép) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("75A4A57F-F7CA-47D3-8E8B-8D551B525257"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강원도\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C1673F2F-B7B6-4A92-9170-18A3B72C8D70"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"Gangwon-do\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("24D03BBD-F9CE-48E7-B66F-72B082553204"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강원도\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A358AB60-AA9D-4E14-98E8-D788D90661C0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강의\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2013EE5-F220-4E97-8F06-FD92992C4932"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc giảng dạy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A53E735E-C69E-4BB5-B385-EDE4862B7F4B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강의\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3746905B-9D3D-4E16-9D8F-189CE6338B89"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강의\" (việc giảng dạy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A55EBCC9-5C2C-4771-A40D-B8E879D46625"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강의실\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FAA4ABF2-21BA-423C-BDF9-897DCD9D32CB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giảng đường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B8648592-C169-4BC3-8DB8-92AD8D9FBB09"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강의실\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("959D5DB9-ECD8-4177-86BF-1521FA137960"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강의실\" (giảng đường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("35FDFA12-3D42-4159-8FF5-A4FAD2E6D84D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강제\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EBD5AC0C-818F-4DFE-BEBA-421A6DA031E2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cưỡng chế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8C6D150E-0FF7-4074-B64B-1AF8EDEE0C26"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강제\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4EFD0706-98A3-4CEF-BF57-6725C325C356"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강제\" (sự cưỡng chế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2A15EDF-6DDE-4EE3-B9A0-622CB557F2FE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강조\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("83D1A485-BEF4-4C7A-B812-8CDE5AD06CA9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khẳng định\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7231D661-EA08-4D3B-905D-76C7736C91E5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강조\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CEE86636-B36D-4260-A019-54495C130D3F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강조\" (sự khẳng định) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A8183C86-A30D-4802-9071-6DD36C07BE0E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강조하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F439754C-8EAD-4E53-9143-A850FC04301E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khẳng định\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DF8896FD-3BB1-4B4B-9922-B25B51EEC2C9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"강조하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("16533767-F69A-41F8-A02C-D41E8781B354"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"강조하다\" (khẳng định) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("466768DC-1332-4AC0-AF55-96AFFF9C4E1B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갖가지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CAAE93D7-DCCC-4C45-89BE-E6ABF488FB3A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"các loại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("22E87369-534F-4037-B20F-6E7930FFC4A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"갖가지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B9E8D680-0893-49E1-9B8A-8093E81BF5FD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갖가지\" (các loại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7832C96D-5B9F-47DC-A6CB-71F5A017D6B4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갖추다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0DE9C22B-0678-4AB1-9DE9-5CCE747B419A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trang bị\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C1F324EC-ABE8-4911-91D1-4BD81A22C0C4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"갖추다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("441CDA15-FB28-4294-B0E0-5600F8A9CA60"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"갖추다\" (trang bị) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BB6D70FA-38E5-4C61-AF1D-515FF200C964"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개구리\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("775FA87A-A7D2-4F3B-AA36-775064C518C1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"con ếch\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("17178026-7DC1-4E83-9466-510CACC62FF0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개구리\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AD4B79C8-0604-4860-9AF5-FC3E633D26D9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개구리\" (con ếch) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E60BF43-5F8D-486F-B473-CD5C7519023C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개나리\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E860549-8B01-4E12-A815-6428F6C62CEB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cây hoa ge-na-ri\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7DBDAB60-5563-4C8E-8A5D-FDAC0FEA745B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개나리\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("42B5A1D4-FD68-48A7-90B8-9F15D865EFDE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개나리\" (cây hoa ge-na-ri) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("972AE356-6750-48BF-B014-B3FB8AE56C2A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개념\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D7033D3D-84A1-4FF6-B9B1-74F8FDDE7843"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khái niệm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AB19C2DC-CE8F-41EB-BE9B-833D436CE10B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개념\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C285AB95-C80C-43D4-8B5A-3444C2B57B96"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개념\" (khái niệm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F506647C-695B-4DE8-A01D-38796F3346EC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A46DE571-CB5C-4ADE-91BC-9D3F1E478FDA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trời quang\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("97DC5E01-D4D4-4719-9CC6-A58476C8CCF7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("30567F4F-68FD-42FA-A0D8-5C8CB8984C5B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개다\" (trời quang) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("114BB9D4-960C-4710-811A-95218BFABB22"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개미\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5047D471-ECD2-476B-AE27-BDA19155AEA5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"con kiến\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A392F14A-1780-470C-B4E6-9D9B4E210899"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개미\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D60F6795-7FEE-4AF7-BA80-07CE1A82C3D7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개미\" (con kiến) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B11EA0C7-3071-4128-8051-BFF41DEB18F8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개발\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CA6314A5-0C3F-45E7-8E21-B416D5031931"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khai khẩn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("01056FA7-03DA-4B10-99CC-6600D63ADFBC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개발\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7EB0F866-6B03-477D-A84D-11A019C6B630"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개발\" (sự khai khẩn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("40A79814-D4C9-4EB3-8712-ED1F40DCB794"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개발하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C7886307-B6C4-43DC-B032-4149E4E86EB9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khai khẩn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D075201-3650-4922-93E5-6064988D78AD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개발하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5797E64B-B02C-4B3E-896D-100D35697E2F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개발하다\" (khai khẩn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("352A74F5-694F-49F9-ABAF-D6265133E146"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개방\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4074CC67-648A-4845-9B69-822C4F0D9D3D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự mở ra\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5B9C4ED5-FE58-45C7-807A-3BFA762B4FE8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개방\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8701A017-91FE-40BB-88CB-127ACA31F0B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개방\" (sự mở ra) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("87FE0319-E9BC-425E-861B-1C83C832CE9F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개별\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2C6F7C80-A487-4B82-807D-6C99882A5567"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"riêng biệt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B9B5687C-7EA3-4ED5-8BDF-5F3111E988D2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개별\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F4D6C1C4-A89B-4B74-AF6D-90B151068741"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개별\" (riêng biệt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2C6BAF61-FACB-421F-B691-001946DA5746"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개선\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4A7963BF-BBD7-47F6-910A-38563A72080A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cải tiến\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D23515A4-C757-4F58-89CA-201386A785F7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개선\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D779D176-F782-4419-A0B6-109FFE301B63"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개선\" (sự cải tiến) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3DA35DDB-0573-4BE0-871D-87BC7F3E81B2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개성\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B7FB1ED2-B258-4373-8336-192B42969479"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cá tính\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F16535A2-10E0-4944-BEAB-75F126CFA6BF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개성\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("189F7E79-FB0E-4D4A-8CA3-AE59015AFF9F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개성\" (cá tính) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7D19FE39-D287-4F10-91BC-0B9C3D3ADDCF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개인\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0E034A4-67F4-4F98-B596-B14DEC6CDEF7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cá nhân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3D302235-53E9-47CE-A00D-DCC8E64903B2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개인\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F89D2811-D8EA-4268-B499-20F21DB0501E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개인\" (cá nhân) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AC983712-40EC-4DB9-B491-EAF4E2B0CF8C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개인적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4254D941-26F2-495A-B1BE-DF49B145D681"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự riêng tư\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BDC86C90-501B-48AD-8E3F-D922EC77E502"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개인적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4F9FAED9-5355-43FD-8BC2-0398C3D0DBC4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개최\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4931CA1C-765F-408F-AE5B-B6CF45F25E15"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc tổ chức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("00961567-45A0-4A8F-B7D0-F663592B71E0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개최\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BA717A91-6767-4CCB-ACE4-D1104889E426"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개최\" (việc tổ chức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("41817E1E-5F42-4BAC-9D66-469F92A8C871"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개혁\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5A87EBA2-9534-4441-99D9-6A8308D5BDF2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cải cách\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("570E7CB0-564C-4A66-9E37-30D0806292B2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"개혁\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("49700C8E-3E15-4AAE-8991-24A81B47F0A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"개혁\" (cải cách) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1A9D4B4F-C9E9-476A-857B-267F78C0B75C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"객관적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF5B690E-FE2B-4F82-B75D-EAC15189F3DB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính khách quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("96DC5849-A6EB-497F-83F1-8EE1B36BCF40"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"객관적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("58267972-6E2D-4B8C-80A1-E2A92F8393C5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"걔\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("50FA3077-C470-4318-8A22-A7BB50B70A8D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đứa đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("89B848FC-54DA-4C29-8B0D-C546184FF1DC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"걔\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("402D03DE-82D3-4038-A6F0-3BF7E70CD9F4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거꾸로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("45554258-FC6A-4CF2-A632-990B8D9FAB96"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngược lại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7AC130BC-3DC5-4E19-A9C3-E0A8F229835C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거꾸로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("43E7F55B-8AB3-4F8A-BA7A-9CD955535E5B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거꾸로\" (ngược lại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("90EDB37C-01B6-42F9-8B4A-4D8DD85DDF2C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("289A6114-BB1D-403C-962A-A0340051EB8A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự to lớn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AAD23842-8814-4829-982A-951BED1D5F2D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9DC1462F-2AEB-427F-9542-C5CE9F005656"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거대\" (sự to lớn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A04191AB-1F2C-4654-83CB-F9A0A94A8049"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거두다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2EE11324-5A63-42CB-8CD9-EFC3C5896213"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thu dọn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9A9B7449-4DE2-4953-A56D-2B98F8286452"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거두다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E1DEA237-8CBA-4426-BACB-7F9F2EF7E010"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거두다\" (thu dọn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C23784CF-9329-4CE7-A216-3DA0834F7D0B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거들다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AB0634DC-C6B1-4617-8572-9B8F34640EE0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đỡ đần\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8026C742-3DBF-4D62-8F86-D054097856A4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거들다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A1701CCF-D0C9-4BCD-9C13-E217175DCD67"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거들다\" (đỡ đần) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6EA5B6B3-30DF-40B7-BE0F-231EA5DE1C95"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거래\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AEBA14D8-16AC-4DF5-B2AF-4F6A437408A6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự giao dịch\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6EC0AC04-C170-4BB1-8E38-BCB7BC58881A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거래\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9899C7C2-C556-4398-AFD5-E0A39D6D5908"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거래\" (sự giao dịch) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4CF881B8-497A-4490-A480-AE57A15AC70C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거래처\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5A3240DB-4096-4790-BAEC-69ABDE8D75B3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khách hàng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DF41C433-E8EC-45E9-801E-789F04FCB666"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거래처\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C4756375-EC54-4263-95FD-83A195DE7B55"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거래처\" (khách hàng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AC2A8A65-C68C-4EFF-9C80-27F3CE9F5C1B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거미\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9B2DEB60-9EF4-42F6-8D09-37591A762A62"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"con nhện\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF838DC1-A33C-4CF1-8E59-8874BD27B678"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거미\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2DF6084B-4EF9-4744-8DCC-A145A73E8B38"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거미\" (con nhện) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5A7845EC-530C-43DA-B158-7D849F49BEFB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거북이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("06DFC52A-ACD4-4B13-B2A8-3640F79B5D89"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"con rùa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FF1F971C-ADA9-4EDA-A944-75E8AD39E27A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거북이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0910B8D9-0A71-4522-A06A-3962A77038F6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거북이\" (con rùa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6C35AB10-F81C-489C-8A49-75E411EBB7D6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거스름돈\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("69F12AA0-9C3B-42FB-BDFD-C0132D40D240"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tiền thối lại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A4F48215-09A1-4F73-A0CC-7C1D54DE3589"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거스름돈\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("795409F9-A11A-4AC0-BC3D-977823B8D7C9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거스름돈\" (tiền thối lại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9C98516F-3620-4583-95A0-56CF3111AE86"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1D1AA01B-673F-4C20-96D2-BB45FAC87499"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"người ăn xin\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5782AC94-7AFF-4840-ACE1-2CB9F76992BC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EE20F3A3-85DE-41DE-9D72-50FC8ED83834"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거지\" (người ăn xin) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9ED46B84-5EC4-4494-9873-099D05E271B0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거짓\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CFF95BE8-A82F-4CE3-BD0B-9E6C5749F09E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự dối trá\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3D3FEDD-8F74-455E-B694-8CF8D237115C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거짓\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C160D411-E220-4138-8412-B24F393460EA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거짓\" (sự dối trá) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5BC894CC-F464-43AC-AB8B-A75E1C336406"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거치다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E009196D-3F17-4814-B9B6-D111DDCD8DD0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vướng vào\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08C8DD6A-ED4D-4FD9-8E3C-9C73AA1965E9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거치다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DA02E3E4-FB8A-46B8-9C32-D5EC60A28F26"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거치다\" (vướng vào) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("25F85A36-5E6E-41E2-A5B0-A60CEA6E540D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거칠다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("92B9FE20-A630-4511-A980-4866C5422B42"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sần sùi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7F9E5669-A187-42B1-9B46-296E58AC437D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거칠다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("38D0892D-B783-4C99-B631-5C6CC3F54F1F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거칠다\" (sần sùi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1D04D22C-6165-48B3-BB8C-01DC8D477372"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거품\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5BC39718-9C3E-4BC7-AAC2-857EF996B456"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bọt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D25BB6A3-68B8-44BF-BD2C-AF84740D43BD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"거품\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2A5832A0-D74B-4B52-B6F0-066284E3B9C9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"거품\" (bọt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("86B20EB5-DA46-44D6-94A0-AFC1AA378978"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"걱정되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5792C2B1-8385-4A7A-A342-46AED9A47CE3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trở nên lo lắng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5EE8975F-BC27-4FE4-B700-408EDC49F0B0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"걱정되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A5FC1A27-9A8E-4395-BD09-4D773258AA46"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"걱정되다\" (trở nên lo lắng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("42DB76EF-F858-4BED-9365-08E41574C912"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"걱정스럽다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("62E305EB-D9B6-411B-AF01-DFA3D1AA9A01"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lo lắng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F34C133-F5C7-4E61-BFBC-F8A97BD8CBDC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"걱정스럽다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("99094D40-1E2F-4ACA-8C87-795F64E03F68"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"걱정스럽다\" (lo lắng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0244D2B0-4563-4AD3-9263-3C5187E96858"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건너\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A76672CA-E498-499E-83F9-C511D069CE34"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"phía đối diện\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("309923DB-F79F-4561-AC95-68C36154BE12"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건너\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6A948C7F-FEEA-4D99-BBF2-A28AB5E66EB2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건너\" (phía đối diện) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5524D664-F77B-4CD4-93A7-63A57065B0C6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건너오다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ABC9BE80-9A66-4E94-980E-35A53F2B7052"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"qua\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D5C5C2F7-4351-4FA3-A9F8-00F6E0B78F36"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건너오다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F5582499-C5DC-48EA-9591-9075AEF8D18E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건너오다\" (qua) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("23C871C7-62BB-46BA-87C7-BCB32F9CE62B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건널목\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8775E3B6-9A02-4C59-A88F-B5F9EEE4A558"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lối qua đường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4268A60A-0775-477E-A61E-4148B66A260D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건널목\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("817B0358-4000-4B90-8F4D-471C076C1500"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건널목\" (lối qua đường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("87B32CA7-9E45-4756-9C96-A996910FF1AA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건네다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C87BD0B4-CF24-43E0-A0DF-456BC1D2D7F8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trao\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7E61F370-612B-4210-A5E2-41C3EF176E2C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건네다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3B6750A5-F8D2-4AE5-ABBD-13D4E5EB9661"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건네다\" (trao) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("309F4DE6-CFE2-42D3-9B0C-CB9114C461BA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건네주다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8CA2A8FF-8158-4994-B869-F8A1F2C7F636"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trao cho\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("459B9B82-FED2-4089-9FBC-23CF20A09A80"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건네주다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EFE5B424-C23E-4130-8E74-E42EA79CF2C4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건네주다\" (trao cho) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED301E74-4F42-4136-9B82-9C8669B1E50B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건드리다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("27F7AE82-93B1-4205-AFCD-55267FA3129A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chạm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4825429C-B04B-4236-A5E8-863637E42037"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건드리다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6F7A0589-A30C-4F33-B011-CDF529D13A54"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건드리다\" (chạm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C0F0C97-1E9E-4861-BB60-5EF1C990D112"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건설\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF90CBAA-694B-4DD7-B713-D096D1BEFF96"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự xây dựng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9BF014CD-73E8-4B39-865B-D9F4650FB38B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건설\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CA64213E-A579-4054-9506-7C492A9FB163"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건설\" (sự xây dựng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B55ABA86-53C6-45D3-9D11-66B9D772AC8C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건전지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E69219BD-8C6B-4842-A3DA-8B255A4EBFA4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"pin\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("244391F3-62A5-4AA6-A25B-5FC634CCE29F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건전지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8541F573-90B8-4728-9785-4270D4F3E9F7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건전지\" (pin) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9B53CCFF-834F-4A6E-AA0B-FC536AC1375A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건조\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1E9DD880-A61E-4BAB-8EE3-8978909FF543"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự kiến thiết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("62A8535D-A1D7-4CCC-815C-A6A5EE5D2DE4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건조\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("870A21F9-DD38-43DF-9AC8-A719C9230479"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건조\" (sự kiến thiết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5FEA4C84-CA23-45F9-8083-6815883D314E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건지다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9EF1608B-BEB9-4795-8261-7CC903576545"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vớt ra\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5F368C95-6A7F-4784-A61B-635167CF09AE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건지다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A6D94462-36A5-4DF8-AAFB-0B77C23812A3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건지다\" (vớt ra) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2AD20F13-940C-490D-BAD6-2C9577994939"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건축\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1F583F07-2A1B-4F0C-BF4C-6F1374ADB6A0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc kiến trúc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED780942-5EF1-45B8-A862-B544E4F27917"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"건축\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DA77B354-9AC3-45F7-B4EC-FB54333E95A4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"건축\" (việc kiến trúc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DF44507C-4C55-492B-A77D-5D2642986120"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"걸레\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("711C32B0-A728-499E-91C2-F7F328F55376"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giẻ lau\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("07B9EF5B-5550-40CB-8D5D-01F6AC0FAE40"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"걸레\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("39987831-A79E-498D-9786-0D910F907DB9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"걸레\" (giẻ lau) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("31C7294F-0516-47F7-93D8-DAB253B9F5B0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"걸치다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7E55A0F1-7308-43C5-BF8D-499B3A4D068C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lơ lửng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("68859590-8627-4E9B-BA9D-733D4116F1D5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"걸치다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("82D62124-88FE-44B7-BAA3-04B0F552E6DC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"걸치다\" (lơ lửng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("088366A9-1148-47D0-9DD8-3EBBDADD1D65"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"검다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("40E396C4-4C83-4948-844A-F1B4EA0681DF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đen\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D07E1E8-E6FE-4ED5-8F0F-58141DABC966"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"검다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A40EBE17-DE9E-46D6-B0BE-2642DE585661"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"검다\" (đen) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F02F94BE-7B1B-4A9D-A2EF-C2010C325E9C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"검색\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("39AFADC8-0176-4190-B648-44032A5BEC02"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự tra xét\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("36049411-78B9-470B-B2EF-9CD0B72C268E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"검색\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0586A489-E365-4FF9-9F0D-A9DDFBF0214C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"검색\" (sự tra xét) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("65B35D42-3CEE-415F-AEA4-9175EAEA1EA0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"검정색\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("23748078-E12D-432A-BACB-010933199B56"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"màu đen\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("15F3E82B-E8FD-4AE4-B30B-E97AADBEA9DF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"검정색\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DB7A4E70-4BC7-49FB-90B2-F9A1184B8321"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"검정색\" (màu đen) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B212D1CE-BF32-462C-94DF-03CB11DC73EC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"검토\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("57C08C44-B726-4181-8FD3-BCA40C3CA7A0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"xem xét\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("48347FB0-CA50-47DE-B2AF-00A28CD48F52"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"검토\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("82982FA1-48AC-470C-9CD8-0F5C41B21A6D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"검토\" (xem xét) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7A73DE8E-8EBA-48F9-96A8-EE68E39B03EB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겁\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("05739C2C-7C48-4DB1-AE49-AACBC380A087"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nỗi sợ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("31713AE9-3751-489D-B00C-A71E22EF7D05"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"겁\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("814B9D11-054B-48C9-95A3-F0DBB07A90E2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겁\" (nỗi sợ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9A560A5C-977B-4864-95EC-2C3B4C9E374D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겁나다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3D37C0B2-BE5C-4FB4-A65D-0EC2EED382A8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sợ hãi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7573B03A-1F47-47BD-91D8-35D70CB3324C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"겁나다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("64FC4A53-074F-4FDE-AC47-597162D9C2AE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겁나다\" (sợ hãi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F3B76415-CC37-4B75-9D77-708EC9FFB8EC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겉모습\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("482204E0-DC22-4301-ABAC-65B2C057FD82"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vẻ ngoài\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DA13770F-E27D-4964-9E93-660CC68B63C2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"겉모습\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0E877FE1-54FE-4B62-A812-3A80D8F8C80D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겉모습\" (vẻ ngoài) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("912514F6-D0B4-4697-9D98-8AE1D5AD209B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겉옷\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0AF4B34C-DBC7-4CAB-804F-3F8A20A467DF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"áo ngoài\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("567B4559-D17B-4769-A9D7-0C4343F2FAB5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"겉옷\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("14C84C39-07CC-47E8-B414-D7EE7A9B8942"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겉옷\" (áo ngoài) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C81ED3E-B859-4D2C-A239-74E406F60FF4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"게\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FB119717-12A0-4012-996B-35C778444297"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"con cua\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("40C3A1BC-7223-4FA1-BFC1-A6296128F9F2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"게\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9B0983DE-C595-4846-B382-BA350202C0E9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"게\" (con cua) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("51F5CB1D-88DC-4DCC-809C-33F2EF007ADD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"게다가\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5958B6E2-8E0E-49F5-AFA1-53B00360D9EC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"hơn nữa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("12478AE8-AC18-4100-A5C9-E40AD1545503"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"게다가\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D3211049-53CC-43FF-90E0-3B507C66ACB1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"게다가\" (hơn nữa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("64FD8454-DEFF-421B-AF67-60526CCD6FA2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"게시\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A8A7066D-A54E-4B10-BD20-6A9440BCB5A8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự đưa lên\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("068BBE71-C551-4425-ACE9-099CD87ACB1D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"게시\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F964FB84-10D6-4AE4-8664-EB0C85950FB8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"게시\" (sự đưa lên) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB08600E-6342-4F8E-BFB5-322861F645A8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"게시판\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7063F174-A20B-4AFB-A5F3-30EBDB00DF48"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bảng thông báo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6A74BD2F-F8D1-4DA2-BFC1-4253ED57BD86"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"게시판\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2DDBED32-3B95-410C-A0D5-5ACD0F20F82B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"게시판\" (bảng thông báo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0D645E19-3015-4337-AA71-7E5C9C2BA7B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겨우\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DC1BEABF-A148-4C21-A745-27FAA52549FB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách khó khăn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6288CA82-17F5-471E-8D13-B0C8EA7FF40D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"겨우\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DB37591E-70EF-47A3-B8F1-D6B38C5B236A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겨우\" (một cách khó khăn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("37F28B47-F059-407B-9293-89B0CC48CE16"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겨울철\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DFDDC48E-41A8-44BD-B365-303BA49549E8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"mùa đông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4AA5CFD6-ED45-499D-9AE0-6217253AE083"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"겨울철\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BF6E2508-1ADE-4125-A04F-502DA3ACCE19"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겨울철\" (mùa đông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("62CE39C6-7A17-4FEE-A174-539C49C18C3E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"격려\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F10A4037-68D2-46B7-A953-2D0875F97638"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khích lệ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7200889C-ED5C-4593-A967-AF56E7F58E08"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"격려\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("56DD22A4-4053-4B96-B05B-1E911CBD9F07"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"격려\" (sự khích lệ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB38E85A-13BB-4DD5-900C-D0F388D30C9A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겪다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AA036BD3-2EB4-4ED4-BA84-84D0A1B2358A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trải qua\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B940DC5C-191B-4CD0-9E1C-D06B8A79DF08"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"겪다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("693914D5-D9BE-4D65-ACE9-18349CA1E9BF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겪다\" (trải qua) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DC60B6E1-2331-47DA-8E75-F7E52FCCB821"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"견디다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E378B195-7D73-46C9-873E-38380891D8C6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chịu đựng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("46C0EB22-8F1C-408C-949B-310F520F07B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"견디다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A32F0BE4-7049-4F14-9ABE-2130993FB052"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"견디다\" (chịu đựng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0E1CE411-B5A1-4A00-B95C-4842957C1ACE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"견학\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("30FEC925-58F3-45E9-BBD3-71CE5DBBF4F4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự kiến tập\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("136B11B9-E3B7-42FC-9999-7D306D81C932"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"견학\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("79B7E6F7-0EDF-436C-A182-5D076F797FF2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"견학\" (sự kiến tập) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("69D932CD-5658-4624-A825-9E8CD50B2E9A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"견해\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2ABB60A-ACAD-4F53-9595-1A3BEE657B34"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quan điểm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6512636B-9DC1-4DA5-9745-BCB733C9C64B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"견해\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5A8C2199-B245-43D3-9A8F-1EC7790C916F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"견해\" (quan điểm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0E49E3A1-0F84-427B-AA0D-D491B89C488E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결국\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3B9E497D-E9A7-490F-A1E7-758AE2A866ED"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đoạn kết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0AEC1DEB-286C-4347-A46B-3B393B53E454"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결국\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C22F5706-B491-4FD5-B204-4C783808A037"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결국\" (đoạn kết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("53BECC8F-9935-44DB-8589-94C35541A502"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결근\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B26B254B-11EB-4D24-89B1-9213A0174102"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự nghỉ làm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("997E23B5-2309-4D2F-BE4E-71C6FA4DF2F1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결근\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("47E16260-3457-4ED5-9E32-634AE4323F61"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결근\" (sự nghỉ làm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E3D36B96-508D-4A96-8819-AA36C795696F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결론\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("120D463A-2F81-435B-8865-6C23358E10F4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kết luận\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FC7B27B8-FF72-4531-A0C3-7C99CB32D21B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결론\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0BB730EF-E74D-47F0-9B74-7D94446729AC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결론\" (kết luận) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2FAE1A19-BDA2-45AF-B19A-19FE0017DC3F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결승\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A47E548B-88D8-4E41-A126-DAF1A4DAF262"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự phân thắng bại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("85203F56-882A-48B7-A875-E5764B797C8D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결승\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("96546198-EBAC-4B61-84D8-ADB88B18A0CE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결승\" (sự phân thắng bại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08E209CF-29B8-44DD-A2C0-497F64B2033F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결심하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("063A0CC9-88D6-489F-AAC5-CF209C37A20E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quyết tâm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB190DAF-8524-4B70-8C56-A08FDEAF8302"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결심하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EF5FECE0-13BF-4A10-A4CF-96EAA4FD9B73"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결심하다\" (quyết tâm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F8E225C2-BD91-4F43-B3CB-9DFD12D4C01C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결정되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("79E03B14-75C9-40D9-AF23-E74660EA88E1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"được quyết định\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("62455546-0738-46C8-ABA2-654AB9F07096"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결정되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DA8115D7-B137-49CE-A160-843AA4B9550A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결정되다\" (được quyết định) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("99429DE7-F550-4E2E-8FC2-8526792F8BA9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결정하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C871429E-87CE-4E58-AA36-3C721914EB22"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quyết định\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("347EDA31-C864-48E8-AA66-B5BEC4E514F0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결정하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FF7DF825-A304-4DED-A2BC-5FC04B6B84E0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결정하다\" (quyết định) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9C735AD9-4E3A-4012-B58C-5A61C1A6AC71"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결제\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A9199C39-5C77-4826-A61D-FA739BE0A37D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự thanh toán\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7D09CBEC-14BA-44BF-8D7B-191232F85420"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결제\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B076D921-FABB-449F-B5F0-75CABE75E5B4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결제\" (sự thanh toán) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BB9B4A84-EEE5-44E8-9E84-7BB8F7D9E29C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결코\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0F79AC94-BD2F-437A-8D2F-54DF86582722"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tuyệt đối\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AD178866-9279-4D7C-A26E-DAEDB16D03C6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결코\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0E120A37-E44F-4CA5-8BE0-975243888C15"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결코\" (tuyệt đối) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DF576FF2-68EF-4185-B3CD-A42D88E37E64"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결합\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BC2BBB8B-2A9E-44E3-8F97-438BFD40E8B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự kết hợp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("11AD5076-F1E6-41DD-9A09-BDEED24249C8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결합\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("59BC1B20-1F27-417B-A34A-A99AF412856F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결합\" (sự kết hợp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("17D85F84-15D9-426E-B9B1-E1E44C953116"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결혼식장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C2F4AA97-DBC3-4524-B59B-83A469EF7D59"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhà hàng tiệc cưới\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D24C6C15-29DD-495A-910D-30C733400CF6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"결혼식장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("47951B61-8EBB-4B75-98A9-8888C05D064A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"결혼식장\" (nhà hàng tiệc cưới) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9FB3C312-4EF7-4D4B-BFB4-BDB1F4D35989"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겸손\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF6D79C9-354A-420C-8F75-C7CFB450D068"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khiêm tốn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BF284B1C-AC39-41AF-90D0-B3E2EC57734C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"겸손\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0D657F21-DDE1-4F61-9C7F-C0B6D9830377"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겸손\" (sự khiêm tốn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("035C802D-3C67-4D71-B2FF-98D907DD8201"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겹치다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33835A91-3FD2-4F08-B4D4-1C45BBA480C7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bị chồng lên\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E26AB593-169A-4E1B-9BA7-E6ED383CD530"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"겹치다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5BC7656F-DCD3-44A9-ABDC-41CCDC12C0C2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"겹치다\" (bị chồng lên) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A0132CB7-908A-4DE9-8843-C0879B5EC930"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경계\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E5D04EBA-21C3-4DA7-A044-165FCE3062C6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ranh giới\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FFD9BF13-F1E3-4A63-8A4C-0E0F6698957A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경계\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7F824C8F-125A-4A82-802A-BB99CBC10731"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경계\" (ranh giới) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2CB09640-3D31-43E7-AB80-25676D6CC5CC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경고\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5C102A9B-71E0-4E26-B65A-58E39C405EA4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cảnh báo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0473769E-7BA5-4A4A-8E83-A5642A8B29B8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경고\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3D4D5A7E-26DF-4384-BF27-6CB1DD352917"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경고\" (sự cảnh báo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4A4AB417-A3AE-4522-89D7-09B346508C96"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경기도\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1C869860-EE6E-4A2D-A855-C0A22448FCA3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"Gyeonggi-do; tỉnh Gyeonggi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D5B040E-1AF8-4C1F-B32F-0283CC77792D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경기도\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1165F5FC-DBB7-4288-949B-7F42B1F11618"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경기장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8ABC4B05-EC15-4FC2-B38D-280A8E9660F5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sân vận động\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("240B7E16-ED4C-4239-A3E7-90CBB902EA33"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경기장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("14591209-5406-42BB-A7A6-93B55112151D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경기장\" (sân vận động) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F96866F8-0512-4BEF-9BFB-DEC9E2B33B9B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경력\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CFEDDD4F-9589-4F0D-8FB3-E9B8B03ABA13"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kinh nghiệm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C65E5AEA-0334-462A-A784-D9DE4C5A10CB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경력\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("20FE9199-2C74-4BF7-9B67-80DB9D429170"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경력\" (kinh nghiệm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("51F992DE-7DD4-4F6B-B8DF-84945A295F7E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경비\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8A369E7A-F132-4618-AA07-8FB0271639AE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kinh phí\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0F7879BB-7387-418E-B34C-6FF4B0BF53DD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경비\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("83758843-21B7-41D3-A572-69A4BF195830"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경비\" (kinh phí) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B92F7170-7378-4078-89DD-4A02CAADF6CD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경비실\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D553B755-C168-4D88-83D6-009EA7455B4F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"phòng bảo vệ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E83FF9E5-1F55-442A-9837-4C20E510EA00"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경비실\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C2409357-6214-4974-930C-ED2DDCC2419F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경비실\" (phòng bảo vệ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A0C4B47E-ED5D-467F-8BED-4A3DEAF397D9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경상도\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4424220F-BF49-43A4-A3E5-40001E15BAE4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"Gyeongsang-do\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F36FBEF9-E005-4701-9F0C-EE5B3E82DFED"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경상도\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5D90A003-09E2-46B0-BE93-221D7EB69C23"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경영\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D7A0871B-CC38-40D8-B823-7A4A1AC1AFD9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc kinh doanh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DFC67DB8-9820-4426-96AD-40DA599863ED"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경영\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F39F4813-B4EF-4886-994A-765B29F06FEE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경영\" (việc kinh doanh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("830D471E-FB5C-499E-833A-7793EC53059E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경우\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FD1F453F-A6D0-47D9-85EA-501AAB415F19"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đạo lý\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C3775E95-7DB3-4EB3-AE0F-2989DE07FECC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경우\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("802B1769-3596-456D-93CD-2AE567EB7327"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경우\" (đạo lý) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("111F57FE-B46A-493C-9A0C-3FF60B0BC0B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경쟁\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("26B1B3FC-6E6B-4BD1-8DFB-76AA50729F8A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cạnh tranh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("70CB0C8F-2242-4483-8583-E6396059EFE5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경쟁\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AB586ECE-3323-40A1-8C83-709BE6CF12C9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경쟁\" (sự cạnh tranh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F3056F5C-D554-42A2-AF23-1A88427987C5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경쟁력\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6635F340-CF89-4B1B-B602-4D9451C0434D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sức cạnh tranh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33AA37D8-00D6-4DDA-A5A2-409EC700D157"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경쟁력\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B9302022-5076-4AD8-BA8F-498E3321DD71"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경쟁력\" (sức cạnh tranh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("510FC0E7-73E7-4072-A668-64D731268B67"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경제\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C91E42C-BEA6-464C-AA51-A9B7171ED9F1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kinh tế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F4C0288D-CF18-4AC8-827B-5C46852DBE47"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경제\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DEE19538-CA55-4584-A191-42373BF950DE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경제\" (kinh tế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AC3CB481-67A9-4655-9939-43296FC61AF7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경제력\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C06A2E82-53F3-4A65-A891-1778816FCE5C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"năng lực kinh tế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E0565082-9017-4851-A96D-9ACB3878AADB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경제력\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4BB2284B-6924-4423-8996-B574C4A5AA8F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경제력\" (năng lực kinh tế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CBAFC0AF-B3F4-43E3-A544-C1B9D599DBD8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경제적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0DF94D4A-0546-4760-9C2C-C5F346A08F58"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính kinh tế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("142BE0C9-8E39-4A0A-9AFE-FFEB44A5E873"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경제적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8BDE1CF2-C2D3-4890-ADE7-B7A1785F4304"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경찰관\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("25FC1D60-B1BC-4B41-AC2A-EB90BA610D41"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"viên cảnh sát\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E07B5FFA-63B9-4835-9F63-5368E6A953FA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경찰관\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7DE67E6C-4FD9-4383-BA7F-BE4653958D1D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경찰관\" (viên cảnh sát) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10080071-CDD7-4959-91E8-269F7CB72B5E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경향\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6A9D9BAA-1D55-48DC-AB3C-8F5F1585DD51"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khuynh hướng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("20E7CE80-59D0-4B21-8688-1600AD1C92A5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경향\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EF846B8E-AAEF-49FE-BB3D-FDE40BDF124F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경향\" (khuynh hướng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB59E4CF-7206-480D-886E-24B2CD394546"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경험하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0D12729-FCDE-4F92-BACF-C63BF147D476"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trải nghiệm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("36878FE6-6CDD-46AA-9638-086505A4D137"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"경험하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C11DD308-6DA8-491E-9ABD-2907655D95AB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"경험하다\" (trải nghiệm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("73989FF0-B68A-469D-80B0-551A4338233D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곁\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("60622156-580B-4886-836A-315CD8E688D1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kề bên\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B82A1FAA-B177-4534-B7AA-FDC78033A8BF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곁\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6637D757-ADE7-44C2-9D43-64ECDFA57FF3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곁\" (kề bên) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6263B3E9-8397-44D4-81B9-0EE89EFB1413"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계곡\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E6518BD0-E0E3-4A16-8AD1-C62FA9FEDD88"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thung lũng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("96B3CE6B-C827-480F-8DBE-F899E2B7C4B8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계곡\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BD867537-E893-49F9-A25A-F93D5DCB54B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계곡\" (thung lũng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A50965E8-A095-47DB-AE65-D2803D5C41BD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3106BCB0-AC0E-4620-AF9E-F0467336838D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bước ngoặt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DA5862D4-8825-4DFD-8683-D65EE617531B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7C56F7D6-84A7-4121-BA04-133CA32104A4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계기\" (bước ngoặt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("88B6D6C7-B91D-4954-9F4C-2DEAD227460C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계산기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1CFEACF0-93F9-4C87-8595-C1DF64452AAC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"máy tính\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("547ED15A-5D3B-453A-B040-F54497D514FE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계산기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("761B98A7-FF90-44CD-8830-C13697B62FAF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계산기\" (máy tính) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("82F268F4-5F22-459A-87D7-D29F2AC10E0D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계산대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("549C1AAD-8CB5-4381-B150-50E6FC741744"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quầy tính tiền\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("24B2F465-4E12-4622-9CBF-735BAA11E35F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계산대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E2464A1D-5A68-4B77-8F3E-DBB808C677E5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계산대\" (quầy tính tiền) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E28A1E5C-26BC-4212-AED3-7DFFEABE969F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계산하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4AB5682F-555C-4561-9435-67E9C3A1E9CB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08BDE6B0-E658-405A-B4EB-D1BD7EFD538A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계산하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8396561A-DDB8-4365-9D5D-86FB19F30B9B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계산하다\" (tính) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("005C082E-A78D-4732-8B50-1F2FE7C22723"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계속되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("35F6A0D6-4093-4A9E-9A34-24AA9583519F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"được liên tục\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("865B4EBB-233C-4A98-89AB-FE07AF79943D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계속되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("31CB53C7-AD40-4193-8598-C0D2D41E6009"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계속되다\" (được liên tục) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("24776EE7-8D00-464C-A40B-E4A9A731C521"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계속하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D5EC40D5-9472-4235-8850-4FCF970556E9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"liên tục\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1F31E777-79D2-4691-A619-13FAA199FA35"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계속하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("61FC15AD-10E5-4752-903F-387813F4EDEC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계속하다\" (liên tục) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("95E36F1D-6CCC-4B2F-B709-972DF2DB5BE3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계약\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BFD9BC3F-9268-4120-9A22-7BD04B31F103"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc lập khế ước\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("036B3A98-51FA-428F-9D71-99D1033392F7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계약\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("67990505-8C46-47AB-AB27-C42C92F2EFBD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계약\" (việc lập khế ước) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F3405E05-2A86-4E76-912B-1FB46E549A37"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계약금\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A8466B86-D119-44EE-9EC7-58FD43184519"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tiền đặt cọc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6D82A360-F3E1-436C-BBC6-8E07257F19D6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계약금\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FDAE1EF9-4FB1-4B46-871F-CEA7BF78D59F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계약금\" (tiền đặt cọc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1822BF96-3998-438B-A51B-F8635BAE09B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계약서\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("00CCC17B-528A-4CD0-8F8C-5C8549576222"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bản hợp đồng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("643F7837-E627-439D-8572-7A0A85732F16"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계약서\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("031E6B82-A6C3-4995-8C28-07609973B81F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계약서\" (bản hợp đồng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("063AE972-640E-4A64-AA23-783E7AEB69C4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계좌\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E71E31A0-DE69-4BEF-AB2A-82ACAE1C717E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tài khoản\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0928227E-139F-4E6A-9FD0-42FE65303932"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계좌\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6D1002B7-F489-40E1-80CD-194898F94F41"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계좌\" (tài khoản) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A1A5F9E9-2DD2-4D40-81A8-10E03B020FAD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계층\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("39E0D93B-33F1-4D97-AAAE-DDF0AC1779EF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giai cấp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C99B278-FF0C-442D-A7AF-41DABD6102D6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계층\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3FC9F4F8-AB73-405D-8180-26714B2580D4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계층\" (giai cấp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E2C4688-FA57-42C3-B0AB-B83F8B352CB1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계획하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("396B7467-46A3-4EE4-BDCB-E6B4DE65CDE5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lên kế hoạch\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A08D8EE2-CD5D-4AE4-8DAF-2784BDA8FBEF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"계획하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F45DB518-0B85-4E73-A69C-855461D4E1E6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"계획하다\" (lên kế hoạch) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C25F09BE-60BC-43AB-B5A4-5F54CB82651B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고객\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("72F7537C-2544-45BD-A2C3-937ED3C9EE9D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khách hàng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D198576F-2623-4EC9-85D0-6D11664F8859"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고객\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D3F385A8-FE5A-4C7E-AF9B-EBD74CC75034"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고객\" (khách hàng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F3438EC0-8EE5-4CE9-93F1-B9A63C1BDE70"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고교\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("579BF30C-221D-49F5-A47B-99A73F1E1178"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trường cấp ba\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D8E89A64-D30B-4277-B116-7B94E8011649"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고교\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("79A33893-47B0-46A9-8BFF-E9A77F56CCDD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고교\" (trường cấp ba) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8EABD618-B69B-4E8D-8049-3A635DDBEEB9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고구마\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("375D4824-B5CC-418D-B389-202ED3664CC3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khoai lang\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E630603C-D0CE-4953-9CE9-FE8A46AB859F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고구마\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6ADE96F9-E2D9-4A6C-84FA-9DF3E20960CF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고구마\" (khoai lang) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("84BF47F3-BA24-4E9E-A89A-B127B7223849"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고국\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D53D6B35-681F-490A-89FC-93726D69D556"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cố hương\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B07B4EE7-0DB6-44FE-96E7-65C86F2B4C35"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고국\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("352A74DF-DDF2-4D4D-95F8-E887D71816CA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고국\" (cố hương) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6F9742D9-AD4B-408F-997C-919F9CDE343B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고궁\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("39F614E1-71D9-49E1-AC57-3FE50E17288C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cố cung\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("89F17EE3-D402-4AB7-8751-1E58BD409879"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고궁\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4803B213-1FE4-4D46-95F1-3E1EF6475DFF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고궁\" (cố cung) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("96A649C2-9738-4106-8FF0-DED13DE5EB02"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고급\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("57C2147D-EC74-4493-8D07-8E03D3DC1D1A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cao cấp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E7002435-FCDE-4E2D-8109-7C9C6A93C016"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고급\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8734A886-4888-45A9-94FD-29E3862976F3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고급\" (sự cao cấp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("51E809DE-7C24-4BCF-AE0F-A81E2259CCED"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고급스럽다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("11E53BAD-0BEA-4B00-A210-1CF4592BD852"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cao cấp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5889985B-F340-426A-8C76-CC81EBFC95D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고급스럽다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7235CA44-A8FD-4E2D-85AF-68B0589BD813"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고급스럽다\" (cao cấp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("64409511-1283-4920-A748-325A40485340"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("446E3D46-6EFE-459D-AC86-8FDD0150F59A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thời kỳ cổ đại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("52C25D26-9BF8-4832-93A2-89AA37C0E10A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2CBB133C-276E-4866-A666-9228F9897955"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고대\" (thời kỳ cổ đại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("96DCE3BC-EC9A-4418-A8DA-CD75F24C9BF6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고독\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0DB16D9-A270-492D-9931-C1A20A924AC0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cô độc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2F609D50-6CFC-4D53-ADD4-88D51C06A9B0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고독\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("43DA8485-4134-46B5-B3AA-4FCF53860827"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고독\" (sự cô độc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8B41D340-BFF3-4F4C-B641-C5BF2ED3B3AB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고등\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5B9DE390-C30F-4529-92B1-CF6F4A2A4F86"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bậc cao\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F8F8BC47-9139-4984-A413-275BE6728190"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고등\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("03441E22-411B-4F6B-A157-C960A1E22CD6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고등\" (bậc cao) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("422EB44F-8C87-4513-9FF6-DB1FC481CB25"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고등어\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("06EC6A10-2798-475C-B29E-48C1BC2E89B8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cá thu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("92EB71C2-0CB6-492C-8DD5-67AE716AF846"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고등어\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D58DFE65-2310-4554-B51B-C644F47B162E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고등어\" (cá thu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2DE3CAD4-219F-4DDE-9F44-CEBB194534BC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고래\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("294BBB67-5A81-4977-83C5-0272FF876633"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cá voi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D703A0DD-B8CE-4684-A572-09762BD808F7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고래\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("645F237A-6483-4BC8-AD3E-B4B2AAB9AA47"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고래\" (cá voi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("817C1AA4-D8D1-4936-9E2E-9423BE6800C6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고려\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("75AE1E33-3242-480A-95B7-075F24E8C579"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cân nhắc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("05C20A4E-9E41-4AAF-BC81-0393098B2B8B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고려\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("15815D69-F4E0-428A-9D4A-F66E81E53A52"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고려\" (sự cân nhắc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0DFF67EC-D16E-4ACD-B1C3-80AE45FF777B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고려하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BEDA8DC0-D37A-4A44-B0CB-0DDA74275C0D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cân nhắc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1ED8A1F5-0DDA-4A12-94BD-2D4075437735"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고려하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F5A8F48E-416E-4421-BCF3-F86E7E39490E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고려하다\" (cân nhắc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B22650C7-5EBE-4427-B4A1-CA8B16ACC123"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고마워하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0257FD4E-3505-4E81-8A2E-A6E5B8C2C79E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"mang ơn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2E8205E2-226F-47D0-B8BD-52779E068899"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고마워하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E6E7B429-9594-40AD-94DC-099A5D45EB7D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고마워하다\" (mang ơn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E7EC44AE-3A8F-48A7-B4FF-46FE73E1880B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고모부\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AB3FADB0-039D-4C79-973A-7D31CD75DBA7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"dượng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BDF01188-CEEA-4099-856E-7DD9A9FA23F9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고모부\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7790B795-96B4-47AA-8B3B-49C3232DAED1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고모부\" (dượng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("318ECEBD-167F-447E-A266-99B4184E14A6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고무\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("46ADFBC9-D13B-4611-81F2-21EB45C23670"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cao su\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("924D3B35-77BA-4172-BA17-D3142C96B980"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고무\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("28F352E5-912E-4C33-8384-7C4EC91BD30C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고무\" (cao su) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D2B311DA-5620-46A2-8C3B-5E480031D95F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고민하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0C1F3BFC-8D70-473F-AC2A-500BCA9B21B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lo lắng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BBE4D102-DEB3-42BA-8311-71BA526D193C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고민하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("926CBDE6-FB05-4CA1-9369-85F62E6E8F42"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고민하다\" (lo lắng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC3A007D-8C29-4515-8799-C609F9DB67D4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고백\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A6101BB8-58F5-4D1D-9094-D55279181259"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự thổ lộ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A5B7B179-0EB0-4A6A-B27B-6D47A7BB0C35"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고백\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("14483981-F356-4BD0-8911-DE6A759421E7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고백\" (sự thổ lộ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A4876F7B-46B7-4701-815F-83B5DBDF5DF9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고생\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("065A66AA-6838-4835-8C13-B15EC40D74F6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nỗi khổ cực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("09730DA8-4642-4F04-9A61-2D4F20C87D86"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고생\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2A5762D9-32E3-4714-A4CF-436F2713EE0A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고생\" (nỗi khổ cực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1A4C47D4-A474-4738-B3ED-364669B7D5F5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고생하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A9279B19-58D4-4F5E-9F56-3E9307C8B05C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khổ sở\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A1F5FA8F-3A1D-4E15-8031-8A5F1E617510"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고생하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F09B4188-7730-4BDB-AFA4-4A0594C6C81F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고생하다\" (khổ sở) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D72C51A5-D189-4861-A510-F18880F40C37"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고소하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C2D9AE11-4360-48F9-8D6D-C6651941F5B4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tố cáo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A0AE216B-DCB8-478C-8F27-770B01197F3C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고소하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6C175020-FC87-4038-BFAF-A9A3A0494FAB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고소하다\" (tố cáo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F469445-AEFF-4CE5-AA7D-786549954D15"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고속\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BE3E7CA2-6AFF-4976-A68D-51118C46ACD2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cao tốc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("09BF97F6-51CA-4D83-A966-62DB7B984BB3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고속\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("46DCA951-2E60-408A-B330-CF40A8985352"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고속\" (cao tốc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("612F0FB6-CFFD-40DD-843F-B5392800AF23"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고속도로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("473B1FC9-B254-4DB5-965A-A2E6D775C745"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"고속도로\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D92E23A5-13BA-4219-95A6-3C03BB2342D9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고속도로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("14C1BCAD-6AC4-4DE6-967F-B006FE7B001B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고속도로\" (고속도로) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E1E4DC7-2B3E-4CBE-B153-6278237B7BFE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고요\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("67767302-4679-44F2-A01A-C18477693645"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự yên tĩnh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E66A607-5EF7-4642-8B6D-28E514442671"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고요\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2D6256D8-F8E8-4964-B8D6-195AE35897B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고요\" (sự yên tĩnh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B94CC3CF-D3B6-496E-863B-A5D469018AF7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고유\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B7F424D4-DCE6-4977-89BC-8CDCDE415B17"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đặc trưng vốn có\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BDE93FC6-BCBF-4E7B-A5B5-15C7FF4DA541"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고유\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8092AD8B-7DB0-4109-A547-C0CB6084FE0B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고유\" (đặc trưng vốn có) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5EE76B22-A13C-4030-95D8-3BB048B7BEB1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고전\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("911C4243-4B38-430C-806A-3FECE575D49B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cổ truyền\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D04D61ED-031F-4799-9F45-4212CE48A2B6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고전\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("80A08B91-2E87-4130-9C58-8AC5A5C269C9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고전\" (cổ truyền) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C6012973-A25E-4A32-827A-E57D40E28189"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고정\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5963B099-F08E-498F-8711-F61FF5C51882"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cố định\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0B45F1FE-3FBD-4AA7-9555-0007D7A52384"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고정\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A0BAA6FB-07B4-4BD2-BB8B-50D5C82CDB6F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고정\" (sự cố định) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED50F306-6094-4B9C-9A15-C3789A04F304"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고집\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FB7E31FC-D98D-4C54-A77A-DB4588F86B92"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cố chấp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C96CEFD7-C654-40C5-8F37-72C0623FA542"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고집\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("930A97F9-CE4E-48A5-8D89-FBA43009F483"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고집\" (sự cố chấp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D6D1FE51-1B7B-46D5-BA07-1CE9F919AD16"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고추\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A7A9AA9B-909B-4DF6-833B-EA708C07B06A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quả ớt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("51B26507-0C67-4D47-9DD1-32C836138AE1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고추\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A8F6986B-0F89-4EC2-A793-224BA51529B4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고추\" (quả ớt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("97788734-983F-45F7-9C7E-D16C40052C97"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고춧가루\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FF443911-7125-4E7B-8680-3E2B848AEB1D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bột ớt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("72747B61-2CF4-4CE2-818A-4619DE0C8160"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고춧가루\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A6B29320-0204-469D-B7C9-EEC4C95ABB90"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고춧가루\" (bột ớt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("335EE67B-36A3-4669-B4B1-9EDA8DB1DDEE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고층\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3D231BE-18BA-412A-8817-6491E2F075DD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tầng cao\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A3E14584-61D4-46A9-8FBB-006A63BAF582"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고층\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B38D8428-5E76-4E6D-A7F1-BE9A7933C641"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고층\" (tầng cao) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E4E342B-51B5-4251-B7EE-A3064A35A646"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고통\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("874BB00B-C91D-4B1B-8DA5-4E401986B4D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự đau khổ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3B67D31F-D95B-497B-B03B-DBA92DE81FE8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고통\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("08AC09B2-8F6D-46F4-912E-B1FFF88C6993"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고통\" (sự đau khổ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2C6BAFE2-B4D9-4AC0-A807-DBC5AD8B263C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고통스럽다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2185291C-C82E-4636-A1C0-880B31D4F269"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khó khăn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CD6FE401-AE59-414E-97EB-664295743BA4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"고통스럽다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("151D811C-9392-4B8F-8AF5-1AB48F726E70"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"고통스럽다\" (khó khăn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FDFACAE9-08CF-4DA5-A501-85F502F19B83"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곡\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7E3AC8E6-0FA8-43AB-8324-A88B101A6364"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khúc nhạc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E892E6B5-B086-4847-86D1-74354B0526C0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곡\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3B977BBA-3352-447B-ABBE-4A6C52A31B04"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곡\" (khúc nhạc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1A23EB50-AFC0-48C8-9D47-1174E2ECADFC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곡식\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1FE76B00-7A99-4CE5-8BF0-5A5F17FB0DE9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngũ cốc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("17E27E2A-2178-4F8D-AC2E-B0CD552A1BA8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곡식\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("998977F3-8BB9-4FE2-91B8-445E3921E387"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곡식\" (ngũ cốc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E0E9CF43-EDE1-40A1-AFC9-83504FAEBF3E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곤란\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0D62D02-1058-4303-BA9F-D7CFE027FA0C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khó khăn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0DED81FB-A158-42AF-8C59-FC128A646F69"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곤란\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("67E3856B-0956-421F-9D8C-81CAAA008518"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곤란\" (sự khó khăn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E6CE06D-EC9D-4D3C-B00C-E006717509B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5893B066-9C21-4352-B346-5D6E0DDC14B8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thẳng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3F6F9D37-8B3F-4D77-B55D-FEB4B85D9933"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곧다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C3869CE1-65AC-42F5-8650-807ECC9D2C63"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧다\" (thẳng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("555581C4-18E8-4EAE-9088-A0D233BD6C61"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧바로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A62D17BF-3F35-48E1-8930-25671CBDA296"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngay lập tức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FDF5BEBB-5ECF-4674-AA4A-5B469D9642E9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곧바로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1AFBAD07-AD6F-47F9-B92D-6828692A702B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧바로\" (ngay lập tức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8615EE1F-63EF-49C8-AE18-873A98AD269C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧이어\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7A9CD03B-2560-488A-903B-841470D71EE2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngay sau đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("454A6C8F-227E-46D4-8B66-99EAEB2D42C8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곧이어\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("60DC705D-E224-4BAA-BB6C-0B529EEFE48E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧이어\" (ngay sau đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2E569A04-D527-4540-8BE4-5AEFFA8A7D84"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧잘\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6BF8B288-F701-4676-96E5-D9A921523E96"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tốt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F25C77D9-506C-4969-AB29-4836B0CDDA83"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곧잘\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("65C3BDC8-057F-4969-A6DA-28BBB909BA3B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧잘\" (tốt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6AE01BD0-5B3E-4841-9660-8E4296DFA7CA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7DD8BF0C-BF63-4874-81F9-6D33059AD294"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thẳng tiến\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6885187B-A87F-4E93-B75E-C21D0B498836"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곧장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0ACCB896-ABDC-4B86-BC90-A5053A00C6A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곧장\" (thẳng tiến) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("76027FE7-38BD-4C48-8B52-78D4889FBD3A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9C6DF23B-F44B-42CD-B700-27C0749922DF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự hờn dỗi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF36CC31-6F35-4BE0-A24B-6DBA43843E62"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"골\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B0DF1BD0-3262-49D0-95AD-9DFD288F2112"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골\" (sự hờn dỗi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7155F3B6-AE72-443E-8CD5-8A31FCDD8A25"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골고루\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("59C3E57F-CDA4-4CBC-9184-8B5DA1E91023"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"(một cách) đồng đều\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DC151E55-3237-43C3-8C87-24CB79253626"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"골고루\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("713865B8-B192-42E2-9603-034887C5623C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골고루\" ((một cách) đồng đều) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("32D7C8EF-01AF-4E58-9C5F-C0701FB8AD4B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9B74AD7B-D9C9-4D3F-B547-CBD0C2C92035"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngáy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FD5C96C5-86D6-44C5-A3D9-159920D5CC5E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"골다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("525EB5E9-D03B-4FDA-AFFC-650326CB7318"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골다\" (ngáy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("404A2F20-FE9A-40E1-B432-28D23CA526C7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골목\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DE5A1653-602F-4976-BCD4-0B3713F78DED"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"con hẻm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B210BA5C-59AD-47E0-926A-81AA8C5EE2D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"골목\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C1EB1EAF-1CFB-43BF-8D31-A5D700BDA8D1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골목\" (con hẻm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("81961195-1D92-4757-AEEB-0DA863D93D69"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골목길\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B20673C0-1056-45BA-A68C-8CC94C93DC80"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"con đường hẻm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("50718EBB-161A-44EB-B217-65CF0EE0DAD7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"골목길\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("73E8AD40-9DDC-4250-B10C-003CCBEA1502"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골목길\" (con đường hẻm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("075E8C56-0F05-4ECF-9E10-F99B30EA531B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골프\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("32A46207-68E6-4795-B10A-9CE4E0B36AA3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"môn đánh gôn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C1F5BA28-5B71-42E8-8306-BF320E4AAE8B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"골프\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D60AFAB4-F6C9-4B8B-ABC7-5D8455577E97"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골프\" (môn đánh gôn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BF23A950-2F46-40FC-9C04-3593024322AF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골프장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("713A3833-F096-4D18-94EE-C6939BA33048"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sân gôn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C01CD89E-BC38-4CD1-85C5-454A6FC5E6A8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"골프장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AC8899F7-2A0E-45AF-947F-0E1B8433BABB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"골프장\" (sân gôn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("50FF6A68-9586-4D88-9F67-23D2E550EBE5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곰\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4584DFDA-A536-4031-B6A1-1ED7A25C116E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"con gấu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("696D3ADD-C8D3-4BD2-89C6-0B2B8BD71B65"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곰\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8514AF7C-DB65-4442-AD8D-5ADF0E14C839"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곰\" (con gấu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("626DAAC2-843A-4DFE-9E77-83B2E23390BD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곱다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A1CDAE1F-4F88-4EBD-9828-EE987B67F217"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cong\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B9742E77-AF37-4A1A-A017-5D14A38B8FF4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곱다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A6EAAB40-B12B-4FC1-8E1D-208CFF243D1F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곱다\" (cong) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8F351315-27D7-49EF-AEF5-D9EDEE51BE06"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곱하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("77AC13EB-D3B9-498A-84EF-4B1D1E09A9A1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7087CAE3-36EB-4F1D-A15D-3E89B593F0DB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곱하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FA3233C4-324E-40F2-974F-854DCF8E4EF0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곱하다\" (nhân) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F897DC9F-B8D7-485A-BC0E-9D14AE297CB1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곳곳\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("96728B35-CC31-4035-973F-AF62A541F59B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nơi nơi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7AB43C35-B61F-47A6-ABD2-645D997633E2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"곳곳\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3C2D9B12-9C92-41B5-9ED2-5CE33400FF6E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"곳곳\" (nơi nơi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B7F4DA23-606F-41A5-A19B-667AB66820B2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공간\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08E78C2D-62AA-4FBC-BD6F-4E06F854358F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"không gian\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3120B155-B1AD-4EE6-ABB5-DDFA09B20FFE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공간\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AA1C0B85-843F-4676-9B20-07DE53E78CE0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공간\" (không gian) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("817DE5CA-81CD-4E3E-99E8-CA9CFE0F0049"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공감\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3E31C598-80A6-4023-ABA4-0051DBF5FACA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự đồng cảm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("144B47BF-C80A-4877-93EC-E0308119F79B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공감\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2BA89A8E-C21B-49A7-9E94-37A341178390"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공감\" (sự đồng cảm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("230D76A0-3B9B-4B8E-AE01-A64E8E8A0941"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공개\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2DEECFE-021B-433C-A88D-43DBE9FA778A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự công khai\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("99FF35FA-50AC-4E46-9A08-F2E0150209AF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공개\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("214D079F-DA7C-4459-ADBA-CD06EA524DEC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공개\" (sự công khai) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0419E746-BC0E-4079-A05D-B9E381D63FCA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공격\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("812B05DB-4550-47C4-891E-6CC26753634D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự công kích\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9DCCE658-4031-431C-B6B6-9FFA4B3931DA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공격\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1E46CE7C-18C2-44CD-886D-6E588551B9F1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공격\" (sự công kích) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CC5428A1-2962-4682-A55C-E8AE5F1EFB5F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공공\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("333625C7-061D-45F3-85F3-EF2ADB48AC86"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"công cộng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("12B367D5-BEB6-4BC9-A1CE-24ADEC95495E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공공\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3FF1D4F7-44E0-48AB-BA82-D2598270AA69"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공공\" (công cộng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5F3783D3-EF7F-483E-9996-CCA9B42DF44C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공공요금\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2FB2F4E2-BE79-4F29-8981-43B0FA56731A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chi phí dịch vụ công cộng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A6D7717E-CFE9-4211-ABAE-FA090E1CB572"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공공요금\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B0A9DFD6-F8E4-4316-B027-253CDC9C88F8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공공요금\" (chi phí dịch vụ công cộng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BEFF3C14-FD40-4E17-B005-22FCC9D181AF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공공장소\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0E864011-7A71-44BD-9F34-215428EE9FE6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nơi công cộng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7785341C-63C9-4468-AE18-53468970D388"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공공장소\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FDBA43A0-21A0-4120-8081-8736E9B89D8A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공공장소\" (nơi công cộng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A54E66F3-052C-414C-857D-903F1F8AE1CB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공과금\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4786023E-DDFE-4E84-9C19-1CC9A7F58DB2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chi phí tiện ích\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3D06AC6F-2F43-48F9-97D1-14B8F58821B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공과금\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0F919F8B-BD78-446B-A718-AAC6D284B3BF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공과금\" (chi phí tiện ích) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9A2AD78C-CEDF-41E4-88E3-3BB0755DAA40"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공급\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("34958A10-3DB1-491C-945E-4BF538F04D5A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cung cấp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("69D51D1A-1731-44C0-9571-A403E22203F7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공급\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FCDA5BEC-E398-4169-9FD4-AD0150833E46"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공급\" (sự cung cấp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("16086E59-0178-4A80-A874-B62FC4C2AACA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C22B72D1-AFBE-49EF-B5E1-53EC4E7B3A8E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"gonggi; viên đá hay viên sỏi (dùng để chơi trò chơi tung hứng)\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E9E9647-C6A4-4015-815E-28ACE1F2E140"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AB4AF524-2367-4FE9-A3E7-5A56CD7129DA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공기\" (gonggi; viên đá hay viên sỏi (dùng để chơi trò chơi tung hứng)) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D04D7BE9-2EAC-43C5-99CF-B5BCBD746617"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공동\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("514AB894-23CF-4190-A499-36A2AFB5690D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chung\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("19B69C55-5903-4C51-8131-C7CA2DC03792"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공동\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E64270C0-A627-4EF8-814E-CC54B3E9501A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공동\" (chung) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("21100BDB-F0CB-476B-820E-5E4C5A1601DC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공동체\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CBDE0628-5BE5-401A-8EBB-AB037C958029"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cộng đồng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B170DCF6-9498-4E04-8104-80A490545B36"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공동체\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("602C30BA-D0CA-4DBD-8A0C-1985F4FA90F4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공동체\" (cộng đồng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B87B98D3-9A4C-4A08-91EF-E27316FEFEFE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AEA1CABC-912C-4881-8012-86AA032AA539"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"công trình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("17FE2A18-C364-4CEF-9A3F-B4D6BF611DBE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4C480563-BBC1-436E-95BB-DDE638F720A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공사\" (công trình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B82C1B35-CD27-42E2-948B-AB656F3A1387"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공손하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("055EBA98-2D95-4333-BE6A-C5A6ACA12F4E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lễ phép và khiêm tốn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A1A29657-D8CD-4399-B714-FE20D9E42EF7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공손하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E7B43BAD-2837-4E29-AE15-9F03B726A304"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공손하다\" (lễ phép và khiêm tốn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4323C102-D1FE-4F0F-BE70-2BD1319ADD1D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공식\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5716B1B5-BC17-468C-8957-1186827A77A4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chính thức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3D4AA337-3809-488C-A5C6-E7C0ACFC6FC1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공식\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("703725A2-C3EA-4965-90AC-0743F51170C8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공식\" (chính thức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C3C60478-2105-4D5A-B97D-E29B573277DD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공업\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("99D6897C-B351-4141-B7B7-DF4676471247"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"công nghiệp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A4276FC9-3B7A-4C87-BC8C-A0E8AF31F299"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공업\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3DC2D679-13AE-45EF-97A1-61F80A6D7DBC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공업\" (công nghiệp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E59FA61C-2486-46E3-A938-5DA0EFE6423D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공연\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("71DC9B99-0E99-44E6-A554-31A06DE88349"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự công diễn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F7AD30EE-9EB5-4E2C-95A1-C2D320FBB129"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공연\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("37AB85E8-3398-4B5E-B6F3-FECE8C83D912"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공연\" (sự công diễn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("76D55A98-110F-40DE-8299-282FEB356BEE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공연장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1AF580BA-51BD-495C-9415-403B5DE666C5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sàn diễn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("018B014E-D0DA-4EE9-B14A-50542774867F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공연장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2E66430C-6456-45DD-866B-59E826A63E01"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공연장\" (sàn diễn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FB87BC68-87EC-447B-A2A1-2FC81991D81B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3849F004-86AB-4597-8E99-9C4DEA8BE260"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"công\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("592AE40E-D799-42E8-8ACE-4AFF9732E259"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("123600BE-8807-4ADB-98E5-460CAEE47410"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공주\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("26576FA4-B00E-4127-957E-668B319BB6DE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"công chúa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93368140-A185-4759-8D88-2E5EB737BE1A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공주\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DFA01B31-AEB2-4279-9EAD-DB7F4BE6B416"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공주\" (công chúa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("586B8585-CCD1-4945-B1B2-90E1A0538429"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공중전화\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6A88A84F-8C83-420C-AF24-7299CE9ED87D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"điện thoại công cộng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E5F16556-D26E-4BA4-952A-C796D189540F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공중전화\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B5C03A88-E6FF-470D-8CD2-62978659655C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공중전화\" (điện thoại công cộng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB284B02-B4CA-4E27-9967-3A8695267B98"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("78D3F37A-C0D9-4124-BD96-08B7115AF7E2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự thông báo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1CF258EA-F3D1-4446-95ED-EBC26B331D19"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CC3B1A73-78C3-4394-97A6-1D9F57B09D19"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공지\" (sự thông báo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7BF56692-E501-4296-8780-7405405F8BB9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공통\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B108EE74-0175-4A08-A98B-A70D286D27A2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự chung\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("195E4971-B124-4B97-AF11-E7BDC9C718BB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공통\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("89050D8A-732D-4570-B41A-BC4C3D816EDB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공통\" (sự chung) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ADEC0FC3-9F71-4E2D-934A-BFED92D52DC2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공통점\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CD8E1D35-66BC-4F2F-8D6C-562EB824F3D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"điểm chung\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("989B59A6-5301-4399-8E60-E5AED94D0390"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공통점\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CA4CE9FB-EB14-4153-BD5A-3BCD4F21A454"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공통점\" (điểm chung) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CE18F48A-F033-4154-8025-2D2726C8551C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공포\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("28E9912B-ECA8-4B99-BFF6-0118A7A62E79"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự công bố\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7B5ADFBE-56C3-48B3-B196-783B6F4FB0CA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공포\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("06D63827-E86F-4BE4-BF07-A7A4EDDD2A6C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공포\" (sự công bố) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33D70593-B517-4B12-A0E9-442FAB4B7F43"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공항버스\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("25293EBA-963F-41D9-8861-7D2120C2BE90"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"xe buýt sân bay\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4882D164-0891-4B27-AE21-72FD02B4B258"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공항버스\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AA7ABF67-9919-4A11-B89F-2E48E6DF547B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공항버스\" (xe buýt sân bay) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9A177690-3D3A-400A-9C21-FAC0C7D6F4A4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공해\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B28C43B3-3E35-4706-BCB2-9633651A7BB0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự ô nhiễm môi trường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("44AA9096-70A1-4BD5-894A-FD0FAB558BDA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"공해\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("10AAA0F9-7DF8-44FF-8DD0-A8A2927DDEDA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"공해\" (sự ô nhiễm môi trường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5621A1B1-AF4F-4C00-A5CE-B2904841885C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("86F06A25-FB9B-4777-B744-0BCFB67E6915"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khoa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("976CDAFD-7AAF-4028-9003-97D9578162F6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("975E9210-8AE2-44E5-845F-C06B4F5ECC9C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과\" (khoa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("47D83697-BF0A-400F-ABB6-CD59BF1C6CA3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3E2FC47F-AF50-4D9E-B0D2-FBC4C4D906E8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự quá sức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E320273E-3DF4-4626-987F-3CF429FFCDE8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2B3561E7-78EA-40EA-BE86-076B4B5DD993"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과로\" (sự quá sức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("141BCAE0-8B27-461F-8DCE-FB5C5D51E2CA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과목\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D5B66EE9-5D61-4139-B7D5-A5520E7B02C7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"môn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D655AD9A-76CA-4AB9-A8E6-0387EAED8C02"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과목\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("57587C5E-ABE8-4A07-9464-85D4C6F698ED"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과목\" (môn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC037B65-A3E8-48A5-B260-36BBCB6C2372"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과소비\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FF959C86-7A82-4CBA-8058-1D712C2BE933"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc tiêu xài quá mức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2A6C4A50-9B04-469B-8069-5874E99A04FC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과소비\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5FB21736-4D14-4410-8DCD-7227A256178C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과소비\" (việc tiêu xài quá mức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8DF0DE47-C789-416F-89AE-39865D7FF7C9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과속\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AC48F0BE-033F-4774-8C3C-CE61730CB703"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc chạy vượt tốc độ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("41AE6655-D6D3-48AC-8B98-74EB22DA93A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과속\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9ABE3F6C-48E8-4A5B-A81E-DD578890B318"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과속\" (việc chạy vượt tốc độ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("61B415D2-148C-47E0-9181-B285A7D15389"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과식\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0EA6B267-163D-44B1-B04F-2F63AF537A49"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự bội thực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9C6CA372-28DB-4071-BFE6-BCCDE964AAB6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과식\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("58DEAB74-7853-437C-91C4-90D99C6DC90B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과식\" (sự bội thực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2A7EF253-EF51-4DE7-8814-BCD404DDA6B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과연\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("559BB3FC-EDC3-468F-821F-644DA656B547"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đúng là\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E73FB8B-6EE5-46A0-8926-8EB44F276B8A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과연\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2AD45243-6535-4D2A-9D7B-7732BAE0E4B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과연\" (đúng là) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("745CB2B9-8AB7-446F-886A-04383CABB65C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과외\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0D41705D-4E86-446E-B6B9-ED452D42DDB2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự phụ thêm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E23A2D49-5E56-4C7E-98CE-64D4936AC0FC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과외\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A295E78B-E0C1-46ED-9A1E-FB4155276EA5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과외\" (sự phụ thêm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC8A98DF-D2FA-4A8F-AC3F-CD8868949707"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("31738A82-1778-4535-AEBD-8AEC9CE43EB9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trưởng khoa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B7B6C8F7-126C-4990-A951-DB6AB80A2813"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9A18805D-BFBB-43FA-B60A-A3B107FFED39"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과장\" (trưởng khoa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D960A28B-068C-4AD6-BD76-3F5D8F45D342"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과정\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F99F4BA8-5DE3-4994-B03C-18EB00963A47"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quá trình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0441529A-E15F-4D2B-AEDA-63C0824D768D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과정\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1A1ADBEC-834D-4163-9FBF-2FDB5BC8F5F7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과정\" (quá trình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4BF40BAB-814F-45F2-94CF-5D0582876A5F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과제\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08C04C60-7FC7-4444-93B3-4FCB779BE07A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bài toán\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8534E5D8-5C6F-4453-83C1-ABF90A0FCDF9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과제\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C0905A9F-E361-41D0-9312-90771B703CAE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과제\" (bài toán) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1F3C0108-23B5-4349-87BE-BB9718451A91"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과학\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("216A0D0B-9782-4B40-BE28-C33DAE9A71B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khoa học\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("90418F5B-8CB0-4679-B01A-21877C277EEE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과학\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B7BFA7FF-4140-4069-B538-1D61CCF172DE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과학\" (khoa học) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6F3B55C3-5DC1-46DF-9E9B-088039F576CD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과학자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F9AB902A-19B6-46A8-9BBA-F336E712F229"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhà khoa học\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CDC23CD0-B493-4A7F-A75C-125BF88A5EC5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과학자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("994EDA86-2BA2-4D87-A402-CD90C0D2C381"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과학자\" (nhà khoa học) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BDB97E57-3C26-4888-92F7-9A929CDDD2C2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"과학적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("90F47EDA-2D38-43B3-9B44-5141F3DD9C03"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khoa học\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5679A9E1-0CF0-40DA-877C-48057C72DF25"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"과학적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B7012C96-0354-4B96-8B07-BE036D779E0D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관객\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EDF77DB4-9C8F-4E16-9625-7155A83C7E48"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khán  giả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF37014B-344D-42D3-A3AD-9F51BCEBAFE8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관객\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("01B58B48-CD99-44B3-9D40-29D46511DD95"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관객\" (khán  giả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("28553B4E-326C-498B-B024-2FB4FA8CA2B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관계없다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8835D23A-B2D4-41E6-9E0A-EE17ADA53B69"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"không liên quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A46C5475-6276-440E-BC9E-1D82B153DCA0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관계없다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5FF2CD45-050E-42A7-A8EC-6CDBE32E3266"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관계없다\" (không liên quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("53C4CB90-7038-4E05-AD3F-E72FCC10BAC8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관계없이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2592BBA4-506F-41C3-8D4D-9831AC3B7E4D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"không có liên quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("227B6A33-33D5-48B2-A289-7E524B0F31C6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관계없이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("481C9C00-75D8-4EA1-ABCD-0664D6BD49DD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관계없이\" (không có liên quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5F079DCC-B6C8-443A-AEA3-8830A3EC854D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관계있다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7A68B267-EB3E-4020-8F0E-3A5CB9C92C3E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"có liên quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3DF8235F-E8CD-461F-B2D4-9D1E34604A26"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관계있다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A3444470-B544-42E3-8BF4-9DF7AD676DDD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관계있다\" (có liên quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0927B88E-F31F-42D0-9A45-5ECA6AE6ABE3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관계자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F40D03F-D893-44DB-B1D6-B9121E708EE9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"người có liên quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E9FF5314-D332-4C82-8519-F14106434723"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관계자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("838CB651-2948-444C-AE3F-A27AA1C85C22"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관계자\" (người có liên quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D5D000CE-E8CE-471F-828D-1DD9A1DA535B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관람\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FC21A993-C2D3-4C43-9B2A-473F1A462842"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự thưởng lãm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DF9D5F4C-0A81-470A-AA2D-94F107CC9598"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관람\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BD331425-979C-41A8-9992-6ECE253CAB06"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관람\" (sự thưởng lãm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("14CF8826-4C9A-4933-B58D-8E248154334A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관람객\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("19507A91-6225-4FDC-8F5C-771083D1209D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khách tham quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("364F9411-9058-4CAC-BE04-E7383D387597"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관람객\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7EAB830A-A654-47FF-B4A5-A6511816E6FA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관람객\" (khách tham quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B4CC4379-641B-4F15-A094-D7D647BE12B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관련\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5280EAF9-24C5-44DC-B980-BBFA5CF76A76"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự liên quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("79576AC7-D277-46E3-AC2C-04D9D4877385"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관련\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("23481701-1302-4B80-B11D-3023DA90F4B6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관련\" (sự liên quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("73E3792F-5B29-42A4-B81A-8958D30F08AE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관련되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CA7FB99C-2B1E-4F3D-922F-9265D61A9F65"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"có liên quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("625511A3-1AB7-4516-AE6A-4384F6EBB955"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관련되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("300E5907-4204-48FA-98D3-48BBD93F8AAD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관련되다\" (có liên quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("704F66AA-B0A4-41AD-8E9E-5D62B5BA959F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관련하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("75F291B2-57B7-4B94-9C1A-FA13F889971B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"liên quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D5AA71BA-447E-4703-AFC1-672B5742E0E7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관련하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6879DE8E-16BF-49B4-828C-354881E8ACE3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관련하다\" (liên quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6134B5F1-E2BE-4F05-A81A-FBBE3BC2CA1C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관리\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("80DD70BC-BAF1-4858-BC21-41E520A6D903"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cán bộ quản lý\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EDD2C273-973E-46EE-92E1-2961742DF24C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관리\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E7CA6ACC-D3E8-48C4-8152-080620885481"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관리\" (cán bộ quản lý) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B23F3683-B707-4AEC-98B9-EA1357376C48"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관심사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("066EF158-3AD3-4C80-A646-CDCB61ED2359"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"mối quan tâm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7E4E5A01-BA91-4735-8D72-9F019847AA9C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관심사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E2E14596-131C-4B7B-BB4E-C7DBA7437EED"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관심사\" (mối quan tâm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8EE003EE-BCC6-47B0-97FA-4C4EB1E58365"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관점\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("948F685D-050C-46C5-8F29-DC8E907FE824"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quan điểm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C1B71DB2-5DE3-41B4-9A6A-EA705E90A312"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관점\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("06FA4349-EBB3-4C5E-AB72-5E3CB4FB61DB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관점\" (quan điểm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("02C9C733-1A98-4D1D-A500-6809A7D9D93F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관찰\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("40767E17-CA2C-4565-817A-C121ACDC49CC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự quan sát\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("81513458-6AA8-4F85-92F8-DC032232C9A9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관찰\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("ADB62D78-89D8-4E17-BBEC-F1BBC5289A0D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관찰\" (sự quan sát) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7F791C0F-A792-46A7-940B-3A5299A5D9CD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관찰하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("41852875-1598-4D53-8E0B-089A84FA0073"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quan sát\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F6965EEC-F0BE-4E63-9250-7DF6AD7E7B1C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관찰하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("151B45DB-D277-4FAE-9C40-FED44E3DE4A1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관찰하다\" (quan sát) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("56FF4E25-BB0C-4F56-9279-B5FB25152080"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B6D5D812-F52E-4636-A947-A8ABA3EEEE17"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"liên quan đến\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B2B7E113-3B74-46EA-885D-94FB7B1A13AB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"관하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F84BCDCC-9232-41D1-AD61-183B6869D8A6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"관하다\" (liên quan đến) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B7E21D76-14B3-45D2-9E91-A27E3360F476"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"광경\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3C6C799-DADF-466A-A8BB-267805B02080"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quang cảnh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("67BC6479-1D84-4A82-8AB7-E8B326A64B17"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"광경\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("579992A9-48EF-470E-BBE1-889019FF940D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"광경\" (quang cảnh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B35B06DA-B232-4F75-82F6-B29E2E712FEF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"괜히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("03939277-439E-4B72-8E22-FF06675B5ECB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách vô ích\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AAC93FC5-6D80-4DA8-9972-890D9110491E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"괜히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5B31B7A6-AB49-44B3-AF86-F020854E65AC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"괜히\" (một cách vô ích) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("645F35A4-9C08-42A7-A35E-692244797398"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"괴로움\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("79776EFC-787D-4C54-AC2F-8AA7C72A5C5F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự đau khổ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C559C79D-688A-4F18-A20C-26848A733E21"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"괴로움\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3A9B7969-E891-46F0-B499-A968F8E7A451"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"괴로움\" (sự đau khổ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E253C888-5A04-4AB7-A468-9A68A1E1C988"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"괴롭다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C920C2E9-98ED-4C9B-B64B-AD48E509E948"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đau khổ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D345B2C0-6C61-4FA5-B99D-4C348BA697C1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"괴롭다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AADDD2C6-B109-4AAF-AEA0-E6CEE271ACD3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"괴롭다\" (đau khổ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1B5EF3B4-057D-42E7-8279-0E1A81851CF1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"괴롭히다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AD4BA714-048D-461F-B7E8-EBE17B58338A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"làm đau buồn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4E47F261-A4BE-4A81-B753-DE91D5CE1225"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"괴롭히다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("66B6B4D8-7CC7-4DD2-90BF-F84E4E492C59"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"괴롭히다\" (làm đau buồn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2A13BAD7-8B7A-4BAF-8C6C-3C8EF8914052"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굉장하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F5A10861-1DD5-4190-941A-921F7A0C0A5B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"hùng vĩ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3523ECD0-5EF2-49B9-8398-8557AD6B3921"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"굉장하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2DB67913-854E-4D66-A432-6CBE2655D0CD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굉장하다\" (hùng vĩ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2288833D-1E02-40CC-A2B9-678F3E1AD17D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굉장히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("769ADFC1-C660-4258-A091-D567686499F7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vô cùng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CAAF8388-F4FC-49A3-BF84-7D96D72356C3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"굉장히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E47982C5-531B-4704-B65A-EE06EC9AC06D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굉장히\" (vô cùng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E3A44FB5-A662-4DC5-B5A4-28F50AB181A1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교내\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0B317EC8-635D-4CDD-82A8-9158FE210843"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trong trường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1F7A99DA-6E9E-4E4B-A00C-BA2CAA1003CA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교내\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A8BA3B6D-1C46-4417-B34D-FB718F1BB03F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교내\" (trong trường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("89C293E8-EB0B-4EED-BCC5-7675E026F99C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F3411367-2E9C-4AF2-B040-6744FD2434AF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ca (làm việc)\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1025F3C9-6B75-42FF-A904-B48EF6726AA1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5C03D4A1-8FAA-474A-A2F7-3FC9985B700B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교대\" (ca (làm việc)) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A9A7E09E-1241-44CA-9601-8D41F8D00CBE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교류\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("17272F88-8B88-4514-8042-305A74746D01"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự hợp lưu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("193D53E9-B3BA-49CD-A9A6-1D71B96470D5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교류\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("42C8D572-0C23-4B70-ADBE-22AC54C58B2E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교류\" (sự hợp lưu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("71F2C6CA-D484-4BD2-93A9-4A23B5A395C3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교문\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("00702E7E-B605-4A64-9DB0-FEC3088DD500"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cổng trường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F539A161-8E59-4D1B-B479-CC4AA52753DD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교문\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5B8B63DA-3FE0-489C-8AD8-7F14CF991A97"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교문\" (cổng trường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D8143F3B-5B39-4A36-8050-1CA4A269204C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교복\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("276A849E-C138-48A2-AA65-CAAAF554E73F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đồng phục học sinh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("472B5301-F45C-4CB2-91CC-AA7BC5AB2B8C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교복\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C1047C90-FFB2-4E0C-9D69-5D1528A0300F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교복\" (đồng phục học sinh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F1921CD9-FD47-48C4-9410-D0696B1D81B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교시\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("13948DF6-FC94-435C-B9EE-8CD21C567AFA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự chỉ dạy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("91EEB3A0-4193-430D-897D-4CDFA7E0F659"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교시\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D9F25256-79A7-4386-900E-35F394380DA6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교양\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2F5EA6B0-29DA-4454-BB65-71FE517D2DBE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"học thức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CBCD67D5-AD74-4F83-8AC0-3D2DE6099A35"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교양\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BBF9AED6-D7B6-4A89-AA42-A7EFF8EBCD49"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교양\" (học thức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1FE199EF-F90A-478C-B7FB-3146AD947054"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교외\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("45093517-5584-413F-9513-6FF8CF14F896"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vùng ngoại ô\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("91B2D452-AF53-4C36-A388-FB2DBE08C790"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교외\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D7CBC030-C447-4F4D-A50F-76381879330B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교외\" (vùng ngoại ô) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("498C72E4-121F-4DB5-90E0-FB5DB08A17F5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교육비\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("133523B0-0557-451C-BD67-491A5B0B985A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"phí giáo dục\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EDBA3E11-C703-4BE0-8EBF-C852C85D21CE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교육비\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D20FD201-0B13-4180-9D67-84B3CE7833D6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교육비\" (phí giáo dục) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6C7D65A7-A817-4DA9-86E8-F34068AE74A4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교육자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9626542D-DEFB-4C0C-90BC-7C98F8690B6F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhà giáo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("875E2612-4D86-4670-AC60-1AACD8ECC029"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교육자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CD9B1CA3-D566-4964-8045-8B9E93A0F354"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교육자\" (nhà giáo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8840F099-E5D9-407D-A65C-7125D9ACDD22"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF2A708C-418C-4235-8636-1E7DCDAE84C1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"hiệu trưởng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2C2D0231-FB8A-47D3-8380-9DB7833B4A94"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2F144C36-36A2-4FE8-B597-DD4C3A9CE51C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교장\" (hiệu trưởng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("852132C7-1DAF-4BBF-A626-BE5E7BAFC5F1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교재\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E6C1F614-4B39-4302-8F3E-0160528B2420"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"giáo trình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E444D595-BA8B-4B85-BF8F-633B10FE3E92"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교재\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("82647731-D721-4A9C-B336-3EA2646DACF9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교재\" (giáo trình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A46ADF67-1536-442F-9A14-D6ED375173F7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교체\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1B5D96F4-4F03-42E1-AA86-D6CD8DACE0E4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự thay thế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1BB7DB93-7B0B-48CC-A0E0-702DFE2E3960"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교체\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("557811F2-0EC4-4916-8FE0-6723B985921A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교체\" (sự thay thế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B144DCD9-48EE-447A-85B3-9F7A66417EC0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교통수단\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("79986F60-5049-4EE6-8060-77EC1FBF704F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"phương tiện giao thông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E185819-C810-4587-ABEA-2DA5F3191E54"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교통수단\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7E12E07A-46D4-4901-8E6E-F4099B3E9ABC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교통수단\" (phương tiện giao thông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F612B204-48C6-4624-B7AB-56F6A5A96CE0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교통편\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B1FB8C07-CC28-433C-909D-6665C8C8B269"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"phương tiện giao thông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1454A7D3-8D71-4988-BC5D-9774451CD3D5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교통편\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("15B2C7A9-E836-4B96-87E9-3C574876E2CD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교통편\" (phương tiện giao thông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E3D93056-0662-4C53-8282-5F126410AF55"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교포\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("39A47F0F-814C-4B12-BB71-3362375D7114"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kiểu bào\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1913D763-8FE9-4533-B003-E3709E3BBBB5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교포\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7912F5CB-B44A-4E70-B317-718B0C58BA6A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교포\" (kiểu bào) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("09B1E85D-CA58-4EF8-85AC-DBB2FFC8E5B0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교훈\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("61D7BF03-6387-4434-93BA-83AF59FAF90B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lời giáo huấn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7B87AC4A-981F-4520-8D32-1C84A3A57322"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"교훈\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("382E1530-33F0-4228-BD5C-7114A1AA0734"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"교훈\" (lời giáo huấn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("14AB5A87-FE26-4DDD-B276-D20024ED0776"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구경거리\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("42797326-EE2E-4894-A141-5DD9322581D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cái để ngắm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B8851C2B-E847-4038-8D41-2E5E4BF722C7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구경거리\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4E67F2C5-A453-4E61-9924-E0CEB666960A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구경거리\" (cái để ngắm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("82EDF0DE-EA73-4F18-92C7-C0F0DE73035A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구경하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8BB1CC6B-B159-4AC2-830D-05C45ED80BD3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngắm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B4FB6800-7603-4985-B0E5-F165D0755E8E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구경하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8D1CADB7-C34D-48B4-A849-D16E1163927F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구경하다\" (ngắm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("99A7A822-C3F8-466A-92E7-5371188295C3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구르다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("948C2E71-2F57-4D89-BB85-C49123BC9A8C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lăn tròn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CECD1336-4012-457B-BE62-59468C04CF91"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구르다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F2F44EEA-0156-441A-B1D5-7B3BC0D2DFB5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구르다\" (lăn tròn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("31100CF3-3A4A-407D-B251-EC14E6E03464"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구매\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8C401FDC-A232-430F-BC28-52609E070A14"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự mua\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("82BF1981-1B9E-4F5C-8828-3ACA71DD40E6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구매\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("084688F4-86AA-469C-A25D-2958412593BE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구매\" (sự mua) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("829BBF4B-70EF-4B8F-8E06-11498F5FD911"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구멍\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("723E08FA-9E3B-4A56-8282-3BB91E319AE9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lỗ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1F371499-B40D-4F10-BE22-92B05078E94F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구멍\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DFAC9804-9FAC-4692-83DD-4F1E972146F9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구멍\" (lỗ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E6455DA-7194-4FA8-8C0C-30E295536F78"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구별\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D3C8F7CA-3CBB-4ABC-A5F2-C7507F89F263"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự phân biệt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B62DF2C2-7A9D-47D8-B32A-2B8BD3435BB9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구별\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("05B8C60B-5149-4B3A-B606-8AF7D15CEA22"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구별\" (sự phân biệt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1D1D25E0-04B8-4C07-B831-F83B348190FB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구부리다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D0E31BB-634D-4692-A811-65E25ACABCDB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"gập\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E17409BC-3069-41AC-832E-96A1092CD0B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구부리다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AF4121C7-7CBC-42E2-AB8C-5B83EB910162"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구부리다\" (gập) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("058E3D90-89F1-4078-B145-3939F22DE100"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구분\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10A6606F-8B87-4B06-A804-4213A5BA2DAB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự phân loại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("42E4BED9-5F90-4B3C-9325-060CAAC3067D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구분\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("95D508ED-FF16-49C7-BB9E-B6EDEA9E3B1C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구분\" (sự phân loại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C8E4E15F-E112-4970-A40E-2319AD1CE406"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구석\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D161CE39-5793-41A5-8480-CFE63DC3A975"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"góc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7CB2A49B-4E01-4DBE-93A7-DA06D359C997"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구석\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2B0F7204-8862-4B3E-AFCD-EF81ADAB29AF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구석\" (góc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A0378DF6-F6BE-4474-AF18-81742F6882DB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구성\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E225423F-5E69-40F2-8470-0C72D0C3A8EA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cấu thành\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2D8791E5-99B1-4750-A026-70DFB7428525"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구성\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("71193585-6C22-4096-89FA-5EF972DB799F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구성\" (sự cấu thành) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("367094B4-205F-43D4-8CEA-7AC6F4CB88CF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구세대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("853740CA-F667-4D46-A593-162D111E5A77"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thế hệ cũ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DFE5E09C-CFC4-4F3D-9069-8237387E0B56"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구세대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("070CDAA4-EEE9-4B80-9698-977A824E1DE6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구세대\" (thế hệ cũ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ADF8D9BA-324E-490B-A713-86FD921DD222"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구속\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0147BB5B-F2E7-4584-A311-70533D4645F2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khống chế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E63D0814-12CE-4424-BEAD-C6A9E24C9F3E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구속\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DCF27714-643F-4CE0-9CFA-AFE46EBAC65A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구속\" (sự khống chế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A3795310-F360-4A3E-A18E-8A455348733B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구수하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("05612F45-37D8-4453-945E-A7C5648874CC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thơm ngon\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8763B32A-E1F1-4702-A747-2F2CF589D162"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구수하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("467CF2A3-4B9C-4957-BCDE-458FA89C67B6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구수하다\" (thơm ngon) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("66586256-7E38-46A4-AC6B-B5D56BEDCC9A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구역\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7A6A506B-327B-4EFB-B9E6-1D2B37F60A72"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khu vực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7423651D-815B-414B-9628-0BCC8612F242"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구역\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("75CC4DEB-7E4B-4480-A71C-900D3EC5D174"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구역\" (khu vực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A2223743-81B0-4D66-8034-5F476D205970"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구입\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0CC4B76-5F72-4421-B434-61F9520383B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự mua vào\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9198A4A6-013B-40FF-A0ED-BC615F0A3268"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구입\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A03EA208-25EC-4AA8-8076-9927F55F2B67"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구입\" (sự mua vào) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C7E61B85-787D-4A21-B8C2-4F14B00FE774"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구조\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C4BB8086-2F2D-433F-94ED-0E2BE3FF6502"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cứu trợ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CCAF6925-FAC0-43E7-A3DD-D7CA92CECE17"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구조\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5BF5CE7D-9FE2-44E9-B866-7D12494F9615"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구조\" (sự cứu trợ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E72B1AF0-6D0E-4713-9EAB-9D1D0C77A3CA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구조대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DC5FAD10-2BB5-42AF-9BAB-1BE80AC61A81"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đội cứu trợ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CD99BE17-7DFF-4DB6-8FDC-D82F986DD4A9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구조대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F08D2BE9-6F74-48EB-8108-45B77D96B55A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구조대\" (đội cứu trợ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("416AF393-6947-4948-89CF-84A550E47536"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구체적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CD0C0980-3961-45B4-B457-8B3FB7A022DD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính cụ thể\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D6CAAA73-68EA-4A11-8B44-A1851285D11A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구체적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C2BC9DE1-B4F4-462C-995E-6BF4BA9C14BE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FBFEE69C-250F-4342-B9B6-5149A8008F3A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tìm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A96241E8-E706-4534-B10E-7D27A595EA6E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"구하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("48FD590B-7872-439B-A6CD-866F6AA65529"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"구하다\" (tìm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C65866BE-2CF0-43F9-B424-D0565400F07F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국가\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A7252897-851E-496D-9621-33196387C5D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc gia\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6EE04C8C-3338-4DCA-88F9-1949D344E60D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국가\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("91A0358B-EBB9-497E-A37B-BE1D8FDE0B1B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국가\" (quốc gia) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0223F32-1420-460C-B553-2E203FFEF0D9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국경일\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A30F37F0-E96B-4F2D-9C87-3CBB881B0093"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngày quốc khánh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C3D10803-36EA-4790-A683-FBDE23F133DA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국경일\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("968F4488-E35F-4C6D-B18A-2F740EBDC180"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국경일\" (ngày quốc khánh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5AA87C49-50DA-45AC-95CF-6EA6A79B6400"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2073F974-56BD-4EAD-9EA2-D569D692EFE5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc kỳ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F146112E-294D-4A0B-A82A-794EB1070C1C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("24D3E945-131E-4F80-BEE0-C8313C522957"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국기\" (quốc kỳ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9E0F653E-8800-45A1-9749-2A57C2CE2E22"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국내선\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("70F71BFF-4611-4B35-BD5F-0C890D411479"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tuyến quốc nội\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E64F227F-3282-48A5-BE4F-5760A4C9CE39"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국내선\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("ED532BCE-A5B4-415C-862F-AFAC259B2E57"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국내선\" (tuyến quốc nội) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EA6A632D-C902-44DA-9FC4-E73526555F9D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국립\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A64A481F-DE95-40F0-AD44-BDE1B8941200"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc lập\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8C6EA1ED-E69D-4D69-AB0F-9722EA8BF46D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국립\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F6E5EC4B-61A9-4186-9505-A2C95FEC1A42"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국립\" (quốc lập) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AB039DF4-CC8B-44DA-9D1B-B2ACA135E285"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국물\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7D4186DA-E98E-4C71-8FF9-9EEB2B39FC9F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nước canh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("232B9249-C400-4F37-AB77-CE3A39831C69"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국물\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("27679BA7-B9F7-4072-A3FF-5049B089898C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국물\" (nước canh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5BAC1F27-10F5-49AF-AA61-EFBF546EFE0A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국민\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("36A7B500-4DE6-4F11-BE67-C302065D058C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc dân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5A2B09DC-8FDC-4EF3-8F17-EE52442EF1AD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국민\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6551FAD9-66D5-4204-AD03-47B402E64EBF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국민\" (quốc dân) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DDC370C8-4E62-4E5B-82E9-07314939D3B4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국산\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("416961F2-1AC3-412E-80E9-E0E47EFBEDCB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc sản xuất trong nước\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("845D2221-F4E2-49A5-9B2C-5E6C6CF48394"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국산\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6D46FA72-532D-44D2-A04F-6244821E6AF1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국산\" (việc sản xuất trong nước) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("35F75F65-500A-443E-BADC-DA47588015E4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국어\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("156ECC4B-AF24-4D28-9D74-AA58B335DFD7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc ngữ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6D617297-EB9F-4EC3-BF53-A7AF75EFDE9A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국어\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("08DF9223-B900-462B-93D6-37C24F5B7A1A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국어\" (quốc ngữ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BA8F49A5-88E6-406B-BA77-15EFEFB71F0A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국외\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EB9CC02A-2FFE-4BDF-9ED2-32BC4681ABB2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngoại quốc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3499513A-96E1-40EC-91E1-92FCB07328EF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국외\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F7B50C6B-9D9B-4585-996A-B30424F1A50A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국외\" (ngoại quốc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("53D78460-75B8-4EBB-8B68-BFCCF1003F6F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국제결혼\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("68334585-C223-4C33-8D43-0E403A7610C9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"việc kết hôn quốc tế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5A2506AD-DC14-4615-B41F-76652393BAD0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국제결혼\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("98C88A24-EF4E-4408-89A9-B31705BFB5D4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국제결혼\" (việc kết hôn quốc tế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("57159CFA-E962-44EC-A220-93D167EB8595"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국제선\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("808EEBBC-C9D7-42BD-9A4F-176FF436150B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tuyến quốc tế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C1549748-8EA5-4986-88C6-1F1E45D40EFB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국제선\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FDE1DC4A-7804-4823-99E6-D80F4771C6B6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국제선\" (tuyến quốc tế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1C5332DF-CA18-4443-BF77-658232D6ED5F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국제화\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6DCF07D3-6B86-4D46-B45E-25145C17C785"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự quốc tế hoá\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E9A088F1-89B8-4B52-ABE1-27EDED886A3D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국제화\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BC149B8E-5048-4FF7-A656-E643D622F65C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국제화\" (sự quốc tế hoá) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3534A82-5EC3-4718-9E13-073FC274579E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국화\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1AF4D3EB-23AC-4A1B-B9C6-D96B55B2DBF0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc hoa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10CE713B-6138-41BD-8A75-596252F69822"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국화\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E1B4DD2A-73B7-4071-8CFB-008DBB885082"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국화\" (quốc hoa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C629AD5-2C6F-4465-B8A6-7E1015CB9EDD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국회\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5B81D0CF-0329-4516-A46A-7C6B2B12E82D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc hội\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6EA0C0AA-7A3E-4C45-BB10-FF4092C61D49"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국회\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("63C53BE0-9C9A-4EC3-BD3D-56D496C32300"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국회\" (quốc hội) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4A6395DD-4954-4DE7-8863-A5AF30856F87"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국회의원\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("01EDA6AF-D175-4602-8B4F-FFF0D13723DB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"국회의원\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C006593C-DCAF-410C-BCB7-857F432D91E6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"국회의원\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0655B551-C5F7-44FC-B14F-F5073B0DDA01"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"국회의원\" (국회의원) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EE1E7874-DB4B-4836-8367-48D6C779104A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"군\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB94EFB2-82C2-42DD-92B5-E30A47C5AA4B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("92306089-55EE-4601-B9FD-BF5D040163C1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"군\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EC4504B8-2CC2-4845-AE12-A27D672E05F6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"군대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A4647A83-26FA-4515-B54A-506C0B335A80"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quân đội\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EE1A6BE1-77A1-41CA-B536-05C680945341"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"군대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3DF047AD-F061-4FD8-B330-0C66A10AD313"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"군대\" (quân đội) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0F8A5416-4FE9-4CE5-BA27-8EF35A16519D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"군데\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C4DD922D-D114-4730-A02F-B36BF7A24C26"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nơi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E4AE553D-0EB0-4C2F-807F-A870D4579DA5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"군데\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D6A35828-FC0E-44D5-95BE-AEC170815EBB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"군사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("66E6C350-0D4A-45FA-A3EE-5EB02E666DBC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quân sĩ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("12706042-4EFA-4A9A-9F01-1C6182B27F5C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"군사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FE40F90C-87F9-4534-B7CF-03142DCDB9CE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"군사\" (quân sĩ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("168782DE-E9C6-4DB4-88B9-3471CDAFAA00"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굳어지다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8146C297-DF63-454E-8D0F-87B2180B8014"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trở nên đông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A52A967D-FA47-4D95-809A-2DA1C0C4E731"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"굳어지다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("31A62B9C-0BF1-4AB4-BF30-1E2A0AF3B44A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굳어지다\" (trở nên đông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("847FCD15-6AC7-417E-BAE2-11F0F611A56D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굳이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6D865A0F-C203-4FAF-90A3-C146BFA186B1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cố ý\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E5D38314-E3C0-4D8E-BB6F-851DB15A966D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"굳이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("109C2F94-D124-4CFD-A1BD-6C746DEF60C3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굳이\" (cố ý) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4E1A26D4-0D11-4117-B442-C54A6576EE37"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굴\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FC641D29-DAC7-4764-827B-5BD3A56185A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"con hào\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB7E6ACA-382D-4D1E-A8B0-D0E0DE7BDB7B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"굴\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("22BAE128-111F-488A-9FFE-16DAF1FFDAB7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굴\" (con hào) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3B04198B-2AFA-4E4D-9645-860F62F1CF1E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굶다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("394BD97C-73C3-49C4-A5EF-91617A76A5D4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhịn ăn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("811904BF-8691-4E17-B811-F4D97F7E7453"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"굶다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EE364914-8AB1-4CE8-A173-BDB5662BC507"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굶다\" (nhịn ăn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E91675DE-F4B1-400E-B60E-A0DA7B063318"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굽\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("28065D28-CCE6-469D-914D-BD358F3110A6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"móng chân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CF49C44F-9CAB-4DB0-9552-E04AC2FDB4AD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"굽\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6FC31867-843A-47FD-9231-75945CA4D69B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굽\" (móng chân) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F6498ED-D84F-4576-A005-19572BEEF2E3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굽히다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3873ED18-1220-4801-AD4D-EFDB94B10295"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cúi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2D0338E8-D9F3-421D-BF24-D29DDA778D1A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"굽히다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1187E393-9E8E-4E41-A2DD-5153CEC04437"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"굽히다\" (cúi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3F811376-5E18-4726-88F0-4D8D3C91B64C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권력\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D17F4DB8-8547-4C21-BD03-BB782E91FE9C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quyền lực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0F3A180-A7FA-4357-BCE7-7B84AFB3BE64"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"권력\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A8283559-AE15-489A-A978-58E36D00DF0E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권력\" (quyền lực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FD0D9C53-3EDB-4006-B226-50E825559D1F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권리\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3983FD7E-4373-4D98-9A39-A64C035CD799"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quyền lợi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F2C63252-AFD5-41A6-ADEB-4748765A09D0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"권리\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6AD34DAE-9F74-4C4E-876C-AB12E63526F0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권리\" (quyền lợi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("38BB32FB-CA24-4D60-97C3-28EFEAC7AC3A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권위\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1EB56CD7-D221-4E02-BD79-4D9906862359"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quyền uy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7B2E9BDE-4303-48B7-B506-9CC1D286C719"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"권위\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1F7C9256-EF6C-496D-9377-AEBAF2500D80"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권위\" (quyền uy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C658D386-424D-4966-83CC-1313E3C1F6F1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권유\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("601AA86A-097C-421D-BFB0-65EC181BF4AA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khuyên nhủ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0A55D484-F0D2-46DF-8729-78F5247CDABA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"권유\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8FA6095E-6A2D-478C-97F8-0188692FA233"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권유\" (sự khuyên nhủ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8DC94DB2-615D-4C70-959A-1075C1D2EFD5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권투\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("781EE7AC-B28A-4CD9-9FAB-F6B96C91F667"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quyền anh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7A22B8DE-B9A0-4E0D-BC40-9FC53E3A4FB0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"권투\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2692FD15-43D4-40EA-B796-27D9B7EBEF14"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권투\" (quyền anh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D5E320EC-2309-40F6-909B-BF8A2B99637F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E52E111D-E938-4492-B079-376D98A85AC1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khuyên\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5F2C13D4-A581-40E0-9BB5-CF76320B1FF2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"권하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F59804D7-EE1B-427D-8BED-50D1748A63B4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"권하다\" (khuyên) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8FD652BD-C2F9-47A5-87A7-565E94EBEE28"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀가\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9BF1EA9A-CAC6-43F4-B347-A8AA686D5A4C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự trở về nhà\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0F895783-66A7-4B4C-BEB6-E01D19FE7C94"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"귀가\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("269ADA1F-1CDB-4C82-A671-815A3D187926"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀가\" (sự trở về nhà) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("762F17EF-343A-4896-8C54-B8EAFEC9F8CA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀국\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6998FB86-7836-41FD-83E7-DA095A1C8008"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự về nước\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4268EC43-667F-4ED5-8CC6-26F285C064FB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"귀국\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("525EB0C8-F4D2-4005-86C5-6C81F42D665F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀국\" (sự về nước) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0ED5528D-3CF1-4B2C-BEC9-598A36B279F8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀국하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B15440C2-908B-430C-885B-66CFC6CF5474"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"về nước\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F8F18977-5C4A-4F21-9618-90D08655367D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"귀국하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("89D3B127-63BD-40E0-B4DF-54C8FCDE0A50"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀국하다\" (về nước) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF9B4A57-7D48-4B79-A359-FA0B056D5C94"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀신\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C381E0C5-2E0D-487D-BAA5-1D58DAB80D38"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"hồn ma\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E0D8200-232B-4C74-BF2E-E58ABBADE46B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"귀신\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("624F9AB6-87BE-4F0B-970E-317C8C56ED7C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀신\" (hồn ma) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08BE99EA-BD46-48B9-A6FB-D256E5BB7314"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀중하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0BD72062-DAD4-411A-AA3B-495915E831F4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quý trọng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6D8BBE28-EE9A-4779-892C-28A3520E0781"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"귀중하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("ADAA4BE8-587C-4E38-A729-F03A194BE52C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀중하다\" (quý trọng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9D05956F-C89B-4FB9-8798-0FFE0C885C85"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀하\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E9810DFE-CE50-44FE-A2C6-FF772A49ECC6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kính gửi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("36F99CF8-A308-4FD7-A14B-120A69E2A42B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"귀하\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0E8937CD-7A98-418D-952B-5994B931F7CA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("51523154-A965-4D32-89ED-880B2B02B4E2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cao quý\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0C0EDDA1-DFF8-4276-8998-B73441A4A864"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"귀하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("19C79FFE-D038-442D-934C-7E070203E609"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"귀하다\" (cao quý) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C0FB947E-176D-4B56-971A-B3B622722E2B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"규모\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF793E30-FB42-42FD-B9C0-FCB54FF2582E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quy mô\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3FB68DA7-F1A2-4733-B448-63C860543E67"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"규모\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7918B905-A87C-4BEE-8CD7-C0367BEF5914"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"규모\" (quy mô) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3BA06BF1-4182-4D87-9C06-64EEC22A8E82"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"규정\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("03988163-56AC-4193-82CF-D7B404D5DE6F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quy định\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3EB48D5F-24B9-4A46-941E-DD0437EF3039"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"규정\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1E9D07CD-DCBB-4F54-AF6D-280C4AAE62A3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"규정\" (quy định) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AB5C9A55-FEFD-46BA-AF3A-CA84086DFB9F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"규칙적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("444E7AD7-D74E-44F8-A7C8-BCF99140498A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính quy tắc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C1F6C2DC-0E8A-4C81-AD76-15C596FB48A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"규칙적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D9FD8E8F-AC36-4340-9E4C-CC88C7641101"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"균형\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9600A856-910D-42E8-AE7B-C3F6E7B4CDC5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cân bằng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B9AAD4E2-886E-4D5E-9FE3-DEDD2574AF8B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"균형\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("908A5BA2-45B6-42A8-AC02-FF6B3FD4C4DB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"균형\" (sự cân bằng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FD405C6F-4DD8-4049-9F9B-6A5ACF1B3715"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그나마\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8FAD8433-B0BA-4410-8407-CF6E1C02773B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"dù sao thì cũng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33BC7951-9C7F-4C35-96FE-3DAEAA486B2E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그나마\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B0425A42-3251-4044-A1A7-ED4C7A18B1CF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그나마\" (dù sao thì cũng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("878C54A1-A6D4-44D1-B51C-56A287047C92"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그네\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BEB4C4BE-8A1F-4450-B4F0-FFDC34CCAABA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cái xích đu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CC9DD166-4ABF-485B-A634-29A0AD95EDB8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그네\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E58D3B41-31BD-4857-9D77-23F65B7A43D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그네\" (cái xích đu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C1FEAAA-B37C-49BB-BF09-9019D613EDBC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그녀\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AB5477FE-8284-4A88-BAEC-1446B3DDF07D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cô ấy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C09B32D8-EC49-4286-8D5D-43709C9300DD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그녀\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B060F77E-2929-47ED-800F-D36AFC2FB9A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그늘\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("193F32C1-81CA-4FBF-854D-E8AB8599223C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bóng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("36B0394D-FE7D-46DB-A4EC-55A046358C69"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그늘\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DFFFAE17-B11E-4FA3-8314-4C7D4240CA82"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그늘\" (bóng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B77A11AB-2504-41AC-A8EF-14FAC15A0FB7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그다음\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9C8F6F82-EE68-4BE7-BFAC-12BE7C5326E5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sau đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CF68184C-1DB1-41FF-97A8-76099F73ABDE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그다음\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C16ACDE9-3665-4363-9987-9D2C88603BAC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그다음\" (sau đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("14515F57-A2DF-4F3F-9C6B-45B7C8000BD8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그다지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FF67181E-7812-4D9F-B09A-1A8CF76E8535"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"(không)...lắm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A9E3E6BA-755F-4A6F-8531-8F7234D23821"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그다지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1930A4EB-C69A-4B27-AC51-85134D0C7638"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그다지\" ((không)...lắm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("414B33DA-504B-470E-895C-F35244E20A3D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B8476457-19D5-49EE-AEA4-80F684E7D0F8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cậu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4A1F573E-34CB-40C3-9293-3C93D2EA7206"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5584E3B8-32D6-4C62-8094-FB507E823B11"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그래도\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4EEBCFAE-3354-44E6-A97F-3901A06A90C9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"dù vậy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("55182926-6D57-4BDE-8BA0-F5B4EF88ADD0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그래도\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3DEC0D1B-8E76-44A4-8037-E1ABA7345844"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그래프\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("929CE9B9-0E69-4C91-81CA-71670A5C42E0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đồ thị\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FAB8823C-0BC6-4A77-8457-4FFB7C48CFE9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그래프\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("671D51EC-C0B2-435E-91EA-5F8DE95E1A71"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그래프\" (đồ thị) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0B29B755-5A66-452B-9B23-67E8487D5727"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그램\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6394E6FE-86B3-4513-8A2D-210AEF86FFCB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"gam\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("28E708E6-D40C-4FC6-BD77-0EC373D96190"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그램\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F40AFA65-2C52-4E87-93E6-D8EA5FB97C3A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그러게\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("61C43D01-6A76-4CE0-BE6F-C6184D890C79"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thì đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E9A48597-F94E-4CEF-BFEA-4AD867064EF1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그러게\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C62AA242-6D0D-4B23-A9EB-0984DC1EFC2D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그러다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DD63C578-5DEE-48F3-B6A2-97188DE5F10E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"làm như vậy thì\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D493DD4B-3864-485D-8BEE-ED6B0F30384C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그러다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7990EEBA-ECEA-4E39-BD0E-DE8CCB400FC9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그러다\" (làm như vậy thì) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F43CC4B5-ADA9-4D52-8A30-65BBB04A1EDB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그러하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4BEAACED-0718-4611-B3AE-2512EFE56BC2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"như thế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4B41391E-E956-4CCC-AD89-02B61BCA6312"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그러하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D3F8AFDA-94A4-435B-8D72-A1B9C9D5792F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그러하다\" (như thế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("38EF656A-2067-4769-8AA0-ECB335296CB5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그럭저럭\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("00EF7D88-A105-4C7F-ABE0-2AFE1DC2A9C5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đều đều\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("30BC561B-5B10-4B7A-9B47-2A452AB2113C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그럭저럭\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B346CE64-B2A4-4848-81E9-43E3B747D4BD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그럭저럭\" (đều đều) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0B79929C-2266-4F4E-8143-5429BBFC0D0F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그런대로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("55E098B9-2A25-4082-9E3B-29B879C5A51E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"dù sao\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0890C06B-9E1B-456C-9058-2DA4C6532F13"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그런대로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AB25C383-E142-4DD9-B31E-462A7851CBAA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그런대로\" (dù sao) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("60B24B16-0200-4248-AC73-207289646676"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그렇게\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7410F2C2-7CBE-4556-A005-F9B251FBE205"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"như thế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("51C017E2-8C13-4BCC-8403-93336A84CE55"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그렇게\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6102031D-F544-4AEB-9C57-CA05E0386BF8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그렇지\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("689B27A2-D43A-40E6-AA3C-75DDD9A70DF8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đúng rồi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DA466792-EF93-486F-81BE-592287CC79D5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그렇지\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1D4CB3C6-6F75-47A9-AE1E-0C9B1E244896"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그려지다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2E6DCBFB-8D98-4A8D-8651-41722EBBD523"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"그려지다\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ABEA480B-64C2-48E9-9027-23C7772D4B6A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그려지다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5064A172-2660-4239-AB98-4E932F6B362D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그려지다\" (그려지다) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2E40CD12-9A01-4776-939C-3F8A628D8A9E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그룹\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("25226DA4-5374-4931-9DD3-18CC323B3A20"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhóm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A527DEC3-B241-4A5E-9663-E0BEAFCC6220"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그룹\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("52C17B8A-9B04-4FBA-9ED0-1C14FA41F929"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그룹\" (nhóm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3300EE40-7061-4B65-B088-B9C100ED1B76"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그리\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED4559E5-7772-452B-ADC0-FDAB212250C4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chỗ đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B05453E8-2DF7-41ED-B4A5-57DB66614934"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그리\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C2DFEC07-7FEF-4295-8753-1441CBE01BFA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그리\" (chỗ đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F481147-29C8-4E3E-9631-39C5A12CC04C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그리움\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("660E68E1-ABA5-4634-A356-3590F7725906"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự nhớ nhung\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F9082353-77AB-4AE5-A812-DEB17A1E1257"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그리움\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("141801E7-A6AF-41C1-85D9-3B1DCBA426C8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그리움\" (sự nhớ nhung) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("64385A80-8161-429C-BD35-E98BD82DDFCF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그림자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0992D80A-507B-4A5D-B032-9A334819FC03"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bóng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CCD4B86D-A406-4AB2-B49E-568DFBA69022"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그림자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("09E688D4-4A5E-457B-A337-7E954369F8AA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그림자\" (bóng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("985BA37F-2F84-40CA-B092-44C0FF6729B6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그림책\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C7FC831E-DA17-4D5C-96A9-EBB3B2E3F368"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"truyện tranh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("05D60D51-70BD-4515-B5B2-5CDDA6FC2C53"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그림책\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B9366DEB-0607-4A10-89BC-9EBDF01E4ACF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그림책\" (truyện tranh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CBA864A3-8376-44E1-80B1-F4A09C3ABF16"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그만큼\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08450823-688A-45BF-9289-444D10CE9630"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chừng đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3AD886BB-EF0E-4EB6-AAC1-0093FCCCAB0B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그만큼\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FAF498E1-9A23-4433-A783-EE46ACCB9243"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그만큼\" (chừng đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2335EE2-9E30-4433-9FDD-44D4F601D9D3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그만하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("148AC5BA-6572-446C-9DB8-2244D2925FE4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngừng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0817FDAD-334A-41EA-B85E-64F3288DCBDE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그만하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("161C8EB4-A1AF-4CDE-A29C-31E609CBFB6D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그만하다\" (ngừng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D21E30A7-5146-4CA6-9D79-850F15DD4263"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그야말로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1EEA047F-FCB8-49DA-B721-DE054E2845E3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"quả thực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("68FDDFDC-9245-4E11-B63B-0E4B07EAA3B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그야말로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4005A4A8-257E-4AB4-AA6E-0517DE19C453"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그야말로\" (quả thực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3D1DA2DD-0CAB-4FBB-A15D-3E4A3463F372"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그저\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33F3CDF0-1E35-472C-B2E9-C579EA85A163"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"suốt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("40525BDE-C6E4-4BA3-8568-4C0A45513FC1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그저\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8A241E9E-12AC-4FDE-9062-46C11AEB3649"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그저\" (suốt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("194C8C2F-3381-4A09-B00E-DD21E0D4A9A2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그제\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("578E1A32-8583-4E1E-968A-4068CD925F31"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngày hôm kia\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BBC55DB4-80B6-4CE9-BF50-ADF4D6298D29"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그제\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F3332237-1708-4955-B2EF-D314B0434AE0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그제\" (ngày hôm kia) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C6EF66C0-9302-4DB0-A2AF-ECFF8B209AFF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그제야\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1AB586D8-D74B-4B7F-BB38-BB6C0CC8646D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"phải đến khi ấy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E6BEEF86-97C4-4C47-BA70-4460E74F1C70"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그제야\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7D486BBB-BC2F-4204-BFD7-F16FFDB09656"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그제야\" (phải đến khi ấy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("83B2587E-9221-4702-A469-A7C4DBD7C0CC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그중\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F0DC09BE-6D9D-4755-9692-8805372C72F4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trong đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DF233029-16ED-4116-AF23-B84BC9B4B012"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그중\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6536BE3A-36B4-4D1A-94B7-4C24BA4527D4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그중\" (trong đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4439A6C9-7A66-4E44-A599-808AECB08FDC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그토록\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D25E5CDD-7015-4B66-B34D-78591DDF67B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đến đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF843592-F0A7-4469-96CA-135082CE3798"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그토록\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CB77A901-B364-4030-9D75-D028B52A182C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그토록\" (đến đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E4C66C80-7AE2-418B-A764-ACD0B9650A48"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그해\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CEA7D18D-9659-4165-998C-1661CD156912"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"năm đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("957D4A5A-B49C-4E9E-88C6-CA765B50080A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"그해\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C8FCFB70-B1A7-4400-B0C0-9628AC96290A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"그해\" (năm đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3F7A07A0-AEF2-4682-A6ED-CBDDD46FF3E6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"극복\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A91BAE5D-A53F-4B49-B796-34AD9FBBC026"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khắc phục\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3BE66E19-5000-4AD8-AA06-1A36334876A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"극복\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("313E2EE6-59E9-4206-914B-95C4E6F4ACA7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"극복\" (sự khắc phục) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F8C2E06C-C027-4F55-AAAE-0F69ECB928C7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"극히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E0C0072B-36CB-4ABE-9378-D9C27B4A6E48"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cực kì\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("77C47D2C-9E43-4593-A58B-89AD6C3CB523"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"극히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("51D8527A-8635-4613-AA70-3354FE73D9B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"극히\" (cực kì) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("68EF9F0A-3B57-4448-96D7-7730C80D7352"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근거\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1E6D021B-0401-4CA5-BF28-16210A5E0966"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cơ sở\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("84B44E73-9E9E-43E7-894D-A577C9805D5B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근거\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C8EB1177-F358-4604-8DAF-9C227F8B985F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근거\" (cơ sở) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CEEE9146-E73B-47D8-8B0B-80B4F7BE2100"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근교\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("742D043C-FEAD-46FD-ACAF-A8959D3C6186"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vùng ngoại ô\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C27B720-E641-4743-96CE-4C515B6F1360"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근교\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2FB0069F-BE32-40D4-AA9E-22DE7E88EAFC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근교\" (vùng ngoại ô) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("258D0352-21D8-4396-B1CF-2B2BDDD9F610"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A81FD5AC-70D1-4BDF-A29C-82B32B47FE98"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thời cận đại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("66F1CC95-2C3A-4A34-802C-C7BF5FCAC51A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("81ED4134-1B45-4D7E-B633-30EB013372AA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근대\" (thời cận đại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("23055235-9DF1-41DC-9718-F05EF271DBE0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근데\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E4E2293A-4022-4C7C-981C-95A9139EB2F5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thế nhưng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5D962E68-E908-4692-9288-02E953CB7750"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근데\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("966FEDA1-E120-407D-9287-CF1FC32C6665"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근데\" (thế nhưng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("85617B16-E842-4F0C-95B1-31EC34BA2B81"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근래\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C87BF3C7-77AA-4639-B037-7B2069750BB8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"gần đây\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FB8F7102-63DF-46EE-9F80-78B3DC29645C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근래\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0BB3DDA5-438B-4406-BB07-663BC70B057F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근래\" (gần đây) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1DDF2FF1-5AC9-4A25-9331-405318D02824"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근로자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("241BAA62-79A8-49F2-882D-FBCFB78CF84F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"người lao động\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CA27605C-FC20-4F62-9A66-9499687FC371"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근로자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("66A53AF9-D058-4B1E-8669-123FD7F33EB1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근로자\" (người lao động) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("95B723E5-E17D-4022-8351-69E6A2FA81AD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근무\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33FC7A33-4163-42B0-B715-EC922BB22EB2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự làm việc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9036E050-7E1B-4138-83B7-0C4185CE2C05"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근무\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6E219705-A6DB-4ADF-93A4-CE283204AA8C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근무\" (sự làm việc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("755A18CB-1F9A-4C5B-A725-2AB73138B153"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근무하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A6863A31-5148-4AD5-9DD6-08BF04328F01"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"làm việc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B949ABD1-CCD0-4B11-BE03-0E5BAC778A0A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근무하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F8CE9876-FBF6-469E-8808-2B11A8B980DF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근무하다\" (làm việc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BB8C3282-FE37-43F0-9288-EFE9C872CCFB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근본\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B458B258-3EFF-4267-8978-3459CB72BFC1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự căn bản\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("74E85013-5BCD-4977-912E-9BE41FB49DDE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근본\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("333677C3-8D12-4D86-9325-0311D8EFCC3D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근본\" (sự căn bản) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F632D562-7C5A-48ED-BF16-B0F51F2E6A95"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근본적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6811CD68-6546-4BF9-B6DC-A3698B806272"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính căn bản\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("88C7F68F-86A6-4E84-8B43-5E4FBFD33486"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근본적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3744701E-E135-407F-8911-09DFB12CB19B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근심\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("297DAB06-EC91-4BDC-A916-1180D419947D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự lo ngại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6916785A-F514-4E21-B5AA-5740AA8A1690"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근심\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B53B471E-D184-4166-B71F-BBD90060FE99"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근심\" (sự lo ngại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("45CE97B6-B5D5-4692-9074-562AB063351E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근육\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7FAC9115-DE72-4FD4-A590-3DB55AA74CF0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cơ bắp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("865C3ECD-8E70-4223-B28E-149B89E1C2CF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"근육\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("684DB008-3C0F-4391-B4E8-2927E9DFF405"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"근육\" (cơ bắp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F06541BD-2825-4414-ABB2-019A63D2461E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"글쓰기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A3899D50-6259-4FD1-966D-E491EF3F6402"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự viết văn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E6C2F0EC-AC8E-407C-A38B-491E35A8B28F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"글쓰기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1F4E6F80-042D-454B-B397-323BADCF6C97"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"글쓰기\" (sự viết văn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("481B3462-4F5B-4C26-8C2D-BCB1B8DA14D8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긁다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EBEB6E3E-8A7B-44F7-9868-C263000BADED"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"gãi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("394313F2-578F-4A27-AA6F-8944C8713A95"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"긁다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3B6F949A-D256-4477-BCA4-8B3B958D9F00"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긁다\" (gãi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("850B476A-91C2-4AC7-8A31-FD3E55FF754C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("98F69500-1600-4C88-A09A-03E9D7268735"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vết rạn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E02AA5D8-13DD-4BFB-9DB5-23921BD521A3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"금\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("663BE0C5-B86C-4479-BE72-EDE29FA4DC87"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금\" (vết rạn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("969E27E4-7ABF-4241-BF58-5DA5D85AB2C7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금년\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("441C1CD9-3A18-44BE-A733-DF46CC305F7C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"năm nay\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D95A247-1689-4E84-B7D0-5AC124AA3903"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"금년\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EFCADD93-D711-4934-9958-24D7AA5569D3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금년\" (năm nay) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8AA7C6D6-309A-4C4F-AEF2-A213DEEC7EC1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금액\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9112247A-2E5D-4890-B6C6-9364D6783700"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"số tiền\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("09388A78-12BF-4746-94EC-0C9E48353573"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"금액\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6DB35F08-37E0-495E-A698-57A2751A1743"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금액\" (số tiền) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2156772A-D041-4D6F-860F-B15046BB7BAC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금연\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6D65D862-8076-482C-BEA7-BB2AE3E549B8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cấm hút thuốc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AC8EA7F6-2952-49A2-A018-A13CBAB0E667"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"금연\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("68E5F1D4-A86D-48C0-AD40-7D70F5A627FD"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금연\" (sự cấm hút thuốc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("44AFAFBC-0EB4-4500-9291-0F646C2B2DCE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금융\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8CF68B9A-712F-4619-A90A-0E984967F231"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tài chính tiền tệ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5BBC3481-09D6-435E-A6AA-0C1E50DC3B39"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"금융\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5415DE9A-9FD2-4A38-A2FF-BE6462A2B8E7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금융\" (tài chính tiền tệ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A65749AF-F116-4ACA-AA31-87D04D771EAF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금지하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4EB95F63-B75A-47FB-B06B-7E86912554BA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cấm chỉ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("48F7AD0E-8ECB-4E8F-91C1-D048202BCD61"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"금지하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F1C43C4E-0875-42CB-B910-33CC29E66F6D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금지하다\" (cấm chỉ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3BD5ED84-4C69-4350-A53A-21227CD354F9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("02B14297-24C5-4F6B-AD56-64F21990FF80"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cấm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F7C14384-4B46-41D7-9182-48378821D177"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"금하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C7BCC5C5-B8BA-4CD4-A5C0-E6B938DA99F2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"금하다\" (cấm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("72FF90D9-4113-4D13-8778-6C2B5E0FC411"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"급격히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FA55527B-1937-447E-8726-83CA48420174"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách đột ngột\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("24C50AE3-E702-47B6-981C-A61A104F07F1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"급격히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("27D239A0-A0AA-41F0-8866-7D74A9F7B6C3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"급격히\" (một cách đột ngột) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0B4E78E0-C0AE-48D9-AEAA-073A87458439"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"급속히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4E7F8E72-80E5-4A34-A251-D872CC612B41"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách cấp tốc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9B9C07DB-60A5-4C58-9012-B6A452559B8B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"급속히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1FD639ED-2950-4F60-AA71-1FF4EFC0C52E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"급속히\" (một cách cấp tốc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("288EE293-163D-4AFF-8831-21D40EDEC447"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"급증\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("291DC05D-FE47-4736-89F8-227D0666B160"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự tăng đột ngột\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AAF88BC9-8665-452E-A428-6A090C352DB5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"급증\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0958AE6B-3189-4A2E-A14E-DB258A6157F8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"급증\" (sự tăng đột ngột) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("26D6D580-B5B2-45B2-B2FA-39B9F968174A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"급히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E221707-0A19-4467-81ED-80A2A5E44521"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách gấp gáp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A28388BF-2DE6-4C15-AF59-1092369C0DE8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"급히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4AC36428-9B2E-4F05-A399-E3E0048CF943"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"급히\" (một cách gấp gáp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DABE8A82-F1E9-4E57-AF17-210105EEC00F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긋다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E5C705B-E9B0-4FC6-A20C-E6AC919FF57A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vạch\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("56CD7111-E8E4-42C1-A493-71BC03AED623"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"긋다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3B8826C9-D5C4-4E10-B0CC-D2C9A0B3F098"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긋다\" (vạch) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("16C6E13F-1C5B-4A02-9397-EDC40128C808"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긍정적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB71ED01-C45E-485D-BF58-11DDFA2214F4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khẳng định\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("46181AD7-C431-481E-B560-0E57BF899064"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"긍정적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DE8FD9F0-7420-46D0-9F72-D9DA096E5A3F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기계\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("64FACD86-8800-4B14-8E6E-B68501301994"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"máy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9B4BC465-B248-402F-A149-23CC0C209AAB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기계\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2B6B9670-738A-4A2A-8C31-FE298DCE410D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기계\" (máy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9F175498-FB38-4DD2-B328-EC2DAB5CABDE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기관\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A31012C4-E5D3-4203-83C6-24E02B71ADCF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khí quản\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("56D6AFED-A00C-4452-A38B-1DB818A6188C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기관\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("655DE1E5-E856-40C9-B553-A07ED9502726"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기관\" (khí quản) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF2A698E-CB90-4EEC-8ADC-1D320D33A3A2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기구\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0A73A9C5-F559-4EDB-A183-13C9ACD39F0F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"dụng cụ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CC11877E-B9B9-4BB8-9C43-DC2BDAE45AD6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기구\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6D8C8DDF-A2BE-42E4-883C-8E8D9487C3A5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기구\" (dụng cụ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B12452E3-E8BF-4D4C-8166-30FE10DE751A"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기념\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1148C353-5168-4723-889D-EE361FAA41D3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự kỷ niệm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0E941E36-B9E1-4205-A881-FBC194F315FC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기념\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F46FBF90-F947-4E42-89A0-83F40D521E40"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기념\" (sự kỷ niệm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FD35998E-7906-4EA3-BA36-77CC58B8FDB6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기념일\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A0242D0E-822D-4978-AB20-1F69525DA320"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ngày kỷ niệm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ADDE0605-D1D9-43B1-A2AF-18ADC1EAE30A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기념일\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E39131BF-F704-4882-967D-1212BC40980F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기념일\" (ngày kỷ niệm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E9C5AA9-9FB0-4B61-87F2-66B37CE0FF4F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기념품\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("54B71340-2857-420E-978B-0FCA32F91DA3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đồ lưu niệm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("048DFDDE-5204-4F76-B88A-9FD4582CC494"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기념품\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DD39FBB0-7222-4996-95E0-65FF503DB646"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기념품\" (đồ lưu niệm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7E138D93-14FE-4970-AAC0-60EAB0D4DED4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기능\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3E9D918E-C70A-4A10-B734-7901D9678D18"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kỹ năng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D00F7ED3-2744-4CD4-B4E2-84DEC37F9CA9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기능\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3DED96AC-D3F3-431C-8CD6-EE1922D8D129"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기능\" (kỹ năng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1A6F2C17-3560-4749-B914-A773C774AB00"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D2DBB2BF-74A4-45DE-B4E1-4373ECC34CC4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trườn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A625221C-859C-4457-BE06-FE47E8D6564E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6022A39A-AB6A-44FF-84D9-157C2CA8E734"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기다\" (trườn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4AE0E1CD-4535-4139-A4A0-674BC816268E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기대\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("66312CB7-9E0F-4204-8093-568D09AAF7E3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự mong đợi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("44822C78-BD16-4286-8D29-CE51FB26F3F5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기대\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("848D9187-2AB4-4661-89D5-DDBC14727CFF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기대\" (sự mong đợi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10351BDA-4FB5-4F96-9699-56FD3FD000EF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기대다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BF3A7C1F-0109-44F6-B172-C4DDD292B2B4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"dựa\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2239140A-DFF0-4F5F-A595-88E074B88D08"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기대다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8BA66F59-929B-4A38-8530-56990210BF9E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기대다\" (dựa) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F4824E1E-2E03-47C0-8C6F-9B31320FF15E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기대하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1051F470-0DB8-4358-8D98-F18678628697"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"mong đợi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FC78AF07-2E89-48CF-837A-FB8B8E3CCEE8"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기대하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A3221AD2-F86D-4F5C-9F4E-A1FB8957D7F1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기대하다\" (mong đợi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("02C2BB0C-1C4F-4101-994A-AD5B10128BDF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기도\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9B27BE96-8871-470A-A045-462A75E7EDB1"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự thử\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("76589A50-4C48-4E1F-86FF-84774EF29B8D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기도\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7BA74604-4695-4493-9944-67E9846D9217"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기도\" (sự thử) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7BD1651A-BB8F-49AB-ADCF-71500EDD1C98"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기독교\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7DE1681D-FADF-4FB7-BB09-DF2B2EDE7512"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"Cơ Đốc giáo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0B0C29C5-7833-4253-97B8-BA325A3A1F98"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기독교\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3581FD16-419E-4FE4-8F28-DCD45A796C9E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기독교\" (Cơ Đốc giáo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A110E231-598B-47D8-B888-6E904FB86AB5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기둥\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A73E52C0-FFEB-44E6-95D9-C304D04818C4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cột\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9E319574-4DE8-4598-9A4D-E664F39AA6EB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기둥\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("96AF3DE7-DA85-4B1F-993B-124B17DF534F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기둥\" (cột) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("01E990C3-2919-4094-9444-110DE5453B7F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기록\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B988292E-B4C7-4D57-B63F-E9F7EF9E4A4E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự ghi chép\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("640181DD-1D9D-4B21-89B6-EB2BFCFB7913"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기록\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("03434F4C-F3FD-48F4-AECA-E70DB68C4F10"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기록\" (sự ghi chép) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("71137951-9778-4FAB-BDBC-2CDC3392B89C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기록하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A0A758B3-4A0A-4FD2-B96D-236A932717DB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"ghi chép lại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("742F7182-9E5A-46BC-9599-ADFDF40339D0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기록하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("20D3D079-07D8-4013-A9DE-062062679D53"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기록하다\" (ghi chép lại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AE4CD015-906C-4F4A-9C68-B4BD1B3E82D6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기반\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("52F1C7AC-4FFE-4CD1-A334-B0B88CE881A6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"điều cơ bản\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C776FD15-679F-4DC5-8BA9-66DEDE8BBF75"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기반\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EDEB4777-A74E-4896-A2CA-CA42660936A7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기반\" (điều cơ bản) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF61A1FF-CB74-423B-B1A6-096E21108261"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기본\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("98522C1B-6037-40A4-963F-60C8D6B615FC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cái gốc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("145F06AD-3D05-4176-A589-A5926DDC17B2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기본\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BD5AD8D9-C7BE-4599-BE4E-0F2F85FC76CC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기본\" (cái gốc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("89312802-36A7-4301-B2C8-A9969BAA94E6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기본적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3FF715DC-94FD-417F-B1EB-C3F3C6F479C0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tính căn bản\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("26F284CC-B70A-49F8-9549-4329504F4B11"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기본적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("72CA4A88-8DEA-4676-8FDF-8F33664BF642"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기부\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8EEEB6B9-B4FC-4E29-9272-C65DD0343C1E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cho tặng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C5520D67-13A0-43E8-9B58-E3C2A1879D34"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기부\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E3034ED2-EC9A-4552-8846-4E1836E8AFD5"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기부\" (sự cho tặng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D7B52547-A11C-4DF5-83DC-93B089D3F865"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("175D5E27-8A98-4D55-A32F-A28BC79A761E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"người lái xe\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AA336E0D-14DD-4F80-9EC3-94317E4B18EB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("130E025E-2DF2-4EF1-912B-06C803BC5D8C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기사\" (người lái xe) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A62F8B16-30D7-449D-8EF1-C6D8397898B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기술\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1E7D3678-76A7-4B01-BEAA-67CCF8F784B7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kỹ thuật\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("525AC497-E163-4D96-9351-5579401D8356"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기술\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0487B33D-864C-42F5-A5D6-BFDE44F55346"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기술\" (kỹ thuật) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BA893678-8E66-4925-A190-76CAFFED8959"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기술자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C7391150-40FC-4EC2-AB82-96C419E65DEA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kỹ sư\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1BEC6117-5D88-437F-8B18-2F1264B79458"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기술자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EA206A81-3D27-41F6-96FF-DF12E48CE688"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기술자\" (kỹ sư) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C9C4C79-F062-48D8-A77A-043F7AB2D4C9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기억력\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6C949938-953C-406C-9F64-38D4E6F0EB10"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khả năng ghi nhớ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("33533773-0E20-49F9-A099-B8D258AEA906"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기억력\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1D3F57C2-F24D-4AFB-9F38-3A86B382E25D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기억력\" (khả năng ghi nhớ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A59E3D29-B5EB-4279-8AA4-E0A5463F3A2C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기억하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A914D448-A19A-429E-86DD-FDE65ABE21AA"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhớ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4BB9653F-9D7F-4140-8BFC-FB43D6668CE6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기억하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8E533E92-2BCE-4DD1-91CF-82CF10538221"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기억하다\" (nhớ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("44455347-BD6F-4E72-BF99-8FADEFDA8969"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기업\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0F9C4B2D-E202-4987-BC18-BA17C7DAC438"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"doanh nghiệp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5B95BDD5-7AC8-4BA9-9444-9726E007E44C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기업\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A783BED5-3B6C-46C4-A40F-72E93F2A7642"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기업\" (doanh nghiệp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C8A9238-2E7A-4B74-BCE4-D05E3C4BEA60"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기업가\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1BCCA542-DD3E-4284-B200-2FFE60E1B3D0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhà doanh nghiệp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0619899F-18DD-4F11-8478-A70C1F3DA5F3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기업가\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("00E4FF74-6B9A-4898-9610-00D0C30614F6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기업가\" (nhà doanh nghiệp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF409622-B43F-4DA8-8AB0-7DA5F95E0AE7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기여\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BB4B0464-6153-40A4-8F0E-A7AE9B0B05F6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự đóng góp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E3C89D99-762B-4126-9FA0-90DB6CCEEBFB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기여\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("445A2E91-C943-4DD5-A655-175D094F112B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기여\" (sự đóng góp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("32E2677A-DEE8-4A64-997E-30431B764186"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기운\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9190F876-8845-40FE-8E82-02685FC7E22D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"khí lực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F0B34DE8-6B91-4AAB-854D-A8BFD84AA133"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기운\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8C819077-EFC6-4BF4-A8C9-5F6E0D1EF6F1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기운\" (khí lực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("053319DE-EC59-4B13-8414-28F6FF93C59C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기울다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C61F61EF-A7E2-4D88-993C-5EBF211696A5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nghiêng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C4962BD3-FB79-4564-9824-A11128685063"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기울다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("60C75B11-1201-42DB-ABF9-7F54E4F083BF"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기울다\" (nghiêng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E754BA3-2875-4559-A1FC-1F12FE009B39"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기울이다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9E1CA749-BE8A-491F-A972-D1DB54C50B6C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"làm nghiêng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D5A3B89-726C-418A-AA93-C5D86BC91C22"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기울이다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A68F6AE9-9C54-42FD-8F04-8CF2F371EFA6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기울이다\" (làm nghiêng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1D02CDCC-0B1C-49FD-93DE-5DCED064DCC2"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기원\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("30E331FC-8C33-484B-83A6-9407363934E3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự cầu mong\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("76B3B8CC-454E-4DE3-B42B-B6AD6425E567"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기원\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8FCEC13B-5154-4271-B3EE-7F03F4DF10F9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기원\" (sự cầu mong) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3733DCC0-52F9-49F5-BA9E-CC43C3A8DA63"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E4246B05-39D2-486A-94D8-89C19AD305D6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kỳ tích\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C669800-9A1B-4D9E-ADD0-D89A47181206"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F0751A1D-B50B-47D2-AB7D-14D2849294B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기적\" (kỳ tích) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FF83E8DB-210D-4D39-9C1B-A02B4993C367"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기존\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("269763A5-2245-4FA3-8976-52EED8FF4BB3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vốn có\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BB721426-FF65-4F9D-A0A4-F8C8DA739B0C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기존\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2C8DEC5E-2C1C-4934-A5A3-300F6214DBD7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기존\" (vốn có) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1D8F43FB-9EF0-45A1-8D22-4024A7435E4E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기준\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ABC21EB1-7706-42C9-A5E2-E1E088F7FC6E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tiêu chuẩn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("586D8CF6-A0AD-40C3-8614-5CE73C6E8901"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기준\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0753CEB6-6927-4227-B0EA-912F6D9DE881"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기준\" (tiêu chuẩn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FEDD1F6A-F7E2-47AC-831C-C99EB16F8358"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기지개\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E56A5F0F-55F1-49FD-BED5-A0BB9029FFC5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự vươn vai đứng thẳng dậy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("13BD71B0-A788-4905-A12F-DDF6B6729EE3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기지개\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A5432BF7-94B3-4DDC-8A6A-6C48AEE84279"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기지개\" (sự vươn vai đứng thẳng dậy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AE349718-9B99-42DF-B5D3-DA3026E66269"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기초\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C3780867-2BA5-45A1-92EC-C5A897B23A5B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cơ sở\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("795DDB7E-5EC9-413B-8F2C-06F08287D677"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기초\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8D9217AD-542E-409A-A3AD-13C9E08A010C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기초\" (cơ sở) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7FBF7E18-44C4-4F3A-A999-2761B74FE169"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기혼\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8A4CE854-78EF-4CE5-96EF-E8A59D42637B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự có gia đình\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1197F474-8B2F-4C0D-8593-1717932394DB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기혼\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("ACC980A1-95E3-42EC-8B47-C22FBF311170"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기혼\" (sự có gia đình) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C5327C7-FFC8-4286-AC0C-4F25FB2B5115"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기획\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F7E8B41B-D4F7-4BE6-AD4B-B2A1EA4029C2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"kế hoạch\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AC0BAEC7-37CF-4678-8DAD-5EFB66DFA84F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기획\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AB888556-FFAC-4A64-BE19-99FD1E713070"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기획\" (kế hoạch) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("69DA8E33-6BA2-4BFF-90DD-6560CF45B627"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기후\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9F0C3379-800E-4FE7-BB84-30F30E2B7DB9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"thời tiết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("25F34EB3-3455-4D92-81E0-FA988E893CFB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"기후\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AF01F8D8-887C-43AD-868C-960D2B992EF6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"기후\" (thời tiết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E00E3DCA-720B-49C0-AD64-E05F403BB0E8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긴급\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9BB5D861-4297-479B-A8BB-F201CF2344C2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khẩn cấp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C1A6D8B1-7F92-4264-9DE5-FE86E4975627"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"긴급\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0EED2B93-968A-466F-B0A6-EE9C645E0BE3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긴급\" (sự khẩn cấp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("531E6838-60E3-4440-94C7-A77B992760F0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긴장하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FA569A12-2A13-4536-B959-8DFEF3724955"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"căng thẳng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5478D96D-8F65-4B20-B795-B937706B03A0"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"긴장하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("10322054-2220-427A-962B-3511B97126B6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긴장하다\" (căng thẳng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FB96541F-241F-4C09-A5E4-C9E8D75E4F7D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긴팔\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8B830A9A-2FC8-44F5-A0EA-DF7069241202"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tai dài\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("63274AD2-C50F-4C78-816F-215AE71885E4"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"긴팔\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FD0A42C5-F8EF-45CD-8D90-723D72777E6D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"긴팔\" (tai dài) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2DD2A0C6-DAC7-4A8B-842E-FE7D3E85D1B9"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"길가\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("250D23DF-5215-4BB2-B5D5-1364BE2719BC"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lề đường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8DF93561-1523-494C-995A-D9DED40B56A2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"길가\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8B9A6200-91EB-4D80-8544-0223482BCEAB"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"길가\" (lề đường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4BAF1994-FF31-485E-8206-225C61375C1B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"길거리\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("95214D03-C54F-418C-985B-1561366228BD"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E46F0CD-53D0-4F87-8EBC-F6C298ABA7C5"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"길거리\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("45BCB3BC-7D42-47AF-B756-546A8E65B1DE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"길거리\" (đường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("17003804-678F-4F9F-848B-FF2A7137933D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"김포공항\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("27E5F374-F154-4ACD-8456-2A3CE6F87430"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"김포공항\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("247C5642-086D-4AA0-9834-9F3C61120D2E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"김포공항\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5EDBCCE3-B02D-4026-9E44-095E0105A288"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"까다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D7B50804-68F8-4A2B-BC74-05358A1C602F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bóc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("63AD7C59-359C-459E-BF5C-43659AE08079"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"까다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("80C241DB-8235-408C-9929-B8F1D7E82CA4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"까다\" (bóc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2B4F73DA-81F9-4D02-8DC0-9FD32519DCC1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"까다롭다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("88003B4F-816D-4930-A6F0-B060FE31784E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cầu kỳ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BCE4F1EF-4DBF-42BB-87B2-F4233E0D867D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"까다롭다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0F2781C2-AC64-4875-8B88-BA825E0E6336"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"까다롭다\" (cầu kỳ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("48C17ECF-C5A8-4DCF-8016-DE3D947C82CA"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"까닭\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A542DB94-5F37-4DCE-8A9F-4027F15D5DAF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lý do\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("398F4ABD-A6A4-48FE-9D08-DB39CF60424E"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"까닭\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0D94E274-4D76-43D2-9D54-B157D6F88406"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"까닭\" (lý do) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1B02960C-E1D0-4457-913F-72D9E2D34CCE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"까먹다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CA275B46-EB30-4B70-9D27-9A382666E61B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"gặm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2C6CEC62-9E21-4DB1-B24C-F51D5B9BF4AB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"까먹다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("16DD23CD-420F-46A6-946B-41CA68010D4C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"까먹다\" (gặm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D2C2DB62-47E6-4449-AD6B-8A2C43E0F3E3"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깔끔하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8491E47D-9681-43E3-A749-85DD73D66550"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tươm tất\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A1907B97-0FEB-463B-9637-65DE42441B3C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깔끔하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("73201A30-9FC9-4122-AD25-C01287E11546"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깔끔하다\" (tươm tất) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7832A876-A64C-4E42-ADB7-9270FDFB190C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깔다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DEA983AE-3BDB-458A-92D8-576BFC2CE8E7"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"trải\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E3B9C91-956D-4938-A140-EA60EACBE88A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깔다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F2B6E5C5-5EC6-4A54-8587-D126AC689421"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깔다\" (trải) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3A59EC87-BB08-4137-8484-220A919CC79B"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깔리다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7264ED89-59D2-4F41-A178-D7BF3E5EC99A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"được trải\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EBA643A6-CC21-4287-9F8D-AB841D9E6C38"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깔리다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7FE43440-9992-4202-B4C6-48533305DC3F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깔리다\" (được trải) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6F08D482-0C83-4FC2-85B7-2CBC7EF0FDC6"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깜깜하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E15CEF62-43C3-46B7-8C51-B526EC55BBB2"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tối đen\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E5B4F828-21A4-4D25-8A35-5E8F96B0DFF9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깜깜하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C0AB2A56-746F-491A-9141-98637542EC0C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깜깜하다\" (tối đen) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DC585D75-08AB-447C-8F3B-E7EFB2734EB0"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깜박하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A2D82BC3-B7F9-4557-9A31-1EDBF77F638C"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"lấp lánh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1D5C6466-684C-45C6-B255-4B204BD93669"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깜박하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("77F938E3-C865-406F-AAD4-F683689C9A41"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깜박하다\" (lấp lánh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("67EA13BE-C054-4428-8015-ED04A3E4D871"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깜빡\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7C2E3962-851B-4D91-BA7D-3F663CE7C4E9"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"chớp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9AF8B9D4-8E17-48A7-8851-058C5DF02D7A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깜빡\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0EAA600D-C971-4C03-BB50-989622FF7721"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깜빡\" (chớp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2D860B88-EAC0-4728-9BB0-F31E04172EA1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BEFBBC29-1516-492A-9846-3C1EDF8237EF"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"vừng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F5395EB9-77CE-41D8-BD34-A5CF0270B7DE"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깨\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AE69CE29-F4AF-4636-A347-6AA2AB955F92"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨\" (vừng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E7BCAE4B-1695-4F48-9515-33F87A99D00E"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨닫다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2A025B58-AF57-4857-9CC4-844501347CDB"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"nhận biết\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("61686204-5179-47BE-A0B2-6922FB194974"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깨닫다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7C1B2D8D-6AB0-4F66-8F26-97F26D090DF4"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨닫다\" (nhận biết) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EB6F9CE1-E820-4ADB-B701-AF04B2237BBC"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨뜨리다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7BB06A5A-0E94-4C37-B121-DBB3899E0521"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"làm vỡ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("69FC2A2C-B24E-4564-A47C-D367095E870A"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깨뜨리다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8029B23A-8027-415C-A5A1-A57F0CC78E0F"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨뜨리다\" (làm vỡ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6FA5C5DD-66BF-474D-AA94-EDC352662CF8"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨물다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E1A514E-8A9A-4676-BD93-C610C5E43950"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"cắn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EBBAC10B-D380-42A1-962D-BCB0F0911C1D"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깨물다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6BB7922D-B102-41F0-917C-BB057CBF64E1"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨물다\" (cắn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3B51E20C-ABDD-44B0-9BB9-1B112123B8C7"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨어나다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("80AAB502-4DE6-429F-B63B-9590DB762C3B"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"tỉnh dậy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D7940CD8-E220-47C3-B414-49399368DFC3"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깨어나다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B9AD5BA7-726F-4730-A031-FAC6DC1E7B1D"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨어나다\" (tỉnh dậy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D72E07E2-C685-4E1F-94DB-A5A5AF631889"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨우다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("382660D9-7C13-4E3B-8445-F66BE9943D00"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"đánh thức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF6AAAA2-F750-4237-9A04-EACBFFA47B54"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깨우다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F269210C-746F-4FC7-9324-37D7E8D0D40C"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨우다\" (đánh thức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("87173FD8-99B5-42B5-A720-86507AEF5F92"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨지다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B94D904D-259D-4EC3-95C9-667E9ACE040F"),
                LessonId = AppDbContext.LessonId2,
                Content = "Từ tiếng Hàn có nghĩa là \"bị đập tan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6EE342D6-9304-4E0E-929D-4A3EC765DDB6"),
                LessonId = AppDbContext.LessonId2,
                Content = "Viết nghĩa tiếng Việt của từ \"깨지다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("152B6808-DF26-4B42-B297-6B206860C1FE"),
                LessonId = AppDbContext.LessonId2,
                Content = "\"깨지다\" (bị đập tan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10DDE08C-FCAA-43E3-94C6-DAEB252EBBE4"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가능해지다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FA10BFC3-1C51-490C-8FC3-94404EA73B4C"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"가능해지다\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9E7AD9EC-339E-45D7-A760-87F56F5674BD"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"가능해지다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6BB9FEA2-4D17-4112-B6A2-749055A78ED2"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가능해지다\" (가능해지다) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9CD350E2-27B7-4E9C-9D4C-14EEEBE95CDA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가려지다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FC189E43-2F8F-46DC-BFF5-2A74956EFF6F"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"bị che khuất\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B87AB1CD-247A-452B-84CD-7BA816AA8FBF"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"가려지다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DA850282-E3D1-4E77-8744-6C37DBB25C09"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가려지다\" (bị che khuất) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FB54F17F-302B-4BFA-9306-7D6A94D6DA54"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가령\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("147FD9D6-9C57-40F6-8987-645AD549591E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"giả sử\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C2C16A4E-4692-477D-BCDC-2B2CA7D8B0A3"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"가령\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6364B364-EC19-48DE-8F9D-DEE3BD0B0E07"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가령\" (giả sử) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1FAE7592-9EEA-4BDB-98C2-A0FD2937592D"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가로수\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1DEF9089-A9F7-4A49-97D4-4FA1F8936F2E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cây ven đường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("071D0C0E-445A-43D8-A6FC-9530C1C05889"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"가로수\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4E72B5AB-E833-4445-85BA-5DDBCC89877B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가로수\" (cây ven đường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DCC39593-CB6A-4577-BCE5-5E08EFB2AA6F"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가르침\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("83821B6D-2B10-4A21-A7C2-EEE6611126FF"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"sự chỉ dạy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D6E78710-35C8-49A4-8490-CAA7E4A2801D"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"가르침\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1FC9B812-90AC-46D0-A42E-A6B4F359F95E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가르침\" (sự chỉ dạy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F2C7D966-DBAB-4C06-B05E-692050D6529C"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가상\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("02870E25-1741-4C56-A998-58E0E19D17D5"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"sự giả tưởng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C0B673A-4EF9-4587-89F1-12A01C7D66E4"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"가상\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("90E3AF1F-9DE3-4D6A-BE7C-CA21E70F04FC"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가상\" (sự giả tưởng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EFFED1A3-BBF3-41FD-BEF3-D810C14410E8"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가입하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E3EE49EB-E275-4E6C-81DC-22C592C499E7"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"gia nhập\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("89C44718-E75B-450C-9C33-AC0D2DFE3ACC"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"가입하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7D780B2A-1F17-4F57-9E27-EFAA3CB253D8"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가입하다\" (gia nhập) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("754B16A9-58F3-4ACF-8CE5-B7BDB335F732"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가정교사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2427602C-E5F5-456E-9972-D07CBFA4CD54"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"가정교사\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93826CEF-E430-4562-A19A-5DDA51BA0024"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"가정교사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0A34094B-313D-47FC-B034-CB86FBE43F75"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가정교사\" (가정교사) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D0159C7B-930D-4A83-9F41-F4CA2716C357"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93878B37-54D2-4E17-950F-860426277A19"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"gây (áp lực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("87D8C0C4-6B34-41C3-AF4B-87E6D3CFFB7A"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"가하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("26070750-D58E-4D1D-924A-673D5C8B7CD0"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"가하다\" (gây (áp lực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1016C97C-6F8C-4149-BDDB-735F0BF36512"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"각기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A3F14FC3-7AFA-4DA5-96C9-1AFAD3945776"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"từng người\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("197328FE-6CCB-46B7-AF35-5533C22D3854"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"각기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("17B5A6AB-3876-45E8-B772-BAC5B6869808"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"각기\" (từng người) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B9B3643E-0A1F-4EE4-8440-D64A5C92BC10"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"간부\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("025DC409-34DA-4E1D-ADCF-BA59C943041B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cán bộ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("488929D5-6D51-4B7B-B1B9-B510FDCFC0C8"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"간부\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("41F2E535-01CE-4A80-B1CA-5DAA985F68E0"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"간부\" (cán bộ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9CDD0C37-4F84-4305-9909-4DC553736CE9"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"간접\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("139C2B0F-75F8-42AE-8999-627A80C62054"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"(sự) gián tiếp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1BFDB7A9-759C-4182-9F5B-4ADC8D2525F0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"간접\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E1E5A3FF-AB0A-418A-B07F-A4BD7C78D4F3"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"간접\" ((sự) gián tiếp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9D764725-DD2C-4373-8EB7-C48A2F505108"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"감소되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9555FB09-4589-494F-BCF5-D766D6C08FC4"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"bị giảm sút\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9C0C492A-E193-4DAA-8FBE-0A7A7A7C18FE"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"감소되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("68B5144A-0E75-40A2-BEDB-D0F9438065EF"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"감소되다\" (bị giảm sút) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9A5A9454-DF7F-4B96-9435-4AE725C1A91A"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"감소하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6F294681-9927-40F3-BA21-5AA3E88FD249"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"giảm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F215ACE9-F254-49A1-87F0-6FFBF91305E4"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"감소하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("86ECE4BF-A62F-49FB-A519-592F88EE48B8"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"감소하다\" (giảm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6CCAFE87-5025-4913-AB92-11BC7E9EECF6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"감수성\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5C426540-DB7F-448F-8028-6329D98CDAFF"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tính nhạy cảm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5824DBE7-9969-42FA-A210-2A8E4E4DBC56"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"감수성\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CF0740E4-E516-4192-80CC-3554B515665B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"감수성\" (tính nhạy cảm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E06E919-3AD3-44BE-99D0-ED3D62410DA2"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"감정적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8AD4A250-D386-4EAB-AFFB-DBE289B704EC"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tính tình cảm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F434913C-4CE0-46C8-8C65-544BA6C76292"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"감정적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1CF09C68-9911-4F80-8B6B-E64CB65FA677"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"감정적\" (tính tình cảm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("645407CE-B1DE-412F-BF98-FF59ED640218"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"갑\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EC013323-D8D3-4A7B-9ECD-93FB6A8740B8"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"bên A\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1926D589-25AC-4066-9C52-13BA6EF19632"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"갑\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("35C25790-96F9-462F-80C7-229E3A8B2D4E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"갑\" (bên A) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3A4EB334-661A-49E1-B782-BF299C8E76AA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강남\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0FD0259E-2CDD-4B47-8FB6-F3AA9D90B1F8"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"phía nam sông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("17FAD170-BF3B-485B-A3AE-958BB66037B3"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"강남\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AF1BA46D-CE44-4BEF-A14B-2B25D7EA6634"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강남\" (phía nam sông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("14B379F8-E4E8-48C0-B885-2A830CCFEFDD"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강력하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DF4EEA58-730D-4E78-A1E5-725A44E552BA"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cường tráng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("168D7B04-61AB-48D6-BFDC-CADBFFC25D09"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"강력하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D6CECD60-8C2D-4AD4-A950-CA83FD1A16FD"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강력하다\" (cường tráng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A44C0F63-F46D-4F72-8523-9E0B4662B966"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강력히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("570B6094-9014-4C11-9C41-1940A2A145A3"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"một cách cường tráng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("31B6D3DC-2FFC-48C7-B9EF-2E4437B5EA2D"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"강력히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2817B402-55FE-4CAD-A13B-71F6DC4930AF"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강력히\" (một cách cường tráng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93E9AD6B-8221-49FB-B40C-571192BC1751"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강렬하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C05902DF-7CC5-437B-B233-3E2650C97100"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"mạnh mẽ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0B8CA62B-6153-4EA2-9122-E56C8EF7B801"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"강렬하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("99BFBED9-8A49-4FB2-99D7-2681328884AA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강렬하다\" (mạnh mẽ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BF9D4EC0-147A-4E9D-A5A1-34780886846E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강변\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F74C125A-3BE1-4647-8659-5BE03CFFA3B5"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"bờ sông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08124010-E7E9-40F8-AF2C-9639493F88EB"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"강변\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("369740A4-335D-400F-AA55-D69F714FE24D"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강변\" (bờ sông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C932A227-D9CF-4D70-B3E7-60393BD39BDD"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강북\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("08EB5449-F6E2-4D9A-9FEE-DD3CCE75CA34"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"bờ bắc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("396B94D3-5426-4558-83FD-366A75595588"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"강북\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E7F008C2-3924-4F1E-B405-B08200DC063B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강북\" (bờ bắc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C705245D-37A9-42C8-AFA6-30EFC4AC4793"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강요하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F16608D9-82AD-403F-87BC-0301AD6CF296"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"bắt buộc\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C782B064-D801-44D8-8814-60F96091CE15"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"강요하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BC7EEF97-7940-4AE6-A495-7BACA2BA5B39"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강요하다\" (bắt buộc) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F7A4DF2F-79F8-49A3-B78E-D9FF8F21EE2A"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강의하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3890A44E-BD3B-40C2-80C2-94D5EE1C1E84"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"giảng dạy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A6CFE338-55AD-441B-990A-F490DFB78ED4"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"강의하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D6F6E328-82E7-42C2-837B-B0ABECFFA968"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강의하다\" (giảng dạy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C5DE4B17-0D59-4F3F-9461-86232522CE15"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강화하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("090170FE-40BA-4A36-948C-165562183CDD"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tăng cường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("077114C9-E32C-439B-AD25-9CB1F49F5A7B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"강화하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E43C8D4C-823A-4CD1-9CFA-DC203E1959D9"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"강화하다\" (tăng cường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7578B0A5-D880-49A9-A10E-751729DA7C66"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"같이하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("39D1F19B-5FF1-4161-A036-C803D3520DB2"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cùng nhau\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E787915C-6002-494A-BB68-1FFC1F0671C0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"같이하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2B01721F-DB52-45E4-8F01-7D6C386C5E75"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"같이하다\" (cùng nhau) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("322B808D-E594-4A1D-8FF8-62E13849F8D3"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개개인\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4B9727F3-806D-485C-9FC7-D0197277E475"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"mỗi người\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E21B6449-9AC2-4FF2-9984-2A1BCBE99063"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"개개인\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("96E73306-F6C1-44A7-9552-AF790696826D"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개개인\" (mỗi người) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("01F01C0A-3ED7-4727-89A5-736CA3E028CA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개국\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E5240C7D-08B6-4DE5-9C0C-0F380CA2EE61"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"sự khánh thành\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("65337B08-F30A-4A52-8B9F-5CD1C7B30807"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"개국\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("7B7A91BA-6060-4E1A-AC31-7BB23A50C5D6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개발되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("88139B6B-F73C-4AD7-BB1C-DC66CC41E084"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"được khai khẩn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BDC16053-2EFC-42CA-A1A4-1F08A6E68B45"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"개발되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3D095534-F923-45FA-891D-67CA1D4931E0"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개발되다\" (được khai khẩn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("27995543-A96A-4A10-B72A-D07545B499A1"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개방되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A29DBDB7-CDBB-4A5D-AA43-C9429B4733D5"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"được mở ra\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E21D4802-6FE6-48FA-8C09-267FD8CFFE52"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"개방되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9A00F227-6765-4388-8992-1CB4FB66CBDD"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개방되다\" (được mở ra) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("742CEBF1-4125-4F11-9E76-58D99DE5A84E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개방하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FB9F9158-AF29-4ADF-869F-3A09182573D0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"mở ra\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6E21265C-835D-41FA-9D73-2063C404CD68"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"개방하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5C901FF3-9A9C-43A5-8518-5E80C84507A6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개방하다\" (mở ra) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3F00C2B6-9017-493C-B9F8-804EBA27323E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개선되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D81788C3-544C-41C2-9380-9327A9D942C9"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"được cải tiến\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A0ED16A8-5D39-468D-BE65-BDA043F3AF1A"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"개선되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1424D200-952D-4290-AE8E-D1ABA417F3FE"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개선되다\" (được cải tiến) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("082DF645-D22B-4C3B-B316-6C6D113A05C3"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개선하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F199E0E-FC15-4487-A1DA-684A1A942CC7"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cải tiến\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("50BF558B-8FD9-4355-93B6-DDD6F1BDEABA"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"개선하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("C137D695-0B10-466C-B98F-C0211B579BDE"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"개선하다\" (cải tiến) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8B8D56DC-B83A-4B7D-AE6A-DCB6FD31AA40"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거대하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A8B18ADC-FF5C-4CBE-A9F7-C59CAD55CA23"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"lớn lao\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9802BF11-DF79-4536-B364-536D21F5C5F4"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"거대하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2AFE818B-40F8-4270-9F3F-38D8B8B3857F"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거대하다\" (lớn lao) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("01586954-D2EA-4717-81DF-A67190DB5E24"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거듭\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7AEEF291-0978-40C7-B998-A57764F2F34C"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cứ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D3DF0EC6-EA64-4596-AB6B-07A57D1E1A60"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"거듭\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AA04421C-82AF-4F60-BD8C-EC8CBF382D5A"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거듭\" (cứ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("70813C37-AEF3-4A15-A9C9-E361395278C2"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거부하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("75C92FE0-DB22-46F8-9D8A-A93F3C680304"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"từ chối\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1103BDAC-2497-4C56-962D-FC1AADC68F09"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"거부하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6BA58EDE-CFE4-4883-A4E3-2BEFC2A9D238"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거부하다\" (từ chối) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("119D814E-5A93-49A2-B37C-63DA6A069C5B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거액\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2369145F-46D1-4089-B463-34AE1153D224"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"số tiền lớn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E0F55BB-7D04-45EC-B6B7-AE049B8284A0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"거액\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5E49268F-181E-4238-B58F-3EAC1692BA3F"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거액\" (số tiền lớn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EE99548A-8C30-46E6-AE17-DA7CF5019ED7"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거절하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("22AD367A-F564-49B1-8FBE-C3A179D31737"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"từ chối\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("71898428-FC7D-4B70-B978-6206BABD8013"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"거절하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FC2FD98E-4E42-4DB4-BD7A-96725F3642CF"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"거절하다\" (từ chối) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CB5311C8-324D-4B4A-8AF8-8440A365C49E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BCC05AA3-D518-4BFC-8DE7-F59DC35FFD8D"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"vụ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("78308702-E27A-4D7C-B390-DE12D3E6B6F9"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"건\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("74539D8E-9106-41D1-95F0-644C3C27996E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건넌방\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6AC66E42-B10F-4583-88DB-C7526DE7C1C4"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"phòng đối diện\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A972790F-2A64-4980-B48C-51D71E0D472B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"건넌방\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8BB80DBC-B97C-41AA-83D2-FAC0922961DC"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건넌방\" (phòng đối diện) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FD0B6930-C93E-493C-A88D-744CD1C07EF6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건설되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C5EA6811-4E60-425C-97D2-9B77F24F1797"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"được xây dựng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E8899686-177A-49AF-95D5-225F164A46C1"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"건설되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E1EC58B6-D16C-4F43-9782-DD7B0F2BE172"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건설되다\" (được xây dựng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8069141D-ED9A-4D65-8AAC-31F89B024AFA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건설하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ECAC4102-A838-44A5-AD78-763C9536EF84"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"xây dựng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0472831D-526E-4EEB-B239-076C1D20FD2F"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"건설하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("67BCB9AB-1717-476B-BA75-33A198286B8E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건설하다\" (xây dựng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("46F25DDC-C926-48A5-9C3D-2AECD5F927E1"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건전하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D8326738-A33C-4C33-9483-9EDA7D7D0286"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tích cực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("53229136-0261-49B7-8351-57598178ACBF"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"건전하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("CAF076AA-474A-4699-8CBB-8F1F9008D3CF"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건전하다\" (tích cực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("37B6383C-D5E0-4A98-8E5E-525BF53D23EF"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건조하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6EA27FE5-5236-4206-AE81-D0B1521B68AA"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"kiến tạo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3DEC904E-6885-4D9D-9947-BF4B736D88A2"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"건조하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("95BBA0BE-8630-4EA0-8ABB-741BC9FB23F0"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"건조하다\" (kiến tạo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("35B722EC-0D86-4DF0-856D-894A3FECD928"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"걷기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("27D5750C-061B-4A8E-86E7-AA9E4471B026"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"việc đi bộ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EAD46EF0-216B-4B6E-844B-CDAAB7566847"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"걷기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6ED74EAE-1B16-46F0-A43B-BC71A4BBBDA5"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"걷기\" (việc đi bộ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BFBED9D5-C8A6-45EB-B62B-8571421832FB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"겨자\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BA16900A-E53A-4929-B81B-D4A6CE3F4653"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cây  mù tạt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("13233CC7-8F09-4AE2-AF12-32D4424F5A86"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"겨자\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5A86CBF9-24DE-46B9-8C39-B0573EC25C7D"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"겨자\" (cây  mù tạt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("53CAFD6E-069D-4145-A7F8-7351E7F82B16"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"결과적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("54DA13FA-CE3D-4079-8F2C-F0494549E6DF"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"về mặt kết quả\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A9CAC441-4582-42DB-9570-D9038DC91ACA"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"결과적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("D4F93AC3-20B3-4C89-96FE-8F63C62F88EA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"결과적\" (về mặt kết quả) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6DA06B7D-EBFF-48F8-BCEE-DBF4CC1B9FC1"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"결석하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CC8493EC-A359-4D0D-8E07-F14BE902798B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"vắng mặt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EA18392C-1C78-4AB8-AAB3-D3093B23DDA8"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"결석하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EC068799-987E-4E35-B768-9C33D3BC5FF8"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"결석하다\" (vắng mặt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("FFDEF734-1EB1-4B14-8FD7-F54D28C76D0B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"경고하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("39B10E7C-BF91-4BD3-8128-35B779712CEA"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cảnh báo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("124743EC-BB21-4896-922A-37ABDE273FB4"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"경고하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("879FDCEE-00B2-4D20-9445-B33DF97D2455"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"경고하다\" (cảnh báo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("964584D3-1BE2-4E15-95FD-2B5769BB26CA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"경영하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5D383812-C8EB-4FE2-990C-86946D0673AD"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"kinh doanh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3D708071-B862-4D05-A67D-2F755EC7AAD8"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"경영하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("4653FB04-7A2C-43C6-9484-F4D5D30F775F"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"경영하다\" (kinh doanh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("00725B2B-F116-4D9D-9FF6-757AD1393962"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"경제학\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0D865161-818E-4FDB-B9AC-E4195889A2AE"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"kinh tế học\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("51CC62A6-CDA8-4B85-B04D-0ED6E4A3B080"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"경제학\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("76EAF293-3DE3-4151-BBC6-77A28304E69E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"경제학\" (kinh tế học) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0F3E4325-B6CC-470F-83D4-F118506F9B61"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고구려\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9497CD05-48D7-46E0-B470-ABB7751EC679"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"Goguryeo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("04826D1B-E272-46E4-B0E5-98187705131B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"고구려\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DF7774FE-6219-4929-815A-F1FDB984C5D1"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고무신\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("325241FF-AF81-46DC-B2A2-CC66FD621CA6"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"Gomusin; giày cao su\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D5FF5B50-CA89-478F-B86C-1FFB72EE7391"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"고무신\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1AE6885B-9AE7-4D6C-A7F0-806E0C3D4FCA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고무신\" (Gomusin; giày cao su) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4BD5FA9E-0B5F-4B9D-9BCB-B416517DFA0F"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고요하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E9867AC7-CEAB-4B92-8FB5-1D62F607D465"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"yên ắng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("49A1778D-DE9E-48EC-AE60-CEC268BEAAA0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"고요하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5C932903-D638-46BB-82CD-CDA107CB54AC"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고요하다\" (yên ắng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B6C5FC98-4237-4EB3-9AC6-77AD126E6B07"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고작\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6B5FBB74-B00B-4EFA-BA0C-F73BB9AEC7BC"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"hầu như không\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED284C61-98E5-44CA-AF38-44AB15A9F48C"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"고작\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9746688D-2783-40AE-ADE0-5DA39F273DBB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고작\" (hầu như không) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F73223B6-99AE-402B-8C38-6FA1C00FEA44"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고집하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6204C5E2-A1FB-4925-BEB6-EEC0E253E941"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cố chấp\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B07B0ADA-840D-40B1-92F9-2E6FC6D42C1D"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"고집하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1FEBE526-2A5D-4D5F-A7D4-CE1F45EF2703"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고집하다\" (cố chấp) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("126A5FDD-16A8-4335-A9A9-A584E7792223"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고함\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D90F7B76-8908-4B03-91DB-5035F41BD85C"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tiếng la hét\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CE4ABDE3-5520-48BE-BD0D-75E037A60175"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"고함\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("00579A5F-B6F4-494F-852C-75876B9AF549"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"고함\" (tiếng la hét) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AA89CB76-88BB-4739-A5FF-68303DB36126"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"곤란하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7AF4FAD5-0C6A-4497-B83D-2D38995294B2"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"khó khăn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("171CECD7-6BDC-4B47-B703-71297263ECB3"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"곤란하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("72F152F4-0345-4F1E-ADE5-1D304899CBF6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"곤란하다\" (khó khăn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("971C2F61-9390-428F-B931-30957E7A20DA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"골짜기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("702D0BDE-D2A3-4DFE-BF92-757561496C22"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"hẻm núi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("482EB64A-7449-48B8-8222-9B1051F5AECB"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"골짜기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("FC65C50B-7983-41A7-B907-4E0CA7276D32"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"골짜기\" (hẻm núi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DD4B710D-1D11-48C2-8FA0-94FFAF00D3B6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"골치\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A7A599C3-1BCA-4605-80EE-4AD35D33C298"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cái đầu\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B95BD827-C15D-456C-8697-5A90FBDA2B9E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"골치\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("857A0E4E-8F44-4E5F-9304-CE4C9BCFBD4D"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"골치\" (cái đầu) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D715B6E7-7778-4F95-9975-B2CA3F9AADB8"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공개하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E6D1402-A4FC-48C1-A41D-610FD53EE84F"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"công khai\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5848ABBC-4F60-4CA0-A378-18AAFE8886AA"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공개하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E5EF1236-5EEE-4C13-8EFE-577699E818EC"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공개하다\" (công khai) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("49294D43-9334-4426-9F14-726EAAC2F61B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공격하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("22F570B9-CDCB-4C22-A9E9-449D81F1F7AA"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"công kích\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("82B2B39B-25F3-4869-B0BC-C7B829BF4C80"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공격하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6BB8B03D-99B5-40B4-B9DA-DF5D7D6DCCC8"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공격하다\" (công kích) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DE3F9EBC-9A20-4846-8C34-2BBDFEED4362"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공군\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C4ADE329-0717-41F2-ABE9-DDEF2023A101"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"không quân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("54217528-172F-491B-B710-82CD782C5175"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공군\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E8606672-08FE-4919-88F8-97A59155C926"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공군\" (không quân) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6B0C7D44-D0B1-4808-85EF-6C66C998846B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공식적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("39D6D529-A3C0-4018-8346-B7C22EC7C491"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tính chính thức\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A6AF10B2-4BA3-4358-9969-EC0723B07374"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공식적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("318D8DDA-743E-47BB-BB8E-E147D66C519A"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공식적\" (tính chính thức) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E9455C07-8A34-4404-97E0-EE1B18D2F723"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공연되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EF798B9F-F8E3-4FE2-B82B-18E7B0032189"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"được biểu diễn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D6F4C554-3F78-4EC9-98E8-3273DC905257"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공연되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("521C32CF-8209-4997-AF80-6210BDEAD880"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공연되다\" (được biểu diễn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A7A0476F-107F-4E66-93C6-49C780A96195"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공연하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("554B574F-B5C2-4EC3-98B9-3116384BE616"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"trình diễn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("49137992-3888-4BB8-A91F-AB0052F6655D"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공연하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("229C9825-DD73-403F-A953-FBD8667C10ED"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공연하다\" (trình diễn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5AD698BF-72DD-4849-8E94-35F0E33386B7"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공연히\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2523086F-CDD5-44B7-B38A-1041B244B1C1"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"vớ vẩn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("453FB47F-FB3F-4151-AB05-7CA6F787BC5F"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공연히\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("38109D4A-5D7B-4E40-99FD-B18A59722E0E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공연히\" (vớ vẩn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("95B5B26A-006B-41ED-82D8-9D4F71093265"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공중\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("41680ADB-A843-4590-9711-ECE7E82F2F61"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"công chúng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("77AD4FA1-2E8E-4B75-A954-BA4573AA12CA"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공중\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E1237D2C-CAF0-4256-8898-D39994348543"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공중\" (công chúng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7F12C38F-C889-4638-ACFE-26DC73DF245B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공통되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0CDD3A30-C644-46FC-9FD7-B577903EAFD9"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"chung\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("645C3CC7-1E5B-40DA-95D5-164D47C97F90"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공통되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("56DFB7F4-EA55-4684-A4B7-B2FFB4EAE7A2"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공통되다\" (chung) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B6F8D72C-5318-4B3B-841C-6A3DC019A886"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공통적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C69A9BCB-24A5-468A-835E-F9A3A283FB11"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tính chung\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8D5CF234-F68B-47DF-9A31-81EFEEA1D130"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"공통적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("448E8A3D-2C66-431E-962C-851CABB2C0E6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"공통적\" (tính chung) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0BA226BD-02FC-4F74-9AC3-2CEAC232D16C"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관계되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1F97D42D-B7D3-45D8-92F6-C89E1E355DA6"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"có liên quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CA76B29B-DE9B-4813-8CFC-5AAF56373CC6"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"관계되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B97D68F1-1324-4118-893B-82611A6CD2C7"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관계되다\" (có liên quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5E40E359-CF2A-4811-B69B-5E4EF1B4C469"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관광버스\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D7503606-5A1B-4780-86E2-BB062819E461"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"xe tham quan\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7A7DCB25-BF56-4199-B61F-F3A34623ADBD"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"관광버스\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("BE89C7CB-32B2-4733-A54D-7BCCD99C5139"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관광버스\" (xe tham quan) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3C7B5E2D-0514-416F-A931-078B0408A13D"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관념\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AADA17F5-E57B-4C90-BDC3-F055D4307B95"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"quan  niệm\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("56A57165-3152-4F1A-9C68-5EF71DC97F21"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"관념\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F8B724C0-4445-4EDA-8E9A-671619D4288F"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관념\" (quan  niệm) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("84E1AA21-641F-4222-9B31-EA7CABBDD8FB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관리하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BBB42B53-723C-4120-839B-F6E058FA7015"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"quản lý\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("58E11D4C-A968-463D-8AB9-E2599B1B2FC6"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"관리하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("812B8618-49BA-456D-AE96-A450A0400C68"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관리하다\" (quản lý) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("13F3AC52-C268-4D06-B442-5735B5893BBB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관습\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8F317148-1D5C-4DCD-86B3-4F96C3A9CA1B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"thói quen\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9DAF048F-AFBB-4AF4-9649-F36D349534ED"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"관습\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1F0DE5BE-FE25-4434-99B6-2CF3D5A0758E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"관습\" (thói quen) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E5A4184E-554B-4A0F-A964-F3E7B8AB7F0B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"광장\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("32D78DD1-BBCF-4AA4-A3DB-938658631BCA"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"quảng trường\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("523A6259-6EB0-4C9B-8601-42788C29288B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"광장\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("630739B8-BD7A-4428-B221-9B2FCAA32089"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"광장\" (quảng trường) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("43FFFFB7-9776-4D16-A96E-8D274856F1F2"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"교직\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("52110CB3-A6E6-4C98-8778-87C9AC190C13"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"nghề giáo\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F2F1BFA7-4AB5-40FB-9A30-8000C4407D7F"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"교직\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9110F191-4A6B-429C-9FF1-EF4A4F821ECC"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"교직\" (nghề giáo) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ADF45C15-8F5E-427D-8286-E618F077A3FE"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"교환하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("396CDBE7-0D02-40E3-ACA5-3DAC3F49548E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"đổi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DD42934F-4F0E-4D8B-B40E-C7425AD5EED5"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"교환하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("81CCEC39-F21C-4C13-BCFA-289A0823FB36"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"교환하다\" (đổi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("71759CB9-9037-435A-9287-47A5CD36AED6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구별되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("197F7890-EB49-43BB-985C-23BFEDEF6112"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"được phân biệt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A21B9536-B41E-4F59-B3FE-F38A7979CE57"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구별되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F260ABC2-36C4-446A-90BB-12862AD0CAA6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구별되다\" (được phân biệt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("78270A90-3922-4B2B-BC83-8AA74FEF4635"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구별하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8CDCC131-3E03-4079-AFFB-23302E447110"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"phân biệt\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("654B6C17-6439-4717-B0BD-55F5CB484424"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구별하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5FF80340-FE92-4448-B9FC-4659EBBF68A7"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구별하다\" (phân biệt) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A3BAAE13-5D64-404C-8491-367F29BB6703"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구분되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CEE60026-52E3-4FB8-81AC-93823DC08DDE"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"được phân loại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("61CDFD41-824C-4E64-BD53-B3A49D54795C"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구분되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("74E93FD7-67AF-4F44-BBC5-02006D30E223"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구분되다\" (được phân loại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7D4E5C0A-7CCB-4C9D-ACB0-BE8D22AD562B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구분하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("431658B8-B2D7-43C8-8377-F62B946CB61E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"phân loại\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2528B33C-23C2-4732-A9AA-84B30D929084"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구분하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("708540B8-4BEE-42DC-8F42-27074E5BDBE6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구분하다\" (phân loại) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("42FF9965-E2BF-410D-9BBB-C0036244E23A"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구석구석\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AF900F6D-FE57-4BA4-A66E-456208F8623C"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"khắp nơi\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C7A8F6F4-2CE0-40EF-B35C-FBDE0A3EBBDD"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구석구석\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AB3137C8-91A5-4F34-A0E8-2DEC059928F3"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구석구석\" (khắp nơi) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("40331316-58B2-4225-B679-887D6DCE9EEE"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구성되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("422BDE0C-F315-4009-B9B3-66FFEE63437B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"được cấu thành\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9DC9E133-5C39-4064-A5FF-5232F0AE5C69"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구성되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B6464654-54EC-4E68-B4B0-3B76C62A0F59"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구성되다\" (được cấu thành) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6CEB0AAF-92D9-43BC-9126-8F01E0E0FC18"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구성하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("3EB9A28C-20D6-4E0C-82FE-D1C8DA43CBD6"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tạo thành\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F9BD30EC-D6D6-4B80-925F-602A1160C60E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구성하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A483A9AE-2D22-4A92-8291-A87822697BDA"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구성하다\" (tạo thành) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0E52E852-95BD-4423-8EED-90A61126B653"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구속되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D30EB56C-A8FE-4061-91C2-4BEF7E4E94A7"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"bị giới hạn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A5794319-43EB-4BDE-9FF5-9E3CA90E6F91"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구속되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B1F39F6A-84DE-4B57-A9E8-AAEB1D13B87A"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구속되다\" (bị giới hạn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("5D0B604C-BE66-4147-9111-826364DB686E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구속하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("41899EEE-0D53-4DB4-9442-2FCE3879B283"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"khống chế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6692849B-4420-452D-9194-5DE01F2D9601"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구속하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("07E2B85E-DD21-448B-9438-91084E232836"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구속하다\" (khống chế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A5309A62-D0AE-456C-8443-2E171DDA7616"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구입하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4E7E347A-4BB1-4C65-9FED-3F8D23D9CBD4"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"mua\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7745D8FA-446D-4CD7-898C-EAF978A01F0B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구입하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8BE7EC53-4B84-42E5-82D6-F775C0DADD1B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구입하다\" (mua) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7738F754-D4A9-4F54-8FCC-495DFCB3A46E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구청\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1B88F4EB-620C-4CEC-AEEA-5EC123A6E2E2"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"Gu-cheong\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F146898A-AB8E-4DB2-A18E-A1A75EDAA91B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"구청\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("73D5350F-F66B-4B2D-A59B-ECC2EDFDF646"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"구청\" (Gu-cheong) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("549BF4D5-2723-468A-9382-236D64DC4337"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국가적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4E9CF8E8-9CC3-48CA-87D8-FD91BC75E761"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tính quốc gia\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("84A5E7A3-CF10-44A4-94A1-B6D0E3E5CB74"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"국가적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EF4FE757-0316-4327-8938-049355AF48CF"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국가적\" (tính quốc gia) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("79BF025C-AE9D-4CD7-8D6D-2A2D0FE7CD4B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국내외\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("18B5709F-CFF2-467D-97CA-6F75A0B7613A"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"trong và ngoài nước\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("061790BD-7AF6-4BFB-9A91-8E4269CBB1BF"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"국내외\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("51970475-CC46-4292-95CF-A640B9E7FCF1"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국내외\" (trong và ngoài nước) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4AC594B6-8E04-40FC-AF35-0DFD46B1CB8C"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국민적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CC3526FB-D07C-4347-BB79-04DE0B74E311"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tính toàn dân\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("01C95FE6-28F3-40DE-A0E3-63DFE923EA7F"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"국민적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9A76D894-1992-4E8B-8764-FA0E5876CF59"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국민적\" (tính toàn dân) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("25E9EA76-C959-4C06-A1DB-858711ACDF76"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국사\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("86900540-968B-4DC7-A9B3-9BCC24B31CE8"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc sử\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C1A5A4BA-9AE4-452F-893D-E8B0B2D9368D"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"국사\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9DF9E01A-2467-4F6C-B6C8-227A1971E5FE"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국사\" (quốc sử) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("48E06AA2-EB7F-4244-93DE-2E5CE4042330"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국왕\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("66144F17-FD41-4643-B8F4-09256931A42A"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"quốc vương\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A531F1A1-565E-4EDC-A23E-2262542EEE9E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"국왕\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0210459B-FB3D-424D-87B5-FB5645AB70A6"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국왕\" (quốc vương) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A261AA74-DC7B-477B-9D61-98CC87A96E7C"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국제적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9BFBD026-8477-4FE0-A7C0-7700F2477EB7"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"mang tính cục bộ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A5F78AE0-8337-4991-97CB-6CEB64CC8A20"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"국제적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3A0666F1-CC23-4BD2-9C39-2F63E54E4AD0"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"국제적\" (mang tính cục bộ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A1C370E7-3B91-4E1A-85C4-6518ACB3D042"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"굳히다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("651F40F7-1271-43B9-B0A8-A33A7EDBA4F0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"làm cho đông\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CCE281E9-1AD6-49D5-8232-48354F7C3F4A"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"굳히다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("80BA0AB0-833D-4255-BDDF-050A88F85F55"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"굳히다\" (làm cho đông) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BA3ACC57-57EA-4E92-8288-83FA9B9537C9"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"궁극적\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8E0D2514-8907-4003-9A2B-58F0AA10EC76"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tính cùng cực\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F9A2CAC-E644-4E14-A2A3-C3AA5A9B0DD0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"궁극적\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("DB3C5A4F-A902-4585-BB06-B5CF72D054E4"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"궁극적\" (tính cùng cực) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2C59E2A9-4288-4EDF-99C0-0F25F3EF91F9"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"귀가하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9B524787-0662-4992-94AE-8AEACF8E7430"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"về nhà\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F7B6A187-CE1B-49CA-AC5E-48977BDA48CE"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"귀가하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("43D78291-8DE2-44C8-935A-D5CD9355BA5E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"귀가하다\" (về nhà) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6BF41EAA-F4F1-483E-ADDD-B12EFD32CB13"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"귓속\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2C8DAA1-7CCA-4DAF-90DB-B48AA19617BE"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"trong tai\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("898DA114-2269-499F-8C0B-777FB220D27E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"귓속\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("52FAF1B5-BF9D-4638-BA5C-53EA6EB2420A"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"귓속\" (trong tai) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("47F6FA6A-D854-4CA3-A551-F1E2FDAA8341"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그간\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B2A78062-3AF5-40D4-BB86-81F5037CB21B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"trong khoảng đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B31FEB50-8947-4FE4-92E9-5CD4D292F442"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그간\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("0574CDC2-BA26-4154-89AE-80AF17BE6C59"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그간\" (trong khoảng đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BFB301B6-3709-4ED7-BBE6-F44ADFB4502C"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그놈\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6742A468-2E71-4697-BC7C-A1C73B2D1660"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"그놈\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C6F5895B-AA3E-465F-BC59-2E35B4A77191"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그놈\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("52941410-5160-4A21-83BF-7E40AF514DC4"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그때그때\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9EFBBB03-3FDA-4CF1-8785-BAA0FF6CEE69"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"những lúc ấy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("054ABC92-678B-42CE-8232-055B39AEA417"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그때그때\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8CE1C895-480F-4EDF-82AD-34E4563F6613"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그때그때\" (những lúc ấy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("117D9675-D35D-4BD0-829F-8E0A3BC5F55B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그래야\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E3FFB0C8-1FCF-49C6-ABDC-C6DBDEB7FD02"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"그리하여야\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("DB578C00-F9A0-4317-B871-49CC222A8507"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그래야\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9C9849F9-965F-4169-8C72-5489194B21A2"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그래픽\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D7D6437B-49DA-42A2-8210-CB28A610DE42"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"đồ hoạ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("F2AC3B05-DF65-4E9F-AAD4-8036C6AF7C69"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그래픽\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3D5EBBE6-F5B4-4B04-98D4-A486DD1ED6D3"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그래픽\" (đồ hoạ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("822AFD64-42B9-4C5E-9F12-3E123D623140"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그럴듯하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6589168C-B160-4DBD-8716-DB66FA6B1B00"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"hợp lý\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1DF3DE93-ACC8-4859-AAF3-C66E335DA67A"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그럴듯하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("8A1E1693-E6FD-4D24-92C4-70CBFBF18EF4"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그럴듯하다\" (hợp lý) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("821F71D8-ED42-49FC-98F5-05AA841EFADF"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그루\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("55237ACC-1FDF-466F-BF61-77C27E22332E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"gốc (cây)\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8CD02B51-7540-414C-A8AA-413BDA17DD06"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그루\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("14174F5C-6BD3-40DB-BB11-01FEE5818813"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그리로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("48CF14EF-7CB5-4DE3-AA85-CF053388D7DC"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"nơi ấy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("C4085697-A627-4260-9141-CE6D086AE8D9"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그리로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("A0112A6C-A6AB-4387-967B-AC84BD4CFE21"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그리로\" (nơi ấy) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E25FCA91-422E-4109-AAB6-CC34DD94AA34"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그리워하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EDF16C40-F62A-47FA-B961-E4C94D301852"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"nhớ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EE4ADB62-8D63-4FFD-BA98-96DCF04855B1"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그리워하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("2B82A7B4-2473-4399-A5DA-945914FF9437"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그리워하다\" (nhớ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ECA51F2B-0660-4936-9BCC-20198296961F"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그리하여\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BAF7F9CA-316E-40ED-8C39-3E19D13D2FE3"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"làm thế\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7735517F-079B-4A91-AE89-6D49F262FBB0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그리하여\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("F005A0B3-9A76-410F-84D2-DECD880AAA50"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그리하여\" (làm thế) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("10E69459-83A8-4154-A21F-0E2F91F38509"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그사이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1A862A52-7FF6-4F1A-B20C-AE0F61C6DBA0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"giữa lúc đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("57FCBF88-F058-4AB0-BFDD-5FD5E498758B"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그사이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("86F5300D-3A64-4768-9062-0E328461223B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그사이\" (giữa lúc đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8334F441-0347-438E-BD38-7BEEA72140EB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그이\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("32C9ECF5-5D24-4FF2-997A-CBE06B2FA297"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"người ấy\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("AEE42EEB-FF50-40D4-A9E6-9A915D52468D"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그이\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("374CA230-3060-44FB-B12F-55922341706B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그전\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CEB21119-AB04-4CA3-A764-11755CB9504C"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"trước đó\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("612D4AE7-D385-4FD1-ABDA-19EB89068BBC"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그전\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("EB373F3C-A532-454F-9FEA-505A541E5FBD"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그전\" (trước đó) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("74B74345-F167-4835-9B57-951DE0CEC1A7"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그제서야\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("909BC095-C784-4631-B4C9-A925AF24D8DB"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"그제서야\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("44738E85-F585-428C-9A31-90DACB5E521E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"그제서야\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("20EB7054-6670-41F5-970A-33BBC208DBE3"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"그제서야\" (그제서야) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E9490A06-EA06-4597-BD6A-97B2AF9D1D56"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"극\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2689DAD-90E3-437A-A7C4-2CED689E0C0C"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"cực độ\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("88440940-DFEE-4848-BAC4-68107D476E9F"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"극\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9A619168-3DE0-4257-9776-E6F253AEA9A0"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"극\" (cực độ) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("849A6916-B134-4C3C-A9A1-BDCDD64E34FB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"극복하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("D6EE5E32-6180-42E8-BCA7-66785485B8D8"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"khắc phục\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("BE5B7174-3F96-45B3-AFBC-3D517DE85558"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"극복하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("95A6A8B6-5E2B-4304-AC3D-DD42B5CAD812"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"극복하다\" (khắc phục) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6446E177-5E8A-4FA1-A87C-4A0857EC824B"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"극작가\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1772A6F0-94BA-4540-9760-B7A4910E068E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"nhà biên kịch\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("324F0935-22C9-4165-ADF8-9E8471986DE3"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"극작가\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("6E001B8F-DE52-437B-AF75-6084534CEABB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"극작가\" (nhà biên kịch) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6843CB44-50EF-411C-9684-EE16045DF6AD"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"근거하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6A3C7E65-503F-479D-834A-3AB73E7A1EA0"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"trên cơ sở\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("694E2F52-1145-4DDE-A898-13590883A192"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"근거하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("60F30781-0831-4A8C-B864-0A07E9C32688"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"근거하다\" (trên cơ sở) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CDED6056-8488-491B-B1EE-6DDEC9FD68FB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"근로\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("788C13BC-F7CA-47B6-9753-29239EAA360A"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"(sự) cần lao\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("2D905A57-095B-4925-B1F8-FC1895904BC2"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"근로\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("5D785F1E-C9FC-4355-8627-031D2C9B65A2"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"근로\" ((sự) cần lao) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("1889C058-FF0B-455E-A557-F72C121433CB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"근원\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("71FDB494-1D90-4F18-92BD-EE369E24D87E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"khởi nguồn\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("B3727FFF-3B09-4415-AD22-57B091308712"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"근원\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("E6529F63-236E-4FD2-9EEA-F908FC04BF9E"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"근원\" (khởi nguồn) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("19EAECB6-231A-47DB-A082-C323A34BF790"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"금강산\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("E2DB3AAD-5E2B-4C59-8025-5FFAE5752E30"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"Geumgang-san\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("CFC3A142-5AE6-49E4-8FEB-A4939264F1E5"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"금강산\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("B376EFC2-FA18-4F76-AD5A-FFC5FBC54AB7"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"금고\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("79936259-78F3-411C-AF66-A7F996045E3E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"két\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("0DFABE93-7BFC-406C-A503-004322EE66B7"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"금고\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("86710D84-3D7A-4664-B994-F4FB07775C9C"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"금고\" (két) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("42E02E68-B464-4A34-959E-9BE6E57DA3AC"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"금메달\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("29A9FE1D-DBAE-4534-803D-0681AD5BFFFE"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"huy chương vàng\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("9F813AA7-55C5-4312-AD92-08EEC8CD40B9"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"금메달\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("3EAD7965-E606-4BEF-B450-CF477A19E76D"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"금메달\" (huy chương vàng) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("55780687-6E8A-421C-B250-2042D07056D8"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"금세\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6171CDE8-02BE-48DB-8B09-37E3C8EF0699"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"ngay\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("EE6128DC-920F-4948-95A9-0B23DFB7FBB6"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"금세\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("194DC3AD-0D71-47E9-9D21-3FA5E2CC7256"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"금세\" (ngay) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("8C62E5C3-8040-4ADE-8C15-C65B0BF5CC45"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"금지되다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("6EE4EEB3-9043-4BAB-8744-C06BBDE2938D"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"bị cấm đoán\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("376F1DD0-92FA-40B0-876F-8AD41FDEC111"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"금지되다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("AE70A04B-3244-4B14-A435-A1CE6C3FDCCB"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"금지되다\" (bị cấm đoán) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("7D873FF6-3F2A-416F-AECD-49EDDC57D477"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"급증하다\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("09F83130-29BF-474A-8799-65DD06F7EA19"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"tăng nhanh\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("4F627759-0457-4CB0-A2C7-8E691E34BF4F"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"급증하다\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("9196F8CD-8E35-48A6-9499-5AC5BE5CB353"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"급증하다\" (tăng nhanh) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("93511EA8-7D16-4C21-AF03-01A9C6B35F81"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"기\" có nghĩa là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("A7FC389B-3A9C-4941-904F-A225F790D72E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Từ tiếng Hàn có nghĩa là \"sinh khí\" là gì?",
                Type = "MultipleChoice",
            },
            new()
            {
                Id = new Guid("ED934536-1548-4FF8-B7CB-D7B79AEC767E"),
                LessonId = AppDbContext.LessonId3,
                Content = "Viết nghĩa tiếng Việt của từ \"기\"",
                Type = "Writing",
            },
            new()
            {
                Id = new Guid("1152BCAF-A693-4BCD-952A-26D4D909C3B0"),
                LessonId = AppDbContext.LessonId3,
                Content = "\"기\" (sinh khí) thuộc loại từ nào?",
                Type = "MultipleChoice",
            },
        };

        builder.HasData(questions);
    }
}