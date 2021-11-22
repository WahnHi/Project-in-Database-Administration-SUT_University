Imports System.Data
Imports System.Data.SqlClient
Public Class patient_allo_ward_search
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from m_ward_staff_allocation"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub patient_allo_ward_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub
    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select m.staff_allocation_number as 'Staff allocation number' , m.staff_number as 'Staff number' ,s.first_name ++' '++ s.last_name as 'Charge nurse' , m.ward_number as 'Ward number' , w.ward_name as 'Ward name' ,w.location as 'Location' ,w.[tel extn] as 'Tel extn' from m_ward_staff_allocation as m , ward as w , staff as s where m.ward_number = w.ward_number and m.staff_number = s.staff_number  and concat(m.staff_allocation_number , m.staff_number ,s.first_name , s.last_name  , m.ward_number , w.ward_name ,w.location, w.[tel extn]) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "select m.staff_allocation_number , m.staff_number ,s.first_name , s.last_name  , m.ward_number , w.ward_name,w.location,w.[tel extn] from m_ward_staff_allocation as m , ward as w , staff as s where m.ward_number = w.ward_number and m.staff_number = s.staff_number  and concat(m.staff_allocation_number , m.staff_number ,s.first_name , s.last_name  , m.ward_number , w.ward_name ,w.location, w.[tel extn]) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        patient_allocation.Ward_numberTextBox.Text = sqlReader.Item("Ward_number")
        patient_allocation.Ward_nameTextBox.Text = sqlReader.Item("Ward_name")
        patient_allocation.Staff_numberTextBox.Text = sqlReader.Item("Staff_number")
        patient_allocation.First_nameTextBox.Text = sqlReader.Item("first_name")
        patient_allocation.Last_nameTextBox.Text = sqlReader.Item("last_name")
        patient_allocation.LocationTextBox.Text = sqlReader.Item("Location")
        patient_allocation.Tel_extnTextBox.Text = sqlReader.Item("Tel extn")

        Me.Close()

    End Sub

End Class