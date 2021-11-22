Imports System.Data
Imports System.Data.SqlClient
Public Class suppuiler_sarch
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from staff"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub suppuiler_sarch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub

    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select  Supplier_number as 'Supplier number' , [Suppliers name] , ardress as 'Address' , telephone as 'Telephone' , [Fax numbers] from suppliers  where concat( Supplier_number  , [Suppliers name] , ardress  , telephone ,[Fax numbers] ) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "select  Supplier_number  , [Suppliers name] , ardress  , telephone  , [Fax numbers] from suppliers  where concat( Supplier_number  , [Suppliers name] , ardress  , telephone ,[Fax numbers]) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        Suppiler.Supplier_NumberTextBox.Text = sqlReader.Item("Supplier_number")
        Suppiler.Suppliers_nameTextBox.Text = sqlReader.Item("Suppliers name")
        Suppiler.ArdressTextBox.Text = sqlReader.Item("ardress")
        Suppiler.ArdressTextBox.Text = sqlReader.Item("telephone")
        Suppiler.TelephoneTextBox.Text = sqlReader.Item("telephone")
        Suppiler.Fax_numbersTextBox.Text = sqlReader.Item("Fax numbers")

        sqlReader.Close()
        sqlConnection.Close()

        Me.Close()

    End Sub

End Class