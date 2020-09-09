using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Device_Registration
{
    /** WE ENTER THE PARAMETERS OF THE GATEWAY IN THIS WINDOW**/
    public partial class Gateway : Form
    {
        //Variables where the parameters introduced are saved
        short entered_id;
        string entered_serialn;
        string entered_trademark;
        string entered_model;
        string entered_ip;
        string entered_port;

        //For writing the ip in an intuitive format
        string ip_1;
        string ip_2;
        string ip_3;
        string ip_4;

        //Flags that indicates the variable is entered correctly
        short id_correct;
        short serialn_correct;
        short ip_correct;

        //Strings with the comboboxes's options
        string[] trademarks = { "Schneider", "Electric" };
        string[] models = { "First", "Second" };
        string[] ports = { "Port-1", "Port-2", "Port-3" };

        //Path where the file with the data of the devices registered is saved
        string path = @"Database\GW_data.txt";
        public Gateway()
        {
            InitializeComponent();
        }

        private void Back1_Click(object sender, EventArgs e)    //This function closed this window and takes you back to the first window when button "Back" is clicked
        {
            this.Close();
        }

        private void Ok1_Click(object sender, EventArgs e)  //You click the "Ok" button when you have entered the parameters of the device
        {
            save_var(); //The entered data by the user is saved in the variables
            int already = Validate();   //We check if the device is already registered
            if (already == 0)   //The device IS NOT registered
            {
                Register_device();  //We write the device's parameters in the file
                using (Registration_complete complete_window = new Registration_complete())
                    complete_window.ShowDialog();   //A "success" message is displayed
                this.Close();   //The program takes you back to the first window
            }
            else if (already == 1)   //The device IS registered
            {
                using (Registration_failed failed_window = new Registration_failed())
                    failed_window.ShowDialog(); //A "fail" message is displayed
            }
        }

        void save_var() //Function that saves the entered data in the variables
        {
            entered_id = short.Parse(id.Text);  //ID
            entered_serialn = serialn.Text;     //Serial number
            entered_trademark = trademark.Text; //Trademark
            entered_model = model.Text;         //Model
            entered_ip = ip.Text;               //IP
            entered_port = port.Text;           //Port
            split_ip();
        }

        private void Water_Load(object sender, EventArgs e)
        {
            Filltrademarks();       //This function fills the combobox "trademark" with the options
            Fillmodels();           //This function fills the combobox "model" with the options
            Fillports();            //This function fills the combobox "port" with the options
            Ok1.Enabled = false;    //Button started disabled until all parameters have been entered correctly
        }

        void Filltrademarks()
        {
            for (int i = 0; i < trademarks.Length; i++)
            {
                trademark.Items.Add(trademarks[i]);
            }
        }

        void Fillmodels()
        {
            for (int i = 0; i < models.Length; i++)
            {
                model.Items.Add(models[i]);
            }
        }
        void Fillports()
        {
            for (int i = 0; i < ports.Length; i++)
            {
                port.Items.Add(ports[i]);
            }
        }
        void Register_device()  //We write the device's data in the file
        {
            //This creates the file if not exists, if exists: writes the data in the next line
            TextWriter tw = new StreamWriter(path,true);
            tw.WriteLine("GW {0} {1} {2} {3} {4}.{5}.{6}.{7} {8}", entered_id,entered_serialn,entered_trademark,entered_model, ip_1, ip_2, ip_3, ip_4, entered_port);
            tw.Close();
        }

        int Validate()  //This checks if the device is already registered
        {
            if (File.Exists(path))  //If the file already exists, checks if the ID or serial number are already in the text reading ALL the text
            {
                if (File.ReadAllText(path).Contains(entered_id.ToString()) || File.ReadAllText(path).Contains(entered_serialn))
                {
                    return 1;   //The device is already registered
                }
                else
                {
                    return 0;   //The device is NOT registered
                }
            }
            else
                return 0;       //The file doesn't exist yet, so it's impossible the device was registered before
        }

        private void id_Validating(object sender, CancelEventArgs e)
        {
            Validate_id();  //Checks if the entered ID is a number of 4 digits
        }

        void Validate_id()
        {
            if (id.Text.All(char.IsDigit) && id.TextLength == 4)
            {
                //If all is correct we enable the button "ok"
                Ok1.Enabled = true;
                errorProvider1.SetError(id, "");    //Important to erase the previous error message
                id_correct = 1;
            }
            else
            {
                //If the data is incorrect we disable the button and display an error message
                Ok1.Enabled = false;
                errorProvider1.SetError(id, "The ID has to be a number with 4 digits");
                id_correct = 0;
            }
        }

        private void serialn_Validating(object sender, CancelEventArgs e)
        {
            Validate_serialn(); //Checks if the serial  number is a code of lenght=6
        }

        private void serialn_KeyPress(object sender, KeyPressEventArgs e)
        {
            //With this we force that the serial number is a combination of only letters or numbers
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        void Validate_serialn()
        {
            if (serialn.TextLength == 6)
            {
                //If all is correct we enable the button "ok"
                Ok1.Enabled = true;
                errorProvider1.SetError(serialn, "");   //Important to erase the previous error message
                serialn_correct = 1;
            }
            else
            {
                //If the data is incorrect we disable the button and display an error message
                Ok1.Enabled = false;
                errorProvider1.SetError(serialn, "The serial number has to be a combination of 6 letters or digits");
                serialn_correct = 0;
            }
        }

        private void panel1_Validating(object sender, CancelEventArgs e)
        {
            Validate_options();     //checks if the rest of the parameters are completed
        }

        void Validate_options()
        {
            errorProvider1.SetError(panel1, "");

            if (trademark.Text != string.Empty && model.Text != string.Empty && port.Text != string.Empty && id_correct == 1 && serialn_correct == 1 && ip_correct == 1)
            {
                Ok1.Enabled = true;
                errorProvider1.SetError(panel1, "");
            }
            else
            {
                Ok1.Enabled = false;
                errorProvider1.SetError(panel1, "All the fields must be completed");
            }
        }

        private void ip_Validating(object sender, CancelEventArgs e)    //Similar to id_validating()
        {
            if (ip.Text.All(char.IsDigit) && ip.TextLength == 12)
            {
                Ok1.Enabled = true;
                errorProvider1.SetError(ip, "");
                ip_correct = 1;
            }
            else
            {
                Ok1.Enabled = false;
                errorProvider1.SetError(ip, "The IP has to be a number with 12 digits");
                ip_correct = 0;
            }
        }

        void split_ip() //This divide the ip in four to write it in the file correctly
        {
            ip_1 = entered_ip.Substring(0, 3);
            ip_2 = entered_ip.Substring(3, 3);
            ip_3 = entered_ip.Substring(6, 3);
            ip_4 = entered_ip.Substring(9, 3);
        }
    }
}
