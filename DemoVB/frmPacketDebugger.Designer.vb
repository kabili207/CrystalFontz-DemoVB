<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPacketDebugger
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
        Me.btnClose = New System.Windows.Forms.Button
        Me.dgvPackets = New System.Windows.Forms.DataGridView
        Me.grpSettings = New System.Windows.Forms.GroupBox
        Me.chkPacket = New System.Windows.Forms.CheckBox
        Me.chkPacketIDHex = New System.Windows.Forms.CheckBox
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        CType(Me.dgvPackets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSettings.SuspendLayout()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(600, 14)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dgvPackets
        '
        Me.dgvPackets.AllowUserToAddRows = False
        Me.dgvPackets.AllowUserToDeleteRows = False
        Me.dgvPackets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPackets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPackets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPackets.Location = New System.Drawing.Point(0, 0)
        Me.dgvPackets.Name = "dgvPackets"
        Me.dgvPackets.Size = New System.Drawing.Size(703, 175)
        Me.dgvPackets.TabIndex = 3
        '
        'grpSettings
        '
        Me.grpSettings.Controls.Add(Me.btnClose)
        Me.grpSettings.Controls.Add(Me.chkPacket)
        Me.grpSettings.Controls.Add(Me.chkPacketIDHex)
        Me.grpSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpSettings.Location = New System.Drawing.Point(0, 0)
        Me.grpSettings.Name = "grpSettings"
        Me.grpSettings.Size = New System.Drawing.Size(703, 42)
        Me.grpSettings.TabIndex = 2
        Me.grpSettings.TabStop = False
        Me.grpSettings.Text = "Settings"
        '
        'chkPacket
        '
        Me.chkPacket.AutoSize = True
        Me.chkPacket.Checked = True
        Me.chkPacket.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPacket.Location = New System.Drawing.Point(151, 20)
        Me.chkPacket.Name = "chkPacket"
        Me.chkPacket.Size = New System.Drawing.Size(122, 17)
        Me.chkPacket.TabIndex = 1
        Me.chkPacket.Text = "Packet Data as Hex"
        Me.chkPacket.UseVisualStyleBackColor = True
        '
        'chkPacketIDHex
        '
        Me.chkPacketIDHex.AutoSize = True
        Me.chkPacketIDHex.Checked = True
        Me.chkPacketIDHex.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPacketIDHex.Location = New System.Drawing.Point(7, 20)
        Me.chkPacketIDHex.Name = "chkPacketIDHex"
        Me.chkPacketIDHex.Size = New System.Drawing.Size(107, 17)
        Me.chkPacketIDHex.TabIndex = 0
        Me.chkPacketIDHex.Text = "PacketID as Hex"
        Me.chkPacketIDHex.UseVisualStyleBackColor = True
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.grpSettings)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.dgvPackets)
        Me.splitContainer1.Size = New System.Drawing.Size(703, 221)
        Me.splitContainer1.SplitterDistance = 42
        Me.splitContainer1.TabIndex = 5
        '
        'frmPacketDebugger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 221)
        Me.Controls.Add(Me.splitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmPacketDebugger"
        Me.Text = "Packet Viewer"
        CType(Me.dgvPackets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSettings.ResumeLayout(False)
        Me.grpSettings.PerformLayout()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnClose As System.Windows.Forms.Button
    Private WithEvents dgvPackets As System.Windows.Forms.DataGridView
    Private WithEvents grpSettings As System.Windows.Forms.GroupBox
    Private WithEvents chkPacket As System.Windows.Forms.CheckBox
    Private WithEvents chkPacketIDHex As System.Windows.Forms.CheckBox
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
End Class
