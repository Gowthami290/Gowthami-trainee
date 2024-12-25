using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        
        static SqlConnection getConnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-D244D6FJ;Initial Catalog=RailwayReservation;" + "Integrated Security=true;");

            con.Open();
            return con;
        }

        public static void AddTrain()
        {
            con = getConnection();

            Console.WriteLine("Enter Train number,Train Name, Source, Destination,available berths");
            int trainnumber= Convert.ToInt32(Console.ReadLine());
            string trainName = Console.ReadLine();
            string source = Console.ReadLine();
            string destination = Console.ReadLine();
            int berths= Convert.ToInt32(Console.ReadLine());
          

            string query = "insert into Trains (trainnumber,TrainName, Source, Destination,availableBerths,IsActive) values (@tnumber,@name, @source, @destination, @berths,1)";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@tnumber", trainnumber);
            cmd.Parameters.AddWithValue("@name", trainName);
            cmd.Parameters.AddWithValue("@source", source);
            cmd.Parameters.AddWithValue("@destination", destination);
            cmd.Parameters.AddWithValue("@berths", berths);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Train added successfully!");

            con.Close();
        }

        public static void ModifyTrain()
        {
            con = getConnection();

            Console.Write("Enter Train number to modify: ");
            int trainnumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter new Train Name, Source, Destination, Class (1A, 2A)");
            string trainName = Console.ReadLine();
            string source = Console.ReadLine();
            string destination = Console.ReadLine();
            string trainClass = Console.ReadLine();

            string query = "update Trains set TrainName = @name, Source = @source, Destination = @destination where trainnumber = @tnumber";
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@tnumber", trainnumber);
            cmd.Parameters.AddWithValue("@name", trainName);
            cmd.Parameters.AddWithValue("@source", source);
            cmd.Parameters.AddWithValue("@destination", destination);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Train modified successfully!");

            con.Close();
        }

        public static void DeleteTrain()
        {
            con = getConnection();

            Console.Write("Enter Train number to delete: ");
            int trainnumber = Convert.ToInt32(Console.ReadLine());

            string query = "update Trains set IsActive=0 where trainnumber = @tnumber";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tnumber", trainnumber);

            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Train deleted successfully!");
            }
            else
            {
                Console.WriteLine("Train not found.");
            }

            con.Close();
        }

    }

    class Admin
    {
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Add Train");
                Console.WriteLine("2. Modify Train");
                Console.WriteLine("3. Delete Train");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Program.AddTrain();
                        break;
                    case 2:
                        Program.ModifyTrain();
                        break;
                    case 3:
                        Program.DeleteTrain();
                        break;
                    case 4:
                        Console.WriteLine("Exiting Admin Menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
