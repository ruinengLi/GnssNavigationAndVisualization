﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GPS_navigation.Services;
using GPS_navigation.Views;

namespace GPS_navigation
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
