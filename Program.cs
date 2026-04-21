namespace aspnetcorewebapi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Add CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAngular",
                    policy =>
                    {
                        policy.WithOrigins("http://localhost:4200")
                              .AllowAnyHeader()
                              .AllowAnyMethod();
                    });
            });
            builder.Services.AddControllers();

            
            //builder.Services.AddHsts(hsts =>
            //{
            //    hsts.MaxAge = TimeSpan.FromDays(1);
            //});

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            //app.UseHsts();
            //app.UseHttpsRedirection();

            app.UseCors("AllowAngular");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
            Console.WriteLine(app.Environment.EnvironmentName);
        }
    }
}
