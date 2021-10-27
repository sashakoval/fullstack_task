using fullstack_task.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fullstack_task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        
        static EmployeeData empData = new EmployeeData();
        
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(empData.GetAll());
        }

        [HttpGet("{id}")]
        public JsonResult GetbyId(int id)
        {
            try
            {
                empData.GetById(id);
                return new JsonResult(empData.GetById(id));
            }
            catch
            {
                return new JsonResult("ID doesn't exists");
            }

        }


        [HttpPost]
        public JsonResult Post(Employee emp)
        {
            try
            {
                if (empData.IsEmpCorrect(emp))
                {
                    empData.AddEmployee(emp);
                    return new JsonResult("Employee has been successfully added.");
                } else
                {
                    throw new Exception("Required fields must be filled");
                }
            }
            catch (Exception) when (empData.IsEmpCorrect(emp) == false)
            {
                return new JsonResult("Required fields must be filled");
            }
        }

        [HttpPut("{id}")]
        public JsonResult Put(uint id, Employee emp)
        {
            try
            {
                if (empData.IsEmpCorrect(emp))
                {
                    empData.Update(id, emp);
                    return new JsonResult("Employee has been successfully updated.");
                }
                else
                {
                    throw new Exception("Required fields must be filled");
                }
            }
            catch (Exception) when (empData.IsEmpCorrect(emp) == false)
            {
                return new JsonResult("Required fields must be filled");
            }
        }
  
        [HttpDelete]
        public JsonResult DeleteAll()
        {
            empData.DeleteAll();
            return new JsonResult("Employees have been successfully removed.");

        }

        [HttpDelete("{id}")]
        public JsonResult DeleteById(int id)
        {
            try
            {
                empData.DeleteById(id);
                return new JsonResult($"Employee has been successfully deleted by ID:{id}");
            }
            catch
            {
                return new JsonResult("ID doesn't exists");
            }
        }

    }
}
