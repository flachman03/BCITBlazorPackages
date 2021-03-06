#pragma checksum "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\Tables\BCITDataTableCell.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fb59f3addb8300a54d0ee3ea1367cb7114e58b2"
// <auto-generated/>
#pragma warning disable 1591
namespace BCITBlazor.Common.Tables
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\_Imports.razor"
using BCITBlazor.Common.Enums;

#line default
#line hidden
    public partial class BCITDataTableCell : BCITDataTableCellBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "td");
            __builder.AddMarkupContent(1, "\r\n");
#line 4 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\Tables\BCITDataTableCell.razor"
     if(Cell.CellType == BCITDataTableCellType.Text)
    {

#line default
#line hidden
            __builder.AddContent(2, "        ");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, 
#line 6 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\Tables\BCITDataTableCell.razor"
            Cell.TextValue

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#line 7 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\Tables\BCITDataTableCell.razor"
    }

#line default
#line hidden
            __builder.AddMarkupContent(6, "\r\n");
#line 9 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\Tables\BCITDataTableCell.razor"
     if(Cell.CellType == BCITDataTableCellType.InputText)
    {

#line default
#line hidden
            __builder.AddContent(7, "        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#line 11 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\Tables\BCITDataTableCell.razor"
                          Cell

#line default
#line hidden
            ));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 12 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\Tables\BCITDataTableCell.razor"
                                                               InitiateOnChange

#line default
#line hidden
                ));
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 12 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\Tables\BCITDataTableCell.razor"
                                     Cell.TextValue

#line default
#line hidden
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Cell.TextValue = __value, Cell.TextValue))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Cell.TextValue));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
#line 14 "C:\Users\rflachman.BCMGT\source\repos\BCITBlazorPackages\BCITBlazor.Common\Tables\BCITDataTableCell.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
