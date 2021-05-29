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

        public List<Building> GetAllBuildings()
        {
            List<Building> buildingData = new List<Building>();
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"select [id] , [buildng_name],[roomsCount] from [dbo].[building]";            
            SqlDataReader reader =  dbConnection.queryData(cmd);
            while (reader.Read())
            {
                Building building = new Building()
                {
                    Id = reader.GetInt32(0),
                    name = reader.GetString(1),
                    RoomsCount = reader.GetInt32(2)
                };

                buildingData.Add(building);
            }

            return buildingData;
        }
    }
}
