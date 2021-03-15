using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiCrudDemo.EmployeeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCrudDemo.Controllers
{
	
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		private IEmployeeData _employeeData;
		public EmployeesController(IEmployeeData _employeeData) {
			_employeeData = _employeeData;
		}
		[HttpGet]
		[Route("api/[controller]")]
		public IActionResult GetEmployees() {
			return Ok(_employeeData.GetEmployees());
		}
	}
}
