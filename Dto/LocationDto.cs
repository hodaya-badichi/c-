using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    class LocationDto
    {
        public int LocationCode { get; set; }
        public string LocationName { get; set; }
        public LocationDto(Dal.LocationTable location)
        {
            this.LocationCode = location.LocationCode;
            this.LocationName = location.LocationName;
        }
        public Dal.LocationTable ToDal(Dto.LocationDto location)
        {
            return new Dal.LocationTable
            {
                LocationCode = location.LocationCode,
                LocationName = location.LocationName
            };
        }
    }
}
