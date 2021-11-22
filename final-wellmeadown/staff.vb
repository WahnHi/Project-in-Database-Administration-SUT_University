Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization

Public Class staff
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from staff"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader

    Private Sub staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btn_add.Text = "add"
        btn_edit.Text = "edit"

        btn_edit.Enabled = False
        btn_delete.Enabled = False

        Call CAD()
        Call Start_clear()

    End Sub

    Private Sub Start_clear()
        btn_add.Enabled = True
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        btn_save.Enabled = False
        Staff_numberTextBox.Enabled = False
        First_nameTextBox.Enabled = False
        Last_nameTextBox.Enabled = False
        GenderTextBox.Enabled = False
        TelephoneTextBox.Enabled = False
        AddressTextBox.Enabled = False
        PositionTextBox.Enabled = False
        NinTextBox.Enabled = False
        Current_salaryTextBox.Enabled = False
        Salary_scaleTextBox.Enabled = False
        Painweekly_or_monthlyTextBox.Enabled = False
        Permanent_or_temporaryTextBox.Enabled = False
        Qft_typeTextBox.Enabled = False
        Qft_institutionTextBox.Enabled = False
        Wex_positionTextBox.Enabled = False
        Wex_organization_TextBox.Enabled = False
        Date_of_birthDateTimePicker.Enabled = False
        Qft_dateDateTimePicker.Enabled = False
        Wex_start_dateDateTimePicker.Enabled = False
        Wex_finish_dateDateTimePicker.Enabled = False

    End Sub
    Private Sub CAD()
        Staff_numberTextBox.Clear()
        First_nameTextBox.Clear()
        Last_nameTextBox.Clear()
        GenderTextBox.Clear()
        TelephoneTextBox.Clear()
        AddressTextBox.Clear()
        Date_of_birthDateTimePicker.Value = New DateTime(2001, 10, 20)
        PositionTextBox.Clear()
        NinTextBox.Clear()
        Current_salaryTextBox.Clear()
        Salary_scaleTextBox.Clear()
        Painweekly_or_monthlyTextBox.Clear()
        Permanent_or_temporaryTextBox.Clear()
        Qft_typeTextBox.Clear()
        Qft_dateDateTimePicker.Value = New DateTime(2001, 10, 20)
        Qft_institutionTextBox.Clear()
        Wex_positionTextBox.Clear()
        Wex_start_dateDateTimePicker.Value = New DateTime(2001, 10, 20)
        Wex_finish_dateDateTimePicker.Value = New DateTime(2001, 10, 20)
        Wex_organization_TextBox.Clear()



    End Sub
    Private Sub ReadMydata(connection As String)

        sqlReader = sqlCommand.ExecuteReader()
        sqlReader.Read()
        Staff_numberTextBox.Text = sqlReader.Item("Staff_Number")
        First_nameTextBox.Text = sqlReader.Item("First_name")
        Last_nameTextBox.Text = sqlReader.Item("Last_name")
        GenderTextBox.Text = sqlReader.Item("Gender")
        TelephoneTextBox.Text = sqlReader.Item("Telephone")
        Date_of_birthDateTimePicker.Value = sqlReader.Item("Date_of_birth")
        AddressTextBox.Text = sqlReader.Item("Address")
        PositionTextBox.Text = sqlReader.Item("Position")
        NinTextBox.Text = sqlReader.Item("NIN")
        Current_salaryTextBox.Text = sqlReader.Item("Current_Salary")
        Salary_scaleTextBox.Text = sqlReader.Item("Salary_Scale")
        Painweekly_or_monthlyTextBox.Text = sqlReader.Item("PainWeekly_or_Monthly")
        Permanent_or_temporaryTextBox.Text = sqlReader.Item("Permanent_or_Temporary")
        Qft_dateDateTimePicker.Value = sqlReader.Item("Qft_date")
        Qft_typeTextBox.Text = sqlReader.Item("QFT_Type")
        Qft_institutionTextBox.Text = sqlReader.Item("QFT_Institution")
        Wex_start_dateDateTimePicker.Value = sqlReader.Item("Wex_start_date")
        Wex_finish_dateDateTimePicker.Value = sqlReader.Item("Wex_finish_date")
        Wex_positionTextBox.Text = sqlReader.Item("WEX_position")
        Wex_organization_TextBox.Text = sqlReader.Item("WEX_Organization ")

    End Sub



    Private Sub btn_add_Click(dender As Object, e As EventArgs) Handles btn_add.Click

        Call CAD()

        btn_delete.Enabled = False
        btn_edit.Enabled = True
        btn_save.Enabled = True
        Staff_numberTextBox.Enabled = True
        First_nameTextBox.Enabled = True
        Last_nameTextBox.Enabled = True
        GenderTextBox.Enabled = True
        TelephoneTextBox.Enabled = True
        AddressTextBox.Enabled = True
        PositionTextBox.Enabled = True
        NinTextBox.Enabled = True
        Current_salaryTextBox.Enabled = True
        Salary_scaleTextBox.Enabled = True
        Painweekly_or_monthlyTextBox.Enabled = True
        Permanent_or_temporaryTextBox.Enabled = True
        Qft_typeTextBox.Enabled = True
        Qft_institutionTextBox.Enabled = True
        Wex_positionTextBox.Enabled = True
        Wex_organization_TextBox.Enabled = True
        Qft_dateDateTimePicker.Enabled = True
        Wex_start_dateDateTimePicker.Enabled = True
        Wex_finish_dateDateTimePicker.Enabled = True
        Date_of_birthDateTimePicker.Enabled = True

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
        Call CAD()
        Call Start_clear()
    End Sub

    Private Sub InsertMyData(connectionString As String)

        Dim sqlInsert As String = ("insert into Staff (Staff_Number,First_name,Last_name,Gender,Telephone,Address,Position,NIN,Current_Salary,Salary_Scale,PainWeekly_or_Monthly,Permanent_or_Temporary,QFT_Type,QFT_Institution,WEX_position,WEX_Organization ,Date_of_birth,Qft_date,Wex_start_date,Wex_finish_date)
        values(" & Staff_numberTextBox.Text & ",'" & First_nameTextBox.Text & "','" & Last_nameTextBox.Text &
        "','" & GenderTextBox.Text & "'," & TelephoneTextBox.Text & ",'" & AddressTextBox.Text & "','" & PositionTextBox.Text &
        "','" & NinTextBox.Text & "'," & Current_salaryTextBox.Text & ",'" & Salary_scaleTextBox.Text & "','" & Painweekly_or_monthlyTextBox.Text &
        "','" & Permanent_or_temporaryTextBox.Text & "','" & Qft_typeTextBox.Text & "','" & Qft_institutionTextBox.Text & "','" & Wex_positionTextBox.Text &
        "','" & Wex_organization_TextBox.Text & "','" & Date_of_birthDateTimePicker.Value.ToString("dd/MM/yyyy") & "','" & Qft_dateDateTimePicker.Value.ToString("dd/MM/yyyy") & "','" & Wex_start_dateDateTimePicker.Value.ToString("dd/MM/yyyy") & "','" & Wex_finish_dateDateTimePicker.Value.ToString("dd/MM/yyyy") & "')")



        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        MessageBox.Show(" ลบข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim sqlDelete As String = ("DELETE FROM staff where Staff_Number = " & Staff_numberTextBox.Text)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
        ReadMydata(connectionString)
        Call CAD()
    End Sub

    Private Sub btn_edit_Click(dender As Object, e As EventArgs) Handles btn_edit.Click

        If btn_edit.Text = "edit" Then
            MessageBox.Show("อัพเดตข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateMyData(connectionString)

            ReadMydata(connectionString)

            Call CAD()
            Call Start_clear()

        Else
            btn_add.Text = "add"
            btn_edit.Text = "edit"

            Call CAD()
            Call Start_clear()

        End If

    End Sub

    Private Sub UpdateMyData(connectionString As String)

        Dim sqlUpdate As String = "Update Staff set First_name = '" & First_nameTextBox.Text &
            "' ,Last_name = '" & Last_nameTextBox.Text &
            "',Gender = '" & GenderTextBox.Text &
            "',Telephone = '" & TelephoneTextBox.Text &
            "',Address = '" & AddressTextBox.Text &
            "',Position = '" & PositionTextBox.Text &
            "',NIN = '" & NinTextBox.Text &
            "',Current_Salary = '" & Current_salaryTextBox.Text &
            "',Salary_Scale = '" & Salary_scaleTextBox.Text &
            "',PainWeekly_or_Monthly = '" & Painweekly_or_monthlyTextBox.Text &
            "',Permanent_or_Temporary = '" & Permanent_or_temporaryTextBox.Text &
            "',QFT_Type = '" & Qft_typeTextBox.Text &
            "',QFT_Institution = '" & Qft_institutionTextBox.Text &
            "',WEX_position = '" & Wex_positionTextBox.Text &
            "',WEX_Organization = '" & Wex_organization_TextBox.Text & "'
            where Staff_Number = " & Staff_numberTextBox.Text

        Debug.WriteLine(sqlUpdate)
        Dim sqlCommand As New SqlCommand(sqlUpdate, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()

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

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        staff_search.Show()

    End Sub


End Class
