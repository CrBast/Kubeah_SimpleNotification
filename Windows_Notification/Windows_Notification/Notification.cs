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
 * https://github.com/CrBast/Kubeah_SimpleNotification/wiki/English-Documentation---OFFICIAL
 * 
 * 
 * 
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
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Windows_Notification
{
    public partial class Notification : Form
    {
        public Boolean logsEnable = true;//Default = false
        public string logsPath = "";
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
            // Check if another process exist
            // Bug : Multi process
            Process[] processes = Process.GetProcessesByName("Windows_Notification");
            if (processes.Length > 0)
                processes[0].CloseMainWindow();
            /*
             * Basic initialization
            */
            pbxLogo.Visible = false;
            lblTitle.Width = 17;
            lblTitle.Height = 9;
            tbxContent.Width = 20;
            tbxContent.Height = 33;
            tbxContent.Size = new System.Drawing.Size(301, 52);
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
                        switch (xmlNode.Attributes["name"].Value)
                        {
                            case "fileLogsPath":
                                logsEnable = true;
                                logsPath = xmlNode.Attributes["value"].Value;
                                /*
                                 * Create logs file
                                 */

                                if (!File.Exists($"{logsPath}"))
                                {
                                    File.Create($"{logsPath}");
                                }
                                break;
                            case "notificationsFolder" :
                                directoryPath = xmlNode.Attributes["value"].Value;
                                break;
                            case "saveNotifications":
                                saveNotifications = Convert.ToBoolean(xmlNode.Attributes["value"].Value);
                                break;
                            case "styleFile":
                                if (xmlNode.Attributes["value"].Value != "")
                                {
                                    styleFile = true;
                                    styleFilePath = xmlNode.Attributes["value"].Value;
                                }
                                break;
                        }

                    }
                }
                catch(Exception exc)
                {
                    writeLogs($"{exc.Message}", logsEnable);
                }   
            }
            catch
            {
                writeLogs($"NotificationApp.conf is missing", logsEnable);
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
                writeLogs($"{exc.Message}", logsEnable);
                this.Close();
            }


        }
        public void writeLogs(string text, bool state)
        {
            if (state)
            { 
                try
                {
                    TextWriter tw = new StreamWriter($"{logsPath}", true);
                    // write a line of text to the file
                    tw.WriteLine($"{ DateTime.Now}   :   { text }");
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
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(filePath);
                try
                {
                    // Create XML file connexion
                    foreach (XmlNode xmlNode in xmlDoc.DocumentElement)
                    {
                        switch (xmlNode.Attributes["name"].Value)
                        {
                            case "content":
                                try { tbxContent.Text = xmlNode.Attributes["value"].Value; }
                                catch { writeLogs("Minor  =>  Error with parameter 'content'", logsEnable); }

                                break;

                            case "title":
                                try { lblTitle.Text = xmlNode.Attributes["value"].Value; }
                                catch { writeLogs("Minor  =>  Error with parameter 'title'", logsEnable); }

                                break;

                            case "backgroundColor":
                                try
                                {
                                    Color color2 = System.Drawing.ColorTranslator.FromHtml(xmlNode.Attributes["value"].Value);
                                    this.BackColor = color2;
                                    tbxContent.BackColor = color2;
                                }
                                catch { writeLogs("Minor  =>  Error with parameter 'backgroundColor'", logsEnable); }
                                break;

                            case "opacity":
                                try { this.Opacity = Convert.ToDouble(xmlNode.Attributes["value"].Value); }
                                catch { writeLogs("Minor  =>  Error with parameter 'opacity'", logsEnable); }

                                break;

                            case "time":
                                try { timer.Interval = Convert.ToInt32(xmlNode.Attributes["value"].Value) * 1000; }
                                catch { writeLogs("Minor  =>  Error with parameter 'time'", logsEnable); }
                                break;

                            case "fontColor":
                                try
                                {
                                    Color color = System.Drawing.ColorTranslator.FromHtml(xmlNode.Attributes["value"].Value);
                                    lblTitle.ForeColor = color;
                                    tbxContent.ForeColor = color;
                                }
                                catch
                                {
                                    writeLogs("Minor  =>  Error with parameter 'fontColor'", logsEnable);
                                }
                                break;

                            case "iconPath":
                                try
                                {
                                    pbxLogo.ImageLocation = xmlNode.Attributes["value"].Value;
                                    pbxLogo.Visible = true;
                                    this.Refresh();
                                    lblTitle.Location = new Point(51, 7);
                                    tbxContent.Location = new Point(54, 25);
                                    tbxContent.Size = new System.Drawing.Size(246, 52);
                                    pbxLogo.Location = new Point(10, 9);
                                }
                                catch
                                {
                                    writeLogs("Minor  =>  Error with parameter 'iconPath'", logsEnable);
                                }

                                break;
                        }
                    }
                }
                catch (Exception exc)
                {
                    writeLogs($"{exc.Message}", logsEnable);
                    this.Close();
                }
            }
            catch {
                writeLogs($"Medium  =>  '{filePath}' not found", logsEnable);
            }
        }
    }
}