using MvvmCross.iOS.Views;
using System;

using UIKit;
using Cirrious.FluentLayouts.Touch;
namespace ContinuousIntegration.iOS.Views
{
    public partial class FirstView : MvxViewController
    {
        UILabel labelHello;
        public FirstView() : base("FirstView", null)
        {
            labelHello = new UILabel();
            labelHello.Text = "Hello!";
            
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            View.Add(labelHello);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            this.View.AddConstraints(labelHello.WithSameCenterX(this.View)
                                     ,labelHello.WithSameCenterY(this.View)
                         //, OKButton.WithSameCenterX(this.View)
                         );

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}