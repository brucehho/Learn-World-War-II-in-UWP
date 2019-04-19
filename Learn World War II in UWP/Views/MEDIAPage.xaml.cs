using System;

using Learn_World_War_II_in_UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Learn_World_War_II_in_UWP.Views
{
    public sealed partial class MEDIAPage : Page
    {
        private MEDIAViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MEDIAViewModel; }
        }

        public MEDIAPage()
        {
            InitializeComponent();
        }
    }
}
