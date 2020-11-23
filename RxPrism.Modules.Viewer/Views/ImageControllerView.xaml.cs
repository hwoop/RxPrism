using RxPrism.Core.Views;
using RxPrism.Modules.Viewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
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
    public partial class ImageControllerView : RxUserControlBase<ImageControllerViewModel>
    {
        public ImageControllerView()
        {
            InitializeComponent();
        }
    }
}
