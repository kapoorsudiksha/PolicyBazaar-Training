var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

//app.UseDefaultFiles();
//app.UseStaticFiles();

DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
defaultFilesOptions.DefaultFileNames.Clear();
defaultFilesOptions.DefaultFileNames.Add("home.html");
defaultFilesOptions.DefaultFileNames.Add("dashboard.html");
app.UseDefaultFiles(defaultFilesOptions);

app.UseStaticFiles();

app.Run();
