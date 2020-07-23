using System;
using Dto;
using Dal;
namespace Bl
{
    public class UserBl
    {
        public static UserDto Login(string id, string password)
        {
            UsersTable u = Dal.UserDal.Login(id, password);
            if (u != null)
            {
                UserDto user = new UserDto(u);
                return user;
            }

            return null;
        }
        public static bool AddNew(UserDto u)
        {          
            UsersTable user = UserDto.ToDal(u);
            bool b=  Dal.UserDal.AddNew(user);
            return b;
  
        }

    }
}