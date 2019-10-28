Public Class ScrutinyColorForm
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
    End Sub
    Private Sub RedMaxSlider_Scroll(sender As Object, e As ScrollEventArgs) Handles RedMaxSlider.Scroll
        If RedMinSlider.Value >= RedMaxSlider.Value Then
            RedMinSlider.Value = RedMaxSlider.Value
        End If
        UpdateColor.UpdateColor()
    End Sub

    Private Sub RedMinSlider_Scroll(sender As Object, e As ScrollEventArgs) Handles RedMinSlider.Scroll
        If RedMaxSlider.Value <= RedMinSlider.Value Then
            RedMaxSlider.Value = RedMinSlider.Value
        End If
        UpdateColor.UpdateColor()
    End Sub
    Private Sub GreenMaxSlider_Scroll(sender As Object, e As ScrollEventArgs) Handles GreenMaxSlider.Scroll
        If GreenMinSlider.Value >= GreenMaxSlider.Value Then
            GreenMinSlider.Value = GreenMaxSlider.Value
        End If
        UpdateColor.UpdateColor()
    End Sub

    Private Sub GreenMinSlider_Scroll(sender As Object, e As ScrollEventArgs) Handles GreenMinSlider.Scroll
        If GreenMaxSlider.Value <= GreenMinSlider.Value Then
            GreenMaxSlider.Value = GreenMinSlider.Value
        End If
        UpdateColor.UpdateColor()
    End Sub
    Private Sub BlueMaxSlider_Scroll(sender As Object, e As ScrollEventArgs) Handles BlueMaxSlider.Scroll
        If BlueMinSlider.Value >= BlueMaxSlider.Value Then
            BlueMinSlider.Value = BlueMaxSlider.Value
        End If
        UpdateColor.UpdateColor()
    End Sub

    Private Sub BlueMinSlider_Scroll(sender As Object, e As ScrollEventArgs) Handles BlueMinSlider.Scroll
        If BlueMaxSlider.Value <= BlueMinSlider.Value Then
            BlueMaxSlider.Value = BlueMinSlider.Value
        End If
        UpdateColor.UpdateColor()
    End Sub
    Private Sub ToleranceSlider_Scroll(sender As Object, e As ScrollEventArgs) Handles ToleranceSlider.Scroll

        Dim globalTol As Integer = ToleranceSlider.Value / 255 * 300

        tolRed = globalTol
        tolGreen = globalTol
        tolBlue = globalTol
        SetColor()
        UpdateColor.UpdateColor()

        'Evaluate.Evaluate()
        'ScrutinyForm.PictureBox1.ImageLocation = imageNewLocation
        ToleranceLabel.Text = ToleranceSlider.Value.ToString



    End Sub

    Private Sub ScrutinyColorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        capturePix = True
    End Sub
End Class