#pragma checksum "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\App.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "118cb64c11d4bf038ec6f3943d0f3b0b30b77dc1c9ac3f11b958ce62cbc83f2b"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Web
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\_Imports.razor"
using eShop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\_Imports.razor"
using eShop.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "AdditionalAssemblies", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<System.Reflection.Assembly>>(
#nullable restore
#line 3 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\App.razor"
                           new[] {
    typeof(eShop.Web.CustomerPortal.Pages.SearchProductComponent).Assembly
}

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.RouteView>(5);
                __builder2.AddAttribute(6, "RouteData", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 7 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(7, "DefaultLayout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 7 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
            }
            ));
            __builder.AddAttribute(9, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(11);
                __builder2.AddAttribute(12, "Layout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 10 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "\r\n            ");
                    __builder3.AddMarkupContent(15, "<p>Sorry, there\'s nothing at this address.</p>\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
