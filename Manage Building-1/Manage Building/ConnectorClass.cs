using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Building
{
    class ConnectorClass
    {

        private readonly SqlConnection con;

        public ConnectorClass()
        {
            string connString = "Server=52.172.250.71;Database=AriyaDb;User Id=sa;Password=dj@innova;";
            this.con = new SqlConnection(connString);
        }

        public SqlConnection GetConnection()
        {
            return con;
        }

        public void OpenConection()
        {
            
            if (con != null && con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
                Console.WriteLine("db connected");
            }
        }


        public void CloseConnection()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

       
        public bool executequery(String Query)
        {
            try
            {
                OpenConection();
                SqlCommand cmd = new SqlCommand(Query, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }

        }

        /// <summary>
        /// excute the query and return the row count updated
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>
        public int excuteQueryRowcount(SqlCommand sqlCommand)
        {
            try
            {
                OpenConection();
                int updatedCount = sqlCommand.ExecuteNonQuery();
                CloseConnection();
                return updatedCount;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return 0;
            }
        }

            /// <summary>
            /// excute the query and return updated id
            /// </summary>
            /// <param name="sqlCommand"></param>
            /// <returns></returns>
        public int executequery(SqlCommand sqlCommand)
        {
            try
            {
                OpenConection();
               int id = (int) sqlCommand.ExecuteScalar();
                CloseConnection();
                return id;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public SqlDataReader queryData(SqlCommand sqlCommand)
        {
            try
            {
                OpenConection();
                SqlDataReader reader =  sqlCommand.ExecuteReader();
              //  CloseConnection();
                return reader;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ShowDataInGridView(string Query_)
        {
            SqlDataAdapter dr = new SqlDataAdapter(Query_, con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }


        public SqlDataReader DataReader(string Query_, String para1)
        {
            SqlCommand cmd = new SqlCommand(Query_, con);
            cmd.Parameters.AddWithValue("@building_name", para1);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        public SqlDataReader DataReader(string Query)
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }


        public int DataCount(string Tablename_ )
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM "+Tablename_, con);
       
            return (Int32)cmd.ExecuteScalar();
        }

    }
}
