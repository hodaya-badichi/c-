using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ReqeustDal
    {
        public static Requests[] GetRequests()
        {
            try
            {
                using (TravelsProjectEntities db = new TravelsProjectEntities())
                {
                    Requests[] requests = db.Requests.ToArray();
                    return requests;
                }
            }
            catch (Exception e)
            {
                return null;
            }

        }
    }
}
