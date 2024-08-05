Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kalimat() As String
        kalimat = txt_foreach.Text.Split(" ")
        For Each kata In kalimat
            ListBox1.Items.Add(kata)
        Next
    End Sub
End Class