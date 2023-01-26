using buber.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);


{
builder.Services.AddControllers();
builder.Services.AddScoped<Ibreakfast, BreakfastService>();

}



var app = builder.Build();

// Configure the HTTP request pipeline.

{
//app.UseExceptionHandler("/error");
app.UseHttpsRedirection();

app.MapControllers();
app.Run();
}

