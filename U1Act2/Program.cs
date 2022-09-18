var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();

app.UseFileServer();

app.UseRouting();

app.UseStaticFiles();

app.UseEndpoints(endpoints => endpoints.MapDefaultControllerRoute());

app.Run();
