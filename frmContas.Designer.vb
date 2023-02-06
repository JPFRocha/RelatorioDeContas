<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContas))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistrarContaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbImagemFundo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbImagemFundo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarContaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 58)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistrarContaToolStripMenuItem
        '
        Me.RegistrarContaToolStripMenuItem.AutoSize = False
        Me.RegistrarContaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.RegistrarContaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RegistrarContaToolStripMenuItem.Image = CType(resources.GetObject("RegistrarContaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrarContaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistrarContaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.RegistrarContaToolStripMenuItem.Name = "RegistrarContaToolStripMenuItem"
        Me.RegistrarContaToolStripMenuItem.ShowShortcutKeys = False
        Me.RegistrarContaToolStripMenuItem.Size = New System.Drawing.Size(122, 54)
        Me.RegistrarContaToolStripMenuItem.Text = "Registrar Conta"
        Me.RegistrarContaToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RegistrarContaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'pbImagemFundo
        '
        Me.pbImagemFundo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbImagemFundo.BackgroundImage = Global.Relatório_de_Contas.My.Resources.Resources.super_mario_capa_galeria_2020
        Me.pbImagemFundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImagemFundo.ErrorImage = Nothing
        Me.pbImagemFundo.InitialImage = Nothing
        Me.pbImagemFundo.Location = New System.Drawing.Point(0, 61)
        Me.pbImagemFundo.Name = "pbImagemFundo"
        Me.pbImagemFundo.Size = New System.Drawing.Size(800, 390)
        Me.pbImagemFundo.TabIndex = 3
        Me.pbImagemFundo.TabStop = False
        '
        'frmContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbImagemFundo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relação de Contas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbImagemFundo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents pbImagemFundo As PictureBox
    Friend WithEvents RegistrarContaToolStripMenuItem As ToolStripMenuItem
End Class
