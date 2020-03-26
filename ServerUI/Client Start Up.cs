using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerUI
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 sendMesForm = new Form1(ID_Box.Text);
            sendMesForm.Show();
            ID_Box.Clear();
        }
    }
}
