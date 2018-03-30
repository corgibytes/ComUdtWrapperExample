
''' <summary>
''' Data returned by the adapter.
''' </summary>
''' <remarks>
''' Mimics the data returned by the COM component.
''' </remarks>
Public Class KeyToken

    Public sub New()

    End sub

    ''' <summary>
    ''' Map the data from the COM component.
    ''' </summary>
    ''' <param name="source">The data from the COM component to map.</param>
    public Sub New(source As DataAdp1Mapper.UdtWrapper)

        Key = source.Key
        Value = source.Value
        ErrorNumber = source.ErrorNumber

    End Sub

    
    Public Property Key As String
    Public Property Value As String
    Public Property ErrorNumber As Long

End Class
