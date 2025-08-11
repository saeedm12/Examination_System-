# Exam.Web

A Bootstrap-styled ASP.NET Core MVC UI for your Examination System. Plug in your existing C# logic behind controllers.

## Prerequisites
- .NET SDK 9.0+

## Run
```bash
dotnet run --project ./Exam.Web/Exam.Web.csproj
```
Then open `http://localhost:5000`.

## Integrating your logic
- Move your domain classes from `EXAM` into a class library (e.g., `EXAM.Domain`), or reference them directly if already in a library.
- Inject services into controllers to:
  - Create subjects and exams from form data
  - Generate questions (MCQ / TrueOrFalse)
  - Evaluate submissions and compute scores

This project ships with view models and views only, keeping it backend-agnostic so you can wire it to your logic as needed.