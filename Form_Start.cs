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
    /**  THE VERY FIRST WINDOW   **/
    public partial class Inicio : Form  
    {
        //String with the combobox's options
        string[] types = { "Water meter", "Electrical meter", "Gateway" };
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ok.Enabled = false;     //Button started disabled until an option is selected
            Filltypes();    //For filling the combobox
        }

        void Filltypes()    //This function fills the combobox "type" with the options
        {
            for(int i=0; i<types.Length; i++)
            {
                type.Items.Add(types[i]);
            }
        }

        private void Exit_Click(object sender, EventArgs e)    //This function closes the program when clicking "exit" button
        {
            this.Close();
        }

        private void Ok_Click(object sender, EventArgs e)   //This function opens the correct window depending of the option selected
        {
            string selected_type = type.SelectedItem.ToString();    //A string where we save the selected option in the combobox

            if (selected_type == "Water meter")     //Water meter window
            {
                using (Water water_window = new Water())    
                    water_window.ShowDialog();
            }
            else if(selected_type == "Electrical meter")    //Electrical meter window
            {
                using (Electrical electrical_window = new Electrical())
                    electrical_window.ShowDialog();
            }
            else if (selected_type == "Gateway")    //Gateway window
            {
                using (Gateway gateway_window = new Gateway())
                    gateway_window.ShowDialog();
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ok.Enabled = true;  //When an option of the combobox is selected, button "Ok" is enabled
        }
    }
}
