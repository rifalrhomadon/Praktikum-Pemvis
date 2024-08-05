Public Class Form1

    Private Sub btn_Proses_Click(sender As Object, e As EventArgs) Handles btn_Proses.Click
        Dim awal As Integer = Val(tb_awal.Text)
        Dim akhir As Integer = Val(tb_akhir.Text)
        Dim i As Integer

        For i = awal To akhir
            If i Mod 2 = 0 Then
                ListBox2.Items.Add(i & " ")
            Else
                ListBox1.Items.Add(i & " ")
            End If
        Next
    End Sub

End Class
