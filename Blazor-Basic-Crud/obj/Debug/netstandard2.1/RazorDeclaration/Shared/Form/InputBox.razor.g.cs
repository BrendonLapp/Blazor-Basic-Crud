// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor_Basic_Crud.Shared.Form
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
    public partial class InputBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\b_lap\Documents\GitHub\Blazor-Basic-Crud\Blazor-Basic-Crud\Shared\Form\InputBox.razor"
       

    private string _value;

    [Parameter]
    public string BindingValue
    {
        get => _value;
        set
        {
            if (_value == value) return;
            _value = value;
            BindingValueChanged.InvokeAsync(value);
        }
    }

    [Parameter]
    public EventCallback<string> BindingValueChanged { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
