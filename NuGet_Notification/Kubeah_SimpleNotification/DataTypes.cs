using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNotifications
{
    /// <summary>
    /// Return int for data types
    /// </summary>
    class DataTypes
    {
        private static Dictionary<int, string> data = new Dictionary<int, string>(){
            {1, "title"}, {2, "content"}, {3, "opacity"}, {4, "backgroundColor"}, {5, "fontColor"}, {6, "time"}
        };

        public static string GetName(int id) => data[id].ToString();

        /// <summary>
        /// Get Title Id
        /// </summary>
        /// <returns>(int) Title Id</returns>
        public static int Title() => getId("title");

        /// <summary>
        /// Get Content Id
        /// </summary>
        /// <returns>(int) Content Id</returns>
        public static int Content() => getId("content");

        /// <summary>
        /// Get Opacity Id
        /// </summary>
        /// <returns>(int) Opacity Id</returns>
        public static int Opacity() => getId("opacity");

        /// <summary>
        /// Get BackgroundColor Id
        /// </summary>
        /// <returns>(int) BackgroundColor Id</returns>
        public static int BackgroundColor() => getId("backgroundColor");

        /// <summary>
        /// Get FontColor Id
        /// </summary>
        /// <returns>(int) FontColor Id</returns>
        public static int FontColor() => getId("fontColor");

        /// <summary>
        /// Get Time Id
        /// </summary>
        /// <returns>(int) Time Id</returns>
        public static int Time() => getId("time");

        /// <summary>
        /// Get dictionnary {(int) id, (string) definition}
        /// </summary>
        /// <returns>Dictionary<(int) id, (string) definition></returns>
        public Dictionary<int, string> GetDict() => data;

        private static int getId(string temp) => Convert.ToInt32(data.FirstOrDefault(x => x.Value == temp));
    }
}
