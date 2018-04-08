using Kubeah_SimpleNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Kubeah_SimpleNotification
{
    class Program
    {
        static void Main(string[] args)
        {
            KNotification kNotification = new KNotification("Temp", "Le Titre");
            kNotification.Show();
            Console.WriteLine("<< KNotification(string, string) >> object initialize");
            Console.Read();
        }
    }
}
