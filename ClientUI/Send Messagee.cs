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

namespace ClientUI
{
    public partial class Form1 : Form
    {
        private static Client_model client;
        public Form1(string ID, Client_model cm)
        {
            InitializeComponent();
            ID_label.Text = ID;
            client = cm;
        }

        private void display(string message, string serverResponse)
        {
            Display_pannel.Text += "Sent: " + message + System.Environment.NewLine;
            Display_pannel.Text += "Response: " + serverResponse + System.Environment.NewLine;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string serverResponse = client.sendMessage(ID_label.Text + Message_textbox.Text);
            display(Message_textbox.Text, serverResponse);
            Message_textbox.Clear();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string serverResponse = client.sendMessage(ID_label.Text + "RTS");            
            display("RTS", serverResponse);
            serverResponse = client.sendMessage(ID_label.Text + textBox3.Text);
            display(textBox3.Text, serverResponse);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
