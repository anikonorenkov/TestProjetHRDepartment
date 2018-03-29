using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entity;

namespace DAL.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="dataManager"></param>
        public EmployeeRepository(DataManager dataManager) : base(DataManager.Instance)
        {

        }

        /// <summary>
        /// Удаление выбранного сотрудника
        /// </summary>
        /// <param name="id"></param>
        public override void Delete(int id)
        {
            base.Delete(id);
        }
    }
}
