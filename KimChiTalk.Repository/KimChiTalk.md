# KimChiTalk — Business Rules Document (BRD rút gọn)

> Phiên bản: v2 (MVP — bản chốt cuối trước khi sửa entity)
> Ngày cập nhật: 31/07/2026
> Trạng thái: Đã thống nhất toàn bộ qua phân tích BA, sẵn sàng để viết Use Case & cập nhật Entity

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
| BR-20 | Mỗi Lesson có 2 giai đoạn, phân biệt bằng field `Question.QuestionStage` (enum: `Practice`, `FinalTest`) — không tách bảng riêng: <br>• **Practice**: làm tự do, sai không sao, có thể làm lại nhiều lần <br>• **FinalTest**: phải trả lời **đúng 100%** thì Lesson mới được tính `Completed` |
| BR-21 | Trong `FinalTest`, nếu trả lời sai: hệ thống nhắc lại kiến thức liên quan (Vocabulary/Grammar của câu đó) → Customer chỉ làm lại **các câu đã sai** (không làm lại toàn bộ) → lặp lại quy trình này đến khi trả lời đúng hết toàn bộ mới được qua Lesson tiếp theo |

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
| BR-22 | Reward dùng **ảnh cá nhân** (do chủ dự án chọn, không phải ảnh generate). DB chỉ lưu `ImageUrl` (string, path/URL) — **không lưu binary ảnh trong DB**. File ảnh thật lưu tĩnh trong project (`wwwroot/images/rewards/`), seed sẵn đường dẫn |
| BR-23 | Có mục **"Sưu tầm"** (Collection) riêng để Customer xem lại toàn bộ Reward đã nhận được, không chỉ hiện popup 1 lần rồi mất |

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
| `Course` | + `Level` (enum: Beginner/Intermediate/Advanced), + `Order` (int, thứ tự trong Level) |
| `Question` | + `QuestionType` (enum: VocabularyMeaning / Grammar / SentenceTranslation), + `QuestionStage` (enum: Practice / FinalTest) |
| `Grammar` | + quan hệ với `Question` (Question có thể thuộc Grammar thay vì chỉ Vocabulary) |
| *(mới)* `UserGrammar` | UserId, GrammarId, IsLearned |
| *(mới)* `UserReward` | UserId, RewardId, ReceivedAt |
| *(mới)* `Reward` | Title, Description, ImageUrl (path/URL, KHÔNG lưu binary), Message (lời chúc), Level, MilestoneType (HalfLevel / FullLevel) |
| `UserCourse` | Rename `CoursesId` → `CourseId` (đúng convention) |
| `Lesson` | Rename property `Courses` → `Course` (quan hệ là 1-1/nhiều-1, không phải số nhiều) |

**Ghi chú lưu trữ ảnh:** File ảnh Reward đặt tại `wwwroot/images/rewards/`, seed sẵn đường dẫn tương đối vào field `ImageUrl`. Không dùng cloud storage ở v1 — tránh phát sinh dependency ngoài (đúng BR-19).

---

## 6. Trạng thái tồn đọng

| Vấn đề | Trạng thái |
|---|---|
| Ngưỡng hoàn thành Lesson | ✅ Đã chốt — BR-20, BR-21 (đúng 100% FinalTest, sai thì luyện lại đến khi đúng hết) |
| Nội dung/quy tắc thưởng theo Level | ✅ Đã chốt — BR-22, BR-23 (ảnh cá nhân, mục Sưu tầm) |
| Nơi lưu ảnh Reward | ✅ Đã chốt — lưu tĩnh trong project, DB chỉ lưu path |
| Rename field kỹ thuật | ✅ Đã chốt — đổi tên cho đúng convention |
| **Use Case chi tiết theo Actor** | ⏳ Bước tiếp theo |
| **Cập nhật entity thật trong code** | ⏳ Bước tiếp theo (sau Use Case) |

> Toàn bộ Business Rules đã chốt xong. Bước tiếp theo: viết Use Case chi tiết (Customer / Admin) rồi mới bắt đầu sửa entity + migration.