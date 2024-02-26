namespace tamrin5.sortNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblnumbers = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtnumbers = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.rdoasc = new System.Windows.Forms.RadioButton();
            this.rdodesc = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnumbers
            // 
            this.lblnumbers.AutoSize = true;
            this.lblnumbers.Location = new System.Drawing.Point(14, 37);
            this.lblnumbers.Name = "lblnumbers";
            this.lblnumbers.Size = new System.Drawing.Size(102, 16);
            this.lblnumbers.TabIndex = 0;
            this.lblnumbers.Text = "Unsorted Data";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(152, 37);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(87, 16);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "Sorted Data";
            // 
            // txtnumbers
            // 
            this.txtnumbers.Location = new System.Drawing.Point(14, 57);
            this.txtnumbers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnumbers.Multiline = true;
            this.txtnumbers.Name = "txtnumbers";
            this.txtnumbers.Size = new System.Drawing.Size(115, 274);
            this.txtnumbers.TabIndex = 2;
            this.txtnumbers.TextChanged += new System.EventHandler(this.txtnumbers_TextChanged);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(136, 57);
            this.txtresult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(115, 274);
            this.txtresult.TabIndex = 3;
            // 
            // rdoasc
            // 
            this.rdoasc.AutoSize = true;
            this.rdoasc.Location = new System.Drawing.Point(8, 23);
            this.rdoasc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoasc.Name = "rdoasc";
            this.rdoasc.Size = new System.Drawing.Size(93, 20);
            this.rdoasc.TabIndex = 4;
            this.rdoasc.TabStop = true;
            this.rdoasc.Text = "Ascending";
            this.rdoasc.UseVisualStyleBackColor = true;
            this.rdoasc.Click += new System.EventHandler(this.rdoasc_Click);
            // 
            // rdodesc
            // 
            this.rdodesc.AutoSize = true;
            this.rdodesc.Location = new System.Drawing.Point(8, 44);
            this.rdodesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdodesc.Name = "rdodesc";
            this.rdodesc.Size = new System.Drawing.Size(100, 20);
            this.rdodesc.TabIndex = 5;
            this.rdodesc.TabStop = true;
            this.rdodesc.Text = "Descending";
            this.rdodesc.UseVisualStyleBackColor = true;
            this.rdodesc.Click += new System.EventHandler(this.rdodesc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoasc);
            this.groupBox1.Controls.Add(this.rdodesc);
            this.groupBox1.Location = new System.Drawing.Point(264, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(134, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort type";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtnumbers);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblnumbers);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Sorting";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnumbers;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtnumbers;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.RadioButton rdoasc;
        private System.Windows.Forms.RadioButton rdodesc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

