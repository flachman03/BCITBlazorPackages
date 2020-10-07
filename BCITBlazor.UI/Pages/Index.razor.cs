using BCITBlazor.Common.Shared;
using BCITBlazor.UI.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCITBlazor.UI.Pages
{
    public class IndexBase : ComponentBase
    {
        public IMockDataService _mockDataService { get; set; }

        public List<BCITSelectListItem> ListItems { get; set; }

        public IndexBase()
        {
            _mockDataService = new MockDataService();
            ListItems = _mockDataService.GetListItems();
        }

        public void SelectCompany(string itemId)
        {

        }
    }
}
