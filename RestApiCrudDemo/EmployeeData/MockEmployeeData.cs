using RestApiCrudDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCrudDemo.EmployeeData
{
	public class MockEmployeeData : IEmployeeData
	{
		public Employee AddEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public void DeleteEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public Employee EditEmployee(Employee employee)
		{
			throw new NotImplementedException();
		}

		public Employee GetEmployee(Guid id)
		{
			throw new NotImplementedException();
		}

		public List<Employee> GetEmployees()
		{
			throw new NotImplementedException();
		}
	}
}
