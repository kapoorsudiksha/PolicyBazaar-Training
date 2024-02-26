var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
   await context.Response.WriteAsync("Middleware A => ");
    await next();
    await context.Response.WriteAsync("Middleware A (End)");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware B => ");
    await next();
    await context.Response.WriteAsync("Middleware B (End)  =>") jj j j j
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware C => ");
    await next();
    await context.Response.WriteAsync("Middleware C (End) => ");
});

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Middleware Last => ");
});

app.Run();
