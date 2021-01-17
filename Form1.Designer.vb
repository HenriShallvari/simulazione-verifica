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
        Me.pnl_Sotto = New System.Windows.Forms.Panel()
        Me.pnl_Sinistra = New System.Windows.Forms.Panel()
        Me.dgv_Discoteche = New System.Windows.Forms.DataGridView()
        Me.pnl_Destra = New System.Windows.Forms.Panel()
        Me.dgv_Accessi = New System.Windows.Forms.DataGridView()
        Me.pnl_Main = New System.Windows.Forms.Panel()
        Me.dgv_Calendario = New System.Windows.Forms.DataGridView()
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
        Me.pnl_Sotto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_Sotto.Location = New System.Drawing.Point(0, 506)
        Me.pnl_Sotto.Name = "pnl_Sotto"
        Me.pnl_Sotto.Size = New System.Drawing.Size(993, 135)
        Me.pnl_Sotto.TabIndex = 1
        '
        'pnl_Sinistra
        '
        Me.pnl_Sinistra.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnl_Sinistra.Controls.Add(Me.dgv_Discoteche)
        Me.pnl_Sinistra.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnl_Sinistra.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Sinistra.Name = "pnl_Sinistra"
        Me.pnl_Sinistra.Size = New System.Drawing.Size(163, 506)
        Me.pnl_Sinistra.TabIndex = 2
        '
        'dgv_Discoteche
        '
        Me.dgv_Discoteche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Discoteche.Location = New System.Drawing.Point(12, 39)
        Me.dgv_Discoteche.Name = "dgv_Discoteche"
        Me.dgv_Discoteche.Size = New System.Drawing.Size(143, 402)
        Me.dgv_Discoteche.TabIndex = 0
        '
        'pnl_Destra
        '
        Me.pnl_Destra.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.pnl_Destra.Controls.Add(Me.dgv_Accessi)
        Me.pnl_Destra.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnl_Destra.Location = New System.Drawing.Point(830, 0)
        Me.pnl_Destra.Name = "pnl_Destra"
        Me.pnl_Destra.Size = New System.Drawing.Size(163, 506)
        Me.pnl_Destra.TabIndex = 3
        '
        'dgv_Accessi
        '
        Me.dgv_Accessi.AllowUserToAddRows = False
        Me.dgv_Accessi.AllowUserToDeleteRows = False
        Me.dgv_Accessi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Accessi.Location = New System.Drawing.Point(6, 39)
        Me.dgv_Accessi.Name = "dgv_Accessi"
        Me.dgv_Accessi.ReadOnly = True
        Me.dgv_Accessi.Size = New System.Drawing.Size(143, 402)
        Me.dgv_Accessi.TabIndex = 0
        '
        'pnl_Main
        '
        Me.pnl_Main.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.pnl_Main.Controls.Add(Me.dgv_Calendario)
        Me.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_Main.Location = New System.Drawing.Point(163, 0)
        Me.pnl_Main.Name = "pnl_Main"
        Me.pnl_Main.Size = New System.Drawing.Size(667, 506)
        Me.pnl_Main.TabIndex = 4
        '
        'dgv_Calendario
        '
        Me.dgv_Calendario.AllowUserToAddRows = False
        Me.dgv_Calendario.AllowUserToDeleteRows = False
        Me.dgv_Calendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Calendario.Location = New System.Drawing.Point(6, 12)
        Me.dgv_Calendario.Name = "dgv_Calendario"
        Me.dgv_Calendario.ReadOnly = True
        Me.dgv_Calendario.Size = New System.Drawing.Size(655, 488)
        Me.dgv_Calendario.TabIndex = 0
        '
        'frm_Main
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(993, 641)
        Me.Controls.Add(Me.pnl_Main)
        Me.Controls.Add(Me.pnl_Destra)
        Me.Controls.Add(Me.pnl_Sinistra)
        Me.Controls.Add(Me.pnl_Sotto)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frm_Main"
        Me.Text = "Simulazione Verifica Fila A"
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
End Class
