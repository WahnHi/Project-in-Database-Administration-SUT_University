Imports System.Data
Imports System.Data.SqlClient
Public Class patient_allo_search
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from staff"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub patient_allo_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub
    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select m.patient_allocation_number as 'Patient allocation number' , m.staff_number as 'Staff number' ,s.first_name ++' '++ s.last_name as 'Charge nurse' , m.ward_number as 'Ward number' , w.ward_name as 'Ward name' ,w.location as 'Location' ,w.[tel extn] as 'Tel extn' from m_patient_allocation as m , ward as w , staff as s where m.ward_number = w.ward_number and m.staff_number = s.staff_number  and concat(m.patient_allocation_number , m.staff_number ,s.first_name , s.last_name  , m.ward_number , w.ward_name ,w.location, w.[tel extn]) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "select m.patient_allocation_number  , m.staff_number  ,s.first_name , s.last_name  , m.ward_number  , w.ward_name  ,w.location  ,w.[tel extn]  from m_patient_allocation as m , ward as w , staff as s where m.ward_number = w.ward_number and m.staff_number = s.staff_number  and concat(m.patient_allocation_number , m.staff_number ,s.first_name , s.last_name  , m.ward_number , w.ward_name ,w.location, w.[tel extn]) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        patient_allocation.Patient_allocation_numberTextBox.Text = sqlReader.Item("Patient_allocation_number")
        patient_allocation.Ward_numberTextBox.Text = sqlReader.Item("Ward_number")
        patient_allocation.Ward_nameTextBox.Text = sqlReader.Item("Ward_name")
        patient_allocation.Staff_numberTextBox.Text = sqlReader.Item("Staff_number")
        patient_allocation.First_nameTextBox.Text = sqlReader.Item("first_name")
        patient_allocation.Last_nameTextBox.Text = sqlReader.Item("last_name")
        patient_allocation.LocationTextBox.Text = sqlReader.Item("Location")
        patient_allocation.Tel_extnTextBox.Text = sqlReader.Item("Tel extn")

        sqlReader.Close()
        sqlConnection.Close()

        Dim sqlSearch2 As String = "select d.patient_number , p.first_name , p.last_name , d.on_waiting_list , d.[expected_stay_(days)] , d.date_placed , d.date_lave , d.actual_leave , d.bed_number from d_patient_allocation as d , patient as p  where d.patient_number = p.patient_number  and concat(d.patient_allocation_number , d.patient_number ,p.first_name , p.last_name ) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection2 As New SqlConnection(connectionString)
        Dim sqlCommand2 As New SqlCommand(sqlSearch2, sqlConnection2)
        Dim sqlReader2 As SqlDataReader

        sqlConnection2.Open()
        sqlReader2 = sqlCommand2.ExecuteReader()

        While sqlReader2.Read

            Dim item As New ListViewItem

            item = patient_allocation.ListView1.Items.Add(sqlReader2.Item(0).ToString)
            item.SubItems.Add(sqlReader2.Item(1).ToString)
            item.SubItems.Add(sqlReader2.Item(2).ToString)
            item.SubItems.Add(sqlReader2.Item(3).ToString)
            item.SubItems.Add(sqlReader2.Item(4).ToString)
            item.SubItems.Add(sqlReader2.Item(5).ToString)
            item.SubItems.Add(sqlReader2.Item(6).ToString)
            item.SubItems.Add(sqlReader2.Item(7).ToString)
            item.SubItems.Add(sqlReader2.Item(8).ToString)
        End While

        sqlReader.Close()
        sqlConnection.Close()
        Me.Close()

    End Sub
End Class