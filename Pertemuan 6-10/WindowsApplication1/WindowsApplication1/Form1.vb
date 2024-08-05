Public Class Form1
    Sub nonparam()
        MessageBox.Show("Nama Default")
    End Sub
    Sub param(nama As String)
        MessageBox.Show("Panggil " & nama)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nonparam()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String
        input = txt_input.Text()
        Call param(input)
    End Sub
End Class
