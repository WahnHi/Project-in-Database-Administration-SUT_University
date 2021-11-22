Imports System.Data
Imports System.Data.SqlClient

Public Class staff_allocation
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select m.* , w.ward_name,w.location,w.[tel extn],s.first_name
                                    from m_ward_staff_allocation as m , ward as w , staff as s
                                    where m.ward_number = w.ward_number and m.staff_number = s.staff_number "
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader

    Private Sub staff_allocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.d_ward_staff_allocation' table. You can move, or remove it, as needed.
        Me.D_ward_staff_allocationTableAdapter.Fill(Me._wellmeadown_finalDataSet.d_ward_staff_allocation)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.m_ward_staff_allocation' table. You can move, or remove it, as needed.
        Me.M_ward_staff_allocationTableAdapter.Fill(Me._wellmeadown_finalDataSet.m_ward_staff_allocation)

        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.ward' table. You can move, or remove it, as needed.
        Me.WardTableAdapter.Fill(Me._wellmeadown_finalDataSet.ward)
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet.m_patient_allocation' table. You can move, or remove it, as needed.
        Me.M_patient_allocationTableAdapter.Fill(Me._wellmeadown_finalDataSet.m_patient_allocation)

        Call CAD()
        btn_add.Text = "add"
        btn_edit.Text = "edit"


    End Sub

    Private Sub CAD()
        Staff_allocation_numberTextBox.Clear()
        Ward_numberTextBox.Clear()
        Ward_nameTextBox.Clear()
        LocationTextBox.Clear()
        Tel_extnTextBox.Clear()
        Staff_numberTextBox.Clear()
        First_nameTextBox.Clear()
        Last_nameTextBox.Clear()
        ListView1.Items.Clear()

    End Sub


    Private Sub ReadMydata(connection As String)

        sqlReader = sqlCommand.ExecuteReader()
        sqlReader.Read()

        Staff_allocation_numberTextBox.Text = sqlReader.Item("Staff_allocation_number")
        Ward_numberTextBox.Text = sqlReader.Item("Ward_number")
        Ward_nameTextBox.Text = sqlReader.Item("Ward_name")
        LocationTextBox.Text = sqlReader.Item("Location")
        Tel_extnTextBox.Text = sqlReader.Item("Tel extn")
        Staff_numberTextBox.Text = sqlReader.Item("Staff_number")
        First_nameTextBox.Text = sqlReader.Item("First_name")
    End Sub

    Private Sub ReadMydata2(connection As String)

        Dim sqlSelectQuery As String = "select * from d_ward_staff_allocation "
        Dim sqlConnection As New SqlConnection(connectionString)
        Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
        Dim sqlReader As SqlDataReader

        sqlConnection.Open()
        sqlReader = sqlCommand.ExecuteReader()

        sqlReader.Read()

        Staff_allocation_numberTextBox.Text = sqlReader.Item("Staff_allocation_number")
        TextBox7.Text = sqlReader.Item("Staff_number")
        TextBox6.Text = sqlReader.Item("shift")

        sqlReader.Close()
        sqlConnection.Close()

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
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        MessageBox.Show("บันทึกข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        InsertMyData(connectionString)

        ReadMydata(connectionString)

        btn_edit.Text = "edit"

        Call CAD()
    End Sub

    Private Sub InsertMyData(connectionString As String)

        Dim sqlInsert As String = ("insert into m_ward_staff_allocation (Staff_allocation_number,Ward_number,Staff_number)
        values(" & Staff_allocation_numberTextBox.Text & ",'" & Ward_numberTextBox.Text & "','" & Staff_numberTextBox.Text & "')")

        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub

    Private Sub InsertMyData2(connectionString As String)

        Dim sqlInsert As String = ("insert into d_ward_staff_allocation (Staff_allocation_number , staff_number ,shift )
        values(" & Staff_allocation_numberTextBox.Text & ",'" & TextBox7.Text & "' , '" & TextBox6.Text & "')")

        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub

    Sub deleteData(connectionString As String)

        Dim sqlDelete As String = ("DELETE FROM d_ward_staff_allocation where STAFF_NUMBER = " & TextBox7.Text)

        Debug.WriteLine(sqlDelete)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
        ReadMydata2(connectionString)

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        MessageBox.Show(" ลบข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim sqlDelete2 As String = ("DELETE FROM d_ward_staff_allocation where Staff_allocation_number = " & Staff_allocation_numberTextBox.Text)
        Dim sqlCommand2 As New SqlCommand(sqlDelete2, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand2.ExecuteNonQuery()


        Dim sqlDelete As String = ("DELETE FROM m_ward_staff_allocation where Staff_allocation_number = " & Staff_allocation_numberTextBox.Text)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()

        ListView1.Items.Clear()

        Call CAD()
    End Sub
    Private Sub btn_edit_Click(dender As Object, e As EventArgs) Handles btn_edit.Click

        If btn_edit.Text = "edit" Then
            MessageBox.Show("อัพเดตข้อมูล " & First_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateMyData(connectionString)

            ReadMydata(connectionString)

        Else
            btn_edit.Text = "edit"

            Call CAD()

        End If

    End Sub

    Sub UpdateMyData(connectionString As String)

        Dim sqlUpdate As String = "Update m_ward_staff_allocation set Ward_number = '" & Ward_numberTextBox.Text &
            "' ,Staff_number= '" & Staff_numberTextBox.Text &
           "' where Staff_allocation_number = " & Staff_allocation_numberTextBox.Text

        Debug.WriteLine(sqlUpdate)
        Dim sqlCommand As New SqlCommand(sqlUpdate, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()

    End Sub



    Sub add()
        Dim item As New ListViewItem
        If TextBox6.Text = "" Then
                MessageBox.Show("กรุณากรอกข้อมูล Shift ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
            If ListView1.Items.Count = 0 Then
                item = ListView1.Items.Add(TextBox7.Text)
                item.SubItems.Add(TextBox1.Text)
                item.SubItems.Add(TextBox2.Text)
                item.SubItems.Add(TextBox3.Text)
                item.SubItems.Add(TextBox4.Text)
                item.SubItems.Add(TextBox5.Text)
                item.SubItems.Add(TextBox6.Text)
                InsertMyData2(connectionString)
                ReadMydata2(connectionString)

            Else
                With ListView1
                        Dim itm As ListViewItem
                        itm = .FindItemWithText(TextBox7.Text, True, 0, True)
                    If Not itm Is Nothing Then
                        MessageBox.Show("ข้อมูลของ  " & TextBox7.Text & "  " & TextBox1.Text & "  " & TextBox2.Text & "  มีอยู่ในตารางอยู่แล้ว", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        item = ListView1.Items.Add(TextBox7.Text)
                        item.SubItems.Add(TextBox1.Text)
                        item.SubItems.Add(TextBox2.Text)
                        item.SubItems.Add(TextBox3.Text)
                        item.SubItems.Add(TextBox4.Text)
                        item.SubItems.Add(TextBox5.Text)
                        item.SubItems.Add(TextBox6.Text)
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

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        ListView1.Items.Clear()
    End Sub


    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem1.Click
        For i As Integer = ListView1.Items.Count - 1 To 0 Step -1
            If ListView1.Items(i).Selected Then ListView1.Items.RemoveAt(i)

        Next

        deleteData(connectionString)
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            TextBox7.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox1.Text = ListView1.SelectedItems(0).SubItems(1).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(2).Text
            TextBox3.Text = ListView1.SelectedItems(0).SubItems(3).Text
            TextBox4.Text = ListView1.SelectedItems(0).SubItems(4).Text
            TextBox5.Text = ListView1.SelectedItems(0).SubItems(5).Text
            TextBox6.Text = ListView1.SelectedItems(0).SubItems(6).Text
        End If
    End Sub










    Private Sub btn_patient_Click(sender As Object, e As EventArgs) Handles btn_patient.Click
        patient.Show()
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
    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        staff.Show()
        Me.Close()
    End Sub

    Private Sub Ward_numberLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ward_staff_allo_search.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        staff_staff_allo_search.Show()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        staff_allocation_search.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        staff_allocation_staff.Show()
    End Sub


End Class