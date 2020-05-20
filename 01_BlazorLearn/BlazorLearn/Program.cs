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
             * AddSingleton() : bu client i�in bir nesne olu�turuyor ve tamamen client uygulama boyunca onu kullan�yor. Ayn� 
               referans� kullan�yor, b�ylece bunu defalarca new new yapm�yor. Data tutma i�lemi i�in kullan�lmaz. 
             * AddTransient() : her istekte service yenileniyor. Data tutan ortamlar vve o datay� payla�mak istemedi�imiz 
               ortamlarda kullan�r�z. Ayn� nesne t�r�nden iki kere istedi�imizde iki kere new yapar.
             * AddScoped() : bir ba�lant�da ayn� nesneden iki kere istedi�imizde bir tane new veriyor. 
             */

            /*
             * singleton : uygulama ilk aya�a kalkt��� anda, servisin tek bir instance�� olu�turularak memory�de 
               tutulur ve daha sonras�nda her servis �a�r�s�nda bu instance g�nderilir.
             * scoped : her request i�in tek bir instance yarat�lmas�n� sa�layan lifetime se�ene�idir. request cycle�� 
               tamamlanana kadar ger�ekle�en servis �a�r�lar�nda daha �nce olu�turulan instance g�nderilir. daha sonra yeni 
               bir request ba�lad���nda farkl� bir instance olu�turulur.
             * transient : her servis �a�r�s�nda yeni bir instance olu�turulur. ba�lay�c�l��� en az olan lifetime se�ene�idir.
             * http://www.canertosuner.com/post/asp-net-core-dependency-injection
             */

            await builder.Build().RunAsync();
        }
    }
}
