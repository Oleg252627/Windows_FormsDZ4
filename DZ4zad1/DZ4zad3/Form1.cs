using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ4zad3
{
    public partial class Form1 : Form
    {
        private MenuStrip menu;
        private ToolStripMenuItem toolStrip;
        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
            menu = new MenuStrip();
            toolStrip = new ToolStripMenuItem();
            this.Controls.Add(menu);
            menu.BringToFront();
            this.bunifuFlatButton1_menu.Click += BunifuFlatButton1_menu_Click;
            this.bunifuFlatButton1_PodMenu.Click += BunifuFlatButton1_PodMenu_Click;
        }

        private void BunifuFlatButton1_PodMenu_Click(object sender, EventArgs e)
        {
            if (this.TopLevelMenu.Text != "")
            {
                if (this.SubItem.Text != "")
                {
                    foreach (var VARIABLE in Controls)
                    {
                        if (VARIABLE is MenuStrip)
                        {
                            foreach (var item in (VARIABLE as MenuStrip).Items)
                            {
                                if (item is ToolStripMenuItem)
                                {
                                    if ((item as ToolStripMenuItem).Text == this.TopLevelMenu.Text)
                                    {
                                        (item as ToolStripMenuItem).DropDownItems.Add(this.SubItem.Text);
                                        (item as ToolStripMenuItem).DropDownItems.Add(new ToolStripSeparator());
                                        flag = true;
                                        this.SubItem.Text = null;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Вы не ввели название подменю", "Предупреждение", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели название меню", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!flag)
            {
                MessageBox.Show("Такого пункта меню нет", "Оповещение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.TopLevelMenu.Text = null;
            }
        }

        private void BunifuFlatButton1_menu_Click(object sender, EventArgs e)
        {
            if (this.TopLevelMenu.Text!="")
            {
                menu.Items.Add(toolStrip.Text = this.TopLevelMenu.Text);
                this.TopLevelMenu.Text = null;
            }
            else
            {
                MessageBox.Show("Вы не ввели название меню", "Предупреждение", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_minimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
