using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class TravelsDto
    {
        public int TravleCode { get; set; }
        public string UserId { get; set; }
        public System.DateTime Date { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
        public int NumOfPassengers { get; set; }
        public TravelsDto(Dal.Travels t)
        {
            TravleCode = t.TravleCode;
            UserId = t.UserId;
            Date = t.Date;
            SourceAddress = t.SourceAddress;
            DestinationAddress = t.DestinationAddress;
            NumOfPassengers = t.NumOfPassengers;
        }
        public static Dal.Travels ToDal(Dto.TravelsDto t)
        {
            Dal.Travels travels = new Dal.Travels
            {
                TravleCode = t.TravleCode,
                UserId = t.UserId,
                Date = t.Date,
                SourceAddress = t.SourceAddress,
                DestinationAddress = t.DestinationAddress,
                NumOfPassengers = t.NumOfPassengers
            };
            return travels;
        }
    }
}
