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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Media.Animation;
namespace FirstGround
{

    public partial class MainWindow : Window
    {
        Choice choise;
        DateTime start = DateTime.Now.AddMilliseconds(420);
        public MainWindow()
        {
            
            InitializeComponent();
            CloseCheck();
        }
        public void CloseCheck()
        {
            #region sb
            DoubleAnimation fadeIn = new DoubleAnimation(0.0, 1, TimeSpan.FromSeconds(2), FillBehavior.HoldEnd);
            fadeIn.BeginTime = TimeSpan.FromSeconds(0);
            DoubleAnimation fadeOut = new DoubleAnimation(1.0, 0.0, TimeSpan.FromSeconds(2), FillBehavior.HoldEnd);
            fadeOut.BeginTime = TimeSpan.FromSeconds(3);

            Storyboard sb = new Storyboard();
            Storyboard.SetTarget(fadeIn, this);
            Storyboard.SetTarget(fadeOut, this);
            Storyboard.SetTargetProperty(fadeIn, new PropertyPath("(Opacity)"));
            Storyboard.SetTargetProperty(fadeOut, new PropertyPath("(Opacity)"));
            sb.Children.Add(fadeIn);
            sb.Children.Add(fadeOut);
            this.Resources.Clear();
            this.Resources.Add("MyEffect", sb);
            #endregion
            sb.Duration = new System.Windows.Duration(TimeSpan.FromSeconds(5.0));
            sb.Completed += sb_Completed;
            sb.Begin();
            
        }

        void sb_Completed(object sender, EventArgs e)
        {
            Choice main = new Choice();
            App.Current.MainWindow = main;
            this.Close();
            main.Show();
            Choice c = new Choice();
        }
    }
}
