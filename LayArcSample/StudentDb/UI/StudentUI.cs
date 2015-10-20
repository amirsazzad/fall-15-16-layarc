using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using StudentDb.DataLayer;
using StudentDb.Entities;
using StudentDb.Framework;

namespace StudentDb.UI
{
    public class StudentUI
    {
        private static DataAccess _dataAccess = new DataAccess();
        public void Delete()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            _studentDa.Delete(id);
            Query();
        }
        public void Update()
        {
            Student studentObjectToUpdate = new Student();
            Console.Write("Enter ID: ");
            studentObjectToUpdate.ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            studentObjectToUpdate.Name = Console.ReadLine();
            _studentDa.Update(studentObjectToUpdate);
            Query();
        }
        static StudentDa _studentDa = new StudentDa();
        public void Insert()
        {
            Student studentObjectToInsert = new Student();
            Console.Write("Enter ID: ");
            studentObjectToInsert.ID = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            studentObjectToInsert.Name = Console.ReadLine();

            bool isPosted = _studentDa.Insert(studentObjectToInsert);
            if (isPosted)
                Console.WriteLine("Data Posted");
            else
                Console.WriteLine("Data Posting Failed.");
            Query();
        }

        public void Query()
        {

            string query = "SELECT * FROM Student";
            DataTable dt = _dataAccess.Query(query);

            ShowTable(dt);
        }

        public void ShowTable(DataTable dt)
        {
            for (int j = 0; j < dt.Columns.Count; j++)
            {
                Console.Write(dt.Columns[j].ColumnName);
                Console.Write("\t");
            }
            Console.WriteLine();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
