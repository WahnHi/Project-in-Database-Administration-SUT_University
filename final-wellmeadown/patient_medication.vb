Imports System.Data
Imports System.Data.SqlClient

Public Class patient_medication

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select a.* , p.first_name , p.last_name , w.ward_name ,b.bed_number
                                    from m_patient_medication as a , ward as w , bed as b ,patient as p
                                    where a.Patient_Number = p. Patient_Number and w.ward_number = a.Ward_Number and b.bed_number = a.bed_number"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader

    Private Sub patient_medication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me._wellmeadown_finalDataSet.inventory)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.ward' table. You can move, or remove it, as needed.
        Me.WardTableAdapter.Fill(Me._wellmeadown_finalDataSet.ward)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me._wellmeadown_finalDataSet.patient)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.m_patient_medication' table. You can move, or remove it, as needed.
        Me.M_patient_medicationTableAdapter.Fill(Me._wellmeadown_finalDataSet.m_patient_medication)

        btn_add.Text = "add"
        btn_edit.Text = "edit"
        Call CAD()
    End Sub

    Private Sub CAD()
        Pmedication_numberTextBox.Clear()
        Patient_NumberTextBox.Clear()
        First_nameTextBox.Clear()
        Last_nameTextBox.Clear()
        Ward_NumberTextBox.Clear()
        Ward_nameTextBox.Clear()
        Bed_NumberTextBox.Clear()
        ListView1.Items.Clear()

    End Sub
    Private Sub ReadMydata(connection As String)

        sqlReader = sqlCommand.ExecuteReader()
        sqlReader.Read()

        Pmedication_numberTextBox.Text = sqlReader.Item("Pmedication_number")
        Patient_NumberTextBox.Text = sqlReader.Item("Patient_Number")
        First_nameTextBox.Text = sqlReader.Item("First_name")
        Last_nameTextBox.Text = sqlReader.Item("Last_name")
        Ward_NumberTextBox.Text = sqlReader.Item("Ward_Number")
        Ward_nameTextBox.Text = sqlReader.Item("Ward_name")
        Bed_NumberTextBox.Text = sqlReader.Item("Bed_Number")

    End Sub

    Private Sub ReadMydata2(connection As String)

        Dim sqlSelectQuery As String = "select * from d_patient_medication "
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        Pmedication_numberTextBox.Text = sqlReader.Item("Pmedication_number")
        TextBox1.Text = sqlReader.Item("inventory_number")
        DateTimePicker1.Value = sqlReader.Item("start_date")
        DateTimePicker2.Value = sqlReader.Item("finish_date")

        sqlReader.Close()
        sqlConnection.Close()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        patien_medi_search.Show()

    End Sub

    Private Sub btn_add_Click(dender As Object, e As EventArgs) Handles btn_add.Click


        If btn_add.Text = "add" Then


            Call CAD()

            btn_edit.Text = "cancle"

        Else
            MessageBox.Show("บันทึกข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            InsertMyData(connectionString)
            ReadMydata(connectionString)

            Call CAD()

        End If

    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        MessageBox.Show("ลบข้อมูลวอร์ด " & Ward_NumberTextBox.Text & Ward_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim sqlDelete2 As String = ("DELETE FROM d_patient_medication where pmedication_number = " & Pmedication_numberTextBox.Text)
        Dim sqlCommand2 As New SqlCommand(sqlDelete2, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand2.ExecuteNonQuery()

        Dim sqlDelete As String = ("DELETE FROM m_patient_medication where pmedication_number = " & Pmedication_numberTextBox.Text)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()


        ListView1.Items.Clear()

        Call CAD()


    End Sub
    Private Sub InsertMyData(connectionString As String)

        Dim sqlInsert As String = ("insert into m_patient_medication (pmedication_number,patient_number,Ward_number,bed_number)
                                    values (" & Pmedication_numberTextBox.Text & ",'" & Patient_NumberTextBox.Text & "','" & Ward_NumberTextBox.Text & "','" & Bed_NumberTextBox.Text & "')")

        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub
    Private Sub InsertMyData2(connectionString As String)

        Dim sqlInsert As String = ("insert into d_patient_medication (Pmedication_number , inventory_number ,start_date,finish_date)
        values(" & Pmedication_numberTextBox.Text & ",'" & TextBox1.Text & "' , '" & DateTimePicker1.Value.ToString("MM/dd/yyyy") & "', '" & DateTimePicker2.Value.ToString("MM/dd/yyyy") & "')")


        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub

    Sub deleteData(connectionString As String)

        Dim sqlDelete As String = ("DELETE FROM d_patient_medication where inventory_number = " & TextBox1.Text)

        Debug.WriteLine(sqlDelete)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
        ReadMydata2(connectionString)

    End Sub
    Private Sub btn_edit_Click(dender As Object, e As EventArgs) Handles btn_edit.Click

        If btn_edit.Text = "edit" Then
            MessageBox.Show("ลบข้อมูลวอร์ด " & Ward_NumberTextBox.Text & Ward_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateMyData(connectionString)

            ReadMydata(connectionString)
            Call CAD()

        Else

            btn_edit.Text = "edit"

            Call CAD()

        End If

    End Sub
    Private Sub UpdateMyData(connectionString As String)

        Dim sqlUpdate As String = "Update m_patient_medication set Ward_number = '" & Ward_NumberTextBox.Text &
            "' ,patient_number = '" & Patient_NumberTextBox.Text &
            "' ,bed_number = '" & Bed_NumberTextBox.Text & "'
            where pmedication_number = " & Pmedication_numberTextBox.Text

        Debug.WriteLine(sqlUpdate)
        Dim sqlCommand As New SqlCommand(sqlUpdate, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()

    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click


        MessageBox.Show("บันทึกข้อมูลวอร์ด " & Ward_NumberTextBox.Text & Ward_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        InsertMyData(connectionString)

        ReadMydata(connectionString)

        btn_edit.Text = "edit"

    End Sub

    Sub add()
        Dim item As New ListViewItem
        If TextBox4.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถถ้วน ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If ListView1.Items.Count = 0 Then
                item = ListView1.Items.Add(TextBox1.Text)
                item.SubItems.Add(TextBox2.Text)
                item.SubItems.Add(TextBox3.Text)
                item.SubItems.Add(TextBox4.Text)
                item.SubItems.Add(TextBox5.Text)
                item.SubItems.Add(TextBox6.Text)
                item.SubItems.Add(DateTimePicker1.Value.ToString("dd/MM/yyyy"))
                item.SubItems.Add(DateTimePicker2.Value.ToString("dd/MM/yyyy"))
                InsertMyData2(connectionString)
                ReadMydata2(connectionString)

            Else
                With ListView1
                    Dim itm As ListViewItem
                    itm = .FindItemWithText(TextBox1.Text, True, 0, True)
                    If Not itm Is Nothing Then
                        MessageBox.Show("ข้อมูลของ  " & TextBox1.Text & "  " & TextBox2.Text & " มีอยู่ในตารางอยู่แล้ว", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        item = ListView1.Items.Add(TextBox1.Text)
                        item.SubItems.Add(TextBox2.Text)
                        item.SubItems.Add(TextBox3.Text)
                        item.SubItems.Add(TextBox4.Text)
                        item.SubItems.Add(TextBox5.Text)
                        item.SubItems.Add(TextBox6.Text)
                        item.SubItems.Add(DateTimePicker1.Value.ToString("dd/MM/yyyy"))
                        item.SubItems.Add(DateTimePicker2.Value.ToString("dd/MM/yyyy"))
                        InsertMyData2(connectionString)
                        ReadMydata2(connectionString)
                    End If
                End With
            End If
        End If


    End Sub
    Private Sub searchp_Click(sender As Object, e As EventArgs) Handles searchp.Click
        patient_search_patient_medi.Show()
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
            TextBox4.Text = ListView1.SelectedItems(0).SubItems(3).Text
            TextBox5.Text = ListView1.SelectedItems(0).SubItems(4).Text
            TextBox6.Text = ListView1.SelectedItems(0).SubItems(5).Text
            DateTimePicker1.Value = ListView1.SelectedItems(0).SubItems(6).Text
            DateTimePicker2.Value = ListView1.SelectedItems(0).SubItems(7).Text
        End If
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        medication_search.Show()
    End Sub

    Private Sub btn_patient_medication_Click(sender As Object, e As EventArgs) Handles btn_patient_medication.Click

    End Sub

    Private Sub Pmedication_numberLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class