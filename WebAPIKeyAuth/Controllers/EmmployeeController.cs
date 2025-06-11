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
        /// <summary>
        /// Adds a new employee record to the system.
        /// </summary>
        /// <param name="employee">The employee object containing details to be added.
        /// This typically includes properties like Id and Name.</param>
        /// <returns>
        /// An <see cref="IHttpActionResult"/> indicating the outcome of the operation.
        /// On successful addition, returns an <see cref="OkResult"/> with a confirmation message
        /// including the ID and Name of the added employee.
        /// </returns>
        [HttpPost]
        [Route("api/employee/add")]
        public IHttpActionResult AddEmployee([FromBody]Employee employee)
        {
            return Ok("Employee is added in the system, Employee: " + "ID: " + employee.Id.ToString() + ", Name: " + employee.Name);
        }
    }
}
