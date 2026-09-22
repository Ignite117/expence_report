# WinFormsApp1 — учёт расходов

Настольное приложение на **C# / Windows Forms (.NET 8)** для учёта расходов, сотрудников и категорий. Хранит данные в базе **PostgreSQL**, графики строит через **LiveCharts**.

## Возможности

- Учёт расходов (`FormRasxod`)
- Управление категориями расходов (`AddCategoriForm`)
- Учёт сотрудников (`FormEmployee`, `AddEmployeeForm`)
- Визуализация данных с помощью графиков (`FormAva`, `AddAvaForm2`)

## Технологии

- .NET 8, Windows Forms
- PostgreSQL (через `Npgsql`)
- LiveCharts.WinForms — графики и диаграммы

## Требования

- Windows
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 (или новее) с рабочей нагрузкой ".NET desktop development"
- Установленный и запущенный сервер [PostgreSQL](https://www.postgresql.org/download/)

## Установка и запуск

1. Склонируйте репозиторий:
   ```bash
   git clone https://github.com/ваш-логин/expence_report.git
   ```

2. Откройте `WinFormsApp1.sln` в Visual Studio.

3. Создайте базу данных в PostgreSQL (по умолчанию в коде используется имя `kirbd`):
   ```sql
   CREATE DATABASE kirbd;
   ```

4. Укажите свою строку подключения к базе. В файле `Form1.cs` найдите строку:
   ```csharp
   con = new NpgsqlConnection("Server=localhost; Port=5432; UserID=postgres; Password=YOUR_PASSWORD_HERE; Database=kirbd");
   ```
   Замените `YOUR_PASSWORD_HERE` на пароль вашего локального PostgreSQL-пользователя. **Не коммитьте реальный пароль в репозиторий.**

5. Восстановите NuGet-пакеты (Visual Studio делает это автоматически при открытии, либо вручную):
   ```bash
   dotnet restore
   ```

6. Запустите проект (F5 в Visual Studio или):
   ```bash
   dotnet run --project WinFormsApp1
   ```

## Структура проекта

```
WinFormsApp1/
├── WinFormsApp1.sln
└── WinFormsApp1/
    ├── Program.cs              # Точка входа
    ├── Form1.cs                 # Главная форма
    ├── FormRasxod.cs             # Учёт расходов
    ├── FormEmployee.cs           # Учёт сотрудников
    ├── FormAva.cs                # Графики / визуализация
    ├── AddCategoriForm.cs        # Добавление категорий
    ├── AddEmployeeForm.cs        # Добавление сотрудников
    └── AddExForm.cs               # Добавление расходов
```

## Примечание по безопасности

Строка подключения к базе данных в коде не содержит реального пароля. Перед использованием подставьте собственные учётные данные локально и не публикуйте их в открытом репозитории.
