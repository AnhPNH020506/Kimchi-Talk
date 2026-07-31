# KimChiTalk — Business Rules Document (BRD rút gọn)

> Phiên bản: v1 (MVP)
> Ngày cập nhật: 31/07/2026
> Trạng thái: Đã thống nhất qua phân tích BA, sẵn sàng để viết Use Case & cập nhật Entity

---

## 1. Bối cảnh dự án

| Mục | Nội dung |
|---|---|
| Vấn đề giải quyết | Học tiếng Hàn miễn phí cho bạn bè trải nghiệm |
| Đối tượng người dùng | Người học với mục đích giao tiếp, xem phim, nghe nhạc (không chuyên sâu học thuật) |
| Mô hình | Free, không kinh doanh |
| Thước đo thành công | Tỉ lệ hoàn thành level, tần suất quay lại dùng |
| Ngoài phạm vi v1 | Tích hợp AI, API ngoài, Notification/Email |

---

## 2. Actor

| Actor | Vai trò |
|---|---|
| **Customer** | Người học — đăng ký, học Course/Lesson, làm quiz, nhận thưởng |
| **Admin** | Toàn quyền hệ thống — CRUD nội dung, xem tiến độ Customer, gửi thư động viên |

---

## 3. Business Rules

### 3.1. Cấu trúc nội dung & phân cấp (Course / Level)

| ID | Rule |
|---|---|
| BR-01 | `Course` có field `Level` dạng **enum** (`Beginner`, `Intermediate`, `Advanced`) — độc lập với `Vocabulary.Level` (field Level ở Vocabulary chỉ dùng để phân loại độ khó từng từ, không đại diện cho cả Course) |
| BR-02 | `Course` có field `Order` (số nguyên) — xác định thứ tự học bắt buộc trong cùng 1 Level |
| BR-03 | Customer chỉ được học Course có `Order = N+1` khi Course có `Order = N` (cùng Level) đã hoàn thành 100% |

### 3.2. Hoàn thành bài học (Lesson / Course completion)

| ID | Rule |
|---|---|
| BR-06 | Lesson được coi là `Completed` khi: đã xem hết Vocabulary + đọc hết Grammar + làm xong Question đạt điểm tối thiểu |
| BR-07 | Course % hoàn thành = (Số Lesson đã Completed / Tổng số Lesson trong Course) × 100% |

### 3.3. Nội dung học mở rộng (Grammar, Question đa dạng)

| ID | Rule |
|---|---|
| BR-08 | `Grammar` cần có bộ Question riêng để kiểm tra (không chỉ đọc lý thuyết) |
| BR-09 | Cần bảng `UserGrammar` để đánh dấu Customer đã học Grammar nào (tương tự `UserVocabulary.IsLearned`) |
| BR-13 | `Question` cần có field `QuestionType` (enum: `VocabularyMeaning`, `Grammar`, `SentenceTranslation`) để phân loại, dùng chung 1 bảng `Question`/`Answer` cho cả 3 loại |
| BR-14 | Cặp ngôn ngữ dịch cho loại `SentenceTranslation`: **Việt ↔ Hàn** (không có tiếng Anh) |
| BR-15 | Question loại `SentenceTranslation` vẫn gắn với `LessonId` cụ thể — nội dung câu dịch chỉ xoay quanh từ vựng/ngữ pháp của Lesson đó |
| BR-16 | v1 chỉ làm dạng **trắc nghiệm** (chọn đáp án đúng trong nhiều lựa chọn) cho `SentenceTranslation`; dạng tự nhập câu trả lời (free-text + so khớp) để dành version sau |

### 3.4. Phần thưởng (Reward / Gamification)

| ID | Rule |
|---|---|
| BR-04 | Đạt 1/2 số Course trong 1 Level → mở thưởng (avatar / lời chúc) |
| BR-05 | Hoàn thành 100% Course trong 1 Level → mở thưởng + mở Level tiếp theo |
| BR-10 | Cần bảng `UserReward` để lưu Customer đã nhận thưởng nào — tránh hiện popup thưởng trùng lặp |
| BR-12 | Reward (avatar, lời chúc) **seed cứng sẵn trong DB** ở v1, chưa cần Admin CRUD — để dành version sau |

### 3.5. Ngoài phạm vi v1 (Won't have)

| ID | Rule |
|---|---|
| BR-11 | **Không làm** Notification (UI) và Email nhắc nhở khi Customer không vào app — lý do: cần background job + email service, không phù hợp chi phí/lợi ích cho dự án free quy mô nhỏ |
| BR-17 | **Không làm** bài kiểm tra xếp lớp (placement test) — đã loại bỏ khỏi scope |
| BR-18 | **Không làm** Admin CRUD Reward ở v1 (xem BR-12) |
| BR-19 | **Không làm** tích hợp AI / API ngoài |

---

## 4. MoSCoW Prioritization (tổng hợp)

| Tính năng | Ưu tiên |
|---|---|
| Đăng ký / đăng nhập | Must |
| Xem danh sách khóa học không cần login | Should |
| Đăng ký khóa học | Must |
| UI leo bậc thang theo Course/Level (kiểu Candy Crush) | Must |
| Phần thưởng (avatar, lời chúc) khi đạt 1/2 & full Level | Must |
| Giải thích chi tiết câu sai | Must |
| Lưu & luyện lại câu sai cuối bài | Must |
| Câu động viên khi học xong 1/2 course và hết course | Should |
| Admin CRUD Course / Vocabulary / Question / Answer / Grammar | Must |
| Admin xem tiến độ Customer | Must |
| Admin gửi thư riêng cho Customer | Could |
| Bài kiểm tra xếp lớp | Won't (v1) |
| Notification / Email nhắc nhở | Won't (v1) |
| Admin CRUD Reward | Won't (v1) |
| Free-text translation input (Cách B) | Won't (v1) — để version sau |

---

## 5. Thay đổi Entity cần thực hiện (tổng hợp — CHƯA code, chờ xác nhận trước khi implement)

| Entity | Thay đổi |
|---|---|
| `Course` | + `Level` (enum), + `Order` (int) |
| `Question` | + `QuestionType` (enum: VocabularyMeaning / Grammar / SentenceTranslation) |
| `Grammar` | + quan hệ với `Question` (Question có thể thuộc Grammar thay vì chỉ Vocabulary) |
| *(mới)* `UserGrammar` | UserId, GrammarId, IsLearned |
| *(mới)* `UserReward` | UserId, RewardId (hoặc LevelId), ReceivedAt |
| *(mới)* `Reward` | Title, Description, ImageUrl (avatar), Message (lời chúc), Level, MilestoneType (HalfLevel / FullLevel) |

---

## 6. Câu hỏi còn mở (theo dõi tiếp)

- [ ] Chưa viết Use Case chi tiết theo từng Actor
- [ ] Chưa xác nhận cách tính điểm tối thiểu để Lesson được coi là "đạt" (bao nhiêu % đúng?)
- [ ] Chưa xác nhận nội dung/quy tắc cụ thể cho từng mốc thưởng theo Level