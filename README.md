# COM UDT Wrapper Example
An exmaple of how to access a VB6 collection of User Defined Types (UDTs) in .NET via COM.  The problem is UDTs, structs in .NET, can't cross COM boundries.  If you need to access a VB6 UDT in a COM component you have two opitons:

1) If you have access to the VB6 source code and can re-compile it change the UDT to a class.
2) If you don't have access to the VB6 source code or can't re-comiple it then you need to wrap the UDT in a class.

This example focuses on option 2.

# Quickstart
You will need a copy of Visual Studio 2017 but not VB6.  There are compiled versions of the VB6 COM components included in the reporistory.

Clone the repository and open up the .NET project.  If needed update the COM references in the DataAdapter1Udt project.  You can find the compiled COM components in the ComLibs folder.  Then run the project and click the Export Keys button.
