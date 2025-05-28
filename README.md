# WebAPIKeyAuth

A simple implementation of API Key authentication middleware in ASP.NET Core.  
Useful for securing minimal APIs or internal endpoints with a shared key.

## 🔐 Features

- Lightweight API key authentication middleware  
- Easy to configure with minimal changes  
- Suitable for internal tools, microservices, or prototyping  

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/ejimeoghenefejiro/WebAPIKeyAuth.git
cd WebAPIKeyAuth
```
2. Configure the API Key
Set the expected API key in appsettings.json:

```bash
{
  "ApiKey": "your-secure-api-key"
}
```
3. Use the Middleware
Register the middleware in your Program.cs or Startup.cs:
```bash
app.UseMiddleware<ApiKeyMiddleware>();
```
Example Request
```bash
GET /weatherforecast HTTP/1.1
Host: localhost:5000
X-API-KEY: your-secure-api-key
```

Running the Project
```bash
dotnet run
```
🤝 Contributing

Contributions and stars are welcome! ⭐
Feel free to fork the repo and submit a pull request.
