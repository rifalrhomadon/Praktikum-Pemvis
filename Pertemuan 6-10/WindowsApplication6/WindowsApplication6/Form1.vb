Imports System.IO
Public Class Form1
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text files (*.txt)|*.txt"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim textToSave As String = txt_file.Text
            File.WriteAllText(saveFileDialog.FileName, textToSave)
        End If
    End Sub
    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog.FileName
            Try
                Using imageStream As New System.IO.FileStream(fileName, System.IO.FileMode.Open)
                    Dim memoryStream As New System.IO.MemoryStream()
                    imageStream.CopyTo(memoryStream)
                    memoryStream.Position = 0

                    Dim image As Image = image.FromStream(memoryStream)

                    Dim form As New Form()
                    form.Text = "Image Selected"
                    form.ClientSize = New Size(image.Width, image.Height)

                    Dim pictureBox As New PictureBox()
                    pictureBox.Dock = DockStyle.Fill
                    pictureBox.Image = image
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage

                    form.Controls.Add(pictureBox)
                    form.ShowDialog()
                    image.Dispose()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
