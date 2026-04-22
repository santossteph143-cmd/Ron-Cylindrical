var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();   // ✅ THIS replaces MapStaticAssets

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();   // ✅ No WithStaticAssets needed

app.Run();
