using BCITBlazor.Common.Tables.Definitions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCITBlazor.Common.Tables
{
    public class BCITDataTableCellBase : ComponentBase
    {
        [Parameter]
        public BCITDataTableCellDefinition Cell { get; set; }

        [Parameter]
        public BCITDataTableColumnDefinitions Column { get; set; }
        

        public void InitiateOnKeyUp(KeyboardEventArgs e)
        {
            if(e.Key == "Enter")
            {
                Cell.Actions.OnEnter?.Invoke(Cell.TextValue);
            }
            else 
            { 
                
                Cell.Actions.OnKeyUp?.Invoke(Cell.TextValue);
            }
        }

        public void InitiateOnBlur(FocusEventArgs e)
        {
            Cell.Actions.OnBlur?.Invoke(Cell.TextValue);
        }

        public void InitiateOnchange(ChangeEventArgs e)
        {
            Console.WriteLine(e.Value);
        }
    }
}
