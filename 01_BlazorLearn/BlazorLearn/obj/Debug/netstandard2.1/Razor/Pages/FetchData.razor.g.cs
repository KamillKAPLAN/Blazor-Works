#pragma checksum "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd42c2e2afed39cfa0bae6dca1f3521d566e81eb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorLearn.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using BlazorLearn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\_Imports.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenComponent<BlazorLearn.Shared.LoadingSpinner>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
#nullable restore
#line 12 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.AddMarkupContent(9, "<thead>\r\n            <tr>\r\n                <th>Date</th>\r\n                <th>Temp. (C)</th>\r\n                <th>Temp. (F)</th>\r\n                <th>Summary</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 25 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "tr");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 28 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 29 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 30 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 31 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 33 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(28, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 36 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    /* sayfa y�klendi�i anda �al��acak metodumuz 'OnInitializedAsync', b�yle bir haz�r
     * event'imiz var. Dikkat edersek biz bunu 'override' edebiliyoruz. */
    protected override async Task OnInitializedAsync()
    {
        /* bu bizim herhangi bir api'yede istek yapabildi�imizi g�steriyor. */
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        Console.WriteLine(Navigation.Uri); // �uanda hangi sayfada oldu�umuz 'Uri' vas�tas�yla alabiliyoruz.
        Navigation.NavigateTo("detail");
    }

    // Bizim i�in bir object(nesne) class'�d�r.
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }
        // C# 6 ile gelmi� bir �zellik bu �zelli�i direkt buradan okuyoruz.
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
