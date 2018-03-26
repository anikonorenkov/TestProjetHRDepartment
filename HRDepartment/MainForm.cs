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
using HRDepartment.BL;


namespace HRDepartment
{

    public interface IMainForm
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

    public partial class MainForm : Form, IMainForm
    {
        #region Реализация интерфейса IMainForm

        /// <summary>
        /// Идентификатор текущего подразделения в DepartmentTreeView 
        /// </summary>
        public int DepartmentCurrentId
        {
            get { return (int)DepartmentTreeView.SelectedNode.Tag; }
        }

        /// <summary>
        /// Родительское подразделение выбранного в DepartmentTreeView подразделения 
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
             get { return (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DepartmentId"); }
        }

        public List<int?> DepartmentChieldId => throw new NotImplementedException();

        /// <summary>
        /// Выбранная строка в EmployeeDataGridView int{get}
        /// </summary>
        public int SelectedDGVRows
        {
            get { return (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id"); }
        }

        /// <summary>
        /// Идентификатор выбранного сотрудника в EmployeeDataGridView int{get}
        /// </summary>
        public int EmployeeId
        {
            get { return (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id"); }
        }

        public bool SelectedRowsCount
        {
            get { return gridView1.RowCount <= 0; }
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            AddDepartmentBtn.Click += AddDepartmentBtn_Click;
            EditDepartmentBtn.Click += EditDepartmentBtn_Click;
            DeleteDepartmentBtn.Click += DeleteDepartmentBtn_Click;
            AddEmployeeBtn.Click += AddEmployeeBtn_Click;
            EditEmployeeBtn.Click += EditEmployeeBtn_Click;
            DeleteEmployeeBtn.Click += DeleteEmployeeBtn_Click;
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (DeleteEmployeeBtnClick != null) DeleteEmployeeBtnClick(this, EventArgs.Empty);
        }

        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (EditEmployeeBtnClick != null) EditEmployeeBtnClick(this, EventArgs.Empty);
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (AddEmployeeBtnClick != null) AddEmployeeBtnClick(this, EventArgs.Empty);
        }

        private void DeleteDepartmentBtn_Click(object sender, EventArgs e)
        {
            if (DeleteDepartmentBtnClick != null) DeleteDepartmentBtnClick(this, EventArgs.Empty);
        }

        private void EditDepartmentBtn_Click(object sender, EventArgs e)
        {
            if (EditDepartmentBtnClick != null) EditDepartmentBtnClick(this, EventArgs.Empty);
        }

        private void AddDepartmentBtn_Click(object sender, EventArgs e)
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
        /// Рекурсивная функция заполнения TreeView
        /// </summary>
        /// <param name="dp"></param>
        /// <param name="rootNode"></param>
        public void GetDepartmentRecurs(int parentDirectoryId, TreeNode rootNode)
        {

            if (DataManager.Instance.Departments.GetAll().Where(c => c.ParentId == parentDirectoryId).Any())
            {
                var chieldDepartment = DataManager.Instance.Departments.GetAll().Where(c => c.ParentId == parentDirectoryId);
                TreeNode cN = new TreeNode();
                cN = rootNode;
                foreach (var item in chieldDepartment)
                {
                    TreeNode cNN = new TreeNode(item.Name);
                    cNN.Tag = item.Id;
                    cN.Nodes.Add(cNN);
                    GetDepartmentRecurs(item.Id, cNN);
                }
            }
        }

        /// <summary>
        ///  вызов заполнненого дерева
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LoadDepartmentTrL()
        {
            DepartmentTreeView.Nodes.Clear();
            var node = DataManager.Instance.Departments.GetAll().Where(a => a.ParentId == null);
            foreach (var item in node)
            {
                TreeNode rootNode = new TreeNode(item.Name);
                rootNode.Tag = item.Id;
                DepartmentTreeView.Nodes.Add(rootNode);
                GetDepartmentRecurs(item.Id, rootNode);
            }
        }

        /// <summary>
        /// заполнение EmployeeDataGridView информацией о сотрудниках
        /// </summary>
        public void LoadEmployeeGrCn()
        {
            GridControlEmployee.DataSource = DataManager.Instance.Employees.GetAll(); 
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

                if (DepartmentTreeView.SelectedNode != null)
                    departmens.Add((int)DepartmentTreeView.SelectedNode.Tag);
                departmens = GetDepartmentId(departmens);

                GridControlEmployee.DataSource = GetFilterDepartmentIDEmployees(departmens);
            }
            catch(Exception ex)
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            fmMain fmMain = new fmMain();
            fmMain.ShowDialog();
        }
    }
}
