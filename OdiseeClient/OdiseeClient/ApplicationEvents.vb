Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.Devices

Namespace My

    ' Für MyApplication sind folgende Ereignisse verfügbar:
    ' 
    ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
    ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
    ' UnhandledException: Wird ausgelöst, wenn in der Anwendung eine unbehandelte Ausnahme auftritt.
    ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist. 
    ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
    Partial Friend Class MyApplication

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub MyApplication_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If e.IsNetworkAvailable() Then
                MsgBox("Network unavailable -- disabling buttons")
                My.Forms.OdiseeTester.makeOdiseeRequestButton.Enabled = True
                My.Forms.OdiseeTester.sendOdiseeRequestButton.Enabled = True
                My.Forms.OdiseeTester.chooseFolderButton.Enabled = True
            Else
                MsgBox("Network available -- enabling buttons")
                My.Forms.OdiseeTester.makeOdiseeRequestButton.Enabled = False
                My.Forms.OdiseeTester.sendOdiseeRequestButton.Enabled = False
                My.Forms.OdiseeTester.chooseFolderButton.Enabled = False
            End If
        End Sub

    End Class

End Namespace
