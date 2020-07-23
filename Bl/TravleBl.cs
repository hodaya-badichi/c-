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

            return null;
        }
    }
}
