Attribute VB_Name = "Module4"
Public Function VLAN(ip_address As String) As Integer
Select Case Octet(ip_address, 2)
    Case 0
        VLAN = Octet(ip_address, 3)
    Case 1 To 9
        Select Case Octet(ip_address, 3)
            Case 0 To 9
                VLAN = Octet(ip_address, 2) & "0" & Octet(ip_address, 3)
            Case 10 To 99
                VLAN = Octet(ip_address, 2) & Octet(ip_address, 3)
            Case Is > 99
                VLAN = 9999
            End Select
    Case 10 To 99
        Select Case Octet(ip_address, 3)
            Case 0 To 9
                VLAN = Octet(ip_address, 2) & "0" & Octet(ip_address, 3)
            Case 10 To 99
                VLAN = Octet(ip_address, 2) & Octet(ip_address, 3)
            Case Is > 99
                VLAN = 9999
            End Select
    Case Is > 99
        VLAN = 9999
    End Select
End Function
