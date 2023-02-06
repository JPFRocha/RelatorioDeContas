Imports MySqlConnector
Imports MySqlCommand = MySqlConnector.MySqlCommand
Imports MySqlConnection = MySqlConnector.MySqlConnection

Public Class frmNovaConta
    Private Sub frmNovaConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GravarDados()

        Using con As MySqlConnection = PegaConexao()
            Try
                con.Open()
                Dim sql As String = "INSERT INTO TabelaDeContas (TipoDaConta, Empresa, ValorDaConta, VencimentoDaConta, MultaAtraso, JurosMes, JurosDia, Pago, DataCadastro) VALUES (@TipoDaConta, @Empresa, @ValorDaConta, @VencimentoDaConta, @MultaAtraso, @JurosMes, @JurosDia, @Pago, @DataCadastro);"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)

                Dim paramTipoDaConta As MySqlParameter
                Dim paramEmpresa As MySqlParameter
                Dim paramValorDaConta As MySqlParameter
                Dim paramVencimentoDaConta As MySqlParameter
                Dim paramMultaAtraso As MySqlParameter
                Dim paramJurosMes As MySqlParameter
                Dim paramJurosDia As MySqlParameter
                Dim paramPago As MySqlParameter
                Dim paramCadastro As MySqlParameter

                paramTipoDaConta = cmd.Parameters.Add("TipoDaConta", MySqlDbType.VarChar, 100)
                paramEmpresa = cmd.Parameters.Add("Empresa", MySqlDbType.VarChar, 100)
                paramValorDaConta = cmd.Parameters.Add("ValorDaConta", MySqlDbType.Decimal, 10.2)
                paramVencimentoDaConta = cmd.Parameters.Add("VencimentoDaConta", MySqlDbType.Date)
                paramMultaAtraso = cmd.Parameters.Add("MultaAtraso", MySqlDbType.Decimal, 10.2)
                paramJurosMes = cmd.Parameters.Add("JurosMes", MySqlDbType.Decimal, 10.2)
                paramJurosDia = cmd.Parameters.Add("JurosDia", MySqlDbType.Decimal, 10.2)
                paramPago = cmd.Parameters.Add("Pago", MySqlDbType.Bit)
                paramCadastro = cmd.Parameters.Add("DataCadastro", MySqlDbType.DateTime)

                paramTipoDaConta.Value = txtTipoContaNova.Text
                paramEmpresa.Value = txtEmpresaContaNova.Text
                paramValorDaConta.Value = txtValorContaNova.Text
                paramVencimentoDaConta.Value = dtpVencimentoContaNova.Value
                paramMultaAtraso.Value = txtJurosConta.Text
                paramJurosMes.Value = txtJurosContaMes.Text
                paramJurosDia.Value = txtJurosContaDia.Text
                paramPago.Value = False
                paramCadastro.Value = Now
                cmd.ExecuteNonQuery()
                MsgBox("Dados salvos com sucesso.", MsgBoxStyle.Information, "Contas")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub btnSalvarContaNova_Click(sender As Object, e As EventArgs) Handles btnSalvarContaNova.Click
        GravarDados()
    End Sub
End Class