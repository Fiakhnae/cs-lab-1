﻿using CSLab1.ViewModels;

namespace CSLab1.Views {
    public partial class MainPage : ContentPage {
        
        public MainPage(MainViewModel viewModel) {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

}
