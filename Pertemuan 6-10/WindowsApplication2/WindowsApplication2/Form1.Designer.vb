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
        Me.tb_bil1 = New System.Windows.Forms.TextBox()
        Me.tb_bil2 = New System.Windows.Forms.TextBox()
        Me.tb_hasil = New System.Windows.Forms.TextBox()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.btn_keluar = New System.Windows.Forms.Button()
        Me.gt_operator = New System.Windows.Forms.GroupBox()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.gt_operator.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb_bil1
        '
        Me.tb_bil1.Location = New System.Drawing.Point(24, 22)
        Me.tb_bil1.Name = "tb_bil1"
        Me.tb_bil1.Size = New System.Drawing.Size(100, 20)
        Me.tb_bil1.TabIndex = 0
        '
        'tb_bil2
        '
        Me.tb_bil2.Location = New System.Drawing.Point(24, 63)
        Me.tb_bil2.Name = "tb_bil2"
        Me.tb_bil2.Size = New System.Drawing.Size(100, 20)
        Me.tb_bil2.TabIndex = 1
        '
        'tb_hasil
        '
        Me.tb_hasil.Location = New System.Drawing.Point(159, 22)
        Me.tb_hasil.Name = "tb_hasil"
        Me.tb_hasil.Size = New System.Drawing.Size(168, 20)
        Me.tb_hasil.TabIndex = 2
        '
        'btn_hitung
        '
        Me.btn_hitung.Location = New System.Drawing.Point(159, 60)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(75, 23)
        Me.btn_hitung.TabIndex = 3
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'btn_keluar
        '
        Me.btn_keluar.Location = New System.Drawing.Point(252, 60)
        Me.btn_keluar.Name = "btn_keluar"
        Me.btn_keluar.Size = New System.Drawing.Size(75, 23)
        Me.btn_keluar.TabIndex = 4
        Me.btn_keluar.Text = "Keluar"
        Me.btn_keluar.UseVisualStyleBackColor = True
        '
        'gt_operator
        '
        Me.gt_operator.Controls.Add(Me.RadioButton6)
        Me.gt_operator.Controls.Add(Me.RadioButton5)
        Me.gt_operator.Controls.Add(Me.RadioButton4)
        Me.gt_operator.Controls.Add(Me.RadioButton3)
        Me.gt_operator.Controls.Add(Me.RadioButton2)
        Me.gt_operator.Controls.Add(Me.RadioButton1)
        Me.gt_operator.Location = New System.Drawing.Point(24, 122)
        Me.gt_operator.Name = "gt_operator"
        Me.gt_operator.Size = New System.Drawing.Size(303, 199)
        Me.gt_operator.TabIndex = 5
        Me.gt_operator.TabStop = False
        Me.gt_operator.Text = "Function Operasi"
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(7, 148)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton6.TabIndex = 5
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Pangkat"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(7, 124)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Modulus"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(7, 100)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(78, 17)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Pembagian"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(7, 76)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Perkalian"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 53)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(89, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Pengurangan"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(86, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Penjumlahan"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 333)
        Me.Controls.Add(Me.gt_operator)
        Me.Controls.Add(Me.btn_keluar)
        Me.Controls.Add(Me.btn_hitung)
        Me.Controls.Add(Me.tb_hasil)
        Me.Controls.Add(Me.tb_bil2)
        Me.Controls.Add(Me.tb_bil1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gt_operator.ResumeLayout(False)
        Me.gt_operator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_bil1 As System.Windows.Forms.TextBox
    Friend WithEvents tb_bil2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents btn_hitung As System.Windows.Forms.Button
    Friend WithEvents btn_keluar As System.Windows.Forms.Button
    Friend WithEvents gt_operator As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton

End Class
