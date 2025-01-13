var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Map a basic endpoint
app.MapGet("/", () => "Hello, World!");

// Start the app
app.Run();

