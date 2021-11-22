Imports System.Data
Imports System.Data.SqlClient
Public Class staff_allocation_staff
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from staff"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub staff_allocation_staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub

    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select staff_number as 'Staff number' , first_name ++ ' ' ++ last_name as 'Name' , address as 'Address' , telephone as 'Telephone' , position as 'Position' from staff where concat(staff_number , first_name , last_name , address , telephone , position) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "select staff_number  , first_name , last_name  , address  , telephone  , position  from staff where concat(staff_number , first_name , last_name , address , telephone , position) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        staff_allocation.TextBox7.Text = sqlReader.Item("staff_number")
        staff_allocation.TextBox1.Text = sqlReader.Item("first_name")
        staff_allocation.TextBox2.Text = sqlReader.Item("last_name")
        staff_allocation.TextBox3.Text = sqlReader.Item("address")
        staff_allocation.TextBox4.Text = sqlReader.Item("telephone")
        staff_allocation.TextBox5.Text = sqlReader.Item("position")



        sqlReader.Close()
        sqlConnection.Close()

        Me.Close()

    End Sub
End Class