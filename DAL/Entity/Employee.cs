
namespace DAL
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Таблица сотрудники в ней находятся данные о сотрудниках
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Ключевое поле идентификатор Автоинкримент
        /// </summary>
        [DbProp]
        public int Id { get; set; }

        /// <summary>
        /// Фамилия сотрудника обязательное поле
        /// </summary>
        [DbProp]
        public string LastName { get; set; }

        /// <summary>
        /// Имя сотрудника обязательное поле
        /// </summary>
        [DbProp]
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        [DbProp]
        public string MiddleName { get; set; }

        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>
        [DbProp]
        public System.DateTime? DtBirth { get; set; }

        /// <summary>
        /// Табельный номер сотрудника обязательное поле
        /// </summary>
        [DbProp]
        public string TabNumber { get; set; }

        /// <summary>
        /// Дата приема на работу сотрудника, по умолчанию проставляется дата внесения записи о сотруднике
        /// </summary>
        [DbProp]
        public System.DateTime DtHire { get; set; }

        /// <summary>
        /// Пол сотрудника
        /// </summary>
        [DbProp]
        public string Gender { get; set; }

        /// <summary>
        /// Подразделение в котором числится сотрудник
        /// </summary>
        [DbProp]
        public int? DepartmentId { get; set; }

        /// <summary>
        /// Должность сотрудника
        /// </summary>
        [DbProp]
        public string Position { get; set; }

        /// <summary>
        /// Дополнительная информация о сотруднике
        /// </summary>
        [DbProp]
        public string Information { get; set; }

        /// <summary>
        /// Флаг показывающий что сотрудник действующий и не уволен
        /// </summary>
        [DbProp]
        public int? IsActive { get; set; }

    }
}
