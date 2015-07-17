using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TestMultiPlatform.Droid
{
	[Activity (Label = "TestMultiPlatform.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		public SharedInt sharedModel { get; set; }

		protected override void OnCreate (Bundle bundle)
		{
			sharedModel = new SharedInt();
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			this.sharedModel.IncrementInt();

			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", this.sharedModel.sharedInt);
				this.sharedModel.IncrementInt();
			};
		}
	}
}


