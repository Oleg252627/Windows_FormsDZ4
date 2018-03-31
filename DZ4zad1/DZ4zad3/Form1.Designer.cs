namespace DZ4zad3
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1_minimiz = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1_Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.TopLevelMenu = new System.Windows.Forms.TextBox();
            this.SubItem = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1_menu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1_PodMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_minimiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuImageButton1_minimiz);
            this.panel1.Controls.Add(this.bunifuImageButton1_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 34);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Creating a menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DZ4zad3.Properties.Resources._11logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1_minimiz
            // 
            this.bunifuImageButton1_minimiz.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1_minimiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1_minimiz.Image = global::DZ4zad3.Properties.Resources._100;
            this.bunifuImageButton1_minimiz.ImageActive = null;
            this.bunifuImageButton1_minimiz.Location = new System.Drawing.Point(516, 10);
            this.bunifuImageButton1_minimiz.Name = "bunifuImageButton1_minimiz";
            this.bunifuImageButton1_minimiz.Size = new System.Drawing.Size(16, 16);
            this.bunifuImageButton1_minimiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1_minimiz.TabIndex = 1;
            this.bunifuImageButton1_minimiz.TabStop = false;
            this.bunifuImageButton1_minimiz.Zoom = 10;
            this.bunifuImageButton1_minimiz.Click += new System.EventHandler(this.bunifuImageButton1_minimiz_Click);
            // 
            // bunifuImageButton1_Close
            // 
            this.bunifuImageButton1_Close.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1_Close.Image = global::DZ4zad3.Properties.Resources._2close1;
            this.bunifuImageButton1_Close.ImageActive = null;
            this.bunifuImageButton1_Close.Location = new System.Drawing.Point(538, 10);
            this.bunifuImageButton1_Close.Name = "bunifuImageButton1_Close";
            this.bunifuImageButton1_Close.Size = new System.Drawing.Size(16, 16);
            this.bunifuImageButton1_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1_Close.TabIndex = 1;
            this.bunifuImageButton1_Close.TabStop = false;
            this.bunifuImageButton1_Close.Zoom = 10;
            this.bunifuImageButton1_Close.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 10);
            this.panel2.TabIndex = 1;
            // 
            // TopLevelMenu
            // 
            this.TopLevelMenu.Location = new System.Drawing.Point(183, 205);
            this.TopLevelMenu.Name = "TopLevelMenu";
            this.TopLevelMenu.Size = new System.Drawing.Size(126, 20);
            this.TopLevelMenu.TabIndex = 2;
            // 
            // SubItem
            // 
            this.SubItem.Location = new System.Drawing.Point(183, 254);
            this.SubItem.Name = "SubItem";
            this.SubItem.Size = new System.Drawing.Size(126, 20);
            this.SubItem.TabIndex = 3;
            // 
            // bunifuFlatButton1_menu
            // 
            this.bunifuFlatButton1_menu.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1_menu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1_menu.BorderRadius = 0;
            this.bunifuFlatButton1_menu.ButtonText = "Добавить пункт меню";
            this.bunifuFlatButton1_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1_menu.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1_menu.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1_menu.Iconimage = null;
            this.bunifuFlatButton1_menu.Iconimage_right = null;
            this.bunifuFlatButton1_menu.Iconimage_right_Selected = null;
            this.bunifuFlatButton1_menu.Iconimage_Selected = null;
            this.bunifuFlatButton1_menu.IconMarginLeft = 0;
            this.bunifuFlatButton1_menu.IconMarginRight = 0;
            this.bunifuFlatButton1_menu.IconRightVisible = true;
            this.bunifuFlatButton1_menu.IconRightZoom = 0D;
            this.bunifuFlatButton1_menu.IconVisible = true;
            this.bunifuFlatButton1_menu.IconZoom = 90D;
            this.bunifuFlatButton1_menu.IsTab = false;
            this.bunifuFlatButton1_menu.Location = new System.Drawing.Point(344, 197);
            this.bunifuFlatButton1_menu.Name = "bunifuFlatButton1_menu";
            this.bunifuFlatButton1_menu.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1_menu.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1_menu.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1_menu.selected = false;
            this.bunifuFlatButton1_menu.Size = new System.Drawing.Size(169, 32);
            this.bunifuFlatButton1_menu.TabIndex = 4;
            this.bunifuFlatButton1_menu.Text = "Добавить пункт меню";
            this.bunifuFlatButton1_menu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1_menu.Textcolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1_menu.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // bunifuFlatButton1_PodMenu
            // 
            this.bunifuFlatButton1_PodMenu.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1_PodMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1_PodMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1_PodMenu.BorderRadius = 0;
            this.bunifuFlatButton1_PodMenu.ButtonText = "Добавить подменю";
            this.bunifuFlatButton1_PodMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1_PodMenu.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1_PodMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1_PodMenu.Iconimage = null;
            this.bunifuFlatButton1_PodMenu.Iconimage_right = null;
            this.bunifuFlatButton1_PodMenu.Iconimage_right_Selected = null;
            this.bunifuFlatButton1_PodMenu.Iconimage_Selected = null;
            this.bunifuFlatButton1_PodMenu.IconMarginLeft = 0;
            this.bunifuFlatButton1_PodMenu.IconMarginRight = 0;
            this.bunifuFlatButton1_PodMenu.IconRightVisible = true;
            this.bunifuFlatButton1_PodMenu.IconRightZoom = 0D;
            this.bunifuFlatButton1_PodMenu.IconVisible = true;
            this.bunifuFlatButton1_PodMenu.IconZoom = 90D;
            this.bunifuFlatButton1_PodMenu.IsTab = false;
            this.bunifuFlatButton1_PodMenu.Location = new System.Drawing.Point(344, 249);
            this.bunifuFlatButton1_PodMenu.Name = "bunifuFlatButton1_PodMenu";
            this.bunifuFlatButton1_PodMenu.Normalcolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1_PodMenu.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1_PodMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1_PodMenu.selected = false;
            this.bunifuFlatButton1_PodMenu.Size = new System.Drawing.Size(169, 32);
            this.bunifuFlatButton1_PodMenu.TabIndex = 5;
            this.bunifuFlatButton1_PodMenu.Text = "Добавить подменю";
            this.bunifuFlatButton1_PodMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1_PodMenu.Textcolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1_PodMenu.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DZ4zad3.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 309);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuFlatButton1_PodMenu);
            this.Controls.Add(this.bunifuFlatButton1_menu);
            this.Controls.Add(this.SubItem);
            this.Controls.Add(this.TopLevelMenu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_minimiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1_Close;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1_minimiz;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TopLevelMenu;
        private System.Windows.Forms.TextBox SubItem;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1_menu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1_PodMenu;
    }
}

