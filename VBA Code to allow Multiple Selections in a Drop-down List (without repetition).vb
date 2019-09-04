Private Sub Worksheet_Change(ByVal Target As Range)
' Created by Matt Wyen -- https://github.com/talltechy
' To allow multiple selections in a Drop Down List in Excel (without repetition)
' Put code in worksheet code page
Dim Oldvalue As String
Dim Newvalue As String
Application.EnableEvents = True
On Error GoTo Exitsub
If Target.Address = "$C$2" Then
  If Target.SpecialCells(xlCellTypeAllValidation) Is Nothing Then
    GoTo Exitsub
  Else: If Target.Value = "" Then GoTo Exitsub Else
    Application.EnableEvents = False
    Newvalue = Target.Value
    Application.Undo
    Oldvalue = Target.Value
      If Oldvalue = "" Then
        Target.Value = Newvalue
      Else
        If InStr(1, Oldvalue, Newvalue) = 0 Then
            Target.Value = Oldvalue & ", " & Newvalue
      Else:
        Target.Value = Oldvalue
      End If
    End If
  End If
End If
Application.EnableEvents = True
Exitsub:
Application.EnableEvents = True
End Sub
