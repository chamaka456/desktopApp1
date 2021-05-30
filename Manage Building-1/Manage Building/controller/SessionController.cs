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

            cmd.Parameters.Add(new SqlParameter("@lec", session.lectureId));
            cmd.Parameters.Add(new SqlParameter("@sub", session.subjectId));
            cmd.Parameters.Add(new SqlParameter("@tag", session.tag));
            cmd.Parameters.Add(new SqlParameter("@gp", session.groupId));
            cmd.Parameters.Add(new SqlParameter("@room", session.roomId));
            cmd.Parameters.Add(new SqlParameter("@count", session.count));
            cmd.Parameters.Add(new SqlParameter("@dur", session.duaration));
            cmd.Parameters.Add(new SqlParameter("@id", session.Id));

            return dbConnection.excuteQueryRowcount(cmd);
        }

        public int DeleteSession(int id)
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"DELETE FROM [dbo].[sesion]
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
        public List<Session> getAllSessions()
        {
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());
            List<Session> sessions = new List<Session>();

            cmd.CommandText = @"SELECT id, Lecture_no, Subject_no, Tag ,Group_no, Room_id,count , duration 
                              FROM [dbo].[groups]";

            SqlDataReader reader = dbConnection.queryData(cmd);

            while (reader.Read())
            {
                Session ss = new Session()
                {
                    Id = reader.GetInt32(0),
                    lectureId = reader.GetInt32(1),
                    subjectId = reader.GetString(2),
                    tag = reader.GetString(3),
                    groupId = reader.GetInt32(4),
                    roomId = reader.GetInt32(5),
                    count = reader.GetInt32(6),
                    duaration = reader.GetInt32(7)
                };

                sessions.Add(ss);
            }
            dbConnection.CloseConnection();

            return sessions;
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