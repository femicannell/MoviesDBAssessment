namespace Movies2020
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.lblCopies = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.btnNewMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.lblMovies = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.rbAllMovies = new System.Windows.Forms.RadioButton();
            this.rbRentedMovies = new System.Windows.Forms.RadioButton();
            this.rbAvailableMovies = new System.Windows.Forms.RadioButton();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.btnRentMovie = new System.Windows.Forms.Button();
            this.txtRentedID = new System.Windows.Forms.TextBox();
            this.lblRentedID = new System.Windows.Forms.Label();
            this.tabRented = new System.Windows.Forms.TabPage();
            this.DGVRented = new System.Windows.Forms.DataGridView();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.tabDGV = new System.Windows.Forms.TabControl();
            this.tabRented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRented)).BeginInit();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabDGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(15, 291);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(121, 291);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(100, 20);
            this.txtRating.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(227, 291);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(545, 291);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(100, 20);
            this.txtCopies.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(439, 291);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(333, 291);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 4;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(757, 291);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 7;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(651, 291);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(100, 20);
            this.txtPlot.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 275);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(754, 275);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Genre";
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.Location = new System.Drawing.Point(648, 275);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(25, 13);
            this.lblPlot.TabIndex = 11;
            this.lblPlot.Text = "Plot";
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(542, 275);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(39, 13);
            this.lblCopies.TabIndex = 12;
            this.lblCopies.Text = "Copies";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(436, 275);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(62, 13);
            this.lblCost.TabIndex = 13;
            this.lblCost.Text = "Rental Cost";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(333, 275);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Year";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(224, 275);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Title";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(118, 275);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 16;
            this.lblRating.Text = "Rating";
            // 
            // btnNewMovie
            // 
            this.btnNewMovie.Location = new System.Drawing.Point(863, 282);
            this.btnNewMovie.Name = "btnNewMovie";
            this.btnNewMovie.Size = new System.Drawing.Size(70, 36);
            this.btnNewMovie.TabIndex = 17;
            this.btnNewMovie.Text = "New Movie";
            this.btnNewMovie.UseVisualStyleBackColor = true;
            this.btnNewMovie.Click += new System.EventHandler(this.BtnNewMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Location = new System.Drawing.Point(939, 282);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(70, 36);
            this.btnUpdateMovie.TabIndex = 18;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Location = new System.Drawing.Point(1015, 282);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(70, 36);
            this.btnDeleteMovie.TabIndex = 19;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovies.Location = new System.Drawing.Point(15, 246);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(62, 18);
            this.lblMovies.TabIndex = 30;
            this.lblMovies.Text = "Movies";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(15, 324);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(91, 18);
            this.lblCustomers.TabIndex = 50;
            this.lblCustomers.Text = "Customers";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(697, 359);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(70, 36);
            this.btnDeleteCustomer.TabIndex = 49;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(621, 359);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(70, 36);
            this.btnUpdateCustomer.TabIndex = 48;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(545, 359);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(70, 36);
            this.btnNewCustomer.TabIndex = 47;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(118, 352);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 46;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(224, 352);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(333, 352);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 44;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(439, 352);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 43;
            this.lblPhone.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 352);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "ID";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(439, 368);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 35;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(333, 368);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 34;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(227, 368);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 33;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(121, 368);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 32;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(15, 368);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(100, 20);
            this.txtCustID.TabIndex = 31;
            // 
            // rbAllMovies
            // 
            this.rbAllMovies.AutoSize = true;
            this.rbAllMovies.Checked = true;
            this.rbAllMovies.Location = new System.Drawing.Point(83, 248);
            this.rbAllMovies.Name = "rbAllMovies";
            this.rbAllMovies.Size = new System.Drawing.Size(73, 17);
            this.rbAllMovies.TabIndex = 51;
            this.rbAllMovies.TabStop = true;
            this.rbAllMovies.Text = "All Movies";
            this.rbAllMovies.UseVisualStyleBackColor = true;
            this.rbAllMovies.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbRentedMovies
            // 
            this.rbRentedMovies.AutoSize = true;
            this.rbRentedMovies.Location = new System.Drawing.Point(162, 248);
            this.rbRentedMovies.Name = "rbRentedMovies";
            this.rbRentedMovies.Size = new System.Drawing.Size(97, 17);
            this.rbRentedMovies.TabIndex = 52;
            this.rbRentedMovies.Text = "Rented Movies";
            this.rbRentedMovies.UseVisualStyleBackColor = true;
            this.rbRentedMovies.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbAvailableMovies
            // 
            this.rbAvailableMovies.AutoSize = true;
            this.rbAvailableMovies.Location = new System.Drawing.Point(265, 248);
            this.rbAvailableMovies.Name = "rbAvailableMovies";
            this.rbAvailableMovies.Size = new System.Drawing.Size(105, 17);
            this.rbAvailableMovies.TabIndex = 53;
            this.rbAvailableMovies.Text = "Available Movies";
            this.rbAvailableMovies.UseVisualStyleBackColor = true;
            this.rbAvailableMovies.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.Green;
            this.btnReturnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReturnMovie.Location = new System.Drawing.Point(1015, 356);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(75, 43);
            this.btnReturnMovie.TabIndex = 54;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // btnRentMovie
            // 
            this.btnRentMovie.BackColor = System.Drawing.Color.DarkRed;
            this.btnRentMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentMovie.ForeColor = System.Drawing.Color.Salmon;
            this.btnRentMovie.Location = new System.Drawing.Point(898, 356);
            this.btnRentMovie.Name = "btnRentMovie";
            this.btnRentMovie.Size = new System.Drawing.Size(75, 43);
            this.btnRentMovie.TabIndex = 55;
            this.btnRentMovie.Text = "Rent Movie";
            this.btnRentMovie.UseVisualStyleBackColor = false;
            this.btnRentMovie.Click += new System.EventHandler(this.btnRentMovie_Click);
            // 
            // txtRentedID
            // 
            this.txtRentedID.Location = new System.Drawing.Point(1113, 375);
            this.txtRentedID.Name = "txtRentedID";
            this.txtRentedID.Size = new System.Drawing.Size(100, 20);
            this.txtRentedID.TabIndex = 56;
            // 
            // lblRentedID
            // 
            this.lblRentedID.AutoSize = true;
            this.lblRentedID.Location = new System.Drawing.Point(1110, 359);
            this.lblRentedID.Name = "lblRentedID";
            this.lblRentedID.Size = new System.Drawing.Size(88, 13);
            this.lblRentedID.TabIndex = 57;
            this.lblRentedID.Text = "Rented Movie ID";
            // 
            // tabRented
            // 
            this.tabRented.Controls.Add(this.DGVRented);
            this.tabRented.Location = new System.Drawing.Point(4, 22);
            this.tabRented.Name = "tabRented";
            this.tabRented.Padding = new System.Windows.Forms.Padding(3);
            this.tabRented.Size = new System.Drawing.Size(1035, 188);
            this.tabRented.TabIndex = 2;
            this.tabRented.Text = "Rented Movies";
            this.tabRented.UseVisualStyleBackColor = true;
            // 
            // DGVRented
            // 
            this.DGVRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRented.Location = new System.Drawing.Point(0, 0);
            this.DGVRented.Name = "DGVRented";
            this.DGVRented.Size = new System.Drawing.Size(1035, 188);
            this.DGVRented.TabIndex = 30;
            this.DGVRented.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRented_CellClick);
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.DGVCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(1035, 188);
            this.tabCustomers.TabIndex = 1;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Location = new System.Drawing.Point(-1, 0);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.Size = new System.Drawing.Size(1040, 188);
            this.DGVCustomers.TabIndex = 29;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellClick);
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.DGVMovies);
            this.tabMovies.Location = new System.Drawing.Point(4, 22);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(1035, 188);
            this.tabMovies.TabIndex = 0;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Location = new System.Drawing.Point(-4, 0);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.Size = new System.Drawing.Size(1039, 188);
            this.DGVMovies.TabIndex = 28;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick);
            // 
            // tabDGV
            // 
            this.tabDGV.Controls.Add(this.tabMovies);
            this.tabDGV.Controls.Add(this.tabCustomers);
            this.tabDGV.Controls.Add(this.tabRented);
            this.tabDGV.Location = new System.Drawing.Point(12, 12);
            this.tabDGV.Name = "tabDGV";
            this.tabDGV.SelectedIndex = 0;
            this.tabDGV.Size = new System.Drawing.Size(1043, 214);
            this.tabDGV.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 450);
            this.Controls.Add(this.lblRentedID);
            this.Controls.Add(this.txtRentedID);
            this.Controls.Add(this.btnRentMovie);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.rbAvailableMovies);
            this.Controls.Add(this.rbRentedMovies);
            this.Controls.Add(this.rbAllMovies);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.lblMovies);
            this.Controls.Add(this.tabDGV);
            this.Controls.Add(this.btnDeleteMovie);
            this.Controls.Add(this.btnUpdateMovie);
            this.Controls.Add(this.btnNewMovie);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.lblPlot);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabRented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRented)).EndInit();
            this.tabCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.tabMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabDGV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button btnNewMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.RadioButton rbAllMovies;
        private System.Windows.Forms.RadioButton rbRentedMovies;
        private System.Windows.Forms.RadioButton rbAvailableMovies;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button btnRentMovie;
        private System.Windows.Forms.TextBox txtRentedID;
        private System.Windows.Forms.Label lblRentedID;
        private System.Windows.Forms.TabPage tabRented;
        private System.Windows.Forms.DataGridView DGVRented;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.TabControl tabDGV;
    }
}

