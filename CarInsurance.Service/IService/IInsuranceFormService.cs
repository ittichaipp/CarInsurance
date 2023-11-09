
using CarInsurance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Service.IService
{
    public interface IInsuranceFormService
    {
        void CreateInsuranceForm(InsuranceForm insForm);
        List<InsuranceForm> GetInsuranceForms();
        InsuranceForm GetInsuranceForm(int id);

        void DeleteInsuranceForm(int id);

        void UpdateInsuranceForm(InsuranceForm insForm);


        
    }
}
