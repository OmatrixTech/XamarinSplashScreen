﻿using System.ComponentModel;
using Xamarin.Forms;
using XamarinTutorial.ViewModels;

namespace XamarinTutorial.Views
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