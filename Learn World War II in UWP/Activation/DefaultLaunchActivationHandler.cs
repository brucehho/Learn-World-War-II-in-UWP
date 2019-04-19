using System;
using System.Threading.Tasks;

using Learn_World_War_II_in_UWP.Services;
using Learn_World_War_II_in_UWP.ViewModels;

using Windows.ApplicationModel.Activation;

namespace Learn_World_War_II_in_UWP.Activation
{
    internal class DefaultLaunchActivationHandler : ActivationHandler<LaunchActivatedEventArgs>
    {
        private readonly string _navElement;

        public NavigationServiceEx NavigationService => ViewModelLocator.Current.NavigationService;

        public DefaultLaunchActivationHandler(Type navElement)
        {
            _navElement = navElement.FullName;
        }

        protected override async Task HandleInternalAsync(LaunchActivatedEventArgs args)
        {
            NavigationService.Navigate(_navElement, args.Arguments);

            await Task.CompletedTask;
        }

        protected override bool CanHandleInternal(LaunchActivatedEventArgs args)
        {
            return NavigationService.Frame.Content == null && _navElement != null;
        }
    }
}
