<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="UI._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="panel-default">
        <div class="panel-heading">
            <asp:Label runat="server" ID="lblmsg">Texto aqui para testes.</asp:Label>
        </div>
        <form id="form1" runat="server">
            <div class="panel-body">
                <div class="col-md-3">
                    <label>Código: </label> 
                    <asp:TextBox runat="server" class="form-control" ID="txtId"></asp:TextBox>
                    <asp:Button runat="server" class="form-control" Text="Localizar" ID="btnLocalizar" />
                </div>
                <div class="clearfix"></div>
            

                <div class="col-md-3">
                    <label>Nome: </label> 
                    <asp:TextBox runat="server" class="form-control" ID="txtNome"></asp:TextBox>
                </div>
            
                <div class="col-md-3">
                    <label>Endereço: </label> 
                    <asp:TextBox runat="server" class="form-control" ID="txtEndereco"></asp:TextBox>
                </div>

                <div class="col-md-3">
                    <label>Telefone: </label> 
                    <asp:TextBox runat="server" class="form-control" ID="txtTelefone"></asp:TextBox>
                </div>
            
                <div class="col-md-3">
                    <label>E-mail: </label> 
                    <asp:TextBox runat="server" class="form-control" ID="txtEmail"></asp:TextBox>
                </div>
            
                <div class="col-md-3">
                    <label>Observação: </label> 
                    <asp:TextBox runat="server" class="form-control" ID="txtObservacao"></asp:TextBox>
                </div>
                <div class="clearfix"></div>
                <div class="">
                <div class="col-md-3">
                <asp:Button runat="server" Text="Incluir" class="form-control" ID="btnIncluir" />
                </div>
                <div class="col-md-3">
                <asp:Button runat="server" Text="Alterar" class="form-control" ID="btnAlterar" />
                </div>
                <div class="col-md-3">
                <asp:Button runat="server" Text="Excluir" class="form-control" ID="btnExcluir" />
                </div>
                <div class="col-md-3">
                <asp:Button runat="server" Text="Sair" class="form-control" ID="btnSair" />
                </div>
            </div>
            </div>
            <div class="">
                <asp:GridView runat="server"  ID="gvClientes" class="table-responsive table table-bordered" AutoGenerateColumns="true">

                </asp:GridView>
            </div>
            
        </form>
    </div>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
