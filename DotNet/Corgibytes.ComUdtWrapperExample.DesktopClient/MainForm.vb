Public Class MainForm

    Private Sub ExtractKeyButton_Click(sender As Object, e As EventArgs) Handles ExtractKeyButton.Click

        AppendToStatus("Extracting keys...")

        Try
            'Extract the keys from the adapter.
            '
            'Only call the .NET assembly and don't reference the COM component.
            'When the COM component is migrated to .NET the client won't have
            'to make any changes.
            Dim wrapper As New DataAdapter1Udt.Adapter
            Dim extractedKeys = wrapper.ExtractKeys()

            'Write out the keys that where found.
            AppendToStatus("The following keys where found...")
            For i = 0 To extractedKeys.Keys.Count - 1
                AppendToStatus($"  Key: {extractedKeys.Keys(i)}")
                WriteKeyTokenToStatus(extractedKeys.Values(i))
            Next

            'All done.
            AppendToStatus("Done extracting keys.")
            AppendToStatus("")

        Catch ex As Exception
            AppendToStatus($"Exception: {ex.Message}")

        End Try
       
    End Sub

    ''' <summary>
    ''' Writes the key token values to the status.
    ''' </summary>
    ''' <param name="keyToken">The token values to write.</param>
    Private Sub WriteKeyTokenToStatus(ByVal keyToken As DataAdapter1Udt.KeyToken)

        AppendToStatus($"  Token Key: {keyToken.Key}")
        AppendToStatus($"  Token Value: {keyToken.Value}")
        AppendToStatus($"  Token ErrorNumber: {keyToken.ErrorNumber}")
        AppendToStatus("")

    End Sub

    ''' <summary>
    ''' Append a message to the status textbox.
    ''' </summary>
    ''' <param name="message">The message to append to the status.</param>
    Private Sub AppendToStatus(ByVal message As String)

        StatusTextBox.Text &= message & Environment.NewLine

    End Sub
End Class
