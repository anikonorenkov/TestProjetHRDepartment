using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ViewModel
    {
        /// <summary>
        /// Получение списка идентификаторов подразделений  которые входят в выбранное подразделение включая и его самого
        /// </summary>
        /// <param name="ParentDepartmentId"></param>
        /// <returns></returns>
        public static List<int?> GetDepartmentsIdList(int id)
        {
            var parentDepartmentId = new List<int?>() { id };
            var childrenDepartment = new List<int?>() { id };

            if (DataManager.Instance.Departments.GetAll().Where(c => parentDepartmentId.Contains(c.Id)).Any())
            {

                for (int i = 0; i < DataManager.Instance.Departments.GetAll().Where(c => parentDepartmentId.Contains(c.Id)).Count(); i++)
                {
                    var intermedIdList = DataManager.Instance.Departments.GetAll()
                    .Where(c => parentDepartmentId.Contains(c.ParentId))
                    .Select(c => (int)c.Id).ToList();

                    parentDepartmentId.Clear();  // очищаем список

                    foreach (var item in intermedIdList)
                    {
                        parentDepartmentId.Add(item);
                        childrenDepartment.Add(item);
                    }
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
            var result = DataManager.Instance.Employees.GetAll().
            Where(c => departmentsId.Contains((int)c.DepartmentId)).
            Join(DataManager.Instance.Departments.GetAll(),    // Связываемый набор данных
             e => e.DepartmentId,  // Свойство селектор из первого набора
            d => d.Id,   // Свойство селектор из второго набора
            (e, d) => new Employee()
            {
                Id = e.Id,
                LastName = e.LastName,
                FirstName = e.FirstName,
                MiddleName = e.MiddleName,
                DtBirth = e.DtBirth,
                TabNumber = e.TabNumber,
                DtHire = e.DtHire,
                Gender = e.Gender,
                DepartmentId = e.DepartmentId,
                Position = e.Position,
                Information = e.Information,
                IsActive = e.IsActive
            }

            ).ToList();

            return result;

        }
    }
}
