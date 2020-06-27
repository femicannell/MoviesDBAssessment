using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies2020
{
    public class Data
    {
        //Database connection string
        public string connectionString = @"Data Source=DESKTOP-00F5KNJ\SQLEXPRESS01;Initial Catalog=MoviesDB;Integrated Security=True";
        public DataTable DGVMoviesDatabase(SqlConnection Con)
        {
            //Selecting and displaying data for ALL MOVIES
            string queryStringMovies = "SELECT * FROM Movies ORDER by MovieID";
            //read in the data with a datareader open the data connection
            Con.Open();
            // Create new DataAdapter
            using (SqlDataAdapter adapter = new SqlDataAdapter(
                queryStringMovies, Con))
            {
                // Use DataAdapter to fill DataTable
                DataTable dataTableMovies = new DataTable();
                adapter.Fill(dataTableMovies);

                //return DataTable
                return dataTableMovies;
            }
        }

        public DataTable AvailableMoviesDatabase(SqlConnection Con)
        {
            //Selecting and displaying data for AVAILABLE MOVIES
            string queryStringMovies2 = "SELECT * from Movies Where MovieID NOT IN (Select MovieIDFK from RentedMovies WHERE DateReturned IS NULL);";
            // Create new DataAdapter
            using (SqlDataAdapter adapterAvailable = new SqlDataAdapter(
                queryStringMovies2, Con))
            {
                // Use DataAdapter to fill DataTable
                DataTable dataTableAvailable = new DataTable();
                adapterAvailable.Fill(dataTableAvailable);

                //return DataTable
                return dataTableAvailable;
            }
        }

        public DataTable RentedMoviesDatabase(SqlConnection Con)
        {
            //Selecting and displaying data for RENTED MOVIES in the standard Movies tab
            string queryStringMovies2 = "SELECT * FROM Movies WHERE MovieID IN (SELECT MovieIDFK FROM RentedMovies WHERE DateReturned IS NULL); ";
            // Create new DataAdapter
            using (SqlDataAdapter adapter = new SqlDataAdapter(queryStringMovies2, Con))
            {
                // Use DataAdapter to fill DataTable
                DataTable dataTableMovies2 = new DataTable();
                adapter.Fill(dataTableMovies2);

                //return DataTable
                return dataTableMovies2;
            }
        }
        public DataTable CustomersDatabase(SqlConnection Con)
        {
            //Selecting and displaying data for CUSTOMERS
            string queryStringCustomer = "SELECT * FROM Customer ORDER by CustID";
            // Create new DataAdapter
            using (SqlDataAdapter adapter = new SqlDataAdapter(
                queryStringCustomer, Con))
            {
                // Use DataAdapter to fill DataTable
                DataTable dataTableCustomer = new DataTable();
                adapter.Fill(dataTableCustomer);

                //return DataTable
                return dataTableCustomer;
            }
        }

        public DataTable RentedDatabase(SqlConnection Con)
        {
            //Selecting and displaying data for RENTED MOVIES
            string queryStringRented = "SELECT * FROM RentedMovies ORDER by RMID";
            // Create new DataAdapter
            using (SqlDataAdapter adapter = new SqlDataAdapter(
                queryStringRented, Con))
            {
                // Use DataAdapter to fill DataTable
                DataTable dataTableRented = new DataTable();
                adapter.Fill(dataTableRented);

                //return DataTable
                return dataTableRented;
            }
        }
    }
}