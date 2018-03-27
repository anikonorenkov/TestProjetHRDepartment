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

        ///// <summary>
        ///// Получение списка сотрудников
        ///// </summary>
        ///// <returns></returns>
        //public override List<Employee> GetAll()
        //{
        //    return base.GetAll();
        //}

        ///// <summary>
        ///// Получение списка из одного сотрудника выбранного по идентификатору входящего параметра
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public override Employee GetById(int id)
        //{
        //    var result = base.GetById(id);
        //    return result;
        //}

        ///// <summary>
        ///// Добавление нового сотрудника
        ///// </summary>
        ///// <param name="employee"></param>
        //public override void Add(Employee employee)
        //{
        //    base.Add(employee);
        //}

        ///// <summary>
        ///// Редактирование данных о сотруднике
        ///// </summary>
        ///// <param name="employee"></param>
        //public override void Edit(Employee employee)
        //{
        //    base.Edit(employee);
        //}

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
