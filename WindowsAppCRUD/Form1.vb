Public Class Form1
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            create("INSERT INTO utilizadores(nome, utilizador, senha, nivel) VALUES ('" & TxtNome.Text & "','" & TxtUtilizador.Text & "','" & TxtSenha.Text & "'," & CInt(Cbnivel.SelectedIndex) + 1 & ")")
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        Try
            Reload("SELECT * FROM utilizadores ORDER BY ID ASC", DgLista)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Updates("UPDATE utilizadores SET nome='" & TxtNome.Text & "'," & "utilizador='" & TxtUtilizador.Text & "', " & "senha='" & TxtSenha.Text & "', " & "nivel=" & Cbnivel.SelectedIndex & "WHERE id=" & LbIed.Text)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Delete("DELETE FROM utilizadores WHERE id=" & LbIed.Text)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'Dbusers1DataSet.utilizadores'. Você pode movê-la ou removê-la conforme necessário.
        'Me.UtilizadoresTableAdapter.Fill(Me.Dbusers1DataSet.utilizadores)

    End Sub

    Private Sub DgLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgLista.DoubleClick
        LbIed.Text = DgLista.CurrentRow.Cells(0).Value
        TxtNome.Text = DgLista.CurrentRow.Cells(1).Value
        TxtSenha.Text = DgLista.CurrentRow.Cells(2).Value
        TxtUtilizador.Text = DgLista.CurrentRow.Cells(3).Value
        Cbnivel.Text = DgLista.CurrentRow.Cells(4).Value
    End Sub
End Class
