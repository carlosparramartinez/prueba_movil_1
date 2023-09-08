﻿using frontend_movil_1.Services;
using frontend_movil_1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace frontend_movil_1
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
