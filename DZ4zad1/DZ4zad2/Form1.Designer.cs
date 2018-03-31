namespace DZ4zad2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1_Minimiz = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backwardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1_bracward = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2_forvard = new System.Windows.Forms.ToolStripButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.listBox1_Dir = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.For_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bac_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1_File = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Minimiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Close)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.bunifuImageButton1_Minimiz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuImageButton1_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 39);
            this.panel1.TabIndex = 1;
            // 
            // bunifuImageButton1_Minimiz
            // 
            this.bunifuImageButton1_Minimiz.BackColor = System.Drawing.Color.Maroon;
            this.bunifuImageButton1_Minimiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1_Minimiz.Image = global::DZ4zad2.Properties.Resources._100;
            this.bunifuImageButton1_Minimiz.ImageActive = null;
            this.bunifuImageButton1_Minimiz.Location = new System.Drawing.Point(798, 7);
            this.bunifuImageButton1_Minimiz.Name = "bunifuImageButton1_Minimiz";
            this.bunifuImageButton1_Minimiz.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1_Minimiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1_Minimiz.TabIndex = 6;
            this.bunifuImageButton1_Minimiz.TabStop = false;
            this.bunifuImageButton1_Minimiz.Zoom = 10;
            this.bunifuImageButton1_Minimiz.Click += new System.EventHandler(this.bunifuImageButton1_Minimiz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "C# guide";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DZ4zad2.Properties.Resources.logo_zad2;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1_Close
            // 
            this.bunifuImageButton1_Close.BackColor = System.Drawing.Color.Maroon;
            this.bunifuImageButton1_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1_Close.Image = global::DZ4zad2.Properties.Resources._2close;
            this.bunifuImageButton1_Close.ImageActive = null;
            this.bunifuImageButton1_Close.Location = new System.Drawing.Point(828, 7);
            this.bunifuImageButton1_Close.Name = "bunifuImageButton1_Close";
            this.bunifuImageButton1_Close.Size = new System.Drawing.Size(24, 24);
            this.bunifuImageButton1_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1_Close.TabIndex = 0;
            this.bunifuImageButton1_Close.TabStop = false;
            this.bunifuImageButton1_Close.Zoom = 10;
            this.bunifuImageButton1_Close.Click += new System.EventHandler(this.bunifuImageButton1_Close_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 39);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(862, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forwardToolStripMenuItem,
            this.backwardToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // forwardToolStripMenuItem
            // 
            this.forwardToolStripMenuItem.Name = "forwardToolStripMenuItem";
            this.forwardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.forwardToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.forwardToolStripMenuItem.Text = "Forward";
            // 
            // backwardToolStripMenuItem
            // 
            this.backwardToolStripMenuItem.Name = "backwardToolStripMenuItem";
            this.backwardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.backwardToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.backwardToolStripMenuItem.Text = "Backward";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1_bracward,
            this.toolStripButton2_forvard});
            this.toolStrip1.Location = new System.Drawing.Point(0, 63);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(862, 26);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1_bracward
            // 
            this.toolStripButton1_bracward.AutoSize = false;
            this.toolStripButton1_bracward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1_bracward.Image = global::DZ4zad2.Properties.Resources._11;
            this.toolStripButton1_bracward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1_bracward.Name = "toolStripButton1_bracward";
            this.toolStripButton1_bracward.Size = new System.Drawing.Size(24, 23);
            this.toolStripButton1_bracward.Text = "Назад";
            // 
            // toolStripButton2_forvard
            // 
            this.toolStripButton2_forvard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2_forvard.Image = global::DZ4zad2.Properties.Resources._12;
            this.toolStripButton2_forvard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2_forvard.Name = "toolStripButton2_forvard";
            this.toolStripButton2_forvard.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton2_forvard.Text = "Вперед";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // listBox1_Dir
            // 
            this.listBox1_Dir.BackColor = System.Drawing.Color.White;
            this.listBox1_Dir.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1_Dir.ForeColor = System.Drawing.Color.Black;
            this.listBox1_Dir.FormattingEnabled = true;
            this.listBox1_Dir.HorizontalScrollbar = true;
            this.listBox1_Dir.Location = new System.Drawing.Point(36, 128);
            this.listBox1_Dir.Name = "listBox1_Dir";
            this.listBox1_Dir.Size = new System.Drawing.Size(378, 329);
            this.listBox1_Dir.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.For_ToolStripMenuItem,
            this.Bac_ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // For_ToolStripMenuItem
            // 
            this.For_ToolStripMenuItem.Name = "For_ToolStripMenuItem";
            this.For_ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.For_ToolStripMenuItem.Text = "Вперед";
            // 
            // Bac_ToolStripMenuItem
            // 
            this.Bac_ToolStripMenuItem.Name = "Bac_ToolStripMenuItem";
            this.Bac_ToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.Bac_ToolStripMenuItem.Text = "Назад";
            // 
            // listBox1_File
            // 
            this.listBox1_File.BackColor = System.Drawing.Color.White;
            this.listBox1_File.ForeColor = System.Drawing.Color.Black;
            this.listBox1_File.FormattingEnabled = true;
            this.listBox1_File.HorizontalScrollbar = true;
            this.listBox1_File.Location = new System.Drawing.Point(449, 128);
            this.listBox1_File.Name = "listBox1_File";
            this.listBox1_File.Size = new System.Drawing.Size(378, 329);
            this.listBox1_File.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Directories";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(445, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Files";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::DZ4zad2.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(862, 495);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1_File);
            this.Controls.Add(this.listBox1_Dir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Minimiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Close)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backwardToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1_bracward;
        private System.Windows.Forms.ToolStripButton toolStripButton2_forvard;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ListBox listBox1_Dir;
        private System.Windows.Forms.ListBox listBox1_File;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1_Minimiz;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem For_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bac_ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

