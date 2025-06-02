# WebAPIKeyAuth

Secure Your `ASP.NET` Core APIs with Custom Key-Based Authentication
This middleware implementation provides a lightweight yet robust authentication layer for `ASP.NET` Core applications where traditional OAuth or JWT solutions may be overkill. Perfect for internal microservices, administrative endpoints, or third-party integrations that require simple but effective access control.

## 🔐 Key Features

Enterprise-Ready Security Made Simple

- **Zero-Configuration Authentication:** Drop-in middleware that secures your endpoints immediately without complex setup or external dependencies
- **Developer-Friendly Integration:** Seamlessly integrates into existing `ASP.NET` Core applications with just a few lines of code - no architectural changes required
- **Production-Tested Reliability:** Battle-tested solution perfect for high-traffic microservices, internal tooling, and rapid prototype-to-production scenarios

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
