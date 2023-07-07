var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseDefaultFiles(); //default.html, default.htm, index.html, index.htm
app.UseStaticFiles(); // add support static files

//using parametres
app.MapGet("/contact/{name}/{surname}", (string name, string surname) => $"Contact me, {name} {surname}! ");
app.MapGet("/contact/{name}", (string name) => $"Contact me, {name} ! ");
app.MapGet("/contact", () => "Contact me! ");
app.MapGet("/about", () => "About me!");
//app.MapGet("/", () => "Hello World!");


app.Run();
