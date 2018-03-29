
namespace DAL
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Справочник подразделения
    /// </summary>
    public class Department
    {
        public Department()
        {

        }

        /// <summary>
        /// Ключевое поле идентификатор автоинкримент
        /// </summary>
        [DbProp]
        public int Id { get; set; }

        /// <summary>
        /// Название подразделение обязательное поле
        /// </summary>
        [DbProp]
        public string Name { get; set; }

        /// <summary>
        /// Код подразделения обязательное поле
        /// </summary>
        [DbProp]
        public string Code { get; set; }

        /// <summary>
        /// Дата создания подразделения , по умолчанию берётся текущая дата при добавлении нового подразделения
        /// </summary>
        [DbProp]
        public System.DateTime? DtCreated { get; set; }

        /// <summary>
        ///Идентификатор родительского подразделения
        /// </summary>
        [DbProp]
        public int? ParentId { get; set; }

        /// <summary>
        /// Флаг активности подразделения по умолчанию ставится в True
        /// </summary>
        [DbProp]
        public bool? IsActive { get; set; }

        



    }
}
