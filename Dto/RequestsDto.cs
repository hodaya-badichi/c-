using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dto
{
    class RequestsDto
    {
        public int RequestsCode { get; set; }
        public Nullable<int> LocationCode { get; set; }
        public Nullable<System.DateTime> RequestsDate { get; set; }
        public string Dedicated { get; set; }
        public string Frequency { get; set; }
        public RequestsDto(Dal.RequestsTable request)
        {
            this.RequestsCode = request.RequestsCode;
            this.LocationCode = request.LocationCode;
            this.RequestsDate = request.RequestsDate;
            this.Frequency = request.Frequency;
            this.Dedicated = request.Dedicated;
        }
        public Dal.RequestsTable ToDal(Dto.RequestsDto request)
        {
            return new Dal.RequestsTable
                {
                RequestsCode = request.RequestsCode,
                LocationCode = request.LocationCode,
                RequestsDate = request.RequestsDate,
                Frequency = request.Frequency,
                Dedicated = request.Dedicated,
            };              
        }
    }
}
