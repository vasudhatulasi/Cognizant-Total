using System;
using System.Data.SqlClient;

class Program
{
    static string connectionString =
        "Server=localhost;Database=CompanyDB;Trusted_Connection=True;";

    static void Main()
    {
        // INSERT
        using (SqlConnection con =
               new SqlConnection(connectionString))
        {
            con.Open();

            SqlCommand insertCmd =
                new SqlCommand(
                "INSERT INTO Employees(Name,Salary) VALUES('John',50000)",
                con);

            insertCmd.ExecuteNonQuery();

            Console.WriteLine("Record Inserted");
        }

        // READ
        using (SqlConnection con =
               new SqlConnection(connectionString))
        {
            con.Open();

            SqlCommand readCmd =
                new SqlCommand(
                "SELECT * FROM Employees",
                con);

            SqlDataReader reader =
                readCmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(
                    reader["Id"] + " " +
                    reader["Name"] + " " +
                    reader["Salary"]);
            }
        }

        // UPDATE
        using (SqlConnection con =
               new SqlConnection(connectionString))
        {
            con.Open();

            SqlCommand updateCmd =
                new SqlCommand(
                "UPDATE Employees SET Salary=60000 WHERE Name='John'",
                con);

            updateCmd.ExecuteNonQuery();

            Console.WriteLine("Record Updated");
        }

        // DELETE
        using (SqlConnection con =
               new SqlConnection(connectionString))
        {
            con.Open();

            SqlCommand deleteCmd =
                new SqlCommand(
                "DELETE FROM Employees WHERE Name='John'",
                con);

            deleteCmd.ExecuteNonQuery();

            Console.WriteLine("Record Deleted");
        }
    }
}
