Public Class MainForm

    Private Sub ExtractKeyButton_Click(sender As Object, e As EventArgs) Handles ExtractKeyButton.Click

        AppendToLog("Extracting keys...")

        Try
            Dim wrapper As New Corgibytes.ComExample.DataAdapter1Udt.Adapter
            Dim extractedKeys = wrapper.ExtractKeys()

            AppendToLog("The following keys where found...")
            For i = 0 To extractedKeys.Keys.Count - 1
                AppendToLog($"  Key: {extractedKeys.Keys(i)}")
                WriteKeyTokenToLog(extractedKeys.Values(i))
            Next

            AppendToLog("Done extracting keys.")
            AppendToLog("")

        Catch ex As Exception
            AppendToLog($"Exception: {ex.Message}")

        End Try
       
    End Sub

    Private Sub WriteKeyTokenToLog(ByVal keyToken As Corgibytes.ComExample.DataAdapter1Udt.DataAdapterOneToken)

        AppendToLog($"  Token Key: {keyToken.Key}")
        AppendToLog($"  Token Value: {keyToken.Value}")
        AppendToLog($"  Token ErrorNumber: {keyToken.ErrorNumber}")

    End Sub

    Private Sub AppendToLog(ByVal message As String)

        LogTextBox.Text &= message & Environment.NewLine

    End Sub
End Class
