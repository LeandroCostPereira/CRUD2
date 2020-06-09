Imports System.Data.SqlClient
Module CRUD

    'declarar s ligaçao á BD
    Public Function strligaçao() As SqlConnection
        Return New SqlConnection("Data Source = (LocalDB) \ MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Dbusers1.mdf;Integrated Security=True")

    End Function
    'declarar variavel global para establecer ligaçao
    Public strConexao As SqlConnection = strligaçao()
    'declarar classes e variaveis para o dataset
    Public resultado As String
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public dt As New DataTable
    'este metodo é para inserir um novo registo
    Public Sub create(ByVal comando As String)
        Try
            'abrir coneçao
            strConexao.Open()
            'reter a intruçao a ser executada
            With cmd
                .Connection = strConexao
                .CommandText = comando
                ' executar a instruçao
                resultado = cmd.ExecuteNonQuery
                If resultado = 0 Then
                    MessageBox.Show("Falhou a operaçao de inserir os dados.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Os dados foram inseridos com sucesso.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(comando)
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'fechar a ligaçao
        strConexao.Close()
    End Sub
    'este metodo é para ler os dados de uma tabela da BD
    ' e com ele vamos tambem atualizar o dataGridView
    Public Sub Reload(ByVal comando As String, grelha As Object)
        Try
            dt = New DataTable
            strConexao.Open()
            With cmd
                .Connection = strConexao
                .CommandText = comando
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            grelha.dataSource = dt
        Catch ex As Exception
            'em caso de erro na ligaçao
            MessageBox.Show("Erros" & vbNewLine & ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'fechar a ligaçao
        strConexao.Close()
        'libertar dados em memoria
        da.Dispose()
    End Sub
    ' este metudo para atualizar os dados de uma tabela da BD
    Public Sub Updates(ByVal comando As String)
        Try
            strConexao.Open()
            With cmd
                .Connection = strConexao
                .CommandText = comando
                'executar a instruçao
                resultado = cmd.ExecuteNonQuery
                ' verificar  se a instruçao foi corretamente executada
                If resultado = 0 Then
                    MessageBox.Show("Falhou a operaçao de atualizar os dados", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Os dados foram atualizados com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            'em caso de erro na ligaçao
            MessageBox.Show("ERRO" & vbNewLine & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        strConexao.Close()
    End Sub
    ' este metodo é para eliminar dados de uma tabela BD
    Public Sub Delete(ByVal comando As String)
        Try
            strConexao.Open()
            With cmd
                .Connection = strConexao
                .CommandText = comando
                'executar a instruçao
                resultado = cmd.ExecuteNonQuery
                'verificar se  a instruçao foi corretamente excutada
                If resultado = 0 Then
                    MessageBox.Show("Falhou a operaçao de eliminar os dados.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Os dados foram eleminados com sucesso.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            'caso de erro na ligaçao
            MessageBox.Show("Erro" & vbNewLine & ex.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        strConexao.Close()
    End Sub
End Module