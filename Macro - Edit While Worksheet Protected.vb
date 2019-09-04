Private Sub Workbook_open()
' Created by Matt Wyen -- https://github.com/talltechy
' Repeat with the name and password of additional sheets to be manipulated by VBA.
' secret is the password to the sheet
' Sheet1/2/3 etc is the Worksheet.Codename property found in VBA module editor
' This macro needs to be insterted into the ThisWorkbook page in the VBAProject (Macros)
Sheet1.Protect Password:="test", UserInterFaceOnly:=True
Sheet2.Protect Password:="test", UserInterFaceOnly:=True
Sheet3.Protect Password:="test", UserInterFaceOnly:=True
Sheet4.Protect Password:="test", UserInterFaceOnly:=True
Sheet5.Protect Password:="test", UserInterFaceOnly:=True
Sheet6.Protect Password:="test", UserInterFaceOnly:=True
Sheet7.Protect Password:="test", UserInterFaceOnly:=True
Sheet8.Protect Password:="test", UserInterFaceOnly:=True
Sheet9.Protect Password:="test", UserInterFaceOnly:=True
Sheet10.Protect Password:="test", UserInterFaceOnly:=True
Sheet11.Protect Password:="test", UserInterFaceOnly:=True
Sheet12.Protect Password:="test", UserInterFaceOnly:=True
Sheet24.Protect Password:="test", UserInterFaceOnly:=True
End Sub
