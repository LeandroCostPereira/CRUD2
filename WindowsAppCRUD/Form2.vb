Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnome.Select()
        Me.btnreload.PerformClick()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Try
            create("INSERT INTO utilizadores(nome, utilizador, senha, nivel) VALUES ('" & txtnome.Text & "','" & txtutilizador.Text & "','" & txtsenha.Text & "'," & CInt(cbnivel.SelectedIndex) + 1 & ")")
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnreload_Click(sender As Object, e As EventArgs) Handles btnreload.Click
        Try
            Reload("SELECT * FROM utilizadores ORDER BY ID ASC", DgLista)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Try
            Updates("UPDATE utilizadores SET nome='" & txtnome.Text & "'," & "utilizador='" & txtutilizador.Text & "', " & "senha='" & txtsenha.Text & "', " & "nivel=" & cbnivel.SelectedIndex & "WHERE id=" & lblId.Text)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Delete("DELETE FROM utilizadores WHERE id=" & lblId.Text)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dglista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dglista.CellContentClick
        lblId.Text = dglista.CurrentRow.Cells(0).Value
        txtnome.Text = dglista.CurrentRow.Cells(1).Value
        txtsenha.Text = dglista.CurrentRow.Cells(2).Value
        txtutilizador.Text = dglista.CurrentRow.Cells(3).Value
        cbnivel.Text = dglista.CurrentRow.Cells(4).Value
    End Sub
End Class