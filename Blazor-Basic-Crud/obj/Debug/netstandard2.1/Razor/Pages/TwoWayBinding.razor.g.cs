#pragma checksum "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\Pages\TwoWayBinding.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b0fa23cac319a8ac871cbb153c4114d41a3802"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Basic_Crud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using Blazor_Basic_Crud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using Blazor_Basic_Crud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using Blazor_Basic_Crud.Shared.Form;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\_Imports.razor"
using Blazor_Basic_Crud.Shared.Binding;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/two-way-binding")]
    public partial class TwoWayBinding : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 2 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\Pages\TwoWayBinding.razor"
     Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\n\nEnter the title in Parent:\n");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\Pages\TwoWayBinding.razor"
                                               Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Title = __value, Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n<br>\nDate value:\n");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\Pages\TwoWayBinding.razor"
                                               Date

#line default
#line hidden
#nullable disable
            , format: "dd-MM-yyyy"));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Date = __value, Date, format: "dd-MM-yyyy"));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n\n<hr>\n\n");
            __builder.OpenComponent<Blazor_Basic_Crud.Shared.Binding.ChildTwoWayBinding>(15);
            __builder.AddAttribute(16, "MainTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\Pages\TwoWayBinding.razor"
                                     Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "MainTitleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Title = __value, Title))));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\Pages\TwoWayBinding.razor"
        public string Title { get; set; } = "Two-Way Binding";
    public DateTime Date { get; set; } = new DateTime(2020, 02, 12); 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591