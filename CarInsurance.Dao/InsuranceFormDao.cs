using CarInsurance.Dao.IDao;
using CarInsurance.Model;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Dao
{
    public class InsuranceFormDao : IInsuranceFormDao
    {
        public void CreateInsuranceForm(OracleConnection conn, InsuranceForm insForm)
        {
            try
            {
                string sql = @"Insert Into TEST_INSURANCE_FORM (TYPE_CAR, INS_LEVEL	, FIRST_NAME ,LAST_NAME	,TEL,EMAIL,TOLTAL) 
                               Values(
                                :TypeCar,:InsLevel,:FirstName,:LastName,:Tel,:Email,:Total
                               )";

                                  
                OracleCommand myCommand = new OracleCommand(sql, conn);

                List<OracleParameter> oraParams = new List<OracleParameter>();
                OracleParameter oraParam;

                oraParam = new OracleParameter("TypeCar", OracleDbType.Varchar2);
                oraParam.Value = insForm.TypeCar ;
                oraParams.Add(oraParam);

                oraParam = new OracleParameter("InsLevel", OracleDbType.Varchar2);
                oraParam.Value = insForm.Level;
                oraParams.Add(oraParam);

                oraParam = new OracleParameter("FirstName", OracleDbType.Varchar2);
                oraParam.Value = insForm.FirstName;
                oraParams.Add(oraParam);

                oraParam = new OracleParameter("LastName", OracleDbType.Varchar2);
                oraParam.Value = insForm.LastName;
                oraParams.Add(oraParam);

                oraParam = new OracleParameter("Tel", OracleDbType.Varchar2);
                oraParam.Value = insForm.Tel;
                oraParams.Add(oraParam);

                oraParam = new OracleParameter("Email", OracleDbType.Varchar2);
                oraParam.Value = insForm.Email;
                oraParams.Add(oraParam);

                oraParam = new OracleParameter("Total", OracleDbType.Int32);
                oraParam.Value = insForm.Total;
                oraParams.Add(oraParam);

                myCommand.Parameters.AddRange(oraParams.ToArray());

                myCommand.Prepare();
                myCommand.ExecuteNonQuery();
            }
            catch 
            {
                throw ;
            }
            //strSQL += " and buyer.buyer_code like :buyerCode ";
            //oraParam = new OracleParameter("buyerCode", OracleDbType.Varchar2);
            //oraParam.Value = "%" + buyerCode + "%";
            //oraParams.Add(oraParam);
        }

        public void DeleteInsuranceForm(OracleConnection conn, int id)
        {
            string sql = @"DELETE FROM TEST_INSURANCE_FORM  where ID=:id";

            //InsuranceForm insForm = new InsuranceForm();
            OracleCommand myCommand = new OracleCommand(sql, conn);

            List<OracleParameter> oraParams = new List<OracleParameter>();
            OracleParameter oraParam;

            oraParam = new OracleParameter("id", OracleDbType.Int32);
            oraParam.Value = id;
            oraParams.Add(oraParam);
            

            myCommand.Parameters.AddRange(oraParams.ToArray());
            myCommand.Prepare();
            myCommand.ExecuteNonQuery();
        }

        public InsuranceForm RetrieveInsuranceForm(OracleConnection conn, int id)
        {
            string sql = @"SELECT ID,TYPE_CAR, INS_LEVEL, FIRST_NAME ,LAST_NAME,TEL,EMAIL,TOLTAL FROM TEST_INSURANCE_FORM where ID=:id ";

            InsuranceForm insForm = new InsuranceForm();

            OracleCommand myCommand = new OracleCommand(sql, conn);
            
            List<OracleParameter> oraParams = new List<OracleParameter>();
            OracleParameter oraParam;

            oraParam = new OracleParameter("id", OracleDbType.Int32);
            oraParam.Value = id;
            oraParams.Add(oraParam);

            myCommand.Parameters.AddRange(oraParams.ToArray());

            myCommand.Prepare();


            OracleDataReader reader = myCommand.ExecuteReader();
            if (reader.Read())
            {
                insForm.Id = reader.GetInt32(0);
                insForm.TypeCar = reader.GetValue(1).ToString();
                insForm.Level = reader.GetValue(2).ToString();
                insForm.FirstName = reader.GetValue(3).ToString();
                insForm.LastName = reader.GetValue(4).ToString();
                insForm.Tel = reader.GetValue(5).ToString();
                insForm.Email = reader.GetValue(6).ToString();
                insForm.Total = reader.GetInt32(7);
            }
            return insForm;
           
        }

        public List<InsuranceForm> RetrieveInsuranceForms(OracleConnection conn)
        {
            string sql = @"SELECT ID,TYPE_CAR, INS_LEVEL, FIRST_NAME ,LAST_NAME,TEL,EMAIL,TOLTAL FROM TEST_INSURANCE_FORM ORDER BY ID desc ";
            List<InsuranceForm> insForms = new List<InsuranceForm>();
            
            OracleCommand myCommand = new OracleCommand(sql, conn);
            OracleDataReader reader = myCommand.ExecuteReader();

            InsuranceForm insForm;

            while (reader.Read())
            {
                insForm = new InsuranceForm();
                insForm.Id = reader.GetInt32(0);
                insForm.TypeCar = reader.GetValue(1).ToString();
                insForm.Level = reader.GetValue(2).ToString();
                insForm.FirstName = reader.GetValue(3).ToString();
                insForm.LastName = reader.GetValue(4).ToString();
                insForm.Tel = reader.GetValue(5).ToString();
                insForm.Email = reader.GetValue(6).ToString();
                insForm.Total = reader.GetInt32(7);
                insForms.Add(insForm);
            }
            
            return insForms;
        }

        public void UpdateInsuranceForm(OracleConnection conn, InsuranceForm insForm)
        {
            string sql = @"UPDATE TEST_INSURANCE_FORM SET TYPE_CAR=:TypeCar,INS_LEVEL=:InsLevel,FIRST_NAME=:FirstName,LAST_NAME=:LastName,TEL=:Tel,EMAIL=:Email,TOLTAL=:Total WHERE ID=:id";
            OracleCommand myCommand = new OracleCommand(sql, conn);

            List<OracleParameter> oraParams = new List<OracleParameter>();
            OracleParameter oraParam;

            oraParam = new OracleParameter("TypeCar", OracleDbType.Varchar2);
            oraParam.Value = insForm.TypeCar;
            oraParams.Add(oraParam);

            oraParam = new OracleParameter("InsLevel", OracleDbType.Varchar2);
            oraParam.Value = insForm.Level;
            oraParams.Add(oraParam);

            oraParam = new OracleParameter("FirstName", OracleDbType.Varchar2);
            oraParam.Value = insForm.FirstName;
            oraParams.Add(oraParam);

            oraParam = new OracleParameter("LastName", OracleDbType.Varchar2);
            oraParam.Value = insForm.LastName;
            oraParams.Add(oraParam);

            oraParam = new OracleParameter("Tel", OracleDbType.Varchar2);
            oraParam.Value = insForm.Tel;
            oraParams.Add(oraParam);

            oraParam = new OracleParameter("Email", OracleDbType.Varchar2);
            oraParam.Value = insForm.Email;
            oraParams.Add(oraParam);

            oraParam = new OracleParameter("Total", OracleDbType.Int32);
            oraParam.Value = insForm.Total;
            oraParams.Add(oraParam);

            oraParam = new OracleParameter("id", OracleDbType.Int32);
            oraParam.Value = insForm.Id;
            oraParams.Add(oraParam);

            myCommand.Parameters.AddRange(oraParams.ToArray());

            myCommand.Prepare();
            myCommand.ExecuteNonQuery();
        }
    }
}
