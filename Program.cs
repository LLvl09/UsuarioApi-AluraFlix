using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UsuarioAluraFlix.Data;
using UsuarioAluraFlix.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//adicionando banco de dados
builder.Services.AddDbContext<UserDbContext>(opts => opts.UseMySql("Server=localhost;User ID=root;Password=ads.Microsoft2;Database=UsuariosAluraFlix", ServerVersion.Parse("8.0.29")));
//adicionando e configurando o identity
builder.Services.AddIdentity<IdentityUser<int>, IdentityRole<int>>()
    .AddEntityFrameworkStores<UserDbContext>()
    .AddDefaultTokenProviders();

//Adicionando AutoMapper
//Adicionando parametros ao escopo 
builder.Services.AddScoped<TokenService, TokenService>();
builder.Services.AddScoped<LogoutService, LogoutService>();


var app = builder.Build();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
