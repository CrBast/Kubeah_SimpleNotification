/* 
 * for more informations about notifications
 * Please visit https://github.com/CrBast/Kubeah_SimpleNotification/wiki/English-Documentation---OFFICIAL
 *
 * 
 * 
 * APPLICATION LICENSE
 * MIT License
 * https://github.com/CrBast/Kubeah_SimpleNotification/blob/master/LICENSE
 * */
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Kubeah_SimpleNotification.GUI
{
    public partial class Notification : Form
    {
        public Boolean logsEnable = false;
        public string logsPath = "";

        /// <summary>
        /// String : Path to the style file
        /// </summary>
        public string styleFile = "";



        public Boolean saveNotifications = false;//Default = false
        public string styleFilePath = "";
        public string title = "";
        public string content = "";
        Color backgroundColor = System.Drawing.ColorTranslator.FromHtml("#1F1F1F");
        public int interval = 5000;


        public Notification()
        {
            InitializeComponent();

            this.ShowInTaskbar = false;

            //Displays the window at the bottom of the screen
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height - 7);
        }


        private void pbxArrow_Click(object sender, EventArgs e)
        {

        }

        private void Notification_Load(object sender, EventArgs e)
        {
            // Check if another process exist
            // Bug : Multi process
            Process[] pname = Process.GetProcessesByName(AppDomain.CurrentDomain.FriendlyName.Remove(AppDomain.CurrentDomain.FriendlyName.Length - 4));
            if (pname.Length > 1)
                pname.Where(p => p.Id != Process.GetCurrentProcess().Id).First().Kill();
            pbxLogo.Visible = false;
            lblTitle.Width = 17;
            lblTitle.Height = 9;
            tbxContent.Width = 20;
            tbxContent.Height = 33;
            tbxContent.Size = new System.Drawing.Size(301, 52);
            lblTitle.Text = title;
            tbxContent.Text = content;
            timer.Interval = interval;
            this.BackColor = backgroundColor;
            tbxContent.BackColor = backgroundColor;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void topMost_Tick(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
