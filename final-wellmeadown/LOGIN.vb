Imports System.Data
Imports System.Data.SqlClient

Public Class LOGIN
    Private connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kitti\source\repos\final-wellmeadown\final-wellmeadown\wellmeadown-final.mdf;Integrated Security=True;Connect Timeout=30"

    Dim sqlSelectQuery As String = "select * from staff"
    Dim sqlConnection As New SqlConnection(connectionString)
    Dim sqlCommand As New SqlCommand(sqlSelectQuery, sqlConnection)
    Dim sqlReader As SqlDataReader
    Dim sql As String
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub



    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim tb1, tb2 As String

        tb1 = TextBox1.Text
        tb2 = TextBox2.Text

        If tb1 = "admin" And tb2 = "1234" Then
            staff.Show()
            Me.Hide()
            Patient_appointment.Staff_numberTextBox.Text = tb1


        Else
            MessageBox.Show("ข้อมูลผิดพลาด Username หรือ password ")

        End If

    End Sub

    Private Sub btn_vc_Click(sender As Object, e As EventArgs)


        vaccine.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub btn_check_Click(sender As Object, e As EventArgs)
        check_vaccine.Show()
    End Sub
End Class