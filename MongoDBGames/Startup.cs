using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using MongoDB.Driver;

using MongoDBGames.Helpers;
using MongoDBGames.Model;
using MongoDBGames.Repository;

namespace MongoDBGames
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.Configure<Settings>(
                options =>
                {
                    options.ConnectionString =
                        Configuration.GetSection("MongoDb:ConnectionString").Value;
                    options.Database = Configuration.GetSection("MongoDb:Database").Value;
                });
            services.AddMvcCore().AddMvcOptions(x => x.EnableEndpointRouting = false);
            services.AddSingleton<IMongoClient, MongoClient>(
                _ => new MongoClient(Configuration.GetSection("MongoDb:ConnectionString").Value));

            services.AddTransient<IGameContext, GameContext>();
            services.AddTransient<IGameRepository, GameRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddAuthentication("BasicAuthenticationFilter");
        }

        [System.Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            app.UseMvc();
        }
    }
}