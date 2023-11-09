using CarInsurance.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Dao.IDao
{
    public interface IInsuranceFormDao
    {
        void CreateInsuranceForm(OracleConnection conn, InsuranceForm insForm);
        List<InsuranceForm> RetrieveInsuranceForms(OracleConnection conn);
        InsuranceForm RetrieveInsuranceForm(OracleConnection conn , int id);

        void DeleteInsuranceForm(OracleConnection conn, int id);

        void UpdateInsuranceForm(OracleConnection conn, InsuranceForm insForm);
    }
}
