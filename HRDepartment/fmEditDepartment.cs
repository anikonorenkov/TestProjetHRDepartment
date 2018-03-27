using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;

namespace HRDepartment
{
    public partial class fmEditDepartment : XtraForm
    {
        public fmEditDepartment()
        {
            InitializeComponent();
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

        private int _DepartmentId;

        /// <summary>
        /// Родительское подразделение
        /// </summary>
        public int ParentDepartment
        {
            get { return _DepartmentId; }
            set
            {

                if (value > 0)
                {
                    LUEDepartment.EditValue = value;
                }
                _DepartmentId = value;
            }
        }

        private DAL.Department _department;

        /// <summary>
        /// выбранное подразделение
        /// </summary>
        public DAL.Department Department
        {
            get { return _department; }
            set
            {

                if (value != null)
                {
                    this.Text = "Редактировать подразделение";
                    this.SBSave.Click += DoUpdate; ;
                    TEName.Text = value.Name;
                    TECode.Text = value.Code;

                    if (CEIsActiv.Checked)
                        CEIsActiv.Checked = (bool)value.IsActive;

                }
                else
                {
                    this.Text = "Добавить подразделение";
                    this.SBSave.Click += DoInsert;
                }
                _department = value;
            }
        }

        private void DoUpdate(object sender, EventArgs e)
        {
            try
            {
                DoUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoInsert(object sender, EventArgs e)
        {
            try
            {
                DoInsert();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Действия при добавлении подразделения
        /// </summary>
        private void DoInsert()
        {

            try
            {
                var department = new DAL.Department()
                {
                    Name = TEName.Text,
                    Code = TECode.Text,
                    DtCreated = DateTime.Now,
                    ParentId = (int)LUEDepartment.EditValue,
                    IsActive = CEIsActiv.Checked,
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
        private void DoUpdate()
        {
            try
            {
                Department.Name = TEName.Text;
                Department.Code = TECode.Text;
                Department.ParentId = (int)LUEDepartment.EditValue;
                Department.IsActive = CEIsActiv.Checked;

                DataManager.Instance.Departments.Edit(Department);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Предварительная загрузка связанных компонентов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FmEditDepartment_Load(object sender, EventArgs e)
        {
            SetDepartmentCombobox();
        }

        /// <summary>
        /// Установка "Родительского" подразделения для выпадающего списка
        /// </summary>
        private void SetDepartmentCombobox()
        {
            try
            {
                LUEDepartment.Properties.DataSource = DataManager.Instance.Departments.GetAll();
                LUEDepartment.Properties.DisplayMember = "Name";
                LUEDepartment.Properties.ValueMember = "Id";

                if (_department.ParentId.HasValue)
                    LUEDepartment.EditValue = _department.ParentId;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}