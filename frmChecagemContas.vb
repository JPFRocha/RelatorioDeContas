Imports MySqlCommand = MySqlConnector.MySqlCommand
Imports MySqlConnection = MySqlConnector.MySqlConnection
Imports MySqlDataAdapter = MySqlConnector.MySqlDataAdapter
Imports MySqlConnector
Public Class frmAdicionarContas
    Public strSQL As String = "SELECT * FROM TabelaDeContas"
    Private conexaoSQL As String = "server=bd-joao.mysql.uhserver.com;user id=joaopaulo21;password=KoP7458+.-;database=bd_joao;sslmode=None"
    Dim ds As DataSet

    Private Sub frmChecagemContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaInformacoes()

    End Sub
    Private Sub CarregaInformacoes()
        CarregaDados()
        If dgvContas.Rows.Count >= 1 Then
            AbrirContasToolStripMenuItem.Enabled = True
        End If
        CalculaTotalDeContas()
    End Sub
    Private Sub CarregaDados()
        Using con As MySqlConnection = PegaConexao()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM TabelaDeContas ORDER BY VencimentoDaConta"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvContas.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub CarregaContasPagas()
        Using con As MySqlConnection = PegaConexao()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM TabelaDeContas WHERE Pago = True ORDER BY VencimentoDaConta"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvContas.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub CarregaContasNãoPagas()
        Using con As MySqlConnection = PegaConexao()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM TabelaDeContas WHERE Pago = False ORDER BY VencimentoDaConta"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvContas.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub CarregaContasVencidas()
        Using con As MySqlConnection = PegaConexao()
            Try
                con.Open()
                Dim sql As String = "SELECT * FROM TabelaDeContas WHERE VencimentoDaConta < DataCadastro ORDER BY VencimentoDaConta"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvContas.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub CalculaTotalDeContas()
        Dim totalValor As Double
        For Each linha As DataGridViewRow In dgvContas.Rows
            totalValor = totalValor + linha.Cells("ValorDaConta").Value
        Next
        txtTotalContas.Text = FormatCurrency(totalValor)
    End Sub

    Private Sub CalculaMulta()
        If frmPagarConta.cboPagoPagamento.Enabled = True Then
            Exit Sub
        End If
        Dim valorConta As Double
        Dim multaAtraso As Double
        Dim valorMultaAtraso As Double
        Dim valorFinalAtraso As Double

        valorConta = dgvContas.CurrentRow.Cells(3).Value
        multaAtraso = dgvContas.CurrentRow.Cells(5).Value / 100
        valorMultaAtraso = valorConta * multaAtraso
        valorFinalAtraso = valorConta + valorMultaAtraso

        frmPagarConta.txtValorContaPagamento.Text = FormatCurrency(valorConta)
        frmPagarConta.txtValorJurosPagamento.Text = FormatCurrency(multaAtraso)
        frmPagarConta.txtValorTotalContaPagamento.Text = FormatCurrency(valorFinalAtraso)
    End Sub

    Private Sub CalculaJurosMes()
        If dgvContas.CurrentRow.Cells(6).Value = 0 Then
            Exit Sub
        End If

        If frmPagarConta.cboPagoPagamento.Enabled = True Then
            Exit Sub
        End If
        Dim valorConta As Double
        Dim jurosMes As Double
        Dim valorFinalMes As Double
        Dim mes = DateDiff("m", dgvContas.CurrentRow.Cells(4).Value, Today())

        valorConta = dgvContas.CurrentRow.Cells(3).Value
        jurosMes = dgvContas.CurrentRow.Cells(6).Value / 100
        valorFinalMes = valorConta + (mes * jurosMes)

        frmPagarConta.txtValorContaPagamento.Text = FormatCurrency(valorConta)
        frmPagarConta.txtValorJurosPagamento.Text = FormatCurrency(jurosMes)
        frmPagarConta.txtValorTotalContaPagamento.Text = FormatCurrency(valorFinalMes)
    End Sub

    Private Sub CalculaJurosDia()
        If dgvContas.CurrentRow.Cells(7).Value = 0 Then
            Exit Sub
        End If

        If frmPagarConta.cboPagoPagamento.Enabled = True Then
            Exit Sub
        End If
        Dim valorConta As Double
        Dim jurosDia As Double
        Dim valorFinalDia As Double
        Dim dia = DateDiff("d", dgvContas.CurrentRow.Cells(4).Value, Today())

        valorConta = dgvContas.CurrentRow.Cells(3).Value
        jurosDia = dgvContas.CurrentRow.Cells(7).Value / 100
        valorFinalDia = valorConta + (dia * jurosDia)

        frmPagarConta.txtValorContaPagamento.Text = FormatCurrency(valorConta)
        frmPagarConta.txtValorJurosPagamento.Text = FormatCurrency(jurosDia)
        frmPagarConta.txtValorTotalContaPagamento.Text = FormatCurrency(valorFinalDia)
    End Sub

    Private Sub AtualizaTabela()

        ' se houve mudanças no dataset então ...
        If ds.HasChanges() Then

            Dim da As MySqlDataAdapter
            Dim cmdb As MySqlCommandBuilder

            ' Cria o DataAdapter
            da = New MySqlDataAdapter(strSQL, conexaoSQL)

            ' Mapeia a tabela para TabelaDeContas.
            da.TableMappings.Add("Table", "TabelaDeContas")

            ' usa o CommandBuilder para gerar os comandos para 
            ' incluir , atualizar e excluir
            ' sem este comando a atualização vai falhar...
            cmdb = New MySqlCommandBuilder(da)

            ' Salva as alterações
            da.Update(ds)
        End If

    End Sub


    Private Sub NovaContaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovaContaToolStripMenuItem.Click
        frmNovaConta.Show()
    End Sub

    Private Sub PagarContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagarContasToolStripMenuItem.Click
        frmPagarConta.txtIdDaContaPagamento.Text = dgvContas.CurrentRow.Cells(0).Value
        frmPagarConta.txtTipoDaContaPagamento.Text = dgvContas.CurrentRow.Cells(1).Value
        frmPagarConta.txtEmpresaDaContaPagamento.Text = dgvContas.CurrentRow.Cells(2).Value
        frmPagarConta.txtValorDaContaPagamento.Text = dgvContas.CurrentRow.Cells(3).Value
        frmPagarConta.txtVencimentoDaContaPagamento.Text = dgvContas.CurrentRow.Cells(4).Value
        frmPagarConta.txtMultaAtrasoPagamento.Text = dgvContas.CurrentRow.Cells(5).Value
        frmPagarConta.txtJurosMesPagamento.Text = dgvContas.CurrentRow.Cells(6).Value
        frmPagarConta.txtJurosDiaPagamento.Text = dgvContas.CurrentRow.Cells(7).Value
        frmPagarConta.cboPagoPagamento.Checked = dgvContas.CurrentRow.Cells(8).Value
        frmPagarConta.txtDataCadastroPagamento.Text = dgvContas.CurrentRow.Cells(9).Value
        CalculaMulta()
        CalculaJurosMes()
        CalculaJurosDia()
        frmPagarConta.Show()
    End Sub
    Private Sub rbtnTodasContas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTodasContas.CheckedChanged
        CarregaDados()
    End Sub
    Private Sub rbtnPago_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPago.CheckedChanged
        CarregaContasPagas()
    End Sub

    Private Sub rbtnContasNaoPagas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnContasNaoPagas.CheckedChanged
        CarregaContasNãoPagas()
    End Sub

    Private Sub rbtnContasVencidas_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnContasVencidas.CheckedChanged
        CarregaContasVencidas()
    End Sub

    Private Sub AtualizarNúmeroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtualizarNúmeroDeContasToolStripMenuItem.Click
        AtualizaTabela()
    End Sub
End Class