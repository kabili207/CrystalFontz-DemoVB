Imports Crystalfontz.Displays

Public Class frmMain
    Dim _genericDisplay As CFA63XDisplay
    Dim _devices As ComDevice()

    Dim _strLine1 As String = ""
    Dim _strLine2 As String = ""

    Dim _strLine3 As String = ""
    Dim _strLine4 As String = ""


    Public Sub New(ByVal Device As DeviceID)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Select Case Device
            Case DeviceID.CFA631
                _genericDisplay = New CFA631()
                Me.Text = Me.Text.Replace("X"c, "1"c)
                Exit Select
            Case DeviceID.CFA633
                _genericDisplay = New CFA633()
                Me.Text = Me.Text.Replace("X"c, "3"c)
                Exit Select
            Case DeviceID.CFA635
                _genericDisplay = New CFA635()
                Me.Text = Me.Text.Replace("X"c, "5"c)
                Exit Select
        End Select
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Here we are setting the port we are connected to 
        _devices = SerialPorts.ComPorts
        cmbPorts.DataSource = _devices
        cmbPorts.DisplayMember = "Name"
        cmbPorts.ValueMember = "PortName"
        cmbPorts.SelectedValue = _genericDisplay.PortName

        'Add event handlers 
        AddHandler _genericDisplay.HardwareFirmwareVersion, AddressOf _genericDisplay_HardwareFirmwareVersion
        AddHandler _genericDisplay.ReportingAndStatus, AddressOf _genericDisplay_ReportingAndStatus
        AddHandler _genericDisplay.ReadData, AddressOf _genericDisplay_ReadData

        'Call to get the Hardware and Firmware Version 
        _genericDisplay.GetHardwareFirmwareVersion()

        If _genericDisplay.DeviceModel = DeviceID.CFA635 Then
            txtLine3.Enabled = True
            btnLine3Send.Enabled = True
            txtLine4.Enabled = True
            btnLine4Send.Enabled = True
        Else
            'This will read line 0 and line 1 of CFA631 && CFA633 
            'Feel free to see the constant RamLocations 
            'I do alot of firmware base stuff so hex doesn't scare me and I love it :) 
            _genericDisplay.Read8BytesOfLCDMemory(&H80)
            _genericDisplay.Read8BytesOfLCDMemory(&H88)

            _genericDisplay.Read8BytesOfLCDMemory(&HC0)
            _genericDisplay.Read8BytesOfLCDMemory(&HC8)
        End If

        'Make sure we are connected and do gui logic 
        If _genericDisplay.IsOpen Then
            cmbPorts.Enabled = False
        End If

        'gui logic to display baudrate 
        If _genericDisplay.BaudRate = 19200 Then
            rb19.Checked = True
        Else
            rb115.Checked = True
        End If

        'Request the Contrast and Brightness 
        _genericDisplay.ReadReportingStatus()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ''We want to dispose of the Display Class
        ''If you DO NOT DISPOSE the program will remain running as
        ''The class will always have an active thread.
        _genericDisplay.Dispose()
        Me.Close()
    End Sub

#Region "ThreadSafe Delegates and Functions"
    Delegate Sub threadSafeTextbox(ByVal TXTBox As TextBox, ByVal Text As String)

    Private Sub UpdateTextbox(ByVal TXTBox As TextBox, ByVal Text As String)
        If InvokeRequired Then
            Dim tsCall As New threadSafeTextbox(AddressOf UpdateTextbox)
            Invoke(tsCall, New Object() {TXTBox, Text})
        Else
            TXTBox.Text = Text
        End If
    End Sub


    Delegate Sub threadSafeHSBar(ByVal HSBar As HScrollBar, ByVal Value As Integer)

    Private Sub UpdateHSBar(ByVal HSBar As HScrollBar, ByVal Value As Integer)
        If InvokeRequired Then
            Dim tsCall As New threadSafeHSBar(AddressOf UpdateHSBar)
            Invoke(tsCall, New Object() {HSBar, Value})
        Else
            HSBar.Value = Value
            If HSBar.Name() = hsbBacklight.Name() Then
                lblBacklightPercent.Text = Value.ToString() & "%"
            End If
            If HSBar.Name() = hsbContrast.Name() Then
                lblContrastPercent.Text = Value.ToString()
            End If
        End If
    End Sub

    Delegate Sub threadSafeLabel(ByVal lbl As Label, ByVal Text As String)

    Private Sub UpdateLabel(ByVal lbl As Label, ByVal Text As String)
        If InvokeRequired Then
            Dim tsCall As New threadSafeLabel(AddressOf UpdateLabel)
            Invoke(tsCall, New Object() {lbl, Text})
        Else
            lbl.Text = Text
        End If
    End Sub

    Private Sub _genericDisplay_HardwareFirmwareVersion(ByVal sender As Object, ByVal e As CFAHardwareFirmwareEventArgs)
        Me.UpdateTextbox(txtStatus, e.Information)
    End Sub

#End Region

    Private Sub _genericDisplay_ReportingAndStatus(ByVal sender As Object, ByVal e As CFAReportingAndStatusEventArgs)
        Me.UpdateHSBar(hsbContrast, e.Contrast)
        Me.UpdateHSBar(hsbBacklight, e.Backlight)
    End Sub

    Private Sub _genericDisplay_ReadData(ByVal sender As Object, ByVal e As CFAReadDataEventArgs)
        'Checking for the address Ranges we want 
        If e.AddressCode = &H80 OrElse e.AddressCode = &H88 Then
            For Each _byteChar As Byte In e.Data
                'Printable ascii charaters 
                If _byteChar >= 32 OrElse _byteChar <= 126 Then
                    _strLine1 += Convert.ToChar(_byteChar)
                Else
                    'Non printable charaters get set to the binaray thing 
                    _strLine1 += "\"c + _byteChar.ToString().PadLeft(3, "0"c)
                End If
            Next
            'Update the text box 
            Me.UpdateTextbox(txtLine1, _strLine1)
        End If

        'Checking for the address Ranges we want 
        If e.AddressCode = &HC0 OrElse e.AddressCode = &HC8 Then
            For Each _byteChar As Byte In e.Data
                'Printable ascii charaters 
                If _byteChar >= 32 OrElse _byteChar <= 126 Then
                    _strLine2 += Convert.ToChar(_byteChar)
                Else
                    'Non printable charaters get set to the binaray thing 
                    _strLine2 += "\"c + _byteChar.ToString().PadLeft(3, "0"c)
                End If
            Next
            'Update the text box 
            Me.UpdateTextbox(txtLine2, _strLine2)
        End If
    End Sub

    Private Sub hsbBacklight_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles hsbBacklight.Scroll
        If e.NewValue <> e.OldValue Then
            _genericDisplay.SetBacklight(e.NewValue)
            lblBacklightPercent.Text = e.NewValue.ToString() & "%"
        End If
    End Sub

    Private Sub btnLine1Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLine1Send.Click
        _genericDisplay.WriteLine(0, txtLine1.Text, 0, True)
    End Sub

    Private Sub btnLine2Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLine2Send.Click
        _genericDisplay.WriteLine(1, txtLine2.Text, 0, True)
    End Sub

    Private Sub btnLine3Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLine3Send.Click
        _genericDisplay.WriteLine(2, txtLine3.Text, 0, True)
    End Sub

    Private Sub btnLine4Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLine4Send.Click
        _genericDisplay.WriteLine(3, txtLine4.Text, 0, True)
    End Sub
End Class
