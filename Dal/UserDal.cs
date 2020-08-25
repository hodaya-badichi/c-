using System;
using System.Linq;
namespace Dal
{
    public class UserDal
    {
        public static Users Login(string id,string ps)
        {
            try
            {
                using (TravelsProjectEntities db = new TravelsProjectEntities())
                {
                    Users us = db.Users.Where(u => u.UserId == id && u.UserPassword == ps).FirstOrDefault();
                    
                    if(us!=null)
                    return us;
                    return null;    
                }
            }
            catch(Exception e)
            {
                return null;
            }
            
        }

        public static bool Register(Users u)
        {
            try
            {
                using (TravelsProjectEntities db = new TravelsProjectEntities())
                {

                    db.Users.Add(u);
                    try {db.SaveChanges();     }
                          catch(Exception ee)
                    {
                        return false;
                    }    
                     return true;
                }
                
            }
            catch(Exception e)
            {
                return false;
            }
            
        }
    }
}