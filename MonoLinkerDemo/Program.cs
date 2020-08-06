using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorMdc;

namespace MonoLinkerDemo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddMTAnimatedNavigationManager(new MTAnimatedNaviationManagerConfiguration()
            {
                ApplyAnimation = true,
                AnimationTime = 300
            });

            builder.Services.AddMTToastService(new MTToastServiceConfiguration()
            {
                Position = MTToastPosition.TopRight,
                CloseMethod = MTToastCloseMethod.Timeout,
            });

            await builder.Build().RunAsync();
        }
    }
}
