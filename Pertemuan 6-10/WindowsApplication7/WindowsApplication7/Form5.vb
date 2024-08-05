Imports System.Data.SqlClient
Public Class Form5
    Dim Con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If (txtUsername.Text = "" And txtPassword.Text = "") Then
            MsgBox("Masukkan Username/Password")
            txtUsername.Focus()
        End If
        Try
            Con = New SqlConnection("Data Source=RIFAL;Initial Catalog=Bab7;Integrated Security=True")
            Con.Open()
            cmd = New SqlCommand("Select * from tb_login where Username='" & txtUsername.Text & "' and Password ='" & txtPassword.Text & "'")
            cmd.Connection = Con
            rdr = cmd.ExecuteReader()
            If (rdr.Read()) Then
                My.Settings.IsLoggedln = True
                My.Settings.Save()
                Form6.Show()
                Me.Hide()
            Else
                MsgBox("Username/Password Salah!")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Form6.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.IsLoggedln = True Then
            Me.Close()
            Form6.Show()
            Exit Sub
        End If
    End Sub
End Class