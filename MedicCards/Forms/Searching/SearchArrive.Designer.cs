﻿namespace MedicCards
{
    partial class SearchArrive
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
            this.date = new System.Windows.Forms.DateTimePicker();
            this.search = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.changing = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.archiev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(330, 57);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(138, 20);
            this.date.TabIndex = 25;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(642, 64);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 24;
            this.search.Text = "Найти";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(27, 387);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(81, 13);
            this.count.TabIndex = 23;
            this.count.Text = "Количество: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Введите дату поступления";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(670, 387);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 21;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.changing,
            this.archiev,
            this.number,
            this.name,
            this.birth,
            this.handOver,
            this.arriving,
            this.notes});
            this.dataGridView1.Location = new System.Drawing.Point(30, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 273);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDown);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // changing
            // 
            this.changing.HeaderText = "Изменить";
            this.changing.Name = "changing";
            this.changing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.changing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // archiev
            // 
            this.archiev.HeaderText = "Архив";
            this.archiev.Name = "archiev";
            // 
            // number
            // 
            this.number.HeaderText = "Номер карты";
            this.number.Name = "number";
            // 
            // name
            // 
            this.name.HeaderText = "ФИО";
            this.name.Name = "name";
            // 
            // birth
            // 
            this.birth.HeaderText = "Дата рождения";
            this.birth.Name = "birth";
            // 
            // handOver
            // 
            this.handOver.HeaderText = "Дата регистрации";
            this.handOver.Name = "handOver";
            // 
            // arriving
            // 
            this.arriving.HeaderText = "Дата поступления";
            this.arriving.Name = "arriving";
            // 
            // notes
            // 
            this.notes.HeaderText = "Особые пометки";
            this.notes.Name = "notes";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 48);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // SearchArrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.date);
            this.Controls.Add(this.search);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchArrive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск по дате поступления";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchArrive_FormClosed);
            this.Load += new System.EventHandler(this.SearchArrive_Load);
            this.ClientSizeChanged += new System.EventHandler(this.SearchArrive_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn changing;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiev;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn handOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriving;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}