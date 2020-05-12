Attribute VB_Name = "Module5"
Public Function Add_Class_C(ip_address As String) As String
    Add_Class_C = Octet(ip_address, 1) & "." & Octet(ip_address, 2) & "." & Octet(ip_address, 3) + 1 & "." & Octet(ip_address, 4)
End Function
