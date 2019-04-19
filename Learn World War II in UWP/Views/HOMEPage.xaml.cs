using System;

using Learn_World_War_II_in_UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Learn_World_War_II_in_UWP.Views
{
    public sealed partial class HOMEPage : Page
    {
        private HOMEViewModel ViewModel
        {
            get { return ViewModelLocator.Current.HOMEViewModel; }
        }

        public HOMEPage()
        {
            InitializeComponent();
        }

        private void Hub_SectionHeader_SectionHeaderClick(object sender, HubSectionHeaderClickEventArgs e)
        {
            switch (e.Section.Name)
            {
                case "Home":
                    Frame.Navigate(typeof(HOMEPage));
                    break;
                case "MainTopics":
                    Frame.Navigate(typeof(MAINTOPICSPage));
                    break;
                case "Generals":
                    Frame.Navigate(typeof(GENERALSPage));
                    break;
                case "ARTS":
                    Frame.Navigate(typeof(ARTSPage));
                    break;
                case "MEDIA":
                    Frame.Navigate(typeof(MEDIAPage));
                    break;
                case "TIMELINE":
                    Frame.Navigate(typeof(TIMELINEPage));
                    break;

            }
        }
    }
}
