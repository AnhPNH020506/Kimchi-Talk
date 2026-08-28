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
| BR-03 | Customer chỉ được học Course có `Order = N+1` khi Course có `Order = N` (cùng Level) đã hoàn thành 100% (áp dụng nếu 1 Level có nhiều Course — xem BR-27b) |
| BR-27 | Customer luôn được truy cập Course ở Level thấp hơn hoặc bằng Level đã mở khóa (không giới hạn quay lại ôn tập). Để **mở khóa Level cao hơn**, phải hoàn thành 100% Lesson thuộc Course của Level hiện tại (xem BR-05). So sánh thứ tự Level dựa theo giá trị `CourseLevel` enum (Beginner < Intermediate < Advanced), không dùng `Course.Order` |
| BR-27b | **Cấu trúc thực tế hiện tại:** Chỉ có đúng **3 Course**, tương ứng 1-1 với 3 Level (Beginner, Intermediate, Advanced) — không có nhiều Course con trong 1 Level. Đơn vị "bậc thang" hiển thị trên UI chính là **Lesson**, không phải Course. Field `Course.Order` vẫn giữ để mở rộng sau này, nhưng hiện luôn bằng `1` cho cả 3 Course |

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
| BR-16 | `SentenceTranslation` dùng cơ chế **sắp xếp mảnh ghép** (kiểu Duolingo) thay vì trắc nghiệm chọn nguyên câu — xem BR-29, BR-30 |
| BR-28 | `Answer` có thêm field `Order` (int, nullable): số thứ tự đúng của mảnh ghép trong câu/từ hoàn chỉnh; `Order = null` nghĩa là mảnh nhiễu (decoy), không thuộc đáp án đúng. Không cần field nhãn loại từ (chủ ngữ/động từ...) — chỉ cần đúng thứ tự ghép |
| BR-29 | `VocabularyMeaning`: giữ nguyên trắc nghiệm chọn nghĩa đúng (như data cũ), bỏ hẳn dạng tự gõ đáp án (`"Writing"`) khỏi seed — không chuyển đổi, xóa thẳng |
| BR-30 | `SentenceTranslation`: mảnh ghép chia theo **cụm từ có vai trò ngữ pháp** (chủ ngữ/vị ngữ/bổ trợ), có thêm mảnh nhiễu. Cần **data câu ví dụ mới** theo từng Lesson (chưa có sẵn, để làm sau — không lấy được từ data "Writing" cũ vì đó là hỏi nghĩa từ đơn, không phải câu) |

### 3.4. Phần thưởng (Reward / Gamification)

| ID | Rule |
|---|---|
| BR-04 | Đạt mốc **1/2** số Lesson đã `Completed` trong Course (Level) → mở thưởng (avatar / lời chúc). Công thức: `(Số Lesson Completed / Tổng số Lesson trong Course) ≥ 50%` |
| BR-05 | Đạt **100%** Lesson đã `Completed` trong Course (Level) → mở thưởng + mở Level tiếp theo |
| BR-10 | Cần bảng `UserReward` để lưu Customer đã nhận thưởng nào — tránh hiện popup thưởng trùng lặp |
| BR-12 | Reward (avatar, lời chúc) **seed cứng sẵn trong DB** ở v1, chưa cần Admin CRUD — để dành version sau |
| BR-22 | Reward dùng **ảnh cá nhân** (do chủ dự án chọn, không phải ảnh generate). DB chỉ lưu `ImageUrl` (string, path/URL) — **không lưu binary ảnh trong DB**. File ảnh thật lưu tĩnh trong project (`wwwroot/images/rewards/`), seed sẵn đường dẫn |
| BR-23 | Có mục **"Sưu tầm"** (Collection) riêng để Customer xem lại toàn bộ Reward đã nhận được, không chỉ hiện popup 1 lần rồi mất |

### 3.5b. Admin gửi thư riêng & Thứ tự Lesson

| ID | Rule |
|---|---|
| BR-24 | Admin gửi thư động viên/chúc mừng cho **từng Customer riêng lẻ** (không hỗ trợ gửi hàng loạt/broadcast — nếu cần thông báo cho tất cả Customer thì dùng tính năng thông báo hệ thống, khác với `AdminMessage`). Không ràng buộc thời gian gửi. Customer nhận trong mục **Thông báo** trong app (không phải email) |
| BR-25 | `Lesson` có field `Order` (int) — xác định thứ tự học bắt buộc trong cùng 1 Course, tương tự cách `Course.Order` hoạt động trong 1 Level (BR-02, BR-03) |
| BR-26 | `UserVocabulary.IsFavorite` — giữ lại tính năng đánh dấu từ vựng yêu thích trong scope v1 |

### 3.5. Ngoài phạm vi v1 (Won't have)

| ID | Rule |
|---|---|
| BR-11 | **Không làm** Notification (UI) và Email nhắc nhở khi Customer không vào app — lý do: cần background job + email service, không phù hợp chi phí/lợi ích cho dự án free quy mô nhỏ |
| BR-17 | **Không làm** bài kiểm tra xếp lớp (placement test) — đã loại bỏ khỏi scope |
| BR-18 | **Không làm** Admin CRUD Reward ở v1 (xem BR-12) |
| BR-19 | **Không làm** tích hợp AI / API ngoài |
| BR-31 | **Không làm** chấm điểm real-time từng câu kiểu Duolingo (chọn phát báo đúng/sai ngay) ở v1 — lý do: cần thêm entity mới lưu "User đã trả lời đúng Question nào" để BE tự theo dõi tiến độ FinalTest qua nhiều lần gọi API (không thể tin FE tự báo hoàn thành). v1 dùng cách nộp bài theo lượt: Customer làm hết cả lượt (Practice hoặc FinalTest) → submit 1 lần cả danh sách câu trả lời → BE chấm hàng loạt, trả kết quả |
| BR-32 | **Không thêm** `VocabularyId` trực tiếp trên `Question` ở v1 (đánh đổi: cần migration + script gán lại `VocabularyId` cho ~2667 câu `VocabularyMeaning` đã seed). Hệ quả: khi câu `VocabularyMeaning` trong FinalTest bị sai, hệ thống chỉ nhắc lại **toàn bộ Vocabulary của Lesson** đó (gọi lại `GetVocabularies`), không xác định được chính xác 1 từ bị sai. Ngược lại, câu `Grammar`/`SentenceTranslation` sai thì nhắc đúng 1 Grammar cụ thể (đã có sẵn `GrammarId` trên Question) |

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
| Admin gửi thư riêng cho Customer (không broadcast) | Must (đã quyết định làm ngay, không để dành version sau) |
| Bài kiểm tra xếp lớp | Won't (v1) |
| Notification / Email nhắc nhở | Won't (v1) |
| Admin CRUD Reward | Won't (v1) |
| Free-text translation input (Cách B) | Won't (v1) — để version sau |

---

## 5. Thay đổi Entity cần thực hiện (tổng hợp — CHƯA code, chờ xác nhận trước khi implement)

| Entity | Thay đổi |
|---|---|
| `Course` | + `Level` (enum: Beginner/Intermediate/Advanced), + `Order` (int, thứ tự trong Level) |
| `Question` | + `QuestionType` (enum: VocabularyMeaning / Grammar / SentenceTranslation), + `QuestionStage` (enum: Practice / FinalTest); xóa field `Type` (string) cũ |
| `Answer` | + `Order` (int?, nullable) — thứ tự đúng của mảnh ghép, null = mảnh nhiễu |
| `Grammar` | + quan hệ với `Question` (Question có thể thuộc Grammar thay vì chỉ Vocabulary) |
| *(mới)* `UserGrammar` | UserId, GrammarId, IsLearned |
| *(mới)* `UserReward` | UserId, RewardId, ReceivedAt |
| *(mới)* `Reward` | Title, Description, ImageUrl (path/URL, KHÔNG lưu binary), Message (lời chúc), Level, MilestoneType (HalfLevel / FullLevel) |
| `UserCourse` | Rename `CoursesId` → `CourseId` (đúng convention) |
| `Lesson` | Rename property `Courses` → `Course` (quan hệ là 1-1/nhiều-1, không phải số nhiều); + `Order` (int, thứ tự trong Course) |
| *(mới)* `AdminMessage` | AdminId (gửi), UserId (nhận), Content, SentAt, IsRead |

**Ghi chú lưu trữ ảnh:** File ảnh Reward đặt tại `wwwroot/images/rewards/`, seed sẵn đường dẫn tương đối vào field `ImageUrl`. Không dùng cloud storage ở v1 — tránh phát sinh dependency ngoài (đúng BR-19).

---

## 6. Trạng thái tồn đọng

| Vấn đề | Trạng thái |
|---|---|
| Ngưỡng hoàn thành Lesson | ✅ Đã chốt — BR-20, BR-21 (đúng 100% FinalTest, sai thì luyện lại đến khi đúng hết) |
| Nội dung/quy tắc thưởng theo Level | ✅ Đã chốt — BR-22, BR-23 (ảnh cá nhân, mục Sưu tầm) |
| Nơi lưu ảnh Reward | ✅ Đã chốt — lưu tĩnh trong project, DB chỉ lưu path |
| Rename field kỹ thuật | ✅ Đã chốt — đổi tên cho đúng convention |
| **Use Case chi tiết theo Actor** | ✅ Đã viết xong (UC-01 → UC-16) |
| Giữ/bỏ `IsFavorite` | ✅ Đã chốt — giữ lại (BR-26) |
| Chi tiết Admin gửi thư (UC-16) | ✅ Đã chốt — gửi riêng lẻ, không broadcast (BR-24) |
| Thứ tự Lesson trong Course | ✅ Đã chốt — dùng field `Order` (BR-25) |
| **Cập nhật entity thật trong code** | ⏳ Bước tiếp theo — sẵn sàng bắt đầu |

> Toàn bộ Business Rules và Use Case đã chốt xong. Bước tiếp theo: cập nhật entity + tạo migration.

## 6b. Lỗi dữ liệu phát hiện lúc test — chưa sửa, rà soát 1 lượt vào cuối dự án

> Các lỗi dưới đây đã xác nhận là **lỗi data seed**, không phải lỗi code/logic (đã trace kỹ code, filter đúng theo `LessonId`). Cố tình **chưa sửa ngay** để tránh xáo trộn tiến độ code hiện tại — sẽ rà soát tổng thể data 1 lượt trước khi release.

| # | Vấn đề | Ghi chú |
|---|---|---|
| 1 | `Vocabulary` không khớp chủ đề `Lesson` | Ví dụ Lesson "Gia đình & Con người 2" (`Id: 918c686b-...`) lại có 6 từ vựng: `글`(bài viết), `글쎄`/`글쎄요`(để xem...), `기온`(nhiệt độ), `길`(đường), `김치찌개`(canh kimchi) — không liên quan chủ đề gia đình. Nghi vấn: `Vocabularies.json` được **gom nhóm theo thứ tự bảng chữ cái tiếng Hàn** (tất cả đều bắt đầu bằng "ㄱ"), rồi chia đều theo Lesson theo số lượng — chứ không soạn theo đúng chủ đề từng Lesson. Cần rà lại toàn bộ `Vocabularies.json` xem có bị lỗi tương tự ở các Lesson khác không, và gán lại đúng theo chủ đề. |

## 7. Main Flow (luồng chính của hệ thống)

Đây là 4 luồng trải nghiệm cốt lõi, dùng làm thứ tự ưu tiên implement Service — thay vì làm rời rạc theo từng Entity.

### Main Flow 1 — Xem khóa học & Chọn học
Customer xem thông tin các khóa học (Course) công khai, **không cần đăng nhập** (MoSCoW: Should) → khi muốn bắt đầu học, mới đăng ký/đăng nhập → chọn khóa học mình mong muốn, đăng ký học.
> Use Case liên quan: UC-03 (xem công khai) → UC-01, UC-02 (đăng ký/đăng nhập) → UC-04 (đăng ký học)
> **Lưu ý code:** Endpoint danh sách Course KHÔNG gắn `[Authorize]`; chỉ endpoint đăng ký học (UC-04) mới yêu cầu đăng nhập.

### Main Flow 2 — Học & Nhận thành tựu
Customer học từng Lesson (Practice → Final Test) → hoàn thành Lesson này mới được mở Lesson tiếp theo (BR-25, BR-20, BR-21) → đạt các cột mốc (1/2, full Level) thì nhận phần thưởng kèm lời chúc (`Reward.Message` — BR-22, tự động, không phải Admin soạn tay).
> Use Case liên quan: UC-05, UC-06, UC-07, UC-08, UC-09, UC-11
> **Lưu ý:** "Lời chúc khi đạt thành tựu" thuộc `Reward.Message`, sinh tự động khi đạt mốc — khác với `AdminMessage` (UC-16, Admin soạn tay, gửi thủ công, không tự động trigger). Không nhầm 2 khái niệm này khi code.

### Main Flow 3 — Admin theo dõi & động viên Customer
Admin theo dõi tiến độ học tập của từng Customer → gửi thư động viên/chúc mừng riêng cho từng người.
> Use Case liên quan: UC-15, UC-16

### Main Flow 4 — Admin quản lý nội dung học
Admin CRUD Course, Lesson, Vocabulary, Question, Answer, Grammar — quản lý toàn bộ nội dung học của hệ thống.
> Use Case liên quan: UC-13, UC-14
> **Ghi chú:** Ưu tiên thấp nhất trong 4 flow — giai đoạn đầu vẫn quản lý nội dung qua seed data / thao tác trực tiếp DB, chưa cần giao diện CRUD riêng.

### Main Flow 5 — Không gian cá nhân
Customer xem lại Reward đã sưu tầm (mục Sưu tầm), xem danh sách từ vựng đã đánh dấu yêu thích.
> Use Case liên quan: UC-10 (xem mục Sưu tầm — BR-23), UC-12 (đánh dấu/xem từ vựng yêu thích — BR-26)
> **Ghi chú:** Tính năng tra cứu cá nhân, không nằm trên mạch học chính (không chặn/mở khóa gì) — làm sau khi MF1-3 chạy được.

### ⚠️ Blocker dữ liệu cần xử lý trước khi code Main Flow 2
BR-06 định nghĩa Lesson `Completed` = xem hết Vocabulary + đọc hết Grammar + làm xong Question — nhưng hiện tại:
- Bảng `Grammar` đang **0 record** (chưa seed) → không thể test điều kiện "đọc hết Grammar"
- Bảng `Reward` đang **0 record** (BR-12 yêu cầu seed cứng 3 Level × 2 mốc = 6 record) → không thể test UC-09
- Toàn bộ 2,667 Question hiện là `VocabularyMeaning` — chưa có Question loại `Grammar` hay `SentenceTranslation`

→ **Trước khi bắt đầu code Main Flow 2**, cần seed tối thiểu: vài Grammar cho 1-2 Lesson (kèm Question loại `Grammar`), và đủ 6 Reward theo BR-04/BR-05 — nếu không, Main Flow 2 code xong sẽ không test end-to-end được.

### Thứ tự implement Service đề xuất (theo Main Flow 1 → 2 → 3 → 4)
1. User (Register/Login)
2. Course (danh sách, đăng ký học)
3. Lesson (danh sách theo Course, trạng thái khóa/mở)
4. Vocabulary + Grammar (nội dung học trong Lesson)
5. Question + Answer (làm bài Practice/FinalTest)
6. UserProgress (tính Completed, mở Lesson kế)
7. Reward/UserReward (kiểm tra mốc, trả thưởng)
8. AdminMessage (Admin gửi thư, Customer nhận)
9. Admin xem tiến độ Customer
10. Admin CRUD nội dung (Course/Lesson/Vocabulary/Question/Grammar) — làm sau cùng