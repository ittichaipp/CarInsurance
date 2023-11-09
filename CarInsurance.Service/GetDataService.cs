using CarInsurance.Model;
using CarInsurance.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CarInsurance.Service
{
    public class GetDataService : IGetDataService
    {
        public void GetData(GetDataForm getForm)
        {
            string[] lines = File.ReadAllLines(@"C:\Project\Test\CarInsurance\customer_20211202.txt");
            foreach (String item in lines){
                string[] split = item.Split('|');
                
            }


            
        }
    }
}
