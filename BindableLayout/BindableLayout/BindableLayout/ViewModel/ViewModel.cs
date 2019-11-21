using System;
using System.Collections.Generic;
using System.Text;

namespace BindableLayout
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.GetContactsList();
        }

        public List<PlatformInfo> PlatformsList { get; set; }

        private void GetContactsList()
        {
            if (this.PlatformsList == null)
                this.PlatformsList = new List<PlatformInfo>();

            this.PlatformsList.Add(new PlatformInfo() { IsChecked = true, PlatformName = "Android" });
            this.PlatformsList.Add(new PlatformInfo() { IsChecked = true, PlatformName = "iOS" });
            this.PlatformsList.Add(new PlatformInfo() { IsChecked = false, PlatformName = "UWP" });
        }
    }
}
