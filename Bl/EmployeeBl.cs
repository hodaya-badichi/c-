using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
namespace Bl
{
   public class EmployeeBl
    {
        public static EmployeeDto Login(string id, string password)
        {
            EmployeeTable e = Dal.EmployeeDal.Login(id, password);
            if (e != null)
            {
                EmployeeDto emp = new EmployeeDto(e);

                return emp;
            }

            return null;
        }
        public static bool AddNew(EmployeeDto emp)
        {           
            EmployeeTable e = EmployeeDto.ToDal(emp);
            bool b = Dal.EmployeeDal.AddNew(e);
            return b;

        }
    }
}
