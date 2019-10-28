Imports System.IO

Module Evaluate
    Public Sub Evaluate()

        If evaluateEnabled = True Then
            Dim lookFile As String = Application.StartupPath & "\pixpattern" & ".txt"
            While File.Exists(lookFile)
                Try
                    If (System.IO.File.Exists(lookFile)) Then
                        Delete.Delete(lookFile)
                    End If
                Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message))
                End Try
            End While

            Dim xPix As Integer
            Dim yPix As Integer
            Dim moveX As Integer
            Dim moveY As Integer
            Dim stopX As Integer
            Dim stopY As Integer
            Dim a As Integer
            Dim b As Integer

            'drawing x right to left
            If mouseDownPosX >= mouseUpPosX Then
                xPix = mouseDownPosX - mouseUpPosX
                moveX = mouseUpPosX
                a = 1
            Else
                'drawing x left to right *working
                xPix = mouseUpPosX - mouseDownPosX
                moveX = mouseDownPosX
                a = 1
            End If
            stopX = moveX
            'drawing y bottom to top
            If mouseDownPosY >= mouseUpPosY Then
                yPix = mouseDownPosY - mouseUpPosY
                moveY = mouseUpPosY
                b = 1
            Else
                'drawing y top to bottom *working
                yPix = mouseUpPosY - mouseDownPosY
                moveY = mouseDownPosY
                b = 1
            End If
            stopY = moveY

            Dim myGraphics As Graphics

            Dim myRectangle As Rectangle

            Dim myPen As New Pen(Color.Blue)

            'return the current form as a drawing surface

            myGraphics = Graphics.FromHwnd(ScrutinyForm.PictureBox1.Handle)

            'create a rectangle based on x,y coordinates, width, & height

            myRectangle = New Rectangle(x:=moveX, y:=moveY, width:=xPix, height:=yPix)

            'draw rectangle from pen and rectangle objects

            myGraphics.DrawRectangle(pen:=myPen, rect:=myRectangle)

            If picLoaded = True Then
                Dim MyBitmap As Bitmap
                Dim colorTotal As Integer = 0
                Dim pixColor As Color
                Dim pixHiLo As Integer = 0
                Dim xLine As Integer = 0

                MyBitmap = CType(ScrutinyForm.PictureBox1.Image, Bitmap)
                Try
                    Do Until moveX >= xPix + stopX
                        Do Until moveY >= yPix + stopY
                            pixColor = MyBitmap.GetPixel(moveX, moveY)

                            If (moveX = stopX) OrElse (moveX = stopX + xPix - 1) OrElse (moveY = stopY + yPix - 1) OrElse (moveY = stopY) Then
                                MyBitmap.SetPixel(moveX, moveY, Color.Lime)
                            End If
                            moveY = moveY + b
                            pixColor = MyBitmap.GetPixel(moveX, moveY)
                            If pixColor.R <= maxRed And pixColor.G <= maxGreen And pixColor.B <= maxBlue And pixColor.R >= minRed And pixColor.G >= minGreen And pixColor.B >= minBlue Then
                                MyBitmap.SetPixel(moveX, moveY, Color.LightCyan)

                                colorTotal = colorTotal + pixColor.B + pixColor.G + pixColor.R
                                pixHiLo = 1
                            Else
                                pixHiLo = 0
                            End If
                            colorTotal = colorTotal + pixHiLo
                            'pixString.Append(pixHiLo.ToString)
                        Loop
                        xLine = xLine + 1
                        moveX = moveX + a
                        moveY = stopY

                        'pixString.AppendLine()

                    Loop
                Catch ex As Exception
                    MessageBox.Show(String.Format("Inspection area out of bounds " + ex.Message))
                    'Exit Sub
                End Try
                'ScrutinyForm.LabelDebug.Text = moveX.ToString + " / " + moveY.ToString


                'ScrutinyForm.fileTransfer.Text = colorTotal

                'Dim tolerance As Integer = ScrutinyForm.TextBox2.Text
                'If colorTotal > tolerance Then
                '    ScrutinyForm.colorResult.BackColor = Color.Lime
                '    ScrutinyForm.colorResult.Text = "GOOD"
                'Else
                '    ScrutinyForm.colorResult.BackColor = Color.Red
                '    ScrutinyForm.colorResult.Text = "BAD"
                'End If



                '    pixPattern = pixString.ToString
                '    MainForm.String1TB.Text = pixPattern
                '    Dim file As StreamWriter
                '    Dim newFont As Font
                '    newFont = New Font("Symbol", 8, FontStyle.Regular)

                '    file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\pixpattern" & ".txt", False)
                '    file.Write(pixPattern, newFont, False)
                '    file.Close()

            End If
        End If

    End Sub
End Module
