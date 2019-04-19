using System;

using Learn_World_War_II_in_UWP.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Learn_World_War_II_in_UWP.Views
{
    public sealed partial class GENERALSPage : Page
    {
        private GENERALSViewModel ViewModel
        {
            get { return ViewModelLocator.Current.GENERALSViewModel; }
        }

        public GENERALSPage()
        {
            InitializeComponent();
            Loaded += GENERALSPage_Loaded;
        }

        private async void GENERALSPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            // Workaround for issue on MasterDetail Control. Find More info at https://github.com/Microsoft/WindowsTemplateStudio/issues/2738
            ViewModel.Selected = null;
        }
    }
}
