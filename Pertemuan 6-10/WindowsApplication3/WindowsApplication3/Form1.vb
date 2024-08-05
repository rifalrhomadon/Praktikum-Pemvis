Public Class Form1
    Function penjumlahan(ByVal nilai1 As Integer, ByVal nilai2 As Integer)
        Dim hasil As Integer
        hasil = nilai1 + nilai2
        Return hasil
    End Function
    Function pengurangan(ByVal nilai1 As Integer, ByVal nilai2 As Integer)
        Dim hasil As Integer
        hasil = nilai1 - nilai2
        Return hasil
    End Function
    Function perkalian(ByVal nilai1 As Integer, ByVal nilai2 As Integer)
        Dim hasil As Integer
        hasil = nilai1 * nilai2
        Return hasil
    End Function
    Function pembagian(ByVal nilai1 As Double, ByVal nilai2 As Double)
        Dim hasil As Double
        hasil = nilai1 / nilai2
        Return hasil
    End Function
    Function modulus(ByVal nilai1 As Double, ByVal nilai2 As Double)
        Dim hasil As Double
        hasil = nilai1 Mod nilai2
        Return hasil
    End Function
    Function pangkat(ByVal nilai1 As Double, ByVal nilai2 As Double)
        Dim hasil As Double
        hasil = nilai1 ^ nilai2
        Return hasil
    End Function
    Private Sub btn_hasil_Click(sender As Object, e As EventArgs) Handles btn_hasil.Click
        Try
            Dim nilai1, nilai2 As Integer
            nilai1 = CInt(tb_nilai1.Text)
            nilai2 = CInt(tb_nilai2.Text)
            If (RadioButtonJumlah.Checked) Then
                tb_hasil.Text = penjumlahan(nilai1, nilai2)
            ElseIf (RadioButtonKurang.Checked) Then
                tb_hasil.Text = pengurangan(nilai1, nilai2)
            ElseIf (RadioButtonKali.Checked) Then
                tb_hasil.Text = perkalian(nilai1, nilai2)
            ElseIf (RadioButtonBagi.Checked) Then
                tb_hasil.Text = pembagian(nilai1, nilai2)
            ElseIf (RadioButtonModu.Checked) Then
                tb_hasil.Text = modulus(nilai1, nilai2)
            ElseIf (RadioButtonPang.Checked) Then
                tb_hasil.Text = pangkat(nilai1, nilai2)
            Else
                MsgBox("Silakan pilih operasi!",
                MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Peringatan")
            End If
        Catch ex As InvalidCastException
            MsgBox("Inputan ada yang salah atau kurang!",
            MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Peringatan")
        End Try
    End Sub

    Private Sub btn_keluar_Click(sender As Object, e As EventArgs) Handles btn_keluar.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_hasil.Enabled = False
    End Sub
End Class
