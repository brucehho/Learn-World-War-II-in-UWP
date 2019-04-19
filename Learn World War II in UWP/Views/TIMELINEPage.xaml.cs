using System;

using Learn_World_War_II_in_UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Learn_World_War_II_in_UWP.Views
{
    public sealed partial class TIMELINEPage : Page
    {
        private TIMELINEViewModel ViewModel
        {
            get { return ViewModelLocator.Current.TIMELINEViewModel; }
        }

        public TIMELINEPage()
        {
            InitializeComponent();
        }
    }
}
