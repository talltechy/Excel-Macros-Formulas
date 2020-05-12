Attribute VB_Name = "Module3"
Public Function Octet(inIP As String, tetNo As Integer) As Byte
    Dim a() As String
    a = Split(inIP, ".")
    Octet = CByte(a(tetNo - 1)) ' Subtract 1 for 1,2,3,4
End Function
