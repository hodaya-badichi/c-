using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto;
using Dal;
namespace Bl
{
    public class ReqeustBl
    {
        public static RequestDto[] GetRequests()
        {
            Requests[] requests = ReqeustDal.GetRequests();
            RequestDto[] requestsDto = new RequestDto[requests.Length];
            for (int i = 0; i < requests.Length; i++)
            {
                requestsDto[i] = new RequestDto(requests[i]);
            }
            return requestsDto;
        }
    }
}
