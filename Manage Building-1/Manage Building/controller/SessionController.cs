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

        public int UpdateSession(Session session)
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"UPDATE [dbo].[sesion]
                                set [Lecture_no]= @lec , [Subject_no] = @sub, [Tag] = @tag, [Group_no] = @gp, [Room_id] = @room, [count] = @count,  [duration] = @dur
                                WHERE [id] = @id";

            cmd.Parameters.Add(new SqlParameter("@lec", session.name));
            cmd.Parameters.Add(new SqlParameter("@sub", session.name));
            cmd.Parameters.Add(new SqlParameter("@tag", session.name));
            cmd.Parameters.Add(new SqlParameter("@gp", session.name));
            cmd.Parameters.Add(new SqlParameter("@room", session.name));
            cmd.Parameters.Add(new SqlParameter("@count", session.RoomsCount));
            cmd.Parameters.Add(new SqlParameter("@dur", session.name));
            cmd.Parameters.Add(new SqlParameter("@id", session.Id));

            return dbConnection.excuteQueryRowcount(cmd);
        }

        public int DeleteBuilding(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"DELETE FROM [dbo].[building]
                                WHERE [id] = @id";
            cmd.Parameters.Add(new SqlParameter("@id", id));
            return dbConnection.excuteQueryRowcount(cmd);
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
        
        public List<Group> getAllGroups()
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());
            List<Group> groups = new List<Group>();

            cmd.CommandText = @"SELECT Id , name FROM [dbo].[groups]";

            SqlDataReader reader = dbConnection.queryData(cmd);

            while (reader.Read())
            {
                Group gp = new Group()
                {
                    Id = reader.GetInt32(0),
                    name = reader.GetString(1)
                };

                groups.Add(gp);
            }
            dbConnection.CloseConnection();

            return groups;
        } 
        
        
        public List<Subject> getAllSubjects()
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());
            List<Subject> subjects = new List<Subject>();

            cmd.CommandText = @"SELECT subjectCode  , name FROM [dbo].[subject]";

            SqlDataReader reader = dbConnection.queryData(cmd);

            while (reader.Read())
            {
                Subject subject = new Subject()
                {
                    code = reader.GetString(0),
                    name = reader.GetString(1)
                };

                subjects.Add(subject);
            }
            dbConnection.CloseConnection();

            return subjects;
        }

        
    }
}