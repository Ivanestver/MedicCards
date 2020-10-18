namespace MedicCards
{
    partial class SearchThereIs
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
            this.count = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.archiev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handOver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arriving = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.Location = new System.Drawing.Point(29, 317);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(81, 13);
            this.count.TabIndex = 26;
            this.count.Text = "Количество: 0";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(701, 353);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 25;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.archiev,
            this.number,
            this.name,
            this.birth,
            this.handOver,
            this.arriving,
            this.notes});
            this.dataGridView1.Location = new System.Drawing.Point(32, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 273);
            this.dataGridView1.TabIndex = 24;
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
            // SearchThereIs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.count);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchThereIs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск по наличию в архиве";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchThereIs_FormClosed);
            this.Load += new System.EventHandler(this.SearchThereIs_Load);
            this.ClientSizeChanged += new System.EventHandler(this.SearchThereIs_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn archiev;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn handOver;
        private System.Windows.Forms.DataGridViewTextBoxColumn arriving;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}