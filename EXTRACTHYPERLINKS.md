# Extracting a URL from a hyperlink on Excel

## Option 1: If you want to run this operation one time

Open up a new workbook.

Get into VBA (Press Alt+F11)

Insert a new module (Insert > Module)

Copy and Paste the Excel user defined function below

Press F5 and click “Run”

Get out of VBA (Press Alt+Q)

```vb
Sub ExtractHL()
Dim HL As Hyperlink
For Each HL In ActiveSheet.Hyperlinks
HL.Range.Offset(0, 1).Value = HL.Address
Next
End Sub
```

## Option 2: If you plan to add more hyperlinks to the spreadsheet and need to store the formula on the sheet

Open up a new workbook.

Get into VBA (Press Alt+F11)

Insert a new module (Insert > Module)

Copy and Paste the Excel user defined function below

Get out of VBA (Press Alt+Q)

Use this syntax for this custom Excel function:

```excel
=GetURL(cell,[default_value])
```

VB Code:

```vb
Function GetURL(cell As range, _
Optional default_value As Variant)
'Lists the Hyperlink Address for a Given Cell
'If cell does not contain a hyperlink, return default_value
If (cell.range("A1").Hyperlinks.Count <> 1) Then
GetURL = default_value
Else
GetURL = cell.range("A1").Hyperlinks(1).Address & "#" & cell.range("A1").Hyperlinks(1).SubAddress
End If
End Function
```
