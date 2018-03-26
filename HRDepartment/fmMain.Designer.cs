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
            this.DepartmentTrL = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.AddDepartnentBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EditDepartmentBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteDepartmentBtn = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.EmployeeGrCn = new DevExpress.XtraGrid.GridControl();
            this.EmployeeGrV = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.AddEmployeeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.EditEmployeeBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteEmployeeBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentTrL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrCn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelControl1.Controls.Add(this.DepartmentTrL);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(346, 636);
            this.panelControl1.TabIndex = 13;
            // 
            // DepartmentTrL
            // 
            this.DepartmentTrL.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.DepartmentTrL.DataSource = null;
            this.DepartmentTrL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DepartmentTrL.Location = new System.Drawing.Point(2, 2);
            this.DepartmentTrL.Name = "DepartmentTrL";
            this.DepartmentTrL.Size = new System.Drawing.Size(342, 632);
            this.DepartmentTrL.TabIndex = 0;
            this.DepartmentTrL.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.DepartmentTrL_FocusedNodeChanged);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Подразделение";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // AddDepartnentBtn
            // 
            this.AddDepartnentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddDepartnentBtn.Location = new System.Drawing.Point(15, 655);
            this.AddDepartnentBtn.Name = "AddDepartnentBtn";
            this.AddDepartnentBtn.Size = new System.Drawing.Size(75, 23);
            this.AddDepartnentBtn.TabIndex = 14;
            this.AddDepartnentBtn.Text = "Добавить...";
            // 
            // EditDepartmentBtn
            // 
            this.EditDepartmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditDepartmentBtn.Location = new System.Drawing.Point(97, 655);
            this.EditDepartmentBtn.Name = "EditDepartmentBtn";
            this.EditDepartmentBtn.Size = new System.Drawing.Size(75, 23);
            this.EditDepartmentBtn.TabIndex = 15;
            this.EditDepartmentBtn.Text = "Править...";
            // 
            // DeleteDepartmentBtn
            // 
            this.DeleteDepartmentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteDepartmentBtn.Location = new System.Drawing.Point(179, 655);
            this.DeleteDepartmentBtn.Name = "DeleteDepartmentBtn";
            this.DeleteDepartmentBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteDepartmentBtn.TabIndex = 16;
            this.DeleteDepartmentBtn.Text = "Удалить";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.EmployeeGrCn);
            this.panelControl2.Location = new System.Drawing.Point(364, 13);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(765, 636);
            this.panelControl2.TabIndex = 17;
            // 
            // EmployeeGrCn
            // 
            this.EmployeeGrCn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeGrCn.Location = new System.Drawing.Point(2, 2);
            this.EmployeeGrCn.MainView = this.EmployeeGrV;
            this.EmployeeGrCn.Name = "EmployeeGrCn";
            this.EmployeeGrCn.Size = new System.Drawing.Size(761, 632);
            this.EmployeeGrCn.TabIndex = 12;
            this.EmployeeGrCn.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EmployeeGrV});
            // 
            // EmployeeGrV
            // 
            this.EmployeeGrV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.EmployeeGrV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.EmployeeGrV.GridControl = this.EmployeeGrCn;
            this.EmployeeGrV.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.EmployeeGrV.Name = "EmployeeGrV";
            this.EmployeeGrV.OptionsBehavior.Editable = false;
            this.EmployeeGrV.OptionsBehavior.ReadOnly = true;
            this.EmployeeGrV.OptionsView.ShowGroupPanel = false;
            this.EmployeeGrV.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
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
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddEmployeeBtn.Location = new System.Drawing.Point(366, 655);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.AddEmployeeBtn.TabIndex = 18;
            this.AddEmployeeBtn.Text = "Добавить...";
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditEmployeeBtn.Location = new System.Drawing.Point(448, 655);
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.EditEmployeeBtn.TabIndex = 19;
            this.EditEmployeeBtn.Text = "Править...";
            // 
            // DeleteEmployeeBtn
            // 
            this.DeleteEmployeeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteEmployeeBtn.Location = new System.Drawing.Point(530, 655);
            this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            this.DeleteEmployeeBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteEmployeeBtn.TabIndex = 20;
            this.DeleteEmployeeBtn.Text = "Удалить";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 690);
            this.Controls.Add(this.DeleteEmployeeBtn);
            this.Controls.Add(this.EditEmployeeBtn);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.DeleteDepartmentBtn);
            this.Controls.Add(this.EditDepartmentBtn);
            this.Controls.Add(this.AddDepartnentBtn);
            this.Controls.Add(this.panelControl1);
            this.Name = "fmMain";
            this.Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentTrL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrCn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGrV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList DepartmentTrL;
        private DevExpress.XtraEditors.SimpleButton AddDepartnentBtn;
        private DevExpress.XtraEditors.SimpleButton EditDepartmentBtn;
        private DevExpress.XtraEditors.SimpleButton DeleteDepartmentBtn;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl EmployeeGrCn;
        private DevExpress.XtraGrid.Views.Grid.GridView EmployeeGrV;
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
        private DevExpress.XtraEditors.SimpleButton AddEmployeeBtn;
        private DevExpress.XtraEditors.SimpleButton EditEmployeeBtn;
        private DevExpress.XtraEditors.SimpleButton DeleteEmployeeBtn;
    }
}