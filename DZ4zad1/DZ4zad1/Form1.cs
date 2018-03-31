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

namespace DZ4zad1
{
    public partial class Form1 : Form
    {
        private bool flagInstrument = true;
        private OpenFileDialog openFile;
        private SaveFileDialog saveFile;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStrip1.Visible = false;
            this.bunifuImageButton2_instrument.Click += BunifuImageButton2_instrument_Click;
            this.ObenToolStripMenuItem.Click+=new EventHandler(Open_Button_Clic);
            this.toolStripButton1_Otkrit.Click+= new EventHandler(Open_Button_Clic);
            this.SaveToolStripMenuItem.Click+= new EventHandler(Save_Button_Click);
            this.toolStripButton2_Sohranit.Click+= new EventHandler(Save_Button_Click);
            this.Sav_2ToolStripMenuItem.Click+= new EventHandler(SaveAS_Button_Click);
            this.New_docToolStripMenuItem.Click+= new EventHandler(New_Doc_Button_Click);
            this.toolStripButton3_New_docum.Click+= new EventHandler(New_Doc_Button_Click);
            this.Cope_ToolStripMenuItem.Click+= new EventHandler(Cope_Button_Click);
            this.toolStripButton4_Copirovat.Click+= new EventHandler(Cope_Button_Click);
            this.Copy_ToolStripMenuItem.Click += new EventHandler(Cope_Button_Click);
            this.Cut_ToolStripMenuItem.Click+= new EventHandler(Cut_Button_Click);
            this.toolStripButton5_virezat.Click+= new EventHandler(Cut_Button_Click);
            this.Virez_ToolStripMenuItem.Click+= new EventHandler(Cut_Button_Click);
            this.Paste_ToolStripMenuItem.Click+= new EventHandler(Paste_Button_Click);
            this.toolStripButton6_vstavit.Click+= new EventHandler(Paste_Button_Click);
            this.Vstav_ToolStripMenuItem.Click+= new EventHandler(Paste_Button_Click);
            this.Highlight_ToolStripMenuItem.Click+= new EventHandler(Highlight_Buttom_Click);
            this.Undo_ToolStripMenuItem.Click+= new EventHandler(Undo_Buttom_Click);
            this.toolStripButton7_otmena.Click+= new EventHandler(Undo_Buttom_Click);
            this.Otmena_ToolStripMenuItem.Click+= new EventHandler(Undo_Buttom_Click);
            this.Color_Back_ToolStripMenuItem.Click+= new EventHandler(Color_Backgraund_Buttom_Click);
            this.Col_Back_ToolStripMenuItem.Click+= new EventHandler(Color_Backgraund_Buttom_Click);
            this.Color_fon_ToolStripMenuItem.Click+= new EventHandler(Color_Font_Buttom_Click);
            this.Col_FonToolStripMenuItem.Click+= new EventHandler(Color_Font_Buttom_Click);
            this.Fon_ToolStripMenuItem.Click+= new EventHandler(Fonts_Buttom_Click);
            this.Fonts_ToolStripMenuItem.Click+= new EventHandler(Fonts_Buttom_Click);
        }

        private void Fonts_Buttom_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1_File.Font = this.fontDialog1.Font;
            }
        }
        private void Color_Font_Buttom_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1_File.ForeColor = this.colorDialog1.Color;
            }
        }
        private void Color_Backgraund_Buttom_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox1_File.BackColor = this.colorDialog1.Color;
            }
        }

        private void Undo_Buttom_Click(object sender, EventArgs e)
        {
            if (this.textBox1_File.CanUndo == true)
            {
                this.textBox1_File.Undo();
                this.textBox1_File.ClearUndo();
            }
        }
        private void Highlight_Buttom_Click(object sender, EventArgs e)
        {
            if (this.textBox1_File.Text != "")
            {
                this.textBox1_File.SelectAll();
            }
            else
            {
                MessageBox.Show("Нет текста!", "Оповищение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Paste_Button_Click(object sender, EventArgs e)
        {
            this.textBox1_File.Paste();
        }
        private void Cut_Button_Click(object sender, EventArgs e)
        {
            if (this.textBox1_File.SelectedText != "")
            {
                this.textBox1_File.Cut();
            }
        }
        private void Cope_Button_Click(object sender, EventArgs e)
        {
            if (this.textBox1_File.SelectedText != "")
            {
                this.textBox1_File.Copy();
            }
        }
        private void New_Doc_Button_Click(object sender, EventArgs e)
        {
            openFile=new OpenFileDialog();
            saveFile=new SaveFileDialog();
            saveFile.Filter = "TXT file (*.txt)|*.txt|DOC file (*.doc)|*.doc";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(saveFile.FileName))
                {
                    FileStream file=File.Create(saveFile.FileName);
                    file.Close();
                    openFile.FileName = saveFile.FileName;
                    this.textBox1_File.ReadOnly = false;
                    this.label1_Put.Text = openFile.FileName;
                }
                else
                {
                    MessageBox.Show("Фаил с таким именем уже существует!", "Оповишение", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    openFile = null;
                    saveFile = null;
                }
            }
        }
        private void SaveAS_Button_Click(object sender, EventArgs e)
        {
            saveFile=new SaveFileDialog();
            saveFile.Filter = "TXT file(*.txt)|*.txt|DOC file(*.doc)|*.doc";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer=new StreamWriter(saveFile.FileName);
                writer.Write(this.textBox1_File.Text);
                writer.Close();
            }
            else
            {
                saveFile = null;
            }
        }
        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (openFile != null)
            {
                StreamWriter writer=new StreamWriter(openFile.FileName);
                writer.Write(this.textBox1_File.Text);
                writer.Close();
            }
        }
        private void Open_Button_Clic(object sender, EventArgs e)
        {
           openFile=new OpenFileDialog();
            openFile.Filter = "TXT file (*.txt)|*.txt|DOC file (*.doc,*.docx)|*.doc;*.docx";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader file=new StreamReader(openFile.FileName,Encoding.UTF8);
                this.textBox1_File.Clear();
                this.textBox1_File.Text = file.ReadToEnd();
                this.textBox1_File.ReadOnly = false;
                this.label1_Put.Text = openFile.FileName;
                file.Close();
            }
            else
            {
                openFile = null;
            }
        }

        private void BunifuImageButton2_instrument_Click(object sender, EventArgs e)
        {
            if (flagInstrument)
            {
                flagInstrument = false;
                Bitmap My_image = new Bitmap(String.Format(@"..\..\images\{0}_{1}.png", 3,1));
                this.bunifuImageButton2_instrument.Image = My_image;
                this.bunifuImageButton2_instrument.BackColor = Color.Plum;
                this.bunifuTransition1.ShowSync(this.toolStrip1);
            }
            else
            {
                flagInstrument = true;
                Bitmap My_image = new Bitmap(String.Format(@"..\..\images\{0}.png", 3));
                this.bunifuImageButton2_instrument.Image = My_image;
                this.bunifuImageButton2_instrument.BackColor = Color.Purple;
                this.bunifuTransition1.HideSync(this.toolStrip1);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
