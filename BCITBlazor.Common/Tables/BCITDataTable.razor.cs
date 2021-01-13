using BCITBlazor.Common.Enums;
using BCITBlazor.Common.Tables.Definitions;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCITBlazor.Common.Tables
{
    public class BCITDataTableBase : ComponentBase
    {
        [Parameter]
        public BCITDataTableDefinitions TableDefinitions { get; set; }

        public BCITDataTableCellDefinition CellDefinition { get; set; }

        public string Title { get; set; }

        public BCITDataTableBase()
        {
            CellDefinition = new BCITDataTableCellDefinition();
            CreateCellDefinition();
        }

        private void CreateCellDefinition()
        {
            CellDefinition.CellType = BCITDataTableCellType.InputText;
            CellDefinition.TextValue = "";
            CellDefinition.OnChange = InitiateOnChange;
            CellDefinition.OnEnter = InitiateOnEnter;
            CellDefinition.OnBlur = InitiateOnBlur;
            CellDefinition.OnKeyUp = InitiateOnKeyUp;
            Title = "Test Title";
        }

        public void InitiateOnChange()
        {
            Console.WriteLine("DataTable layer Initiate on Change");

            Title = CellDefinition.TextValue;
            StateHasChanged();
        }

        public void InitiateOnEnter()
        {
            Console.WriteLine("DataTable layer Initiate on enter");

            Title = CellDefinition.TextValue;
            StateHasChanged();
        }

        public void InitiateOnBlur()
        {
            Console.WriteLine("DataTable layer Initiate on Blur");

            Title = CellDefinition.TextValue;
            StateHasChanged();
        }

        public void InitiateOnKeyUp()
        {
            Console.WriteLine("DataTable layer Initiate on Keyup");

            Title = CellDefinition.TextValue;
            StateHasChanged();
        }

    }
}
