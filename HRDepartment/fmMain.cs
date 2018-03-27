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
    #region Описание интерфейса

    public interface IXtraForm
    {
        int DepartmentCurrentId { get; }
        int DepartmentCurrentParentId { get; }
        bool IsExistsEmployee { get; }
        int EmployeeCurrentDepartmentId { get; }
        List<int?> DepartmentChieldId { get; }
        int SelectedDGVRows { get; }
        int EmployeeId { get; }
        bool SelectedRowsCount { get; }
        void TLLoadDepartment();
        void GRLoadEmployee();

        event EventHandler SBAddDepartmentClick;
        event EventHandler SBEditDepartmentClick;
        event EventHandler SBDeleteDepartmentClick;

        event EventHandler SBAddEmployeeClick;
        event EventHandler SBEditEmployeeClick;
        event EventHandler SBDeleteEmployeeClick;

        event EventHandler LoadDataDepartmentTreeView;
        event EventHandler LoadDataEmployeeDataGridView;

    }

    #endregion

    public partial class fmMain : XtraForm , IXtraForm
    {

        /// <summary>
        /// Идентификатор текущего подразделения в DepartmentTrL
        /// </summary>
        public int DepartmentCurrentId
        {
            get { return (int)TLDepartmentList.FocusedNode.GetValue("Id"); }
        }

        /// <summary>
        /// Родительское подразделение выбранного в DepartmentTrL подразделения 
        /// </summary>
        public int DepartmentCurrentParentId
        {
            get { return DepartmentCurrentParentId; }
        }

        /// <summary>
        /// флаг наличия сотрудников в данном подразделении
        /// </summary>
        public bool IsExistsEmployee
        {
            get { return DataManager.Instance.Employees.GetAll().Where(d => d.DepartmentId == DepartmentCurrentId).Any(); }
        }

        /// <summary>
        /// Идентификатор департамента в котором числится сотрудник выбранный  в EmployeeDataGridView short{get}
        /// </summary>
        public int EmployeeCurrentDepartmentId
        {
            get { return (int)GVEmployee.GetRowCellValue(GVEmployee.FocusedRowHandle, "DepartmentId"); }
        }

        /// <summary>
        /// Список идентификаторов подчиненных департаментов
        /// </summary>
        public List<int?> DepartmentChieldId => throw new NotImplementedException();

        /// <summary>
        /// Выбранная строка в EmployeeDataGridView int{get}
        /// </summary>
        public int SelectedDGVRows
        {
            get { return (int)GVEmployee.GetRowCellValue(GVEmployee.FocusedRowHandle, "Id"); }
        }

        /// <summary>
        /// Идентификатор выбранного сотрудника в EmployeeDataGridView int{get}
        /// </summary>
        public int EmployeeId
        {
            get { return (int)GVEmployee.GetRowCellValue(GVEmployee.FocusedRowHandle, "Id"); }
        }

        /// <summary>
        /// флаг показывающий что строка в компоненте грид выбрана
        /// </summary>
        public bool SelectedRowsCount
        {
            get { return GVEmployee.RowCount <= 0; }
        }


        public fmMain()
        {
            InitializeComponent();
            LoadData();
            SBAddDepartnent.Click += SBAddDepartnent_Click;
            SBEditDepartment.Click += SBEditDepartment_Click;
            SBDeleteDepartment.Click += SBDeleteDepartment_Click;
            SBAddEmployee.Click += SBAddEmployee_Click;
            SBEditEmployee.Click += SBEditEmployee_Click;
            SBDeleteEmployee.Click += BSDeleteEmployee_Click;
        }

        #region Реализация интерфейса IMainForm
        private void BSDeleteEmployee_Click(object sender, EventArgs e)
        {
            SBDeleteEmployeeClick?.Invoke(this, EventArgs.Empty);
        }

        private void SBEditEmployee_Click(object sender, EventArgs e)
        {
            SBEditEmployeeClick?.Invoke(this, EventArgs.Empty);
        }

        private void SBAddEmployee_Click(object sender, EventArgs e)
        {
            SBAddEmployeeClick?.Invoke(this, EventArgs.Empty);
        }

        private void SBDeleteDepartment_Click(object sender, EventArgs e)
        {
            SBDeleteDepartmentClick?.Invoke(this, EventArgs.Empty);
        }

        private void SBEditDepartment_Click(object sender, EventArgs e)
        {
            SBEditDepartmentClick?.Invoke(this, EventArgs.Empty);
        }

        private void SBAddDepartnent_Click(object sender, EventArgs e)
        {
            SBAddDepartmentClick?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler SBAddDepartmentClick;
        public event EventHandler SBEditDepartmentClick;
        public event EventHandler SBDeleteDepartmentClick;
        public event EventHandler SBAddEmployeeClick;
        public event EventHandler SBEditEmployeeClick;
        public event EventHandler SBDeleteEmployeeClick;

        public event EventHandler LoadDataDepartmentTreeView;
        public event EventHandler LoadDataEmployeeDataGridView;

        #endregion

        public void TLLoadDepartment()
        {
            TLDepartmentList.DataSource = DataManager.Instance.Departments.GetAll();
            TLDepartmentList.ParentFieldName = "ParentId";
            TLDepartmentList.KeyFieldName = "Id";
        }

        /// <summary>
        /// Загрузка данных в EmployeeGrCn
        /// </summary>
        public void GRLoadEmployee()
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
                TLLoadDepartment();
                GRLoadEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// обновление данных в EmployeeDataGridView в соответсвии с выбранным подразделением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

            try
            {
                var departmens = new List<int?>();

                if (TLDepartmentList.FocusedNode != null)
                    departmens.Add((int)TLDepartmentList.FocusedNode.GetValue("Id"));

                departmens = GetDepartmentId(departmens);
                GCEmployeeList.DataSource = GetFilterDepartmentIDEmployees(departmens);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Получение списка идентификаторов подразделений в которые входят в выбранное подразделение
        /// </summary>
        /// <param name="ParentDepartmentId"></param>
        /// <returns></returns>
        public static List<int?> GetDepartmentId(List<int?> parentDepartmentId)
        {
            var childrenDepartment = new List<int?>();

            foreach (var item in parentDepartmentId)
            {
                childrenDepartment.Add(item);
            }

            while (DataManager.Instance.Departments.GetAll().Where(c => parentDepartmentId.Contains(c.Id)).Any())
            {
                var myDepartment = DataManager.Instance.Departments.GetAll()
                    .Where(c => parentDepartmentId.Contains(c.ParentId))
                    .Select(c => (int)c.Id).ToList();
                parentDepartmentId.Clear();

                foreach (var item in myDepartment)
                {
                    parentDepartmentId.Add(item);
                    childrenDepartment.Add(item);
                }
            }

            return childrenDepartment;
        }

        /// <summary>
        /// Получение фильтрованного по депортаментам запроса
        /// </summary>
        /// <param name="departmentID"></param>
        /// <returns></returns>
        public static List<Employee> GetFilterDepartmentIDEmployees(List<int?> departmentsId)
        {
            var result = new List<Employee>();
            var emp = DataManager.Instance.Employees.GetAll(). // Основоной набор данных 
                Where(c => departmentsId.Contains((int)c.DepartmentId)).
                Join(DataManager.Instance.Departments.GetAll(),    // Связываемый набор данных
                e => e.DepartmentId,  // Свойство селектор из первого набора
                d => d.Id,   // Свойство селектор из второго набора
                (e, d) => new           // Создаем результат
                {
                    employeeId = e.Id,
                    tabNom = e.TabNumber,
                    firstName = e.FirstName,
                    lastName = e.LastName,
                    middleName = e.MiddleName,
                    dtHire = e.DtHire,
                    birthDate = e.DtBirth,
                    gender = e.Gender,
                    position = e.Position,
                    information = e.Information,
                    departmentId = e.DepartmentId

                });

            foreach (var item in emp)
            {
                Employee e = new Employee()
                {
                    Id = item.employeeId,
                    FirstName = item.firstName,
                    LastName = item.lastName,
                    MiddleName = item.middleName,
                    DtHire = item.dtHire,
                    TabNumber = item.tabNom,
                    DtBirth = item.birthDate,
                    Gender = item.gender,
                    Position = item.position,
                    Information = item.information,
                    DepartmentId = item.departmentId
                };

                result.Add(e);
            }

            return result;

        }

        /// <summary>
        /// обновление данных в DepartmentTrL в соответсвии с выбранным подразделением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepartmentTrL_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {

            try
            {
                var listId = new List<int?>();

                if (TLDepartmentList.FocusedNode.GetValue("Id") != null)
                    listId.Add((int)TLDepartmentList.FocusedNode.GetValue("Id"));

                listId = GetDepartmentId(listId);

                GCEmployeeList.DataSource = GetFilterDepartmentIDEmployees(listId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}