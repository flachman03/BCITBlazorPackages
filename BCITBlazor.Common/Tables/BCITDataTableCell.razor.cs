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
        

        public void InitiateOnKeyUp(KeyboardEventArgs e)
        {
            if(e.Key == "Enter")
            {
                Cell.OnEnter?.Invoke();
            }
            else 
            { 
                
                Cell.OnKeyUp?.Invoke();
            }
        }

        public void InitiateOnBlur(FocusEventArgs e)
        {
            Cell.OnBlur?.Invoke();
        }

        public void InitiateOnchange(ChangeEventArgs e)
        {
            Console.WriteLine(e.Value);
        }
    }
}
