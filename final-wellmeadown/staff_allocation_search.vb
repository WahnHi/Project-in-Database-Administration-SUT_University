Imports System.Data
Imports System.Data.SqlClient
Public Class staff_allocation_search
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from staff"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub staff_allocation_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub
    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select m.staff_allocation_number as 'Staff allocation number', s.staff_number as 'Staff number' , s.first_name ++' '++ s.last_name as 'Name', w.ward_number as 'Ward number' , w.ward_name  as 'Ward name'  from m_ward_staff_allocation as m , staff as s , ward as w where m.staff_number = s.staff_number and m.ward_number = w.ward_number and concat(m.staff_allocation_number , w.ward_number , w.ward_name , s.staff_number , s.first_name , s.last_name) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "select m.* , w.* , s.*  from m_ward_staff_allocation as m , staff as s , ward as w where m.staff_number = s.staff_number and m.ward_number = w.ward_number and concat(m.staff_allocation_number , w.ward_number , w.ward_name , s.staff_number , s.first_name , s.last_name) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        staff_allocation.Staff_allocation_numberTextBox.Text = sqlReader.Item("Staff_allocation_number")
        staff_allocation.Staff_numberTextBox.Text = sqlReader.Item("staff_number")
        staff_allocation.First_nameTextBox.Text = sqlReader.Item("first_name")
        staff_allocation.Last_nameTextBox.Text = sqlReader.Item("last_name")
        staff_allocation.Ward_numberTextBox.Text = sqlReader.Item("Ward_number")
        staff_allocation.Ward_nameTextBox.Text = sqlReader.Item("Ward_name")
        staff_allocation.LocationTextBox.Text = sqlReader.Item("Location")
        staff_allocation.Tel_extnTextBox.Text = sqlReader.Item("Tel extn")



        Dim sqlSearch2 As String = "select m.staff_number , s.first_name , s.last_name , s.address , s.telephone , s.position , m.shift  
                                   from d_ward_staff_allocation as m , staff as s  where m.staff_number = s.staff_number  
                                   and concat(m.staff_allocation_number , s.staff_number , s.first_name , s.last_name) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection2 As New SqlConnection(connectionString)
        Dim sqlCommand2 As New SqlCommand(sqlSearch2, sqlConnection2)
        Dim sqlReader2 As SqlDataReader

        sqlConnection2.Open()
        sqlReader2 = sqlCommand2.ExecuteReader()

        While sqlReader2.Read

            Dim item As New ListViewItem
            item = staff_allocation.ListView1.Items.Add(sqlReader2.Item(0).ToString)
            item.SubItems.Add(sqlReader2.Item(1).ToString)
            item.SubItems.Add(sqlReader2.Item(2).ToString)
            item.SubItems.Add(sqlReader2.Item(3).ToString)
            item.SubItems.Add(sqlReader2.Item(4).ToString)
            item.SubItems.Add(sqlReader2.Item(5).ToString)
            item.SubItems.Add(sqlReader2.Item(6).ToString)

        End While

        Me.Close()
    End Sub
End Class