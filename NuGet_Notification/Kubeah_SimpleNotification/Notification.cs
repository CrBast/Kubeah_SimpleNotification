using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kubeah_SimpleNotification;

namespace Kubeah_SimpleNotification
{
    /// <summary>
    /// Create simple notifications.
    /// </summary>
    public class Notification
    {
        Kubeah_SimpleNotification.GUI.Notification guiNotif = new GUI.Notification();
        public Notification(string content) => guiNotif.content = content;

        public Notification(string content, string title)
        {
            guiNotif.content = content;
            guiNotif.title = title;
        }

        /// <summary>
        /// Show the Notification object. Displays the final result of the notification.
        /// </summary>
        public void Show() => guiNotif.Show();

        /// <summary>
        /// Quick creation of a notification.
        /// </summary>
        /// <param name="content">Content of the notification</param>
        public static void Show(string content)
        {
            Kubeah_SimpleNotification.GUI.Notification guiNotif = new GUI.Notification();
            guiNotif.content = content;
            guiNotif.Show();
        }

        /// <summary>
        /// Quick creation of a notification.
        /// </summary>
        /// <param name="content">Content of the notification</param>
        /// <param name="title">Title of the notification</param>
        public static void Show(string content, string title)
        {
            Kubeah_SimpleNotification.GUI.Notification guiNotif = new GUI.Notification();
            guiNotif.title = title;
            guiNotif.content = content;
            guiNotif.Show();
        }
    }
}
