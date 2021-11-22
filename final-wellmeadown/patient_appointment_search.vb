Imports System.Data
Imports System.Data.SqlClient
Public Class patient_appointment_search
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from patient"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Private Sub patient_appointment_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub

    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select a.appointment_number , a.patient_number , p.first_name , p.last_name , s.staff_number , a.ward_number , w.ward_name  from patient_appointment as a , patient as p , staff as s ,ward as w where a.patient_number = p.patient_number and a.staff_number = s.staff_number and a.ward_number = w.ward_number and concat(a.appointment_number , a.patient_number , p.first_name , p.last_name , s.staff_number , a.ward_number , w.ward_name ) like '%" & valueTosearch & "%'"
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

        Dim sqlSearch As String = "select a.* ,  p.* , s.* , w.*  from patient_appointment as a , patient as p , staff as s ,ward as w where a.patient_number = p.patient_number and a.staff_number = s.staff_number and a.ward_number = w.ward_number and concat(a.appointment_number , a.patient_number , p.first_name , p.last_name , s.staff_number , a.ward_number , w.ward_name ) like '%" & TextBox1.Text & "%'"
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSearch, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()
        Patient_appointment.Appointment_numberTextBox.Text = sqlReader.Item("Appointment_number")
        Patient_appointment.Patient_numberTextBox.Text = sqlReader.Item("Patient_number")
        Patient_appointment.First_nameTextBox.Text = sqlReader.Item("First_name")
        Patient_appointment.Last_nameTextBox.Text = sqlReader.Item("Last_name")
        Patient_appointment.GenderTextBox.Text = sqlReader.Item("Gender")
        Patient_appointment.Ward_numberTextBox.Text = sqlReader.Item("Ward_number")
        Patient_appointment.Ward_nameTextBox.Text = sqlReader.Item("Ward_name")
        Patient_appointment.LocationTextBox.Text = sqlReader.Item("Location")
        Patient_appointment.Cause_of_appointmentTextBox.Text = sqlReader.Item("Cause_of_appointment")

        Patient_appointment.btn_add.Enabled = True
        Patient_appointment.btn_edit.Enabled = True
        Patient_appointment.btn_delete.Enabled = True
        Patient_appointment.btn_search.Enabled = True
        Patient_appointment.Appointment_numberTextBox.Enabled = False
        Patient_appointment.Patient_numberTextBox.Enabled = True
        Patient_appointment.First_nameTextBox.Enabled = True
        Patient_appointment.Last_nameTextBox.Enabled = True
        Patient_appointment.GenderTextBox.Enabled = True
        Patient_appointment.Date_of_birthDateTimePicker.Enabled = True
        Patient_appointment.Ward_numberTextBox.Enabled = True
        Patient_appointment.LocationTextBox.Enabled = True
        Patient_appointment.Cause_of_appointmentTextBox.Enabled = True
        Patient_appointment.Staff_numberTextBox.Enabled = True
        Patient_appointment.btn_save.Enabled = True
        Patient_appointment.textsearchp.Enabled = True
        Patient_appointment.textsearchw.Enabled = True

        Me.Close()

    End Sub
End Class