using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRDepartment.BL
{
    public class MainPresenter
    {
        private readonly IXtraForm _view;
        private readonly IMessageService _messageService;


        public MainPresenter(IXtraForm view, IMessageService servece)
        {
            _view = view;
            _messageService = servece;

            _view.AddDepartmentBtnClick += _view_AddDepartmentClick;
            _view.EditDepartmentBtnClick += _view_EditDepartmentClick;
            _view.DeleteDepartmentBtnClick += _view_DeleteDepartmentClick;
            _view.AddEmployeeBtnClick += _view_AddEmployeeClick;
            _view.EditEmployeeBtnClick += _view_EditEmployeeClick;
            _view.DeleteEmployeeBtnClick += _view_DeleteEmployeeClick;
        }

        private void _view_DeleteEmployeeClick(object sender, EventArgs e)
        {
            try
            {
                var employee = DataManager.Instance.Employees.GetById(_view.EmployeeId);
                DataManager.Instance.Employees.Delete(employee.Id);
                _view.LoadEmployeeGrCn();
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
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
                // ExecuteEmployeeForm(employee);
                {
                    _view.LoadEmployeeGrCn();
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_AddEmployeeClick(object sender, EventArgs e)
        {
            try
            {
                Employee employee = null;
                if (fmEditEmployee.Execute(employee))
               
                {
                    _view.LoadEmployeeGrCn();
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
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
                    _view.LoadDepartmentTrL();
                }
                else
                    _messageService.ShowExclamation("В подразделении еще есть сотрудники нужно сначала их удалить.");
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_EditDepartmentClick(object sender, EventArgs e)
        {
            try
            {
                var department = DataManager.Instance.Departments.GetById(_view.DepartmentCurrentId);

                if (fmEditDepartment.Execute(department))
                {
                    _view.LoadDepartmentTrL();
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }

        private void _view_AddDepartmentClick(object sender, EventArgs e)
        {
            try
            {
                DAL.Department department = null;

                if (fmEditDepartment.Execute(department))
                {
                    _view.LoadDepartmentTrL();
                }
            }
            catch (Exception ex)
            {
                _messageService.ShowError(ex.Message);
            }
        }
    }
}
