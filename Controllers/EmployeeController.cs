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
            empData.GetById(id);
            return new JsonResult(empData.GetById(id));
        }


        [HttpPost]
        public JsonResult Post(Employee emp)
        {         
                empData.AddEmployee(emp);
                return new JsonResult(empData.GetAll());
        }

        [HttpPut("{id}")]
        public JsonResult Put(uint id, Employee emp)
        {
            empData.Update(id, emp);
            return new JsonResult(empData.Update(id, emp));
        }
  
        [HttpDelete]
        public JsonResult DeleteAll()
        {
            empData.DeleteAll();
            return new JsonResult("Succsessfully cleared.");
        }

        [HttpDelete("{id}")]
        public JsonResult DeleteById(int id)
        {
            empData.DeleteById(id);
            return new JsonResult($"Deleted by ID {id}");
        }

    }
}
