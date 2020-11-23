using Prism.Mvvm;
using RxPrism.Core.ViewModels;

namespace RxPrism.App.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
