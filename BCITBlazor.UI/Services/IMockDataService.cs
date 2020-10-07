using BCITBlazor.Common.Shared;
using System.Collections.Generic;

namespace BCITBlazor.UI.Services
{
    public interface IMockDataService
    {
        List<BCITSelectListItem> GetListItems();
    }
}