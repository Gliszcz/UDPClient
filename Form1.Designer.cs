namespace UDPClient
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
            this.txtb_adress = new System.Windows.Forms.TextBox();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.txtb_message = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.listBox_info = new System.Windows.Forms.ListBox();
            this.adress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_adress
            // 
            this.txtb_adress.Location = new System.Drawing.Point(78, 9);
            this.txtb_adress.Name = "txtb_adress";
            this.txtb_adress.Size = new System.Drawing.Size(121, 20);
            this.txtb_adress.TabIndex = 0;
            // 
            // nud_port
            // 
            this.nud_port.Location = new System.Drawing.Point(79, 35);
            this.nud_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(120, 20);
            this.nud_port.TabIndex = 1;
            // 
            // txtb_message
            // 
            this.txtb_message.Location = new System.Drawing.Point(37, 63);
            this.txtb_message.Multiline = true;
            this.txtb_message.Name = "txtb_message";
            this.txtb_message.Size = new System.Drawing.Size(291, 219);
            this.txtb_message.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(124, 288);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 40);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "SEND";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // listBox_info
            // 
            this.listBox_info.FormattingEnabled = true;
            this.listBox_info.Location = new System.Drawing.Point(390, 57);
            this.listBox_info.Name = "listBox_info";
            this.listBox_info.Size = new System.Drawing.Size(223, 225);
            this.listBox_info.TabIndex = 4;
            // 
            // adress
            // 
            this.adress.AutoSize = true;
            this.adress.Location = new System.Drawing.Point(34, 9);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(38, 13);
            this.adress.TabIndex = 5;
            this.adress.Text = "adress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.listBox_info);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txtb_message);
            this.Controls.Add(this.nud_port);
            this.Controls.Add(this.txtb_adress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_adress;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.TextBox txtb_message;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.ListBox listBox_info;
        private System.Windows.Forms.Label adress;
        private System.Windows.Forms.Label label1;
    }
}

