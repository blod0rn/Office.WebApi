using Microsoft.EntityFrameworkCore;
using Office.Web.DAL;
using Office.Web.Domain;
using Office.Web.Domain.IServices;
using Office.Web.Domain.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<OfficedbContext>(opt =>
{
    opt.UseNpgsql("Host=localhost;Port=5432;Database=officeDb;Username=postgres;Password=admin");
}
);
    
    
builder.Services.AddTransient<IDbRepository, DbRepository>();
builder.Services.AddTransient<IUserService, UserService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();




app.Run();
