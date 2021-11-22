Imports System.Data
Imports System.Data.SqlClient
Public Class patien_medi_search
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from m_patient_medication"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub patien_medi_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub
    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select m.pmedication_number as 'Patient medication number' , m.patient_number as 'Patient number', p.first_name ++' '++ p.last_name as 'Name' from m_patient_medication as m , patient as p where m.patient_number = p.patient_number and concat(m.pmedication_number , m.patient_number , p.first_name , p.last_name) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "select a.* , p.first_name , p.last_name , w.ward_name ,b.bed_number
                                    from m_patient_medication as a , ward as w , bed as b ,patient as p
                                    where a.Patient_Number = p. Patient_Number and w.ward_number = a.Ward_Number and b.bed_number = a.bed_number  and concat(a.pmedication_number , a.patient_number , p.first_name , p.last_name) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        patient_medication.Pmedication_numberTextBox.Text = sqlReader.Item("Pmedication_number")
        patient_medication.Patient_NumberTextBox.Text = sqlReader.Item("Patient_Number")
        patient_medication.First_nameTextBox.Text = sqlReader.Item("First_name")
        patient_medication.Last_nameTextBox.Text = sqlReader.Item("Last_name")
        patient_medication.Ward_NumberTextBox.Text = sqlReader.Item("Ward_Number")
        patient_medication.Ward_nameTextBox.Text = sqlReader.Item("Ward_name")
        patient_medication.Bed_NumberTextBox.Text = sqlReader.Item("Bed_Number")


        sqlReader.Close()
        sqlConnection.Close()

        Dim sqlSearch2 As String = "select d.inventory_number ,  i.name , i.description , i.[size/osage], i.method_of_admin ,i.cost_per_unit,d.start_date,d.finish_date
                                    From inventory as i , d_patient_medication as d 
                                    Where i.inventory_number = d.inventory_number  
                                    and d.pmedication_number Like '%" & TextBox1.Text & "%'"
        Dim sqlConnection2 As New SqlConnection(connectionString)
        Dim sqlCommand2 As New SqlCommand(sqlSearch2, sqlConnection2)
        Dim sqlReader2 As SqlDataReader

        sqlConnection2.Open()
        sqlReader2 = sqlCommand2.ExecuteReader()

        While sqlReader2.Read

            Dim item As New ListViewItem
            item = patient_medication.ListView1.Items.Add(sqlReader2.Item(0).ToString)
            item.SubItems.Add(sqlReader2.Item(1).ToString)
            item.SubItems.Add(sqlReader2.Item(2).ToString)
            item.SubItems.Add(sqlReader2.Item(3).ToString)
            item.SubItems.Add(sqlReader2.Item(4).ToString)
            item.SubItems.Add(sqlReader2.Item(5).ToString)
            item.SubItems.Add(sqlReader2.Item(6).ToString)
            item.SubItems.Add(sqlReader2.Item(7).ToString)

        End While

        Me.Close()

    End Sub
End Class