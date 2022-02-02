using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceReminder
{
    public partial class RemindWindow : Form
    {
        public RemindWindow()
        {
            InitializeComponent();
            Load += RemindWindow_Load;
        }

        private void RemindWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void postponeReminder_Click(object sender, EventArgs e)
        {

        }
    }
}
