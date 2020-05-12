Attribute VB_Name = "Module9"
Public Function netmask(hosts As Integer) As Integer

Select Case hosts
Case 1 To 2
    netmask = 252
Case 3 To 6
    netmask = 248
Case 7 To 14
    netmask = 240
Case 15 To 30
    netmask = 224
Case 31 To 62
    netmask = 192
Case 63 To 126
    netmask = 128
Case 127 To 254
    netmask = 0
End Select

End Function
