namespace HRDepartment
{
    partial class fmEditDepartment
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.IsActiveDepartmentChb = new System.Windows.Forms.CheckBox();
            this.NameTxb = new System.Windows.Forms.TextBox();
            this.DepartmentCbBx = new System.Windows.Forms.ComboBox();
            this.CodeTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(277, 135);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "ОК";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(196, 135);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // IsActiveDepartmentChb
            // 
            this.IsActiveDepartmentChb.AutoSize = true;
            this.IsActiveDepartmentChb.Location = new System.Drawing.Point(18, 98);
            this.IsActiveDepartmentChb.Name = "IsActiveDepartmentChb";
            this.IsActiveDepartmentChb.Size = new System.Drawing.Size(229, 21);
            this.IsActiveDepartmentChb.TabIndex = 2;
            this.IsActiveDepartmentChb.Text = "Действующее подразделение";
            this.IsActiveDepartmentChb.UseVisualStyleBackColor = true;
            // 
            // NameTxb
            // 
            this.NameTxb.Location = new System.Drawing.Point(143, 12);
            this.NameTxb.Name = "NameTxb";
            this.NameTxb.Size = new System.Drawing.Size(209, 22);
            this.NameTxb.TabIndex = 3;
            // 
            // DepartmentCbBx
            // 
            this.DepartmentCbBx.FormattingEnabled = true;
            this.DepartmentCbBx.Location = new System.Drawing.Point(143, 68);
            this.DepartmentCbBx.Name = "DepartmentCbBx";
            this.DepartmentCbBx.Size = new System.Drawing.Size(209, 24);
            this.DepartmentCbBx.TabIndex = 4;
            // 
            // CodeTxb
            // 
            this.CodeTxb.Location = new System.Drawing.Point(143, 40);
            this.CodeTxb.Name = "CodeTxb";
            this.CodeTxb.Size = new System.Drawing.Size(209, 22);
            this.CodeTxb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Код:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Принадлежность:";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 170);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CodeTxb);
            this.Controls.Add(this.DepartmentCbBx);
            this.Controls.Add(this.NameTxb);
            this.Controls.Add(this.IsActiveDepartmentChb);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveBtn);
            this.Name = "DepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подразделения";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.CheckBox IsActiveDepartmentChb;
        private System.Windows.Forms.TextBox NameTxb;
        private System.Windows.Forms.ComboBox DepartmentCbBx;
        private System.Windows.Forms.TextBox CodeTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}