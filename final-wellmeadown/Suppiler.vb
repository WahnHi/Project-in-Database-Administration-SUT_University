Imports System.Data
Imports System.Data.SqlClient
Public Class Suppiler

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from suppliers"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader

    Private Sub Suppiler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet1.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me._wellmeadown_finalDataSet1.Suppliers)
        Call CAD()
    End Sub

    Private Sub CAD()
        Supplier_NumberTextBox.Clear()
        Suppliers_nameTextBox.Clear()
        ArdressTextBox.Clear()
        TelephoneTextBox.Clear()
        Fax_numbersTextBox.Clear()
    End Sub
    Private Sub ReadMydata(connection As String)

        sqlReader = sqlCommand.ExecuteReader()
        sqlReader.Read()
        Supplier_NumberTextBox.Text = sqlReader.Item("Supplier_number")
        Suppliers_nameTextBox.Text = sqlReader.Item("Suppliers name")
        ArdressTextBox.Text = sqlReader.Item("Ardress")
        TelephoneTextBox.Text = sqlReader.Item("telephone")
        Fax_numbersTextBox.Text = sqlReader.Item("Fax numbers")
    End Sub



    Private Sub btn_Save_Click(dender As Object, e As EventArgs) Handles btn_save.Click
        MessageBox.Show("บันทึกข้อมูล " & Suppliers_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        SaveMyData(connectionString)

        btn_save.Enabled = False
        btn_delete.Enabled = True
        btn_add.Enabled = True

        ReadMydata(connectionString)
        Call CAD()

    End Sub
    Private Sub SaveMyData(connectionString As String)

        Dim sqlInsert As String = ("insert into Suppliers (Supplier_number,[Suppliers name],Ardress,telephone,[Fax numbers])
        values(" & Supplier_NumberTextBox.Text & ",'" & Suppliers_nameTextBox.Text & "','" & ArdressTextBox.Text &
        "','" & TelephoneTextBox.Text & "','" & Fax_numbersTextBox.Text & "')")

        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub

    Private Sub btn_edit_Click(dender As Object, e As EventArgs) Handles btn_edit.Click
        MessageBox.Show("อัพเดตข้อมูล " & Suppliers_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        UpdateMyData(connectionString)

        ReadMydata(connectionString)
        Call CAD()
    End Sub

    Private Sub UpdateMyData(connectionString As String)

        Dim sqlUpdate As String = "Update Suppliers set [Suppliers name] = '" & Suppliers_nameTextBox.Text & "' ,Ardress = '" & ArdressTextBox.Text & "',telephone = '" & TelephoneTextBox.Text & "',[Fax numbers] = '" & Fax_numbersTextBox.Text & "'
where Supplier_number = " & Supplier_NumberTextBox.Text

        Debug.WriteLine(sqlUpdate)
        Dim sqlCommand As New SqlCommand(sqlUpdate, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()

    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        MessageBox.Show("ลบข้อมูล " & Suppliers_nameTextBox.Text & " สำเร็จ", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim sqlDelete As String = ("DELETE FROM Suppliers where Supplier_number = " & Supplier_NumberTextBox.Text)
        Dim sqlCommand As New SqlCommand(sqlDelete, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
        ReadMydata(connectionString)
        Call CAD()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        staff.Show()
        Me.Close()

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

    Private Sub btn_vaccine_oder_Click(sender As Object, e As EventArgs) Handles btn_vaccine_oder.Click
        vaccine_order.Show()
        Me.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        LOGIN.Show()
        Me.Close()
    End Sub

    Private Sub btn_staff_Click_1(sender As Object, e As EventArgs) Handles btn_staff.Click
        staff.Show()
        Me.Close()
    End Sub

    Private Sub btnd_staff_allocation_Click(sender As Object, e As EventArgs) Handles btnd_staff_allocation.Click

        staff_allocation.Show()
        Me.Close()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        suppuiler_sarch.Show()
    End Sub
End Class

