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

    public partial class fmMain : XtraForm
    {
        public fmMain()
        {
            InitializeComponent();
            LoadData();
        }

        #region Переменные используемые в методах формы

        /// <summary>
        /// Идентификатор текущего подразделения в DepartmentTrL
        /// </summary>
        private int CurrentDepartmentId
        {
            get { return (int)TLDepartmentList.FocusedNode.GetValue("Id"); }
        }

        /// <summary>
        /// Родительское подразделение выбранного в DepartmentTrL подразделения 
        /// </summary>
        private int CurrentDepartmentParentId
        {
            get { return CurrentDepartmentParentId; }
        }

        /// <summary>
        /// флаг наличия сотрудников в данном подразделении
        /// </summary>
        private bool IsExistsEmployee
        {
            get { return DataManager.Instance.Employees.GetAll().Where(d => d.DepartmentId == CurrentDepartmentId).Any(); }
        }

        /// <summary>
        /// Идентификатор департамента в котором числится сотрудник выбранный   
        /// </summary>
        private int EmployeeCurrentDepartmentId
        {
            get { return (int)GVEmployee.GetRowCellValue(GVEmployee.FocusedRowHandle, "DepartmentId"); }
        }

        /// <summary>
        /// Идентификатор сотрудника выбранной строки в GVEmployee 
        /// </summary>
        private int SelectedDGVRows
        {
            get { return (int)GVEmployee.GetRowCellValue(GVEmployee.FocusedRowHandle, "Id"); }
        }

        /// <summary>
        /// Идентификатор выбранного сотрудника в EmployeeDataGridView 
        /// </summary>
        private int EmployeeId
        {
            get { return (int)GVEmployee.GetRowCellValue(GVEmployee.FocusedRowHandle, "Id"); }
        }

        /// <summary>
        /// флаг показывающий что строка в компоненте GVEmployee выбрана хотя бы одна строка
        /// </summary>
        private bool SelectedRowsGVEmployee
        {
            get { return GVEmployee.RowCount <= 0; }
        }

        #endregion

        /// <summary>
        /// Загрузка данных в TLLoadDepartment
        /// </summary>
        private void TLLoadDepartmentsList()
        {
            TLDepartmentList.DataSource = DataManager.Instance.Departments.GetAll();
        }

        /// <summary>
        /// Загрузка данных в EmployeeGrCn
        /// </summary>
        private void GRLoadEmployeesList()
        {
            GCEmployeeList.DataSource = DataManager.Instance.Employees.GetAll();
        }

        /// <summary>
        /// Первичная загрузка данных
        /// </summary>
        private void LoadData()
        {

            try
            {
                TLLoadDepartmentsList();
                GRLoadEmployeesList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// обновление данных в TLDepartmentList в соответсвии с выбранным подразделением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentTrL_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

            try
            {

                if (TLDepartmentList.FocusedNode.GetValue("Id") == null)
                    return;

                var listId = DAL.Repositories.ViewModel.GetDepartmentsIdList(((int)TLDepartmentList.FocusedNode.GetValue("Id")));
                GCEmployeeList.DataSource = DAL.Repositories.ViewModel.GetFilterDepartmentIDEmployees(listId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Работа с кнопками вызова форм и удаления

        /// <summary>
        /// Удаление выбранного сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить сотрудника?", "Предупреждение.", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var employee = DataManager.Instance.Employees.GetById(EmployeeId);
                    DataManager.Instance.Employees.Delete(employee.Id);
                    GRLoadEmployeesList();
                }
                else
                    return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Редактирование данных о сотруднике
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBEditEmployee_Click(object sender, EventArgs e)
        {
            try
            {

                if (SelectedRowsGVEmployee)
                {
                    MessageBox.Show("Выберите сотрудника для редактирования.", "Информационное сообщение.", MessageBoxButtons.OK);

                    return;

                }

                var employee = DataManager.Instance.Employees.GetById(EmployeeId);

                if (fmEditEmployee.Execute(employee))
                {
                    GRLoadEmployeesList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Добавление нового сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var employee = new Employee
                {
                    Id = 0,
                    FirstName = "",
                    LastName = "",
                    TabNumber = "",
                    DtHire = System.DateTime.Now
                };

                if (fmEditEmployee.Execute(employee))
                {
                    GRLoadEmployeesList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Удаление выбранного подразделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBDeleteDepartment_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Удалить подразделение?", "Предупреждение.", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var department = DataManager.Instance.Departments.GetById(CurrentDepartmentId);
                    DataManager.Instance.Departments.Delete(department.Id);
                    TLLoadDepartmentsList();
                }

                else
                    return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Редактирование выбранного подразделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBEditDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                var department = DataManager.Instance.Departments.GetById(CurrentDepartmentId);

                if (fmEditDepartment.Execute(department))
                {
                    TLLoadDepartmentsList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Добавление нового департамента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBAddDepartnent_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.Department department = new DAL.Department
                {
                    Id = 0,
                    Name = "",
                    Code = ""
                };

                if (fmEditDepartment.Execute(department))
                {
                    TLLoadDepartmentsList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}