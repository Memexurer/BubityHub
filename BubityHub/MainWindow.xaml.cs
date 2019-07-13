using BubityHub.pages;
using BubityHub.src;
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
using System.Windows.Threading;

namespace BubityHub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MediaElement gifPlayer;

        public MainWindow()
        {
   
            InitializeComponent();
            UtilityLoader.LoadAll();
            gifPlayer = mediaElement;
           
        }

       private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gifPlayer.Opacity = 0;
            gifPlayer.Play();
        
            await Task.Delay(1000);
            fadeGif(true);
            await Task.Delay(3000);
            fadeGif(false);
            await Task.Delay(1100);
            this.Content = new JubityShop();

        }

        private void onMediaEnded(object sender, RoutedEventArgs e)
        {
                mediaElement.Position = new TimeSpan(0, 0, 1);
                mediaElement.Play();       
        }

        private void fadeGif(bool fadeIn)
        {
            int to = fadeIn ? 1 : 0;
            DoubleAnimation myDoubleAnimation = new DoubleAnimation(to, TimeSpan.FromMilliseconds(1500));
            myDoubleAnimation.AutoReverse = false;
            gifPlayer.BeginAnimation(MediaElement.OpacityProperty, myDoubleAnimation);
        }

   
    }
}
