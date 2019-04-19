using System;

using Learn_World_War_II_in_UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Learn_World_War_II_in_UWP.Views
{
    public sealed partial class MAINTOPICSPage : Page
    {
        private MAINTOPICSViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MAINTOPICSViewModel; }
        }

        public MAINTOPICSPage()
        {
            InitializeComponent();
        }
    }
}
