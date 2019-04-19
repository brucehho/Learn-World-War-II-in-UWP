using System;
using System.Collections.ObjectModel;
using System.Linq;

using GalaSoft.MvvmLight;

using Learn_World_War_II_in_UWP.Core.Models;
using Learn_World_War_II_in_UWP.Core.Services;
using Learn_World_War_II_in_UWP.Helpers;

using Windows.UI.Xaml.Navigation;

namespace Learn_World_War_II_in_UWP.ViewModels
{
    public class ARTSDetailViewModel : ViewModelBase
    {
        private object _selectedImage;
        private ObservableCollection<SampleImage> _source;

        public object SelectedImage
        {
            get => _selectedImage;
            set
            {
                Set(ref _selectedImage, value);
                ImagesNavigationHelper.UpdateImageId(ARTSViewModel.ARTSSelectedIdKey, ((SampleImage)SelectedImage).ID);
            }
        }

        public ObservableCollection<SampleImage> Source
        {
            get => _source;
            set => Set(ref _source, value);
        }

        public ARTSDetailViewModel()
        {
            Source = SampleDataService.GetGallerySampleData();
        }

        public void Initialize(string selectedImageID, NavigationMode navigationMode)
        {
            if (!string.IsNullOrEmpty(selectedImageID) && navigationMode == NavigationMode.New)
            {
                SelectedImage = Source.FirstOrDefault(i => i.ID == selectedImageID);
            }
            else
            {
                selectedImageID = ImagesNavigationHelper.GetImageId(ARTSViewModel.ARTSSelectedIdKey);
                if (!string.IsNullOrEmpty(selectedImageID))
                {
                    SelectedImage = Source.FirstOrDefault(i => i.ID == selectedImageID);
                }
            }
        }
    }
}
