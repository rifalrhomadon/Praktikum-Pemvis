<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nilai1 = New System.Windows.Forms.TextBox()
        Me.txt_nilai2 = New System.Windows.Forms.TextBox()
        Me.Konversi1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_hasil1 = New System.Windows.Forms.TextBox()
        Me.txt_hasil2 = New System.Windows.Forms.TextBox()
        Me.txt_hasil3 = New System.Windows.Forms.TextBox()
        Me.Konversi2 = New System.Windows.Forms.Button()
        Me.Reverse = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai 2"
        '
        'txt_nilai1
        '
        Me.txt_nilai1.Location = New System.Drawing.Point(97, 27)
        Me.txt_nilai1.Name = "txt_nilai1"
        Me.txt_nilai1.Size = New System.Drawing.Size(100, 20)
        Me.txt_nilai1.TabIndex = 2
        '
        'txt_nilai2
        '
        Me.txt_nilai2.Location = New System.Drawing.Point(97, 54)
        Me.txt_nilai2.Name = "txt_nilai2"
        Me.txt_nilai2.Size = New System.Drawing.Size(100, 20)
        Me.txt_nilai2.TabIndex = 3
        '
        'Konversi1
        '
        Me.Konversi1.Location = New System.Drawing.Point(20, 81)
        Me.Konversi1.Name = "Konversi1"
        Me.Konversi1.Size = New System.Drawing.Size(177, 23)
        Me.Konversi1.TabIndex = 4
        Me.Konversi1.Text = "Konversi dalam bentuk Integer"
        Me.Konversi1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hasil Konversi"
        '
        'txt_hasil1
        '
        Me.txt_hasil1.Location = New System.Drawing.Point(97, 111)
        Me.txt_hasil1.Name = "txt_hasil1"
        Me.txt_hasil1.Size = New System.Drawing.Size(100, 20)
        Me.txt_hasil1.TabIndex = 6
        '
        'txt_hasil2
        '
        Me.txt_hasil2.Location = New System.Drawing.Point(97, 169)
        Me.txt_hasil2.Name = "txt_hasil2"
        Me.txt_hasil2.Size = New System.Drawing.Size(100, 20)
        Me.txt_hasil2.TabIndex = 7
        '
        'txt_hasil3
        '
        Me.txt_hasil3.Location = New System.Drawing.Point(97, 231)
        Me.txt_hasil3.Name = "txt_hasil3"
        Me.txt_hasil3.Size = New System.Drawing.Size(100, 20)
        Me.txt_hasil3.TabIndex = 8
        '
        'Konversi2
        '
        Me.Konversi2.Location = New System.Drawing.Point(20, 138)
        Me.Konversi2.Name = "Konversi2"
        Me.Konversi2.Size = New System.Drawing.Size(177, 23)
        Me.Konversi2.TabIndex = 9
        Me.Konversi2.Text = "Konversi dalam bentuk String"
        Me.Konversi2.UseVisualStyleBackColor = True
        '
        'Reverse
        '
        Me.Reverse.Location = New System.Drawing.Point(20, 196)
        Me.Reverse.Name = "Reverse"
        Me.Reverse.Size = New System.Drawing.Size(177, 23)
        Me.Reverse.TabIndex = 10
        Me.Reverse.Text = "Reverse"
        Me.Reverse.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Hasil Konversi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Hasil Konversi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(67, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Program Konversi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 331)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Reverse)
        Me.Controls.Add(Me.Konversi2)
        Me.Controls.Add(Me.txt_hasil3)
        Me.Controls.Add(Me.txt_hasil2)
        Me.Controls.Add(Me.txt_hasil1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Konversi1)
        Me.Controls.Add(Me.txt_nilai2)
        Me.Controls.Add(Me.txt_nilai1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "2218106_Bab1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_nilai1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_nilai2 As System.Windows.Forms.TextBox
    Friend WithEvents Konversi1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_hasil1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_hasil2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_hasil3 As System.Windows.Forms.TextBox
    Friend WithEvents Konversi2 As System.Windows.Forms.Button
    Friend WithEvents Reverse As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
