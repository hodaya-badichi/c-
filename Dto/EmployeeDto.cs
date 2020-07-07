using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class EmployeeDto
    {
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeAdress { get; set; }
        public string EmployeePhoneNumber { get; set; }
        public string EmployeeEmail { get; set; }
        public EmployeeDto(Dal.EmployeeTable employee)
        {
            this.EmployeeCode = employee.EmployeeCode;
            this.EmployeeName = employee.EmployeeName;
            this.EmployeePassword = employee.EmployeePassword;
            this.EmployeeAdress = employee.EmployeeAdress;
            this.EmployeePhoneNumber = employee.EmployeePhoneNumber;
            this.EmployeeEmail = employee.EmployeeEmail;
        }
        public Dal.EmployeeTable ToDal(Dto.EmployeeDto employee)
        {
            return new Dal.EmployeeTable
            {
                EmployeeCode = employee.EmployeeCode,
                EmployeeName = employee.EmployeeName,
                EmployeePassword = employee.EmployeePassword,
                EmployeeAdress = employee.EmployeeAdress,
                EmployeePhoneNumber = employee.EmployeePhoneNumber,
                EmployeeEmail = employee.EmployeeEmail
            };
        }
    }
}
