#pragma checksum "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductItemComponent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cecd8852c71c2b529bff3c5a908af0e74049bd2ca2bbf18739b5f30433db6f1b"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Web.CustomerPortal.Controls
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.ViewProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.Web.CustomerPortal.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.CoreBusiness.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using eShop.UseCases.SearchProductScreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductItemComponent.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
    public partial class ProductItemComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductItemComponent.razor"
 if(this.Product != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "tr");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "td");
            __builder.AddMarkupContent(4, "\r\n            ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "Href", (object)(
#nullable restore
#line 10 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductItemComponent.razor"
                             $"product/{Product.ProductId}"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 10 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductItemComponent.razor"
__builder2.AddContent(8, Product.Name);

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n            \r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 13 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductItemComponent.razor"
__builder.AddContent(12, Product.Brand);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 14 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductItemComponent.razor"
__builder.AddContent(15, Product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 16 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductItemComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Controls\ProductItemComponent.razor"
       
    [Parameter]
    public Product Product { get; set; }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IViewProductUseCase viewProduct { get; set; }
    }
}
#pragma warning restore 1591
