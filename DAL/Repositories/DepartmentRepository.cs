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
    public class DepartmentRepository : BaseRepository<Department>
    {

        /// <summary>
        /// Конструктор на базе базового класса
        /// </summary>
        /// <param name="dataManager"></param>
        public DepartmentRepository(DataManager dataManager) : base(DataManager.Instance)
        {

        }

        /// <summary>
        /// Удаление выбранного подразделения вместе со вложенными поддразделениями и входящими в них сотрудниками
        /// </summary>
        /// <param name="id"></param>
        public override void Delete(int id)
        {

            var deptIdList = ViewModel.GetDepartmentsIdList(id);

            foreach (var deptId in deptIdList)
            {
                var listEmployeeId = DataManager.Instance.Employees.GetAll().Where(d => d.DepartmentId == deptId).Select(c => c.Id).ToList();

                foreach (var itemIdDelete in listEmployeeId)
                {
                    DataManager.Instance.Employees.Delete(itemIdDelete);
                }
            }

            foreach (var deptId in deptIdList)
            {
                base.Delete((int)deptId);
            }

            base.Delete(id);

        }


    }
}
