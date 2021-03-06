#pragma checksum "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/Orders.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b04842821a538d7be38e92b1d2025c5f56f2e1b"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/_Imports.razor"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/orders")]
    public partial class Orders : OwningComponentBase<IPurchaseRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Mission7.Pages.Admin.OrdersTable>(0);
            __builder.AddAttribute(1, "TableTitle", "Awaiting Fulfillment");
            __builder.AddAttribute(2, "Orders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Mission7.Models.Purchase>>(
#nullable restore
#line 4 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/Orders.razor"
                                                       AwaitingFulfillment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonLabel", "Shipped");
            __builder.AddAttribute(4, "OrderSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 5 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/Orders.razor"
                                                  ShipOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n\n");
            __builder.OpenComponent<Mission7.Pages.Admin.OrdersTable>(6);
            __builder.AddAttribute(7, "TableTitle", "Shipped Orders");
            __builder.AddAttribute(8, "Orders", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Mission7.Models.Purchase>>(
#nullable restore
#line 7 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/Orders.razor"
                                                 ShippedOrders

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ButtonLabel", "Reset");
            __builder.AddAttribute(10, "OrderSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 8 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/Orders.razor"
                                                ResetOrder

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-info");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/Orders.razor"
                                         x => UpdateData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Refresh Orders");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/ashleydenison/Documents/GitHub/Mission10/Mission7/Pages/Admin/Orders.razor"
       
    public IPurchaseRepository repo => Service;

    public IEnumerable<Purchase> AllOrders { get; set; }
    public IEnumerable<Purchase> AwaitingFulfillment { get; set; }
    public IEnumerable<Purchase> ShippedOrders { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllOrders = await repo.Purchases.ToListAsync();
        AwaitingFulfillment = AllOrders.Where(x => !x.OrderReceived);
        ShippedOrders = AllOrders.Where(x => x.OrderReceived);
    }

    public void ShipOrder(int id) => UpdateOrder(id, true);
    public void ResetOrder(int id) => UpdateOrder(id, false);

    private void UpdateOrder(int id, bool shipped)
    {
        Purchase p = repo.Purchases.FirstOrDefault(x => x.PurchaseId == id);
        p.OrderReceived = shipped;
        repo.SavePurchase(p);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
