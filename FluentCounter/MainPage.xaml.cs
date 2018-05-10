using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Timers;
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

namespace FluentCounter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer dispatcherTimer, demoDispatcher;

        public MainPage()
        {
            this.InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {

            DateTime currentTime = DateTime.Now;
            DateTime endTime = currentTime.AddMinutes(1.0);

            TimeSpan difference = endTime.Subtract(currentTime);

            CountdownText.Text = currentTime.Minute.ToString() + " : " + currentTime.Second.ToString() + " : " + currentTime.Millisecond.ToString();
            CountdownText2.Text = endTime.Minute.ToString() + " : " + endTime.Second.ToString() + " : " + endTime.Millisecond.ToString();
            difference = endTime.Subtract(currentTime);
            CountdownText3.Text = difference.ToString();

            //while (currentTime.CompareTo(endTime) <= 0)
            //{
            //    currentTime = DateTime.Now;
            //    if(currentTime.Millisecond == 0)
            //    {
            //        difference = endTime.Subtract(currentTime);
            //        CountdownText3.Text = difference.ToString();
            //    }
            //}


            //counter++;
            // CountdownText.Text = date.AddSeconds(counter).ToString("HH:mm:ss");


            //CountdownText.Text = "06:00:00";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            //CountdownText3.Text = DateTime.Now.ToLongTimeString();
            
        }

    }
}
