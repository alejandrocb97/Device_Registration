using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Registration
{
    /** THIS WINDOW APPEARS WHEN A REGISTRATION HAS BEEN SUCCESFUL
     *  YOU ONLY HAVE TO PRESS "OK" TO CLOSE THE MESSAGE DISPLAYED**/
    public partial class Registration_complete : Form
    {
        public Registration_complete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
