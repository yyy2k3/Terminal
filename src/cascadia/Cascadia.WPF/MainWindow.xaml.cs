﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cascadia.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // RuntimeComponent1.Class foo;
        public MainWindow()
        {
            InitializeComponent();
            // foo = new RuntimeComponent1.Class();
        }

        private void WindowsXamlHost_XamlRootChanged(object sender, EventArgs e)
        {
            Windows.UI.Xaml.Controls.Button button = (Windows.UI.Xaml.Controls.Button)windowXamlHost.Child;
            if (button != null)
            {
                button.Content = "XAML Button";
                button.Click += Button_Click;
            }
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            string label = (sender as Windows.UI.Xaml.Controls.Button).Content as string;
            RuntimeComponent1.Class foo = new RuntimeComponent1.Class();

            var b = foo.DoTheThing();
            //textBlock.Text = $"{label} - {DateTime.Now.ToLongTimeString()} - {foo.DoTheThing()}";
            textBlock.Text = $"{label} - {DateTime.Now.ToLongTimeString()} - {b}";
            //textBlock.Text = $"{label} - {DateTime.Now.ToLongTimeString()}";

        }
    }
}
