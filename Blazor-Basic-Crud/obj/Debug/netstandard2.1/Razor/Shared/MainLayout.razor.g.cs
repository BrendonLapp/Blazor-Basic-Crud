#pragma checksum "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab8a95ec8b354d3d92bf95898e66807810901c96"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_Basic_Crud.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazor_Basic_Crud.Shared.NavBar>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "main");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "content px-4");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddContent(8, 
#nullable restore
#line 6 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
