using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BlazorLearn.Services;
using Blazored.LocalStorage;
using Blazored.Toast;

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

            /*
             * LocalStorage Eklenmesi 
             */
            builder.Services.AddBlazoredLocalStorage();
            /*
             * Toast Eklenmesi 
             */
            builder.Services.AddBlazoredToast();

            /* 
             * AddSingleton() : bu client için bir nesne oluþturuyor ve tamamen client uygulama boyunca onu kullanýyor. Ayný 
               referansý kullanýyor, böylece bunu defalarca new new yapmýyor. Data tutma iþlemi için kullanýlmaz. 
             * AddTransient() : her istekte service yenileniyor. Data tutan ortamlar vve o datayý paylaþmak istemediðimiz 
               ortamlarda kullanýrýz. Ayný nesne türünden iki kere istediðimizde iki kere new yapar.
             * AddScoped() : bir baðlantýda ayný nesneden iki kere istediðimizde bir tane new veriyor. 
             */

            /*
             * singleton : uygulama ilk ayaða kalktýðý anda, servisin tek bir instance’ý oluþturularak memory’de 
               tutulur ve daha sonrasýnda her servis çaðrýsýnda bu instance gönderilir.
             * scoped : her request için tek bir instance yaratýlmasýný saðlayan lifetime seçeneðidir. request cycle’ý 
               tamamlanana kadar gerçekleþen servis çaðrýlarýnda daha önce oluþturulan instance gönderilir. daha sonra yeni 
               bir request baþladýðýnda farklý bir instance oluþturulur.
             * transient : her servis çaðrýsýnda yeni bir instance oluþturulur. baðlayýcýlýðý en az olan lifetime seçeneðidir.
             * http://www.canertosuner.com/post/asp-net-core-dependency-injection
             */

            await builder.Build().RunAsync();
        }
    }
}
