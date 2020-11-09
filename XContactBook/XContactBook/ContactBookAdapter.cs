using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace XContactBook
{
    class ContactBookAdapter : BaseAdapter
    {

        private readonly Context c;
        private readonly JavaList<ContactBook> contacts;
        private LayoutInflater inflater;

        public ContactBookAdapter(Context c, JavaList<ContactBook> contacts)
        {
            this.c = c;
            this.contacts = contacts;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return contacts.Get(position);
        }
        
        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //INITIALIZE INFLATER
            if (inflater == null)
            {
                inflater = (LayoutInflater)c.GetSystemService(Context.LayoutInflaterService);
            }

            //INFLATE OUR MODEL LAYOUT
            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.Model, parent, false);
            }

            //BIND DATA
            CustomAdapterViewHolder holder = new CustomAdapterViewHolder(convertView)
            {
                NameTxt = { Text = contacts[position].Name }
            };
            holder.Img.SetImageResource(contacts[position].Image);

            //convertView.SetBackgroundColor(Color.LightBlue);

            return convertView;
        }

        public override int Count => contacts.Size();
    }

    class CustomAdapterViewHolder : Java.Lang.Object
    {
        //adapter views to re-use
        public TextView NameTxt;
        public ImageView Img;

        public CustomAdapterViewHolder(View itemView)
        {
            
            NameTxt = itemView.FindViewById<TextView>(Resource.Id.nameTxt);
            Img = itemView.FindViewById<ImageView>(Resource.Id.contactImg);

        }
    }
}