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
        /// Возвращает список подразделений
        /// </summary>
        /// <returns></returns>
        public override List<Department> GetAll()
        {
            var result = base.GetAll();
            return result;
        }

        /// <summary>
        /// Возвращает список из одного подразделения id которого передается в качестве входящего параметра
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override Department GetById(int id)
        {
            var result = base.GetById(id);
            return result;
        }

        /// <summary>
        /// Добавляет новое подразделение
        /// </summary>
        /// <param name="department"></param>
        public override void Add(Department department)
        {
            base.Add(department);
        }

        /// <summary>
        /// Редактирование выбранного подразделения
        /// </summary>
        /// <param name="department"></param>
        public override void Edit(Department department)
        {
            base.Edit(department);
        }

        /// <summary>
        /// Удаление выбранного подразделения
        /// </summary>
        /// <param name="id"></param>
        public override void Delete(int id)
        {
            base.Delete(id);
        }
    }
}
