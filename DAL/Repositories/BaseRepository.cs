using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BaseRepository<TEntity>
        where TEntity : new()
    {
        private DataManager _dataManager;

        public BaseRepository(DataManager dataManager)
        {
            this._dataManager = dataManager;
        }

        /// <summary>
        /// Использование кеша
        /// </summary>
        private static List<TEntity> CashedList { get; set; }

        /// <summary>
        /// Получение списка объектов
        /// </summary>
        /// <returns></returns>
        public virtual List<TEntity> GetAll()
        {
            if (CashedList != null)
                return CashedList;

            var type = typeof(TEntity);
            var tableName = type.Name;
            var sql = "Select * from " + tableName;
            var propValues = _dataManager.SqlExecuter.Execute(sql, tableName);

            var itemsList = new List<TEntity>();

            foreach (DataRow row in propValues.Rows)
            {
                itemsList.Add(CreateItemFromRow<TEntity>(row));
            }

            return itemsList;
        }

        /// <summary>
        /// Получение одного объекта Id которого передается во входящем параметре
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity GetById(int id)
        {
            //  return this.GetAll().FirstOrDefault(e => e.Id == id);

            var type = typeof(TEntity);
            var tableName = type.Name;

            var sql = "Select * from " + tableName + " Where id = @id";
            var propValues = _dataManager.SqlExecuter.Execute(sql, new object[] { "id", id }, tableName);

            var item = new TEntity();

            foreach (DataRow row in propValues.Rows)
            {
                item = (CreateItemFromRow<TEntity>(row));
            }

            return item;
        }

        /// <summary>
        /// Редактирование объекта
        /// </summary>
        /// <param name="editItem"></param>
        public virtual void Edit(TEntity editItem)
        {
            var type = typeof(TEntity);
            var tableName = type.Name;
            int id = 0;

            var propNames = new List<string>();
            var propValues = new List<object>();

            foreach (var prop in type.GetProperties().Where(c => !c.GetMethod.IsVirtual))
            {
                var propName = prop.Name;
                var propValue = prop.GetValue(editItem);

                if (propName == "Id")
                {
                    id = (int)propValue;
                    continue;
                }

                propNames.Add(propName + " = @" + propName);

                propValues.Add(propName);
                propValues.Add(propValue);
            }

            propValues.Add("@id");
            propValues.Add(id);
            var fields = string.Join(", ", propNames);

            var sql = "Update " + tableName + " SET " + fields + " WHERE Id = @id";

            _dataManager.SqlExecuter.Execute(sql, propValues.ToArray());
        }

        /// <summary>
        /// Добавление нового объекта
        /// </summary>
        /// <param name="editItem"></param>
        public virtual void Add(TEntity editItem)
        {

            var type = typeof(TEntity); // Объявляем сущность Department
            var tableName = type.Name;   // ПОлучаем название сущности

            var propNames = new List<string>();  // Объявляем список Названий внутри сущности (Полей)  (Строка)
            var propValues = new List<object>();  // Объявляем список Значений полей внутри сущности   (Объект)

            foreach (var prop in type.GetProperties().Where(c => !c.GetMethod.IsVirtual))   // возврящаем все поля ключ значение из записи путем перебора
            {
                //if (prop.GetCustomAttributes(true).Count(a => a is DbPropAttribute) == 0)
                //    continue;
                // Добавить Аттрибуты и фильтровать по ним




                var propName = prop.Name;                   // присваиваем переменной название поля
                var propValue = prop.GetValue(editItem);  // получаем значение нужного поля

                if (propName == "Id")                   // поле Id автоинкрементное поэтому его пропускаем
                    continue;

                propNames.Add(propName);                // добавляем в список Названий название поля

                propValues.Add(propName);               // добавляем в список Значений Название поля 
                propValues.Add(propValue);              // добавляем в список Значений Значение поля
            }

            var fields = string.Join(", ", propNames);   // Формируем строку Поля для SQL запроса
            var values = "@" + string.Join(", @", propNames);  // формируем строку Значения для SQL запроса

            var sql = "insert into " + tableName + " (" + fields + ") Values (" + values + ")";   // формируем SQL запрос 


            _dataManager.SqlExecuter.Execute(sql, propValues.ToArray()); // вызываем процедуру исполнения запроса
        }

        /// <summary>
        /// Удаление выбранного объекта
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(int id)
        {
            var tableName = typeof(TEntity).Name;
            var sql = "Delete from " + tableName + " Where id = @id";

            _dataManager.SqlExecuter.Execute(sql, new object[] { "id", id });
        }

        /// <summary>
        /// Создание строки данных (Объекта)
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="row"></param>
        /// <returns></returns>
        public static TEntity CreateItemFromRow<TEntity>(DataRow row) where TEntity : new()
        {
            // Создаем объект
            TEntity item = new TEntity();

            // присваеваем данные из таблицы объекту
            SetItemFromRow(item, row);

            // возвращаем итем 
            return item;
        }

        /// <summary>
        /// Заполнение данных строки
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="item"></param>
        /// <param name="row"></param>
        public static void SetItemFromRow<TEntity>(TEntity item, DataRow row) where TEntity : new()
        {
            // Создаем колонки для таблицы
            foreach (DataColumn c in row.Table.Columns)
            {
                // Ищим информацию о колонке
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);

                // если все нормально то присваеваем данные
                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(item, row[c], null);
                }
            }
        }
    }
}
