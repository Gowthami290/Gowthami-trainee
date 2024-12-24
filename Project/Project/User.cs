using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project
{
    class Program2
    {
        static SqlConnection con;

       //Method to get SQL connection
        static SqlConnection getConnection()
        {
            try
            {
                con = new SqlConnection("Data Source=ICS-LT-D244D6FJ;Initial Catalog=RailwayReservation;Integrated Security=true;");
                return con;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error establishing connection: " + ex.Message);
                return null;
            }
        }
    }

    class User
    {
        static string connectionString = "Data Source=ICS-LT-D244D6FJ;Initial Catalog=RailwayReservation;Integrated Security=true;";
        static Dictionary<int, string> bookings = new Dictionary<int, string>();
        static int bookingIdCounter = 1;
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static SqlConnection Connection()
        {
            con = new SqlConnection("Data Source=ICS-LT-D244D6FJ;Initial Catalog=MiniprojectRailway;" + "Integrated Security=true;");

            con.Open();
            Console.WriteLine("Connected successfully:");
            return con;
        }

        public static void UserOperations()
        {
            while (true)
            {
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Booking Ticket");
                Console.WriteLine("2. Cancel Ticket");
                Console.WriteLine("3. Show All Trains");
                Console.WriteLine("4. Show Booking");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            BookingTicket();
                            break;
                        case 2:
                           CancelTicket();
                            break;
                        case 3:
                            ShowAllTrains();
                            break;
                        case 4:
                            ShowBooking();
                            break;
                        case 5:
                            Console.WriteLine("Exiting Admin Menu...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice Try again");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
        }

        public static void BookingTicket()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                try
                {

                     Connection();
                    Console.WriteLine("Enter TrainId");
                    string trainNo = Console.ReadLine();

                    Console.Write("Enter Passenger Name ");
                    string passengerName = Console.ReadLine();

                    Console.Write("Enter Class ");
                    string trainClass = Console.ReadLine();

                    Console.Write("Enter Berths to Book ");
                    int berths = Convert.ToInt32(Console.ReadLine());



                    SqlCommand cmd = new SqlCommand("sp_bookingtickets", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@trainnumber", trainNo);
                    cmd.Parameters.AddWithValue("@passengername", passengerName);
                    cmd.Parameters.AddWithValue("@class", trainClass);
                    cmd.Parameters.AddWithValue("@berths", berths);

                    cmd.ExecuteNonQuery();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Ticket booked successfully");
                    string query = "update Train set AvailableBerths = AvailableBerths - @berths " +
                                   "where TrainId = @trainnumber AND AvailableBerths >= @berths and IsActive = 1";
                    }
                    else
                    {
                        Console.WriteLine("Booking failed. Not enough berths or train is inactive");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        public static void CancelTicket()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                     Console.Write("Enter Booking Id to Cancel");
                        int trainnumber = Convert.ToInt32(Console.ReadLine());

                    SqlCommand cmd = new SqlCommand("sp_Cancelticket", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                
                    cmd.Parameters.AddWithValue("@trainnumber", trainnumber);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Booking cancelled successfully");
                    }
                    else
                    {
                        Console.WriteLine("No booking found with the given ID");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred " + ex.Message);
                }
            }
        }

        public static void ShowAllTrains()
        {

            con = Connection();
            string query = "select * from Trains where IsActive =1";
            SqlCommand cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            Console.WriteLine("Avalible Trains");
            while (dr.Read())
            {
                Console.WriteLine($"{dr["trainid"]} | {dr["trainName"]} | {dr["source"]} | {dr["availableBerths"]} | {dr["trainClass"]}");

            }

        }
        public static void ShowBooking()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM BookingTickets";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Console.WriteLine("Booking Details");
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine($"Trainnumber {row["Trainnumber"]}, TrainId {row["PassengerName"]}");
                }
            }
        }

    }
}
