﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TaskListApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            DataContext = ((App)App.Current).MyViewModelLocator.getViewModel();
        }
        private void GoToPage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AddTaskPage));
            //MyFrame.Navigate(typeof(Page1));
        }
        private void GoToPage2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PersistentTextPage));
            //MyFrame.Navigate(typeof(Page1));
        }
    }
}
