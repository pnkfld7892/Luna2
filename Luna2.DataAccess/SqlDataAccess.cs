using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Luna2.DataAccess.AppConfig;

namespace Luna2.DataAccess
{
    public class SqlDataAccess : IDisposable
    {
        private AppConfig.AppConfiguation _appConfig = new AppConfiguation();
        //TODO: Actually Implement Dispose on SQL Data Access
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //get Connection string from configuration
        public string GetConnectionString()
        {
            return _appConfig.ConnectionString;
        }

        public List<T> LoadData<T,U> (string storedProcedure, U parameters)
        {
            string connectionString = GetConnectionString();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }
    }
}
