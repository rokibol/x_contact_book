using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace XContactBook
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //DECLARATIONS
        private ListView lv;
        private ContactBookAdapter adapter;
        private JavaList<ContactBook> contacts;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            lv = FindViewById<ListView>(Resource.Id.lv);

            //BIND ADAPTER
            adapter = new ContactBookAdapter(this, GetContacts());

            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;

        }

        /*
        * LISTVIEW ITEM CLICK
        */
        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, contacts[e.Position].Name, ToastLength.Short).Show();
        }

        /*
        * DATA SOURCE
        */
        private JavaList<ContactBook> GetContacts()
        {
            contacts = new JavaList<ContactBook>();

            ContactBook s;

            s = new ContactBook("Shayan Ahed", Resource.Drawable.u1);
            contacts.Add(s);

            s = new ContactBook("Mihran Bhuiyan", Resource.Drawable.u2);
            contacts.Add(s);

            s = new ContactBook("Taimur Khan", Resource.Drawable.u3);
            contacts.Add(s);

            s = new ContactBook("Ruhan Sultan", Resource.Drawable.u4);
            contacts.Add(s);

            s = new ContactBook("Kabir Ahmed", Resource.Drawable.u5);
            contacts.Add(s);

            s = new ContactBook("Ismail Hosain", Resource.Drawable.u6);
            contacts.Add(s);

            s = new ContactBook("Khalil Khaled", Resource.Drawable.u7);
            contacts.Add(s);

            s = new ContactBook("Ahmed Imtiaz", Resource.Drawable.u8);
            contacts.Add(s);

            s = new ContactBook("Abdul Hamid", Resource.Drawable.u9);
            contacts.Add(s);

            s = new ContactBook("Abdul Kader", Resource.Drawable.u10);
            contacts.Add(s);

            s = new ContactBook("Saiful Islam", Resource.Drawable.u11);
            contacts.Add(s);

            return contacts;

        }
    }
}