using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab2_Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
         

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x1 = int.Parse(TextBox1.Text);
            int x2 = int.Parse(TextBox2.Text);
            int x3;
            x3 = x1 + x2;
            string answer = x3.ToString();
            TextBox3.Text = answer;


        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "0";
            TextBox2.Text = "0";
            TextBox3.Text = "0";


        }

        private void MultButton_Click(object sender, RoutedEventArgs e)
        {
            int x1 = int.Parse(TextBox1.Text);
            int x2 = int.Parse(TextBox2.Text);
            int x3;
            x3 = x1 * x2;
            string answer = x3.ToString();
            TextBox3.Text = answer;

        }
    }
}
