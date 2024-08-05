Public Class Form1

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim R As New IO.StreamReader("D:\FROM E\laptop\Semester 4\Praktikum Pemrograman Visual\Afwrii\" & txtFileName.Text & ".txt")
        txtText.Text = R.ReadToEnd
        R.Close()
    End Sub
End Class
