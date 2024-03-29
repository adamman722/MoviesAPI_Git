using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

//var data = MoviesAPI_Git.Repo.LoanRepo.loans;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

//TODO: Figure out how to make it like the last api that points to swagger right off the rip

builder.Services.AddSwaggerGen(options =>{
    //This is needed if we wanted to make comments on our swagger doc.
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


