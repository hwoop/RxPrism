using Prism.Ioc;
using Prism.Modularity;
using RxPrism.App.Views;
using RxPrism.Modules.Viewer;
using System.Windows;

namespace RxPrism.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ViewerModule>();
        }
    }
}
