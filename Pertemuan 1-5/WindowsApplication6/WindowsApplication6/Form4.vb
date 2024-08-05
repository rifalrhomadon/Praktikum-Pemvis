Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim awal, akhir
        awal = Val(tb_awal.Text)
        akhir = Val(tb_akhir.Text)
        While awal <= akhir
            ListBox1.Items.Add(awal)
            awal = awal + 1
        End While
    End Sub
End Class