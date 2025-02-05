using Course.Application.Abstract;
using Course.Application.Concrete;
using Course.DataAccess.Abstract;
using Course.DataAccess.Concrete.EFEntityFramework;
using Course.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession();

#region AddScoped

builder.Services.AddScoped<IUserDal, EFUserDal>();
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddScoped<IBookDal, EFBookDal>();
builder.Services.AddScoped<IBookService, BookService>();

builder.Services.AddScoped<ICourseDal, EFCourseDal>();
builder.Services.AddScoped<ICourseService, CourseService>();

#endregion

#region Database registration
var conn = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(opt =>
{
    opt.UseSqlServer(conn);
});
#endregion

var app = builder.Build();



if (!app.Environment.IsDevelopment())   
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
