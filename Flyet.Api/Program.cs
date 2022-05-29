global using Flyet.Api.Data;
global using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseMySql("server=flyet-db.mysql.database.azure.com;user=Flyet_admin;password=RbBk)37r;database=flyet", 
        ServerVersion.AutoDetect("server=flyet-db.mysql.database.azure.com;user=Flyet_admin;password=RbBk)37r;database=flyet"), null);
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:3000");
                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseCors(MyAllowSpecificOrigins);


// test
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
