using SignalRWorkspace.Business;
using SignalRWorkspace.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>  options.AddDefaultPolicy(policy =>
{
    policy.AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    .SetIsOriginAllowed(origin => true);
}));
builder.Services.AddSignalR();
builder.Services.AddTransient<MyBusiness>();
builder.Services.AddControllers();
var app = builder.Build();

app.UseCors();
app.MapHub<MyHub>("/myhub"); 
app.MapControllers();
app.Run();
