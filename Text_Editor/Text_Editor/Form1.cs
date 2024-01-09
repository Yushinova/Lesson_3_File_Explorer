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

namespace WF_dz_3
{
	public partial class Form1 : Form
	{
        string currFilePath = null;
        string buffer = null;
		public Form1()
		{
			InitializeComponent();
            saveAsFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (currFilePath == null)
            {
                this.Text = "Новый документ";
            }
        }
		private void btn_exit_Click(object sender, EventArgs e)
		{
			Close();
		}
        void newFile()
        {
			DialogResult result = saveAsFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				string path = saveAsFileDialog.FileName + ".txt";
				StreamWriter sw = new StreamWriter(path);
				sw.Write(textBox_Main.Text);
				sw.Close();
				currFilePath = path;
				Text = path;
			}
		}
		private void btn_saveAs_Click(object sender, EventArgs e)
        {
            newFile();
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                string path = saveAsFileDialog.FileName + ".txt";
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                textBox_Main.Text = sr.ReadToEnd();
                this.Text = openFileDialog.FileName;
                currFilePath = openFileDialog.FileName;
                sr.Close();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (currFilePath != null)
            {
                StreamWriter sw = new StreamWriter(currFilePath);
                sw.Write(textBox_Main.Text);
                sw.Close();
            }
			else
			{
				newFile();
			}
        }

		private void btn_new_Click(object sender, EventArgs e)
		{
            newFile();
		}

		private void btn_Copy_Click(object sender, EventArgs e)
		{
            buffer = textBox_Main.SelectedText;
        }

		private void btn_Cut_Click(object sender, EventArgs e)
		{
			buffer = textBox_Main.SelectedText;
            textBox_Main.SelectedText = "";
            Console.WriteLine(buffer);
        }

		private void btn_Paste_Click(object sender, EventArgs e)
		{
            textBox_Main.SelectedText += buffer;
		}

		private void btn_undo_Click(object sender, EventArgs e)
		{
            textBox_Main.Undo();
		}

		private void поУмочаниюToolStripMenuItem_Click(object sender, EventArgs e)
		{
            textBox_Main.ForeColor = Color.Black;
		}

		private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.ForeColor = Color.Red;
		}

		private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.ForeColor = Color.Green;
		}

		private void синийToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.ForeColor = Color.Blue;
		}

		private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.ForeColor = Color.White;
		}

		private void поУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.BackColor = Color.White;
		}

		private void красныйToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			textBox_Main.BackColor = Color.Red;
		}

		private void зеленыйToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			textBox_Main.BackColor = Color.Green;
		}

		private void синийToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			textBox_Main.BackColor = Color.Blue;
		}

		private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.BackColor = Color.Black;
		}

		private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		}

		private void gOSTBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.Font = new System.Drawing.Font("GOST type B", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		}

		private void calibriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
		}

		private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			textBox_Main.SelectAll();
		}

     
    }
}
