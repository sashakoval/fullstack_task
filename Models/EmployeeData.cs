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

        public bool IsEmpCorrect(Employee emp)
        {
            if (!String.IsNullOrEmpty(emp.FirstName) &&
                !String.IsNullOrEmpty(emp.FirstName) &&
                emp.TaxId != 0 &&
                !String.IsNullOrEmpty(emp.PhoneNumber) &&
                !String.IsNullOrEmpty(emp.Sex))
            {
                if (!emp.FirstName.All(char.IsDigit) && !emp.LastName.All(char.IsDigit) && !emp.Sex.All(char.IsDigit) && emp.PhoneNumber.All(char.IsDigit))
                {
                    return true;
                } else
                {
                    return false;
                }
                    
            } else {
                return false;
            }
        }
        
    }
}
