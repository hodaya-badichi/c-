using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class TravleDal
    {
<<<<<<< HEAD
        public static List<Travels> TrvlesOfEmployee(string id)
        {
            try
            {
                List<Travels> t = new List<Travels>();
                using (TravelsProjectEntities db = new TravelsProjectEntities())
                {
                    foreach (var item in db.Travels)
                    {
                        if(item.UserId==id)
=======
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
>>>>>>> 318f8ce07cf3a0e9e0cded04481984ce18c09d89
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
