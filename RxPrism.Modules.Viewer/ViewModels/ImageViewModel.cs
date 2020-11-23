using Prism.Regions;
using RxPrism.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RxPrism.Modules.Viewer.ViewModels
{
    public class ImageViewModel : RxRegionViewModelBase
    {
        public ImageViewModel(IRegionManager regionManager)
            : base (regionManager)
        {

        }

        public override void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }

        public override void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
