using System;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.Windows.Threading;

namespace NC_SplashScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int TickCount = 0;
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start(); 

            loadprogressbar();
          //  arduino2560.Form1 f1 =new Form1();
           // MessageBox.Show("Hello");
           // System.Diagnostics.Process.Start(Application
          //  Process.Start(Application.StartUpPath.to "arduino2560.exe");
           // SplashTerminate();
            //System.Threading.Thread.Sleep(8000);
           // this.Close();




        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            TickCount++;
           // MessageBox.Show(TickCount.ToString());
            if (TickCount == 8)
            {
                this.Close();
            }
        }

        private void SplashTerminate()
        {
           
           
        }

        private void loadprogressbar()
        {
           
                Duration dur = new Duration(TimeSpan.FromSeconds(8));
                DoubleAnimation dblani = new DoubleAnimation(100.0, dur);
                PB1.BeginAnimation(ProgressBar.ValueProperty, dblani);
                // this.Close();
                
               
               // this.Close();
                //if (PB1.Value >= 100)
                //{
                //    MessageBox.Show("Enter");
                //    this.Close();
                //    break;
                //}
                //else
                //{
                //    System.Threading.Thread.Sleep(100);
                //  //  MessageBox.Show("@");
                //}

            
        }
    }
}
