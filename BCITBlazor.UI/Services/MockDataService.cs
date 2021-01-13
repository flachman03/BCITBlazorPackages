using BCITBlazor.Common.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCITBlazor.UI.Services
{
    public class MockDataService : IMockDataService
    {
        public List<BCITSelectListItem> GetListItems()
        {
            var items = new List<BCITSelectListItem>();

            items.Add(new BCITSelectListItem { Text = "GSU", Id = "1", IsSelected = false });
            items.Add(new BCITSelectListItem { Text = "GMA", Id = "2", IsSelected = false });
            items.Add(new BCITSelectListItem { Text = "GTOasdfasfadf", Id = "3", IsSelected = true });
            items.Add(new BCITSelectListItem { Text = "GFD", Id = "4", IsSelected = false });

            return items;
        }
    }
}
