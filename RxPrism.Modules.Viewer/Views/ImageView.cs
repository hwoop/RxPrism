using ReactiveUI;
using RxPrism.Core.Views;
using RxPrism.Modules.Viewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RxPrism.Modules.Viewer.Views
{
    public class ImageView : RxUserControlBase<ImageViewModel>
    {
        public ImageView()
        {
            this.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            this.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            
        }
    }
}
