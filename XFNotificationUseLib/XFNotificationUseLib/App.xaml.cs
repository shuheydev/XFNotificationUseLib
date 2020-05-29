using Plugin.LocalNotification;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFNotificationUseLib
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NotificationCenter.Current.NotificationTapped += Current_NotificationTapped;

            MainPage = new MainPage();
        }

        private void Current_NotificationTapped(NotificationTappedEventArgs e)
        {
            var lbl = new Label
            {
                Text = "tapped"
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
