namespace File_Explorer_Tree
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Backward = new System.Windows.Forms.Button();
            this.Forward = new System.Windows.Forms.Button();
            this.DirectoryText = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.CopyFile = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertFile = new System.Windows.Forms.ToolStripMenuItem();
            this.listView = new System.Windows.Forms.ListView();
            this.NameFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TypeFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Backward
            // 
            this.Backward.Location = new System.Drawing.Point(4, 3);
            this.Backward.Name = "Backward";
            this.Backward.Size = new System.Drawing.Size(64, 27);
            this.Backward.TabIndex = 0;
            this.Backward.Text = "<<";
            this.Backward.UseVisualStyleBackColor = true;
            this.Backward.Click += new System.EventHandler(this.Backward_Click);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(74, 3);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(64, 27);
            this.Forward.TabIndex = 1;
            this.Forward.Text = ">>";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.Forward_Click);
            // 
            // DirectoryText
            // 
            this.DirectoryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectoryText.Location = new System.Drawing.Point(190, 5);
            this.DirectoryText.Name = "DirectoryText";
            this.DirectoryText.Size = new System.Drawing.Size(505, 22);
            this.DirectoryText.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 37);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.listView);
            this.splitContainer1.Size = new System.Drawing.Size(691, 401);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.TabIndex = 5;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(187, 401);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Location = new System.Drawing.Point(140, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 101);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyFile,
            this.DeleteFile,
            this.InsertFile});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip.Location = new System.Drawing.Point(0, 1);
            this.menuStrip.MinimumSize = new System.Drawing.Size(150, 100);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.ShowItemToolTips = true;
            this.menuStrip.Size = new System.Drawing.Size(232, 100);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Visible = false;
            // 
            // CopyFile
            // 
            this.CopyFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CopyFile.Image = global::File_Explorer_Tree.Properties.Resources._03;
            this.CopyFile.Name = "CopyFile";
            this.CopyFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyFile.Size = new System.Drawing.Size(182, 25);
            this.CopyFile.Text = "Копировать    ctrl+C";
            this.CopyFile.Click += new System.EventHandler(this.CopyFile_Click);
            // 
            // DeleteFile
            // 
            this.DeleteFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteFile.Image = global::File_Explorer_Tree.Properties.Resources._04;
            this.DeleteFile.Name = "DeleteFile";
            this.DeleteFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.DeleteFile.Size = new System.Drawing.Size(217, 25);
            this.DeleteFile.Text = "Удалить           ctrl+Delete";
            this.DeleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // InsertFile
            // 
            this.InsertFile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertFile.Image = global::File_Explorer_Tree.Properties.Resources._02;
            this.InsertFile.Name = "InsertFile";
            this.InsertFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.InsertFile.Size = new System.Drawing.Size(184, 25);
            this.InsertFile.Text = "Вставить          ctrl+V";
            this.InsertFile.Click += new System.EventHandler(this.InsertFile_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFile,
            this.LastChange,
            this.TypeFile});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(500, 401);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;

            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // NameFile
            // 
            this.NameFile.Text = "Имя";
            this.NameFile.Width = 219;
            // 
            // LastChange
            // 
            this.LastChange.Text = "Дата изменения";
            this.LastChange.Width = 145;
            // 
            // TypeFile
            // 
            this.TypeFile.Text = "Тип";
            this.TypeFile.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::File_Explorer_Tree.Properties.Resources._01;
            this.label1.Location = new System.Drawing.Point(144, 3);
            this.label1.MinimumSize = new System.Drawing.Size(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 27);
            this.label1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.DirectoryText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.Backward);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backward;
        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DirectoryText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader NameFile;
        private System.Windows.Forms.ColumnHeader LastChange;
        private System.Windows.Forms.ColumnHeader TypeFile;
        private System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem CopyFile;
        public System.Windows.Forms.ToolStripMenuItem DeleteFile;
        public System.Windows.Forms.ToolStripMenuItem InsertFile;
        private System.Windows.Forms.Panel panel1;
    }
}

