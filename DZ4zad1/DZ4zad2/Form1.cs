using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ4zad2
{
    public partial class Form1 : Form
    {
        private List<String> puts;
        private int col_puts = -1;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            puts=new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                this.listBox1_Dir.Items.Add(d);
            }
            this.forwardToolStripMenuItem.Click+= new EventHandler(Forward_buttom_Click);
            this.backwardToolStripMenuItem.Click+=new EventHandler(Backward_Buttom_Click);
            this.toolStripButton1_bracward.Click+= new EventHandler(Backward_Buttom_Click);
            this.toolStripButton2_forvard.Click+= new EventHandler(Forward_buttom_Click);
            this.listBox1_Dir.MouseDoubleClick += ListBox1_Dir_MouseDoubleClick;
            this.For_ToolStripMenuItem.Click+= new EventHandler(Forward_buttom_Click);
            this.Bac_ToolStripMenuItem.Click+= new EventHandler(Backward_Buttom_Click);
        }

        private void ListBox1_Dir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.listBox1_Dir.SelectedIndex > -1)
            {
                try
                {
                    col_puts++;
                    String[] dir = Directory.GetDirectories(this.listBox1_Dir.Items[listBox1_Dir.SelectedIndex].ToString());
                    String[] file = Directory.GetFiles(this.listBox1_Dir.Items[listBox1_Dir.SelectedIndex].ToString());
                    this.label1.Text = this.listBox1_Dir.Items[listBox1_Dir.SelectedIndex].ToString();
                    puts.Add(this.listBox1_Dir.Items[listBox1_Dir.SelectedIndex].ToString());
                
                    this.listBox1_Dir.Items.Clear();
                    this.listBox1_File.Items.Clear();
                    foreach (var VARIABLE in dir)
                    {
                        this.listBox1_Dir.Items.Add(VARIABLE);
                    }

                    foreach (var VARIABLE in file)
                    {
                        this.listBox1_File.Items.Add(VARIABLE);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Эта директория закрытого доступа!", "Предупреждение", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    col_puts--;
                }
            }
        }

        private void Backward_Buttom_Click(object sender, EventArgs e)
        {
            col_puts--;
            if (col_puts >=0)
            {
                puts.Remove(puts[col_puts + 1]);
                String[] dir = Directory.GetDirectories(puts[col_puts]);
                String[] file = Directory.GetFiles(puts[col_puts]);
                this.label1.Text = puts[col_puts];
                this.listBox1_Dir.Items.Clear();
                this.listBox1_File.Items.Clear();
                foreach (var VARIABLE in dir)
                {
                    this.listBox1_Dir.Items.Add(VARIABLE);
                }

                foreach (var VARIABLE in file)
                {
                    this.listBox1_File.Items.Add(VARIABLE);
                }
               
            }
            else
            {
                col_puts = -1;
                puts.Clear();
                this.label1.Text = "C# guide";
                this.listBox1_Dir.Items.Clear();
                this.listBox1_File.Items.Clear();
                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo d in allDrives)
                {
                    this.listBox1_Dir.Items.Add(d);
                }
            }
        }
        private void Forward_buttom_Click(object sender, EventArgs e)
        {
            if (this.listBox1_Dir.SelectedIndex > -1)
            {
                try
                {
                    col_puts++;
                    String[] dir = Directory.GetDirectories(this.listBox1_Dir.Items[listBox1_Dir.SelectedIndex].ToString());
                    String[] file = Directory.GetFiles(this.listBox1_Dir.Items[listBox1_Dir.SelectedIndex].ToString());
                    this.label1.Text = this.listBox1_Dir.Items[listBox1_Dir.SelectedIndex].ToString();
                    puts.Add(this.listBox1_Dir.Items[listBox1_Dir.SelectedIndex].ToString());
                
                    this.listBox1_Dir.Items.Clear();
                    this.listBox1_File.Items.Clear();
                    foreach (var VARIABLE in dir)
                    {
                        this.listBox1_Dir.Items.Add(VARIABLE);
                    }

                    foreach (var VARIABLE in file)
                    {
                        this.listBox1_File.Items.Add(VARIABLE);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Эта директория закрытого доступа!", "Предупреждение", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    col_puts--;
                }
            }
        }
        private void bunifuImageButton1_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Minimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
