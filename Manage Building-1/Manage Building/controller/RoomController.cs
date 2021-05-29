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


        public List<Room> GetAllRooms()
        {
            List<Room> roomData = new List<Room>();
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"select [room_id] , [room_name],[building_id],[capcity],[room_type] from [dbo].[building]";
            SqlDataReader reader = dbConnection.queryData(cmd);
            while (reader.Read())
            {
                Room room = new Room()
                {
                    Id = reader.GetInt32(0),
                    name = reader.GetString(1),
                    Capacity = reader.GetInt32(2),
                    type = reader.GetInt32(2),
                    BuildingId = reader.GetInt32(2)
                };

                roomData.Add(room);
            }

            return roomData;
        }
    }
}
