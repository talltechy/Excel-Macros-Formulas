Attribute VB_Name = "Module8"
Public Function VOIP_Network(ip_address As String) As Integer

Dim VLAN_Prefix As String
Dim VLAN_Suffix As String

Select Case Octet(ip_address, 2)
    Case 0
        VOIP_Network = "20" & Octet(ip_address, 3)
    Case 1 To 9
        Select Case Octet(ip_address, 3)
            Case 0 To 9
                VLAN_Suffix = Octet(ip_address, 2) & "0" & Octet(ip_address, 3)
            Case 10 To 99
                VLAN_Suffix = Octet(ip_address, 2) & Octet(ip_address, 3)
            Case Else
                VLAN_Suffix = 9999
            End Select
    Case 10 To 99
        Select Case Octet(ip_address, 3)
            Case 0 To 9
                VLAN_Suffix = Octet(ip_address, 2) & "0" & Octet(ip_address, 3)
            Case 10 To 99
                VLAN_Suffix = Octet(ip_address, 2) & Octet(ip_address, 3)
            Case Else
                VLAN_Suffix = 9999
            End Select
    Case Else
        VLAN_Suffix = 9999
    End Select
    
Select Case Len(VLAN_Suffix)
    Case Is < 4
        VOIP_Network = "2" & VLAN_Suffix
    Case Else
        VOIP_Network = VLAN_Suffix
    End Select
    
    
    
    
End Function
