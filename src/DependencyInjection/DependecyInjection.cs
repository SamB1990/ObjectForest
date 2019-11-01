using System.Forest.Services;
using Microsoft.Extensions.DependencyInjection;

namespace System.Forest
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddObjectForest(this IServiceCollection services)
        {
            services.AddSingleton<ITreeService, TreeService>();
            services.AddSingleton<IBranchConstructor, BranchConstructor>();
            services.AddSingleton<IBranchService, BranchService>();
            services.AddSingleton<IBranchConstructor, BranchConstructor>();
            return services;
        }
    }
}
