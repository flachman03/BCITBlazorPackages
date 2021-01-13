using BCITBlazor.Common.Enums;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCITBlazor.Common.Tables.Definitions
{
    public class BCITDataTableCellDefinition
    {
        public BCITDataTableCellDefinition()
        {
            Actions = new BCITActions();
            CellType = BCITDataTableCellType.Text;
        }
        public BCITDataTableCellType CellType { get; set; }

        public string TextValue { get; set; }

        public string InputPlaceholder { get; set; }

        public BCITActions Actions { get; set; }

    }
}
