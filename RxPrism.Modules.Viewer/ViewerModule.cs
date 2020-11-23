using RxPrism.Modules.Viewer.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using RxPrism.Core;
using RxPrism.Modules.Viewer.ViewModels;

namespace RxPrism.Modules.Viewer
{
    public class ViewerModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ViewerModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            //_regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(RxSampleView));
            //_regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(SampleView));
            _regionManager.RequestNavigate(RegionNames.ContentRegion, nameof(ImageControllerView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SampleView, SampleViewModel>();
            containerRegistry.RegisterForNavigation<RxSampleView, RxSampleViewModel>();

            containerRegistry.RegisterForNavigation<ImageControllerView, ImageControllerViewModel>();
            containerRegistry.RegisterForNavigation<ImageView, ImageViewModel>();
        }
    }
}