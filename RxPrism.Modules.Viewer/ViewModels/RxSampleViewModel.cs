using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using ReactiveUI;
using RxPrism.Core;
using RxPrism.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace RxPrism.Modules.Viewer.ViewModels
{
    public class RxSampleViewModel : RxRegionViewModelBase
    {
        private string _userName = string.Empty;
        private string _password = string.Empty;


        public string UserName
        {
            get => _userName;
            set => this.RaiseAndSetIfChanged(ref _userName, value);
        }

        public string Password
        {
            get => _password;
            set => this.RaiseAndSetIfChanged(ref _password, value);
        }

        public ReactiveCommand<Unit, Unit> PivotContents { get; }

        public RxSampleViewModel(IRegionManager regionManager)
            : base (regionManager)
        {
            var canExecute = this.WhenAnyValue(
                vm => vm.UserName,
                vm => vm.Password,
                (userName, password) =>
                {
                    return string.IsNullOrEmpty(userName) == false &&
                           string.IsNullOrEmpty(password) == false;
                });

            PivotContents = ReactiveCommand.CreateFromTask(ExecuteTransition, canExecute);
        }

        private async Task ExecuteTransition()
        {
            RegionManager.RequestNavigate(RegionNames.ContentRegion, "SampleView");
        }
    }
}
