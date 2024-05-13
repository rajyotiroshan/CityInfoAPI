var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();//reister all controllers related services.
//builder.Services.AddMvc();//regoster extra servi7//ces.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();


app.UseAuthorization();

//app.MapControllers();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); //add endpoints to controller actions witout specifyig routes
    //routes specification will happen through attribute routing
});

app.Run();

