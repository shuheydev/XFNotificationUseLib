using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.LocalNotifications;
using Plugin.LocalNotification;

namespace XFNotificationUseLib
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int counter = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            counter++;
            //CrossLocalNotifications.Current.Show($"Test{counter}", "This is Test");

            var notification = new NotificationRequest
            {
                NotificationId = 100,
                Title = "Test",
                Description = $"This is Test{counter} from Plugin.LocalNotification",
                ReturningData = "Dammy data.",
                NotifyTime = DateTime.Now.AddSeconds(2),
                BadgeNumber = 3
            };

            notification.Android.IconName = "icon.jpg";

            

            NotificationCenter.Current.Show(notification);
        }
    }
}
