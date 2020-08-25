using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class TravleDal
    {
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
