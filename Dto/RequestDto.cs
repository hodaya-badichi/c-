using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class RequestDto
    {
        public int RequestCode { get; set; }
        public string UserId { get; set; }
        public int? TravelCode { get; set; }
        public string SourceAddress { get; set; }
        public string DestinationAddress { get; set; }
        public System.DateTime Date { get; set; }
        public string Frequency { get; set; }
        public string Summarry { get; set; }

        public RequestDto(Dal.Requests r)
        {
            RequestCode = r.RequestCode;
            UserId = r.UserId;
            TravelCode = r.TravelCode;
            SourceAddress = r.SourceAddress;
            DestinationAddress = r.DestinationAddress;
            Date = r.Date;
            Frequency = r.Frequency;
            Summarry = r.Summarry;
        }
        public static Dal.Requests ToDal(Dto.RequestDto r)
        {
            Dal.Requests requests = new Dal.Requests
            {
                RequestCode = r.RequestCode,
                UserId = r.UserId,
                TravelCode = r.TravelCode,
                SourceAddress = r.SourceAddress,
                DestinationAddress = r.DestinationAddress,
                Date = r.Date,
                Frequency = r.Frequency,
                Summarry = r.Summarry,
            };
            return requests;
        }
        
    }

}
