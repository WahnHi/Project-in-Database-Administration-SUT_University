Imports System.Data
Imports System.Data.SqlClient

Public Class Patient_appointment
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select a.* , p.first_name , p.last_name , p.date_of_birth , p.gender , w.ward_name ,w.location
                                    from patient_appointment as a ,patient as p ,ward as w
                                    where a.patient_number = p.patient_number and a.ward_number = w.ward_number"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader

    Private Sub Patient_appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet1.ward' table. You can move, or remove it, as needed.
        Me.WardTableAdapter1.Fill(Me._wellmeadown_finalDataSet1.ward)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.ward' table. You can move, or remove it, as needed.
        Me.WardTableAdapter.Fill(Me._wellmeadown_finalDataSet.ward)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me._wellmeadown_finalDataSet.patient)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.patient_appointment' table. You can move, or remove it, as needed.
        Me.Patient_appointmentTableAdapter.Fill(Me._wellmeadown_finalDataSet.patient_appointment)

        btn_add.Text = "add"
        btn_edit.Text = "edit"



        Call start_clear()


        Call CAD()

    End Sub

    Private Sub start_clear()
        btn_add.Enabled = True
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_search.Enabled = True
        Appointment_numberTextBox.Enabled = False
        Patient_numberTextBox.Enabled = False
        First_nameTextBox.Enabled = False
        Last_nameTextBox.Enabled = False
        GenderTextBox.Enabled = False
        Date_of_birthDateTimePicker.Enabled = False
        Ward_numberTextBox.Enabled = False
        LocationTextBox.Enabled = False
        Cause_of_appointmentTextBox.Enabled = False
        Staff_numberTextBox.Enabled = False
        btn_save.Enabled = False
        textsearchp.Enabled = False
        textsearchw.Enabled = False

    End Sub

    Private Sub CAD()
        Appointment_numberTextBox.Clear()
        Patient_numberTextBox.Clear()
        First_nameTextBox.Clear()
        Last_nameTextBox.Clear()
        GenderTextBox.Clear()
        Ward_numberTextBox.Clear()
        LocationTextBox.Clear()
        Cause_of_appointmentTextBox.Clear()


    End Sub
    Private Sub ReadMydata(connection As String)

        sqlReader = sqlCommand.ExecuteReader()
        sqlReader.Read()

        Appointment_numberTextBox.Text = sqlReader.Item("Appointment_number")
        Patient_numberTextBox.Text = sqlReader.Item("patient_number")
        First_nameTextBox.Text = sqlReader.Item("First_name")
        Last_nameTextBox.Text = sqlReader.Item("Last_name")
        GenderTextBox.Text = sqlReader.Item("Gender")
        'Date_of_birthDateTimePicker.Text = sqlReader.Item(" Date_of_birthDate")
        Ward_numberTextBox.Text = sqlReader.Item("Ward_number")
        LocationTextBox.Text = sqlReader.Item("Location")
        Cause_of_appointmentTextBox.Text = sqlReader.Item("Cause_of_appointment")
        Staff_numberTextBox.Text = sqlReader.Item("Staff_number")

    End Sub


    Private Sub btn_add_Click(dender As Object, e As EventArgs) Handles btn_add.Click


        Call CAD()

        btn_add.Enabled = False
        btn_delete.Enabled = False
        btn_edit.Enabled = True
        btn_search.Enabled = False
        btn_save.Enabled = True
        Appointment_numberTextBox.Enabled = True
        Patient_numberTextBox.Enabled = True
        First_nameTextBox.Enabled = False
        Last_nameTextBox.Enabled = False
        GenderTextBox.Enabled = False
        Date_of_birthDateTimePicker.Enabled = False
        Ward_numberTextBox.Enabled = True
        LocationTextBox.Enabled = False
        Cause_of_appointmentTextBox.Enabled = True
        Staff_numberTextBox.Enabled = True

        textsearchp.Enabled = True
        textsearchw.Enabled = True

        btn_edit.Text = "cancle"

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        MessageBox.Show("ลบข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim sqlDelete As String = ("DELETE FROM patient_appointment where appointment_number = " & Appointment_numberTextBox.Text)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
        ReadMydata(connectionString)

        Call CAD()

        Call start_clear()

    End Sub

    Private Sub InsertMyData(connectionString As String)

        Dim sqlInsert As String = ("insert into patient_appointment (Appointment_number,Patient_number,Ward_number, Cause_of_appointment,Staff_number)
values (" & Appointment_numberTextBox.Text & ",'" & Patient_numberTextBox.Text & "','" & Ward_numberTextBox.Text & "','" & Cause_of_appointmentTextBox.Text & "','" & Staff_numberTextBox.Text & "')")


        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub
    Private Sub btn_edit_Click(dender As Object, e As EventArgs) Handles btn_edit.Click

        If btn_edit.Text = "edit" Then
            MessageBox.Show("อัพเดตข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateMyData(connectionString)

            ReadMydata(connectionString)
            Call CAD()
            Call start_clear()
        Else
            btn_add.Text = "add"
            btn_edit.Text = "edit"

            Call start_clear()
            Call CAD()



        End If

    End Sub
    Private Sub UpdateMyData(connectionString As String)

        Dim sqlUpdate As String = "Update patient_appointment set Patient_number = '" & Patient_numberTextBox.Text &
            "' ,Cause_of_appointment = '" & Cause_of_appointmentTextBox.Text &
            "',Staff_number = '" & Staff_numberTextBox.Text &
            "',Ward_number = '" & Ward_numberTextBox.Text & "'
            where Appointment_number = " & Appointment_numberTextBox.Text


        Debug.WriteLine(sqlUpdate)
        Dim sqlCommand As New SqlCommand(sqlUpdate, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()

    End Sub

    Private Sub textsearchv_Click(sender As Object, e As EventArgs) Handles textsearchp.Click

        patient_app_search.Show()

    End Sub

    Private Sub searchw_Click(sender As Object, e As EventArgs) Handles textsearchw.Click

        ward_app_search.Show()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        MessageBox.Show("บันทึกข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        InsertMyData(connectionString)

        ReadMydata(connectionString)

        btn_add.Text = "add"
        btn_edit.Text = "edit"


        btn_delete.Enabled = False
        btn_edit.Enabled = True
        btn_search.Enabled = True
        Call CAD()
        Call start_clear()
    End Sub

    Private Sub Textsearch_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btn_patient_Click(sender As Object, e As EventArgs) Handles btn_patient.Click
        patient.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnd_staff_allocation.Click
        staff_allocation.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_patient_allocation.Click
        patient_allocation.Show()
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

    Private Sub btn_vaccine_oder_Click(sender As Object, e As EventArgs) Handles btn_vaccine_oder.Click
        vaccine_order.Show()
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

    Private Sub btn_patient_appointment_Click(sender As Object, e As EventArgs) Handles btn_patient_appointment.Click

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        patient_appointment_search.Show()

    End Sub
End Class