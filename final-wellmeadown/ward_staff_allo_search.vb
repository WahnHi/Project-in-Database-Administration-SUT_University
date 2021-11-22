Imports System.Data
Imports System.Data.SqlClient
Public Class ward_staff_allo_search
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from ward"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub ward_staff_allo_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub

    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select ward_number as 'Ward number' , ward_name as 'Ward name' , location as 'Location' , [tel extn] as 'Tel extn' from ward where concat(ward_number , ward_name , location , [tel extn]) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "SELECT * FROM ward where concat(ward_number , ward_name , location , [tel extn]) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        staff_allocation.Ward_numberTextBox.Text = sqlReader.Item("Ward_number")
        staff_allocation.Ward_nameTextBox.Text = sqlReader.Item("Ward_name")
        staff_allocation.LocationTextBox.Text = sqlReader.Item("Location")
        staff_allocation.Tel_extnTextBox.Text = sqlReader.Item("Tel extn")

        Me.Close()

    End Sub
End Class