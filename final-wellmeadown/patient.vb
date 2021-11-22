Imports System.Data
Imports System.Data.SqlClient

Public Class patient
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "Select * FROM patient"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader

    Private Sub patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me._wellmeadown_finalDataSet.patient)

        btn_add.Text = "add"
        btn_edit.Text = "edit"

        btn_edit.Enabled = False
        btn_delete.Enabled = False

        Call start_clear()


        Call CAD()

    End Sub
    Private Sub start_clear()
        btn_add.Enabled = True
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_select.Enabled = True
        btn_save.Enabled = False
        Patient_numberTextBox.Enabled = False
        First_nameTextBox.Enabled = False
        Last_nameTextBox.Enabled = False
        GenderTextBox.Enabled = False
        Registeretion_dateDateTimePicker.Enabled = False
        Marital_statusTextBox.Enabled = False
        AddressTextBox.Enabled = False
        TelephoneTextBox.Enabled = False
        Date_of_birthDateTimePicker.Enabled = False
        Nok_first_nameTextBox.Enabled = False
        Nok_last_nameTextBox.Enabled = False
        Nok_relationshipTextBox.Enabled = False
        Nok_addressTextBox.Enabled = False
        Nok_telephoneTextBox.Enabled = False
        Clinic_numberTextBox.Enabled = False

        First_nameTextBox1.Enabled = False
        Last_nameTextBox1.Enabled = False
        AddressTextBox1.Enabled = False
        TelephoneTextBox1.Enabled = False

        Button1.Enabled = False


    End Sub
    Private Sub CAD()
        Patient_numberTextBox.Clear()
        First_nameTextBox.Clear()
        Last_nameTextBox.Clear()
        GenderTextBox.Clear()

        Marital_statusTextBox.Clear()
        AddressTextBox.Clear()
        TelephoneTextBox.Clear()

        Nok_first_nameTextBox.Clear()
        Nok_last_nameTextBox.Clear()
        Nok_relationshipTextBox.Clear()
        Nok_addressTextBox.Clear()
        Nok_telephoneTextBox.Clear()
        Clinic_numberTextBox.Clear()

        First_nameTextBox1.Clear()
        Last_nameTextBox1.Clear()
        AddressTextBox1.Clear()
        TelephoneTextBox1.Clear()

    End Sub
    Private Sub ReadMydata(connection As String)

        sqlReader = sqlCommand.ExecuteReader()
        sqlReader.Read()


        Patient_numberTextBox.Text = sqlReader.Item("patient_number")
        First_nameTextBox.Text = sqlReader.Item("First_name")
        Last_nameTextBox.Text = sqlReader.Item("Last_name")
        GenderTextBox.Text = sqlReader.Item("Gender")
        Marital_statusTextBox.Text = sqlReader.Item("Marital_Status")
        AddressTextBox.Text = sqlReader.Item("Address")
        TelephoneTextBox.Text = sqlReader.Item("TelePhone")

        Nok_first_nameTextBox.Text = sqlReader.Item("NOK_First_Name")
        Nok_last_nameTextBox.Text = sqlReader.Item("NOK_Last_Name")
        Nok_relationshipTextBox.Text = sqlReader.Item("NOK_relationship")
        Nok_addressTextBox.Text = sqlReader.Item("NOK_Address")
        Nok_telephoneTextBox.Text = sqlReader.Item("NOK_Telephone")
        Clinic_numberTextBox.Text = sqlReader.Item("Clinic_number")

    End Sub
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_select.Click

        patient_search.Show()

    End Sub

    Private Sub btn_add_Click(dender As Object, e As EventArgs) Handles btn_add.Click



        Call CAD()

        btn_add.Enabled = False
        btn_delete.Enabled = False
        btn_edit.Enabled = True
        btn_select.Enabled = True
        btn_save.Enabled = True

        Patient_numberTextBox.Enabled = True
        First_nameTextBox.Enabled = True
        Last_nameTextBox.Enabled = True
        GenderTextBox.Enabled = True
        Registeretion_dateDateTimePicker.Enabled = True
        Marital_statusTextBox.Enabled = True
        AddressTextBox.Enabled = True
        TelephoneTextBox.Enabled = True
        Date_of_birthDateTimePicker.Enabled = True
        Nok_first_nameTextBox.Enabled = True
        Nok_last_nameTextBox.Enabled = True
        Nok_relationshipTextBox.Enabled = True
        Nok_addressTextBox.Enabled = True
        Nok_telephoneTextBox.Enabled = True
        Clinic_numberTextBox.Enabled = True
        Button1.Enabled = True

        btn_edit.Text = "cancle"

    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        MessageBox.Show("บันทึกข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        InsertMyData(connectionString)

        ReadMydata(connectionString)

        btn_add.Text = "add"
        btn_edit.Text = "edit"


        btn_delete.Enabled = False
        btn_edit.Enabled = True
        btn_select.Enabled = True
        Call CAD()
        Call start_clear()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim sqlDelete As String = ("DELETE FROM patient where patient_number = " & Patient_numberTextBox.Text)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
        ReadMydata(connectionString)
        Call CAD()
        Call start_clear()

    End Sub

    Private Sub InsertMyData(connectionString As String)

        Dim sqlInsert As String = ("insert into patient (patient_number,First_name,Last_name,Gender,Marital_Status,Address,TelePhone,NOK_First_Name,NOK_Last_Name,NOK_relationship,NOK_Address,NOK_Telephone,Clinic_number,Date_of_birth)
values (" & Patient_numberTextBox.Text & ",'" & First_nameTextBox.Text & "','" & Last_nameTextBox.Text & "','" & GenderTextBox.Text &
"','" & Marital_statusTextBox.Text & "','" & AddressTextBox.Text & "'," & TelephoneTextBox.Text & ",'" & Nok_first_nameTextBox.Text &
"','" & Nok_last_nameTextBox.Text & "','" & Nok_relationshipTextBox.Text & "','" & Nok_addressTextBox.Text &
"'," & Nok_telephoneTextBox.Text & ",'" & Clinic_numberTextBox.Text & "','" & Date_of_birthDateTimePicker.Text & "')")


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

            Call CAD()
            Call start_clear()

        End If

    End Sub
    Private Sub UpdateMyData(connectionString As String)

        Dim sqlUpdate As String = "Update patient set First_name = '" & First_nameTextBox.Text &
            "' ,Last_name = '" & Last_nameTextBox.Text &
            "',Gender = '" & GenderTextBox.Text &
            "',Marital_Status = '" & Marital_statusTextBox.Text &
            "',Address = '" & AddressTextBox.Text &
            "',Telephone = '" & TelephoneTextBox.Text &
            "',NOK_First_Name = '" & Nok_first_nameTextBox.Text &
            "',NOK_Last_Name = '" & Nok_last_nameTextBox.Text &
            "',NOK_relationship = '" & Nok_relationshipTextBox.Text &
            "',NOK_Address = '" & Nok_addressTextBox.Text &
            "',NOK_Telephone = '" & Nok_telephoneTextBox.Text &
            "',Clinic_number = '" & Clinic_numberTextBox.Text & "'
            where Patient_number = " & Patient_numberTextBox.Text


        Debug.WriteLine(sqlUpdate)
        Dim sqlCommand As New SqlCommand(sqlUpdate, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()

    End Sub



    Private Sub btn_patient_Click(sender As Object, e As EventArgs) Handles btn_patient.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnd_staff_allocation.Click
        staff_allocation.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_patient_allocation.Click
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

    Private Sub btn_vaccine_oder_Click(sender As Object, e As EventArgs) Handles btn_vaccine_oder.Click
        vaccine_order.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LOGIN.Show()
        Me.Close()
    End Sub

    Private Sub Nok_addressLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nok_addressTextBox_TextChanged(sender As Object, e As EventArgs) Handles Nok_addressTextBox.TextChanged

    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        staff.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        local_doc_search.Show()
    End Sub
End Class