Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.IsLoggedln Then
            Form3.ShowDialog()
            Me.Hide()
            Exit Sub
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.IsLoggedln = False
        My.Settings.Save()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub CRUDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRUDToolStripMenuItem.Click
        Form1.Show()
    End Sub
End Class