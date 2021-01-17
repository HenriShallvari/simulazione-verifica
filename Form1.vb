Public Class frm_Main
    Dim n_Discoteche As String
    Dim excp As Boolean
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Do
            '//Questo l'ho imparato da un corso di C# :P
            'Try
            '    n_Discoteche = InputBox("Quante discoteche ci sono?")
            '    excp = False

            'Catch ex As System.InvalidCastException
            '    MsgBox("Devi inserire un numero intero!",
            '                   MessageBoxIcon.Warning)
            '    excp = True
            'End Try
        Loop Until excp = False


        dgv_Calendario.ColumnCount = 7
        dgv_Calendario.RowHeadersVisible = False
        dgv_Calendario.Columns(0).HeaderText = "Lunedì"
        dgv_Calendario.Columns(1).HeaderText = "Martedì"
        dgv_Calendario.Columns(2).HeaderText = "Mercoledì"
        dgv_Calendario.Columns(3).HeaderText = "Giovedì"
        dgv_Calendario.Columns(4).HeaderText = "Venerdì"
        dgv_Calendario.Columns(5).HeaderText = "Sabato"
        dgv_Calendario.Columns(6).HeaderText = "Domenica"

        dgv_Calendario.RowCount = n_Discoteche
        dgv_Accessi.RowCount = n_Discoteche
        dgv_Discoteche.RowCount = n_Discoteche

        dgv_Accessi.RowHeadersVisible = False
        dgv_Discoteche.RowHeadersVisible = False




        For i = 0 To dgv_Calendario.ColumnCount - 1
            dgv_Calendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_Accessi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_Discoteche.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Next
    End Sub
End Class
