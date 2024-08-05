Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.IsLoggedln Then
            Form5.ShowDialog()
            Me.Hide()
            Exit Sub
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        My.Settings.IsLoggedln = False
        My.Settings.Save()
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub CRUDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRUDToolStripMenuItem.Click
        Form1.Show()
    End Sub
End Class