using BCITBlazor.Common.Enums;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCITBlazor.Common.Tables.Definitions
{
    public class BCITDataTableCellDefinition
    {
        public BCITDataTableCellType CellType { get; set; }

        public string TextValue { get; set; }

        public string InputPlaceholder { get; set; }

        public Action OnChange { get; set; }

        public Action OnKeyUp { get; set; }

        public Action OnEnter { get; set; }

        public Action OnBlur { get; set; }

    }
}
