using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Entity;

namespace DAL
{

    public sealed class DataManager
    {

        /// <summary>
        /// Конструктор класса
        /// </summary>
        private DataManager()
        {

        }

        public static string sqlConnection = @"Data Source=localhost;Initial Catalog=HRDepartment;Integrated Security=True";
        public SqlConnection _conn = new SqlConnection(sqlConnection);

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="conn"></param>
        public DataManager(SqlConnection conn)
        {
            conn = _conn;
        }

        private SqlExecuter _executer;

        /// <summary>
        /// Класс SqlExecuter (Туда перенести все методы)
        /// </summary>
        public SqlExecuter SqlExecuter
        {
            get
            {

                if (_executer == null)
                {
                    _executer = new SqlExecuter();
                }

                return _executer;
            }
        }


        private static DataManager instance = null;

        /// <summary>
        /// Инстанс менеджра данных
        /// </summary>
        public static DataManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataManager();
                }
                return instance;
            }
        }

        #region Repositories

        private DepartmentRepository _departmentRepository;

        /// <summary>
        /// Подразделения 
        /// </summary>
        public DepartmentRepository Departments
        {
            get
            {
                if (_departmentRepository == null)
                {
                    _departmentRepository = new DepartmentRepository(Instance);
                }

                return _departmentRepository;
            }
        }

        private EmployeeRepository _employeeRepository;

        /// <summary>
        /// поле - репозиторий сотрудники
        /// </summary>
        public EmployeeRepository Employees
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(Instance);
                }
                return _employeeRepository;
            }
        }

        #endregion Repositories
    }
}
