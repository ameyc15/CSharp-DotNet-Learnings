
using Day28_DependencyInjection.Managers;

namespace Day28_DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<UserManager>();
            builder.Services.AddScoped<EmployeeManager>();

            // IServiceCollection is the interface and ServiceClass has it's implementation
            // Dependency Injection is registered here on the basis of type depending upon the lifecycle management of 
            // objects 
            // 1. Singleton : one object throughout the lifetime of application
            // 2. Scopeed : new object for every http request
            // 3. Transient : fresh instance is created everytime it's requested 

            // usage : 
            // 1. singleton : caching, logging
            // 2. scoped : database connection
            // 3. lightweight stateless service, multi-threading, file upload in chunks

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
