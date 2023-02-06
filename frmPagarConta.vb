Public Class frmPagarConta
    Private Sub frmPagarConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPagamento.Enabled = False
        If cboPagoPagamento.Checked = True Then
            btnPagamento.Enabled = False
        End If

        If cboPagoPagamento.Checked = True Then
            rbtnCartao.Enabled = False
            rbtnDinheiro.Enabled = False
            rbtnPix.Enabled = False
        End If
    End Sub

    Private Sub rbtnDinheiro_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDinheiro.CheckedChanged

        If rbtnDinheiro.Checked = True Then
            btnPagamento.Enabled = True
        End If
    End Sub

    Private Sub rbtnCartao_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCartao.CheckedChanged

        If rbtnCartao.Checked = True Then
            btnPagamento.Enabled = True
        End If
    End Sub

    Private Sub rbtnPix_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPix.CheckedChanged

        If rbtnPix.Checked = True Then
            btnPagamento.Enabled = True
        End If
    End Sub

    Private Sub btnCalculoDeDias_Click(sender As Object, e As EventArgs) Handles btnCalculoDeDias.Click
        Dim resultado = DateDiff("d", txtVencimentoDaContaPagamento.Text, Today())
        If resultado > 0 Then
            MsgBox("Conta Atrasada em " & resultado & " dias.")
        Else
            MsgBox("Vencimento em " & (-1) * resultado & " dias.")
        End If
    End Sub
End Class