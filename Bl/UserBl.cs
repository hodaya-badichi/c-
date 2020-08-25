using System;
using Dto;
using Dal;
namespace Bl
{
    public class UserBl
    {
        public static UserDto Login(string id, string password)
        {
            Users u = Dal.UserDal.Login(id, password);
            if (u != null)
            {
                UserDto user = new UserDto(u);
                return user;
            }

            return null;
        }
<<<<<<< HEAD
        public static bool Register(UserDto u)
        {          
            Users user = UserDto.ToDal(u);
            bool b=  Dal.UserDal.Register(user);
=======
        public static bool AddNew(UserDto u)
        {          
            UsersTable user = UserDto.ToDal(u);
            bool b=  Dal.UserDal.AddNew(user);
>>>>>>> 318f8ce07cf3a0e9e0cded04481984ce18c09d89
            return b;
  
        }

    }
}