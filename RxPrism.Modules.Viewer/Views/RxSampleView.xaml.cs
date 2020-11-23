using ReactiveUI;
using RxPrism.Core.Views;
using RxPrism.Modules.Viewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RxPrism.Modules.Viewer.Views
{
    /// <summary>
    /// Interaction logic for ViewA.xaml
    /// </summary>
    public partial class RxSampleView : RxUserControlBase<RxSampleViewModel>
    {
        public RxSampleView()
        {
            InitializeComponent();

            this.Bind(ViewModel, vm => vm.UserName, v => v.UserName.Text)
                .DisposeWith(ViewBindings);

            this.Bind(ViewModel, vm => vm.Password, v => v.Password.Text)
                .DisposeWith(ViewBindings);

            this.BindCommand(ViewModel, vm => vm.PivotContents, v => v.ExecuteButton)
                .DisposeWith(ViewBindings);

            this.WhenAnyObservable(v => v.ViewModel.PivotContents.CanExecute)
                .StartWith(false)
                .DistinctUntilChanged()
                .Subscribe(canExecute =>
                {
                    ExecuteButton.Background = canExecute ? Brushes.Coral : Brushes.AliceBlue;
                });
        }
    }
}
