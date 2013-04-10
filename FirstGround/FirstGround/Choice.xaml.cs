using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ModelView.ViewModel;
using ModelView;

namespace FirstGround
{
   
    public partial class Choice : Window
    {
        public Choice()
        {
          InitializeComponent();
        }

        private void ActivityLogger(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Akir\\Documents\\Dev\\CiView\\ActivityLogger\\ModelView\\bin\\Debug\\ModelView.exe");
        }

        private void EndUserObjectExplorer(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Users\\Akir\\Documents\\Dev\\CiView\\ActivityLogger\\ModelView\\bin\\Debug\\EndUserObjectExplorer\\EndUserObjectExplorer.exe");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
