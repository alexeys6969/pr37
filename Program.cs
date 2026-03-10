using Shop.Data.Interfaces;
using Shop.Data.Mocks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);


builder.Services.AddTransient<ICategorys, MockCaregories>();
builder.Services.AddTransient<IItems, MockItems>();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.Run();
