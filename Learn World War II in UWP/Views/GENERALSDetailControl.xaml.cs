using System;

using Learn_World_War_II_in_UWP.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Learn_World_War_II_in_UWP.Views
{
    public sealed partial class GENERALSDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(GENERALSDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public GENERALSDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as GENERALSDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
