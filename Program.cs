using NAC_Aircraft_Checklist.Data;
using NAC_Aircraft_Checklist.Services.Mail;
using Microsoft.EntityFrameworkCore;
using NAC_Aircraft_Checklist.Data.Services;
using NAC_Aircraft_Checklist.Data.Services.MasterTables;
using NAC_Aircraft_Checklist.Models.Tables;
using NAC_Aircraft_Checklist.Models.Entry.B1900;
using NAC_Aircraft_Checklist.Data.Services.Proof;
using NAC_Aircraft_Checklist.Data.Services.Email;
using Hangfire;
using NAC_Aircraft_Checklist.Services.Jobs;
using Microsoft.AspNetCore.Identity;
using NAC_Aircraft_Checklist.Data.Services.Revision;
using NAC_Aircraft_Checklist.Data.Services.Documents;
using NAC_Aircraft_Checklist.Data.Services.ProofRead;
using NAC_Aircraft_Checklist.Models.Users;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions()
{
    EnvironmentName = Microsoft.Extensions.Hosting.Environments.Production
});


//var builder = WebApplication.CreateBuilder(args);

//Connect to the database server
// Services need to be added
//All activities
//
builder.Services.AddDbContextFactory<AppDbContext>(optionsAction: options =>
{

    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
/*
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
}).AddRoles<IdentityRole>()
.AddEntityFrameworkStores<AppDbContext>();
*/
builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
    options.SignIn.RequireConfirmedEmail = false; options.SignIn.RequireConfirmedAccount = false;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<IJobService, JobService>();
builder.Services.AddHangfire(configuration =>
{
    configuration.UseSqlServerStorage(builder.Configuration.GetConnectionString("DefaultConnection"));

});

builder.Services.AddHealthChecks();
builder.Services.AddHangfireServer();
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddTransient<INACEmailSender, EmailSender>();
builder.Services.AddScoped<IRevisionService, RevisionService>();

builder.Services.AddRazorPages();
//MasterList services
builder.Services.AddScoped<IMasterListService, MasterListService>();
//Proof Service
//Document Service
builder.Services.AddScoped<IB1900DocumentService, B1900DocumentService>();
builder.Services.AddScoped<ILearjetDocumentService, LearjetDocumentService>();


builder.Services.AddScoped<IProofReadService, ProofReadService>();
builder.Services.AddScoped<IB1900ProofService, B1900ProofService>();
builder.Services.AddScoped<ILearjetProofService, LearjetProofService>();

builder.Services.AddScoped<IMasterBaseService<B1900InteriorMaster>, B1900MasterService.MasterInteriorListService>();

builder.Services.AddScoped<IMasterBaseService<B1900ExteriorMaster>, B1900MasterService.MasterExteriorListService>();

builder.Services.AddScoped<IMasterBaseService<B1900CockpitMaster>, B1900MasterService.MasterCockpitService>();

builder.Services.AddScoped<IMasterBaseService<B1900CabinMaster>, B1900MasterService.MasterCabinService>();

builder.Services.AddScoped<IMasterBaseService<B1900FlightRedFolderMaster>, B1900MasterService.MasterFlightFolderService>();

builder.Services.AddScoped<IMasterBaseService<B1900ManualsMaster>, B1900MasterService.MasterManualsService>();

builder.Services.AddScoped<IMasterBaseService<B1900ManualsIPadMaster>, B1900MasterService.MasterManualsIPadService>();

builder.Services.AddScoped<IMasterBaseService<B1900OpsDocsEquipmentMaster>, B1900MasterService.MasterOpsDocsService>();

builder.Services.AddScoped<IMasterBaseService<B1900AircraftFlipFileMaster>, B1900MasterService.MasterAircraftFlipFileService>();

builder.Services.AddScoped<IMasterBaseService<B1900EquipmentMaster>, B1900MasterService.MasterEquipmentService>();
//
//Learjet Master list

builder.Services.AddScoped<IMasterBaseService<LearjetInteriorMaster>, LearjetMasterService.MasterInteriorListService>();
builder.Services.AddScoped<IMasterBaseService<LearjetExteriorMaster>, LearjetMasterService.MasterExteriorListService>();
builder.Services.AddScoped<IMasterBaseService<LearjetCockpitMaster>, LearjetMasterService.MasterCockpitService>();
builder.Services.AddScoped<IMasterBaseService<LearjetCabinMaster>, LearjetMasterService.MasterCabinService>();
builder.Services.AddScoped<IMasterBaseService<LearjetFlightFolderMaster>, LearjetMasterService.MasterFlightFolderService>();
builder.Services.AddScoped<IMasterBaseService<LearjetAircraftFlipFileMaster>, LearjetMasterService.MasterAircraftFlipFileService>();
builder.Services.AddScoped<IMasterBaseService<LearjetManualsMaster>, LearjetMasterService.MasterManualsService>();
builder.Services.AddScoped<IMasterBaseService<LearjetManualsEFBMaster>, LearjetMasterService.MasterManualsEFBService>();
builder.Services.AddScoped<IMasterBaseService<LearjetOperationDocumentsEquipmentMaster>, LearjetMasterService.MasterOpsDocsService>();
builder.Services.AddScoped<IMasterBaseService<LearjetEquipmentMaster>, LearjetMasterService.MasterEquipmentService>();



builder.Services.AddScoped<IAircraftService, AircraftService>();

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication().AddCookie(options =>
{
    //options.LoginPath = "/Home/Login";
    options.LoginPath = "/Home/Login";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(40);
});
builder.Services.AddHttpContextAccessor();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseHangfireDashboard();
app.MapHealthChecks("/health");
app.UseRouting();
app.UseAuthorization();
//New below
app.UseCookiePolicy(new CookiePolicyOptions { 
    MinimumSameSitePolicy= SameSiteMode.Lax
});
//app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var roles = new[] { "Admin", "Manager", "BaseManager", "Planner" };
    foreach (var role in roles)
    {
        if (roleManager != null)
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
    }
}

using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

    string email = "acadmin@nac.co.za";
    string password = "Admin@Acforms1946";

    if (await userManager.FindByEmailAsync(email) == null)
    {

        var user = new ApplicationUser();
        user.UserName = email;
        user.Email = email;
        user.EmailConfirmed = true;

        await userManager.CreateAsync(user, password);

        await userManager.AddToRoleAsync(user, "Admin");
    }
}



app.Run();

/*
using (var scope = app.Services.CreateScope())
{
    
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    var roles = new[] { "Admin", "Manager", "BaseManager", "Planner" };

    foreach (var role in roles)
    {
        if (roleManager != null)
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
    }
    
}
using (var scope = app.Services.CreateScope())
{
    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
    
    string adminEmail = "steven.novukuza@nac.co.za";
    string adminPassword = "@dmin@N@C";

    if (await userManager.FindByEmailAsync(adminEmail) == null)
    {
        var user = new IdentityUser();
        user.UserName = adminEmail;
        user.Email = adminEmail;
        await userManager.CreateAsync(user, adminPassword);
        //await userManager.AddToRoleAsync(user, "Admin");
    }
}
*/
