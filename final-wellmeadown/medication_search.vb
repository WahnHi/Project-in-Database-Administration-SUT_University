Imports System.Data
Imports System.Data.SqlClient
Public Class medication_search
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from inventory"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub medication_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub

    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select * from inventory where stock_number = 02 and concat(inventory_number , name ) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "select * from inventory where stock_number = 02 and concat(inventory_number , name ) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        patient_medication.TextBox1.Text = sqlReader.Item("inventory_number")
        patient_medication.TextBox2.Text = sqlReader.Item("name")
        patient_medication.TextBox3.Text = sqlReader.Item("description")
        patient_medication.TextBox5.Text = sqlReader.Item("method_of_admin")
        patient_medication.TextBox6.Text = sqlReader.Item("cost_per_unit")



        sqlReader.Close()
        sqlConnection.Close()


        Me.Close()

    End Sub



End Class