using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace KNotifications
{
    class KNotification
    {
        // Example 1 ; true
        public static Dictionary<int, string> data = new Dictionary<int, string>();
        public void Show()
        {
            ShowApp();
        }

        public void setContent(string value)
        {
            AddOrOverwriteData(DataTypes.Content(), value);
        }

        public void setTitle(string value)
        {
            AddOrOverwriteData(DataTypes.Title(), value);
        }

        public void setOpacity(double value)
        {
            AddOrOverwriteData(DataTypes.Content(), DoubleWithComma(value));
        }

        public void setContent(string value)
        {
            AddOrOverwriteData(DataTypes.Content(), value);
        }

        // Static methods
        public static void Show(string title, string content)
        {
            AddOrOverwriteData(DataTypes.Title(), title);
            AddOrOverwriteData(DataTypes.Content(), content);
        }

        public static void Show(string title, string content, double opacity)
        {
            AddOrOverwriteData(DataTypes.Title(), title);
            AddOrOverwriteData(DataTypes.Content(), content);
            AddOrOverwriteData(DataTypes.Content(), DoubleWithComma(opacity));
        }

        

        // PRIVATE
        private static string ColorToStringHexa()
        {
            return "";
        }

        private static string DoubleWithComma(double value)
        {
            string result = value.ToString();
            return result.Replace(".", ",");
        }

        /// <summary>
        /// Use this for create and show notification
        /// </summary>
        private void ShowApp()
        {
            Directory.CreateDirectory("./App/notifications");
            string title = DateTime.Now.ToString("dd.MM.yyyy_HH.mm.ss");
            XmlWriter xmlWriter = XmlWriter.Create("./App/notifications" + title + ".xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("param");
            foreach (KeyValuePair<int, string> entry in data)
            {
                xmlWriter.WriteStartElement("param");
                xmlWriter.WriteAttributeString("name", DataTypes.getName(entry.Key));
                xmlWriter.WriteAttributeString("value", RemoveInvalidCharacters(entry.Value));
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndElement();
            xmlWriter.Close();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("./App/notifications" + title + ".xml");
            xmlDoc.Save("./App/notifications" + title + ".xml");


            var currentDirectory = Directory.GetCurrentDirectory();
            var executablePath = $@"{currentDirectory}\App\Windows_Notification.exe";
            var p = new Process{StartInfo = new ProcessStartInfo(executablePath)};
            p.StartInfo.WorkingDirectory = Path.GetDirectoryName(executablePath);
            p.Start();
        }

        private static void AddOrOverwriteData(int dataTypeId, string value)
        {
            if (data.ContainsKey(dataTypeId))
                data[dataTypeId] = value;
            else
                data.Add(dataTypeId, value);
        }

        // https://sandeep-tada.blogspot.com/2014/02/c-systemargumentexception-hexadecimal_11.html
        private static string RemoveInvalidCharacters(string str)
        {
            if (str == null) return null;

            var formattedStr = new StringBuilder();

            foreach (var ch in str)
            {
                if ((ch < 0x00FD && ch > 0x001F) || ch == '\t' || ch == '\n' || ch == '\r')
                {
                    formattedStr.Append(ch);
                }
            }
            return formattedStr.ToString();
        }
    }
}
