using Shop.Data.DataBase;
using Shop.Data.Interfaces;
using Shop.Data.Mocks;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(option => option.EnableEndpointRouting = false);


builder.Services.AddTransient<ICategorys, DBCategory>();
builder.Services.AddTransient<IItems, DBItems>();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.Run();
