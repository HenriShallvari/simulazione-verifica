<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Main))
        Me.pnl_Sotto = New System.Windows.Forms.Panel()
        Me.lst_Pari = New System.Windows.Forms.ListBox()
        Me.lbl_Totale = New System.Windows.Forms.Label()
        Me.lbl_MaxDiscoteche = New System.Windows.Forms.Label()
        Me.btn_Pari = New System.Windows.Forms.Button()
        Me.btn_Totale = New System.Windows.Forms.Button()
        Me.btn_MassimoDiscoteche = New System.Windows.Forms.Button()
        Me.btn_Massimo = New System.Windows.Forms.Button()
        Me.pnl_Sinistra = New System.Windows.Forms.Panel()
        Me.dgv_Discoteche = New System.Windows.Forms.DataGridView()
        Me.pnl_Destra = New System.Windows.Forms.Panel()
        Me.dgv_Accessi = New System.Windows.Forms.DataGridView()
        Me.pnl_Main = New System.Windows.Forms.Panel()
        Me.dgv_Calendario = New System.Windows.Forms.DataGridView()
        Me.lbl_Titolo = New System.Windows.Forms.Label()
        Me.pnl_Sotto.SuspendLayout()
        Me.pnl_Sinistra.SuspendLayout()
        CType(Me.dgv_Discoteche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Destra.SuspendLayout()
        CType(Me.dgv_Accessi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Main.SuspendLayout()
        CType(Me.dgv_Calendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl_Sotto
        '
        Me.pnl_Sotto.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnl_Sotto.Controls.Add(Me.lbl_Titolo)
        Me.pnl_Sotto.Controls.Add(Me.lst_Pari)
        Me.pnl_Sotto.Controls.Add(Me.lbl_Totale)
        Me.pnl_Sotto.Controls.Add(Me.lbl_MaxDiscoteche)
        Me.pnl_Sotto.Controls.Add(Me.btn_Pari)
        Me.pnl_Sotto.Controls.Add(Me.btn_Totale)
        Me.pnl_Sotto.Controls.Add(Me.btn_MassimoDiscoteche)
        Me.pnl_Sotto.Controls.Add(Me.btn_Massimo)
        Me.pnl_Sotto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Sotto.Location = New System.Drawing.Point(0, 492)
        Me.pnl_Sotto.Name = "pnl_Sotto"
        Me.pnl_Sotto.Size = New System.Drawing.Size(993, 167)
        Me.pnl_Sotto.TabIndex = 1
        '
        'lst_Pari
        '
        Me.lst_Pari.FormattingEnabled = True
        Me.lst_Pari.ItemHeight = 21
        Me.lst_Pari.Location = New System.Drawing.Point(420, 6)
        Me.lst_Pari.Name = "lst_Pari"
        Me.lst_Pari.Size = New System.Drawing.Size(171, 151)
        Me.lst_Pari.TabIndex = 2
        '
        'lbl_Totale
        '
        Me.lbl_Totale.AutoSize = True
        Me.lbl_Totale.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_Totale.Location = New System.Drawing.Point(192, 88)
        Me.lbl_Totale.Name = "lbl_Totale"
        Me.lbl_Totale.Size = New System.Drawing.Size(61, 21)
        Me.lbl_Totale.TabIndex = 1
        Me.lbl_Totale.Text = "Label1"
        '
        'lbl_MaxDiscoteche
        '
        Me.lbl_MaxDiscoteche.AutoSize = True
        Me.lbl_MaxDiscoteche.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_MaxDiscoteche.Location = New System.Drawing.Point(192, 50)
        Me.lbl_MaxDiscoteche.Name = "lbl_MaxDiscoteche"
        Me.lbl_MaxDiscoteche.Size = New System.Drawing.Size(61, 21)
        Me.lbl_MaxDiscoteche.TabIndex = 1
        Me.lbl_MaxDiscoteche.Text = "Label1"
        '
        'btn_Pari
        '
        Me.btn_Pari.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.btn_Pari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Pari.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Pari.Location = New System.Drawing.Point(284, 6)
        Me.btn_Pari.Name = "btn_Pari"
        Me.btn_Pari.Size = New System.Drawing.Size(130, 32)
        Me.btn_Pari.TabIndex = 0
        Me.btn_Pari.Text = "Pari"
        Me.btn_Pari.UseVisualStyleBackColor = False
        '
        'btn_Totale
        '
        Me.btn_Totale.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btn_Totale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Totale.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Totale.Location = New System.Drawing.Point(3, 82)
        Me.btn_Totale.Name = "btn_Totale"
        Me.btn_Totale.Size = New System.Drawing.Size(183, 32)
        Me.btn_Totale.TabIndex = 0
        Me.btn_Totale.Text = "Totale"
        Me.btn_Totale.UseVisualStyleBackColor = False
        '
        'btn_MassimoDiscoteche
        '
        Me.btn_MassimoDiscoteche.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btn_MassimoDiscoteche.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_MassimoDiscoteche.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_MassimoDiscoteche.Location = New System.Drawing.Point(3, 44)
        Me.btn_MassimoDiscoteche.Name = "btn_MassimoDiscoteche"
        Me.btn_MassimoDiscoteche.Size = New System.Drawing.Size(183, 32)
        Me.btn_MassimoDiscoteche.TabIndex = 0
        Me.btn_MassimoDiscoteche.Text = "Massimo Discoteche"
        Me.btn_MassimoDiscoteche.UseVisualStyleBackColor = False
        '
        'btn_Massimo
        '
        Me.btn_Massimo.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btn_Massimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_Massimo.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_Massimo.Location = New System.Drawing.Point(3, 6)
        Me.btn_Massimo.Name = "btn_Massimo"
        Me.btn_Massimo.Size = New System.Drawing.Size(183, 32)
        Me.btn_Massimo.TabIndex = 0
        Me.btn_Massimo.Text = "Massimo"
        Me.btn_Massimo.UseVisualStyleBackColor = False
        '
        'pnl_Sinistra
        '
        Me.pnl_Sinistra.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnl_Sinistra.Controls.Add(Me.dgv_Discoteche)
        Me.pnl_Sinistra.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_Sinistra.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Sinistra.Name = "pnl_Sinistra"
        Me.pnl_Sinistra.Size = New System.Drawing.Size(163, 492)
        Me.pnl_Sinistra.TabIndex = 2
        '
        'dgv_Discoteche
        '
        Me.dgv_Discoteche.AllowUserToAddRows = False
        Me.dgv_Discoteche.AllowUserToDeleteRows = False
        Me.dgv_Discoteche.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Discoteche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Discoteche.Location = New System.Drawing.Point(12, 39)
        Me.dgv_Discoteche.Name = "dgv_Discoteche"
        Me.dgv_Discoteche.Size = New System.Drawing.Size(143, 388)
        Me.dgv_Discoteche.TabIndex = 0
        '
        'pnl_Destra
        '
        Me.pnl_Destra.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnl_Destra.Controls.Add(Me.dgv_Accessi)
        Me.pnl_Destra.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_Destra.Location = New System.Drawing.Point(830, 0)
        Me.pnl_Destra.Name = "pnl_Destra"
        Me.pnl_Destra.Size = New System.Drawing.Size(163, 492)
        Me.pnl_Destra.TabIndex = 3
        '
        'dgv_Accessi
        '
        Me.dgv_Accessi.AllowUserToAddRows = False
        Me.dgv_Accessi.AllowUserToDeleteRows = False
        Me.dgv_Accessi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Accessi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Accessi.Location = New System.Drawing.Point(6, 39)
        Me.dgv_Accessi.Name = "dgv_Accessi"
        Me.dgv_Accessi.ReadOnly = True
        Me.dgv_Accessi.Size = New System.Drawing.Size(143, 388)
        Me.dgv_Accessi.TabIndex = 0
        '
        'pnl_Main
        '
        Me.pnl_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.pnl_Main.Controls.Add(Me.dgv_Calendario)
        Me.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Main.Location = New System.Drawing.Point(163, 0)
        Me.pnl_Main.Name = "pnl_Main"
        Me.pnl_Main.Size = New System.Drawing.Size(667, 492)
        Me.pnl_Main.TabIndex = 4
        '
        'dgv_Calendario
        '
        Me.dgv_Calendario.AllowUserToAddRows = False
        Me.dgv_Calendario.AllowUserToDeleteRows = False
        Me.dgv_Calendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Calendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Calendario.Location = New System.Drawing.Point(6, 12)
        Me.dgv_Calendario.Name = "dgv_Calendario"
        Me.dgv_Calendario.ReadOnly = True
        Me.dgv_Calendario.Size = New System.Drawing.Size(655, 474)
        Me.dgv_Calendario.TabIndex = 0
        '
        'lbl_Titolo
        '
        Me.lbl_Titolo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Titolo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titolo.ForeColor = System.Drawing.SystemColors.Control
        Me.lbl_Titolo.Image = Global._019_SimulazioneVerifica.My.Resources.Resources.disco_ball
        Me.lbl_Titolo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_Titolo.Location = New System.Drawing.Point(769, 118)
        Me.lbl_Titolo.Name = "lbl_Titolo"
        Me.lbl_Titolo.Size = New System.Drawing.Size(210, 39)
        Me.lbl_Titolo.TabIndex = 3
        Me.lbl_Titolo.Text = "GESTIONE DISCOTECHE"
        Me.lbl_Titolo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(993, 659)
        Me.Controls.Add(Me.pnl_Main)
        Me.Controls.Add(Me.pnl_Destra)
        Me.Controls.Add(Me.pnl_Sinistra)
        Me.Controls.Add(Me.pnl_Sotto)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(852, 395)
        Me.Name = "frm_Main"
        Me.Text = "Simulazione Verifica Fila A"
        Me.pnl_Sotto.ResumeLayout(False)
        Me.pnl_Sotto.PerformLayout()
        Me.pnl_Sinistra.ResumeLayout(False)
        CType(Me.dgv_Discoteche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Destra.ResumeLayout(False)
        CType(Me.dgv_Accessi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Main.ResumeLayout(False)
        CType(Me.dgv_Calendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_Sotto As Panel
    Friend WithEvents pnl_Sinistra As Panel
    Friend WithEvents pnl_Destra As Panel
    Friend WithEvents pnl_Main As Panel
    Friend WithEvents dgv_Discoteche As DataGridView
    Friend WithEvents dgv_Accessi As DataGridView
    Friend WithEvents dgv_Calendario As DataGridView
    Friend WithEvents btn_Totale As Button
    Friend WithEvents btn_MassimoDiscoteche As Button
    Friend WithEvents btn_Massimo As Button
    Friend WithEvents lst_Pari As ListBox
    Friend WithEvents lbl_Totale As Label
    Friend WithEvents lbl_MaxDiscoteche As Label
    Friend WithEvents btn_Pari As Button
    Friend WithEvents lbl_Titolo As Label
End Class
