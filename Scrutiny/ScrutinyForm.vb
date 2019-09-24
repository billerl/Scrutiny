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
        ScrutinyFrm.Close()
    End Sub



    Private Sub ScrutinyForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ScrutinyFrm.Close()
    End Sub

    Private Sub ScrutinyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageNewLocation = "C:\Images\EMGU.jpg"
        PictureBox1.ImageLocation = imageNewLocation
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
    End Sub

    Private Sub SetRangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetRangeToolStripMenuItem.Click
        ScrutinyColorForm.Show()
    End Sub
End Class