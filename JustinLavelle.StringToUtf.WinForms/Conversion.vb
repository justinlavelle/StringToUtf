Module Conversion

    Public Function ConvertToUTF16(ByVal str As String) As String
        ' Local Variable Declaration
        Dim ArrayOFBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(str)
        Dim UTF16 As String
        Dim v As Integer

        For v = 0 To ArrayOFBytes.Length - 1
            If v Mod 2 = 0 Then
                Dim t As Integer = ArrayOFBytes(v)
                ArrayOFBytes(v) = ArrayOFBytes(v + 1)
                ArrayOFBytes(v + 1) = t
            End If
        Next
        For v = 0 To ArrayOFBytes.Length - 1
            Dim c As String = Hex$(ArrayOFBytes(v))
            If c.Length = 1 Then
                c = "0" & c
            End If
            UTF16 = UTF16 & c
        Next

        Return UTF16                                        ' Returns valid UTF String
    End Function

End Module
