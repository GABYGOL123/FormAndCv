﻿using FormAndCv.Services;
using FormAndCv.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormAndCv
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AboutPage();
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
