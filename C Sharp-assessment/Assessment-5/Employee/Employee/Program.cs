using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True";
        string productName = "New Product";
        decimal price = 100.00m;

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("sp_InsertProduct", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.Add("@ProductId", SqlDbType.Int).Direction = ParameterDirection.Output;

                command.ExecuteNonQuery();

                int productId = (int)command.Parameters["@ProductId"].Value;
                decimal discountedPrice = GetDiscountedPrice(productId, connection);

                Console.WriteLine("Product ID: " + productId);
                Console.WriteLine("Discounted Price: " + discountedPrice);
            }
        }
    }

    static decimal GetDiscountedPrice(int productId, SqlConnection connection)
    {
        using (SqlCommand command = new SqlCommand("SELECT DiscountedPrice FROM ProductsDetails WHERE ProductId = @ProductId", connection))
        {
            command.Parameters.AddWithValue("@ProductId", productId);

            return (decimal)command.ExecuteScalar();
        }
        Console.Read();
    } 
}
