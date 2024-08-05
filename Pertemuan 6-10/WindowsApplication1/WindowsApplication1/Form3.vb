Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intInteger As Byte
        Try
            intInteger = CByte(txtTryCatch.Text)
        Catch ex As InvalidCastException
            MsgBox("Tedapat Eror Dalam Program")
        Catch ex As OverflowException
            MsgBox("Tedapat Eror Overflow Dalam Program")
        Catch ex As Exception
            MsgBox("Tedapat Eror Dalam Program")
        End Try
        MsgBox("Inputan Anda :" & intInteger.ToString)
    End Sub
End Class