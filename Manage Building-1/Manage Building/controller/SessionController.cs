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

        public int AddSession(Session session)
        {
            Console.WriteLine(session);
            SqlCommand cmd = new SqlCommand(string.Empty, dbConnection.GetConnection());

            cmd.CommandText = @"INSERT INTO [dbo].[sesion] ([count], [duration] , [Tag] , [Lecture_no] , [Group_no] , [Room_id] , [Subject_no]) output INSERTED.id
                                VALUES(@count, @duration, @tag , @lecId , @grpId, @roomId ,@subcode)";

            cmd.Parameters.Add(new SqlParameter("@count", session.count));
            cmd.Parameters.Add(new SqlParameter("@duration", session.duaration));
            cmd.Parameters.Add(new SqlParameter("@tag", session.tag));
            cmd.Parameters.Add(new SqlParameter("@lecId", session.lectureId));
            cmd.Parameters.Add(new SqlParameter("@grpId", session.groupId));
            cmd.Parameters.Add(new SqlParameter("@roomId", session.roomId));
            cmd.Parameters.Add(new SqlParameter("@subCode", session.subjectId));
            return dbConnection.executequery(cmd);
           
        }

        
    }
}