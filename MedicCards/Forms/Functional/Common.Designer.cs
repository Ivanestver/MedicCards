namespace MedicCards
{
    partial class Common
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
            this.every = new System.Windows.Forms.Button();
            this.searchNumbers = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.Button();
            this.birth = new System.Windows.Forms.Button();
            this.arrive = new System.Windows.Forms.Button();
            this.handover = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // every
            // 
            this.every.Location = new System.Drawing.Point(58, 63);
            this.every.Name = "every";
            this.every.Size = new System.Drawing.Size(128, 46);
            this.every.TabIndex = 0;
            this.every.Text = "Все карты";
            this.every.UseVisualStyleBackColor = true;
            this.every.Click += new System.EventHandler(this.every_Click);
            // 
            // searchNumbers
            // 
            this.searchNumbers.Location = new System.Drawing.Point(262, 63);
            this.searchNumbers.Name = "searchNumbers";
            this.searchNumbers.Size = new System.Drawing.Size(128, 46);
            this.searchNumbers.TabIndex = 1;
            this.searchNumbers.Text = "Поиск по номеру карты";
            this.searchNumbers.UseVisualStyleBackColor = true;
            this.searchNumbers.Click += new System.EventHandler(this.searchNumbers_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(159, 356);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(128, 46);
            this.exit.TabIndex = 2;
            this.exit.Text = "Выйти";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(58, 136);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(128, 46);
            this.searchName.TabIndex = 3;
            this.searchName.Text = "Поиск по ФИО";
            this.searchName.UseVisualStyleBackColor = true;
            this.searchName.Click += new System.EventHandler(this.searchName_Click);
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(262, 136);
            this.birth.Name = "birth";
            this.birth.Size = new System.Drawing.Size(128, 46);
            this.birth.TabIndex = 4;
            this.birth.Text = "Поиск по дата рождения";
            this.birth.UseVisualStyleBackColor = true;
            this.birth.Click += new System.EventHandler(this.birth_Click);
            // 
            // arrive
            // 
            this.arrive.Location = new System.Drawing.Point(262, 207);
            this.arrive.Name = "arrive";
            this.arrive.Size = new System.Drawing.Size(128, 46);
            this.arrive.TabIndex = 5;
            this.arrive.Text = "Поиск по дате поступления";
            this.arrive.UseVisualStyleBackColor = true;
            this.arrive.Click += new System.EventHandler(this.arrive_Click);
            // 
            // handover
            // 
            this.handover.Location = new System.Drawing.Point(58, 207);
            this.handover.Name = "handover";
            this.handover.Size = new System.Drawing.Size(128, 46);
            this.handover.TabIndex = 6;
            this.handover.Text = "Поиск по дате регистрации";
            this.handover.UseVisualStyleBackColor = true;
            this.handover.Click += new System.EventHandler(this.handover_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Поиск по наличию в архиве";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Common
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.handover);
            this.Controls.Add(this.arrive);
            this.Controls.Add(this.birth);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchNumbers);
            this.Controls.Add(this.every);
            this.Name = "Common";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Common_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button every;
        private System.Windows.Forms.Button searchNumbers;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button searchName;
        private System.Windows.Forms.Button birth;
        private System.Windows.Forms.Button arrive;
        private System.Windows.Forms.Button handover;
        private System.Windows.Forms.Button button1;
    }
}