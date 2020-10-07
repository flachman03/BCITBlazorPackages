using BCITBlazor.Common.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BCITBlazor.Common.Dropdowns
{
    public class DropdownBase : ComponentBase
    {
        [Parameter]
        public List<BCITSelectListItem> ListItems { get; set; }

        [Parameter]
        public Action<string> OnClick { get; set; }

        public string SelectedItemId { get; set; }
        
        public DropdownBase()
        {
        }

        protected override void OnInitialized()
        {
            ListItems = SortListItems(ListItems);
            base.OnInitialized();
        }

        #region Private Methods

        public List<BCITSelectListItem> SortListItems(List<BCITSelectListItem> listItems)
        {
            return listItems.OrderBy(x => x.Text).ToList();
        }

        #endregion

        #region Public Methods

        public void InvokeOnClick()
        {
            OnClick?.Invoke(SelectedItemId);
        }

        #endregion
    }
}
