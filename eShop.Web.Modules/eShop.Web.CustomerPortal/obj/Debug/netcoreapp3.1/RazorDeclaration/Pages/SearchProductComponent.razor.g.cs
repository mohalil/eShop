// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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