<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.ExtractKeyButton = New System.Windows.Forms.Button()
        Me.LogTextBox = New System.Windows.Forms.TextBox()
        Me.KeysTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'ExtractKeyButton
        '
        Me.ExtractKeyButton.Location = New System.Drawing.Point(685, 55)
        Me.ExtractKeyButton.Name = "ExtractKeyButton"
        Me.ExtractKeyButton.Size = New System.Drawing.Size(75, 23)
        Me.ExtractKeyButton.TabIndex = 0
        Me.ExtractKeyButton.Text = "Extract Keys"
        Me.ExtractKeyButton.UseVisualStyleBackColor = true
        '
        'LogTextBox
        '
        Me.LogTextBox.Location = New System.Drawing.Point(12, 260)
        Me.LogTextBox.Multiline = true
        Me.LogTextBox.Name = "LogTextBox"
        Me.LogTextBox.Size = New System.Drawing.Size(748, 136)
        Me.LogTextBox.TabIndex = 1
        '
        'KeysTextBox
        '
        Me.KeysTextBox.Location = New System.Drawing.Point(12, 118)
        Me.KeysTextBox.Multiline = true
        Me.KeysTextBox.Name = "KeysTextBox"
        Me.KeysTextBox.Size = New System.Drawing.Size(748, 136)
        Me.KeysTextBox.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 408)
        Me.Controls.Add(Me.KeysTextBox)
        Me.Controls.Add(Me.LogTextBox)
        Me.Controls.Add(Me.ExtractKeyButton)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ExtractKeyButton As Button
    Friend WithEvents LogTextBox As TextBox
    Friend WithEvents KeysTextBox As TextBox
End Class
