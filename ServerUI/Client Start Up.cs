using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;
using System.Threading;

namespace ClientUI
{
    public partial class Client_Start_Up : Form
    {
        public Client_Start_Up()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void connectToServer()
        {
            string ID = "ID#" + ID_Box.Text + ": "; //need to change how I hadle ID
            Client_model cm = new Client_model();
            Form1 sendMesForm = new Form1("ID#" + ID_Box.Text + ": ", cm);
            ID_Box.Clear();
            sendMesForm.ShowDialog();
            

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(connectToServer);
            t1.Start(); //Thread is spawned to listen for user input            
        }
    }
}
