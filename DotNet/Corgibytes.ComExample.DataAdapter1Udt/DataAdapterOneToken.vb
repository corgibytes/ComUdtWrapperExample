
Public Class DataAdapterOneToken

    Public sub New()

    End sub

    public Sub New(ByVal source As DataAdp1Mapper.UdtWrapper)

        Key = source.Key
        Value = source.Value
        ErrorNumber = source.ErrorNumber

    End Sub

    
    Public Property Key As String
    Public Property Value As String
    Public Property ErrorNumber As Long

End Class
