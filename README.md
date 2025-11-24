# .NET Environment Injector

Displays HTTP_HOST, X-Forwarded-For headers, and custom greeting message.

## Run with Docker
```bash
docker run -p 8128:8080 -e GREETING_TEXT="Custom Message" ghcr.io/olive-techno/ideas_dotnet-env-injector:main
```
Access at: `http://localhost:8128`

## Run with Docker Compose
```bash
docker-compose up
```
Access at: `http://localhost:8128`

## Environment Variables
- `GREETING_TEXT` - Custom greeting message (default: "Hi1_rabbit")
- `ASPNETCORE_URLS` - Listening URL (default: http://+:8080)

## Features
- Shows HTTP_HOST header
- Shows X-Forwarded-For header
- Shows custom GREETING_TEXT
- Shows container hostname
- Shows UTC timestamp
- Health check endpoint
- Request logging

## GitHub Container Registry
Images automatically built and pushed to `ghcr.io` on push to main/develop branches or tags.