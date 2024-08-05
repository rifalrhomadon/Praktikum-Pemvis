Public Class Form1

    Private Sub Btn_for_Click(sender As Object, e As EventArgs) Handles Btn_for.Click
        Dim i As Integer
        For i = Val(tb_awal.Text) To Val(tb_akhir.Text)
            ListBox1.Items.Add(i)

        Next
    End Sub
End Class
