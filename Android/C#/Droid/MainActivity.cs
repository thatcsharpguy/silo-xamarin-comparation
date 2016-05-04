using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

using Xevensthein.Core;

namespace Xevensthein
{
    [Activity(Label = "Xev C#", 
        Theme="@style/AppTheme",
        MainLauncher = true, 
        Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        Button _compareButton;
        TextView _resultTextView;
        EditText _firstWordEditText;
        EditText _secondWordEditText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            _compareButton = FindViewById<Button>(Resource.Id.compareButton);
            _firstWordEditText = FindViewById<EditText>(Resource.Id.firstWordEditText);
            _secondWordEditText = FindViewById<EditText>(Resource.Id.secondWordEditText);
            _resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);

            _compareButton.Click += (sender, e) => {
                var res = LevenshteinDistance.Compute(_firstWordEditText.Text,_secondWordEditText.Text);
                _resultTextView.Text  = res.ToString();
            };
        }
    }
}


