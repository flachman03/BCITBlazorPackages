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

        public List<BCITDataTableCellDefinition> CellDefinition { get; set; }

        public string Title { get; set; }

        public BCITDataTableBase()
        {
            CellDefinition = new List<BCITDataTableCellDefinition>();
            CellDefinition.Add(CreateCellDefinition());
            CellDefinition.Add(CreateCellDefinition());
            CellDefinition.Add(CreateCellDefinition());
            CellDefinition.Add(CreateCellDefinition());
            CellDefinition.Add(CreateCellDefinition());
            CellDefinition.Add(CreateCellDefinition());
        }

        private BCITDataTableCellDefinition CreateCellDefinition()
        {
            var cell = new BCITDataTableCellDefinition();
            cell.CellType = BCITDataTableCellType.InputText;
            cell.TextValue = "";
            cell.Actions.OnChange = InitiateOnChange;
            cell.Actions.OnEnter = InitiateOnEnter;
            cell.Actions.OnBlur = InitiateOnBlur;
            cell.Actions.OnKeyUp = InitiateOnKeyUp;
            Title = "Test Title";

            return cell;
        }

        public void InitiateOnChange(string value)
        {
            Console.WriteLine("DataTable layer Initiate on Change");

            Title = value;
            StateHasChanged();
        }

        public void InitiateOnEnter(string value)
        {
            Console.WriteLine("DataTable layer Initiate on enter");

            Title = value;
            StateHasChanged();
        }

        public void InitiateOnBlur(string value)
        {
            Console.WriteLine("DataTable layer Initiate on Blur");

            Title = value;
            StateHasChanged();
        }

        public void InitiateOnKeyUp(string value)
        {
            Console.WriteLine("DataTable layer Initiate on Keyup");

            Title = value;
            StateHasChanged();
        }

    }
}
