namespace HRDepartment
{
    partial class fmMain
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TLDepartmentList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.SBAddDepartnent = new DevExpress.XtraEditors.SimpleButton();
            this.SBEditDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.SBDeleteDepartment = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.GCEmployeeList = new DevExpress.XtraGrid.GridControl();
            this.GVEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.SBAddEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.SBEditEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.SBDeleteEmployee = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TLDepartmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GCEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.Controls.Add(this.TLDepartmentList);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(346, 636);
            this.panelControl1.TabIndex = 13;
            // 
            // TLDepartmentList
            // 
            this.TLDepartmentList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.TLDepartmentList.DataSource = null;
            this.TLDepartmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLDepartmentList.KeyFieldName = "Id";
            this.TLDepartmentList.Location = new System.Drawing.Point(2, 2);
            this.TLDepartmentList.Name = "TLDepartmentList";
            this.TLDepartmentList.OptionsBehavior.Editable = false;
            this.TLDepartmentList.OptionsBehavior.ReadOnly = true;
            this.TLDepartmentList.ParentFieldName = "ParentId";
            this.TLDepartmentList.Size = new System.Drawing.Size(342, 632);
            this.TLDepartmentList.TabIndex = 0;
            this.TLDepartmentList.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.DepartmentTrL_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Подразделение";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // SBAddDepartnent
            // 
            this.SBAddDepartnent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SBAddDepartnent.Location = new System.Drawing.Point(15, 655);
            this.SBAddDepartnent.Name = "SBAddDepartnent";
            this.SBAddDepartnent.Size = new System.Drawing.Size(84, 23);
            this.SBAddDepartnent.TabIndex = 14;
            this.SBAddDepartnent.Text = "Добавить...";
            this.SBAddDepartnent.Click += new System.EventHandler(this.SBAddDepartnent_Click);
            // 
            // SBEditDepartment
            // 
            this.SBEditDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SBEditDepartment.Location = new System.Drawing.Point(105, 655);
            this.SBEditDepartment.Name = "SBEditDepartment";
            this.SBEditDepartment.Size = new System.Drawing.Size(80, 23);
            this.SBEditDepartment.TabIndex = 15;
            this.SBEditDepartment.Text = "Изменить...";
            this.SBEditDepartment.Click += new System.EventHandler(this.SBEditDepartment_Click);
            // 
            // SBDeleteDepartment
            // 
            this.SBDeleteDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SBDeleteDepartment.Location = new System.Drawing.Point(191, 655);
            this.SBDeleteDepartment.Name = "SBDeleteDepartment";
            this.SBDeleteDepartment.Size = new System.Drawing.Size(75, 23);
            this.SBDeleteDepartment.TabIndex = 16;
            this.SBDeleteDepartment.Text = "Удалить";
            this.SBDeleteDepartment.Click += new System.EventHandler(this.SBDeleteDepartment_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.GCEmployeeList);
            this.panelControl2.Location = new System.Drawing.Point(364, 13);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(765, 636);
            this.panelControl2.TabIndex = 17;
            // 
            // GCEmployeeList
            // 
            this.GCEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GCEmployeeList.Location = new System.Drawing.Point(2, 2);
            this.GCEmployeeList.MainView = this.GVEmployee;
            this.GCEmployeeList.Name = "GCEmployeeList";
            this.GCEmployeeList.Size = new System.Drawing.Size(761, 632);
            this.GCEmployeeList.TabIndex = 12;
            this.GCEmployeeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GVEmployee});
            // 
            // GVEmployee
            // 
            this.GVEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.GVEmployee.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.GVEmployee.GridControl = this.GCEmployeeList;
            this.GVEmployee.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.GVEmployee.Name = "GVEmployee";
            this.GVEmployee.OptionsBehavior.Editable = false;
            this.GVEmployee.OptionsBehavior.ReadOnly = true;
            this.GVEmployee.OptionsView.ShowGroupPanel = false;
            this.GVEmployee.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
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
            // SBAddEmployee
            // 
            this.SBAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SBAddEmployee.Location = new System.Drawing.Point(366, 655);
            this.SBAddEmployee.Name = "SBAddEmployee";
            this.SBAddEmployee.Size = new System.Drawing.Size(83, 23);
            this.SBAddEmployee.TabIndex = 18;
            this.SBAddEmployee.Text = "Добавить...";
            this.SBAddEmployee.Click += new System.EventHandler(this.SBAddEmployee_Click);
            // 
            // SBEditEmployee
            // 
            this.SBEditEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SBEditEmployee.Location = new System.Drawing.Point(455, 655);
            this.SBEditEmployee.Name = "SBEditEmployee";
            this.SBEditEmployee.Size = new System.Drawing.Size(83, 23);
            this.SBEditEmployee.TabIndex = 19;
            this.SBEditEmployee.Text = "Изменить...";
            this.SBEditEmployee.Click += new System.EventHandler(this.SBEditEmployee_Click);
            // 
            // SBDeleteEmployee
            // 
            this.SBDeleteEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SBDeleteEmployee.Location = new System.Drawing.Point(544, 655);
            this.SBDeleteEmployee.Name = "SBDeleteEmployee";
            this.SBDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.SBDeleteEmployee.TabIndex = 20;
            this.SBDeleteEmployee.Text = "Удалить";
            this.SBDeleteEmployee.Click += new System.EventHandler(this.SBDeleteEmployee_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 690);
            this.Controls.Add(this.SBDeleteEmployee);
            this.Controls.Add(this.SBEditEmployee);
            this.Controls.Add(this.SBAddEmployee);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.SBDeleteDepartment);
            this.Controls.Add(this.SBEditDepartment);
            this.Controls.Add(this.SBAddDepartnent);
            this.Controls.Add(this.panelControl1);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TLDepartmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GCEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList TLDepartmentList;
        private DevExpress.XtraEditors.SimpleButton SBAddDepartnent;
        private DevExpress.XtraEditors.SimpleButton SBEditDepartment;
        private DevExpress.XtraEditors.SimpleButton SBDeleteDepartment;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl GCEmployeeList;
        private DevExpress.XtraGrid.Views.Grid.GridView GVEmployee;
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
        private DevExpress.XtraEditors.SimpleButton SBAddEmployee;
        private DevExpress.XtraEditors.SimpleButton SBEditEmployee;
        private DevExpress.XtraEditors.SimpleButton SBDeleteEmployee;
    }
}