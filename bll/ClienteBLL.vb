
Imports DAL
Imports DTO
Public Class ClienteBLL
    Implements ICliente(Of Cliente)
    Public Function GetClienteId(id As Integer) As Cliente Implements ICliente(Of Cliente).GetClienteId
        Try
            Dim sql As String = "SELECT IdCliente,Nome,Endereco,Telefone,Email,Observacao FROM Clientes WHERE IdCliente = " & id
            Dim tabela As New DataTable
            tabela = AcessoDb.GetDataTable(sql)
            Return GetCliente(tabela)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetCliente(ByVal tabela As DataTable) As Cliente
        Try
            Dim _Cliente As New Cliente
            If tabela.Rows.Count > 0 Then
                _Cliente.Id = tabela.Rows(0).Item(0)
                _Cliente.nome = tabela.Rows(0).Item(1)
                _Cliente.endereco = tabela.Rows(0).Item(2)
                _Cliente.telefone = tabela.Rows(0).Item(3)
                _Cliente.email = tabela.Rows(0).Item(4)
                _Cliente.observacao = tabela.Rows(0).Item(5)
                Return _Cliente
            Else
                _Cliente = Nothing
                Return _Cliente
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Exibir() As List(Of Cliente) Implements ICliente(Of Cliente).Exibir
        Try
            Dim sql As String = "SELECT * FROM Clientes"
            Dim tabela As New DataTable
            tabela = AcessoDb.GetDataTable(sql)
            Return GetListaCliente(tabela)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function GetListaCliente(ByVal tabela As DataTable) As List(Of Cliente)
        Try
            Dim listaCliente As New List(Of Cliente)
            Dim i As Integer = 0
            Dim registros = tabela.Rows.Count
            If registros > 0 Then
                For Each drRow As DataRow In tabela.Rows
                    Dim _Cliente As New Cliente
                    _Cliente.Id = tabela.Rows(i).Item(0)
                    _Cliente.nome = tabela.Rows(i).Item(1)
                    _Cliente.endereco = tabela.Rows(i).Item(2)
                    _Cliente.telefone = tabela.Rows(i).Item(3)
                    _Cliente.email = tabela.Rows(i).Item(4)
                    _Cliente.observacao = tabela.Rows(i).Item(5)
                    listaCliente.Add(_Cliente)
                Next
                While i <= registros
                    Dim _Cliente As New Cliente
                    _Cliente.Id = tabela.Rows(i).Item(0)
                    _Cliente.nome = tabela.Rows(i).Item(1)
                    _Cliente.endereco = tabela.Rows(i).Item(2)
                    _Cliente.telefone = tabela.Rows(i).Item(3)
                    _Cliente.email = tabela.Rows(i).Item(4)
                    _Cliente.observacao = tabela.Rows(i).Item(5)
                    listaCliente.Add(_Cliente)
                    i += i
                End While
                Return listaCliente
            Else
                listaCliente = Nothing
                Return listaCliente
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Consultar(nome As String) As DataTable Implements ICliente(Of Cliente).Consultar
        Dim sql As String = "SELECT IdCliente,Nome FROM Clientes WHERE Nome LIKE '" & nome & "%'" & " ORDER BY Nome"
        Try
            Return AcessoDb.GetDataTable(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub Incluir(oCliente As Cliente) Implements ICliente(Of Cliente).Incluir
        Dim sql As String = ""
        Try
            Dim parametrosNomes(5) As String
            parametrosNomes(0) = "@Nome"
            parametrosNomes(1) = "@Endereco"
            parametrosNomes(2) = "@Telefone"
            parametrosNomes(3) = "@Email"
            parametrosNomes(4) = "@Observacao"
            Dim parametrosValores(5) As String
            parametrosValores(0) = oCliente.nome
            parametrosValores(1) = oCliente.endereco
            parametrosValores(2) = oCliente.telefone '
            parametrosValores(3) = oCliente.email
            parametrosValores(4) = oCliente.observacao
            sql = "INSERT INTO Clientes(Nome,Endereco,Telefone,Email,Observacao) values (@Nome,@Endereco,@Telefone,@Email,@Observacao)"
            AcessoDb.CRUD(sql, parametrosNomes, parametrosValores)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Alterar(oCliente As Cliente) Implements ICliente(Of Cliente).Alterar
        Dim sql As String = ""
        Try
            Dim parametrosNomes(6) As String
            parametrosNomes(0) = "@Id"
            parametrosNomes(1) = "@Nome"
            parametrosNomes(2) = "@Endereco"
            parametrosNomes(3) = "@Telefone"
            parametrosNomes(4) = "@Email"
            parametrosNomes(5) = "@Observacao"
            Dim parametrosValores(6) As String
            parametrosValores(0) = oCliente.Id
            parametrosValores(1) = oCliente.nome
            parametrosValores(2) = oCliente.endereco
            parametrosValores(3) = oCliente.telefone '
            parametrosValores(4) = oCliente.email
            parametrosValores(5) = oCliente.observacao
            sql = "UPDATE Clientes SET Nome=@Nome, Endereco=@Endereco ,Telefone=@Telefone,Email=@Email , Observacao=@Observacao Where IdCliente=@Id"
            AcessoDb.CRUD(sql, parametrosNomes, parametrosValores)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Excluir(oCliente As Cliente) Implements ICliente(Of Cliente).Excluir
        Dim sql As String = ""
        Try
            Dim parametrosNomes(0) As String
            parametrosNomes(0) = "@Id"
            Dim parametrosValores(0) As String
            parametrosValores(0) = oCliente.Id
            sql = "DELETE FROM Clientes Where IdCliente=@Id"
            AcessoDb.CRUD(sql, parametrosNomes, parametrosValores)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function ExibirTodos() As DataTable Implements ICliente(Of Cliente).ExibirTodos
        Dim sql As String = "SELECT * FROM Clientes"
        Try
            Return AcessoDb.GetDataTable(sql)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class