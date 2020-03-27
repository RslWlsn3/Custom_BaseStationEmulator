namespace ClientUI
{
    partial class Client_Start_Up
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
            this.button1 = new System.Windows.Forms.Button();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(211, 173);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(100, 22);
            this.ID_Box.TabIndex = 1;
            this.ID_Box.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter ID";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Client_Start_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.button1);
            this.Name = "Client_Start_Up";
            this.Text = "Client_Start_Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ID_Box;
        private System.Windows.Forms.Label label1;
    }
}