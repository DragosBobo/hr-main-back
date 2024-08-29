using HrAppDataAcces.DTOs.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrAppBusiness.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        Task<SalariatPostDto> CreateEmployee(SalariatPostDto employee);
        Task<List<SalariatDto>> GetEmployees();
    }
}
