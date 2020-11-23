using Prism.Commands;
using Prism.Regions;
using RxPrism.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RxPrism.Modules.Viewer.ViewModels
{
    public class SampleViewModel : RegionViewModelBase
    {
        private string _userName = string.Empty;
        private string _password = string.Empty;


        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public DelegateCommand PivotCommand { get; }


        public SampleViewModel(IRegionManager regionManager)
            : base (regionManager)
        {
            PivotCommand = new DelegateCommand(() =>
            {
                RegionManager.RequestNavigate(Core.RegionNames.ContentRegion, "RxSampleView");
            });
        }
    }
}
