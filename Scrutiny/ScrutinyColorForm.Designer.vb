<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScrutinyColorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GlobalLabel = New System.Windows.Forms.Label()
        Me.GlobalChecked = New System.Windows.Forms.CheckBox()
        Me.ToleranceLabel = New System.Windows.Forms.Label()
        Me.ToleranceSlider = New System.Windows.Forms.VScrollBar()
        Me.BlueDisplayLabel = New System.Windows.Forms.Label()
        Me.GreenDisplayLabel = New System.Windows.Forms.Label()
        Me.RedDisplayLabel = New System.Windows.Forms.Label()
        Me.BlueMaxSlider = New System.Windows.Forms.HScrollBar()
        Me.BlueMinSlider = New System.Windows.Forms.HScrollBar()
        Me.BlueLabel = New System.Windows.Forms.Label()
        Me.GreenMaxSlider = New System.Windows.Forms.HScrollBar()
        Me.GreenMinSlider = New System.Windows.Forms.HScrollBar()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.RedMaxSlider = New System.Windows.Forms.HScrollBar()
        Me.RedMinSlider = New System.Windows.Forms.HScrollBar()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GlobalLabel
        '
        Me.GlobalLabel.AutoSize = True
        Me.GlobalLabel.Font = New System.Drawing.Font("BankGothic Lt BT", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GlobalLabel.ForeColor = System.Drawing.Color.White
        Me.GlobalLabel.Location = New System.Drawing.Point(388, 64)
        Me.GlobalLabel.Name = "GlobalLabel"
        Me.GlobalLabel.Size = New System.Drawing.Size(60, 28)
        Me.GlobalLabel.TabIndex = 68
        Me.GlobalLabel.Text = "Global" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tol."
        Me.GlobalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GlobalChecked
        '
        Me.GlobalChecked.AutoSize = True
        Me.GlobalChecked.Location = New System.Drawing.Point(406, 96)
        Me.GlobalChecked.Name = "GlobalChecked"
        Me.GlobalChecked.Size = New System.Drawing.Size(18, 17)
        Me.GlobalChecked.TabIndex = 67
        Me.GlobalChecked.UseVisualStyleBackColor = True
        '
        'ToleranceLabel
        '
        Me.ToleranceLabel.AutoSize = True
        Me.ToleranceLabel.ForeColor = System.Drawing.Color.White
        Me.ToleranceLabel.Location = New System.Drawing.Point(436, 219)
        Me.ToleranceLabel.Name = "ToleranceLabel"
        Me.ToleranceLabel.Size = New System.Drawing.Size(36, 17)
        Me.ToleranceLabel.TabIndex = 66
        Me.ToleranceLabel.Text = "00%"
        '
        'ToleranceSlider
        '
        Me.ToleranceSlider.Location = New System.Drawing.Point(403, 126)
        Me.ToleranceSlider.Maximum = 109
        Me.ToleranceSlider.Name = "ToleranceSlider"
        Me.ToleranceSlider.Size = New System.Drawing.Size(24, 221)
        Me.ToleranceSlider.TabIndex = 65
        '
        'BlueDisplayLabel
        '
        Me.BlueDisplayLabel.BackColor = System.Drawing.Color.Blue
        Me.BlueDisplayLabel.ForeColor = System.Drawing.Color.White
        Me.BlueDisplayLabel.Location = New System.Drawing.Point(338, 284)
        Me.BlueDisplayLabel.Name = "BlueDisplayLabel"
        Me.BlueDisplayLabel.Size = New System.Drawing.Size(40, 63)
        Me.BlueDisplayLabel.TabIndex = 64
        '
        'GreenDisplayLabel
        '
        Me.GreenDisplayLabel.BackColor = System.Drawing.Color.Green
        Me.GreenDisplayLabel.ForeColor = System.Drawing.Color.White
        Me.GreenDisplayLabel.Location = New System.Drawing.Point(338, 187)
        Me.GreenDisplayLabel.Name = "GreenDisplayLabel"
        Me.GreenDisplayLabel.Size = New System.Drawing.Size(40, 63)
        Me.GreenDisplayLabel.TabIndex = 63
        '
        'RedDisplayLabel
        '
        Me.RedDisplayLabel.BackColor = System.Drawing.Color.Red
        Me.RedDisplayLabel.ForeColor = System.Drawing.Color.White
        Me.RedDisplayLabel.Location = New System.Drawing.Point(338, 86)
        Me.RedDisplayLabel.Name = "RedDisplayLabel"
        Me.RedDisplayLabel.Size = New System.Drawing.Size(40, 63)
        Me.RedDisplayLabel.TabIndex = 62
        '
        'BlueMaxSlider
        '
        Me.BlueMaxSlider.Location = New System.Drawing.Point(52, 326)
        Me.BlueMaxSlider.Maximum = 264
        Me.BlueMaxSlider.Name = "BlueMaxSlider"
        Me.BlueMaxSlider.Size = New System.Drawing.Size(283, 21)
        Me.BlueMaxSlider.TabIndex = 61
        '
        'BlueMinSlider
        '
        Me.BlueMinSlider.Location = New System.Drawing.Point(52, 284)
        Me.BlueMinSlider.Maximum = 264
        Me.BlueMinSlider.Name = "BlueMinSlider"
        Me.BlueMinSlider.Size = New System.Drawing.Size(283, 21)
        Me.BlueMinSlider.TabIndex = 60
        '
        'BlueLabel
        '
        Me.BlueLabel.AutoSize = True
        Me.BlueLabel.ForeColor = System.Drawing.Color.White
        Me.BlueLabel.Location = New System.Drawing.Point(48, 261)
        Me.BlueLabel.Name = "BlueLabel"
        Me.BlueLabel.Size = New System.Drawing.Size(103, 17)
        Me.BlueLabel.TabIndex = 59
        Me.BlueLabel.Text = "Blue: Min / Max"
        '
        'GreenMaxSlider
        '
        Me.GreenMaxSlider.Location = New System.Drawing.Point(52, 229)
        Me.GreenMaxSlider.Maximum = 264
        Me.GreenMaxSlider.Name = "GreenMaxSlider"
        Me.GreenMaxSlider.Size = New System.Drawing.Size(283, 21)
        Me.GreenMaxSlider.TabIndex = 58
        '
        'GreenMinSlider
        '
        Me.GreenMinSlider.Location = New System.Drawing.Point(52, 187)
        Me.GreenMinSlider.Maximum = 264
        Me.GreenMinSlider.Name = "GreenMinSlider"
        Me.GreenMinSlider.Size = New System.Drawing.Size(283, 21)
        Me.GreenMinSlider.TabIndex = 57
        '
        'GreenLabel
        '
        Me.GreenLabel.AutoSize = True
        Me.GreenLabel.ForeColor = System.Drawing.Color.White
        Me.GreenLabel.Location = New System.Drawing.Point(48, 164)
        Me.GreenLabel.Name = "GreenLabel"
        Me.GreenLabel.Size = New System.Drawing.Size(115, 17)
        Me.GreenLabel.TabIndex = 56
        Me.GreenLabel.Text = "Green: Min / Max"
        '
        'RedMaxSlider
        '
        Me.RedMaxSlider.Location = New System.Drawing.Point(52, 128)
        Me.RedMaxSlider.Maximum = 264
        Me.RedMaxSlider.Name = "RedMaxSlider"
        Me.RedMaxSlider.Size = New System.Drawing.Size(283, 21)
        Me.RedMaxSlider.TabIndex = 55
        '
        'RedMinSlider
        '
        Me.RedMinSlider.Location = New System.Drawing.Point(52, 86)
        Me.RedMinSlider.Maximum = 264
        Me.RedMinSlider.Name = "RedMinSlider"
        Me.RedMinSlider.Size = New System.Drawing.Size(283, 21)
        Me.RedMinSlider.TabIndex = 54
        '
        'RedLabel
        '
        Me.RedLabel.AutoSize = True
        Me.RedLabel.ForeColor = System.Drawing.Color.White
        Me.RedLabel.Location = New System.Drawing.Point(48, 63)
        Me.RedLabel.Name = "RedLabel"
        Me.RedLabel.Size = New System.Drawing.Size(101, 17)
        Me.RedLabel.TabIndex = 53
        Me.RedLabel.Text = "Red: Min / Max"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 28)
        Me.MenuStrip1.TabIndex = 69
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem2.Text = " "
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ScrutinyColorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(529, 407)
        Me.Controls.Add(Me.GlobalLabel)
        Me.Controls.Add(Me.GlobalChecked)
        Me.Controls.Add(Me.ToleranceLabel)
        Me.Controls.Add(Me.ToleranceSlider)
        Me.Controls.Add(Me.BlueDisplayLabel)
        Me.Controls.Add(Me.GreenDisplayLabel)
        Me.Controls.Add(Me.RedDisplayLabel)
        Me.Controls.Add(Me.BlueMaxSlider)
        Me.Controls.Add(Me.BlueMinSlider)
        Me.Controls.Add(Me.BlueLabel)
        Me.Controls.Add(Me.GreenMaxSlider)
        Me.Controls.Add(Me.GreenMinSlider)
        Me.Controls.Add(Me.GreenLabel)
        Me.Controls.Add(Me.RedMaxSlider)
        Me.Controls.Add(Me.RedMinSlider)
        Me.Controls.Add(Me.RedLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ScrutinyColorForm"
        Me.Text = "Scrutiny Color Tolerance"
        Me.TopMost = True
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GlobalLabel As Label
    Friend WithEvents GlobalChecked As CheckBox
    Friend WithEvents ToleranceLabel As Label
    Friend WithEvents ToleranceSlider As VScrollBar
    Friend WithEvents BlueDisplayLabel As Label
    Friend WithEvents GreenDisplayLabel As Label
    Friend WithEvents RedDisplayLabel As Label
    Friend WithEvents BlueMaxSlider As HScrollBar
    Friend WithEvents BlueMinSlider As HScrollBar
    Friend WithEvents BlueLabel As Label
    Friend WithEvents GreenMaxSlider As HScrollBar
    Friend WithEvents GreenMinSlider As HScrollBar
    Friend WithEvents GreenLabel As Label
    Friend WithEvents RedMaxSlider As HScrollBar
    Friend WithEvents RedMinSlider As HScrollBar
    Friend WithEvents RedLabel As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
End Class
