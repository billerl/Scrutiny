﻿Imports System.IO
Module Save
    Public Sub Save(x As String, a As Integer)
        ScrutinyForm.LblDebug.Text = Application.StartupPath
        If savingFirstPass = True Then

            Try
                Dim lookFile As String = Application.StartupPath & "\param" & ".txt"
                If (System.IO.File.Exists(lookFile)) Then
                    ' If System.IO.File.Exists(noImg) = True Then
                    Delete.Delete(lookFile)

                End If
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
                'Exit Sub
            End Try
            savingFirstPass = False
        End If

        Dim file As StreamWriter
        'true allows appending to what is already written / false deletes and writes new
        file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\param" & ".txt", True)
        If savingLastPass = False Then
            file.Write(x & "|" & a & ",", False)
        Else
            file.Write(x & "|" & a, False)
            savingLastPass = False
        End If
        file.Close()

    End Sub
    Public Sub SaveStuff()
        savingFirstPass = True


        Save((NameOf(mouseDownPosX)), mouseDownPosX)
        Save((NameOf(mouseUpPosX)), mouseUpPosX)
        Save((NameOf(mouseDownPosY)), mouseDownPosY)
        Save((NameOf(mouseUpPosY)), mouseUpPosY)
        'Red
        Save((NameOf(minRed)), minRed)
        Save((NameOf(maxRed)), maxRed)
        Save((NameOf(setRed)), setRed)
        'Green
        Save((NameOf(minGreen)), minGreen)
        Save((NameOf(maxGreen)), maxGreen)
        Save((NameOf(setGreen)), setGreen)

        Save((NameOf(minBlue)), minBlue)
        Save((NameOf(maxBlue)), maxBlue)
        savingLastPass = True
        Save((NameOf(setBlue)), setBlue)

        savingFirstPass = False
    End Sub
End Module
