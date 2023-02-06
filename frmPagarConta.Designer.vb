<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagarConta
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagarConta))
        Me.gbContaSelecionada = New System.Windows.Forms.GroupBox()
        Me.cboPagoPagamento = New System.Windows.Forms.CheckBox()
        Me.gbFormaPagamento = New System.Windows.Forms.GroupBox()
        Me.btnPagamento = New System.Windows.Forms.Button()
        Me.pbPix = New System.Windows.Forms.PictureBox()
        Me.rbtnPix = New System.Windows.Forms.RadioButton()
        Me.rbtnCartao = New System.Windows.Forms.RadioButton()
        Me.rbtnDinheiro = New System.Windows.Forms.RadioButton()
        Me.lblDataCadastroPagamento = New System.Windows.Forms.Label()
        Me.lblIdContaPagamento = New System.Windows.Forms.Label()
        Me.txtIdDaContaPagamento = New System.Windows.Forms.TextBox()
        Me.lblPagoPagamento = New System.Windows.Forms.Label()
        Me.txtTipoDaContaPagamento = New System.Windows.Forms.TextBox()
        Me.lblJurosDiaPagamento = New System.Windows.Forms.Label()
        Me.lblJurosMesPagamento = New System.Windows.Forms.Label()
        Me.txtEmpresaDaContaPagamento = New System.Windows.Forms.TextBox()
        Me.lblMultaAtrasoPagamento = New System.Windows.Forms.Label()
        Me.txtValorDaContaPagamento = New System.Windows.Forms.TextBox()
        Me.lblVencimentoDaContaPagamento = New System.Windows.Forms.Label()
        Me.txtVencimentoDaContaPagamento = New System.Windows.Forms.TextBox()
        Me.lblValorDaContaPagamento = New System.Windows.Forms.Label()
        Me.txtMultaAtrasoPagamento = New System.Windows.Forms.TextBox()
        Me.lblEmpresaDaContaPagamento = New System.Windows.Forms.Label()
        Me.txtJurosMesPagamento = New System.Windows.Forms.TextBox()
        Me.lblTipoDaContaPagamento = New System.Windows.Forms.Label()
        Me.txtJurosDiaPagamento = New System.Windows.Forms.TextBox()
        Me.txtDataCadastroPagamento = New System.Windows.Forms.TextBox()
        Me.gbValoresPagamento = New System.Windows.Forms.GroupBox()
        Me.lblValorTotalValores = New System.Windows.Forms.Label()
        Me.lblValorDoJurosValores = New System.Windows.Forms.Label()
        Me.lblValorDaContaValores = New System.Windows.Forms.Label()
        Me.txtValorTotalContaPagamento = New System.Windows.Forms.TextBox()
        Me.txtValorJurosPagamento = New System.Windows.Forms.TextBox()
        Me.txtValorContaPagamento = New System.Windows.Forms.TextBox()
        Me.btnCalculoDeDias = New System.Windows.Forms.Button()
        Me.gbContaSelecionada.SuspendLayout()
        Me.gbFormaPagamento.SuspendLayout()
        CType(Me.pbPix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbValoresPagamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbContaSelecionada
        '
        Me.gbContaSelecionada.Controls.Add(Me.btnCalculoDeDias)
        Me.gbContaSelecionada.Controls.Add(Me.cboPagoPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.gbFormaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblDataCadastroPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblIdContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.txtIdDaContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblPagoPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.txtTipoDaContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblJurosDiaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblJurosMesPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.txtEmpresaDaContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblMultaAtrasoPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.txtValorDaContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblVencimentoDaContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.txtVencimentoDaContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblValorDaContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.txtMultaAtrasoPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblEmpresaDaContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.txtJurosMesPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.lblTipoDaContaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.txtJurosDiaPagamento)
        Me.gbContaSelecionada.Controls.Add(Me.txtDataCadastroPagamento)
        Me.gbContaSelecionada.Location = New System.Drawing.Point(12, 12)
        Me.gbContaSelecionada.Name = "gbContaSelecionada"
        Me.gbContaSelecionada.Size = New System.Drawing.Size(878, 253)
        Me.gbContaSelecionada.TabIndex = 0
        Me.gbContaSelecionada.TabStop = False
        Me.gbContaSelecionada.Text = "Conta Selecionada"
        '
        'cboPagoPagamento
        '
        Me.cboPagoPagamento.AutoSize = True
        Me.cboPagoPagamento.Enabled = False
        Me.cboPagoPagamento.Location = New System.Drawing.Point(305, 169)
        Me.cboPagoPagamento.Name = "cboPagoPagamento"
        Me.cboPagoPagamento.Size = New System.Drawing.Size(15, 14)
        Me.cboPagoPagamento.TabIndex = 20
        Me.cboPagoPagamento.UseVisualStyleBackColor = True
        '
        'gbFormaPagamento
        '
        Me.gbFormaPagamento.Controls.Add(Me.btnPagamento)
        Me.gbFormaPagamento.Controls.Add(Me.pbPix)
        Me.gbFormaPagamento.Controls.Add(Me.rbtnPix)
        Me.gbFormaPagamento.Controls.Add(Me.rbtnCartao)
        Me.gbFormaPagamento.Controls.Add(Me.rbtnDinheiro)
        Me.gbFormaPagamento.Location = New System.Drawing.Point(513, 8)
        Me.gbFormaPagamento.Name = "gbFormaPagamento"
        Me.gbFormaPagamento.Size = New System.Drawing.Size(359, 229)
        Me.gbFormaPagamento.TabIndex = 19
        Me.gbFormaPagamento.TabStop = False
        Me.gbFormaPagamento.Text = "Forma de Pagamento"
        '
        'btnPagamento
        '
        Me.btnPagamento.Location = New System.Drawing.Point(18, 140)
        Me.btnPagamento.Name = "btnPagamento"
        Me.btnPagamento.Size = New System.Drawing.Size(90, 54)
        Me.btnPagamento.TabIndex = 23
        Me.btnPagamento.Text = "Pagar"
        Me.btnPagamento.UseVisualStyleBackColor = True
        '
        'pbPix
        '
        Me.pbPix.Location = New System.Drawing.Point(129, 17)
        Me.pbPix.Name = "pbPix"
        Me.pbPix.Size = New System.Drawing.Size(202, 195)
        Me.pbPix.TabIndex = 22
        Me.pbPix.TabStop = False
        '
        'rbtnPix
        '
        Me.rbtnPix.AutoSize = True
        Me.rbtnPix.Location = New System.Drawing.Point(18, 81)
        Me.rbtnPix.Name = "rbtnPix"
        Me.rbtnPix.Size = New System.Drawing.Size(39, 17)
        Me.rbtnPix.TabIndex = 21
        Me.rbtnPix.TabStop = True
        Me.rbtnPix.Text = "Pix"
        Me.rbtnPix.UseVisualStyleBackColor = True
        '
        'rbtnCartao
        '
        Me.rbtnCartao.AutoSize = True
        Me.rbtnCartao.Location = New System.Drawing.Point(18, 58)
        Me.rbtnCartao.Name = "rbtnCartao"
        Me.rbtnCartao.Size = New System.Drawing.Size(107, 17)
        Me.rbtnCartao.TabIndex = 20
        Me.rbtnCartao.TabStop = True
        Me.rbtnCartao.Text = "Cartão de Crédito"
        Me.rbtnCartao.UseVisualStyleBackColor = True
        '
        'rbtnDinheiro
        '
        Me.rbtnDinheiro.AutoSize = True
        Me.rbtnDinheiro.Location = New System.Drawing.Point(18, 35)
        Me.rbtnDinheiro.Name = "rbtnDinheiro"
        Me.rbtnDinheiro.Size = New System.Drawing.Size(64, 17)
        Me.rbtnDinheiro.TabIndex = 19
        Me.rbtnDinheiro.TabStop = True
        Me.rbtnDinheiro.Text = "Dinheiro"
        Me.rbtnDinheiro.UseVisualStyleBackColor = True
        '
        'lblDataCadastroPagamento
        '
        Me.lblDataCadastroPagamento.AutoSize = True
        Me.lblDataCadastroPagamento.Location = New System.Drawing.Point(343, 169)
        Me.lblDataCadastroPagamento.Name = "lblDataCadastroPagamento"
        Me.lblDataCadastroPagamento.Size = New System.Drawing.Size(142, 13)
        Me.lblDataCadastroPagamento.TabIndex = 18
        Me.lblDataCadastroPagamento.Text = "Data de Cadastro da Conta :"
        '
        'lblIdContaPagamento
        '
        Me.lblIdContaPagamento.AutoSize = True
        Me.lblIdContaPagamento.Location = New System.Drawing.Point(80, 42)
        Me.lblIdContaPagamento.Name = "lblIdContaPagamento"
        Me.lblIdContaPagamento.Size = New System.Drawing.Size(18, 13)
        Me.lblIdContaPagamento.TabIndex = 1
        Me.lblIdContaPagamento.Text = "ID"
        '
        'txtIdDaContaPagamento
        '
        Me.txtIdDaContaPagamento.Location = New System.Drawing.Point(125, 39)
        Me.txtIdDaContaPagamento.Name = "txtIdDaContaPagamento"
        Me.txtIdDaContaPagamento.Size = New System.Drawing.Size(100, 20)
        Me.txtIdDaContaPagamento.TabIndex = 0
        '
        'lblPagoPagamento
        '
        Me.lblPagoPagamento.AutoSize = True
        Me.lblPagoPagamento.Location = New System.Drawing.Point(261, 169)
        Me.lblPagoPagamento.Name = "lblPagoPagamento"
        Me.lblPagoPagamento.Size = New System.Drawing.Size(38, 13)
        Me.lblPagoPagamento.TabIndex = 17
        Me.lblPagoPagamento.Text = "Pago :"
        '
        'txtTipoDaContaPagamento
        '
        Me.txtTipoDaContaPagamento.Location = New System.Drawing.Point(125, 84)
        Me.txtTipoDaContaPagamento.Name = "txtTipoDaContaPagamento"
        Me.txtTipoDaContaPagamento.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoDaContaPagamento.TabIndex = 1
        '
        'lblJurosDiaPagamento
        '
        Me.lblJurosDiaPagamento.AutoSize = True
        Me.lblJurosDiaPagamento.Location = New System.Drawing.Point(261, 132)
        Me.lblJurosDiaPagamento.Name = "lblJurosDiaPagamento"
        Me.lblJurosDiaPagamento.Size = New System.Drawing.Size(118, 13)
        Me.lblJurosDiaPagamento.TabIndex = 16
        Me.lblJurosDiaPagamento.Text = "Juros ao Dia da Conta :"
        '
        'lblJurosMesPagamento
        '
        Me.lblJurosMesPagamento.AutoSize = True
        Me.lblJurosMesPagamento.Location = New System.Drawing.Point(257, 87)
        Me.lblJurosMesPagamento.Name = "lblJurosMesPagamento"
        Me.lblJurosMesPagamento.Size = New System.Drawing.Size(122, 13)
        Me.lblJurosMesPagamento.TabIndex = 15
        Me.lblJurosMesPagamento.Text = "Juros ao Mês da Conta :"
        '
        'txtEmpresaDaContaPagamento
        '
        Me.txtEmpresaDaContaPagamento.Location = New System.Drawing.Point(125, 129)
        Me.txtEmpresaDaContaPagamento.Name = "txtEmpresaDaContaPagamento"
        Me.txtEmpresaDaContaPagamento.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpresaDaContaPagamento.TabIndex = 2
        '
        'lblMultaAtrasoPagamento
        '
        Me.lblMultaAtrasoPagamento.AutoSize = True
        Me.lblMultaAtrasoPagamento.Location = New System.Drawing.Point(246, 42)
        Me.lblMultaAtrasoPagamento.Name = "lblMultaAtrasoPagamento"
        Me.lblMultaAtrasoPagamento.Size = New System.Drawing.Size(133, 13)
        Me.lblMultaAtrasoPagamento.TabIndex = 14
        Me.lblMultaAtrasoPagamento.Text = "Multa de Atraso da Conta :"
        '
        'txtValorDaContaPagamento
        '
        Me.txtValorDaContaPagamento.Location = New System.Drawing.Point(125, 174)
        Me.txtValorDaContaPagamento.Name = "txtValorDaContaPagamento"
        Me.txtValorDaContaPagamento.Size = New System.Drawing.Size(100, 20)
        Me.txtValorDaContaPagamento.TabIndex = 3
        '
        'lblVencimentoDaContaPagamento
        '
        Me.lblVencimentoDaContaPagamento.AutoSize = True
        Me.lblVencimentoDaContaPagamento.Location = New System.Drawing.Point(4, 220)
        Me.lblVencimentoDaContaPagamento.Name = "lblVencimentoDaContaPagamento"
        Me.lblVencimentoDaContaPagamento.Size = New System.Drawing.Size(115, 13)
        Me.lblVencimentoDaContaPagamento.TabIndex = 13
        Me.lblVencimentoDaContaPagamento.Text = "Vencimento da Conta :"
        '
        'txtVencimentoDaContaPagamento
        '
        Me.txtVencimentoDaContaPagamento.Location = New System.Drawing.Point(125, 217)
        Me.txtVencimentoDaContaPagamento.Name = "txtVencimentoDaContaPagamento"
        Me.txtVencimentoDaContaPagamento.Size = New System.Drawing.Size(100, 20)
        Me.txtVencimentoDaContaPagamento.TabIndex = 4
        '
        'lblValorDaContaPagamento
        '
        Me.lblValorDaContaPagamento.AutoSize = True
        Me.lblValorDaContaPagamento.Location = New System.Drawing.Point(36, 177)
        Me.lblValorDaContaPagamento.Name = "lblValorDaContaPagamento"
        Me.lblValorDaContaPagamento.Size = New System.Drawing.Size(83, 13)
        Me.lblValorDaContaPagamento.TabIndex = 12
        Me.lblValorDaContaPagamento.Text = "Valor da Conta :"
        '
        'txtMultaAtrasoPagamento
        '
        Me.txtMultaAtrasoPagamento.Location = New System.Drawing.Point(385, 39)
        Me.txtMultaAtrasoPagamento.Name = "txtMultaAtrasoPagamento"
        Me.txtMultaAtrasoPagamento.Size = New System.Drawing.Size(100, 20)
        Me.txtMultaAtrasoPagamento.TabIndex = 5
        '
        'lblEmpresaDaContaPagamento
        '
        Me.lblEmpresaDaContaPagamento.AutoSize = True
        Me.lblEmpresaDaContaPagamento.Location = New System.Drawing.Point(19, 132)
        Me.lblEmpresaDaContaPagamento.Name = "lblEmpresaDaContaPagamento"
        Me.lblEmpresaDaContaPagamento.Size = New System.Drawing.Size(100, 13)
        Me.lblEmpresaDaContaPagamento.TabIndex = 11
        Me.lblEmpresaDaContaPagamento.Text = "Empresa da Conta :"
        '
        'txtJurosMesPagamento
        '
        Me.txtJurosMesPagamento.Location = New System.Drawing.Point(385, 84)
        Me.txtJurosMesPagamento.Name = "txtJurosMesPagamento"
        Me.txtJurosMesPagamento.Size = New System.Drawing.Size(100, 20)
        Me.txtJurosMesPagamento.TabIndex = 6
        '
        'lblTipoDaContaPagamento
        '
        Me.lblTipoDaContaPagamento.AutoSize = True
        Me.lblTipoDaContaPagamento.Location = New System.Drawing.Point(39, 87)
        Me.lblTipoDaContaPagamento.Name = "lblTipoDaContaPagamento"
        Me.lblTipoDaContaPagamento.Size = New System.Drawing.Size(80, 13)
        Me.lblTipoDaContaPagamento.TabIndex = 10
        Me.lblTipoDaContaPagamento.Text = "Tipo da Conta :"
        '
        'txtJurosDiaPagamento
        '
        Me.txtJurosDiaPagamento.Location = New System.Drawing.Point(385, 129)
        Me.txtJurosDiaPagamento.Name = "txtJurosDiaPagamento"
        Me.txtJurosDiaPagamento.Size = New System.Drawing.Size(100, 20)
        Me.txtJurosDiaPagamento.TabIndex = 7
        '
        'txtDataCadastroPagamento
        '
        Me.txtDataCadastroPagamento.Location = New System.Drawing.Point(363, 185)
        Me.txtDataCadastroPagamento.Name = "txtDataCadastroPagamento"
        Me.txtDataCadastroPagamento.Size = New System.Drawing.Size(122, 20)
        Me.txtDataCadastroPagamento.TabIndex = 8
        '
        'gbValoresPagamento
        '
        Me.gbValoresPagamento.Controls.Add(Me.lblValorTotalValores)
        Me.gbValoresPagamento.Controls.Add(Me.lblValorDoJurosValores)
        Me.gbValoresPagamento.Controls.Add(Me.lblValorDaContaValores)
        Me.gbValoresPagamento.Controls.Add(Me.txtValorTotalContaPagamento)
        Me.gbValoresPagamento.Controls.Add(Me.txtValorJurosPagamento)
        Me.gbValoresPagamento.Controls.Add(Me.txtValorContaPagamento)
        Me.gbValoresPagamento.Location = New System.Drawing.Point(12, 271)
        Me.gbValoresPagamento.Name = "gbValoresPagamento"
        Me.gbValoresPagamento.Size = New System.Drawing.Size(878, 62)
        Me.gbValoresPagamento.TabIndex = 1
        Me.gbValoresPagamento.TabStop = False
        Me.gbValoresPagamento.Text = "Valores"
        '
        'lblValorTotalValores
        '
        Me.lblValorTotalValores.AutoSize = True
        Me.lblValorTotalValores.Location = New System.Drawing.Point(639, 16)
        Me.lblValorTotalValores.Name = "lblValorTotalValores"
        Me.lblValorTotalValores.Size = New System.Drawing.Size(110, 13)
        Me.lblValorTotalValores.TabIndex = 5
        Me.lblValorTotalValores.Text = "Valor Total da Conta :"
        '
        'lblValorDoJurosValores
        '
        Me.lblValorDoJurosValores.AutoSize = True
        Me.lblValorDoJurosValores.Location = New System.Drawing.Point(320, 16)
        Me.lblValorDoJurosValores.Name = "lblValorDoJurosValores"
        Me.lblValorDoJurosValores.Size = New System.Drawing.Size(80, 13)
        Me.lblValorDoJurosValores.TabIndex = 4
        Me.lblValorDoJurosValores.Text = "Valor do Juros :"
        '
        'lblValorDaContaValores
        '
        Me.lblValorDaContaValores.AutoSize = True
        Me.lblValorDaContaValores.Location = New System.Drawing.Point(19, 16)
        Me.lblValorDaContaValores.Name = "lblValorDaContaValores"
        Me.lblValorDaContaValores.Size = New System.Drawing.Size(83, 13)
        Me.lblValorDaContaValores.TabIndex = 3
        Me.lblValorDaContaValores.Text = "Valor da Conta :"
        '
        'txtValorTotalContaPagamento
        '
        Me.txtValorTotalContaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotalContaPagamento.Location = New System.Drawing.Point(661, 29)
        Me.txtValorTotalContaPagamento.Multiline = True
        Me.txtValorTotalContaPagamento.Name = "txtValorTotalContaPagamento"
        Me.txtValorTotalContaPagamento.Size = New System.Drawing.Size(183, 27)
        Me.txtValorTotalContaPagamento.TabIndex = 2
        Me.txtValorTotalContaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorJurosPagamento
        '
        Me.txtValorJurosPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorJurosPagamento.Location = New System.Drawing.Point(344, 29)
        Me.txtValorJurosPagamento.Multiline = True
        Me.txtValorJurosPagamento.Name = "txtValorJurosPagamento"
        Me.txtValorJurosPagamento.Size = New System.Drawing.Size(183, 27)
        Me.txtValorJurosPagamento.TabIndex = 1
        Me.txtValorJurosPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtValorContaPagamento
        '
        Me.txtValorContaPagamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorContaPagamento.Location = New System.Drawing.Point(42, 29)
        Me.txtValorContaPagamento.Multiline = True
        Me.txtValorContaPagamento.Name = "txtValorContaPagamento"
        Me.txtValorContaPagamento.Size = New System.Drawing.Size(183, 27)
        Me.txtValorContaPagamento.TabIndex = 0
        Me.txtValorContaPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculoDeDias
        '
        Me.btnCalculoDeDias.Location = New System.Drawing.Point(231, 215)
        Me.btnCalculoDeDias.Name = "btnCalculoDeDias"
        Me.btnCalculoDeDias.Size = New System.Drawing.Size(176, 23)
        Me.btnCalculoDeDias.TabIndex = 21
        Me.btnCalculoDeDias.Text = "Dias Restantes para Vencimento"
        Me.btnCalculoDeDias.UseVisualStyleBackColor = True
        '
        'frmPagarConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 345)
        Me.Controls.Add(Me.gbValoresPagamento)
        Me.Controls.Add(Me.gbContaSelecionada)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPagarConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagamento de Conta"
        Me.gbContaSelecionada.ResumeLayout(False)
        Me.gbContaSelecionada.PerformLayout()
        Me.gbFormaPagamento.ResumeLayout(False)
        Me.gbFormaPagamento.PerformLayout()
        CType(Me.pbPix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbValoresPagamento.ResumeLayout(False)
        Me.gbValoresPagamento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbContaSelecionada As GroupBox
    Friend WithEvents lblIdContaPagamento As Label
    Friend WithEvents txtIdDaContaPagamento As TextBox
    Friend WithEvents txtTipoDaContaPagamento As TextBox
    Friend WithEvents txtEmpresaDaContaPagamento As TextBox
    Friend WithEvents txtValorDaContaPagamento As TextBox
    Friend WithEvents txtVencimentoDaContaPagamento As TextBox
    Friend WithEvents txtMultaAtrasoPagamento As TextBox
    Friend WithEvents txtJurosMesPagamento As TextBox
    Friend WithEvents txtJurosDiaPagamento As TextBox
    Friend WithEvents txtDataCadastroPagamento As TextBox
    Friend WithEvents lblTipoDaContaPagamento As Label
    Friend WithEvents lblEmpresaDaContaPagamento As Label
    Friend WithEvents lblValorDaContaPagamento As Label
    Friend WithEvents lblVencimentoDaContaPagamento As Label
    Friend WithEvents lblMultaAtrasoPagamento As Label
    Friend WithEvents lblJurosMesPagamento As Label
    Friend WithEvents lblJurosDiaPagamento As Label
    Friend WithEvents lblPagoPagamento As Label
    Friend WithEvents lblDataCadastroPagamento As Label
    Friend WithEvents gbFormaPagamento As GroupBox
    Friend WithEvents btnPagamento As Button
    Friend WithEvents pbPix As PictureBox
    Friend WithEvents rbtnPix As RadioButton
    Friend WithEvents rbtnCartao As RadioButton
    Friend WithEvents rbtnDinheiro As RadioButton
    Friend WithEvents gbValoresPagamento As GroupBox
    Friend WithEvents lblValorTotalValores As Label
    Friend WithEvents lblValorDoJurosValores As Label
    Friend WithEvents lblValorDaContaValores As Label
    Friend WithEvents txtValorTotalContaPagamento As TextBox
    Friend WithEvents txtValorJurosPagamento As TextBox
    Friend WithEvents txtValorContaPagamento As TextBox
    Friend WithEvents cboPagoPagamento As CheckBox
    Friend WithEvents btnCalculoDeDias As Button
End Class
