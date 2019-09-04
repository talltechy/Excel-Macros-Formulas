Sub MoveRowBasedOnValue()
' Created by Matt Wyen -- https://github.com/talltechy
    Dim xRg As Range ' This will store the list of dispositions from the Agenda sheet
    Dim I As Long ' This will be used to count the total number of used rows in the Agenda sheet
    Dim J As Long ' This will be used to identify the next blank row on the Closed Agenda sheet
    Dim K As Long ' This will be used to iterate through the dispositions from the Agenda Sheet to find the ones to copy over
    Dim cur_Disp As String ' This will be used to store the value of the disposition cell of the current Agenda row for comparison
    Dim closing_dispositions As Variant ' This will be used as an array to store the various closing dispositions in an easy to manage format
    Dim Agenda_Disposition_Column As String ' This will be used to hold which column the dispositions are in on the Agenda sheet
    Dim Closed_Agenda_Disposition_Column As String 'This will be used to hold which column the dispositions are in on the Closed Agenda sheet
    
    Sheet2.Unprotect Password:="EXAMPLE-PASSWORD" ' Unprotect the target sheet - target sheet being the Closed Agenda xYearx
    
    closing_dispositions = Array("Vulnerability is mitigated", "Converted to Project", "No action/Cancelled", "Issue Resolved", "Not technically possible or advisable", "RAF Signed") 'This is the list of dispositions that should be moved to the Closed Agenda.
    ' If you have more dispositions that need to be moved, add them in quotes (casing doesn't matter) to the array above
    Agenda_AlwaysFull_Column = "B" ' This should be the column id of a column that always has a value on the Agenda sheet
    Closed_Agenda_Disposition_Column = "L" ' This should be the column id of the Disposition column on the Closed Agenda sheet
    
    I = Sheet1.UsedRange.Rows.Count ' Grab full used range on Agenda (check under Microsoft Excel Objects in the Project Exlorer for Name to sheet number correlation)
    J = Sheet2.UsedRange.Rows.Count ' Grab full used range on Closed Agenda (check under Microsoft Excel Objects in the Project Exlorer for Name to sheet number correlation)
    
    ' You should NOT have to change anything below this line.
    Sheet1.Range("A1").Select
    Set xRg = Sheet2.Range(Agenda_AlwaysFull_Column & "1:" & Agenda_AlwaysFull_Column & J) ' Grab column B from Closed Agenda that is filled out
    For J = 1 To xRg.Count ' Loop through that column to find the first row that is blank, this is our real target row.
        If Len(Trim(CStr(xRg(J).Value))) = 0 Then
            J = J ' Once we know where to insert, break out of the loop, everything else will be blank.
            Exit For
        End If
    Next
    
    Set xRg = Sheet1.Range(Closed_Agenda_Disposition_Column & "1:" & Closed_Agenda_Disposition_Column & I) 'Grab the column with Dispositions
    On Error Resume Next
    Application.ScreenUpdating = False ' Make the work invisible
    For K = 1 To xRg.Count ' Check each row in the range
        cur_Disp = LCase(CStr(xRg(K).Value)) ' grab the disposition of the current row
        For Each disposition In closing_dispositions ' Loop through the closing_disposition array
            If cur_Disp = LCase(disposition) Then ' if there is a match
                xRg(K).EntireRow.Copy ' Grab the row from Agenda
                Sheet2.Range("A" & J).PasteSpecial Paste:=xlValues ' Paste it in to the Closed Agenda
                xRg(K).EntireRow.Delete ' Purge it from Agenda
                ' Debug.Print "would delete row " & K
                K = K - 1 ' Roll back to the previous row number as we just dropped one
                J = J + 1 ' Remember to increment the row to insert at
                ' Exit For 'Do not need to keep checking dispositions for this row, so exit out
            End If
        Next
        
    Next
    Application.ScreenUpdating = True ' Work is done, make visible and release.
    Sheet2.Protect Password:="EXAMPLE-PASSWORD", UserInterFaceOnly:=True ' Protect the target sheet again.
End Sub
