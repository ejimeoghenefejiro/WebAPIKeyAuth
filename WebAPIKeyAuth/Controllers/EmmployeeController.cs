using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIKeyAuth.Models;

namespace WebAPIKeyAuth.Controllers
{
    
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]
        public IHttpActionResult GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name="Employee1", Designation="Manager" },
                 new Employee() {Id = 2, Name="Employee2", Designation="Supervisor" }
            };
            return Ok(employeeList);
        }
        [HttpPost]
        [Route("api/employee/add")]
        public IHttpActionResult AddEmployee([FromBody]Employee employee)
        {
            return Ok("Employee is added in the system, Employee: " + "ID: " + employee.Id.ToString() + ", Name: " + employee.Name);
        }
    }
}