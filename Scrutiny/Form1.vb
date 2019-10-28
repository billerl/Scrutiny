Public Class Form1
    Public countDown As Integer
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ScrutinyFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        countDown = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim color As Color
        If countDown < 100 Then
            countDown = countDown + 1
            Me.BackColor = Color.FromArgb(countDown * 2.5, countDown * 2.5, countDown * 2.5)
            ToolStripProgressBar1.Value = countDown
        Else
            ScrutinyForm.Show()

            Me.Hide()
        End If



    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class
