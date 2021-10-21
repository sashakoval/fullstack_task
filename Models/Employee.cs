using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fullstack_task.Models
{
    public class Employee
    {
        
        public Employee(uint empId, string firstName, string lastName, int taxId, string phoneNumber, string sex)
        {
            
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TaxId = taxId;
            this.PhoneNumber = phoneNumber;
            this.Sex = sex;
        }

        public uint EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TaxId { get; set; }
        public string PhoneNumber { get; set; }
        public string Sex { get; set; }
        public string BirthDate { get; set; }
        public string Hobbies { get; set; }
    }

    
}
