using System;
using System.Collections.Generic;
using System.Text;

namespace BCITBlazor.Common.Tables.Definitions
{
    public class BCITActions
    {
        public Action<string> OnChange { get; set; }

        public Action<string> OnKeyUp { get; set; }

        public Action<string> OnEnter { get; set; }

        public Action<string> OnBlur { get; set; }
    }
}
