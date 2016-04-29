using System;

using UIKit;

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

        void CompareButtonClicked (object sender, EventArgs e)
        {
            ResultLabel.Text = "Hola";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

