using BCITBlazor.Common.Shared;
using BCITBlazor.Common.Tables.Definitions;
using BCITBlazor.UI.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCITBlazor.Common.Enums;

namespace BCITBlazor.UI.Pages
{
    public class IndexBase : ComponentBase
    {
        public IMockDataService _mockDataService { get; set; }

        public List<BCITSelectListItem> ListItems { get; set; }

        public BCITDataTableDefinitions TableDefinitions { get; set; }

        public IndexBase()
        {
            _mockDataService = new MockDataService();
            ListItems = _mockDataService.GetListItems();
            TableDefinitions = new BCITDataTableDefinitions();
            CreateTableDefinitions();
        }

        private void CreateColumnDefinitions()
        {
            TableDefinitions.Columns.Add(new BCITDataTableColumnDefinitions() { Header = "Stock #" });
            TableDefinitions.Columns.Add(new BCITDataTableColumnDefinitions() { Header = "Vehicle" });
            TableDefinitions.Columns.Add(new BCITDataTableColumnDefinitions() { Header = "Customer Name" });
            TableDefinitions.Columns.Add(new BCITDataTableColumnDefinitions() { Header = "Store" });
            TableDefinitions.Columns.Add(new BCITDataTableColumnDefinitions() { Header = "Account" });
            TableDefinitions.Columns.Add(new BCITDataTableColumnDefinitions() { Header = "Comments" });

        }

        private void CreateTableDefinitions()
        {
            TableDefinitions.Sorting = true;
            TableDefinitions.Searching = true;
            CreateColumnDefinitions();
        }



    }
}
