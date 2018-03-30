VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 0  'vbNone
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "Factory"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = True

'Allows .NET applications to create a VBA collection that can
'be passed into other VB6 COM applications.  For example in .NET
'the following will raise an error:
'
'  '.NET VBA Collection.  You will also get
'  'an error if you use .NET collection.
'  Dim col = New VBA.Collection()
'
'  'The COM object we want to pass a colleciton too.
'  Dim comObject = New MyComProject.MyComClass()
'
'  'This line will raise an error.
'  Dim comObject.SomeMethod(col)
'
'The fix this problem use the Collection Factory:
'
'  'Create the collection in VB6 land.
'  Dim factory = New CollectionFactory.Factory()
'  Dim col = factory.CreateCollection()
'
'  'Add things to the collection but not that you can't
'  'add structs (UDTs in VB6 land).
'  col.Add("Test")
'
'  'Pass the collection to the our COM project.
'  'No error is raised.
'  Dim comObject = New MyComProject.MyComClass()
'  Dim comObject.SomeMethod(col)
'
' https://support.microsoft.com/en-us/help/323737/bug-error-message-when-you-try-to-pass-a-collection-object-from-visual
'
Public Function CreateCollection() As Collection
    Set CreateCollection = New Collection
End Function
