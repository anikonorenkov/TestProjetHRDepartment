using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDepartment
{
    public class MainPresenter
    {
        private readonly IXtraForm _view;

        public MainPresenter(IXtraForm view)
        {
            _view = view;

            _view.SBAddDepartmentClick += _view_AddDepartmentClick;
            _view.SBEditDepartmentClick += _view_EditDepartmentClick;
            _view.SBDeleteDepartmentClick += _view_DeleteDepartmentClick;
            _view.SBAddEmployeeClick += _view_AddEmployeeClick;
            _view.SBEditEmployeeClick += _view_EditEmployeeClick;
            _view.SBDeleteEmployeeClick += _view_DeleteEmployeeClick;
        }

        private void _view_DeleteEmployeeClick(object sender, EventArgs e)
        {

            try
            {
                var employee = DataManager.Instance.Employees.GetById(_view.EmployeeId);
                DataManager.Instance.Employees.Delete(employee.Id);
                _view.GRLoadEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _view_EditEmployeeClick(object sender, EventArgs e)
        {
            try
            {

                if (_view.SelectedRowsCount)
                    return;

                var employee = DataManager.Instance.Employees.GetById(_view.EmployeeId);

                if (fmEditEmployee.Execute(employee))
                {
                    _view.GRLoadEmployee();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _view_AddEmployeeClick(object sender, EventArgs e)
        {
            try
            {
                Employee employee = null;

                if (fmEditEmployee.Execute(employee))
                {
                    _view.GRLoadEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void _view_DeleteDepartmentClick(object sender, EventArgs e)
        {

            try
            {

                if (!_view.IsExistsEmployee)
                {
                    var department = DataManager.Instance.Departments.GetById(_view.DepartmentCurrentId);
                    DataManager.Instance.Departments.Delete(department.Id);
                    _view.TLLoadDepartment();
                }
                else
                    MessageBox.Show("В подразделении еще есть сотрудники нужно сначала их удалить.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _view_EditDepartmentClick(object sender, EventArgs e)
        {

            try
            {
                var department = DataManager.Instance.Departments.GetById(_view.DepartmentCurrentId);

                if (xfmEditDepartment.Execute(department))
                {
                    _view.TLLoadDepartment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void _view_AddDepartmentClick(object sender, EventArgs e)
        {

            try
            {
                DAL.Department department = null;

                if (xfmEditDepartment.Execute(department))
                {
                    _view.TLLoadDepartment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
