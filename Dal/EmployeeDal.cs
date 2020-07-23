using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
  public  class EmployeeDal
    {
        public static EmployeeTable Login(string id, string ps)
        {
            try
            {
                using (taxisEntities db = new taxisEntities())
                {
                    EmployeeTable es = db.EmployeeTables.Where(e => e.EmployeeCode==id && e.EmployeePassword==ps ).FirstOrDefault();

                    if (es != null)
                        return es;
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static bool Exist(string id)
        {
            try
            {
                using (taxisEntities db = new taxisEntities())
                {
                    EmployeeTable es = db.EmployeeTables.Where(e => e.EmployeeCode == id).FirstOrDefault();
                    return es != null;                    
                }
            }
            catch (Exception e)
            {
                return false;
            }

        }
        public static bool AddNew(EmployeeTable emp)
        {
            try
            {
                using (taxisEntities db = new taxisEntities())
                {

                    db.EmployeeTables.Add(emp);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
