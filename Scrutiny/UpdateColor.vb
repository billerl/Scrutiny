Module UpdateColor

    Public Sub UpdateColorDisplay()
        ScrutinyColorForm.RedDisplayLabel.BackColor = Color.FromArgb(setRed, 0, 0)
        ScrutinyColorForm.GreenDisplayLabel.BackColor = Color.FromArgb(0, setGreen, 0)
        ScrutinyColorForm.BlueDisplayLabel.BackColor = Color.FromArgb(0, 0, setBlue)
        ScrutinyColorForm.RedLabel.Text = "RED: Set: " + setRed.ToString + " Min : " + minRed.ToString + " / Max : " + maxRed.ToString
        ScrutinyColorForm.GreenLabel.Text = "Green: Set: " + setGreen.ToString + " Min : " + minGreen.ToString + " / Max : " + maxGreen.ToString
        ScrutinyColorForm.BlueLabel.Text = "Blue: Set: " + setBlue.ToString + " Min : " + minBlue.ToString + " / Max : " + maxBlue.ToString
        ScrutinyColorForm.RedMinSlider.Value = minRed
        ScrutinyColorForm.RedMaxSlider.Value = maxRed
        ScrutinyColorForm.GreenMinSlider.Value = minGreen
        ScrutinyColorForm.GreenMaxSlider.Value = maxGreen
        ScrutinyColorForm.BlueMinSlider.Value = minBlue
        ScrutinyColorForm.BlueMaxSlider.Value = maxBlue
    End Sub
    Public Sub UpdateColor()

        'Capture button pushed
        If capturePix = True Then
            SetColor()
        Else
            'Red
            minRed = ScrutinyColorForm.RedMinSlider.Value
            maxRed = ScrutinyColorForm.RedMaxSlider.Value
            setRed = (minRed + maxRed) / 2
            'Green
            minGreen = ScrutinyColorForm.GreenMinSlider.Value
            maxGreen = ScrutinyColorForm.GreenMaxSlider.Value
            setGreen = (minGreen + maxGreen) / 2
            'Blue
            minBlue = ScrutinyColorForm.BlueMinSlider.Value
            maxBlue = ScrutinyColorForm.BlueMaxSlider.Value
            setBlue = (minBlue + maxBlue) / 2
        End If
        'Red
        If maxRed > 255 Then
            maxRed = 255
        End If
        If minRed < 0 Then
            minRed = 0
        End If
        'green
        If maxGreen > 255 Then
            maxGreen = 255
        End If
        If minGreen < 0 Then
            minGreen = 0
        End If
        'Blue
        If maxBlue > 255 Then
            maxBlue = 255
        End If
        If minBlue < 0 Then
            minBlue = 0
        End If
        UpdateColorDisplay()
        Evaluate.Evaluate()
    End Sub
    Public Sub SetColor()
        'Red
        minRed = setRed - (tolRed / 2)
        maxRed = setRed + (tolRed / 2)
        If maxRed > 255 Then
            maxRed = 255
        End If
        If minRed < 0 Then
            minRed = 0
        End If
        ScrutinyColorForm.RedMinSlider.Value = minRed
        ScrutinyColorForm.RedMaxSlider.Value = maxRed

        'Green
        minGreen = setGreen - (tolGreen / 2)
        maxGreen = setGreen + (tolGreen / 2)
        If maxGreen > 255 Then
            maxGreen = 255
        End If
        If minGreen < 0 Then
            minGreen = 0
        End If
        ScrutinyColorForm.GreenMinSlider.Value = minGreen
        ScrutinyColorForm.GreenMaxSlider.Value = maxGreen

        'Blue
        minBlue = setBlue - (tolBlue / 2)
        maxBlue = setBlue + (tolBlue / 2)
        If maxBlue > 255 Then
            maxBlue = 255
        End If
        If minBlue < 0 Then
            minBlue = 0
        End If
        ScrutinyColorForm.BlueMinSlider.Value = minBlue
        ScrutinyColorForm.BlueMaxSlider.Value = maxBlue
    End Sub
End Module
