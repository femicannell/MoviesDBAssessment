using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies2020
{
    public partial class Form1 : Form
    {
        //instantiate a new Data class
        Data myData = new Data();
        //create SQL connection
        SqlConnection Con = new SqlConnection();
        //create a new DataTable called MovieTable
        DataTable MovieTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
            loadDatabase();
        }
        public void loadDatabase()
        {
            //clear the old data from DGVMovies
            DGVMovies.DataSource = null;
            using (SqlConnection Con = new SqlConnection(myData.connectionString))
            {
                //check to see which radio button is selected - this determines which data is shown on DGVMovies
                if (rbAllMovies.Checked)
                {
                    //display all of the movies in the Movies table
                    DGVMovies.DataSource = myData.DGVMoviesDatabase(Con);
                }
                if (rbRentedMovies.Checked)
                {
                    //display all movies that are CURRENTLY rented out
                    DGVMovies.DataSource = myData.RentedMoviesDatabase(Con);
                }
                if (rbAvailableMovies.Checked)
                {
                    //display all movies that are CURRENTLY available (not rented out)
                    DGVMovies.DataSource = myData.AvailableMoviesDatabase(Con);
                }
                //load data for DGVCustomers and DGVRented (the other tabs)
                DGVCustomers.DataSource = myData.CustomersDatabase(Con);
                DGVRented.DataSource = myData.RentedDatabase(Con);
            }
            //close the database connection
            Con.Close();
        }
        private void rbCheckedChanged(object sender, EventArgs e)
        {
            loadDatabase();
        }

        private void BtnNewMovie_Click(object sender, EventArgs e)
        {
            //SQL query for adding whatever data is in the text boxes to the database
            string NewEntry = "INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Copies, Plot, Genre) VALUES ( @Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre)";
            //SQL connection
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-00F5KNJ\SQLEXPRESS01;Initial Catalog=MoviesDB;Integrated Security=True";

            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {
                newdata.Parameters.AddWithValue("@Rating", txtRating.Text);
                newdata.Parameters.AddWithValue("@Title", txtTitle.Text);
                newdata.Parameters.AddWithValue("@Year", txtYear.Text);
                newdata.Parameters.AddWithValue("@Rental_Cost", txtCost.Text);
                newdata.Parameters.AddWithValue("@Copies", txtCopies.Text);
                newdata.Parameters.AddWithValue("@Plot", txtPlot.Text);
                newdata.Parameters.AddWithValue("@Genre", txtGenre.Text);

                //open a connection to the database
                Con.Open();
                //Run the Query
                newdata.ExecuteNonQuery();
                //message box to inform user that data has been added so they know the query was successful
                MessageBox.Show("Movie added to database successfully");
            }
            //Run the LoadDatabase method from earler to see the new data
            loadDatabase();
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            //SQL query for updating the specified fields of data to the specified row in the database
            string UpdateData = "UPDATE Movies set Rating=@Rating, Title=@Title, Year=@Year, Rental_Cost=@Rental_Cost, Copies=@Copies, Plot=@Plot, Genre=@Genre WHERE MovieID=@ID";
            //SQL connection
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-00F5KNJ\SQLEXPRESS01;Initial Catalog=MoviesDB;Integrated Security=True";

            using (SqlCommand updatedata = new SqlCommand(UpdateData, Con))
            {
                updatedata.Parameters.AddWithValue("@ID", txtID.Text);
                updatedata.Parameters.AddWithValue("@Rating", txtRating.Text);
                updatedata.Parameters.AddWithValue("@Title", txtTitle.Text);
                updatedata.Parameters.AddWithValue("@Year", txtYear.Text);
                updatedata.Parameters.AddWithValue("@Rental_Cost", txtCost.Text);
                updatedata.Parameters.AddWithValue("@Copies", txtCopies.Text);
                updatedata.Parameters.AddWithValue("@Plot", txtPlot.Text);
                updatedata.Parameters.AddWithValue("@Genre", txtGenre.Text);

                //open a connection to the database
                Con.Open();
                //Run the Query
                updatedata.ExecuteNonQuery();
                //message box to inform user that data has been updated so they know the query was successful
                MessageBox.Show("Movie data updated successfully");
            }
            //Run the LoadDatabase method from earler to see the updated data
            loadDatabase();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            //SQL query for deleting a row in the database
            string DeleteData = "DELETE Movies WHERE MovieID=@ID";
            //SQL connection
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-00F5KNJ\SQLEXPRESS01;Initial Catalog=MoviesDB;Integrated Security=True";

            using (SqlCommand deletedata = new SqlCommand(DeleteData, Con))
            {
                deletedata.Parameters.AddWithValue("@ID", txtID.Text);

                //open a connection to the database
                Con.Open();
                //Run the Query
                deletedata.ExecuteNonQuery();
                //message box to inform user that data has been deleted so they know the query was successful
                MessageBox.Show("Movie deleted successfully");
            }
            //Run the LoadDatabase method from earler to see the updated data
            loadDatabase();
        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            //SQL query for adding data from the text boxes to the database
            string NewEntry = "INSERT INTO Customer (FirstName, LastName, Address, Phone) VALUES ( @FirstName, @LastName, @Address, @Phone)";
            //SQL connection
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-00F5KNJ\SQLEXPRESS01;Initial Catalog=MoviesDB;Integrated Security=True";

            using (SqlCommand newdata = new SqlCommand(NewEntry, Con))
            {
                newdata.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                newdata.Parameters.AddWithValue("@LastName", txtLastName.Text);
                newdata.Parameters.AddWithValue("@Address", txtAddress.Text);
                newdata.Parameters.AddWithValue("@Phone", txtPhone.Text);

                //open a connection to the database
                Con.Open();
                //Run the Query
                newdata.ExecuteNonQuery();
                //message box to inform user that data has been added so they know the query was successful
                MessageBox.Show("Customer added successfully");
            }
            //Run the LoadDatabase method from earler to see the new data
            loadDatabase();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //SQL query for updating the specified fields of data to the specified row in the database
            string UpdateDataCustomer = "UPDATE Customer set FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@Phone WHERE CustID=@CustID";
            //SQL connection
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-00F5KNJ\SQLEXPRESS01;Initial Catalog=MoviesDB;Integrated Security=True";

            using (SqlCommand updatedataCustomer = new SqlCommand(UpdateDataCustomer, Con))
            {
                updatedataCustomer.Parameters.AddWithValue("@CustID", txtCustID.Text);
                updatedataCustomer.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                updatedataCustomer.Parameters.AddWithValue("@LastName", txtLastName.Text);
                updatedataCustomer.Parameters.AddWithValue("@Address", txtAddress.Text);
                updatedataCustomer.Parameters.AddWithValue("@Phone", txtPhone.Text);

                //open a connection to the database
                Con.Open();
                //Run the Query
                updatedataCustomer.ExecuteNonQuery();
                //message box to inform user that data has been updated so they know the query was successful
                MessageBox.Show("Customer data updated successfully");
            }
            //Run the LoadDatabase method from earler to see the new data
            loadDatabase();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //SQL query for deleting a row in the database
            string DeleteDataCustomer = "DELETE Customer WHERE CustID=@CustID";
            //SQL connection
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=DESKTOP-00F5KNJ\SQLEXPRESS01;Initial Catalog=MoviesDB;Integrated Security=True";

            using (SqlCommand deletedataCustomer = new SqlCommand(DeleteDataCustomer, Con))
            {
                deletedataCustomer.Parameters.AddWithValue("@CustID", txtCustID.Text);

                //open a connection to the database
                Con.Open();
                //Run the Query
                deletedataCustomer.ExecuteNonQuery();
                //message box to inform user that data has been deleted so they know the query was successful
                MessageBox.Show("Customer deleted successfully");
            }
            //Run the LoadDatabase method from earler to see the new data
            loadDatabase();
        }
        private void DGVMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //show the data in the DGV in the text boxes
                string newvalue = DGVMovies.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //show the output on the header
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                //pass data to the text boxes
                txtID.Text = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtRating.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTitle.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtYear.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCost.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtCopies.Text = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtPlot.Text = DGVMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtGenre.Text = DGVMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch
            { }
        }

        private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //show the data in the DGV in the text boxes
                string newvalue = DGVCustomers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //show the output on the header
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                //pass data to the text boxes
                txtCustID.Text = DGVCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtFirstName.Text = DGVCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtLastName.Text = DGVCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPhone.Text = DGVCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtAddress.Text = DGVCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            { }
        }
        private void DGVRented_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //show the data in the DGV in the text boxes
                string newvalue = DGVRented.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //show the output on the header
                this.Text = "Row : " + e.RowIndex.ToString() + " Col : " + e.ColumnIndex.ToString() + " Value = " + newvalue;
                //pass data to the text boxes
                txtRentedID.Text = DGVRented.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch
            { }
        }

        private void btnRentMovie_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RentMovie(txtID.Text, txtCustID.Text));
        }

        public string RentMovie(string MovieID, string CustID)
        {

            string message;
            if (MovieID == "")
            {
                //create and return a message stating that no movie has been selected
                message = "Please select the movie that is being rented!";
                return message;
            }
            else if (CustID == "")
            {
                //create and return a message stating that no customer has been selected
                message = "Please select the customer that is renting this movie!";
                return message;
            }
            else
            {
                //SQL query for adding data to the RentedMovies table (query for renting a movie)
                string NewEntry = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) VALUES ( @MovieIDFK, @CustIDFK, @DateRented)";
                //SQL connection
                SqlConnection Con = new SqlConnection
                {
                    ConnectionString = @"Data Source=DESKTOP-00F5KNJ\SQLEXPRESS01;Initial Catalog=MoviesDB;Integrated Security=True"
                };
                //get DateTime data for the current date
                DateTime today = DateTime.Today;

                using (SqlCommand newdataRented = new SqlCommand(NewEntry, Con))
                {
                    newdataRented.Parameters.AddWithValue("@MovieIDFK", txtID.Text);
                    newdataRented.Parameters.AddWithValue("@CustIDFK", txtCustID.Text);
                    newdataRented.Parameters.AddWithValue("@DateRented", today);

                    //open a connection to the database
                    Con.Open();
                    //Run the Query
                    newdataRented.ExecuteNonQuery();
                    //create message informing the user that the movie has been rented successfully
                    message = "Movie RENTED";
                }
                //Run the LoadDatabase method from earler to see the new data
                loadDatabase();
            }
            //return the success message
            return message;
        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            //SQL query for adding the return date for a rented movie (returning a movie)
            string NewEntry = "UPDATE RentedMovies set DateReturned=@DateReturned WHERE RMID=@RentedID";
            //SQL connection
            SqlConnection Con = new SqlConnection
            {
                ConnectionString = @"Data Source=DESKTOP-00F5KNJ\SQLEXPRESS01;Initial Catalog=MoviesDB;Integrated Security=True"
            };

            //get DateTime data for the current date
            DateTime today = DateTime.Today;

            using (SqlCommand dataReturned = new SqlCommand(NewEntry, Con))
            {
                dataReturned.Parameters.AddWithValue("@RentedID", txtRentedID.Text);
                dataReturned.Parameters.AddWithValue("@DateReturned", today);

                //open a connection to the database
                Con.Open();
                //Run the Query
                dataReturned.ExecuteNonQuery();
                //message box informing the user that the movie has been returned successfully
                MessageBox.Show("Movie RETURNED");
            }
            //Run the LoadDatabase method from earler to see the new data
            loadDatabase();
        }
    }
}