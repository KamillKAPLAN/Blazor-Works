#pragma checksum "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\Validation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "481c942509b86cac87c9e1531e9857f3a553793c"
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
#line 2 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\Validation.razor"
using BlazorLearn.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/validation")]
    public partial class Validation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Validation</h3>\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\Validation.razor"
                  productAddModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\Validation.razor"
                                                   HandleSave

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, " \r\n    ");
                __builder2.AddMarkupContent(8, "<h4>Product Name : </h4>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "id", "productName");
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\Validation.razor"
                                                                   productAddModel.ProductName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productAddModel.ProductName = __value, productAddModel.ProductName))));
                __builder2.AddAttribute(14, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productAddModel.ProductName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, " <br>\r\n    ");
                __builder2.AddMarkupContent(16, "<h4>Product Description : </h4>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "id", "description");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\Validation.razor"
                                                                   productAddModel.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => productAddModel.Description = __value, productAddModel.Description))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => productAddModel.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, " <br>\r\n    ");
                __builder2.AddMarkupContent(24, "<button class=\"btn btn-success\" type=\"submit\">Kaydet</button> <br> <br>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(25);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, " \r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\kamil\Desktop\GitHubWorks\Blazor_Works\01_BlazorLearn\BlazorLearn\Pages\Validation.razor"
       
    /*
     * 'validation^ı' devreye sokanbilmemiz için öncelikle bu
     * sayamızın çalışacağı modeli belirlememiz gerekmektedir.
     */
    ProductAddModel productAddModel = new ProductAddModel();

    private void HandleSave()
    {
        Console.WriteLine("Product Added");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
