Public Class frm_Carica
    Public NumeroIn As Integer

    Private Sub btn_Caricamento_Click(sender As Object, e As EventArgs) Handles btn_Caricamento.Click
        NumeroIn = nmr_Num.Value
        Me.Close()
    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Environment.Exit(0)
    End Sub

    Private Sub btn_Minimize_Click(sender As Object, e As EventArgs) Handles btn_Minimize.Click
        frm_Carica.ActiveForm.WindowState = FormWindowState.Minimized
    End Sub
End Class