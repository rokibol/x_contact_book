﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XContactBook
{
    class ContactBook
    {
        private String name;
        private int image;

        public ContactBook(string name, int image)
        {
            this.name = name;
            this.image = image;
        }
        public string Name
        {
            get { return name; }
        }

        public int Image
        {
            get { return image; }
        }
    }
}