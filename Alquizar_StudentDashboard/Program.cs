// Magsugod ta sa atong web application
var builder = WebApplication.CreateBuilder(args);

// Idugang ang mga services sa container
// Ang Razor Pages kay importante ni para sa atong mga views
builder.Services.AddRazorPages();

// I-build na nato ang application
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
