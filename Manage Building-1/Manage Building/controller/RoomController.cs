using System;
using Manage_Building.model;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Building.controller
{
    public class RoomController
    {
        private readonly ConnectorClass dbConnection;

        public RoomController()
        {
            dbConnection = new ConnectorClass();
        }

        public int AddNewRoom(Room room)
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"INSERT INTO  [dbo].[room]([room_name] , [building_id] , [capcity] , [room_type]) output INSERTED.ID
                                    VALUES(@name , @building , @capcity, @type)";

            cmd.Parameters.Add(new SqlParameter("@name", room.name));
            cmd.Parameters.Add(new SqlParameter("@building", room.BuildingId));
            cmd.Parameters.Add(new SqlParameter("@capcity", room.Capacity));
            cmd.Parameters.Add(new SqlParameter("@type", room.type));
            return dbConnection.executequery(cmd);

        }
    }
}
