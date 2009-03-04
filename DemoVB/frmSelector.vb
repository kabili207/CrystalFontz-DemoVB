Imports Crystalfontz.Displays
Imports System.Threading

Public Class frmSelector
    Dim _demoForm As frmMain

    Private Sub btnOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOpen.Click
        Select Case cmbSelect.Text
            Case "CFA631"
                _demoForm = New frmMain(DeviceID.CFA631)
                _demoForm.Show()
                Exit Select
            Case "CFA633"
                _demoForm = New frmMain(DeviceID.CFA633)
                _demoForm.Show()
                Exit Select
            Case "CFA635"
                _demoForm = New frmMain(DeviceID.CFA635)
                _demoForm.Show()
                Exit Select
        End Select
        Me.Hide()
        Dim _disposeChecker As New Thread(AddressOf Me.formClosedCheck)
        _disposeChecker.Start()
    End Sub

    ''' <summary> 
    ''' This is a slick way to spawn a form and still close the previous form when the one spawned closes with out doing something drastic 
    ''' Drastic as in find procress and close. 
    ''' </summary> 
    Private Sub formClosedCheck()
        While _demoForm.IsDisposed = False

            'I find 250ms is a good number to not ping the cpu 
            Thread.Sleep(250)
        End While

        'Once the demoForm is disposed of we dispose of our selfs 
        'Note we need to check to see what thread we are on! 
        Me.closeForm()
    End Sub

    Delegate Sub TSCall()

    Private Sub closeForm()
        If InvokeRequired Then
            Dim tsCall As New TSCall(AddressOf closeForm)
            Invoke(tsCall)
        Else
            Me.Close()
        End If
    End Sub
End Class