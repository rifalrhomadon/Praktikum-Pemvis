Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rata.Enabled = False
        total.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim c, d As Integer
        c = CInt(NT.Text) + CInt(Uts.Text) + CInt(Uas.Text)
        total.Text = c
        d = (CInt(NT.Text) + CInt(Uts.Text) + CInt(Uas.Text)) / 3
        rata.Text = d
        If NT.Text > 100 Then
            MsgBox("Nilai yang anda masukkan tidak boleh leih dari 100")
        ElseIf Uas.Text > 100 Then
            MsgBox("Nilai yang anda masukkan tidak boleh leih dari 100")
        Else
            If rata.Text >= 90 Then
                grade.Text = "A"
                MessageBox.Show("Grade Nilai Anda A")
            ElseIf rata.Text >= 80 Then
                grade.Text = "B"
                MessageBox.Show("Grade Nilai Anda B", "Nilai Anda !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf rata.Text >= 70 Then
                grade.Text = "C"
                MessageBox.Show("Grade Nilai Anda C", "Nilai Anda !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else : grade.Text = "-"
                MessageBox.Show("Anda tidak lulus", "Nilai Anda !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class
