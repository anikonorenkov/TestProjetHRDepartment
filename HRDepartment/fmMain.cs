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
        void LoadDepartmentTrL();
        void LoadEmployeeGrCn();

        event EventHandler AddDepartmentBtnClick;
        event EventHandler EditDepartmentBtnClick;
        event EventHandler DeleteDepartmentBtnClick;

        event EventHandler AddEmployeeBtnClick;
        event EventHandler EditEmployeeBtnClick;
        event EventHandler DeleteEmployeeBtnClick;

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
            get { return (int)DepartmentTrL.FocusedNode.GetValue("Id"); }
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
            get { return (int)EmployeeGrV.GetRowCellValue(EmployeeGrV.FocusedRowHandle, "DepartmentId"); }
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
            get { return (int)EmployeeGrV.GetRowCellValue(EmployeeGrV.FocusedRowHandle, "Id"); }
        }

        /// <summary>
        /// Идентификатор выбранного сотрудника в EmployeeDataGridView int{get}
        /// </summary>
        public int EmployeeId
        {
            get { return (int)EmployeeGrV.GetRowCellValue(EmployeeGrV.FocusedRowHandle, "Id"); }
        }

        /// <summary>
        /// флаг показывающий что строка в компоненте грид выбрана
        /// </summary>
        public bool SelectedRowsCount
        {
            get { return EmployeeGrV.RowCount <= 0; }
        }


        public fmMain()
        {
            InitializeComponent();
            LoadData();
            AddDepartnentBtn.Click += AddDepartnentBtn_Click;
            EditDepartmentBtn.Click += EditDepartmentBtn_Click;
            DeleteDepartmentBtn.Click += DeleteDepartmentBtn_Click;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            EditEmployeeBtn.Click += EditEmployeeBtn_Click;
            DeleteEmployeeBtn.Click += DeleteEmployeeBtn_Click;
        }

        #region Реализация интерфейса IMainForm
        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            DeleteEmployeeBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            EditEmployeeBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            AddEmployeeBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void DeleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            DeleteDepartmentBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void EditDepartmentBtn_Click(object sender, EventArgs e)
        {
            EditDepartmentBtnClick?.Invoke(this, EventArgs.Empty);
        }

        private void AddDepartnentBtn_Click(object sender, EventArgs e)
        {
            AddDepartmentBtnClick?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler AddDepartmentBtnClick;
        public event EventHandler EditDepartmentBtnClick;
        public event EventHandler DeleteDepartmentBtnClick;
        public event EventHandler AddEmployeeBtnClick;
        public event EventHandler EditEmployeeBtnClick;
        public event EventHandler DeleteEmployeeBtnClick;

        public event EventHandler LoadDataDepartmentTreeView;
        public event EventHandler LoadDataEmployeeDataGridView;

        #endregion

        public void LoadDepartmentTrL()
        {
            DepartmentTrL.DataSource = DataManager.Instance.Departments.GetAll();
            DepartmentTrL.ParentFieldName = "ParentId";
            DepartmentTrL.KeyFieldName = "Id";
        }

        /// <summary>
        /// Загрузка данных в EmployeeGrCn
        /// </summary>
        public void LoadEmployeeGrCn()
        {
            EmployeeGrCn.DataSource = DataManager.Instance.Employees.GetAll();
        }

        /// <summary>
        /// Первичная загрузка данных
        /// </summary>
        private void LoadData()
        {
            try
            {
                LoadDepartmentTrL();
                LoadEmployeeGrCn();
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

                if (DepartmentTrL.FocusedNode != null)
                    departmens.Add((int)DepartmentTrL.FocusedNode.Tag);
                departmens = GetDepartmentId(departmens);

                EmployeeGrCn.DataSource = GetFilterDepartmentIDEmployees(departmens);
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
        public static List<Employee> GetFilterDepartmentIDEmployees(List<int?> departmentsID)
        {
            var result = new List<Employee>();
            var emp = DataManager.Instance.Employees.GetAll(). // Основоной набор данных 
                Where(c => departmentsID.Contains((int)c.DepartmentId)).
                Join(DataManager.Instance.Departments.GetAll(),    // Связываемый набор данных
                e => e.DepartmentId,  // Свойство селектор из первого набора
                d => d.Id,   // Свойство селектор из второго набора
                (e, d) => new           // Создаем результат
                {
                    employeeID = e.Id,
                    tabNom = e.TabNumber,
                    firstName = e.FirstName,
                    lastName = e.LastName,
                    middleName = e.MiddleName,
                    dtHire = e.DtHire,
                    birthDate = e.DtBirth,
                    gender = e.Gender,
                    position = e.Position,
                    information = e.Information,
                    departmentID = e.DepartmentId

                });
            foreach (var item in emp)
            {
                Employee e = new Employee()
                {
                    Id = item.employeeID,
                    FirstName = item.firstName,
                    LastName = item.lastName,
                    MiddleName = item.middleName,
                    DtHire = item.dtHire,
                    TabNumber = item.tabNom,
                    DtBirth = item.birthDate,
                    Gender = item.gender,
                    Position = item.position,
                    Information = item.information,
                    DepartmentId = item.departmentID
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

                if (DepartmentTrL.FocusedNode.GetValue("Id") != null)
                    listId.Add((int)DepartmentTrL.FocusedNode.GetValue("Id"));
                listId = GetDepartmentId(listId);

                EmployeeGrCn.DataSource = GetFilterDepartmentIDEmployees(listId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}