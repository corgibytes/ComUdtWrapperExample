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

'Translate all the UDT KeyTokens (defined in the DataAdp1Udt project)
'in the collection to a VB6 class.  UDTs, or structs in .NET, can't
'cross the COM boundry to .NET but classes can.
'
'For example, the following code will raise in error .NET:
'
'  'Get collection of UDTs from VB6 COM
'  Dim adapter = New DataAdp1Udt.Adapter
'  adapter.ExtractKeys(vbCollection)
'
'  'If you try to access a UDT from the collection
'  'an error will be raised.
'  Dim keyToken = vbCollection(0)
'
'If you need to access the items in the collection you need to
'transfer it from a UDT to a VB6 class so it can transfer over
'COM:
'
'  'Get collection of UDTs from VB6 COM
'  Dim adapter = New DataAdp1Udt.Adapter
'  adapter.ExtractKeys(vbCollection)
'
'  'Translate the UDTs to VB6 classes.
'  Dim mapper As New DataAdp1Mapper.Mapper
'  Dim mappedCollection = mapper.UdtToClass(vbCollection)
'
'  'Now you can access the items in the collection.
'  Dim keyToken = mappedCollection(0)
'  Console.WriteLine(keyToken.Value)
'
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
