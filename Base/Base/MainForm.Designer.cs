namespace Base
{
    partial class mainForm
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
            this.otdelView = new System.Windows.Forms.DataGridView();
            this.otdel_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otdel_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addOtdelBtn = new System.Windows.Forms.Button();
            this.groupsView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otdel_code_s = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsView = new System.Windows.Forms.DataGridView();
            this.group_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editOtdelBtn = new System.Windows.Forms.Button();
            this.delOtdelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.otdelView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsView)).BeginInit();
            this.SuspendLayout();
            // 
            // otdelView
            // 
            this.otdelView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otdelView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.otdel_code,
            this.otdel_name});
            this.otdelView.Location = new System.Drawing.Point(12, 12);
            this.otdelView.Name = "otdelView";
            this.otdelView.Size = new System.Drawing.Size(246, 426);
            this.otdelView.TabIndex = 0;
            this.otdelView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.otdelView_CellClick);
            // 
            // otdel_code
            // 
            this.otdel_code.HeaderText = "Код отдела";
            this.otdel_code.Name = "otdel_code";
            // 
            // otdel_name
            // 
            this.otdel_name.HeaderText = "Наименование отдела";
            this.otdel_name.Name = "otdel_name";
            this.otdel_name.ReadOnly = true;
            // 
            // addOtdelBtn
            // 
            this.addOtdelBtn.Location = new System.Drawing.Point(12, 444);
            this.addOtdelBtn.Name = "addOtdelBtn";
            this.addOtdelBtn.Size = new System.Drawing.Size(246, 23);
            this.addOtdelBtn.TabIndex = 1;
            this.addOtdelBtn.Text = "Добавить отдел";
            this.addOtdelBtn.UseVisualStyleBackColor = true;
            this.addOtdelBtn.Click += new System.EventHandler(this.AddOtdel);
            // 
            // groupsView
            // 
            this.groupsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.otdel_code_s});
            this.groupsView.Location = new System.Drawing.Point(264, 12);
            this.groupsView.Name = "groupsView";
            this.groupsView.Size = new System.Drawing.Size(362, 426);
            this.groupsView.TabIndex = 2;
            this.groupsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupsView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Код группы";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Группа";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // otdel_code_s
            // 
            this.otdel_code_s.HeaderText = "Код отдела";
            this.otdel_code_s.Name = "otdel_code_s";
            // 
            // studentsView
            // 
            this.studentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group_code,
            this.firstName,
            this.lastName,
            this.adress,
            this.tel});
            this.studentsView.Location = new System.Drawing.Point(632, 12);
            this.studentsView.Name = "studentsView";
            this.studentsView.Size = new System.Drawing.Size(543, 426);
            this.studentsView.TabIndex = 3;
            // 
            // group_code
            // 
            this.group_code.HeaderText = "Код группы";
            this.group_code.Name = "group_code";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Имя";
            this.firstName.Name = "firstName";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Фамилия";
            this.lastName.Name = "lastName";
            // 
            // adress
            // 
            this.adress.HeaderText = "Адрес";
            this.adress.Name = "adress";
            // 
            // tel
            // 
            this.tel.HeaderText = "Телефон";
            this.tel.Name = "tel";
            // 
            // editOtdelBtn
            // 
            this.editOtdelBtn.Location = new System.Drawing.Point(12, 473);
            this.editOtdelBtn.Name = "editOtdelBtn";
            this.editOtdelBtn.Size = new System.Drawing.Size(246, 23);
            this.editOtdelBtn.TabIndex = 4;
            this.editOtdelBtn.Text = "Редактировать отдел";
            this.editOtdelBtn.UseVisualStyleBackColor = true;
            this.editOtdelBtn.Click += new System.EventHandler(this.EditOtdel);
            // 
            // delOtdelBtn
            // 
            this.delOtdelBtn.Location = new System.Drawing.Point(12, 502);
            this.delOtdelBtn.Name = "delOtdelBtn";
            this.delOtdelBtn.Size = new System.Drawing.Size(246, 23);
            this.delOtdelBtn.TabIndex = 5;
            this.delOtdelBtn.Text = "Удалить отдел";
            this.delOtdelBtn.UseVisualStyleBackColor = true;
            this.delOtdelBtn.Click += new System.EventHandler(this.delOtdelBtn_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 554);
            this.Controls.Add(this.delOtdelBtn);
            this.Controls.Add(this.editOtdelBtn);
            this.Controls.Add(this.studentsView);
            this.Controls.Add(this.groupsView);
            this.Controls.Add(this.addOtdelBtn);
            this.Controls.Add(this.otdelView);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Shown += new System.EventHandler(this.mainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.otdelView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView otdelView;
        private System.Windows.Forms.DataGridViewTextBoxColumn otdel_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn otdel_name;
        private System.Windows.Forms.Button addOtdelBtn;
        public System.Windows.Forms.DataGridView groupsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn otdel_code_s;
        public System.Windows.Forms.DataGridView studentsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.Button editOtdelBtn;
        private System.Windows.Forms.Button delOtdelBtn;
    }
}

