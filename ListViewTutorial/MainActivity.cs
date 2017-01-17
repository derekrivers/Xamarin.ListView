using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;

namespace ListViewTutorial
{
    [Activity(Label = "ListViewTutorial", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private List<Person> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);

            mItems = new List<Person>();

            mItems.Add(new Person()
            {
               FirstName = "Bob",
               LastName = "Doe",
               Age="23",
               Gender = "Male"
            });
            mItems.Add(new Person()
            {
                FirstName = "Tom",
                LastName = "Tom",
                Age = "18",
                Gender = "Male"
            });
            mItems.Add(new Person()
            {
                FirstName = "Sally",
                LastName = "Suzanne",
                Age = "23",
                Gender = "Female"
            });
          

            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            mListView.Adapter = adapter;

            mListView.ItemClick += MListView_ItemClick;
            mListView.ItemLongClick += MListView_ItemLongClick;

        }

        private void MListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.WriteLine(mItems[e.Position].LastName);
        }

        private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
           Console.WriteLine(mItems[e.Position].FirstName);
        }
    }
}

