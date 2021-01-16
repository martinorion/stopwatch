using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        
        Stopwatch stopwatch;
        

        public MainPage()
        {
           
            InitializeComponent();
            stopwatch = new Stopwatch();
            lblStopwatch.Text = "00:00:00.000";
        }

        private void btnStart_Clicked(object sender, EventArgs e)
        {
            stopwatch.Start();
            Device.StartTimer(TimeSpan.FromSeconds(100), () =>
            {
                lblStopwatch.Text = stopwatch.Elapsed.ToString();
                return true;
            }
        );
        }

        private void btnStop_Clicked(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {
            stopwatch.Reset();

        }

        private void btnLap_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine();
        }
    }
}
