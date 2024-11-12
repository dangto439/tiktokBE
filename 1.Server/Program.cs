using _2.BLL;
using _3.DAL;
using _3.DAL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Cấu hình dịch vụ cho DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var serverVersion = ServerVersion.AutoDetect(connectionString);

builder.Services.AddDbContext<TiktokDbContext>(options =>
    options.UseMySql(connectionString, serverVersion));


// Thêm các dịch vụ khác vào DI container
builder.Services.ConfigureServices(builder.Configuration);

// Cấu hình CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

// Thêm các dịch vụ cho Controller và Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Cấu hình pipeline HTTP request
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Sử dụng CORS
app.UseCors("AllowAllOrigins");

app.UseAuthorization();
app.MapControllers();

// Thêm dữ liệu khởi tạo vào DB nếu chưa có
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<TiktokDbContext>();
    await SeedData.InitializeAsync(context);  // Khởi tạo dữ liệu nếu chưa có
}

app.Run();
