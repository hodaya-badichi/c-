using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class UserDto
    {
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string UserAdress { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        public UserDto(Dal.UsersTable user)
        {
            this.UserCode = user.UserCode;
            this.UserAdress = user.UserAdress;
            this.UserEmail = user.UserEmail;
            this.UserName = user.UserName;
            this.UserPassword = user.UserPassword;
            this.UserPhoneNumber = user.UserPhoneNumber;
        }
        public static Dal.UsersTable  ToDal(Dto.UserDto user)
        {
            Dal.UsersTable u = new Dal.UsersTable
            {
                UserAdress = user.UserAdress,
                UserCode = user.UserCode,
                UserPhoneNumber = user.UserPhoneNumber,
                UserPassword = user.UserPassword,
                UserName=user.UserName,
                UserEmail=user.UserEmail
               
            };
            return u;
        }
    }
}
