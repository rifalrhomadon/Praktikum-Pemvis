Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim awal, akhir As Integer
        awal = Val(tb_awal.Text)
        akhir = Val(tb_akhir.Text)
        Do
            ListBox1.Items.Add(awal)
            awal = awal + 1
        Loop While (awal <= akhir)
    End Sub
End Class