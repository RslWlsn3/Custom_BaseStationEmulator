﻿namespace ClientUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Send_button = new System.Windows.Forms.Button();
            this.Message_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Display_pannel = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // Send_button
            // 
            this.Send_button.Location = new System.Drawing.Point(55, 85);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(90, 40);
            this.Send_button.TabIndex = 0;
            this.Send_button.Text = "Send";
            this.Send_button.UseVisualStyleBackColor = true;
            this.Send_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Message_textbox
            // 
            this.Message_textbox.Location = new System.Drawing.Point(167, 94);
            this.Message_textbox.Name = "Message_textbox";
            this.Message_textbox.Size = new System.Drawing.Size(384, 22);
            this.Message_textbox.TabIndex = 1;
            this.Message_textbox.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type message";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Auto Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.AccessibleDescription = "";
            this.textBox3.Location = new System.Drawing.Point(167, 169);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(384, 22);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "I want you to hit me as hard as you can";
            this.textBox3.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Automaticly send message";
            this.label3.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Location = new System.Drawing.Point(76, 40);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(22, 16);
            this.ID_label.TabIndex = 9;
            this.ID_label.Text = "12";
            this.ID_label.Click += new System.EventHandler(this.Label4_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Display_pannel
            // 
            this.Display_pannel.Location = new System.Drawing.Point(167, 238);
            this.Display_pannel.Multiline = true;
            this.Display_pannel.Name = "Display_pannel";
            this.Display_pannel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Display_pannel.Size = new System.Drawing.Size(384, 172);
            this.Display_pannel.TabIndex = 10;
            this.Display_pannel.TextChanged += new System.EventHandler(this.TextBox2_TextChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(55, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 40);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Display_pannel);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Message_textbox);
            this.Controls.Add(this.Send_button);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Send_button;
        private System.Windows.Forms.TextBox Message_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID_label;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Display_pannel;
    }
}

