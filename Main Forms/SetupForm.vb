Imports System.Data.SqlClient

Public Class SetupForm
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Application.Exit()
    End Sub

    Private Sub ContinueBtn_Click(sender As Object, e As EventArgs) Handles ContinueBtn.Click

        GlobalVars.connectionString = "Server=" + DBHost.Text + ";User Id=" + DBUsername.Text + ";Password=" + DBPassword.Text + ";"

        Dim cnn As SqlConnection = New SqlConnection(GlobalVars.connectionString)
        Dim cmd As SqlCommand
        Dim query As String

        Try
            cnn.Open()

            ' Create database
            query = String.Format("CREATE DATABASE {0}", DBName.Text.Trim().Replace(" ", ""))
            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            cnn.Close()

            ' Set the initial catalog
            GlobalVars.connectionString += "Database=" + DBName.Text + ";"

            cnn = New SqlConnection(GlobalVars.connectionString)
            cnn.Open()

            ' Create properties table
            query = "CREATE TABLE properties (
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        company varchar(25) NOT NULL,
                        address varchar(255) NOT NULL,
                        country varchar(90) NOT NULL,
                        county varchar(50) NOT NULL,
                        city varchar(189) NOT NULL,
                        postcode varchar(18) NOT NULL,
                        telephone int NOT NULL
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create logs table
            query = "CREATE TABLE logs (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        log_for varchar(15) NOT NULL,
                        type varchar(15) NOT NULL,
                        time_stamp timestamp,
                        email_to varchar(255),
                        email_from varchar(255),
                        call_to varchar(20),
                        call_from varchar(20),
                        voicmail_from varchar(20),
                        voicemail_to varchar(20),
                        note varchar(255)
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create maintenance logs table
            query = "CREATE TABLE maintenance_logs (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        location varchar(20) NOT NULL,
                        status varchar(10) NOT NULL,
                        note varchar(255) NOT NULL
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create tasks table
            query = "CREATE TABLE tasks (
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        name varchar(20) NOT NULL,
                        status varchar(10) NOT NULL,
                        importance varchar(10) NOT NULL,
                        start_date date DEFAULT GETDATE(),
                        due_date date NOT NULL,
                        reminder bit DEFAULT 0,
                        reminder_days int DEFAULT 0,
                        note varchar(255) NOT NULL
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()


            ' Create accounts table
            query = "CREATE TABLE accounts (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        balance_date date NOT NULL,
                        closing_balance decimal NOT NULL
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create invoices table
            query = "CREATE TABLE invoices (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        invoice_date date NOT NULL,
                        type varchar(20) NOT NULL,
                        company varchar(25) NOT NULL,
                        payment_type varchar(15) NOT NULL,
                        amount decimal NOT NULL,
                        status varchar(10) DEFAULT 'Paid',
                        payment_date date NOT NULL,
                        contact_number int NOT NULL,
                        comments varchar(100),
                        contract varchar(20) DEFAULT 'None', 
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create contracts table
            query = "CREATE TABLE contracts (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        type varchar(20) NOT NULL,
                        company varchar(25) NOT NULL,
                        length varchar(10) NOT NULL,
                        start_date date NOT NULL,
                        end_date date NOT NULL,
                        account_holder varchar(30),
                        account_holder_address varchar(255),
                        account_number int,
                        security_answer varchar(25),
                        network varchar(25),
                        telephone_number int,
                        service_plan varchar(100),
                        payment_type varchar(15) NOT NULL,
                        payment_method varchar(20) NOT NULL,
                        fee decimal NOT NULL,
                        reminder_id int
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create contacts table
            query = "CREATE TABLE contacts (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        name varchar(25) NOT NULL,
                        telephone_number int NOT NULL,
                        email_address varchar(255) NOT NULL,
                        address varchar(255)
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create docs table
            query = "CREATE TABLE docs (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        invoice_id int FOREIGN KEY REFERENCES invoices(id),
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()


            '''''''''''''''''''''
            ' Assets tables
            '''''''''''''''''''''
            ' Create broadband table
            query = "CREATE TABLE asset_broadband (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create mobile table
            query = "CREATE TABLE asset_mobile (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create landlines table
            query = "CREATE TABLE asset_landlines (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        telephone_number int NOT NULL,
                        status varchar(10) NOT NULL,
                        location varchar(20),
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create appliances table
            query = "CREATE TABLE asset_appliances (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        manufacturer varchar(50) NOT NULL,
                        model varchar(50) NOT NULL,
                        imei varchar(15),
                        network varchar(10),
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create pcs table
            query = "CREATE TABLE asset_pcs (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        manufacturer varchar(50) NOT NULL,
                        model varchar(50) NOT NULL,
                        serial varchar(10),
                        warranty varchar(10),
                        account_username varchar(256) NOT NULL,
                        account_password varchar(256) NOT NULL,
                        location varchar(20),
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create tvs table
            query = "CREATE TABLE asset_tvs (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        manufacturer varchar(50) NOT NULL,
                        model varchar(50) NOT NULL,
                        serial varchar(10),
                        warranty varchar(10),
                        location varchar(20),
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create cctv table
            query = "CREATE TABLE asset_cctv (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        manufacturer varchar(50) NOT NULL,
                        model varchar(50) NOT NULL,
                        serial varchar(10),
                        channels varchar(10),
                        ip_address varchar(15),
                        account_username varchar(256) NOT NULL,
                        account_password varchar(256) NOT NULL,
                        location varchar(20),
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            ' Create cars table
            query = "CREATE TABLE asset_cars (
                        property_id int FOREIGN KEY REFERENCES properties(id),
                        username varchar(20) NOT NULL,
                        id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
                        manufacturer varchar(50) NOT NULL,
                        model varchar(50) NOT NULL,
                        owner varchar(50) NOT NULL,
                        owner_address varchar(50) NOT NULL,
                        registration_no varchar(8) NOT NULL,
                        mileage int,
            ); "

            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()

            cnn.Close()

            ' Set setup information in settings file
            SettingsINI.WriteINIValue("Startup", "FirstTime", "0")
            SettingsINI.WriteINIValue("Database", "Name", DBName.Text)

            ' Set important global variables
            GlobalVars.DBName = SettingsINI.ReadINIValue("Database", "Name")

            MessageBox.Show("Property Management .NET database installation has been successful!", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ParentMdiForm.Show()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Setup", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub AuthenticationCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles AuthenticationCheckBox.CheckedChanged

        DBUsername.Text = ""
        DBPassword.Text = ""

        If AuthenticationCheckBox.Checked Then
            DBUsername.Enabled = False
            DBPassword.Enabled = False

            DBUsername.Text = Environment.UserDomainName + "\" + Environment.UserName
        Else
            DBUsername.Enabled = True
            DBPassword.Enabled = True
        End If

    End Sub

    Private Sub SetupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class