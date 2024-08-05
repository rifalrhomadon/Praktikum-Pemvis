Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case ComboBox1.Text
            Case "Futsal"
                MessageBox.Show("Anda Memilih futsal sebagai olahraga favorit", "Olahraga Favorit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "Badminton"
                MessageBox.Show("Anda Memilih badminton sebagai olahraga favorit", "Olahraga Favorit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "Basket"
                MessageBox.Show("Anda Memilih basket sebagai olahraga favorit", "Olahraga Favorit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case "Memasak"
                MessageBox.Show("Anda Memilih memasak sebagai olahraga favorit", "Olahraga Favorit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("Anda belum memilih hobi", "Olahraga Favorit", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Select
    End Sub
End Class