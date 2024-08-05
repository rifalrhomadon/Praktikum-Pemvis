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
        Me.txt_file = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_file
        '
        Me.txt_file.Location = New System.Drawing.Point(58, 36)
        Me.txt_file.Multiline = True
        Me.txt_file.Name = "txt_file"
        Me.txt_file.Size = New System.Drawing.Size(303, 150)
        Me.txt_file.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(58, 202)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(286, 202)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(75, 23)
        Me.btn_open.TabIndex = 2
        Me.btn_open.Text = "Open"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 307)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_file)
        Me.Name = "Form1"
        Me.Text = "StreamWriter & StreamRider"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_file As System.Windows.Forms.TextBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_open As System.Windows.Forms.Button

End Class
