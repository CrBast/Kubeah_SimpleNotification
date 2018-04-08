using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubeah_SimpleNotification
{
    public partial class Notification : Form
    {
        public Notification(string Content, string Title)
        {
            InitializeComponent();
            string title = Title;
            string content = Content;
            this.Text = title;
        }
    }
}
