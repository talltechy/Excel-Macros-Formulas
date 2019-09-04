Private Sub Worksheet_Change(ByVal Target As Range)
' Created by Matt Wyen -- https://github.com/talltechy
' VBA code to clear the contents of a dependent drop down list
    On Error GoTo ErrorHandler
        'If the "Owner" Column is empty, then do not continue
        If IsEmpty(Target.Column = 11) Then Exit Sub
        'Target.Column = "the number counted from the left of the column you wish to target, E.G. The TEAM Column is the 10th column"
        If Target.Column = 10 And Target.Validation.Type = 3 Then
            'Application.EnableEvents = False stops Excel event handlers from being called. Setting it to false is usually done because the effect of the event handler is undesirable or to prevent an infinite loop.
            Application.EnableEvents = False
        'If the "Target" Column is empty or changes, Clear the cell directly to the right
        Target.Offset(0, 1).ClearContents
    End If
ErrorExit:
    Application.EnableEvents = True
    Exit Sub
ErrorHandler:

    Debug.Print Err.Number & vbNewLine & Err.Description
    Resume ErrorExit
End Sub
