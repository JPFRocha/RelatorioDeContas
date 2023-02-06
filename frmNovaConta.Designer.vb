<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNovaConta
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
        Me.lblTipoContaNova = New System.Windows.Forms.Label()
        Me.txtTipoContaNova = New System.Windows.Forms.TextBox()
        Me.lblEmpresaContaNova = New System.Windows.Forms.Label()
        Me.lblValorContaNova = New System.Windows.Forms.Label()
        Me.lblVencimentoContaNova = New System.Windows.Forms.Label()
        Me.txtEmpresaContaNova = New System.Windows.Forms.TextBox()
        Me.btnSalvarContaNova = New System.Windows.Forms.Button()
        Me.txtValorContaNova = New System.Windows.Forms.TextBox()
        Me.dtpVencimentoContaNova = New System.Windows.Forms.DateTimePicker()
        Me.lblJurosConta = New System.Windows.Forms.Label()
        Me.txtJurosConta = New System.Windows.Forms.TextBox()
        Me.txtJurosContaMes = New System.Windows.Forms.TextBox()
        Me.txtJurosContaDia = New System.Windows.Forms.TextBox()
        Me.lblJurosContaMes = New System.Windows.Forms.Label()
        Me.lblJurosContaDia = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTipoContaNova
        '
        Me.lblTipoContaNova.AutoSize = True
        Me.lblTipoContaNova.Location = New System.Drawing.Point(108, 21)
        Me.lblTipoContaNova.Name = "lblTipoContaNova"
        Me.lblTipoContaNova.Size = New System.Drawing.Size(83, 13)
        Me.lblTipoContaNova.TabIndex = 0
        Me.lblTipoContaNova.Text = "Tipo de Conta : "
        '
        'txtTipoContaNova
        '
        Me.txtTipoContaNova.Location = New System.Drawing.Point(197, 18)
        Me.txtTipoContaNova.Name = "txtTipoContaNova"
        Me.txtTipoContaNova.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoContaNova.TabIndex = 1
        '
        'lblEmpresaContaNova
        '
        Me.lblEmpresaContaNova.AutoSize = True
        Me.lblEmpresaContaNova.Location = New System.Drawing.Point(91, 51)
        Me.lblEmpresaContaNova.Name = "lblEmpresaContaNova"
        Me.lblEmpresaContaNova.Size = New System.Drawing.Size(100, 13)
        Me.lblEmpresaContaNova.TabIndex = 2
        Me.lblEmpresaContaNova.Text = "Empresa da Conta :"
        '
        'lblValorContaNova
        '
        Me.lblValorContaNova.AutoSize = True
        Me.lblValorContaNova.Location = New System.Drawing.Point(108, 82)
        Me.lblValorContaNova.Name = "lblValorContaNova"
        Me.lblValorContaNova.Size = New System.Drawing.Size(83, 13)
        Me.lblValorContaNova.TabIndex = 3
        Me.lblValorContaNova.Text = "Valor da Conta :"
        '
        'lblVencimentoContaNova
        '
        Me.lblVencimentoContaNova.AutoSize = True
        Me.lblVencimentoContaNova.Location = New System.Drawing.Point(76, 116)
        Me.lblVencimentoContaNova.Name = "lblVencimentoContaNova"
        Me.lblVencimentoContaNova.Size = New System.Drawing.Size(115, 13)
        Me.lblVencimentoContaNova.TabIndex = 4
        Me.lblVencimentoContaNova.Text = "Vencimento da Conta :"
        '
        'txtEmpresaContaNova
        '
        Me.txtEmpresaContaNova.Location = New System.Drawing.Point(197, 48)
        Me.txtEmpresaContaNova.Name = "txtEmpresaContaNova"
        Me.txtEmpresaContaNova.Size = New System.Drawing.Size(100, 20)
        Me.txtEmpresaContaNova.TabIndex = 5
        '
        'btnSalvarContaNova
        '
        Me.btnSalvarContaNova.Location = New System.Drawing.Point(121, 240)
        Me.btnSalvarContaNova.Name = "btnSalvarContaNova"
        Me.btnSalvarContaNova.Size = New System.Drawing.Size(131, 45)
        Me.btnSalvarContaNova.TabIndex = 8
        Me.btnSalvarContaNova.Text = "Incluir dados de conta cadastrados"
        Me.btnSalvarContaNova.UseVisualStyleBackColor = True
        '
        'txtValorContaNova
        '
        Me.txtValorContaNova.Location = New System.Drawing.Point(197, 79)
        Me.txtValorContaNova.Name = "txtValorContaNova"
        Me.txtValorContaNova.Size = New System.Drawing.Size(100, 20)
        Me.txtValorContaNova.TabIndex = 6
        '
        'dtpVencimentoContaNova
        '
        Me.dtpVencimentoContaNova.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpVencimentoContaNova.Location = New System.Drawing.Point(197, 110)
        Me.dtpVencimentoContaNova.Name = "dtpVencimentoContaNova"
        Me.dtpVencimentoContaNova.Size = New System.Drawing.Size(100, 20)
        Me.dtpVencimentoContaNova.TabIndex = 9
        '
        'lblJurosConta
        '
        Me.lblJurosConta.AutoSize = True
        Me.lblJurosConta.Location = New System.Drawing.Point(59, 144)
        Me.lblJurosConta.Name = "lblJurosConta"
        Me.lblJurosConta.Size = New System.Drawing.Size(132, 13)
        Me.lblJurosConta.TabIndex = 10
        Me.lblJurosConta.Text = "Valor de Multa por Atraso :"
        '
        'txtJurosConta
        '
        Me.txtJurosConta.Location = New System.Drawing.Point(197, 141)
        Me.txtJurosConta.Name = "txtJurosConta"
        Me.txtJurosConta.Size = New System.Drawing.Size(100, 20)
        Me.txtJurosConta.TabIndex = 11
        '
        'txtJurosContaMes
        '
        Me.txtJurosContaMes.Location = New System.Drawing.Point(197, 167)
        Me.txtJurosContaMes.Name = "txtJurosContaMes"
        Me.txtJurosContaMes.Size = New System.Drawing.Size(100, 20)
        Me.txtJurosContaMes.TabIndex = 12
        '
        'txtJurosContaDia
        '
        Me.txtJurosContaDia.Location = New System.Drawing.Point(197, 193)
        Me.txtJurosContaDia.Name = "txtJurosContaDia"
        Me.txtJurosContaDia.Size = New System.Drawing.Size(100, 20)
        Me.txtJurosContaDia.TabIndex = 13
        '
        'lblJurosContaMes
        '
        Me.lblJurosContaMes.AutoSize = True
        Me.lblJurosContaMes.Location = New System.Drawing.Point(70, 170)
        Me.lblJurosContaMes.Name = "lblJurosContaMes"
        Me.lblJurosContaMes.Size = New System.Drawing.Size(121, 13)
        Me.lblJurosContaMes.TabIndex = 14
        Me.lblJurosContaMes.Text = "Valor de Juros por Mês :"
        '
        'lblJurosContaDia
        '
        Me.lblJurosContaDia.AutoSize = True
        Me.lblJurosContaDia.Location = New System.Drawing.Point(74, 196)
        Me.lblJurosContaDia.Name = "lblJurosContaDia"
        Me.lblJurosContaDia.Size = New System.Drawing.Size(117, 13)
        Me.lblJurosContaDia.TabIndex = 15
        Me.lblJurosContaDia.Text = "Valor de Juros por Dia :"
        '
        'frmNovaConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 313)
        Me.Controls.Add(Me.lblJurosContaDia)
        Me.Controls.Add(Me.lblJurosContaMes)
        Me.Controls.Add(Me.txtJurosContaDia)
        Me.Controls.Add(Me.txtJurosContaMes)
        Me.Controls.Add(Me.txtJurosConta)
        Me.Controls.Add(Me.lblJurosConta)
        Me.Controls.Add(Me.dtpVencimentoContaNova)
        Me.Controls.Add(Me.btnSalvarContaNova)
        Me.Controls.Add(Me.txtValorContaNova)
        Me.Controls.Add(Me.txtEmpresaContaNova)
        Me.Controls.Add(Me.lblVencimentoContaNova)
        Me.Controls.Add(Me.lblValorContaNova)
        Me.Controls.Add(Me.lblEmpresaContaNova)
        Me.Controls.Add(Me.txtTipoContaNova)
        Me.Controls.Add(Me.lblTipoContaNova)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNovaConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nova Conta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTipoContaNova As Label
    Friend WithEvents txtTipoContaNova As TextBox
    Friend WithEvents lblEmpresaContaNova As Label
    Friend WithEvents lblValorContaNova As Label
    Friend WithEvents lblVencimentoContaNova As Label
    Friend WithEvents txtEmpresaContaNova As TextBox
    Friend WithEvents btnSalvarContaNova As Button
    Friend WithEvents txtValorContaNova As TextBox
    Friend WithEvents dtpVencimentoContaNova As DateTimePicker
    Friend WithEvents lblJurosConta As Label
    Friend WithEvents txtJurosConta As TextBox
    Friend WithEvents txtJurosContaMes As TextBox
    Friend WithEvents txtJurosContaDia As TextBox
    Friend WithEvents lblJurosContaMes As Label
    Friend WithEvents lblJurosContaDia As Label
End Class
