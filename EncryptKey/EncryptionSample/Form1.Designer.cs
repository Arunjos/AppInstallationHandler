namespace EncryptionSample
{
    partial class KEY
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serialKeyGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netconnectionAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netConnectionNotAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDKeyGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCdKeyStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEncrypt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEncrypt.Location = new System.Drawing.Point(373, 319);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 31);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "generate serial key";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 60);
            this.textBox1.MaxLength = 1000;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 282);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(439, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(0, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "HDD No.:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(103, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(103, 157);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(439, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(103, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(439, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(0, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ph No.:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(0, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cd No.:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialKeyGeneratorToolStripMenuItem,
            this.cDKeyGeneratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(550, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serialKeyGeneratorToolStripMenuItem
            // 
            this.serialKeyGeneratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.netconnectionAvailableToolStripMenuItem,
            this.netConnectionNotAvailableToolStripMenuItem});
            this.serialKeyGeneratorToolStripMenuItem.Name = "serialKeyGeneratorToolStripMenuItem";
            this.serialKeyGeneratorToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.serialKeyGeneratorToolStripMenuItem.Text = "Serial Key Generator";
            // 
            // netconnectionAvailableToolStripMenuItem
            // 
            this.netconnectionAvailableToolStripMenuItem.Enabled = false;
            this.netconnectionAvailableToolStripMenuItem.Name = "netconnectionAvailableToolStripMenuItem";
            this.netconnectionAvailableToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.netconnectionAvailableToolStripMenuItem.Text = "Net Connection Available";
            // 
            // netConnectionNotAvailableToolStripMenuItem
            // 
            this.netConnectionNotAvailableToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.netConnectionNotAvailableToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.netConnectionNotAvailableToolStripMenuItem.Name = "netConnectionNotAvailableToolStripMenuItem";
            this.netConnectionNotAvailableToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.netConnectionNotAvailableToolStripMenuItem.Text = "Net Connection Not Available";
            this.netConnectionNotAvailableToolStripMenuItem.Click += new System.EventHandler(this.netConnectionNotAvailableToolStripMenuItem_Click);
            // 
            // cDKeyGeneratorToolStripMenuItem
            // 
            this.cDKeyGeneratorToolStripMenuItem.BackColor = System.Drawing.SystemColors.GrayText;
            this.cDKeyGeneratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cdToolStripMenuItem,
            this.viewCdKeyStatusToolStripMenuItem});
            this.cDKeyGeneratorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cDKeyGeneratorToolStripMenuItem.Name = "cDKeyGeneratorToolStripMenuItem";
            this.cDKeyGeneratorToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cDKeyGeneratorToolStripMenuItem.Text = "CD Key ";
            // 
            // cdToolStripMenuItem
            // 
            this.cdToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cdToolStripMenuItem.Name = "cdToolStripMenuItem";
            this.cdToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cdToolStripMenuItem.Text = "CD Key Generator";
            this.cdToolStripMenuItem.Click += new System.EventHandler(this.cdToolStripMenuItem_Click);
            // 
            // viewCdKeyStatusToolStripMenuItem
            // 
            this.viewCdKeyStatusToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCdKeyStatusToolStripMenuItem.Name = "viewCdKeyStatusToolStripMenuItem";
            this.viewCdKeyStatusToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewCdKeyStatusToolStripMenuItem.Text = "View CD Key status";
            this.viewCdKeyStatusToolStripMenuItem.Click += new System.EventHandler(this.viewCdKeyStatusToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(0, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Serial No.:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(103, 205);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(439, 20);
            this.textBox5.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(0, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Name:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(103, 244);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(439, 20);
            this.textBox6.TabIndex = 17;
            // 
            // KEY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 362);
            this.ControlBox = false;
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(566, 400);
            this.Name = "KEY";
            this.Opacity = 0.85D;
            this.Text = "Key-Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serialKeyGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netconnectionAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netConnectionNotAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDKeyGeneratorToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ToolStripMenuItem cdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCdKeyStatusToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
    }
}

