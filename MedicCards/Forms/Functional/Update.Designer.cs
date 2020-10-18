namespace MedicCards
{
    partial class Update
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
            this.up = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.arrive = new System.Windows.Forms.DateTimePicker();
            this.notes = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.handover = new System.Windows.Forms.DateTimePicker();
            this.birth = new System.Windows.Forms.DateTimePicker();
            this.ar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(351, 359);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 31;
            this.up.Text = "Обновить";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(455, 359);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 30;
            this.back.Text = "Отмена";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // arrive
            // 
            this.arrive.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrive.Location = new System.Drawing.Point(371, 230);
            this.arrive.Name = "arrive";
            this.arrive.Size = new System.Drawing.Size(150, 20);
            this.arrive.TabIndex = 29;
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(57, 272);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(510, 20);
            this.notes.TabIndex = 28;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(380, 98);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 20);
            this.name.TabIndex = 27;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(257, 59);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(150, 20);
            this.number.TabIndex = 26;
            // 
            // handover
            // 
            this.handover.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.handover.Location = new System.Drawing.Point(200, 230);
            this.handover.Name = "handover";
            this.handover.Size = new System.Drawing.Size(150, 20);
            this.handover.TabIndex = 25;
            // 
            // birth
            // 
            this.birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birth.Location = new System.Drawing.Point(27, 246);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(150, 20);
            this.birth.TabIndex = 24;
            // 
            // ar
            // 
            this.ar.FormattingEnabled = true;
            this.ar.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.ar.Location = new System.Drawing.Point(9, 112);
            this.ar.Name = "ar";
            this.ar.Size = new System.Drawing.Size(150, 21);
            this.ar.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Особые пометки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Дата поступления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Период сдачи";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Номер карты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Архив";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.up);
            this.Controls.Add(this.back);
            this.Controls.Add(this.arrive);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.name);
            this.Controls.Add(this.number);
            this.Controls.Add(this.handover);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.ar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ClientSizeChanged += new System.EventHandler(this.Update_ClientSizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DateTimePicker arrive;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.DateTimePicker handover;
        private System.Windows.Forms.DateTimePicker birth;
        private System.Windows.Forms.ComboBox ar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}