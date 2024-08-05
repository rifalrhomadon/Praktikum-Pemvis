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
        Me.tb_nilai1 = New System.Windows.Forms.TextBox()
        Me.tb_nilai2 = New System.Windows.Forms.TextBox()
        Me.tb_hasil = New System.Windows.Forms.TextBox()
        Me.btn_hasil = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonPang = New System.Windows.Forms.RadioButton()
        Me.RadioButtonModu = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBagi = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKali = New System.Windows.Forms.RadioButton()
        Me.RadioButtonKurang = New System.Windows.Forms.RadioButton()
        Me.RadioButtonJumlah = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_nilai1
        '
        Me.tb_nilai1.Location = New System.Drawing.Point(22, 24)
        Me.tb_nilai1.Name = "tb_nilai1"
        Me.tb_nilai1.Size = New System.Drawing.Size(100, 20)
        Me.tb_nilai1.TabIndex = 0
        '
        'tb_nilai2
        '
        Me.tb_nilai2.Location = New System.Drawing.Point(22, 63)
        Me.tb_nilai2.Name = "tb_nilai2"
        Me.tb_nilai2.Size = New System.Drawing.Size(100, 20)
        Me.tb_nilai2.TabIndex = 1
        '
        'tb_hasil
        '
        Me.tb_hasil.Location = New System.Drawing.Point(147, 23)
        Me.tb_hasil.Name = "tb_hasil"
        Me.tb_hasil.Size = New System.Drawing.Size(156, 20)
        Me.tb_hasil.TabIndex = 2
        '
        'btn_hasil
        '
        Me.btn_hasil.Location = New System.Drawing.Point(147, 63)
        Me.btn_hasil.Name = "btn_hasil"
        Me.btn_hasil.Size = New System.Drawing.Size(75, 23)
        Me.btn_hasil.TabIndex = 3
        Me.btn_hasil.Text = "Hasil"
        Me.btn_hasil.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(228, 63)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 4
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonPang)
        Me.GroupBox1.Controls.Add(Me.RadioButtonModu)
        Me.GroupBox1.Controls.Add(Me.RadioButtonBagi)
        Me.GroupBox1.Controls.Add(Me.RadioButtonKali)
        Me.GroupBox1.Controls.Add(Me.RadioButtonKurang)
        Me.GroupBox1.Controls.Add(Me.RadioButtonJumlah)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 185)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Function Operator"
        '
        'RadioButtonPang
        '
        Me.RadioButtonPang.AutoSize = True
        Me.RadioButtonPang.Location = New System.Drawing.Point(7, 140)
        Me.RadioButtonPang.Name = "RadioButtonPang"
        Me.RadioButtonPang.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonPang.TabIndex = 5
        Me.RadioButtonPang.TabStop = True
        Me.RadioButtonPang.Text = "Pangkat"
        Me.RadioButtonPang.UseVisualStyleBackColor = True
        '
        'RadioButtonModu
        '
        Me.RadioButtonModu.AutoSize = True
        Me.RadioButtonModu.Location = New System.Drawing.Point(7, 116)
        Me.RadioButtonModu.Name = "RadioButtonModu"
        Me.RadioButtonModu.Size = New System.Drawing.Size(65, 17)
        Me.RadioButtonModu.TabIndex = 4
        Me.RadioButtonModu.TabStop = True
        Me.RadioButtonModu.Text = "Modulus"
        Me.RadioButtonModu.UseVisualStyleBackColor = True
        '
        'RadioButtonBagi
        '
        Me.RadioButtonBagi.AutoSize = True
        Me.RadioButtonBagi.Location = New System.Drawing.Point(7, 92)
        Me.RadioButtonBagi.Name = "RadioButtonBagi"
        Me.RadioButtonBagi.Size = New System.Drawing.Size(78, 17)
        Me.RadioButtonBagi.TabIndex = 3
        Me.RadioButtonBagi.TabStop = True
        Me.RadioButtonBagi.Text = "Pembagian"
        Me.RadioButtonBagi.UseVisualStyleBackColor = True
        '
        'RadioButtonKali
        '
        Me.RadioButtonKali.AutoSize = True
        Me.RadioButtonKali.Location = New System.Drawing.Point(7, 68)
        Me.RadioButtonKali.Name = "RadioButtonKali"
        Me.RadioButtonKali.Size = New System.Drawing.Size(69, 17)
        Me.RadioButtonKali.TabIndex = 2
        Me.RadioButtonKali.TabStop = True
        Me.RadioButtonKali.Text = "Perkalian"
        Me.RadioButtonKali.UseVisualStyleBackColor = True
        '
        'RadioButtonKurang
        '
        Me.RadioButtonKurang.AutoSize = True
        Me.RadioButtonKurang.Location = New System.Drawing.Point(7, 44)
        Me.RadioButtonKurang.Name = "RadioButtonKurang"
        Me.RadioButtonKurang.Size = New System.Drawing.Size(89, 17)
        Me.RadioButtonKurang.TabIndex = 1
        Me.RadioButtonKurang.TabStop = True
        Me.RadioButtonKurang.Text = "Pengurangan"
        Me.RadioButtonKurang.UseVisualStyleBackColor = True
        '
        'RadioButtonJumlah
        '
        Me.RadioButtonJumlah.AutoSize = True
        Me.RadioButtonJumlah.Location = New System.Drawing.Point(7, 20)
        Me.RadioButtonJumlah.Name = "RadioButtonJumlah"
        Me.RadioButtonJumlah.Size = New System.Drawing.Size(86, 17)
        Me.RadioButtonJumlah.TabIndex = 0
        Me.RadioButtonJumlah.TabStop = True
        Me.RadioButtonJumlah.Text = "Penjumlahan"
        Me.RadioButtonJumlah.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 307)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hasil)
        Me.Controls.Add(Me.tb_hasil)
        Me.Controls.Add(Me.tb_nilai2)
        Me.Controls.Add(Me.tb_nilai1)
        Me.Name = "Form1"
        Me.Text = "2218106_Kalkulator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_nilai1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_nilai2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents btn_hasil As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonPang As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonModu As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonBagi As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonKali As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonKurang As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonJumlah As System.Windows.Forms.RadioButton

End Class
