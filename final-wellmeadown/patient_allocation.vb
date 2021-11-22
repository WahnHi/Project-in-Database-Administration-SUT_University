Imports System.Data
Imports System.Data.SqlClient

Public Class patient_allocation

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select pa.* , w.ward_name , w.location , w.[tel extn] , s.first_name
                                   from m_patient_allocation as pa, ward as w , staff as s
                                   where pa.staff_number = s.staff_number and pa.ward_number = w.ward_name"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader

    Private Sub patient_allocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet1.patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me._wellmeadown_finalDataSet1.patient)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet1.d_patient_allocation' table. You can move, or remove it, as needed.
        Me.D_patient_allocationTableAdapter.Fill(Me._wellmeadown_finalDataSet1.d_patient_allocation)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.ward' table. You can move, or remove it, as needed.
        Me.WardTableAdapter.Fill(Me._wellmeadown_finalDataSet.ward)

        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.m_patient_allocation' table. You can move, or remove it, as needed.
        Me.M_patient_allocationTableAdapter.Fill(Me._wellmeadown_finalDataSet.m_patient_allocation)

        btn_add.Text = "add"
        btn_edit.Text = "edit"


    End Sub


    Private Sub ReadMydata(connection As String)
        Dim sqlSelectQuery As String = "select * from m_patient_allocation "
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader
        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()
        sqlReader.Read()

        Patient_allocation_numberTextBox.Text = sqlReader.Item("Patient_allocation_number")
        Ward_numberTextBox.Text = sqlReader.Item("Ward_number")
        Staff_numberTextBox.Text = sqlReader.Item("Staff_number")

        sqlReader.Close()
        sqlConnection.Close()
    End Sub

    Private Sub ReadMydata2(connection As String)

        Dim sqlSelectQuery As String = "select * from d_patient_allocation "
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        Patient_allocation_numberTextBox.Text = sqlReader.Item("patient_allocation_number")
        TextBox1.Text = sqlReader.Item("patient_number")
        DateTimePicker1.Value = sqlReader.Item("on_waiting_list")
        TextBox5.Text = sqlReader.Item("expected_stay_(days)")
        DateTimePicker2.Value = sqlReader.Item("date_placed")
        DateTimePicker3.Value = sqlReader.Item("date_lave")
        DateTimePicker4.Value = sqlReader.Item("actual_leave")
        TextBox9.Text = sqlReader.Item("bed_number")

        sqlReader.Close()
        sqlConnection.Close()

    End Sub

    Private Sub btn_add_Click(dender As Object, e As EventArgs) Handles btn_add.Click


        If btn_add.Text = "add" Then




            btn_edit.Text = "cancle"

        Else
            MessageBox.Show("บันทึกข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            InsertMyData(connectionString)
            ReadMydata(connectionString)


        End If

    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        MessageBox.Show("ลบข้อมูลวอร์ด " & Ward_numberTextBox.Text & Ward_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim sqlDelete2 As String = ("DELETE FROM d_patient_allocation where patient_allocation_number = " & Patient_allocation_numberTextBox.Text)
        Dim sqlCommand2 As New SqlCommand(sqlDelete2, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand2.ExecuteNonQuery()


        Dim sqlDelete As String = ("DELETE FROM m_patient_allocation where patient_allocation_number = " & Patient_allocation_numberTextBox.Text)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()


        ListView1.Items.Clear()
    End Sub
    Private Sub InsertMyData(connectionString As String)

        Dim sqlInsert As String = ("insert into m_patient_allocation (patient_allocation_number,Ward_number,Staff_number)
                                    values (" & Patient_allocation_numberTextBox.Text & ",'" & Ward_numberTextBox.Text & "','" & Staff_numberTextBox.Text & "')")

        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub

    Private Sub InsertMyData2(connectionString As String)

        Dim sqlInsert As String = ("insert into d_patient_allocation (patient_allocation_number  ,patient_number  ,on_waiting_list  ,[expected_stay_(days)] , date_placed , date_lave , actual_leave , bed_number)
        values(" & Patient_allocation_numberTextBox.Text & ",'" & TextBox1.Text & "' ,'" & DateTimePicker1.Value.ToString("MM/dd/yyyy") & "' ," & TextBox5.Text & " ,'" & DateTimePicker2.Value.ToString("MM/dd/yyyy") & "' ,'" & DateTimePicker3.Value.ToString("MM/dd/yyyy") & "' ,'" & DateTimePicker4.Value.ToString("MM/dd/yyyy") & "','" & TextBox9.Text & "')")

        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub

    Sub deleteData(connectionString As String)

        MessageBox.Show(" ลบข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Dim sqlDelete As String = ("DELETE FROM m_patient_allocation where patient_allocation_number = " & Patient_allocation_numberTextBox.Text)

        Debug.WriteLine(sqlDelete)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()





    End Sub
    Private Sub btn_edit_Click(dender As Object, e As EventArgs) Handles btn_edit.Click

        If btn_edit.Text = "edit" Then
            MessageBox.Show("ลบข้อมูลวอร์ด " & Ward_numberTextBox.Text & Ward_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateMyData(connectionString)

            ReadMydata(connectionString)

        Else

            btn_edit.Text = "edit"



        End If

    End Sub
    Private Sub UpdateMyData(connectionString As String)

        Dim sqlUpdate As String = "Update m_patient_allocation set Ward_number = '" & Ward_numberTextBox.Text &
            "' ,Staff_number = '" & Staff_numberTextBox.Text & "'
            where patient_allocation_number = " & Patient_allocation_numberTextBox.Text

        Debug.WriteLine(sqlUpdate)
        Dim sqlCommand As New SqlCommand(sqlUpdate, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        MessageBox.Show("บันทึกข้อมูลวอร์ด " & Ward_numberTextBox.Text & Ward_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        InsertMyData(connectionString)

        ReadMydata(connectionString)

        btn_edit.Text = "edit"


    End Sub

    Sub add()
        Dim item As New ListViewItem
        If TextBox9.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถถ้วน ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If ListView1.Items.Count = 0 Then
                item = ListView1.Items.Add(TextBox1.Text)
                item.SubItems.Add(TextBox2.Text)
                item.SubItems.Add(TextBox3.Text)
                item.SubItems.Add(DateTimePicker1.Value.ToString("MM/dd/yyyy"))
                item.SubItems.Add(TextBox5.Text)
                item.SubItems.Add(DateTimePicker2.Value.ToString("MM/dd/yyyy"))
                item.SubItems.Add(DateTimePicker3.Value.ToString("MM/dd/yyyy"))
                item.SubItems.Add(DateTimePicker4.Value.ToString("MM/dd/yyyy"))
                item.SubItems.Add(TextBox9.Text)
                InsertMyData2(connectionString)
                ReadMydata2(connectionString)

            Else
                With ListView1
                    Dim itm As ListViewItem
                    itm = .FindItemWithText(TextBox9.Text, True, 0, True)
                    If Not itm Is Nothing Then
                        MessageBox.Show("ข้อมูลของเตียง  " & TextBox9.Text & "  มีอยู่ในตารางอยู่แล้ว", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        item = ListView1.Items.Add(TextBox1.Text)
                        item.SubItems.Add(TextBox2.Text)
                        item.SubItems.Add(TextBox3.Text)
                        item.SubItems.Add(DateTimePicker1.Value.ToString("MM/dd/yyyy"))
                        item.SubItems.Add(TextBox5.Text)
                        item.SubItems.Add(DateTimePicker2.Value.ToString("MM/dd/yyyy"))
                        item.SubItems.Add(DateTimePicker3.Value.ToString("MM/dd/yyyy"))
                        item.SubItems.Add(DateTimePicker4.Value.ToString("MM/dd/yyyy"))
                        item.SubItems.Add(TextBox9.Text)
                        InsertMyData2(connectionString)
                        ReadMydata2(connectionString)
                    End If
                End With
            End If


        End If


    End Sub
    Private Sub btn_addview_Click(sender As Object, e As EventArgs) Handles btn_addview.Click

        Call add()

    End Sub
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        For i As Integer = ListView1.Items.Count - 1 To 0 Step -1
            If ListView1.Items(i).Selected Then ListView1.Items.RemoveAt(i)

        Next

        deleteData(connectionString)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then

            TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
            TextBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text
            DateTimePicker1.Value = ListView1.SelectedItems(0).SubItems(3).Text
            TextBox5.Text = ListView1.SelectedItems(0).SubItems(4).Text
            DateTimePicker2.Value = ListView1.SelectedItems(0).SubItems(5).Text
            DateTimePicker3.Value = ListView1.SelectedItems(0).SubItems(6).Text
            DateTimePicker4.Value = ListView1.SelectedItems(0).SubItems(7).Text
            TextBox9.Text = ListView1.SelectedItems(0).SubItems(8).Text
        End If
    End Sub



    Private Sub searchw_Click(sender As Object, e As EventArgs) Handles searchw.Click
        patient_allo_ward_search.Show()
    End Sub




    Private Sub btn_patient_Click(sender As Object, e As EventArgs) Handles btn_patient.Click
        patient.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnd_staff_allocation.Click
        staff_allocation.Show()
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
    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        staff.Show()
        Me.Close()
    End Sub

    Private Sub btn_patient_allocation_Click(sender As Object, e As EventArgs) Handles btn_patient_allocation.Click

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        patient_allo_search.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        patient_patient_search.Show()
    End Sub
End Class