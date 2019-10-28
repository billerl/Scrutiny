Imports Emgu.CV
Imports Emgu.CV.Util
Imports Emgu.CV.Structure
Imports System.ComponentModel
Imports System.IO
Imports System.Drawing
Public Class ScrutinyForm
    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If defineArea = True Then
            Dim MousePos As Point = PictureBox1.PointToClient(MousePosition)
            mouseDownPosX = MousePos.X
            mouseDownPosY = MousePos.Y
            mouseIsDown = True
            'LabelMousePos.Text = MousePos.ToString
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If defineArea = True Then
            Dim MousePos As Point = PictureBox1.PointToClient(MousePosition)
            mouseUpPosX = MousePos.X
            mouseUpPosY = MousePos.Y
            defineArea = False
            'DefineBtn.Text = "Define Area"
            'DefineBtn.BackColor = Color.DarkGray
            DrawRect()
        End If
        mouseIsDown = False
    End Sub
    Private Sub CreateNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewToolStripMenuItem.Click
        defineArea = True
    End Sub
    Public Sub DrawRect()
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
        'LabelDebug.Text = a.ToString + " / " + b.ToString


        'LabelMousePos.Text = LabelMousePos.Text + " / " + MousePosition.X.ToString + " X width = " + xPix.ToString + " Y width = " + yPix.ToString

        Dim myGraphics As Graphics

        Dim myRectangle As Rectangle

        Dim myPen As New Pen(Color.LimeGreen)

        'return the current form as a drawing surface

        myGraphics = Graphics.FromHwnd(PictureBox1.Handle)

        'create a rectangle based on x,y coordinates, width, & height

        myRectangle = New Rectangle(x:=moveX, y:=moveY, width:=xPix, height:=yPix)

        'draw rectangle from pen and rectangle objects

        myGraphics.DrawRectangle(pen:=myPen, rect:=myRectangle)




    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Form1.Close()
    End Sub



    Private Sub ScrutinyForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Close()
    End Sub

    'Public Sub Evaluate()

    '    If evaluateEnabled = True Then
    '        Dim lookFile As String = Application.StartupPath & "\pixpattern" & ".txt"
    '        While File.Exists(lookFile)
    '            Try
    '                If (System.IO.File.Exists(lookFile)) Then
    '                    Delete.Delete(lookFile)
    '                End If
    '            Catch ex As Exception
    '                MessageBox.Show(String.Format("Error: {0}", ex.Message))
    '            End Try
    '        End While

    '        Dim xPix As Integer
    '        Dim yPix As Integer
    '        Dim moveX As Integer
    '        Dim moveY As Integer
    '        Dim stopX As Integer
    '        Dim stopY As Integer
    '        Dim a As Integer
    '        Dim b As Integer

    '        'drawing x right to left
    '        If mouseDownPosX >= mouseUpPosX Then
    '            xPix = mouseDownPosX - mouseUpPosX
    '            moveX = mouseUpPosX
    '            a = 1
    '        Else
    '            'drawing x left to right *working
    '            xPix = mouseUpPosX - mouseDownPosX
    '            moveX = mouseDownPosX
    '            a = 1
    '        End If
    '        stopX = moveX
    '        'drawing y bottom to top
    '        If mouseDownPosY >= mouseUpPosY Then
    '            yPix = mouseDownPosY - mouseUpPosY
    '            moveY = mouseUpPosY
    '            b = 1
    '        Else
    '            'drawing y top to bottom *working
    '            yPix = mouseUpPosY - mouseDownPosY
    '            moveY = mouseDownPosY
    '            b = 1
    '        End If
    '        stopY = moveY

    '        Dim myGraphics As Graphics

    '        Dim myRectangle As Rectangle

    '        Dim myPen As New Pen(Color.Blue)

    '        'return the current form as a drawing surface

    '        myGraphics = Graphics.FromHwnd(Me.PictureBox1.Handle)

    '        'create a rectangle based on x,y coordinates, width, & height

    '        myRectangle = New Rectangle(x:=moveX, y:=moveY, width:=xPix, height:=yPix)

    '        'draw rectangle from pen and rectangle objects

    '        myGraphics.DrawRectangle(pen:=myPen, rect:=myRectangle)

    '        If picLoaded = True Then
    '            Dim MyBitmap As Bitmap
    '            Dim colorTotal As Integer = 0
    '            Dim pixColor As Color
    '            Dim pixHiLo As Integer = 0
    '            Dim xLine As Integer = 0

    '            MyBitmap = CType(Me.PictureBox1.Image, Bitmap)
    '            Try
    '                Do Until moveX >= xPix + stopX
    '                    Do Until moveY >= yPix + stopY
    '                        pixColor = MyBitmap.GetPixel(moveX, moveY)

    '                        If (moveX = stopX) OrElse (moveX = stopX + xPix - 1) OrElse (moveY = stopY + yPix - 1) OrElse (moveY = stopY) Then
    '                            MyBitmap.SetPixel(moveX, moveY, Color.Lime)
    '                        End If
    '                        moveY = moveY + b
    '                        pixColor = MyBitmap.GetPixel(moveX, moveY)
    '                        If pixColor.R <= maxRed And pixColor.G <= maxGreen And pixColor.B <= maxBlue And pixColor.R >= minRed And pixColor.G >= minGreen And pixColor.B >= minBlue Then
    '                            MyBitmap.SetPixel(moveX, moveY, Color.LightCyan)

    '                            colorTotal = colorTotal + pixColor.B + pixColor.G + pixColor.R
    '                            pixHiLo = 1
    '                        Else
    '                            pixHiLo = 0
    '                        End If
    '                        colorTotal = colorTotal + pixHiLo
    '                        'pixString.Append(pixHiLo.ToString)
    '                    Loop
    '                    xLine = xLine + 1
    '                    moveX = moveX + a
    '                    moveY = stopY

    '                    'pixString.AppendLine()

    '                Loop
    '            Catch ex As Exception
    '                MessageBox.Show(String.Format("Inspection area out of bounds " + ex.Message))
    '                'Exit Sub
    '            End Try
    '            'ScrutinyForm.LabelDebug.Text = moveX.ToString + " / " + moveY.ToString


    '            'ScrutinyForm.fileTransfer.Text = colorTotal

    '            'Dim tolerance As Integer = ScrutinyForm.TextBox2.Text
    '            'If colorTotal > tolerance Then
    '            '    ScrutinyForm.colorResult.BackColor = Color.Lime
    '            '    ScrutinyForm.colorResult.Text = "GOOD"
    '            'Else
    '            '    ScrutinyForm.colorResult.BackColor = Color.Red
    '            '    ScrutinyForm.colorResult.Text = "BAD"
    '            'End If



    '            '    pixPattern = pixString.ToString
    '            '    MainForm.String1TB.Text = pixPattern
    '            '    Dim file As StreamWriter
    '            '    Dim newFont As Font
    '            '    newFont = New Font("Symbol", 8, FontStyle.Regular)

    '            '    file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\pixpattern" & ".txt", False)
    '            '    file.Write(pixPattern, newFont, False)
    '            '    file.Close()

    '        End If
    '    End If

    'End Sub

    Private Sub ScrutinyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        imageNewLocation = "C:\Images\EMGU.jpg"
        'PictureBox1.ImageLocation = imageNewLocation
        LoadParamTxt()
    End Sub

    Private Sub CaptureColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CaptureColorToolStripMenuItem.Click
        capturePix = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.Click
        If capturePix = True Then
            If picLoaded = True Then
                Try
                    Dim MyBitmap As Bitmap
                    Dim SnapShot As Color
                    MyBitmap = CType(PictureBox1.Image, Bitmap)
                    SnapShot = MyBitmap.GetPixel(e.X, e.Y)
                    setRed = SnapShot.R
                    setGreen = SnapShot.G
                    setBlue = SnapShot.B
                    'colorResult.Text = Me.BackColor.ToArgb.ToString + " R= " + Me.BackColor.R.ToString + " G=" + Me.BackColor.G.ToString + " B=" + Me.BackColor.B.ToString
                    UpdateColor.UpdateColor()

                Catch ex As Exception
                    'MessageBox.Show(String.Format("Error: {0}", ex.Message))
                    'Exit Sub
                End Try
            End If
        End If
        capturePix = False
    End Sub

    Private Sub PictureBox1_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles PictureBox1.LoadCompleted
        picLoaded = True
        evaluateEnabled = True
        Evaluate.Evaluate()
    End Sub

    Private Sub SetRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetRangeToolStripMenuItem.Click
        ScrutinyColorForm.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveStuff()
    End Sub

    Private Sub BtnManTrigger_Click(sender As Object, e As EventArgs) Handles BtnManTrigger.Click
        PictureBox1.ImageLocation = imageNewLocation
        'evaluateEnabled = True
        'Evaluate()
    End Sub
End Class