namespace TPP_LAB_3
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.источникДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.подключениеКБазеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отключениеОтБазыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.заменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.contextMenuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.источникДанныхToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(982, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// источникДанныхToolStripMenuItem
			// 
			this.источникДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБазеToolStripMenuItem,
            this.отключениеОтБазыToolStripMenuItem});
			this.источникДанныхToolStripMenuItem.Name = "источникДанныхToolStripMenuItem";
			this.источникДанныхToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
			this.источникДанныхToolStripMenuItem.Text = "Источник данных";
			// 
			// подключениеКБазеToolStripMenuItem
			// 
			this.подключениеКБазеToolStripMenuItem.Name = "подключениеКБазеToolStripMenuItem";
			this.подключениеКБазеToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
			this.подключениеКБазеToolStripMenuItem.Text = "Подключится";
			this.подключениеКБазеToolStripMenuItem.Click += new System.EventHandler(this.подключениеКБазеToolStripMenuItem_Click);
			// 
			// отключениеОтБазыToolStripMenuItem
			// 
			this.отключениеОтБазыToolStripMenuItem.Name = "отключениеОтБазыToolStripMenuItem";
			this.отключениеОтБазыToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
			this.отключениеОтБазыToolStripMenuItem.Text = "Отключится";
			this.отключениеОтБазыToolStripMenuItem.Click += new System.EventHandler(this.отключениеОтБазыToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 28);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(982, 225);
			this.splitContainer1.SplitterDistance = 443;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(443, 225);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Группы";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(4, 19);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(435, 202);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.заменитьToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(146, 76);
			// 
			// добавитьToolStripMenuItem
			// 
			this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
			this.добавитьToolStripMenuItem.Text = "Добавить";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// заменитьToolStripMenuItem
			// 
			this.заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
			this.заменитьToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
			this.заменитьToolStripMenuItem.Text = "Заменить";
			this.заменитьToolStripMenuItem.Click += new System.EventHandler(this.заменитьToolStripMenuItem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dataGridView2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(534, 225);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Студенты";
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.ContextMenuStrip = this.contextMenuStrip2;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(4, 19);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView2.MultiSelect = false;
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersVisible = false;
			this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView2.Size = new System.Drawing.Size(526, 202);
			this.dataGridView2.TabIndex = 1;
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
			this.contextMenuStrip2.Name = "contextMenuStrip1";
			this.contextMenuStrip2.Size = new System.Drawing.Size(148, 76);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 24);
			this.toolStripMenuItem1.Text = "Добавить";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 24);
			this.toolStripMenuItem2.Text = "Удалить";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 24);
			this.toolStripMenuItem3.Text = "Изменить";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 253);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Лаб. работа №3 (Погуляйло М.С.)";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.contextMenuStrip2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem источникДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБазеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключениеОтБазыToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заменитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

