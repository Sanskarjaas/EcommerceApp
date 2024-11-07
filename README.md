# eCommerce Web API

This project is an eCommerce Web API developed using **ASP.NET Web API**, **C#**, and follows a clean architecture with the **API**, **Core**, and **Infrastructure** layers. It utilizes **MSSQL** for data storage and implements various features like product management, search functionality, pagination, and error handling.

## Features

- **CRUD Operations** for managing product data.
- **Search Functionality** for products by brand, type, and name.
- **Pagination** support to manage large product lists with configurable page size.
- **Error Handling** to provide meaningful error messages and status codes.
- **Swagger** integration for easy API documentation and testing.
- **Repository Pattern** and **Service Layer** for clean architecture.

## Technologies Used

- **ASP.NET Web API** - For building the API endpoints.
- **C#** - Programming language for the API logic.
- **Entity Framework Core** - ORM for data access.
- **MSSQL** - Database to store product data.
- **Swagger** - For API documentation and testing.
- **Repository Pattern** - For data abstraction.
- **Service Layer** - For business logic handling.

## Architecture

The project is organized into three main layers:

### 1. **API Layer**  
Contains the API controllers responsible for handling HTTP requests (GET, POST, PUT, DELETE).

### 2. **Core Layer**  
Includes business logic, models, and interfaces. This layer defines the application’s core functionality.

### 3. **Infrastructure Layer**  
Handles data access using **Entity Framework Core** to interact with the **MSSQL** database and implement the **Repository** pattern.

## Setup and Installation

### Prerequisites

- .NET 6 or higher
- SQL Server (or SQL Express) running locally or on a server
- Visual Studio or Visual Studio Code

### Steps to Run the Project

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/ecommerce-web-api.git
    cd ecommerce-web-api
    ```

2. **Configure the Database**:  
   - Create a new SQL Server database or use an existing one.
   - Update the **connection string** in the `appsettings.json` file in the **Infrastructure** project.

3. **Restore NuGet Packages**:
   ```bash
   dotnet restore

<a href="https://github.com/Sanskarjaas">GitHub --SanskarJaiswal--</a>

![localhost_7090_swagger_index html (1)](https://github.com/user-attachments/assets/e065996b-ae61-4ca2-9632-fbd6ed3e13bb)
