<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdicionarContas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionarContas))
        Me.gbContas = New System.Windows.Forms.GroupBox()
        Me.dgvContas = New System.Windows.Forms.DataGridView()
        Me.IdDaConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDaConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorDaConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VencimentoDaConta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MultaAtraso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JurosMes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JurosDia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pago = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataCadastro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalContas = New System.Windows.Forms.TextBox()
        Me.lblTotalContas = New System.Windows.Forms.Label()
        Me.gbBotoesContas = New System.Windows.Forms.GroupBox()
        Me.rbtnTodasContas = New System.Windows.Forms.RadioButton()
        Me.rbtnContasVencidas = New System.Windows.Forms.RadioButton()
        Me.rbtnContasNaoPagas = New System.Windows.Forms.RadioButton()
        Me.rbtnPago = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AbrirContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagarContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtualizarNúmeroDeContasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbContas.SuspendLayout()
        CType(Me.dgvContas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBotoesContas.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbContas
        '
        Me.gbContas.Controls.Add(Me.dgvContas)
        Me.gbContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbContas.Location = New System.Drawing.Point(12, 122)
        Me.gbContas.Name = "gbContas"
        Me.gbContas.Size = New System.Drawing.Size(877, 280)
        Me.gbContas.TabIndex = 1
        Me.gbContas.TabStop = False
        Me.gbContas.Text = "Adicione as informações das contas :"
        '
        'dgvContas
        '
        Me.dgvContas.AllowUserToDeleteRows = False
        Me.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDaConta, Me.TipoDaConta, Me.Empresa, Me.ValorDaConta, Me.VencimentoDaConta, Me.MultaAtraso, Me.JurosMes, Me.JurosDia, Me.Pago, Me.DataCadastro})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvContas.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvContas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvContas.Location = New System.Drawing.Point(3, 16)
        Me.dgvContas.Name = "dgvContas"
        Me.dgvContas.ReadOnly = True
        Me.dgvContas.Size = New System.Drawing.Size(871, 261)
        Me.dgvContas.TabIndex = 1
        '
        'IdDaConta
        '
        Me.IdDaConta.DataPropertyName = "IdDaConta"
        Me.IdDaConta.HeaderText = "ID"
        Me.IdDaConta.Name = "IdDaConta"
        Me.IdDaConta.ReadOnly = True
        Me.IdDaConta.Visible = False
        '
        'TipoDaConta
        '
        Me.TipoDaConta.DataPropertyName = "TipoDaConta"
        Me.TipoDaConta.HeaderText = "Tipo da Conta"
        Me.TipoDaConta.Name = "TipoDaConta"
        Me.TipoDaConta.ReadOnly = True
        '
        'Empresa
        '
        Me.Empresa.DataPropertyName = "Empresa"
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        '
        'ValorDaConta
        '
        Me.ValorDaConta.DataPropertyName = "ValorDaConta"
        Me.ValorDaConta.HeaderText = "Valor da Conta"
        Me.ValorDaConta.Name = "ValorDaConta"
        Me.ValorDaConta.ReadOnly = True
        '
        'VencimentoDaConta
        '
        Me.VencimentoDaConta.DataPropertyName = "VencimentoDaConta"
        Me.VencimentoDaConta.HeaderText = "Vencimento da Conta"
        Me.VencimentoDaConta.Name = "VencimentoDaConta"
        Me.VencimentoDaConta.ReadOnly = True
        '
        'MultaAtraso
        '
        Me.MultaAtraso.DataPropertyName = "MultaAtraso"
        Me.MultaAtraso.HeaderText = "Multa de Atraso da Conta"
        Me.MultaAtraso.Name = "MultaAtraso"
        Me.MultaAtraso.ReadOnly = True
        '
        'JurosMes
        '
        Me.JurosMes.DataPropertyName = "JurosMes"
        Me.JurosMes.HeaderText = "Juros da Conta por Mês"
        Me.JurosMes.Name = "JurosMes"
        Me.JurosMes.ReadOnly = True
        '
        'JurosDia
        '
        Me.JurosDia.DataPropertyName = "JurosDia"
        Me.JurosDia.HeaderText = "Juros da Conta por Dia"
        Me.JurosDia.Name = "JurosDia"
        Me.JurosDia.ReadOnly = True
        '
        'Pago
        '
        Me.Pago.DataPropertyName = "Pago"
        Me.Pago.HeaderText = "Pago"
        Me.Pago.Name = "Pago"
        Me.Pago.ReadOnly = True
        Me.Pago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Pago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataCadastro
        '
        Me.DataCadastro.DataPropertyName = "DataCadastro"
        Me.DataCadastro.HeaderText = "Data de Cadastro"
        Me.DataCadastro.Name = "DataCadastro"
        Me.DataCadastro.ReadOnly = True
        Me.DataCadastro.Visible = False
        '
        'txtTotalContas
        '
        Me.txtTotalContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalContas.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.txtTotalContas.Location = New System.Drawing.Point(553, 408)
        Me.txtTotalContas.Multiline = True
        Me.txtTotalContas.Name = "txtTotalContas"
        Me.txtTotalContas.Size = New System.Drawing.Size(232, 30)
        Me.txtTotalContas.TabIndex = 2
        Me.txtTotalContas.Text = "R$ 00,00"
        Me.txtTotalContas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalContas
        '
        Me.lblTotalContas.AutoSize = True
        Me.lblTotalContas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalContas.Location = New System.Drawing.Point(199, 412)
        Me.lblTotalContas.Name = "lblTotalContas"
        Me.lblTotalContas.Size = New System.Drawing.Size(348, 24)
        Me.lblTotalContas.TabIndex = 3
        Me.lblTotalContas.Text = "Resultado Total de Contas Cadastradas :"
        '
        'gbBotoesContas
        '
        Me.gbBotoesContas.Controls.Add(Me.rbtnTodasContas)
        Me.gbBotoesContas.Controls.Add(Me.rbtnContasVencidas)
        Me.gbBotoesContas.Controls.Add(Me.rbtnContasNaoPagas)
        Me.gbBotoesContas.Controls.Add(Me.rbtnPago)
        Me.gbBotoesContas.Location = New System.Drawing.Point(12, 61)
        Me.gbBotoesContas.Name = "gbBotoesContas"
        Me.gbBotoesContas.Size = New System.Drawing.Size(877, 55)
        Me.gbBotoesContas.TabIndex = 4
        Me.gbBotoesContas.TabStop = False
        '
        'rbtnTodasContas
        '
        Me.rbtnTodasContas.AutoSize = True
        Me.rbtnTodasContas.Checked = True
        Me.rbtnTodasContas.Location = New System.Drawing.Point(20, 19)
        Me.rbtnTodasContas.Name = "rbtnTodasContas"
        Me.rbtnTodasContas.Size = New System.Drawing.Size(105, 17)
        Me.rbtnTodasContas.TabIndex = 3
        Me.rbtnTodasContas.TabStop = True
        Me.rbtnTodasContas.Text = "Todas as Contas"
        Me.rbtnTodasContas.UseVisualStyleBackColor = True
        '
        'rbtnContasVencidas
        '
        Me.rbtnContasVencidas.AutoSize = True
        Me.rbtnContasVencidas.Location = New System.Drawing.Point(357, 19)
        Me.rbtnContasVencidas.Name = "rbtnContasVencidas"
        Me.rbtnContasVencidas.Size = New System.Drawing.Size(108, 17)
        Me.rbtnContasVencidas.TabIndex = 2
        Me.rbtnContasVencidas.Text = "Contas  Vencidas"
        Me.rbtnContasVencidas.UseVisualStyleBackColor = True
        '
        'rbtnContasNaoPagas
        '
        Me.rbtnContasNaoPagas.AutoSize = True
        Me.rbtnContasNaoPagas.Location = New System.Drawing.Point(237, 19)
        Me.rbtnContasNaoPagas.Name = "rbtnContasNaoPagas"
        Me.rbtnContasNaoPagas.Size = New System.Drawing.Size(114, 17)
        Me.rbtnContasNaoPagas.TabIndex = 1
        Me.rbtnContasNaoPagas.Text = "Contas Não Pagas"
        Me.rbtnContasNaoPagas.UseVisualStyleBackColor = True
        '
        'rbtnPago
        '
        Me.rbtnPago.Location = New System.Drawing.Point(134, 19)
        Me.rbtnPago.Name = "rbtnPago"
        Me.rbtnPago.Size = New System.Drawing.Size(97, 17)
        Me.rbtnPago.TabIndex = 0
        Me.rbtnPago.Text = "Contas Pagas"
        Me.rbtnPago.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirContasToolStripMenuItem, Me.NovaContaToolStripMenuItem, Me.PagarContasToolStripMenuItem, Me.AtualizarNúmeroDeContasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(901, 58)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirContasToolStripMenuItem
        '
        Me.AbrirContasToolStripMenuItem.Image = CType(resources.GetObject("AbrirContasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirContasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AbrirContasToolStripMenuItem.Name = "AbrirContasToolStripMenuItem"
        Me.AbrirContasToolStripMenuItem.Size = New System.Drawing.Size(85, 54)
        Me.AbrirContasToolStripMenuItem.Text = "Abrir Contas"
        Me.AbrirContasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'NovaContaToolStripMenuItem
        '
        Me.NovaContaToolStripMenuItem.Image = CType(resources.GetObject("NovaContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NovaContaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NovaContaToolStripMenuItem.Name = "NovaContaToolStripMenuItem"
        Me.NovaContaToolStripMenuItem.Size = New System.Drawing.Size(82, 54)
        Me.NovaContaToolStripMenuItem.Text = "Nova Conta"
        Me.NovaContaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PagarContasToolStripMenuItem
        '
        Me.PagarContasToolStripMenuItem.Image = CType(resources.GetObject("PagarContasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PagarContasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PagarContasToolStripMenuItem.Name = "PagarContasToolStripMenuItem"
        Me.PagarContasToolStripMenuItem.Size = New System.Drawing.Size(89, 54)
        Me.PagarContasToolStripMenuItem.Text = "Pagar Contas"
        Me.PagarContasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AtualizarNúmeroDeContasToolStripMenuItem
        '
        Me.AtualizarNúmeroDeContasToolStripMenuItem.Image = CType(resources.GetObject("AtualizarNúmeroDeContasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AtualizarNúmeroDeContasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AtualizarNúmeroDeContasToolStripMenuItem.Name = "AtualizarNúmeroDeContasToolStripMenuItem"
        Me.AtualizarNúmeroDeContasToolStripMenuItem.Size = New System.Drawing.Size(168, 54)
        Me.AtualizarNúmeroDeContasToolStripMenuItem.Text = "Atualizar Número de Contas"
        Me.AtualizarNúmeroDeContasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmAdicionarContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 450)
        Me.Controls.Add(Me.gbBotoesContas)
        Me.Controls.Add(Me.lblTotalContas)
        Me.Controls.Add(Me.txtTotalContas)
        Me.Controls.Add(Me.gbContas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAdicionarContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adicionar Contas"
        Me.gbContas.ResumeLayout(False)
        CType(Me.dgvContas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBotoesContas.ResumeLayout(False)
        Me.gbBotoesContas.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbContas As GroupBox
    Friend WithEvents dgvContas As DataGridView
    Friend WithEvents txtTotalContas As TextBox
    Friend WithEvents lblTotalContas As Label
    Friend WithEvents gbBotoesContas As GroupBox
    Friend WithEvents rbtnPago As RadioButton
    Friend WithEvents rbtnContasVencidas As RadioButton
    Friend WithEvents rbtnContasNaoPagas As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AbrirContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovaContaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rbtnTodasContas As RadioButton
    Friend WithEvents PagarContasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdDaConta As DataGridViewTextBoxColumn
    Friend WithEvents TipoDaConta As DataGridViewTextBoxColumn
    Friend WithEvents Empresa As DataGridViewTextBoxColumn
    Friend WithEvents ValorDaConta As DataGridViewTextBoxColumn
    Friend WithEvents VencimentoDaConta As DataGridViewTextBoxColumn
    Friend WithEvents MultaAtraso As DataGridViewTextBoxColumn
    Friend WithEvents JurosMes As DataGridViewTextBoxColumn
    Friend WithEvents JurosDia As DataGridViewTextBoxColumn
    Friend WithEvents Pago As DataGridViewCheckBoxColumn
    Friend WithEvents DataCadastro As DataGridViewTextBoxColumn
    Friend WithEvents AtualizarNúmeroDeContasToolStripMenuItem As ToolStripMenuItem
End Class
