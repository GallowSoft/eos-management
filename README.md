# EOS Management System

## Overview

This is an EOS (Entrepreneurial Operating System) management application designed to help organizations manage their rocks, metrics, departments, teams, and members. The application provides a RESTful API built with ASP.NET Core and a frontend built with Blazor WebAssembly.

## Features

- Create, edit, and manage Rocks
- Metric tracking and reporting
- Team and department management
- Member assignment

## Technology Stack

- Backend: ASP.NET Core Web API
- Frontend: Blazor WebAssembly
- ORM: Entity Framework Core
- Mediator Pattern: MediatR
- Database: Microsoft SQL Server

## Project Structure

- **API Project**: Contains the Web API controllers and Startup Configuration.
- **Core Project**: Houses the domain entities and core interfaces.
- **Application Project**: Holds the application logic, organized into vertical slices.
- **Infrastructure Project**: Manages data access and other infrastructural concerns.
- **Front-End Project**: Written in Blazor WebAssembly, contains the UI of the application.
- **Unit Tests Project**: Contains unit tests for the Core and Application layers.

## Getting Started

### Prerequisites

- .NET SDK
- Node.js (for Blazor WebAssembly)
- Microsoft SQL Server

### Setup

1. Clone the repository:

```bash
git clone https://github.com/your-repository.git
```

2. Navigate to the API project folder and restore the packages:

```bash
cd /path/to/api/project
dotnet restore
```

3. Update the connection string in `appsettings.json`.

4. Run Entity Framework migrations to set up the database:

```bash
dotnet ef database update
```

5. Run the API:

```bash
dotnet run
```


## How to Contribute

Please read our [Contribution Guide](CONTRIBUTING.md) for details on the process for submitting pull requests.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details.

---

