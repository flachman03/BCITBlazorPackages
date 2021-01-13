using System;
using System.Collections.Generic;
using System.Text;

namespace BCITBlazor.Common.Tables.Definitions
{
    public class BCITDataTableDefinitions
    {
        public BCITDataTableDefinitions()
        {
            HeaderDefinitions = new BCITHeaderDefinitions();
        }
        public BCITHeaderDefinitions HeaderDefinitions { get; set; }

        public bool Sorting { get; set; }

        public bool Searching { get; set; }

    }
}
