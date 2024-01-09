using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace File_Explorer_Tree
{
    public partial class Form1 : Form
    {
        public string begin_str {  get; set; }
        public string end_str { get; set; }
        public Form1()
        {
            InitializeComponent();
            AddTree();
        }
        private void AddTree()
        {
            try
            {
                int ind = 0;
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    treeView.Nodes.Add(drive.Name);
                    string[] dirs = Directory.GetDirectories(drive.Name);
                    foreach (string s in dirs)
                    {
                        treeView.Nodes[ind].Nodes.Add(s);
                    }
                    ind++;
                }
            }
            catch(Exception ex) { }        
        }
        private void AddDirectoris(string str)
        {
            try
            {
                string[] dirs = Directory.GetDirectories(str);
                string[] df = Directory.GetFiles(str);
                int ind = 0;
                foreach (string s in dirs)
                {
                    listView.Items.Add(s).SubItems.Add(Convert.ToString(Directory.GetLastWriteTime(s)));
                    listView.Items[ind].SubItems.Add("Папка с файлами");
                    ind++;
                }
                foreach (string s in df)
                {
                    listView.Items.Add(s).SubItems.Add(Convert.ToString(Directory.GetLastWriteTime(s)));
                    listView.Items[ind].SubItems.Add("Файл");
                    ind++;
                }
            }
            catch
            {
                Exception exception = new Exception();//вылетает при обращении к определенным папкам
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (listView.Items.Count > 0) { listView.Items.Clear(); }
            DirectoryText.Text = treeView.SelectedNode.Text;
            string str = treeView.SelectedNode.Text;
            AddDirectoris(str);
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            string str = (sender as System.Windows.Forms.ListView).SelectedItems[0].Text;
            DirectoryText.Text = str;
            if (listView.Items.Count > 0) { listView.Items.Clear(); }
            AddDirectoris(str);
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.Items.Count > 0) { listView.Items.Clear(); }
                string str = Directory.GetDirectoryRoot(DirectoryText.Text);//сразу в корневой каталог
                DirectoryText.Text = str;
                AddDirectoris(str);
            }
           catch(Exception ex) { }
        }

        private void Forward_Click(object sender, EventArgs e)//пока не знаю как
        {
            try
            {
                if (listView.Items.Count > 0) { listView.Items.Clear(); }
                AddDirectoris(DirectoryText.Text);
            }
            catch (Exception ex) { }
        }

        private void listView_MouseClick(object sender, MouseEventArgs e)//вызов контекстного меню по правой кнопке
        {
            //string str = (sender as System.Windows.Forms.ListView).SelectedItems[0].Text;
            if ( e.Button==MouseButtons.Right)
            {
                panel1.Location = new Point(e.X, e.Y+15);
                panel1.Visible=true;
                menuStrip.Visible = true;
                DirectoryText.Text = (sender as System.Windows.Forms.ListView).SelectedItems[0].Text;
            }
            else
            {
                panel1.Visible = false;
                menuStrip.Visible = false;
                DirectoryText.Text = (sender as System.Windows.Forms.ListView).SelectedItems[0].Text;
            }
        }
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)//копировать папку и ее содержимое
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            // Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in source.GetFiles())
            {
               // Console.WriteLine(@"Copying {0}\{1}", target.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                    target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        private void CopyFile_Click(object sender, EventArgs e)//запоминает исходный адрес объекта
        {
            begin_str = DirectoryText.Text;
            panel1.Visible = false;
            menuStrip.Visible = false;
        }

        private void InsertFile_Click(object sender, EventArgs e)//НАДО БЫТЬ ВНИМАТЕЛЬНЫМ!!!!!!
        {
            try
            {
                if (begin_str != null) { end_str = DirectoryText.Text; }//при нажатии правой кнопки запоминает адрес куда копируем
                DirectoryInfo dir = new DirectoryInfo(begin_str);
                if (dir.Exists == true)
                {
                    end_str += @"\" + dir.Name + "-Копия" + @"\";
                }
                else
                {
                    end_str += @"\" + dir.Name + @"\";
                }

                DirectoryInfo diSource = new DirectoryInfo(begin_str);
                DirectoryInfo diTarget = new DirectoryInfo(end_str);

                CopyAll(diSource, diTarget);
            }
            catch (Exception) { }
            panel1.Visible = false;
            menuStrip.Visible = false;
            begin_str = null;
            end_str= null;
        }

        private void DeleteFile_Click(object sender, EventArgs e)//удаление папки и ее содержимого
        {
            DialogResult dialog = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \n"+DirectoryText.Text,
                "СООБЩЕНИЕ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if( dialog == DialogResult.Yes )
            {
                try
                {
                    //Action<string> DelPath = null;
                    //DelPath = p =>
                    //{
                    //    Directory.EnumerateFiles(p).ToList().ForEach(File.Delete);
                    //    Directory.EnumerateDirectories(p).ToList().ForEach(DelPath);
                    //    Directory.EnumerateDirectories(p).ToList().ForEach(Directory.Delete);
                    //};
                    //DelPath(DirectoryText.Text);//рекурсия
                    Directory.Delete(DirectoryText.Text);
                }
                catch (Exception)
                {
                    DialogResult obj = MessageBox.Show("Объект не пуст!");
                }
            }
                panel1.Visible = false;
                menuStrip.Visible = false;
        }

    }
}
