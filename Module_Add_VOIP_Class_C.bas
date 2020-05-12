Attribute VB_Name = "Module6"
Public Function Add_VOIP_Class_C(ip_address As String) As String
    Add_VOIP_Class_C = "172.2" & Octet(ip_address, 2) & "." & Octet(ip_address, 3) & ".0"
End Function
