using Prism.Navigation;
using ReactiveUI;
using RxPrism.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Text;

namespace RxPrism.Core.Views
{
    public class RxUserControlBase<T> : ReactiveUserControl<T>, IDestructible 
        where T : RxViewModelBase
    {
        protected readonly CompositeDisposable ViewBindings = new CompositeDisposable();

        public RxUserControlBase()
        {
            this.WhenAnyValue(v => v.DataContext)
                .BindTo(this, v => v.ViewModel);
        }

        public void Destroy()
        {
            ViewBindings?.Dispose();
        }
    }
}
