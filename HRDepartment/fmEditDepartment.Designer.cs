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
            this.SBSave = new DevExpress.XtraEditors.SimpleButton();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.TEName = new DevExpress.XtraEditors.TextEdit();
            this.TECode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CEIsActiv = new DevExpress.XtraEditors.CheckEdit();
            this.LUEDepartment = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TEName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEIsActiv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEDepartment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SBSave
            // 
            this.SBSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SBSave.Location = new System.Drawing.Point(169, 132);
            this.SBSave.Name = "SBSave";
            this.SBSave.Size = new System.Drawing.Size(75, 23);
            this.SBSave.TabIndex = 0;
            this.SBSave.Text = "Сохранить";
            // 
            // SBCancel
            // 
            this.SBCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SBCancel.Location = new System.Drawing.Point(250, 132);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(75, 23);
            this.SBCancel.TabIndex = 1;
            this.SBCancel.Text = "Отменить";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // TEName
            // 
            this.TEName.Location = new System.Drawing.Point(123, 12);
            this.TEName.Name = "TEName";
            this.TEName.Size = new System.Drawing.Size(202, 22);
            this.TEName.TabIndex = 2;
            // 
            // TECode
            // 
            this.TECode.Location = new System.Drawing.Point(123, 40);
            this.TECode.Name = "TECode";
            this.TECode.Size = new System.Drawing.Size(202, 22);
            this.TECode.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Название:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Код:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 71);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(105, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Принадлежность:";
            // 
            // CEIsActiv
            // 
            this.CEIsActiv.Location = new System.Drawing.Point(120, 96);
            this.CEIsActiv.Name = "CEIsActiv";
            this.CEIsActiv.Properties.Caption = "Действующее подразделение";
            this.CEIsActiv.Size = new System.Drawing.Size(202, 20);
            this.CEIsActiv.TabIndex = 8;
            // 
            // LUEDepartment
            // 
            this.LUEDepartment.Location = new System.Drawing.Point(123, 68);
            this.LUEDepartment.Name = "LUEDepartment";
            this.LUEDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Подразделение"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LUEDepartment.Properties.DisplayMember = "Name";
            this.LUEDepartment.Properties.ValueMember = "Id";
            this.LUEDepartment.Size = new System.Drawing.Size(202, 22);
            this.LUEDepartment.TabIndex = 4;
            // 
            // fmEditDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 167);
            this.Controls.Add(this.CEIsActiv);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.LUEDepartment);
            this.Controls.Add(this.TECode);
            this.Controls.Add(this.TEName);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fmEditDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подразделение";
            this.Load += new System.EventHandler(this.FmEditDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TEName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TECode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CEIsActiv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEDepartment.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SBSave;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.TextEdit TEName;
        private DevExpress.XtraEditors.TextEdit TECode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit CEIsActiv;
        private DevExpress.XtraEditors.LookUpEdit LUEDepartment;
    }
}