#pragma checksum "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a3270c24d021e239211f9a66beba183cc57a85a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\ToDo.razor"
       
    IList<TodoItem> todos = new List<TodoItem>();

    /* Yeni eklenecek işe karşılık gelen değişken “newTodo” ve bir buttona tıklanınca
     * eğer yeni iş adı null değil ise, “todos []” dizisine ekleyen “AddTodo()” methodu
     */

    string newTodo;

    void AddTodo()
    {

        if (!String.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            newTodo = "";
            Console.WriteLine("Kamil KAPLAN (Console)");
        }
    }

    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
