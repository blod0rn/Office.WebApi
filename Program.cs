using Microsoft.EntityFrameworkCore;
using Office.Web.DAL;
using Office.Web.DAL.IRepositories;
using Office.Web.DAL.Repositories;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Services;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
    builder =>
    {
        builder.AllowAnyOrigin()
                            .AllowAnyHeader()
                            .AllowAnyMethod();
    });
});

builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<OfficedbContext>(opt =>
{
    opt.UseNpgsql("Host=localhost;Port=5432;Database=officeDb;Username=postgres;Password=admin");
}
);

    
    
builder.Services.AddTransient<IDbRepository, DbRepository>();

builder.Services.AddTransient<IDepartamentRepository, DepartamentRepository>();
builder.Services.AddTransient<IDepartamentService, DepartamentService>();

builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserService2, UserService2>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();




app.Run();
