
''' <summary>
''' Reads values from a water device.
''' </summary>
''' <remarks>
''' In this example this class wraps the underlying VB6 data adapter.
''' To upgrade the VB6 data adapter to .NET you would place the logic
''' into this class/project but keep the interface the same.  Then any
''' consuming clients, such as the desktop client, won't have to change.
''' </remarks>
Public Class Adapter

    ''' <summary>
    ''' Extracts the keys from the Data Adapter.
    ''' </summary>
    ''' <returns>All the keys extracted from the Data Adatper.</returns>
    Public Function ExtractKeys() As Dictionary(Of string, KeyToken)

        'Read the keys from the Data Adapter.  This will return a 
        'VB6 collection of VB6 user defined types (UDT).  If you try to access
        'the user defined type an exception will be raised.
        '
        'This simulates accessing the existing Data Adapter without any changes
        'and not re-compiling it.
        Dim collectionFactory As New CollectionFactory.Factory
        Dim vbCollection = collectionFactory.CreateCollection()

        Dim adapter = New DataAdp1Udt.Adapter
        adapter.ExtractKeys(vbCollection)


        'Transform all the items in the VB6 collection from a
        'VB6 UDT to a VB6 class.  You can't pass UDTs over COM but
        'you can pass classes over COM.
        '
        'This COM mapper class is new and one would be created for
        'each data adapter that has UDTs that need to be mapped.
        Dim mapper As New DataAdp1Mapper.Mapper
        Dim mappedCol = mapper.UdtToClass(vbCollection)


        'Translate the VB6 collection to a .NET Dictionary. Don't expose 
        'the client to the VB6 type so later you can rewrite the COM
        'component in .NET but the client does not have to change.
        Dim result = new Dictionary(Of string, KeyToken)
        For i = 0 to mappedCol.Count - 1
            Dim mappedItem = New KeyToken(mappedCol(i))
            result.Add(mappedItem.Key, mappedItem)
        Next


        'All done.
        Return result
        
    End Function

End Class
