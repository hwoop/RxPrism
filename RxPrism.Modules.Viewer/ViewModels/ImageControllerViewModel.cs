using Prism.Regions;
using RxPrism.Core;
using RxPrism.Core.ViewModels;
using RxPrism.Modules.Viewer.Views;
using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;
using System.Windows.Media.Imaging;

namespace RxPrism.Modules.Viewer.ViewModels
{
    public class ImageControllerViewModel : RxRegionViewModelBase
    {
        public ImageControllerViewModel(IRegionManager regionManager) 
            : base(regionManager)
        {
            var frame = BitmapFrame.Create(new Uri(@$"{Environment.CurrentDirectory}\sample.png"));

            var navParams = new NavigationParameters
            {
                { "ImageInstance", frame },
            };


            RegionManager.RegisterViewWithRegion(RegionNames.ImageRegion, typeof(ImageView));
        }
    }
}