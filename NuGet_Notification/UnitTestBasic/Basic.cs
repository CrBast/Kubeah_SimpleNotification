// Please copy the complete directory : ./NuGet_Notification/App on solution folder
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KNotifications;
using System.Drawing;

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
        public void SetBackgroundColor() => notification.SetBackgroundColor(Color.Blue);
        [TestMethod]
        public void SetTime() => notification.SetTime(10);
        [TestCleanup]
        public void Show() => notification.Show();

        
    }
    
}
