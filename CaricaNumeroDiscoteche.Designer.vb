<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Carica
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Carica))
        Me.lbl_Titolo = New System.Windows.Forms.Label()
        Me.lbl_Testo = New System.Windows.Forms.Label()
        Me.nmr_Num = New System.Windows.Forms.NumericUpDown()
        Me.btn_Caricamento = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.btn_Minimize = New System.Windows.Forms.Button()
        CType(Me.nmr_Num, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Titolo
        '
        Me.lbl_Titolo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titolo.Image = Global._019_SimulazioneVerifica.My.Resources.Resources.disco_ball
        Me.lbl_Titolo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_Titolo.Location = New System.Drawing.Point(34, 9)
        Me.lbl_Titolo.Name = "lbl_Titolo"
        Me.lbl_Titolo.Size = New System.Drawing.Size(210, 36)
        Me.lbl_Titolo.TabIndex = 0
        Me.lbl_Titolo.Text = "GESTIONE DISCOTECHE"
        Me.lbl_Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Testo
        '
        Me.lbl_Testo.Location = New System.Drawing.Point(45, 55)
        Me.lbl_Testo.Name = "lbl_Testo"
        Me.lbl_Testo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl_Testo.Size = New System.Drawing.Size(199, 45)
        Me.lbl_Testo.TabIndex = 1
        Me.lbl_Testo.Text = "Benvenuto, inserisci il numero di discoteche"
        Me.lbl_Testo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nmr_Num
        '
        Me.nmr_Num.Location = New System.Drawing.Point(49, 118)
        Me.nmr_Num.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmr_Num.Name = "nmr_Num"
        Me.nmr_Num.Size = New System.Drawing.Size(195, 27)
        Me.nmr_Num.TabIndex = 2
        Me.nmr_Num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nmr_Num.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_Caricamento
        '
        Me.btn_Caricamento.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btn_Caricamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Caricamento.Location = New System.Drawing.Point(49, 157)
        Me.btn_Caricamento.Name = "btn_Caricamento"
        Me.btn_Caricamento.Size = New System.Drawing.Size(195, 50)
        Me.btn_Caricamento.TabIndex = 3
        Me.btn_Caricamento.Text = "Carica"
        Me.btn_Caricamento.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.FlatAppearance.BorderSize = 0
        Me.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Exit.Location = New System.Drawing.Point(271, 0)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(28, 26)
        Me.btn_Exit.TabIndex = 4
        Me.btn_Exit.Text = "x"
        Me.btn_Exit.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'btn_Minimize
        '
        Me.btn_Minimize.FlatAppearance.BorderSize = 0
        Me.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Minimize.Location = New System.Drawing.Point(241, 0)
        Me.btn_Minimize.Name = "btn_Minimize"
        Me.btn_Minimize.Size = New System.Drawing.Size(28, 26)
        Me.btn_Minimize.TabIndex = 4
        Me.btn_Minimize.Text = "-"
        Me.btn_Minimize.UseVisualStyleBackColor = True
        '
        'frm_Carica
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 250)
        Me.Controls.Add(Me.btn_Minimize)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Caricamento)
        Me.Controls.Add(Me.nmr_Num)
        Me.Controls.Add(Me.lbl_Testo)
        Me.Controls.Add(Me.lbl_Titolo)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Carica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CaricaNumeroDiscoteche"
        CType(Me.nmr_Num, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_Titolo As Label
    Friend WithEvents lbl_Testo As Label
    Friend WithEvents nmr_Num As NumericUpDown
    Friend WithEvents btn_Caricamento As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents btn_Minimize As Button
End Class
