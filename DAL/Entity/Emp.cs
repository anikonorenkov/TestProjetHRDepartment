using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public partial class Emploee
    {
        ///



        public int? DeptId { get; set; }

        private Department _department = null;

        public Department Department
        {
            get
            {
                if (this.DeptId == null)
                    return null;

                if (_department != null)
                    if (_department.Id != this.DeptId)
                        _department = null;

                if (_department == null)
                    _department = DataManager.Instance.Departments.GetById(this.DeptId.Value);

                return _department;
            }
        }


        public string DeptName
        {
            get
            {
                if (this.Department == null)
                    return "-";

                return this.Department.Name;
            }
        }

    }

}

public class Department
{
    public int Id { get; set; }

    public string Name { get; set; }
}




