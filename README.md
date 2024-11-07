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

Run Migrations (if applicable):

In the Infrastructure project, run the migrations to create the necessary database tables.
bash
Copy code
dotnet ef database update
Build and Run the API:

Open the solution in Visual Studio or use the following command to run the API.
bash
Copy code
dotnet run
Test the API:

Open Swagger at https://localhost:<port>/swagger to interact with and test the API.
API Endpoints
1. GET /api/products
Fetches a list of all products with optional search and pagination.

Query Parameters:

brand: Filter by product brand.
type: Filter by product type.
name: Filter by product name.
page: The page number for pagination.
pageSize: Number of products per page (default is 10).
Response:

A paginated list of products.
2. POST /api/products
Adds a new product to the database.

Request Body:

name: Name of the product.
brand: Brand of the product.
type: Type/category of the product.
price: Price of the product.
Response:

The created product object.
3. PUT /api/products/{id}
Updates an existing product by ID.

Request Body:

name: Name of the product.
brand: Brand of the product.
type: Type/category of the product.
price: Price of the product.
Response:

The updated product object.
4. DELETE /api/products/{id}
Deletes a product by ID.

Response:

A success message indicating the product was deleted.
Error Handling
The API returns appropriate HTTP status codes for errors:

400 Bad Request for invalid data.
404 Not Found if a product is not found.
500 Internal Server Error for unhandled errors.
Pagination
The API supports pagination for fetching product lists. The page and pageSize query parameters allow the user to control the pagination.

Example: GET /api/products?page=2&pageSize=10




   

<a href="https://github.com/Sanskarjaas">GitHub --SanskarJaiswal--</a>

![localhost_7090_swagger_index html (1)](https://github.com/user-attachments/assets/e065996b-ae61-4ca2-9632-fbd6ed3e13bb)
