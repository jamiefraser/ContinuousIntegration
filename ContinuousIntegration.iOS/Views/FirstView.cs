using MvvmCross.iOS.Views;
using System;

using UIKit;

namespace ContinuousIntegration.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        public FirstView() : base("FirstView", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}