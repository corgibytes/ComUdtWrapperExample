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
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'ExtractKeyButton
        '
        Me.ExtractKeyButton.Location = New System.Drawing.Point(24, 306)
        Me.ExtractKeyButton.Name = "ExtractKeyButton"
        Me.ExtractKeyButton.Size = New System.Drawing.Size(75, 23)
        Me.ExtractKeyButton.TabIndex = 0
        Me.ExtractKeyButton.Text = "Extract Keys"
        Me.ExtractKeyButton.UseVisualStyleBackColor = true
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Location = New System.Drawing.Point(12, 12)
        Me.StatusTextBox.Multiline = true
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.StatusTextBox.Size = New System.Drawing.Size(748, 288)
        Me.StatusTextBox.TabIndex = 1
        Me.StatusTextBox.WordWrap = false
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 339)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.ExtractKeyButton)
        Me.Name = "MainForm"
        Me.Text = "COM UDT Wrapper Example"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ExtractKeyButton As Button
    Friend WithEvents StatusTextBox As TextBox
End Class
