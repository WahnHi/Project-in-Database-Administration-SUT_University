Imports System.Data
Imports System.Data.SqlClient
Public Class vaccine_order
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from orderer"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader

    Private Sub vaccine_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillterdata("")

    End Sub

    Public Sub fillterdata(valueTosearch As String)

        Dim sqlSelectQuery As String = "select o.order_id as 'Order id' , o.id_card as 'ID card' , o.first_name ++' '++ o.last_name as 'Name'  , o.telephone as 'Telephone' , o.vaccine_vaccine_id as 'Vaccine id', v.vaccine_name as 'Vaccine name' ,o.SYSNT_DATE AS 'Order date', o.first_dose ,  o.second_dose  from orderer as o , vaccine as v  where o.vaccine_vaccine_id = v.vaccine_number and concat(o.order_id  , o.id_card , o.first_name , o.last_name ,o.telephone, o.SYSNT_DATE ,o.vaccine_vaccine_id,v.vaccine_name, o.first_dose ,  o.second_dose) like '%" & valueTosearch & "%'"
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim adapter As New SqlDataAdapter(sqlCommand)
        Dim table As New DataTable()

        adapter.Fill(table)

        DataGridView1.DataSource = table

    End Sub
    Private Sub button1_click(sender As Object, e As EventArgs) Handles Button1.Click

        fillterdata(TextBox1.Text)
    End Sub
    Private Sub btn_patient_Click(sender As Object, e As EventArgs) Handles btn_patient.Click
        patient.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnd_staff_allocation.Click
        staff_allocation.Show()
        Me.Close()
    End Sub

    Private Sub btn_patient_allocation_Click(sender As Object, e As EventArgs) Handles btn_patient_allocation.Click
        patient_allocation.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_patient_appointment.Click
        Patient_appointment.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btn_patient_medication.Click
        patient_medication.Show()
        Me.Close()
    End Sub

    Private Sub btn_suppiler_Click(sender As Object, e As EventArgs) Handles btn_suppiler.Click
        Suppiler.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LOGIN.Show()
        Me.Close()
    End Sub
    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        staff.Show()
        Me.Close()
    End Sub


End Class