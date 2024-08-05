Public Class Form1

    Private Sub Konversi1_Click(sender As Object, e As EventArgs) Handles Konversi1.Click
        txt_hasil1.Text = CInt(txt_nilai1.Text) + CInt(txt_nilai2.Text)

    End Sub

    Private Sub Konversi2_Click(sender As Object, e As EventArgs) Handles Konversi2.Click
        txt_hasil2.Text = (txt_nilai1.Text) + (txt_nilai2.Text)
    End Sub

    Private Sub Reverse_Click(sender As Object, e As EventArgs) Handles Reverse.Click
        txt_hasil3.Text = StrReverse(txt_hasil2.Text)
    End Sub
End Class
