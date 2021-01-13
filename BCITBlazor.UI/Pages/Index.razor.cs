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

        private void CreateHeaderDefinitions()
        {
            TableDefinitions.HeaderDefinitions.Headers.Add("Company");
            TableDefinitions.HeaderDefinitions.Headers.Add("Stock Number");
            TableDefinitions.HeaderDefinitions.Headers.Add("Employee");
            TableDefinitions.HeaderDefinitions.Headers.Add("Start Date");
        }

        private void CreateTableDefinitions()
        {
            TableDefinitions.Sorting = true;
            TableDefinitions.Searching = true;
            CreateHeaderDefinitions();
        }



    }
}
