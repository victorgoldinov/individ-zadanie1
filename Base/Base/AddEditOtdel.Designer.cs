namespace Base
{
    partial class AddEditOtdel
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
            this.otdel_txbx = new System.Windows.Forms.TextBox();
            this.addEditBtn = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otdel_txbx
            // 
            this.otdel_txbx.Location = new System.Drawing.Point(12, 53);
            this.otdel_txbx.Name = "otdel_txbx";
            this.otdel_txbx.Size = new System.Drawing.Size(196, 20);
            this.otdel_txbx.TabIndex = 0;
            // 
            // addEditBtn
            // 
            this.addEditBtn.Location = new System.Drawing.Point(114, 88);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(94, 23);
            this.addEditBtn.TabIndex = 1;
            this.addEditBtn.Text = "Добавить отдел";
            this.addEditBtn.UseVisualStyleBackColor = true;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 37);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(113, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Введите имя отдела:";
            // 
            // AddEditOtdel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 141);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.addEditBtn);
            this.Controls.Add(this.otdel_txbx);
            this.Name = "AddEditOtdel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить отдел";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddEditOtdel_FormClosing);
            this.Load += new System.EventHandler(this.AddEditOtdel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox otdel_txbx;
        public System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.Label lbl_name;
    }
}