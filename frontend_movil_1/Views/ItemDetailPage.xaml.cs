﻿using frontend_movil_1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace frontend_movil_1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}