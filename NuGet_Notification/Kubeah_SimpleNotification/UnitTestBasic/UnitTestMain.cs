using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBasic
{
    [TestClass]
    public class UnitTestMain
    {
        [TestMethod]
        public void Show()
        {
            Kubeah_SimpleNotification.Notification notification = new Kubeah_SimpleNotification.Notification("Hi");
            notification.Show();

        }
    }
}
