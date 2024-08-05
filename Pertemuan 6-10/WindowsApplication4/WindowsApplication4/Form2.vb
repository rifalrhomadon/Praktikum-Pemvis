Public Class Form2

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim W As New IO.StreamWriter("D:\FROM E\laptop\Semester 4\Praktikum Pemrograman Visual\Afwrii\" & txtFileName.Text & ".txt")
        W.Write(txtText.Text)
        W.Close()
    End Sub
End Class