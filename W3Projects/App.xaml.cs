﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace W3Projects
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            /*            MainPage = new CashMain();
            */
            //MainPage = new listViewPage();

            MainPage = new NavigationPage(new navigationPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
