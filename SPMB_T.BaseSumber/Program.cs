using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Rotativa.AspNetCore;
using SPMB_T._DataAccess.Data;
using SPMB_T._DataAccess.Data.DataConfigurations;
using SPMB_T._DataAccess.Services;
using SPMB_T.BaseSumber.Infrastructure;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    ContentRootPath = Directory.GetCurrentDirectory()
});

var env = builder.Environment;

// Add services to the container.
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(60);
});

builder.Services.AddDbContext<ApplicationDbContext>(
                options =>
                {
                    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                    options.UseTriggers(triggerOptions =>
                    {
                        triggerOptions.AddTrigger<SoftDeleteTrigger>();
                        triggerOptions.AddTrigger<SoftDeleteTransactionTrigger>();

                    });

                });


builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>()
    .AddTokenProvider<DataProtectorTokenProvider<IdentityUser>>(TokenOptions.DefaultProvider);

builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequiredLength = 5;
    opt.Password.RequireLowercase = true;
    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(20);
    opt.Lockout.MaxFailedAccessAttempts = 3;
}
);
builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.AccessDeniedPath = new PathString("/Home/Accessdenied");
    opt.ExpireTimeSpan = TimeSpan.FromSeconds(600);
    opt.LoginPath = "/Account/Login";
    opt.SlidingExpiration = true;
    opt.LogoutPath = "/Account/LogOff";
});

builder.Services.AddDIContainer();

builder.Services.AddSystemAuthorization();

// Add services to the container.
builder.Services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

builder.Services.Configure<RazorViewEngineOptions>(options =>
{
    options.PageViewLocationFormats.Add("/Pages/Partials/{0}.cshtml" + RazorViewEngine.ViewExtension);
});

builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(60);
});

var app = builder.Build();

Configure(app);

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

RotativaConfiguration.Setup(env.ContentRootPath, "wwwroot/plugins/Rotativa");

app.Run();

void Configure(WebApplication host)
{
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;


    try
    {
        var dbContext = services.GetRequiredService<ApplicationDbContext>();

        SeedData.Initialize(dbContext);

        var userManager = services.GetRequiredService<UserManager<IdentityUser>>();
        SeedData.SeedUsers(userManager, dbContext);


    }
    catch
    {
        throw;
    }
}
