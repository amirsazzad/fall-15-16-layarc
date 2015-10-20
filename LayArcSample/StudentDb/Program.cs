using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using StudentDb.DataLayer;
using StudentDb.Entities;
using StudentDb.Framework;
using StudentDb.UI;

namespace StudentDb
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentUI sui = new StudentUI();
            do
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("==========================");
                Console.WriteLine("Query:\t1,");
                Console.WriteLine("Insert:\t2,");
                Console.WriteLine("Update:\t3,");
                Console.WriteLine("Delete:\t4,");
                Console.WriteLine("Exit:\t0");
                Console.WriteLine("==========================");
                Console.Write("Enter Command Here: ");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        sui.Query();
                        break;
                    case "2":
                        sui.Insert();
                        break;
                    case "3":
                        sui.Update();
                        break;
                    case "4":
                        sui.Delete();
                        break;
                    case "0":
                        return;

                }
                Console.WriteLine("==========================");
                Console.WriteLine("Press Enter to Continue...");
                Console.ReadLine();
            } while (true);

        }

       

    }
}
