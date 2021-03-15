using RestApiCrudDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCrudDemo.EmployeeData
{
	public interface IEmployeeData
	{
		List<Employee>GetEmployees();
		Employee GetEmployee(Guid id);
		Employee AddEmployee(Employee employee);
		void DeleteEmployee(Employee employee);
		Employee EditEmployee(Employee employee);
	}
}
