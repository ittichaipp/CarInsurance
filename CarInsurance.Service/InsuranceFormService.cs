using CarInsurance.Dao;
using CarInsurance.Model;
using CarInsurance.Service.IService;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarInsurance.Service
{
    public class InsuranceFormService : IInsuranceFormService
    {
        public void CreateInsuranceForm(InsuranceForm insForm)
        {
            DatabaseConnection conn = new DatabaseConnection();
           
            try
            {
                InsuranceCalculateService totalCalculateService = new InsuranceCalculateService();
                insForm.Total = totalCalculateService.Calculate(insForm.TypeCar,insForm.Level);

                OracleConnection oraConn = conn.GetOracleConnection();
                InsuranceFormDao insFormDao = new InsuranceFormDao();
                insFormDao.CreateInsuranceForm(oraConn ,insForm);

            }
            
            catch( Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.CloseOracleConnection();
               
            }
        }

        public void DeleteInsuranceForm(int id)
        {
            DatabaseConnection conn = new DatabaseConnection();
            try
            {
                OracleConnection oraConn = conn.GetOracleConnection();
                InsuranceFormDao insFormDao = new InsuranceFormDao();
                insFormDao.DeleteInsuranceForm(oraConn, id);

            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.CloseOracleConnection();

            }
        }

        public InsuranceForm GetInsuranceForm(int id)
        {   
            DatabaseConnection conn = new DatabaseConnection();
            InsuranceForm insForm = new InsuranceForm();
            try{

                OracleConnection oraConn = conn.GetOracleConnection();
                InsuranceFormDao insFormDao = new InsuranceFormDao();
                insForm = insFormDao.RetrieveInsuranceForm(oraConn,id);
            }
            catch (Exception ex){
            
                throw ex;
            }
            finally
            {
                conn.CloseOracleConnection();
            }
            return insForm;
        }

        public List<InsuranceForm> GetInsuranceForms()
        {
            DatabaseConnection conn = new DatabaseConnection();
            List<InsuranceForm> insForms = new List<InsuranceForm>();

            try
            {

                OracleConnection oraConn = conn.GetOracleConnection();
                InsuranceFormDao insFormDao = new InsuranceFormDao();
                insForms = insFormDao.RetrieveInsuranceForms(oraConn);
                
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.CloseOracleConnection();
            }
            return insForms;
        }

        public void UpdateInsuranceForm(InsuranceForm insForm)
        {
            DatabaseConnection conn = new DatabaseConnection();

            try
            {
                InsuranceCalculateService totalCalculateService = new InsuranceCalculateService();
                insForm.Total = totalCalculateService.Calculate(insForm.TypeCar, insForm.Level);

                OracleConnection oraConn = conn.GetOracleConnection();
                InsuranceFormDao insFormDao = new InsuranceFormDao();
                insFormDao.UpdateInsuranceForm(oraConn, insForm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.CloseOracleConnection();
            }
            
        }
    }
}
