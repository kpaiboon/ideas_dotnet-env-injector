var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) =>
{
    var httpHost = context.Request.Headers["Host"].FirstOrDefault() ?? "N/A";
    var xForwardedFor = context.Request.Headers["X-Forwarded-For"].FirstOrDefault() ?? "N/A";
    var greetingMsg = Environment.GetEnvironmentVariable("GREETING_TEXT") ?? "Hi1_rabbit";
    
    app.Logger.LogInformation("Request from {Host}, X-Forwarded-For: {XFF}, Greeting: {Msg}", httpHost, xForwardedFor, greetingMsg);
    
    context.Response.ContentType = "text/html";
    return $@"<html><body>
<h1>Environment Info</h1>
<p><strong>HTTP_HOST:</strong> {httpHost}</p>
<p><strong>X-Forwarded-For:</strong> {xForwardedFor}</p>
<p><strong>GREETING_TEXT:</strong> {greetingMsg}</p>
<p><strong>Container:</strong> {Environment.MachineName}</p>
<p><strong>Time:</strong> {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} UTC</p>
</body></html>";
});

app.Run();