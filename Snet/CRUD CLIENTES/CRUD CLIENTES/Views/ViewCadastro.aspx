<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewCadastro.aspx.cs" Inherits="CRUD_CLIENTES.Views.WebForm1" %>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<!DOCTYPE html>
<head>

    <title>Cadastro de clientes</title>

</head>
<body>

    <form class="form-horizontal" runat="server">
        <fieldset>
            <div class="panel panel-primary">
                <div class="panel-heading">Cadastro de Cliente</div>

                <div class="panel-body">
                    <div class="form-group">

                        <div class="form-group">
                            <asp:Label class="col-md-2 control-label" runat="server" Text="Nome *" Font-Bold="True" />

                            <div class="col-md-8">
                                <asp:TextBox runat="server" ID="txtNome" class="form-control input-md" />
                            </div>
                        </div>


                        <!-- Prepended text-->
                        <div class="form-group">
                            <asp:Label runat="server" Text="Telefone:" class="col-md-2 control-label" for="prependedtext">
                                
                            </asp:Label>
                            <div class="col-md-2">
                                <div class="input-group">
                                    <span class="input-group-addon"><i class="glyphicon glyphicon-earphone"></i></span>
                                    <asp:TextBox runat="server" ID="txtTelefone" name="prependedtext" class="form-control" />

                                </div>
                            </div>

                        </div>



                        <!-- Search input-->
                        <div class="form-group">
                            <asp:Label runat="server" class="col-md-2 control-label" Text="CEP:" Font-Bold="True" />

                            <div class="col-md-2">
                                <asp:TextBox runat="server" ID="txtCep" name="cep" placeholder="Apenas números" class="form-control input-md" />
                            </div>
                            <div class="col-md-2">
                                <asp:Button runat="server" ID="btBuscarCep" class="btn btn-primary" Text="Pesquisar" OnClick="Unnamed5_Click"></asp:Button>
                                <asp:Label runat="server" ID="lbErro" />
                            </div>
                        </div>

                        <!-- Prepended text-->
                        <div class="form-group">
                            <asp:Label class="col-md-2 control-label" runat="server" />
                            <div class="col-md-4">
                                <div class="input-group">
                                    <span class="input-group-addon">Rua</span>
                                    <asp:TextBox runat="server" ID="txtRua" name="rua" class="form-control" placeholder="" type="text" />
                                </div>

                            </div>
                            <div class="col-md-2">
                                <div class="input-group">
                                    <span class="input-group-addon">Nº
                                        <h11>*</h11>
                                    </span>
                                    <asp:TextBox runat="server" ID="txtNumero" name="numero" class="form-control" placeholder="" type="text" />
                                </div>

                            </div>

                            <div class="col-md-3">
                                <div class="input-group">
                                    <span class="input-group-addon">Bairro</span>
                                    <asp:TextBox runat="server" ID="txtBairro" name="bairro" class="form-control" placeholder="" type="text" />
                                </div>

                            </div>
                        </div>

                        <div class="form-group">
                            <label class="col-md-2 control-label" for="prependedtext"></label>
                            <div class="col-md-4">
                                <div class="input-group">
                                    <span class="input-group-addon">Cidade</span>
                                    <asp:TextBox runat="server" ID="txtcidade" name="cidade" class="form-control" placeholder="" type="text" />
                                </div>

                            </div>

                            <div class="col-md-2">
                                <div class="input-group">
                                    <span class="input-group-addon">Estado</span>
                                    <asp:TextBox runat="server" ID="txtestado" name="estado" class="form-control" placeholder="" type="text" />
                                </div>

                            </div>

                            <div class="col-md-3">
                                <div class="input-group">
                                    <span class="input-group-addon">País:</span>
                                    <asp:TextBox runat="server" ID="txtPais" name="bairro" class="form-control" placeholder="" type="text" />
                                </div>

                            </div>

                        </div>

                        <!-- Button (Double) -->
                        <div class="form-group">
                            <label class="col-md-2 control-label" for="Cadastrar"></label>
                            <div class="col-md-8">
                                <asp:Button runat="server" ID="Cadastrar" name="Cadastrar" class="btn btn-success" type="Submit" Text="Cadastrar" OnClick="Cadastrar_Click"></asp:Button>
                                <asp:Button runat="server" ID="Cancelar" name="Cancelar" class="btn btn-danger" type="Reset" Text="Cancelar"></asp:Button>


                                <br />
                                <br />
                                <asp:GridView ID="tbCliente" runat="server" AutoGenerateColumns="false" class="table" OnSelectedIndexChanged="tbCliente_SelectedIndexChanged">

                                    <Columns>
                                        <asp:BoundField DataField="nome" HeaderText="Nome" />
                                        <asp:BoundField DataField="telefone" HeaderText="Telefone" />
                                        <asp:BoundField DataField="endereco" HeaderText="Endereco" />
                                        <asp:BoundField DataField="bairro" HeaderText="Bairro" />
                                        <asp:BoundField DataField="cep" HeaderText="Cep" />

                                        <asp:TemplateField>

                                            <ItemTemplate>
                                                <asp:Button runat="server" Text="Selecionar" CommandArgument="" />
                                            </ItemTemplate>

                                        </asp:TemplateField>

                                    </Columns>


                                    <HeaderStyle Width="70%" />


                                </asp:GridView>

                            </div>
                        </div>
                        <br />




                    </div>
                </div>
        </fieldset>
    </form>

</body>
</html>
