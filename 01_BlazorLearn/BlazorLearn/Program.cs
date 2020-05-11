using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorLearn.Services;

namespace BlazorLearn
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            /* Dependency Injection IOS Begin */
            builder.Services.AddSingleton<IApiService, JsonPlacerHolderApi>();
            /* Dependency Injection IOS End */

            await builder.Build().RunAsync();
        }
    }
}
