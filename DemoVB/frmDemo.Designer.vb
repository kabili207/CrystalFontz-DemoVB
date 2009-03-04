<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDemo
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
        Me.btnStopScroll = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnScrollDemo = New System.Windows.Forms.Button
        Me.btnProgDemo2 = New System.Windows.Forms.Button
        Me.btnProgDemo1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnStopScroll
        '
        Me.btnStopScroll.Enabled = False
        Me.btnStopScroll.Location = New System.Drawing.Point(52, 102)
        Me.btnStopScroll.Name = "btnStopScroll"
        Me.btnStopScroll.Size = New System.Drawing.Size(95, 23)
        Me.btnStopScroll.TabIndex = 9
        Me.btnStopScroll.Text = "Stop Scrolling"
        Me.btnStopScroll.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 142)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(137, 23)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnScrollDemo
        '
        Me.btnScrollDemo.Location = New System.Drawing.Point(13, 72)
        Me.btnScrollDemo.Name = "btnScrollDemo"
        Me.btnScrollDemo.Size = New System.Drawing.Size(138, 23)
        Me.btnScrollDemo.TabIndex = 7
        Me.btnScrollDemo.Text = "Scrolling Text Demo"
        Me.btnScrollDemo.UseVisualStyleBackColor = True
        '
        'btnProgDemo2
        '
        Me.btnProgDemo2.Location = New System.Drawing.Point(13, 42)
        Me.btnProgDemo2.Name = "btnProgDemo2"
        Me.btnProgDemo2.Size = New System.Drawing.Size(138, 23)
        Me.btnProgDemo2.TabIndex = 6
        Me.btnProgDemo2.Text = "Progress Bar Demo 2"
        Me.btnProgDemo2.UseVisualStyleBackColor = True
        '
        'btnProgDemo1
        '
        Me.btnProgDemo1.Location = New System.Drawing.Point(12, 12)
        Me.btnProgDemo1.Name = "btnProgDemo1"
        Me.btnProgDemo1.Size = New System.Drawing.Size(139, 23)
        Me.btnProgDemo1.TabIndex = 5
        Me.btnProgDemo1.Text = "Progress Bar Demo 1"
        Me.btnProgDemo1.UseVisualStyleBackColor = True
        '
        'frmDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(162, 175)
        Me.Controls.Add(Me.btnStopScroll)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnScrollDemo)
        Me.Controls.Add(Me.btnProgDemo2)
        Me.Controls.Add(Me.btnProgDemo1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDemo"
        Me.Text = "Demo Panel"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnStopScroll As System.Windows.Forms.Button
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents btnScrollDemo As System.Windows.Forms.Button
    Private WithEvents btnProgDemo2 As System.Windows.Forms.Button
    Private WithEvents btnProgDemo1 As System.Windows.Forms.Button
End Class
