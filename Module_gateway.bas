Attribute VB_Name = "Module1"
Public Function gateway(ip_address As String) As String
    gateway = Octet(ip_address, 1) & "." & Octet(ip_address, 2) & "." & Octet(ip_address, 3) & ".1"
End Function
