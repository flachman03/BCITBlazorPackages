using System;
using System.Collections.Generic;
using System.Text;

namespace BCITBlazor.Common.Tables.Definitions
{
    public class BCITDataTableDefinitions
    {
        public BCITDataTableDefinitions()
        {
            Columns = new List<BCITDataTableColumnDefinitions>();
        }
        public List<BCITDataTableColumnDefinitions> Columns { get; set; }

        public bool Sorting { get; set; }

        public bool Searching { get; set; }

    }
}
