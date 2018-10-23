using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Show
{
    [TestClass]
    public class Show
    {
        [TestMethod]
        public void ShowSimple()
        {
            Kubeah_SimpleNotification.Notification notification = new Kubeah_SimpleNotification.Notification("Hi");
            notification.Show();

        }
    }
}
