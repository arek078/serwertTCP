namespace serwertTCP
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
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(46, 224);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(183, 224);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(34, 13);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(100, 20);
            this.adres.TabIndex = 2;
            this.adres.Text = "adres";
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(152, 12);
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(120, 20);
            this.my_port.TabIndex = 3;
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(59, 63);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(120, 95);
            this.info_o_polaczeniu.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
    }
}

