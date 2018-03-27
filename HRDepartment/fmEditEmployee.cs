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
    public partial class fmEditEmployee : XtraForm
    {
        public fmEditEmployee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработка диалогового значения формы
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public static bool Execute(Employee employee)
        {
            using (var fm = new fmEditEmployee())
            {

                fm.Employee = employee;
                var dr = fm.ShowDialog();

                return dr == DialogResult.OK;
            }
        }

        /// <summary>
        /// Предварительная загрузка связанных компонентов формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FmEditEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                SetDepartmentCombobox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Employee _employee;

        /// <summary>
        /// выбранный сотрудник
        /// </summary>
        public Employee Employee
        {
            get { return _employee; }
            set
            {

                if (value != null)
                {
                    this.Text = "Редактировать сотрудника";
                    this.SBSave.Click += DoUpdate;

                    TELastName.Text = value.LastName;
                    TEFirstName.Text = value.FirstName;
                    TEMiddleName.Text = value.MiddleName;
                    DEBirthDay.DateTime = (DateTime)value.DtBirth;
                    TETabNumber.Text = value.TabNumber;
                    DEHireDate.DateTime = (DateTime)value.DtHire;
                    CBEGender.Text = value.Gender;
                    LUEDepartment.ItemIndex = (int)value.DepartmentId;
                    TEPosition.Text = value.Position;
                    MEInformation.Text = value.Information;

                    if (CEIsActiv.Checked)
                        CEIsActiv.Checked = Convert.ToBoolean(value.IsActive);

                   
                }

                else
                {
                    Text = "Добавить сотрудника";
                    SBSave.Click += DoInsert;
                }

                _employee = value;
            }
        }

        private int _DepartmentId;

        /// <summary>
        /// Передаваепое подразделение
        /// </summary>
        public int ParentDepartment
        {
            get { return _DepartmentId; }
            set
            {

                if (value != 0)
                {
                    LUEDepartment.ItemIndex = value;
                }
                _DepartmentId = value;
            }
        }

        /// <summary>
        /// Действия при редактировании подразделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Действия при добавлении подразделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoInsert(object sender, EventArgs e)
        {
            try
            {
                DoInsert();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoInsert()
        {
            try
            {
                var employee = new Employee()
                {
                    LastName = TELastName.Text,
                    FirstName = TEFirstName.Text,
                    MiddleName = TEMiddleName.Text,
                    DtBirth = DEBirthDay.DateTime,
                    TabNumber = TETabNumber.Text,
                    DtHire = DEHireDate.DateTime,
                    Gender = CBEGender.Text,
                    DepartmentId = (int)LUEDepartment.EditValue,
                    Position = TEPosition.Text,
                    Information = MEInformation.Text,
                    IsActive = Convert.ToInt32(CEIsActiv.Checked)
                };

              

                DataManager.Instance.Employees.Add(employee);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoUpdate()
        {
            try
            {
                Employee.LastName = TELastName.Text;
                Employee.FirstName = TEFirstName.Text;
                Employee.MiddleName = TEMiddleName.Text;
                Employee.DtBirth = DEBirthDay.DateTime;
                Employee.TabNumber = TETabNumber.Text;
                Employee.DtHire = DEHireDate.DateTime;
                Employee.Gender = CBEGender.Text;
                Employee.DepartmentId = (int)LUEDepartment.EditValue;
                Employee.Position = TEPosition.Text;
                Employee.Information = MEInformation.Text;

                Employee.IsActive = Convert.ToInt32(CEIsActiv.Checked);

               

                DataManager.Instance.Employees.Edit(Employee);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetDepartmentCombobox()
        {
            try
            {

                LUEDepartment.Properties.DataSource = DataManager.Instance.Departments.GetAll();
                LUEDepartment.Properties.DisplayMember = "Name";
                LUEDepartment.Properties.ValueMember = "Id";

                if (_employee.DepartmentId.HasValue && _employee.DepartmentId > 0)
                {
                    LUEDepartment.EditValue = (int)_employee.DepartmentId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}