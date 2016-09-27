<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash
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
        Me.components = New System.ComponentModel.Container()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label1 = New System.Windows.Forms.Label()
        Me.labelStatus = New System.Windows.Forms.Label()
        Me.labelCounter = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.counter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 0)
        Me.ProgressBar1.MarqueeAnimationSpeed = 700
        Me.ProgressBar1.Maximum = 105
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Timer1
        '
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(0, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(100, 23)
        Me.label1.TabIndex = 2
        '
        'labelStatus
        '
        Me.labelStatus.BackColor = System.Drawing.Color.White
        Me.labelStatus.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.labelStatus.Location = New System.Drawing.Point(0, 0)
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(100, 23)
        Me.labelStatus.TabIndex = 1
        '
        'labelCounter
        '
        Me.labelCounter.Location = New System.Drawing.Point(0, 0)
        Me.labelCounter.Name = "labelCounter"
        Me.labelCounter.Size = New System.Drawing.Size(100, 23)
        Me.labelCounter.TabIndex = 0
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(12, 192)
        Me.ProgressBar2.MarqueeAnimationSpeed = 700
        Me.ProgressBar2.Maximum = 105
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(260, 23)
        Me.ProgressBar2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Loading..."
        '
        'counter
        '
        Me.counter.AutoSize = True
        Me.counter.Location = New System.Drawing.Point(117, 197)
        Me.counter.Name = "counter"
        Me.counter.Size = New System.Drawing.Size(21, 13)
        Me.counter.TabIndex = 6
        Me.counter.Text = "0%"
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Picture_Resize_Tool.My.Resources.Resources.dafdafadf
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.counter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.labelCounter)
        Me.Controls.Add(Me.labelStatus)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents label1 As Label
    Friend WithEvents labelStatus As Label
    Friend WithEvents labelCounter As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents counter As Label
End Class
