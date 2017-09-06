namespace EncryptionSample
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serialKeyGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netconnectionAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.netConnectionNotAvailableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDKeyGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCdKeyStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEncrypt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEncrypt.Location = new System.Drawing.Point(290, 40);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(130, 31);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Show CD key";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(426, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cdToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cdToolStripMenuItem.Name = "cdToolStripMenuItem";
            this.cdToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cdToolStripMenuItem.Text = "CD Key Generator";
            this.cdToolStripMenuItem.Click += new System.EventHandler(this.cdToolStripMenuItem_Click);
            // 
            // viewCdKeyStatusToolStripMenuItem
            // 
            this.viewCdKeyStatusToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.viewCdKeyStatusToolStripMenuItem.Enabled = false;
            this.viewCdKeyStatusToolStripMenuItem.Name = "viewCdKeyStatusToolStripMenuItem";
            this.viewCdKeyStatusToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewCdKeyStatusToolStripMenuItem.Text = "View CD Key status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "Please enter a id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 293);
            this.dataGridView1.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(550, 362);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(566, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(566, 400);
            this.Name = "Form3";
            this.Opacity = 0.85D;
            this.Text = "Key-Generator";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serialKeyGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netconnectionAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem netConnectionNotAvailableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDKeyGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCdKeyStatusToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}