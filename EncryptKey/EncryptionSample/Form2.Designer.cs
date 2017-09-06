namespace EncryptionSample
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serialKeyGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netconnectionAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netConnectionNotAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDKeyGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCdKeyStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEncrypt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEncrypt.Location = new System.Drawing.Point(369, 284);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 31);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "generate CD key";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(31, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(16, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(439, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(12, 78);
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
            this.netconnectionAvailableToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.netconnectionAvailableToolStripMenuItem.Name = "netconnectionAvailableToolStripMenuItem";
            this.netconnectionAvailableToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.netconnectionAvailableToolStripMenuItem.Text = "Net Connection Available";
            this.netconnectionAvailableToolStripMenuItem.Click += new System.EventHandler(this.netconnectionAvailableToolStripMenuItem_Click);
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
            this.cdToolStripMenuItem.Enabled = false;
            this.cdToolStripMenuItem.Name = "cdToolStripMenuItem";
            this.cdToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cdToolStripMenuItem.Text = "CD Key Generator";
            // 
            // viewCdKeyStatusToolStripMenuItem
            // 
            this.viewCdKeyStatusToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCdKeyStatusToolStripMenuItem.Name = "viewCdKeyStatusToolStripMenuItem";
            this.viewCdKeyStatusToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewCdKeyStatusToolStripMenuItem.Text = "View CD Key status";
            this.viewCdKeyStatusToolStripMenuItem.Click += new System.EventHandler(this.viewCdKeyStatusToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Key Validity Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 20);
            this.textBox1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(191, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 362);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(566, 400);
            this.Name = "Form2";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Key-Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serialKeyGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netconnectionAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netConnectionNotAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDKeyGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCdKeyStatusToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}