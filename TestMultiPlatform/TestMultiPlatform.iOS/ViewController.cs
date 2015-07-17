using System;

using UIKit;

namespace TestMultiPlatform.iOS
{
	public partial class ViewController : UIViewController
	{
        public SharedInt sharedModel { get; set; }

		public ViewController (IntPtr handle) : base (handle)
		{
            sharedModel = new SharedInt();
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

        partial void UIButton5_TouchUpInside(UIButton sender)
        {
            this.sharedModel.IncrementInt();

            this.intLabel.Text = String.Format("{0}", this.sharedModel.sharedInt);
        }
	}
}

