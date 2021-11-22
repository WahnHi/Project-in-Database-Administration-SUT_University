
Imports System.Data
        Imports System.Data.SqlClient
Public Class patient_patient_search
        Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

        Dim sqlSelectQuery As String = "select * from patient"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader
        Private Sub patient_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            fillterdata("")

        End Sub
        Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select patient_number as 'Patient number' , first_name ++ '  ' ++ last_name as 'Name' from patient where concat(patient_number , first_name , last_name ) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "SELECT *  FROM patient where concat(patient_number , first_name , last_name ) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
            Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
            Dim sqlReader As SqlDataReader

            sqlConnection.Open()
            sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        patient_allocation.TextBox1.Text = sqlReader.Item("patient_number")
        patient_allocation.TextBox2.Text = sqlReader.Item("first_name")
        patient_allocation.TextBox3.Text = sqlReader.Item("last_name")


        sqlConnection.Close()


        Me.Close()

        End Sub

    End Class
