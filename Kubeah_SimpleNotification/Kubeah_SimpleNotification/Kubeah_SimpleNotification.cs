using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Forms;

namespace Kubeah_SimpleNotification
{
    public class KNotification
    {
        private string content = "";
        private string title = "";
        public int time = 500;
        public KNotification(string Content)
        {
            content = Content;
        }
        public KNotification(string Content, string Title)
        {
            content = Content;
            title = Title;
        }

        //Show the Notification
        public void Show()
        {
            Notification notification = new Notification(content, title);
            notification.Show();
            //TODO
            //Create timer for close notification after X secondes
            //notification.Close();
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = 5000;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            
        }
    }
}
