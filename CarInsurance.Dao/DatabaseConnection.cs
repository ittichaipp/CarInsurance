using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance.Dao
{
    public class DatabaseConnection
    {
        OracleConnection _oracleConn = new OracleConnection();
        String _connectionString = "User Id=COREINS;Password=Passw0rd;Data Source=192.168.14.2:1542/COREINS12DEV;";
        public OracleConnection GetOracleConnection()
        {
            try
            {
                if (_oracleConn.State == System.Data.ConnectionState.Open)
                {
                    _oracleConn.Close();
                }

                _oracleConn = new OracleConnection(_connectionString);
                _oracleConn.Open();
            }
            catch 
            {
                throw;
            }


            return _oracleConn;
        }
        public void CloseOracleConnection()
        {
            try
            {
                _oracleConn.Close();
                _oracleConn.Dispose();
            }
            catch 
            {
                throw;
            }
        }

    }
}
