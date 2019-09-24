Module Variables
    Public imageNewLocation As String
    Public picLoaded As Boolean
    Public BMP As New Drawing.Bitmap(1200, 800)
    Public GFX As Graphics = Graphics.FromImage(BMP)
    Public mouseDownPosX As Integer
    Public mouseUpPosX As Integer
    Public mouseDownPosY As Integer
    Public mouseUpPosY As Integer
    Public mouseIsDown As Boolean
    Public minRed As Integer
    Public maxRed As Integer
    Public setRed As Integer
    Public tolRed As Integer
    Public minGreen As Integer
    Public maxGreen As Integer
    Public setGreen As Integer
    Public tolGreen As Integer
    Public minBlue As Integer
    Public maxBlue As Integer
    Public setBlue As Integer
    Public tolBlue As Integer
    Public capturePix As Boolean
    Public defineArea As Boolean
    Public evaluateEnabled As Boolean
    Public myColor() As String = {"Red", "Green", "Blue"}
    Public savingFirstPass As Boolean
    Public savingLastPass As Boolean
    Public pixPattern As String
    Public pixString As New System.Text.StringBuilder
    Public startTime As DateTime
    Public stopTime As DateTime
    Public elapsedTime As TimeSpan
End Module
