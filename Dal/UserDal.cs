using System;
using System.Linq;
namespace Dal
{
    public class UserDal
    {
        public static UsersTable Login(string id,string ps)
        {
            try
            {
                using (taxisEntities db = new taxisEntities())
                {
                    UsersTable us = db.UsersTables.Where(u => u.UserCode == id && u.UserPassword == ps).FirstOrDefault();
                    
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

        public static bool AddNew(UsersTable u)
        {
            try
            {
                using (taxisEntities db = new taxisEntities())
                {

                    db.UsersTables.Add(u);
                    db.SaveChanges();
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