Public Class frm_Main
    Dim n_Discoteche As Short
    Dim CaricamentoCompletato As Boolean = False

    Dim LarghezzaForm = 1009
    Dim AltezzaForm = 698

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lbl_MaxDiscoteche.Visible = False
        lbl_Totale.Visible = False

        frm_Carica.Activate()
        frm_Carica.BringToFront()
        frm_Carica.ShowDialog()

        n_Discoteche = frm_Carica.NumeroIn


        dgv_Calendario.ColumnCount = 7
        dgv_Accessi.ColumnCount = 1
        dgv_Discoteche.ColumnCount = 1
        dgv_Calendario.RowHeadersVisible = False

        dgv_Calendario.Columns(0).HeaderText = "Lunedì"
        dgv_Calendario.Columns(1).HeaderText = "Martedì"
        dgv_Calendario.Columns(2).HeaderText = "Mercoledì"
        dgv_Calendario.Columns(3).HeaderText = "Giovedì"
        dgv_Calendario.Columns(4).HeaderText = "Venerdì"
        dgv_Calendario.Columns(5).HeaderText = "Sabato"
        dgv_Calendario.Columns(6).HeaderText = "Domenica"
        dgv_Discoteche.Columns(0).HeaderText = "Nome Discoteca"
        dgv_Accessi.Columns(0).HeaderText = "Accessi massimi per settimana"



        dgv_Calendario.RowCount = n_Discoteche
        dgv_Accessi.RowCount = n_Discoteche
        dgv_Discoteche.RowCount = n_Discoteche

        dgv_Accessi.RowHeadersVisible = False
        dgv_Discoteche.RowHeadersVisible = False

        dgv_Accessi.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Discoteche.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Calendario.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgv_Accessi.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Calendario.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv_Discoteche.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim temp = dgv_Calendario.Size.Height / n_Discoteche

        For i = 0 To dgv_Calendario.ColumnCount - 1
            dgv_Calendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_Accessi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgv_Discoteche.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Next



        Call Resizing_Griglie()

        CaricamentoCompletato = True
    End Sub

    Private Sub frm_Main_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If CaricamentoCompletato Then
            Dim larghezza_Cambiata = frm_Main.ActiveForm.Width
            Dim altezza_Cambiata = frm_Main.ActiveForm.Height

            Call Resizing_Griglie()

            Dim Scala As Integer = larghezza_Cambiata / LarghezzaForm
            Dim ScalaH As Integer = altezza_Cambiata / AltezzaForm

            If Scala > 0 Then
                frm_Main.ActiveForm.Font = New Font("Century Gothic", 12 * Scala, FontStyle.Regular)
            End If

        End If
    End Sub

    Sub Resizing_Griglie()
        Dim temp = dgv_Calendario.Size.Height / n_Discoteche
        Dim temp2 = dgv_Calendario.Size.Width / n_Discoteche

        For i = 0 To dgv_Calendario.Rows.Count - 1
            dgv_Calendario.Rows(i).Height = temp
            dgv_Calendario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Next

        Dim temp3 = dgv_Accessi.Size.Height / n_Discoteche
        Dim temp4 = dgv_Accessi.Size.Width / n_Discoteche

        For i = 0 To dgv_Accessi.Rows.Count - 1
            dgv_Accessi.Rows(i).Height = temp3
            dgv_Accessi.Columns(0).Width = temp4
        Next

        Dim temp5 = dgv_Discoteche.Size.Height / n_Discoteche
        Dim temp6 = dgv_Discoteche.Size.Width / n_Discoteche

        For i = 0 To dgv_Discoteche.Rows.Count - 1
            dgv_Discoteche.Rows(i).Height = temp5
            dgv_Discoteche.Columns(0).Width = temp6
        Next


    End Sub

    Private Sub btn_Massimo_Click(sender As Object, e As EventArgs) Handles btn_Massimo.Click
        Dim max As Integer = Integer.MinValue
        Dim max_Disco As String = ""
        Dim k_err As Short = 0

        For i = 0 To dgv_Discoteche.Rows.Count - 1
            If dgv_Discoteche.Rows(i).Cells(0).Value = Nothing Then
                k_err += 1
            End If
        Next

        If k_err = n_Discoteche Then
            MsgBox("Non hai caricato alcuna discoteca!")
            Exit Sub
        End If

        For i = 0 To dgv_Calendario.Rows.Count - 1
            For j = 0 To dgv_Calendario.Columns.Count - 1
                If dgv_Calendario.Rows(i).Cells(j).Value > max Then
                    max = dgv_Calendario.Rows(i).Cells(j).Value
                    max_Disco = dgv_Discoteche.Rows(i).Cells(0).Value
                End If
            Next
        Next

        MsgBox("La discoteca con più accessi è stata " & max_Disco & " con " & max & " accessi totali.")

    End Sub

    Sub Generazione_Numeri(ByVal RowInd As Integer)
        Dim rnd As New Random

        For j = 0 To dgv_Calendario.ColumnCount - 1
            dgv_Calendario.Rows(RowInd).Cells(j).Value = rnd.Next(1, 501)
        Next

    End Sub

    Private Sub dgv_Discoteche_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Discoteche.CellValueChanged
        If CaricamentoCompletato Then
            Call Generazione_Numeri(dgv_Discoteche.CurrentRow.Index)


            Dim max As Integer = Integer.MinValue

            For i = 0 To dgv_Calendario.Columns.Count - 1
                If dgv_Calendario.Rows(dgv_Discoteche.CurrentRow.Index).Cells(i).Value > max Then
                    max = dgv_Calendario.Rows(dgv_Discoteche.CurrentRow.Index).Cells(i).Value
                End If
            Next

            dgv_Accessi.Rows(dgv_Discoteche.CurrentRow.Index).Cells(0).Value = max
        End If
    End Sub

    Private Sub btn_MassimoDiscoteche_Click(sender As Object, e As EventArgs) Handles btn_MassimoDiscoteche.Click
        Dim k_err As Short = 0

        For i = 0 To dgv_Discoteche.Rows.Count - 1
            If dgv_Discoteche.Rows(i).Cells(0).Value = Nothing Then
                k_err += 1
            End If
        Next

        If k_err = n_Discoteche Then
            MsgBox("Non hai caricato alcuna discoteca!")
            Exit Sub
        End If

        Dim max As Integer = Integer.MinValue
        Dim max_Disco As String = ""

        For i = 0 To dgv_Calendario.Rows.Count - 1
            For j = 0 To dgv_Calendario.Columns.Count - 1

                If dgv_Calendario.Rows(i).Cells(j).Value > max Then
                    max = dgv_Calendario.Rows(i).Cells(j).Value
                    max_Disco = dgv_Discoteche.Rows(i).Cells(0).Value
                End If
            Next
        Next

        For i = 0 To dgv_Calendario.Rows.Count - 1
            For j = 0 To dgv_Calendario.Columns.Count - 1
                If dgv_Calendario.Rows(i).Cells(j).Value = max Then
                    dgv_Calendario.Rows(i).Cells(j).Style.BackColor = Color.Green
                    Exit For
                End If
            Next
        Next

        lbl_MaxDiscoteche.Text = max_Disco
        lbl_MaxDiscoteche.Visible = True
    End Sub

    Private Sub btn_Totale_Click(sender As Object, e As EventArgs) Handles btn_Totale.Click
        Dim k_err As Short = 0

        For i = 0 To dgv_Discoteche.Rows.Count - 1
            If dgv_Discoteche.Rows(i).Cells(0).Value = Nothing Then
                k_err += 1
            End If
        Next

        If k_err = n_Discoteche Then
            MsgBox("Non hai caricato alcuna discoteca!")
            Exit Sub
        End If

        Dim totale As Integer = 0
        For i = 0 To dgv_Calendario.Rows.Count - 1
            For j = 0 To dgv_Calendario.Columns.Count - 1
                totale += dgv_Calendario.Rows(i).Cells(j).Value
            Next
        Next

        lbl_Totale.Text = totale
        lbl_Totale.Visible = True
    End Sub

    Private Sub btn_Pari_Click(sender As Object, e As EventArgs) Handles btn_Pari.Click
        Dim k_err As Short = 0

        For i = 0 To dgv_Discoteche.Rows.Count - 1
            If dgv_Discoteche.Rows(i).Cells(0).Value = Nothing Then
                k_err += 1
            End If
        Next

        If k_err = n_Discoteche Then
            MsgBox("Non hai caricato alcuna discoteca!")
            Exit Sub
        End If

        For i = 0 To dgv_Calendario.Rows.Count - 1
            For j = 0 To dgv_Calendario.Columns.Count - 1
                If dgv_Calendario.Rows(i).Cells(j).Value Mod 2 = 0 Then
                    lst_Pari.Items.Add(dgv_Calendario.Rows(i).Cells(j).Value)
                End If
            Next
        Next
    End Sub
End Class

