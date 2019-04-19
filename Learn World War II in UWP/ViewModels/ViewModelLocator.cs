using System;

using GalaSoft.MvvmLight.Ioc;

using Learn_World_War_II_in_UWP.Services;
using Learn_World_War_II_in_UWP.Views;

namespace Learn_World_War_II_in_UWP.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        private static ViewModelLocator _current;

        public static ViewModelLocator Current => _current ?? (_current = new ViewModelLocator());

        private ViewModelLocator()
        {
            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<HOMEViewModel, HOMEPage>();
            Register<MAINTOPICSViewModel, MAINTOPICSPage>();
            Register<GENERALSViewModel, GENERALSPage>();
            Register<ARTSViewModel, ARTSPage>();
            Register<ARTSDetailViewModel, ARTSDetailPage>();
            Register<TIMELINEViewModel, TIMELINEPage>();
            Register<SettingsViewModel, SettingsPage>();
            Register<MEDIAViewModel, MEDIAPage>();
        }

        public MEDIAViewModel MEDIAViewModel => SimpleIoc.Default.GetInstance<MEDIAViewModel>();

        public SettingsViewModel SettingsViewModel => SimpleIoc.Default.GetInstance<SettingsViewModel>();

        public TIMELINEViewModel TIMELINEViewModel => SimpleIoc.Default.GetInstance<TIMELINEViewModel>();

        public ARTSDetailViewModel ARTSDetailViewModel => SimpleIoc.Default.GetInstance<ARTSDetailViewModel>();

        public ARTSViewModel ARTSViewModel => SimpleIoc.Default.GetInstance<ARTSViewModel>();

        public GENERALSViewModel GENERALSViewModel => SimpleIoc.Default.GetInstance<GENERALSViewModel>();

        public MAINTOPICSViewModel MAINTOPICSViewModel => SimpleIoc.Default.GetInstance<MAINTOPICSViewModel>();

        public HOMEViewModel HOMEViewModel => SimpleIoc.Default.GetInstance<HOMEViewModel>();

        public ShellViewModel ShellViewModel => SimpleIoc.Default.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => SimpleIoc.Default.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
