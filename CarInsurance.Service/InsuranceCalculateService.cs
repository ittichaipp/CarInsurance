using CarInsurance.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Service
{
    public class InsuranceCalculateService : IInsuranceCalculateService
    {
        public int Calculate(string typeCar, string level)
        {
            int cal = 0;
            
            if (typeCar == "รถมอเตอร์ไซค์" && level == "ชั้นที่ 1")
            {
                cal = 6000;
            }
            else if (typeCar == "รถมอเตอร์ไซค์" && level == "ชั้นที่ 2")
            {
                cal = 4000;
            }
            else if (typeCar == "รถมอเตอร์ไซค์" && level == "ชั้นที่ 3")
            {
                cal = 2000;
            }
            else if (typeCar == "รถเก๋ง" && level == "ชั้นที่ 1")
            {
                cal = 15000;
            }
            else if (typeCar == "รถเก๋ง" && level == "ชั้นที่ 2")
            {
                cal = 12000;
            }
            else if (typeCar == "รถเก๋ง" && level == "ชั้นที่ 3")
            {
                cal = 8000;
            }
            else if (typeCar == "รถกระบะ" && level == "ชั้นที่ 1")
            {
                cal = 20000;
            }
            else if (typeCar == "รถกระบะ" && level == "ชั้นที่ 2")
            {
                cal = 15000;
            }
            else if (typeCar == "รถกระบะ" && level == "ชั้นที่ 3")
            {
                cal = 10000;
            }



            return cal;
        }
        
    }
}
