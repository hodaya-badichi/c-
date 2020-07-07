using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    class CarDto
    {
        public int CarCode { get; set; }
        public string EmployeeCode { get; set; }
        public int Places { get; set; }
        public string Dedicated { get; set; }

        public CarDto(Dal.CarTable car)
        {
            this.CarCode = car.CarCode;
            this.Dedicated = car.Dedicated;
            this.Places = car.Places;
            this.EmployeeCode = car.EmployeeCode;
        }
        public Dal.CarTable ToDal(Dto.CarDto car)
        {
            return new Dal.CarTable
            {
                CarCode = car.CarCode,
                Dedicated = car.Dedicated,
                Places = car.Places,
                EmployeeCode = car.EmployeeCode
            };
        }
    }
}
