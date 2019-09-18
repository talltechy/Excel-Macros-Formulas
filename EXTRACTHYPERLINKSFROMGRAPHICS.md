# How to extract a URL from a hyperlinked image, graphic, or icon on Excel

When you copy and paste data from the Web onto an Excel spreadsheet, you sometimes end up copying and pasting images, graphics, or icons that were originally hyperlinks. To make the data usable, you may want to extract just the hyperlink and get rid of the image, graphic, or icon.

## You have two options. First is to do it manually

- Right-click a hyperlinked image, graphic, or icon.
- From the Context menu, choose Edit Hyperlink. Excel displays the Edit Hyperlink dialog box.
- Select and copy (Ctrl+C) the entire URL from the Address field of the dialog box.
- Press Esc to close the Edit Hyperlink dialog box.
- Paste the URL into any cell desired.

But what if you have more than just a few hyperlinked images, graphics, or icons? If you had to do this for each and every single hyperlinked image, graphic, or icon, this can get tedious very very quickly. So the second option is to get the URLs using a macro.

The following example can be useful when extracting hyperlinks from images, graphics, or icons that have been copied into Excel.

## Extracting a URL from a hyperlinked image, graphic, or icon on Excel - the VB way

- Open up a new workbook.
- Get into VBA (Press Alt+F11)
- Insert a new module (Insert > Module)
- Copy and Paste the Excel user defined function below
- Press F5 and click “Run”
- Get out of VBA (Press Alt+Q)

```vb
Sub ConvertHLShapes()
Dim shp As Shape
Dim sTemp As String

For Each shp In ActiveSheet.Shapes
sTemp = ""
On Error Resume Next 'go to next shape if no hyperlink
sTemp = shp.Hyperlink.Address
On Error GoTo 0
If sTemp <> "" Then
shp.TopLeftCell.Value = sTemp
shp.Delete
End If
Next
End Sub
```
