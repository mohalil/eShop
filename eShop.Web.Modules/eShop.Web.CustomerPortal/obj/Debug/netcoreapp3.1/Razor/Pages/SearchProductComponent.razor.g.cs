#pragma checksum "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductComponent.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9ba3fa03934e892f4719d81211ee21dacd1f36561b5b465a881de12734234b9e"
// <auto-generated/>
#pragma warning disable 1591
namespace eShop.Web.CustomerPortal.Pages
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
#line 7 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class SearchProductComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Product</h3>\r\n<br>\r\n");
            __builder.OpenComponent<global::eShop.Web.CustomerPortal.Controls.SearchBarComponent>(1);
            __builder.AddAttribute(2, "OnSearch", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 9 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductComponent.razor"
                              HandleSearch

#line default
#line hidden
#nullable disable
            ))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n<br>\r\n\r\n");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.AddMarkupContent(7, "<thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Brand</th>\r\n            <th>Price</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 21 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductComponent.razor"
         if (products != null || products.Count() < 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductComponent.razor"
             foreach (var product in products)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenComponent<global::eShop.Web.CustomerPortal.Controls.ProductItemComponent>(11);
            __builder.AddAttribute(12, "Product", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::eShop.CoreBusiness.Models.Product>(
#nullable restore
#line 25 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductComponent.razor"
                                               product

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 26 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductComponent.razor"
             
        }else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.AddMarkupContent(15, "<tr>\r\n                <td colspan=\"3\">\r\n                    Cannot find Products\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\mohalil.naikwadi\Documents\Personal Projects\Blazor eCommerce Project\eShop\eShop.Web.Modules\eShop.Web.CustomerPortal\Pages\SearchProductComponent.razor"
       
    private IEnumerable<Product> products;
    // List<Product> sproducts = new List<Product>();
    protected override void OnInitialized()
    {
        base.OnInitialized();

        products = searchProduct.Execute();
    }

    private void HandleSearch(string filter)
    {
        products = searchProduct.Execute(filter);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISearchProductUseCase searchProduct { get; set; }
    }
}
#pragma warning restore 1591
