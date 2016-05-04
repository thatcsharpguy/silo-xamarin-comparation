// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Xevensthein
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField FirstWordTextField { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
        UITextField SecondWordTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIButton CompareButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UILabel ResultLabel { get; set; }


		void ReleaseDesignerOutlets ()
		{
			if (CompareButton != null) {
				CompareButton.Dispose ();
				CompareButton = null;
			}
			if (FirstWordTextField != null) {
				FirstWordTextField.Dispose ();
				FirstWordTextField = null;
			}
			if (ResultLabel != null) {
				ResultLabel.Dispose ();
				ResultLabel = null;
			}
			if (SecondWordTextField != null) {
				SecondWordTextField.Dispose ();
				SecondWordTextField = null;
			}
		}
	}
}
