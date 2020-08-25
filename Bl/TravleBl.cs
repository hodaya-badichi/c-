using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
namespace Bl
{
    public class TravleBl
    {
<<<<<<< HEAD
        public static List<TravelsDto> TrvlesOfEmployee(string id)
        {
            
            //bool b=  Dal.EmployeeDal.Exist(id);
            //if (b)
            //{
            //    List<Travels> travlesOfEmpDal = Dal.TravleDal.TrvlesOfEmployee(id);
            //    List<TravelsDto> travlesOfEmpDto = new List<TravelsDto>();
            //    foreach (var item in travlesOfEmpDal)
            //    {
            //        travlesOfEmpDto.Add(new TravelsDto(item));
            //    }
            //    return travlesOfEmpDto;
            //}
=======
        public static List<TravleDto> TrvlesOfEmployee(string id)
        {
            
            bool b=  Dal.EmployeeDal.Exist(id);
            if (b)
            {
                List<TravleTable> travlesOfEmpDal = Dal.TravleDal.TrvlesOfEmployee(id);
                List<TravleDto> travlesOfEmpDto = new List<TravleDto>();
                foreach (var item in travlesOfEmpDal)
                {
                    travlesOfEmpDto.Add(new TravleDto(item));
                }
                return travlesOfEmpDto;
            }
>>>>>>> 318f8ce07cf3a0e9e0cded04481984ce18c09d89

            return null;
        }
    }
}
