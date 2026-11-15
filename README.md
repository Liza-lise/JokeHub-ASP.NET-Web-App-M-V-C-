# JokeHub 😂

**A Joke Sharing Web Application built with ASP.NET Core MVC**

JokeHub is a web application developed using C# and ASP.NET Core MVC. It provides a platform where users can register, authenticate, and interact with jokes through a web-based interface.

The project demonstrates practical application development skills, focusing on backend engineering, database integration, authentication, and the implementation of CRUD functionality.

## Project Overview

JokeHub was developed to explore and demonstrate the ASP.NET Core MVC architecture and the development of database-driven web applications.

The application uses the Model-View-Controller (MVC) pattern to separate application logic, data management, and user interface components.

## Technologies & Tools

- **Language:** C#
- **Framework:** ASP.NET Core MVC (.NET 8)
- **ORM:** Entity Framework Core 8
- **Database:** Microsoft SQL Server (LocalDB)
- **Authentication:** ASP.NET Core Identity
- **Frontend:** HTML, CSS, JavaScript, Bootstrap
- **Development Environment:** Visual Studio 2022
- **Version Control:** Git and GitHub

## Key Features

- User registration and authentication.
- User login and logout.
- Joke management.
- Create, Read, Update and Delete (CRUD) operations.
- Database integration using Entity Framework Core.
- User authentication and authorization.
- MVC architectural pattern.

## Project Architecture

```text
JokeHub/
│
├── Controllers/
│
├── Data/
│   ├── ApplicationDbContext.cs
│   └── Migrations/
│
├── Models/
│
├── Views/
│
├── wwwroot/
│   ├── css/
│   ├── js/
│   └── lib/
│
├── Properties/
├── Program.cs
├── appsettings.json
├── *.csproj
└── README.md
```

## Getting Started

### Prerequisites

Before running the application, ensure you have:

- Visual Studio 2022
- .NET 8 SDK
- Microsoft SQL Server LocalDB
- Entity Framework Core tools

### Installation

**1. Clone the repository**

```bash
git clone https://github.com/Liza-lise/JokeHub-ASP.NET-Web-App-M-V-C-.git
```

**2. Open the solution**

Open the `.sln` file using Visual Studio 2022.

**3. Configure the database**

Check the connection string in `appsettings.json` and ensure SQL Server LocalDB is available.

**4. Apply database migrations**

Using the Visual Studio Package Manager Console:

```powershell
Update-Database
```

Alternatively, using the .NET CLI:

```bash
dotnet ef database update
```

**5. Run the application**

Build and run the project using Visual Studio, or execute:

```bash
dotnet run
```

## Learning Objectives

Through this project, I developed practical experience in:

- ASP.NET Core MVC application development.
- C# backend programming.
- Database design and integration.
- Entity Framework Core and database migrations.
- Authentication and authorization using ASP.NET Core Identity.
- CRUD application development.
- Git and GitHub version control.
- Structuring and maintaining a web application.

## Future Improvements

- Production database integration.
- Cloud deployment.
- Additional user-focused functionality.
- Improved application interface and user experience.

## Developer

**Lizalise Hlangani**

ICT Professional | Application Development

GitHub: [Liza-lise](https://github.com/Liza-lise)

---

*JokeHub — Bringing laughter and technology together.*
