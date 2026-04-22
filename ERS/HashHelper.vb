Imports System.Security.Cryptography
Imports System.Text

' Utility class for password hashing. Passwords are never stored in plain text;
' only the SHA-256 hash is persisted in the database.
Public NotInheritable Class HashHelper
    Private Sub New()
    End Sub

    ' Converts a plain-text string to its lowercase hexadecimal SHA-256 digest.
    ' The result is always 64 characters long and is safe to store in the DB.
    Public Shared Function ComputeSHA256(plainText As String) As String
        Using sha As SHA256 = SHA256.Create()
            ' Encode the text as UTF-8 bytes then hash them
            Dim bytes As Byte() = sha.ComputeHash(Encoding.UTF8.GetBytes(plainText))

            ' Convert each byte to a 2-digit lowercase hex string and concatenate
            Dim sb As New StringBuilder()
            For Each b As Byte In bytes
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function
End Class
