using DAL.Entity;
using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDepartment
{
    public partial class fmEditDepartment : Form
    {
        public fmEditDepartment()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            SetDepartmentCombobox();
        }

        public int _DepartmentID;

        public int ParentDepartment
        {
            get { return _DepartmentID; }
            set
            {

                if (value != 0)
                {
                    DepartmentCbBx.SelectedValue = value;
                }
                _DepartmentID = value;
            }
        }

        private void UpdateType(object sender, EventArgs e)
        {
            UpdateType();
        }

        private void InsertType(object sender, EventArgs e)
        {
            InsertType();
        }

        /// <summary>
        /// выбранное подразделение
        /// </summary>
        private DAL.Department _department;

        public  DAL.Department Department
        {
            get { return _department; }
            set
            {

                if (value != null)
                {
                    this.Text = "Редактировать подразделение";
                    this.SaveBtn.Click += UpdateType; ;
                    NameTxb.Text = value.Name;
                    CodeTxb.Text = value.Code;

                    if (IsActiveDepartmentChb.Checked)
                        IsActiveDepartmentChb.Checked = (bool)value.IsActive;

                }
                else
                {
                    this.Text = "Добавить подразделение";
                    this.SaveBtn.Click += InsertType;
                }
                _department = value;
            }
        }

        /// <summary>
        /// Установка "Родительского" подразделения для выпадающего списка
        /// </summary>
        public void SetDepartmentCombobox()
        {
            try
            {
                DepartmentCbBx.DataSource = DataManager.Instance.Departments.GetAll();
                DepartmentCbBx.DisplayMember = "Name";
                DepartmentCbBx.ValueMember = "Id";

                if (_department.ParentId.HasValue)
                    DepartmentCbBx.SelectedValue = _department.ParentId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Действия при добавлении подразделения
        /// </summary>
        private void InsertType()
        {
            try
            {
                var department = new DAL.Department()
                {
                    Name = NameTxb.Text,
                    Code = CodeTxb.Text,
                    DtCreated = DateTime.Now,
                    ParentId = (int)DepartmentCbBx.SelectedValue,
                    IsActive = IsActiveDepartmentChb.Checked,
                };
                DataManager.Instance.Departments.Add(department);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Действия при редактировании подразделения
        /// </summary>
        private void UpdateType()
        {
            try
            {
                Department.Name = NameTxb.Text;
                Department.Code = CodeTxb.Text;
                Department.ParentId = (int)DepartmentCbBx.SelectedValue;
                Department.IsActive = IsActiveDepartmentChb.Checked;
                DataManager.Instance.Departments.Edit(Department);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool Execute(DAL.Department department)
        {
            using (var fm = new fmEditDepartment())
            {
                fm.Department = department;
                var dr = fm.ShowDialog();

                return dr == DialogResult.OK;
            }
        }

        /// <summary>
        /// Закрыть форму
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
