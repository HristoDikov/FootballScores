namespace FootballScores.Web
{
    using FootballScores.Data;
    using Microsoft.OpenApi.Models;
    using Microsoft.Extensions.Hosting;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using FootballScores.Services.Contracts;
    using Microsoft.Extensions.Configuration;
    using FootballScores.Services.Implementations;
    using Microsoft.Extensions.DependencyInjection;

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

            services.AddAutoMapper(typeof(ILeagueService).Assembly);

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
