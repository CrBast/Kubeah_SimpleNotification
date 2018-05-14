/*
 * The application requires that 
 * the "Notifications" directory
 * 
 * You can change this value in 
 * the "./NotificationApp.conf"
 * 
 * The files contained in the 
 * directory must be in XML format
 * Example : 
 * https://github.com/CrBast/Kubeah_SimpleNotification/edit/master/using-fr.md
 * 
 * 
 * 
 * for more informations about notifications
 * Please visit https://github.com/CrBast/Kubeah_SimpleNotification/edit/master/using-fr.md
 *
 * 
 * 
 * APPLICATION LICENSE
 * MIT License
 * https://github.com/CrBast/Kubeah_SimpleNotification/blob/master/LICENSE
 * */
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Windows_Notification
{
    public partial class Notification : Form
    {
        public Boolean logsEnable = false;//Default = false
        public Boolean saveNotifications = false;//Default = false
        public Boolean styleFile = false;
        public string styleFilePath = "";
        public string directoryPath = ".\\Notifications";
        public Notification()
        {
            InitializeComponent();

            //Hidde program in taskbar
            this.ShowInTaskbar = false;

            //Displays the window at the bottom of the screen
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height - 7);
        }

        private void pbxArrow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Notification_Load(object sender, EventArgs e)
        {            
            /*
             * Basic initialization
            */
            lblTitle.Text = "";
            tbxContent.Text = "";
            timer.Interval = 5000;
            Color nightGray = System.Drawing.ColorTranslator.FromHtml("#1F1F1F");
            this.BackColor = nightGray;
            tbxContent.BackColor = nightGray;


            /*
             * Read config file
             */
            try
            {
                XmlDocument xmlConfig = new XmlDocument();
                xmlConfig.Load("./NotificationApp.conf");
                try
                {
                    foreach (XmlNode xmlNode in xmlConfig.DocumentElement)
                    {
                        if (xmlNode.Attributes["name"].Value == "logsEnable")
                        {
                            logsEnable = Convert.ToBoolean(xmlNode.Attributes["value"].Value);
                            /*
                             * Create log file
                             */
                            if (logsEnable)
                            {
                                if (!File.Exists($".\\Notification.log"))
                                {
                                    File.Create($".\\Notification.log");
                                }
                            }
                        }

                        if (xmlNode.Attributes["name"].Value == "notificationsFolder")
                        {
                            directoryPath = xmlNode.Attributes["value"].Value;
                        }

                        if (xmlNode.Attributes["name"].Value == "saveNotifications")
                        {
                            saveNotifications = Convert.ToBoolean(xmlNode.Attributes["value"].Value);
                        }
                        if (xmlNode.Attributes["name"].Value == "styleFile")
                        {
                            if (xmlNode.Attributes["value"].Value != "")
                            {
                                styleFile = true;
                                styleFilePath = xmlNode.Attributes["value"].Value;
                            }
                        }

                    }
                }
                catch(Exception exc)
                {
                    writeLogs($"{DateTime.Now} \r   { exc.ToString()}", logsEnable);
                }   
            }
            catch
            {
                writeLogs($"{DateTime.Now} \r   NotificationApp.conf is missing", logsEnable);
            }
            var directory = new DirectoryInfo(directoryPath);

            // Select the last file on the directory
            try
            {
                var myFile = (from f in directory.GetFiles() orderby f.LastWriteTime descending select f).First();
                getNotificationConfig(myFile.FullName);
                if (!saveNotifications)
                {
                    myFile.Delete();
                }
                if (styleFile)//Apply the style file
                {
                    getNotificationConfig(styleFilePath);
                }
                timer.Enabled = true;
            }
            catch (Exception exc)
            {
                writeLogs($"{ DateTime.Now} \r   { exc.ToString()}", logsEnable);
                this.Close();
            }


        }
        public void writeLogs(string text, bool state)
        {
            if (state)
            { 
                try
                {
                    TextWriter tw = new StreamWriter(".\\Notification.log", true);
                    // write a line of text to the file
                    tw.WriteLine(text + "\r\n");
                    // close the stream
                    tw.Close();
                }
                catch {}
            }
        }

        private void topMost_Tick(object sender, EventArgs e)
        {
            //Show the form at the forefront
            this.TopMost = true;
        }
        public void getNotificationConfig(string filePath)
        {
            try
            {
                // Create XML file connexion
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);

                foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
                {
                    if (xmlNode.Attributes["name"].Value == "content")
                    {
                        tbxContent.Text = xmlNode.Attributes["value"].Value;
                    }

                    if (xmlNode.Attributes["name"].Value == "title")
                    {
                        lblTitle.Text = xmlNode.Attributes["value"].Value;
                    }

                    if (xmlNode.Attributes["name"].Value == "backgroundColor")
                    {
                        try
                        {
                            Color color = System.Drawing.ColorTranslator.FromHtml(xmlNode.Attributes["value"].Value);
                            this.BackColor = color;
                            tbxContent.BackColor = color;
                        }
                        catch { }
                    }
                    if (xmlNode.Attributes["name"].Value == "time")
                    {
                        timer.Interval = Convert.ToInt32(xmlNode.Attributes["value"].Value) * 1000;
                    }

                    if (xmlNode.Attributes["name"].Value == "fontColor")
                    {
                        Color color = System.Drawing.ColorTranslator.FromHtml(xmlNode.Attributes["value"].Value);
                        lblTitle.ForeColor = color;
                        tbxContent.ForeColor = color;
                    }
                }
            }
            catch (Exception exc)
            {
                writeLogs($"{ DateTime.Now} \r   { exc.ToString()}", logsEnable);
                this.Close();
            }

        }
    }
}