# Course Management System

A RESTful backend API for managing private tutoring centers and online courses, built with **ASP.NET Core 9** following **Clean Architecture** principles. The system models the full learning lifecycle: teachers, assistants, students and parents, class groups, sessions, materials, assignments, quizzes, attendance, grading, messaging, notifications and subscription payments.

> 🚧 **Status:** In active development. The domain model, database schema and data-access layer are complete. API endpoints are being added feature by feature (student registration is available now).

---

## 🛠 Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core Web API (.NET 9) |
| ORM | Entity Framework Core 9 (Code-First + Migrations) |
| Database | SQL Server |
| Authentication | ASP.NET Core Identity + JWT Bearer |
| Architecture patterns | Clean Architecture, CQRS with MediatR, Repository + Unit of Work |
| Mapping / Validation | AutoMapper, FluentValidation |
| API Docs | Swagger / OpenAPI (Swashbuckle) |

---

## 🏗 Architecture

The solution is organized into clear layers, each with a single responsibility:

```
CourseManagementSystem/
├── Domain/              # Core business entities and enums (no dependencies)
│   ├── Models/          # Student, Teacher, Parent, ClassGroup, Session, Quiz, Payment...
│   └── Enums/           # AcademicLevel, AttendanceStatus, QuestionType, QuizMode...
├── Application/         # Use cases and contracts
│   ├── Contracts/       # Repository & Unit of Work interfaces
│   ├── Features/        # CQRS commands / queries + MediatR handlers
│   ├── DTOs/            # Data transfer objects
│   └── Mappings/        # AutoMapper profiles
├── Infrastructure/      # External concerns
│   └── Persistence/     # AppDbContext, repository implementations, Unit of Work
├── Presentation/        # Entry point
│   ├── Controllers/     # API controllers
│   └── Program.cs       # App configuration & DI setup
└── Migrations/          # EF Core database migrations
```

---

## ✨ Domain Features

The data model supports the following modules:

- 👤 **Users & Roles:** Teachers, Assistants, Students and Parents (with student–parent relationships), built on ASP.NET Identity
- 🏫 **Class Groups:** Groups by academic level, scheduled times and student enrollments
- 📅 **Sessions:** Per-session materials, assignments and quizzes
- 📚 **Materials:** Uploaded learning resources with file types
- 📝 **Assignments:** Student submissions with status tracking
- ❓ **Quizzes:** Online, in-class and practice modes, with multiple-choice, multi-select, true/false and short-answer questions, plus attempts and answers
- ✅ **Attendance:** Per-session student attendance tracking
- 📊 **Grading:** Grade items per student
- 📢 **Announcements:** General and class-group announcements
- 💬 **Messaging:** Conversations and messages between users
- 🔔 **Notifications:** System notifications delivered per user
- 💳 **Packages & Payments:** Teacher subscription packages and payment status tracking

---

## 🔌 API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| `POST` | `/api/Auth/register-student` | Register a new student account |

Full interactive documentation is available through Swagger UI once the app is running.

---

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- SQL Server (Express, Developer or LocalDB)
- Visual Studio 2022 (17.12+), VS Code or JetBrains Rider

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/MohammedMahmoud-dev/CourseManagementSystem.git
   cd CourseManagementSystem
   ```

2. **Configure the database connection and JWT settings** in `CourseManagementSystem/appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=.;Initial Catalog=TrainingDb;Integrated Security=True;Encrypt=False"
   },
   "Jwt": {
     "Key": "<your-secret-key-at-least-32-characters>",
     "Issuer": "localhost",
     "Audience": "localhost",
     "DurationInMinutes": 60
   }
   ```

3. **Apply the database migrations**
   ```bash
   dotnet ef database update --project CourseManagementSystem
   ```

4. **Run the API**
   ```bash
   dotnet run --project CourseManagementSystem
   ```

5. **Open Swagger UI** at `https://localhost:7006` (or `http://localhost:5258`). Swagger is served at the root URL in the Development environment.

---

## 🗺 Roadmap

- [x] Domain model and database schema
- [x] Generic repository, specific repositories and Unit of Work
- [x] Student registration (CQRS + MediatR)
- [ ] Login and JWT token generation
- [ ] Teacher, Assistant and Parent registration
- [ ] Class group, session and enrollment management endpoints
- [ ] Materials and assignments upload / submission
- [ ] Quiz creation, attempts and auto-grading
- [ ] Attendance and grade reports
- [ ] Messaging and real-time notifications
- [ ] Global exception handling middleware

---

## 👨‍💻 Author

**Mohammed Mahmoud**
GitHub: [@MohammedMahmoud-dev](https://github.com/MohammedMahmoud-dev)
