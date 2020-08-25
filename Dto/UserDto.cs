using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class UserDto
    {

        public string UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserPhone { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public bool IsDriver { get; set; }
        public UserDto()
        {

        }  
        public UserDto(Dal.Users user)
        {
            this.UserId = user.UserId;            
            this.UserMail = user.UserMail;
            this.UserFirstName = user.UserFirstName;
            this.UserLastName = UserLastName;
            this.UserPassword = user.UserPassword;
            this.UserPhone = user.UserPhone;
            this.IsDriver = user.IsDriver;
        }
        public static Dal.Users  ToDal(Dto.UserDto user)
        {
            Dal.Users u = new Dal.Users
            {
                UserId = user.UserId,
                UserFirstName = user.UserFirstName,
                UserLastName = user.UserLastName,
                UserMail = user.UserMail,
                UserPassword = user.UserPassword,
                UserPhone = user.UserPhone,
                IsDriver = user.IsDriver
               
            };
            return u;
        }
    }
}
