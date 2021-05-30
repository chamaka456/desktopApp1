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

            cmd.CommandText = @"INSERT INTO  [dbo].[room]([room_name] , [building_id] , [capcity] , [room_type]) output INSERTED.room_id
                                    VALUES(@name , @building , @capcity, @type)";

            cmd.Parameters.Add(new SqlParameter("@name", room.name));
            cmd.Parameters.Add(new SqlParameter("@building", room.BuildingId));
            cmd.Parameters.Add(new SqlParameter("@capcity", room.Capacity));
            cmd.Parameters.Add(new SqlParameter("@type", room.roomType));
            return dbConnection.executequery(cmd);

        }

        public int UpdateRoom(Room room)
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"UPDATE [dbo].[room]
                                set [room_name]= @name , [capcity] = @count, [room_type] = @type
                                WHERE [room_id] = @id";

            cmd.Parameters.Add(new SqlParameter("@id", room.Id));
            cmd.Parameters.Add(new SqlParameter("@name", room.name));
            cmd.Parameters.Add(new SqlParameter("@count", room.Capacity));
            cmd.Parameters.Add(new SqlParameter("@type", room.roomType));
            return dbConnection.excuteQueryRowcount(cmd);
        }

        public int DeleteRoom(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"DELETE FROM [dbo].[room]
                                WHERE [room_id] = @id";
            cmd.Parameters.Add(new SqlParameter("@id", id));
            return dbConnection.excuteQueryRowcount(cmd);
        }

        public List<Room> GetAllRooms()
        {
            List<Room> roomData = new List<Room>();
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"select [room_id] , [room_name],[building_id],[capcity],[room_type] from [dbo].[room]";
            SqlDataReader reader = dbConnection.queryData(cmd);
            while (reader.Read())
            {
                Room room = new Room()
                {
                    Id = reader.GetInt32(0),
                    name = reader.GetString(1),
                    Capacity = reader.GetInt32(3),
                    roomType = int.Parse(reader.GetString(4)),
                    BuildingId = reader.GetInt32(2)
                };

                roomData.Add(room);
            }
            dbConnection.CloseConnection();

            return roomData;
        }
    }
}
