VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Adapter"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True

'Example of the UDT in a data adapter.  Assume
'we can't change this UDT to a class.
Public Type KeyToken
    key As String
    value As String
    ErrorNumber As Long
End Type

'Example of the ExtractKey method in a data adapter.  Assumes that
'the collection is not NULL.
Public Function ExtractKeys(ByRef keys As Collection) As Long

    'Simulate that we read a couple keys from a file.
    AddKeyTokenToCollection keys, "One", "Value One"
    AddKeyTokenToCollection keys, "Two", "Value Two"
    
    'All done and assume zero means no errors.
    ExtractKeys = 0

End Function

'Adds a test key to the collection.
Private Sub AddKeyTokenToCollection(ByRef keys As Collection, ByVal key As String, ByVal value As String)

    Dim tokenToAdd As KeyToken
    tokenToAdd.key = "DataAdp1Udt: " & key
    tokenToAdd.value = "DataAdp1Udt: " & value
    tokenToAdd.ErrorNumber = 0
    
    keys.Add tokenToAdd, tokenToAdd.key

End Sub
