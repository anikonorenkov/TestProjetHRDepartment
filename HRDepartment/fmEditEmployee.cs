using DAL;
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
    public partial class fmEditEmployee : Form
    {
        public fmEditEmployee()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {
                SetDepartmentCombobox();
            }
            catch(Exception ex)
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
                    Text = "Редактировать сотрудника";
                    SaveBtn.Click += UpdateType;

                    LastNameTxBx.Text = value.LastName;
                    FirstNameTxBx.Text = value.FirstName;
                    MiddleNameTxBx.Text = value.MiddleName;
                    BirthDateDtTP.Value = (DateTime)value.DtBirth;
                    TabNoTxBx.Text = value.TabNumber;
                    HireDateDtTP.Value = (DateTime)value.DtHire;
                    GenderCbCx.Text = value.Gender;
                    DepartmentCbBx.SelectedValue = value.DepartmentId;
                    PositionTxBx.Text = value.Position;
                    InformationTxBx.Text = value.Information;

                    if (IsActiveEmployeeChBx.Checked)
                        IsActiveEmployeeChBx.Checked = Convert.ToBoolean(value.IsActive);

                }

                else
                {
                    Text = "Добавить сотрудника";
                    SaveBtn.Click += InsertType;
                }

                _employee = value;
            }
        }

        public int _DepartmentID;

        /// <summary>
        /// Передаваепое подразделение
        /// </summary>
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

        /// <summary>
        /// Действия при редактировании подразделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateType(object sender, EventArgs e)
        {
            try
            {
                UpdateType();
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
        private void InsertType(object sender, EventArgs e)
        {
            try
            {
                InsertType();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertType()
        {
            try
            {
                var employee = new Employee()
                {
                    LastName = LastNameTxBx.Text,
                    FirstName = FirstNameTxBx.Text,
                    MiddleName = MiddleNameTxBx.Text,
                    DtBirth = BirthDateDtTP.Value,
                    TabNumber = TabNoTxBx.Text,
                    DtHire = HireDateDtTP.Value,
                    Gender = GenderCbCx.Text,
                    DepartmentId = (int)DepartmentCbBx.SelectedValue,
                    Position = PositionTxBx.Text,
                    Information = InformationTxBx.Text,
                    IsActive = Convert.ToInt32(IsActiveEmployeeChBx.Checked)
                };

                DataManager.Instance.Employees.Add(employee);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UpdateType()
        {
            try
            {
                Employee.LastName = LastNameTxBx.Text;
                Employee.FirstName = FirstNameTxBx.Text;
                Employee.MiddleName = MiddleNameTxBx.Text;
                Employee.DtBirth = BirthDateDtTP.Value;
                Employee.TabNumber = TabNoTxBx.Text;
                Employee.DtHire = HireDateDtTP.Value;
                Employee.Gender = GenderCbCx.Text;
                Employee.DepartmentId = (int)DepartmentCbBx.SelectedValue;
                Employee.Position = PositionTxBx.Text;
                Employee.Information = InformationTxBx.Text;

                Employee.IsActive = Convert.ToInt32(IsActiveEmployeeChBx.Checked);

                DataManager.Instance.Employees.Edit(Employee);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Подгрузка справочника подразделений
        /// </summary>
        private void SetDepartmentCombobox()
        {
            try
            {
                DepartmentCbBx.DataSource = DataManager.Instance.Departments.GetAll();
                DepartmentCbBx.DisplayMember = "Name";
                DepartmentCbBx.ValueMember = "Id";

                if (_employee.DepartmentId.HasValue)
                {
                    int? id = 0;
                    id = _employee.DepartmentId;
                    DepartmentCbBx.SelectedValue = id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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
