Imports System.Data.SqlClient
Public Class Form3
    Dim Con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.IsLoggedln = True Then
            Me.Close()
            Form4.Show()
            Exit Sub
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If (txt_username.Text = "" And txt_password.Text = "") Then
            MsgBox("Masukkan Username/Password")
            txt_username.Focus()
        End If
        Try
            Con = New SqlConnection("Data Source=RIFAL;Initial Catalog=db_barang;Integrated Security=True")
            Con.Open()
            cmd = New SqlCommand("Select * from tb_login where Username='" & txt_username.Text & "' and Password ='" & txt_password.Text & "'")
            cmd.Connection = Con
            rdr = cmd.ExecuteReader()
            If (rdr.Read()) Then
                My.Settings.IsLoggedln = True
                My.Settings.Save()
                Form4.Show()
                Me.Hide()
            Else
                MsgBox("Username/Password Salah!")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
        Form4.Close()
    End Sub
End Class