using Manage_Building.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Building.controller
{
    class SessionController
    {
        private readonly ConnectorClass dbConnection;

        public SessionController()
        {
            this.dbConnection = new ConnectorClass();
        }


        public List<Lecturer> getAllLecturers()
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());
            List<Lecturer> lecturers = new List<Lecturer>();

            cmd.CommandText = @"SELECT Id , name FROM [dbo].[lecturer]";

            SqlDataReader reader = dbConnection.queryData(cmd);

            while (reader.Read())
            {
                Lecturer lecturer = new Lecturer()
                {
                    Id = reader.GetInt32(0),
                    name = reader.GetString(1),

                };

                lecturers.Add(lecturer);
            }
            dbConnection.CloseConnection();

            return lecturers;
        }
    }
}
