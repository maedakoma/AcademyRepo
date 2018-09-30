using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Cercle
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            AcademyMgr.AcademyMgr manager = new AcademyMgr.AcademyMgr();
            manager.Initialize();

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            ListView mainListView = FindViewById<ListView>(Resource.Id.listView1);

            // Create and populate a List of planet names.  
            String[] planets = new String[] { "Mercury", "Venus", "Earth", "Mars",
                                      "Jupiter", "Saturn", "Uranus", "Neptune"};
            List<String> planetList = new List<String>();
            planetList.AddRange(planets);

            // Create ArrayAdapter using the planet list.  
            ArrayAdapter<String>  listAdapter = new ArrayAdapter<String>(this, 1, planetList);

            // Add more planets. If you passed a String[] instead of a List<String>   
            // into the ArrayAdapter constructor, you must not add more items.   
            // Otherwise an exception will occur.  
            listAdapter.Add("Ceres");
            listAdapter.Add("Pluto");
            listAdapter.Add("Haumea");
            listAdapter.Add("Makemake");
            listAdapter.Add("Eris");

            // Set the ArrayAdapter as the ListView's adapter.  
            mainListView.Adapter = listAdapter;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

