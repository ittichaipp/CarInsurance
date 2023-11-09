using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Service.IService
{
    public interface IInsuranceCalculateService
    {
        public int Calculate(String typeCar, String level);
    }
}
