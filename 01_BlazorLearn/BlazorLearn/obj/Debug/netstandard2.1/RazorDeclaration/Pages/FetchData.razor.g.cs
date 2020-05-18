#pragma checksum "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd42c2e2afed39cfa0bae6dca1f3521d566e81eb"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
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
