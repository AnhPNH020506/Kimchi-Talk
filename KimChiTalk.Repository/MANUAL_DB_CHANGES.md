# Manual DB Changes Log

> File này ghi lại **mọi câu lệnh SQL chạy tay trực tiếp vào Database** (qua DBeaver/Rider Database tool...), nằm **ngoài** phạm vi `Migrations/` và `DbSeeder.cs`.
>
> Mục đích: khi build lại DB từ đầu (máy mới, deploy production, hoặc đồng đội khác join sau này), biết chính xác cần chạy thêm gì ngoài `dotnet ef database update`, tránh quên hoặc chèn trùng dữ liệu.
>
> **Quy tắc ghi:** mỗi lần chạy tay 1 câu SQL vào DB (INSERT/UPDATE/DELETE thủ công, không qua code), thêm 1 dòng mới vào bảng dưới đây — kèm ngày, mục đích, và **trạng thái dọn dẹp** (đã xóa khỏi DB test chưa, có cần đưa vào seed chính thức không).

| Ngày | Mục đích | File script | Trạng thái |
|---|---|---|---|
| 2026-08-29 | Tạo data test thủ công cho Question loại `Grammar` + `SentenceTranslation` (Lesson "Công việc & Học tập", Id `5f719033-8948-49c6-9b1c-a70e0da9b58c`) — vì `Questions.json`/`Answers.json` seed sẵn chỉ có loại `VocabularyMeaning`, chưa đủ để test `GetQuestions`/`SubmitQuestions` cho 2 loại còn lại | `seed_test_data.sql` (gửi qua chat, chưa lưu vào repo) | ⚠️ **Chưa dọn** — đây là data test tạm, KHÔNG được đưa vào seed chính thức, KHÔNG được để tồn tại khi lên production. Cần xóa khỏi DB local trước khi merge/deploy, hoặc archive riêng nếu muốn giữ làm data test cho môi trường Dev |

---

## Việc cần làm trước khi lên Production (checklist dọn dẹp)

- [ ] Xóa toàn bộ Question/Answer đã tạo thủ công ở dòng trên (query theo `LessonId = '5f719033-8948-49c6-9b1c-a70e0da9b58c' AND Content LIKE 'Chọn trợ từ đúng%'` hoặc theo đúng các Id đã ghi lúc tạo)
- [ ] Rà soát lại toàn bộ Question thật cần loại `Grammar`/`SentenceTranslation` — hiện `Questions.json` seed chính thức mới chỉ có `VocabularyMeaning` đầy đủ, còn thiếu 2 loại kia cho phần lớn Lesson (xem thêm mục "Backlog"/"Lỗi dữ liệu" trong `KimChiTalk.md`)
