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


Use Case chi tiết — KimChiTalk

Dựa trên toàn bộ Business Rules đã chốt, mình liệt kê Use Case theo từng Actor. Mỗi use case gồm: Mô tả, Điều kiện tiên quyết (Precondition), Luồng chính (Main Flow), Luồng phụ/ngoại lệ (Alternative Flow) — đây là format chuẩn BA dùng để dev đọc vào là implement được ngay, không cần hỏi lại.

ACTOR: CUSTOMER
UC-01: Đăng ký tài khoản
Precondition: Chưa có tài khoản
Main flow: Nhập Name, Email, Password → hệ thống hash password (HashshedPassword) → tạo User mới → chuyển sang màn hình chọn Course
Alternative: Email đã tồn tại → báo lỗi, yêu cầu đăng nhập thay vì đăng ký
UC-02: Đăng nhập
Main flow: Nhập Email + Password → xác thực → vào màn hình chính (danh sách khóa học / tiến độ đang học)
Alternative: Sai thông tin → báo lỗi
UC-03: Xem danh sách Course (không cần đăng nhập)
Main flow: Khách vãng lai xem danh sách Course, phân theo Level, thấy Course nào đã mở/khóa (dựa theo Order) — nhưng không đăng ký học được nếu chưa đăng nhập
Business rule áp dụng: BR-01, BR-02
UC-04: Đăng ký học 1 Course
Precondition: Đã đăng nhập
Main flow: Chọn Course có Order hợp lệ (Course trước đó cùng Level đã Completed) → tạo record UserCourse (EnrollAt = true)
Alternative: Chọn Course chưa mở khóa (Order chưa tới lượt) → hệ thống chặn, hiển thị thông báo "cần hoàn thành Course trước"
Business rule áp dụng: BR-03
UC-05: Học 1 Lesson — giai đoạn Practice
Precondition: Đã đăng ký Course chứa Lesson này
Main flow: Xem Vocabulary → đọc Grammar → làm Question (QuestionStage = Practice) → sai không bị chặn, có thể làm lại tự do → xem giải thích khi sai (đáp ứng yêu cầu "giải thích chi tiết câu sai")
Business rule áp dụng: BR-06, BR-08, BR-13, BR-20
UC-06: Làm bài Final Test của Lesson
Precondition: Đã hoàn thành giai đoạn Practice
Main flow: Làm hết Question (QuestionStage = FinalTest) → nếu đúng 100% → UserProgress.Completed = true, Lesson tiếp theo được mở
Alternative flow (câu sai): Câu nào sai → hệ thống hiển thị lại kiến thức liên quan (Vocabulary/Grammar) → Customer làm lại chỉ câu đã sai → lặp lại đến khi đúng hết
Business rule áp dụng: BR-20, BR-21
UC-07: Xem lại câu sai đã lưu để luyện tập
Main flow: Sau khi hoàn thành 1 bài (Practice hoặc Final Test), hệ thống hiển thị danh sách câu đã từng sai trong phiên đó để Customer luyện lại thêm (không bắt buộc)
UC-08: Nhận thông báo động viên trong lúc học
Trigger: Customer hoàn thành 1/2 số Lesson trong Course, hoặc hoàn thành hết Course
Main flow: Hiển thị câu động viên (random từ 1 danh sách seed sẵn)
UC-09: Nhận Reward khi đạt mốc Level
Trigger: Hoàn thành 1/2 số Course trong 1 Level, hoặc hoàn thành 100% Course trong Level
Main flow: Kiểm tra UserReward xem đã nhận Reward này chưa → nếu chưa: tạo record UserReward, hiển thị popup (ảnh + lời chúc) → nếu đã nhận rồi: không hiển thị lại
Business rule áp dụng: BR-04, BR-05, BR-10, BR-22
UC-10: Xem mục "Sưu tầm" (Collection)
Main flow: Customer vào mục riêng, xem lại toàn bộ Reward đã nhận được từ trước tới giờ (dựa theo UserReward)
Business rule áp dụng: BR-23
UC-11: Xem tiến độ học tập của bản thân
Main flow: Vào lại app lần 2 trở đi → hệ thống hiển thị Course/Lesson đang học dở, % hoàn thành
UC-12: Đánh dấu từ vựng yêu thích (cần xác nhận — xem câu hỏi cuối)
Main flow: Customer đánh dấu 1 Vocabulary là IsFavorite = true để xem lại sau
ACTOR: ADMIN
UC-13: CRUD Course / Level / Order
Main flow: Admin thêm/sửa/xóa Course, gán Level + Order → hệ thống validate không trùng Order trong cùng 1 Level
UC-14: CRUD Lesson (gồm Vocabulary, Grammar, Question, Answer)
Main flow: Admin quản lý nội dung từng Lesson, bao gồm gán QuestionType và QuestionStage cho từng Question khi tạo
UC-15: Xem tiến độ học tập của Customer
Main flow: Admin xem danh sách Customer, chọn 1 người → xem Course/Lesson đang học, % hoàn thành, lịch sử làm bài
UC-16: Gửi thư động viên/chúc mừng riêng cho Customer (Could-have, không bắt buộc v1)
Main flow: Admin soạn nội dung → gửi tới 1 Customer cụ thể → Customer nhận được trong app (không phải email, vì Notification/Email đã loại khỏi scope — BR-11)
Vấn đề phát sinh khi viết Use Case — cần bạn xác nhận trước khi chốt hoàn toàn
UC-12 (đánh dấu từ vựng yêu thích): Field IsFavorite đã có sẵn trong code (UserVocabulary) nhưng chưa từng được nhắc đến trong toàn bộ phân tích trước đó. Bạn có muốn giữ tính năng này trong scope v1 không, hay đây là phần code thừa cần bỏ qua (không cần Use Case, không cần UI)?
UC-16 (Admin gửi thư riêng): Đã xác định là Could-have — bạn có muốn viết Use Case chi tiết cho tính năng này luôn (để sẵn), hay để trống, chỉ làm khi thật sự cần ở version sau?
Trình tự Lesson trong Course: Mình thấy BR-02/BR-03 nói về Order của Course trong Level, nhưng chưa có rule về thứ tự Lesson trong Course — Lesson học tự do trong 1 Course hay cũng phải tuần tự? (Đây là gap mình vừa phát hiện khi viết UC-05/UC-06, cần chốt vì ảnh hưởng đến việc có cần thêm field Order cho Lesson không)