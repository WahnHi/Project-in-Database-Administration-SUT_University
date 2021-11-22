Imports System.Data
Imports System.Data.SqlClient
Public Class vaccine

    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from orderer"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader


    Private Sub vaccine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_wellmeadown_finalDataSet1.vaccine' table. You can move, or remove it, as needed.
        Me.VaccineTableAdapter.Fill(Me._wellmeadown_finalDataSet1.vaccine)

        ComboBox1.Items.Add("sinovac")
        ComboBox1.Items.Add("pizer")
        ComboBox1.Items.Add("moderna")
        ComboBox1.Items.Add("sinopharm")

        DateTimePicker2.Value = DateAdd(DateInterval.Day, 28, Today)
        DateTimePicker3.Value = DateAdd(DateInterval.Day, 56, Today)

    End Sub

    Private Sub ReadMydata(connection As String)

        sqlReader = sqlCommand.ExecuteReader()
        sqlReader.Read()

        Order_idTextBox.Text = sqlReader.Item("Order_id")
        Id_cardTextBox.Text = sqlReader.Item("Id_card")
        First_nameTextBox.Text = sqlReader.Item("First_name")
        Last_nameTextBox.Text = sqlReader.Item("Last_name")
        GenderTextBox.Text = sqlReader.Item("Gender")
        Date_of_birthDateTimePicker.Value = sqlReader.Item("date_of_birth")
        AddressTextBox.Text = sqlReader.Item("Address")
        TelephoneTextBox.Text = sqlReader.Item("Telephone")
        DateTimePicker1.Value = sqlReader.Item("sysnt_date")
        TextBox1.Text = sqlReader.Item("vaccine_vaccine_id")
        DateTimePicker2.Value = sqlReader.Item("first_dose")
        DateTimePicker3.Value = sqlReader.Item("second_dose")



    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click


        MessageBox.Show("จองวัคซีนเสร็จสิ้น", "ข้อความจากระบบ", MessageBoxButtons.OK, MessageBoxIcon.Information)



        InsertMyData(connectionString)

        ReadMydata(connectionString)


    End Sub

    Private Sub InsertMyData(connectionString As String)

        Dim sqlInsert As String = ("insert into Orderer (order_id ,id_card ,first_name ,last_name ,address,gender ,telephone ,date_of_birth ,sysnt_date,vaccine_vaccine_id,first_dose,second_dose )
values (" & Order_idTextBox.Text & "," & Id_cardTextBox.Text & ",'" & First_nameTextBox.Text & "','" & Last_nameTextBox.Text &
"','" & AddressTextBox.Text & "','" & GenderTextBox.Text & "'," & TelephoneTextBox.Text & ",'" & Date_of_birthDateTimePicker.Value.ToString("MM/dd/yyyy") & "','" & DateTimePicker1.Value.ToString("MM/dd/yyyy") & "','" & TextBox1.Text & "','" & DateTimePicker2.Value.ToString("MM/dd/yyyy") & "','" & DateTimePicker3.Value.ToString("MM/dd/yyyy") & "')")


        Debug.WriteLine(sqlInsert)
        Dim sqlCommand As New SqlCommand(sqlInsert, sqlConnection)
        sqlConnection.Close()
        sqlConnection.Open()
        sqlCommand.ExecuteNonQuery()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
        LOGIN.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "sinovac" Then
            TextBox1.Text = "01"

        ElseIf ComboBox1.Text = "pizer" Then
            TextBox1.Text = "02"
        ElseIf ComboBox1.Text = "moderna" Then
            TextBox1.Text = "03"
        Else
            TextBox1.Text = "04"
        End If

    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs) Handles btn_check.Click
        check_vaccine.Show()
    End Sub
End Class