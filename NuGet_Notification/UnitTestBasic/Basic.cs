// Please copy the complete directory : ./NuGet_Notification/App on solution folder
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KNotifications;

namespace Basic
{
    [TestClass]
    public class CreateObjectBasic
    {
        Notification notification = new Notification();
        [TestMethod]
        public void SetTitle() => notification.SetTitle("This is the title");
        [TestMethod]
        public void SetContent() => notification.SetContent("This is the content");
        [TestMethod]
        public void Show() => notification.Show();
    }
}
