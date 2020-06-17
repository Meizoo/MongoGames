using Microsoft.AspNetCore.Builder;

namespace MongoDBGames
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services) { }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) { }
    }
}