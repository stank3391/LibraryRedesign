using Microsoft.Extensions.DependencyInjection;
using Group1Library.Models;

namespace YourNamespace
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<FirebaseService>(provider =>
            {
                // Configure and create an instance of FirebaseService
                string authSecret = "your-auth-secret";
                string basePath = "your-firebase-base-path";
                return new FirebaseService(authSecret, basePath);
            });

            // Add other services as needed

            // Configure other settings
        }

        // Configure method and other methods...
    }
}
