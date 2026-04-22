Imports System.Configuration
Imports MySql.Data.MySqlClient

' Utility class – cannot be instantiated or inherited; all access is through shared members.
Public NotInheritable Class DBConnection
    Private Sub New()
    End Sub

    ' Reads the connection string named "TwoCRentals" from App.config and returns
    ' a new (closed) MySqlConnection. Callers must open and dispose it themselves.
    Public Shared Function GetConnection() As MySqlConnection
        Dim connStr As String = ConfigurationManager.ConnectionStrings("TwoCRentals").ConnectionString
        Return New MySqlConnection(connStr)
    End Function
End Class
