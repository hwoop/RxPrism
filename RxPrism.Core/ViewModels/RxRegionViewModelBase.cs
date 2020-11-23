using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RxPrism.Core.ViewModels
{
    public class RxRegionViewModelBase : RxViewModelBase, INavigationAware, IConfirmNavigationRequest
    {
        protected IRegionManager RegionManager { get; private set; }

        public RxRegionViewModelBase(IRegionManager regionManager)
        {
            RegionManager = regionManager;
        }

        public virtual void ConfirmNavigationRequest(NavigationContext navigationContext, Action<bool> continuationCallback)
        {
            continuationCallback(true);
        }

        public virtual bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public virtual void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public virtual void OnNavigatedTo(NavigationContext navigationContext)
        {

        }
    }
}
