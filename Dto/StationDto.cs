using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    class StationDto
    {
        public int StationCode { get; set; }
        public string StationName { get; set; }
        public StationDto(Dal.StationTable station)
        {
            this.StationCode = station.StationCode;
            this.StationName = station.StationName;
        }
        public Dal.StationTable ToDal(Dto.StationDto station)
        {
            return new Dal.StationTable
            {
                StationCode = station.StationCode,
                StationName = station.StationName
            };
        }
    }
}
