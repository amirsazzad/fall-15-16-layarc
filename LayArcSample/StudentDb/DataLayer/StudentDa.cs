using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using StudentDb.Entities;
using StudentDb.Framework;

namespace StudentDb.DataLayer
{
    public class StudentDa
    {
        DataAccess _dataAccess = new DataAccess();
        public bool Insert(Student student)
        {
            string insertCommand = "INSERT INTO Student (ID, Name) " +
                                   "VALUES (@ID, @Name)";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = student.ID;
            SqlParameter nameParameter = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            nameParameter.Value = student.Name;
            command.Parameters.Add(idParameter);
            command.Parameters.Add(nameParameter);

            return _dataAccess.Post(command);
        }

        public bool Update(Student student)
        {
            string insertCommand = "UPDATE Student SET Name = @Name " +
                                   "WHERE ID = @ID";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = student.ID;
            SqlParameter nameParameter = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            nameParameter.Value = student.Name;
            command.Parameters.Add(idParameter);
            command.Parameters.Add(nameParameter);

            return _dataAccess.Post(command);
        }

        public bool Delete(int id)
        {
            string insertCommand = "DELETE Student " +
                                   "WHERE ID = @ID";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = id;

            command.Parameters.Add(idParameter);

            return _dataAccess.Post(command);
        }
    }

}
