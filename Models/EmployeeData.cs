using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fullstack_task.Models
{
    public class EmployeeData
    {
        List<Employee> empList;



        public EmployeeData()
        {
            empList = new List<Employee>();
        }

        public void AddEmployee(Employee emp)
        {
            if (!empList.Any())
            {
                emp.EmployeeId = 0;
                empList.Add(emp);
            } else
            {
                emp.EmployeeId = empList[empList.Count - 1].EmployeeId + 1;
                empList.Add(emp);
            }
        }

        public List<Employee> GetAll() => empList;

        public Employee Update(uint id, Employee emp)
        {
            emp.EmployeeId = id;
            return empList[(int)id] = emp;
        }
            
        
        public void DeleteById(int id)
        {
            empList.RemoveAt(id);
        }
     

        public Employee GetById(int id) => empList[id];

        public void DeleteAll() => empList.Clear();
        
    }
}
