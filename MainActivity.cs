using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace InterfazDeUsuario
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button botonAxml = FindViewById<Button>(Resource.Id.botonAxml);
            botonAxml.Click += delegate { Toast.MakeText(this, "Boton axml", ToastLength.Long).Show(); };

            Button botonAxml2 = FindViewById<Button>(Resource.Id.botonAxml2);
            botonAxml2.Click += delegate { Toast.MakeText(this, "Boton2 axml", ToastLength.Long).Show(); };

            RelativeLayout relativeLayout1 = FindViewById<RelativeLayout>(Resource.Id.relativeLayout1);
            Button botonCodigo = new Button(this);
            botonCodigo.Text = "Botón con codigo";

            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
            layoutParams.AddRule(LayoutRules.Below, Resource.Id.botonAxml2);
            botonCodigo.LayoutParameters = layoutParams;
            relativeLayout1.AddView(botonCodigo);

            botonCodigo.Click += delegate { Toast.MakeText(this, "Boton con codigo", ToastLength.Long).Show(); };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}