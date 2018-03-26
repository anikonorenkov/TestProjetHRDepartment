namespace HRDepartment
{
    partial class MainForm
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
            this.DepartmentTreeView = new System.Windows.Forms.TreeView();
            this.DeleteDepartmentBtn = new System.Windows.Forms.Button();
            this.EditDepartmentBtn = new System.Windows.Forms.Button();
            this.AddDepartmentBtn = new System.Windows.Forms.Button();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.EditEmployeeBtn = new System.Windows.Forms.Button();
            this.DeleteEmployeeBtn = new System.Windows.Forms.Button();
            this.GridControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartmentTreeView
            // 
            this.DepartmentTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DepartmentTreeView.Location = new System.Drawing.Point(13, 13);
            this.DepartmentTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.DepartmentTreeView.Name = "DepartmentTreeView";
            this.DepartmentTreeView.Size = new System.Drawing.Size(298, 575);
            this.DepartmentTreeView.TabIndex = 1;
            this.DepartmentTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DepartmentTreeView_AfterSelect);
            // 
            // DeleteDepartmentBtn
            // 
            this.DeleteDepartmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteDepartmentBtn.Location = new System.Drawing.Point(217, 602);
            this.DeleteDepartmentBtn.Name = "DeleteDepartmentBtn";
            this.DeleteDepartmentBtn.Size = new System.Drawing.Size(85, 23);
            this.DeleteDepartmentBtn.TabIndex = 2;
            this.DeleteDepartmentBtn.Text = "Удалить";
            this.DeleteDepartmentBtn.UseVisualStyleBackColor = true;
            // 
            // EditDepartmentBtn
            // 
            this.EditDepartmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditDepartmentBtn.Location = new System.Drawing.Point(116, 602);
            this.EditDepartmentBtn.Name = "EditDepartmentBtn";
            this.EditDepartmentBtn.Size = new System.Drawing.Size(95, 23);
            this.EditDepartmentBtn.TabIndex = 3;
            this.EditDepartmentBtn.Text = "Изменить...";
            this.EditDepartmentBtn.UseVisualStyleBackColor = true;
            // 
            // AddDepartmentBtn
            // 
            this.AddDepartmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddDepartmentBtn.Location = new System.Drawing.Point(14, 602);
            this.AddDepartmentBtn.Name = "AddDepartmentBtn";
            this.AddDepartmentBtn.Size = new System.Drawing.Size(96, 23);
            this.AddDepartmentBtn.TabIndex = 4;
            this.AddDepartmentBtn.Text = "Добавить...";
            this.AddDepartmentBtn.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddEmployeeBtn.Location = new System.Drawing.Point(317, 602);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(93, 23);
            this.AddEmployeeBtn.TabIndex = 8;
            this.AddEmployeeBtn.Text = "Добавить...";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditEmployeeBtn.Location = new System.Drawing.Point(416, 602);
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(95, 23);
            this.EditEmployeeBtn.TabIndex = 7;
            this.EditEmployeeBtn.Text = "Изменить...";
            this.EditEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployeeBtn
            // 
            this.DeleteEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteEmployeeBtn.Location = new System.Drawing.Point(517, 602);
            this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            this.DeleteEmployeeBtn.Size = new System.Drawing.Size(84, 23);
            this.DeleteEmployeeBtn.TabIndex = 6;
            this.DeleteEmployeeBtn.Text = "Удалить";
            this.DeleteEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // GridControlEmployee
            // 
            this.GridControlEmployee.Location = new System.Drawing.Point(319, 12);
            this.GridControlEmployee.MainView = this.gridView1;
            this.GridControlEmployee.Name = "GridControlEmployee";
            this.GridControlEmployee.Size = new System.Drawing.Size(831, 576);
            this.GridControlEmployee.TabIndex = 11;
            this.GridControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.IdColumn});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.GridControlEmployee;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Фамилия";
            this.gridColumn1.FieldName = "LastName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Имя";
            this.gridColumn2.FieldName = "FirstName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Отчество";
            this.gridColumn3.FieldName = "MiddleName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Дата рождения";
            this.gridColumn4.FieldName = "DtBirth";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Таб.Номер";
            this.gridColumn5.FieldName = "TabNumber";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Дата приема";
            this.gridColumn6.FieldName = "DtHire";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Пол";
            this.gridColumn7.FieldName = "Gender";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Должность";
            this.gridColumn8.FieldName = "Position";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Информация";
            this.gridColumn9.FieldName = "Information";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // IdColumn
            // 
            this.IdColumn.Caption = "gridColumn10";
            this.IdColumn.CustomizationCaption = "Id";
            this.IdColumn.FieldName = "Id";
            this.IdColumn.Name = "IdColumn";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(797, 602);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 637);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.GridControlEmployee);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.EditEmployeeBtn);
            this.Controls.Add(this.DeleteEmployeeBtn);
            this.Controls.Add(this.AddDepartmentBtn);
            this.Controls.Add(this.EditDepartmentBtn);
            this.Controls.Add(this.DeleteDepartmentBtn);
            this.Controls.Add(this.DepartmentTreeView);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.GridControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView DepartmentTreeView;
        private System.Windows.Forms.Button DeleteDepartmentBtn;
        private System.Windows.Forms.Button EditDepartmentBtn;
        private System.Windows.Forms.Button AddDepartmentBtn;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Button EditEmployeeBtn;
        private System.Windows.Forms.Button DeleteEmployeeBtn;
        private DevExpress.XtraGrid.GridControl GridControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn IdColumn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}