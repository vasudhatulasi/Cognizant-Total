# JWT Authentication in ASP.NET Core Web API

This project demonstrates:
- JWT Authentication
- Securing endpoints using [Authorize]
- Role-based Authorization
- Handling expired tokens

## Endpoints
- POST /api/auth/login
- GET /api/secure/data (Protected)
- GET /api/admin/dashboard (Admin only)

## How to Run
dotnet restore  
dotnet run  

## Usage
Add header:
Authorization: Bearer <token>
