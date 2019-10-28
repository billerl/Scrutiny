Module Load
    Public Sub LoadParamTxt()
        'read text file containing parameters
        Using MyReader As New Microsoft.VisualBasic.
                     FileIO.TextFieldParser(
                       Application.StartupPath & "\param" & ".txt")
            'set delimiter to a comma
            'read everything between commas as seperate field
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            'loop thru all the parameters separated by commas
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    'current parameter being parsed in loop
                    Dim currentField As String
                    'put each word into the array "breakdown()"
                    Dim breakdown() As String
                    'loop thru each word in breakdown()
                    For Each currentField In currentRow
                        'split each word separating by a colon "|"
                        breakdown = Split(currentField, "|")
                        'call sub LoadParam-breakdown(0) is the var name
                        'breakdown(1) is the var value
                        LoadParam(breakdown(0), breakdown(1))
                    Next
                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try
            End While
        End Using
        'update the form after all parameters are loaded
        UpdateColor.UpdateColorDisplay()

    End Sub
    Public Sub LoadParam(x As String, y As Integer)
        If x = "mouseDownPosX" Then
            mouseDownPosX = y
        End If
        If x = "mouseUpPosX" Then
            mouseUpPosX = y
        End If
        If x = "mouseDownPosY" Then
            mouseDownPosY = y
        End If
        If x = "mouseUpPosY" Then
            mouseUpPosY = y
        End If
        If x = "minRed" Then
            minRed = y
        End If
        If x = "maxRed" Then
            maxRed = y
        End If
        If x = "setRed" Then
            setRed = y
        End If
        'Green
        If x = "minGreen" Then
            minGreen = y
        End If
        If x = "maxGreen" Then
            maxGreen = y
        End If
        If x = "setGreen" Then
            setGreen = y
        End If
        'Blue
        If x = "minBlue" Then
            minBlue = y
        End If
        If x = "maxBlue" Then
            maxBlue = y
        End If
        If x = "setBlue" Then
            setBlue = y
        End If
    End Sub
End Module
