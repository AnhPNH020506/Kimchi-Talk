# KimChiTalk API v1 Frontend API Contract

This file stores the normalized frontend API contract for `KimChiTalk.Api v1`.

## Base URL

```
http://localhost:5137
```

## Auth

* `Authorization` header is required for protected endpoints.
* Header format:

```
Authorization: Bearer <token>
Content-Type: application/json
```

## Response envelope

```ts
{
  success: boolean;
  message: string;
  data?: any;
  errors?: any;
  traceId?: string;
  timestampUtc: string;
}
```

## Standard error body

```ts
{
  success: false;
  message: string;
  errors?: {
    code?: string;
    details?: any;
  };
  traceId?: string;
  timestampUtc: string;
}
```

## Error status codes

| Status | Meaning                                    | Thrown from Service layer as |
|--------|---------------------------------------------|-------------------------------|
| 400    | Invalid input / invalid operation           | `ArgumentException`, `InvalidOperationException` |
| 401    | Not authenticated / invalid token            | `UnauthorizedAccessException` |
| 404    | Resource not found                          | `KeyNotFoundException`        |
| 500    | Unhandled server error                      | any other exception           |

---

## Auth

### POST `/api/v1/auth/register`
Public. Creates a new customer account.

**Request**
```ts
{
  email: string;
  password: string;
  fullName: string;
}
```

**Response `data`**
```ts
string // "Đăng ký thành công"
```

---

### POST `/api/v1/auth/login`
Public.

**Request**
```ts
{
  email: string;
  password: string;
}
```

**Response `data`**
```ts
{
  accessToken: string;
  refreshToken: string;
  refreshTokenExpiresAtUtc: string; // ISO datetime
}
```

---

### POST `/api/v1/auth/refresh-token`
Public (requires a previously issued token pair).

**Request**
```ts
{
  accessToken: string;
  refreshToken: string;
}
```

**Response `data`**
```ts
{
  accessToken: string;
  refreshToken: string;
  refreshTokenExpiresAtUtc: string; // ISO datetime
}
```

---

## Course

### GET `/api/v1/course`
Public. Returns all 3 fixed courses (Beginner / Intermediate / Advanced).
If a valid `Authorization` token is sent, each course also reflects the
caller's own enrollment status via `isEnrolled`.

**Auth:** optional

**Response `data`**
```ts
{
  id: string;        // Guid
  title: string;
  description: string;
  level: string;      // "Beginner" | "Intermediate" | "Advanced"
  order: number;
  isEnrolled: boolean; // always false if not authenticated
}[]
```

---

### POST `/api/v1/course`
Enroll the current user into a course.

**Auth:** required (`CustomerPolicy`)

**Request** (query string)
```
?courseId={guid}
```

**Business rule:** the user must have completed 100% of the previous
level's course (Beginner → Intermediate → Advanced) before enrolling
into the next one. No restriction to enroll into the Beginner course.

**Response `data`**
```ts
string // "Bảo bối đã đăng ký khóa học thành công"
```

**Possible errors**
| Status | Case |
|--------|------|
| 401 | Missing/invalid token |
| 404 | `courseId` does not exist |
| 400 | Already enrolled in this course |
| 400 | Previous level course not completed yet |

---

## Notes for future updates

- Cập nhật file này mỗi khi thêm API mới (Lesson, Grammar, Vocabulary,
  Practice/FinalTest, Reward, Personal Space...).
- Route `POST /api/v1/course` hiện đang dùng `courseId` qua query string,
  chưa theo REST convention `/courses/{courseId}/enroll`. Cân nhắc đổi
  route sau nếu muốn nhất quán hơn.

## 1. AUTH

### Login

```http
POST /api/v1/auth/login
```

#### Request

```ts
LoginRequest {
  email: string;
  password: string;
}
```

#### Response data

```ts
IdentityResponse {
  accessToken: string;
  refreshToken: string;
  refreshTokenExpiresAtUtc: string;
}
```

### Refresh token

```http
POST /api/v1/auth/refresh-token
```

#### Request

```ts
RefreshTokenRequest {
  accessToken: string;
  refreshToken: string;
}
```

#### Notes

- Does not require `Authorization` header.
- The access token may be expired, but the refresh token must match the stored active DB record.
- Refresh rotates tokens: store the returned `refreshToken` and discard the old one.

#### Response data

```ts
IdentityResponse {
  accessToken: string;
  refreshToken: string;
  refreshTokenExpiresAtUtc: string;
}
```

### Register

```http
POST /api/v1/auth/register
```

#### Request

```ts
RegisterUserRequest {
  email: string;
  password: string;
  phoneNumber: string;
  fullName: string;
  role: string;
}
```
## 1. Course
API :  GET 
Path: `/api/v1/course`
Output:
status: 200
[
{
"id": "11111111-1111-1111-1111-111111111111",
"title": "Beginner",
"description": "Introductory Korean Language Course",
"level": "Beginner",
"order": 1,
"isEnrolled": false
},
{
"id": "22222222-2222-2222-2222-222222222222",
"title": "Intermediate",
"description": "Intermediate Korean Language Course",
"level": "Intermediate",
"order": 2,
"isEnrolled": false
},
{
"id": "33333333-3333-3333-3333-333333333333",
"title": "Advanced",
"description": "Advanced Korean Language Course",
"level": "Advanced",
"order": 3,
"isEnrolled": false
}
]
### EnrollCourse
```http
POST `/api/v1/course`
```

#### Request
{
"email": "string",
"password": "string"
#### Response data

}
Status : 400
{
    "Success": false,
    "Message": "Bảo bối à em đã đăng kí khóa học này rùi mòo",
    "Data": null,
    "Errors": {
    "code": "bad_request",
}
Status: 400
{
    "Success": false,
    "Message": "Bảo bối phải hoàn thành khóa học \"Beginner\" trước khi đăng ký khóa học này aaaaa",
    "Data": null,
    "Errors": {
    "code": "bad_request",
    "TraceId": "0HNNM637RRC4F:00000005",
    "TimestampUtc": "2026-08-09T16:13:45.9745863Z"
}


---
## 2. Lesson
API :  GET
Path: `/api/v1/lesson`

status: 200
Input:
CourseId: Guid
Output: 
{
[
{
"id": Guid,
"title": string,
"order": int,
"isUnlocked": bool,
"isCompleted": bool
}
]
}

## 3. Vocabulary
API :  GET
Path: `/api/v1/lesson`

status: 200
Input:
LessonId : Guid
Output:
{
[
{
"id": Guid,
"word": string,
"level": string,
"type": string,
"meaningVietnamese": string,
"isLearned": bool,
"isFavorite": bool
}
]
}
## 4. Grammar
API :  GET
Path: `/api/v1/Grammar`

status: 200
Input:
LessonId : Guid
Output:
{
[
{
"id": Guid,
"title": string,
"explanation": string,
"example": string,
"isLearned": bool
}
]
}
## 5. Question
API :  GET
Path: `/api/v1/question`

status: 200
Input:
LessonId : Guid
questionStage: int
Output:
[
{
"id": Guid
"content": string,
"type": enum,
"answers": [
{
"id": Guid,
"content": string
}
]
}
]
Customer summit answer
API :  Post
Path: `/api/v1/question`

status: 200
Input:
{
"lessonId": Guid",
"questionStage": enum,
"answers": [
{
"questionId": Guid,
"selectedAnswerIds": [
Guid
]
}
]
}
Output:
{
"questions": [
{
"questionId": Guid,
"grammarId": Guid,
"isCorrect": bool
}
],
"isPassed": false
}


