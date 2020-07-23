using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class TravleDal
    {
        public static List<TravleTable> TrvlesOfEmployee(string id)
        {
            try
            {
                List<TravleTable> t = new List<TravleTable>();
                using (taxisEntities db = new taxisEntities())
                {
                    foreach (var item in db.TravleTables)
                    {
                        if(item.EmployeeCode==id)
                        {
                            t.Add(item);
                        }
                    }
                   
                    return t;
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }

}
