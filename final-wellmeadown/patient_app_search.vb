
Imports System.Data
    Imports System.Data.SqlClient
    Public Class patient_app_search
        Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

        Dim sqlSelectQuery As String = "select * from patient"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader
        Private Sub patient_app_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            fillterdata("")

        End Sub
        Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select p.patient_number as 'Patient number' , p.first_name ++ '  ' ++ p.last_name as 'Name' , p.clinic_number as 'Clinic number' ,l.cfirst_name ++ '  ' ++ l.clast_name as 'Doctor name'  from patient as p , local_doctor as l where p.clinic_number = l.clinic_number and concat(p.patient_number , p.first_name , p.last_name , p.clinic_number , l.cfirst_name , l.clast_name ) like '%" & valueTosearch & "%'"
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
            Dim adapter As New SqlDataAdapter(sqlCommand)
            Dim table As New DataTable()

            adapter.Fill(table)

            DataGridView1.DataSource = table

        End Sub
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

            fillterdata(TextBox1.Text)

        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

            Dim sqlSearch As String = "SELECT p.* , l.* FROM patient as p , local_doctor as l where p.clinic_number = l.clinic_number and concat(p.patient_number , p.first_name , p.last_name , p.clinic_number , l.cfirst_name , l.clast_name) like '%" & TextBox1.Text & "%'"
            Dim sqlConnection As New SqlConnection(connectionString)
            Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
            Dim sqlReader As SqlDataReader

            sqlConnection.Open()
            sqlReader = sqlCommand.ExecuteReader()

            sqlReader.Read()


        Patient_appointment.Patient_numberTextBox.Text = sqlReader.Item("patient_number")
            Patient_appointment.First_nameTextBox.Text = sqlReader.Item("First_name")
            Patient_appointment.Last_nameTextBox.Text = sqlReader.Item("Last_name")
            Patient_appointment.GenderTextBox.Text = sqlReader.Item("Gender")

            Me.Close()

        End Sub

End Class