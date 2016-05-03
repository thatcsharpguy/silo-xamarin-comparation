using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Xevensthein
{
    [Activity(Label = "Xev C#", 
        Theme="@style/AppTheme",
        MainLauncher = true, 
        Icon = "@mipmap/icon")]
    public class MainActivity : AppCompatActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

        }
    }
}


