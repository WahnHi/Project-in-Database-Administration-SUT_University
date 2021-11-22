Imports System.Data
Imports System.Data.SqlClient
Public Class patient_search_patient_medi
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from staff"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub patient_search_patient_medi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub
    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select  patient_number as 'Patient number' , first_name ++ ' ' ++ last_name as 'Name' from  patient  where concat( patient_number , first_name , last_name) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "select a.* , m.ward_number , p.first_name , p.last_name , w.ward_name ,b.bed_number
                                    from m_patient_allocation as m , d_patient_allocation as a , ward as w , bed as b ,patient as p
                                    where a.patient_allocation_number = m.patient_allocation_number and a.Patient_Number = p. Patient_Number and w.ward_number = m.Ward_Number and b.bed_number = a.bed_number  and concat( a.patient_number , p.first_name , p.last_name) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        patient_medication.Patient_NumberTextBox.Text = sqlReader.Item("Patient_Number")
        patient_medication.First_nameTextBox.Text = sqlReader.Item("First_name")
        patient_medication.Last_nameTextBox.Text = sqlReader.Item("Last_name")
        patient_medication.Ward_NumberTextBox.Text = sqlReader.Item("Ward_Number")
        patient_medication.Ward_nameTextBox.Text = sqlReader.Item("Ward_name")
        patient_medication.Bed_NumberTextBox.Text = sqlReader.Item("Bed_Number")


        sqlReader.Close()
        sqlConnection.Close()

        Me.Close()


    End Sub
End Class