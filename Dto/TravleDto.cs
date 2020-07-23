using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class TravleDto
    {
        public int TravleCode { get; set; }
        public string EmployeeCode { get; set; }
        public Nullable<int> LocationCode { get; set; }
        public Nullable<System.DateTime> TravleDate { get; set; }
        public TravleDto(Dal.TravleTable travle)
        {
            this.EmployeeCode = travle.EmployeeCode;
            this.TravleCode = travle.TravleCode;
            this.LocationCode = travle.LocationCode;
            this.TravleDate = travle.TravleDate;

        }
        public Dal.TravleTable ToDal(Dto.TravleDto travle)
        {
            return new Dal.TravleTable
            {
                EmployeeCode = travle.EmployeeCode,
                TravleCode = travle.TravleCode,
                LocationCode = travle.LocationCode,
                TravleDate = travle.TravleDate
            };
        }
    }
}
