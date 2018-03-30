VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Mapper"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True

'Translate the UDT KeyToken in the DataAdp1Udt project to a class.
'This assumes you can't change the UDT in the DataAdp1Udt project to
'class.
Public Function UdtToClass(ByRef source As Collection) As Collection

    'This collection will contain the wrapper class.
    Dim destination As New Collection
    
    'Map each UDT to a class.
    For i = 1 To source.Count
        'From Dada1AdpUdt project.
        Dim sourceItem As KeyToken
        sourceItem = source(i)
        
        'Copy the values to the wrapper class.
        Dim mappedItem As UdtWrapper
        Set mappedItem = New UdtWrapper
        mappedItem.Key = sourceItem.Key
        mappedItem.Value = sourceItem.Value
        mappedItem.ErrorNumber = sourceItem.ErrorNumber
        
        'Add the wrapper class to the collection.
        destination.Add mappedItem, mappedItem.Key
    Next

    'All done.
    Set UdtToClass = destination

End Function
