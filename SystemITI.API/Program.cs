using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Reflection;
using System.Text;
using SystemITI.API.Entity;
using SystemITI.API.Infrastructure.Abstracts;
using SystemITI.API.Infrastructure.Abstracts.Procedures;
using SystemITI.API.Infrastructure.Reposatories;
using SystemITI.API.persistence.context;
using SystemITI.API.Services.Implementation;
using SystemITI.API.Services.ServicesAbstracts;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
});
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>
    (options => options.UseSqlServer(connectionString));
builder.Host.UseSerilog((context, configuration) =>

    configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddIdentity<User, ApplicationRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddFluentValidationAutoValidation()
    .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IexamProcRepository, examProcRepository>();
builder.Services.AddScoped<IExamServices, ExamServices>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IJwtProvider, JwtProvider>();
var Jwtsetting = builder.Configuration.GetSection(JwtOptions.NameSection)
    .Get<JwtOptions>();
builder.Services.AddOptions<JwtOptions>()
    .BindConfiguration(JwtOptions.NameSection)
    .ValidateDataAnnotations()
    .ValidateOnStart();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
var jwtOptions = builder.Configuration.GetSection(JwtOptions.NameSection).Get<JwtOptions>();
options.TokenValidationParameters = new TokenValidationParameters
{
    ValidateIssuer = true,
    ValidIssuer = jwtOptions.Issuer,
    ValidateAudience = true,
    ValidAudience = jwtOptions.Audience,
    ValidateLifetime = true,
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.Key)),
    ValidateIssuerSigningKey = true
};
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseSerilogRequestLogging();
app.MapControllers();

app.Run();
