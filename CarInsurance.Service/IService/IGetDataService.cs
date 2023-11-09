using CarInsurance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Service.IService
{
    interface IGetDataService
    {
        void GetData(GetDataForm getForm);
    }
}
