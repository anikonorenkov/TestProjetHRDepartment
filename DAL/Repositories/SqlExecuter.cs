using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;

namespace DAL.Repositories
{
    public class SqlExecuter
    {
        /// <summary>
        /// Add Edit Delete
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="obj"></param>
        public void Execute(string sql, object[] obj)
        {

            using (SqlConnection conn = new SqlConnection(DataManager.sqlConnection))
            {

                var command = new SqlCommand(sql, conn);


                var propNames = new List<string>();
                var propValues = new List<object>();

                for (int i = 0; i < obj.Count(); i++)
                {

                    if (i % 2 == 0)
                    {
                        var nameParametr = (string)obj[i];
                        propNames.Add(nameParametr);
                    }
                    else
                    {
                        var valueParametr = obj[i];
                        propValues.Add(valueParametr);
                    }
                }
                for (int i = 0; i < obj.Count() / 2; i++)
                {
                    var nameParametr = propNames[i];
                    var valueParametr = propValues[i];
                    command.Parameters.AddWithValue(nameParametr, valueParametr);
                }

                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

            }

        }

        /// <summary>
        /// GetAll  Переделать что бы метод не был привязан к Department
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Execute(string sql, string tableName)
        {
            using (SqlConnection conn = new SqlConnection(DataManager.sqlConnection))
            {
                var command = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable(tableName);
                sqlDataAdapter.Fill(dataTable);
                conn.Close();

                return dataTable;
            }
        }

        /// <summary>
        /// GetById возвращение одной записи по полученному Id
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="obj"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable Execute(string sql, object[] obj, string tableName)
        {
            using (SqlConnection conn = new SqlConnection(DataManager.sqlConnection))
            {
                var command = new SqlCommand(sql, conn);
                var nameParametr = (string)obj[0];
                var valueParametr = obj[1];
                command.Parameters.AddWithValue(nameParametr, valueParametr);

                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable(tableName);
                sqlDataAdapter.Fill(dataTable);
                conn.Close();

                return dataTable;
            }
        }

    }
}
