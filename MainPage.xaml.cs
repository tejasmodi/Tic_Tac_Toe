using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.ApplicationModel.DataTransfer;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App5
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.SizeChanged += MainPage_SizeChanged;
            DataTransferManager dtm = DataTransferManager.GetForCurrentView();
            dtm.DataRequested += dtm_DataRequested;
        }

        void dtm_DataRequested(DataTransferManager sender, DataRequestedEventArgs args)
        {
            DataPackage dp = args.Request.Data;
            dp.Properties.Title = pl1.Text;
            dp.SetText(X.Text);
            dp.SetUri(new Uri("http://www.bing.com"));
        }
        int x1 = 0, x2 = 0, x3 = 0;

        void MainPage_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ApplicationViewState avs = ApplicationView.Value;
            switch (avs)
            {
                case ApplicationViewState.FullScreenLandscape:

                    full.Visibility = Visibility.Visible;
                    break;
                case ApplicationViewState.Filled:

                    full.Visibility = Visibility.Visible;
                    break;
                default:
                    full.Visibility = Visibility.Collapsed;
                    MessageDialog m = new MessageDialog("not supported...please use landscape mode!s");
                    m.ShowAsync();
                    break;
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
                pl1.FontSize = 50;
            
            X.Text = x1.ToString();
            O.Text = x2.ToString();
            draw.Text = x3.ToString();
        }
        int i = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0, p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0, p6 = 0, p7 = 0, p8 = 0, p9 = 0;
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            if (c1 == 0)
            {
                if (i % 2 == 0)
                {
                    pl1.FontSize = 30;
                    pl2.FontSize = 50;
                }
                else
                {
                    pl1.FontSize = 50;
                    pl2.FontSize = 30;
                }
                c1++;
                if (i % 2 == 0)
                {
                    p1 = 1;
                    b1.Content = 'X';
                }
                else
                {
                    p1 = 2;
                    b1.Content = 'O';
                }
                i++;
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (c2 == 0)
            {
                if (i % 2 == 0)
                {
                    pl1.FontSize = 30;
                    pl2.FontSize = 50;
                }
                else
                {
                    pl1.FontSize = 50;
                    pl2.FontSize = 30;
                }
                c2++;
                if (i % 2 == 0)
                {
                    p2 = 1;
                    b2.Content = 'X';
                }
                else
                {
                    p2 = 2;
                    b2.Content = 'O';
                }
                i++;
                check();
            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            if (c3 == 0)
            {
                if (i % 2 == 0)
                {
                    pl1.FontSize = 30;
                    pl2.FontSize = 50;
                }
                else
                {
                    pl1.FontSize = 50;
                    pl2.FontSize = 30;
                }
                c3++;
                if (i % 2 == 0)
                {
                    p3 = 1;
                    b3.Content = 'X';
                }
                else
                {
                    p3 = 2;
                    b3.Content = 'O';
                }
                i++;
                check();
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            if (c4 == 0)
            {
                if (i % 2 == 0)
                {
                    pl1.FontSize = 30;
                    pl2.FontSize = 50;
                }
                else
                {
                    pl1.FontSize = 50;
                    pl2.FontSize = 30;
                }
                c4++;
                if (i % 2 == 0)
                {
                    p4 = 1;
                    b4.Content = 'X';
                }
                else
                {
                    p4 = 2;
                    b4.Content = 'O';
                }
                i++;
                check();
            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            if (c5 == 0)
            {
                if (i % 2 == 0)
                {
                    pl1.FontSize = 30;
                    pl2.FontSize = 50;
                }
                else
                {
                    pl1.FontSize = 50;
                    pl2.FontSize = 30;
                }
                c5++;
                if (i % 2 == 0)
                {
                    p5 = 1;
                    b5.Content = 'X';
                }
                else
                {
                    p5 = 2;
                    b5.Content = 'O';
                }
                i++;
                check();
            }
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (c6 == 0)
            {
                if (i % 2 == 0)
                {
                    pl1.FontSize = 30;
                    pl2.FontSize = 50;
                }
                else
                {
                    pl1.FontSize = 50;
                    pl2.FontSize = 30;
                }
                c6++;
                if (i % 2 == 0)
                {
                    p6 = 1;
                    b6.Content = 'X';
                }
                else
                {
                    p6 = 2;
                    b6.Content = 'O';
                }
                i++;
                check();
            }
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            if (c7 == 0)
            {
                if (i % 2 == 0)
                {
                    pl1.FontSize = 30;
                    pl2.FontSize = 50;
                }
                else
                {
                    pl1.FontSize = 50;
                    pl2.FontSize = 30;
                }
                c7++;
                if (i % 2 == 0)
                {
                    p7 = 1;
                    b7.Content = 'X';
                }
                else
                {
                    p7 = 2;
                    b7.Content = 'O';
                }
                i++;
                check();
            }
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            if (c8 == 0)
            {
                if (i % 2 == 0)
                {
                    pl1.FontSize = 30;
                    pl2.FontSize = 50;
                }
                else
                {
                    pl1.FontSize = 50;
                 
                    pl2.FontSize = 30;
                }
                c8++;
                if (i % 2 == 0)
                {
                    p8 = 1;
                    b8.Content = 'X';
                }
                else
                {
                    p8 = 2;
                    b8.Content = 'O';
                }
                i++;
                check();
            }
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (c9 == 0)
            {
                if (i % 2 == 0)
                {
                    pl1.FontSize = 30;
                    pl2.FontSize = 50;
                }
                else 
                {
                    pl1.FontSize = 50;
                    pl2.FontSize = 30;
                }
                c9++;
                if (i % 2 == 0)
                {
                    p9 = 1;
                    b9.Content = 'X';
                }
                else
                {
                    p9 = 2;
                    b9.Content = 'O';
                }
                i++;
                check();
            }
        }
        private void resett()
        {
            c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = i = 0;
            b1.Content = b2.Content = b3.Content = b4.Content = b5.Content = b6.Content = b7.Content = b8.Content = b9.Content = "";
            p1 = p2 = p3 = p4 = p5 = p6 = p7 = p8 = p9 = 0;
            pl1.FontSize = 50;
            pl2.FontSize = 30;
        }
        private void check()
        {
            if ((p1 == p2) && (p1 == p3) && (p1 == 1) || (p1 == p4) && (p1 == p7) && (p1 == 1) || (p1 == p5) && (p1 == p9) && (p1 == 1) || (p2 == p5) && (p2 == p8) && (p2 == 1) || (p4 == p5) && (p4 == p6) && (p4 == 1) || (p7 == p8) && (p7 == p9) && (p7 == 1) || (p3 == p5) && (p5 == p7) && (p3 == 1) || (p3 == p6) && (p6 == p9) && (p3 == 1))
            {
                MessageDialog msg = new MessageDialog("PLAYER 1 WINS");
                msg.ShowAsync();
                x1++;
                X.Text = x1.ToString();
                resett();

                
                
            }
            else if ((p1 == p2) && (p1 == p3) && (p1 == 2) || (p1 == p4) && (p1 == p7) && (p1 == 2) || (p1 == p5) && (p1 == p9) && (p1 == 2) || (p2 == p5) && (p2 == p8) && (p2 == 2) || (p4 == p5) && (p4 == p6) && (p4 == 2) || (p7 == p8) && (p7 == p9) && (p7 == 2) || (p3 == p5) && (p5 == p7) && (p3 == 2) || (p3 == p6) && (p6 == p9) && (p3 == 2))
            {
                MessageDialog msg = new MessageDialog("PLAYER 2 WINS");
                msg.ShowAsync();
                x2++;
                O.Text = x2.ToString();
                resett();
                
            }
            else if (c1 == c2 && c2 == c3 && c3 == c4 && c4 == c5 && c5 == c6 && c6 == c7 && c7 == c8 && c8 == c9)
            {
                MessageDialog msg = new MessageDialog("DRAW");
                msg.ShowAsync();
                x3++;
                draw.Text = x3.ToString();
                resett();
            }
        }

       

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            c1 = c2 = c3 = c4 = c5 = c6 = c7 = c8 = c9 = i = 0;
            b1.Content = b2.Content = b3.Content = b4.Content = b5.Content = b6.Content = b7.Content = b8.Content = b9.Content = "";
            p1 = p2 = p3 = p4 = p5 = p6 = p7 = p8 = p9 = 0;
            pl1.FontSize = 50;
            pl2.FontSize = 30;
        }

      
    }
}