namespace FootballScores.Web
{
    using FootballScores.Data;
    using FootballScores.Services.Contracts;
    using FootballScores.Services.Implementations;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<FootballStatsDbContext>(options =>
               options.UseSqlServer(
                  Configuration.GetConnectionString("DefaultConnection")),
                     ServiceLifetime.Transient);

            services.AddTransient<ILeagueService, LeagueService>();
            services.AddTransient<ITeamService, TeamService>();
            services.AddTransient<IFixtureService, FixtureService>();
            services.AddControllers();
            services.AddCors();

            services.AddSwaggerGen(c =>
               {
                   c.SwaggerDoc(
                       "v1",
                       new OpenApiInfo
                       {
                           Title = "FootballScores",
                           Version = "v1"
                       });
               });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseSwagger()
                .UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "FootballScoress v1");
                    options.RoutePrefix = string.Empty;
                })
                .UseCors(options => options
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod())
                .UseHttpsRedirection()
                .UseStaticFiles()
                .UseRouting()
                .UseAuthorization()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
        }
    }
}
