Sub ChartProtection()
' Created by Matt Wyen
For Each I In ActiveSheet.ChartObjects
    I.Chart.ProtectSelection = False
    I.Chart.ProtectData = True
    I.Chart.ProtectFormatting = True
Next I
End Sub