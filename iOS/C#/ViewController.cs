using System;
using UIKit;
using Xevensthein.Core;

namespace Xevensthein
{
    public partial class ViewController : UIViewController, IUITextFieldDelegate
    {
        public ViewController(IntPtr handle)
            : base(handle)
        {
           
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            FirstWordTextField.Delegate = this; 
            SecondWordTextField.Delegate = this;

            CompareButton.TouchUpInside += CompareButtonClicked;
        }

        void CompareButtonClicked (object sender, EventArgs e)
        {
            var result = LevenshteinDistance.Compute(FirstWordTextField.Text, SecondWordTextField.Text);
            ResultLabel.Text = result.ToString();
        }
            
        [Foundation.Export("textFieldShouldReturn:")]
        public bool ShouldReturn(UIKit.UITextField textField)
        {
            if (textField == FirstWordTextField)
            {
                FirstWordTextField.ResignFirstResponder();
                SecondWordTextField.BecomeFirstResponder();
            }
            else
            {
                SecondWordTextField.ResignFirstResponder();
            }
            return true;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

