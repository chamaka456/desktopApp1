using Manage_Building.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Building.controller
{
    public class BuildingController
    {
        private readonly ConnectorClass dbConnection;

        public BuildingController()
        {
            dbConnection = new ConnectorClass();
        }

        public int AddNewBuilding(Building building)
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"INSERT INTO  [dbo].[building]([buildng_name] , [roomsCount]) output INSERTED.ID
                                    VALUES(@name , @count)";

            cmd.Parameters.Add(new SqlParameter("@name", building.name));
            cmd.Parameters.Add(new SqlParameter("@count", building.RoomsCount));
            return dbConnection.executequery(cmd);
           

        }
    }
}
