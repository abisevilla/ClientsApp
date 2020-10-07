<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Clients.aspx.vb" Inherits="ClientsWebApp.Clients" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


<section id="main-content">
    <section id="wrapper">
        <div class="row">

            <div class="col-lg-12">
                <section class="panel"> 

                    <header class="panel-heading">

                        <div class="col-md-4 col-md-offset-4">
                            <h1>Clientes</h1>

                        </div>
                    </header>


                    <div class="panel-body">
                        <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label  Text="Nombre" runat="server"></asp:Label>
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm"></asp:TextBox>

                                </div>

                            </div>

                              <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label  Text="Apellido" runat="server"></asp:Label>
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm"></asp:TextBox>

                                </div>

                            </div>
                        </div>

                         <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label  Text="Email" runat="server"></asp:Label>
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm"></asp:TextBox>

                                </div>

                            </div>

                              <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label  Text="Telefono" runat="server"></asp:Label>
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm"></asp:TextBox>

                                </div>

                            </div>
                        </div>


                          <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label  Text="Dirección" runat="server"></asp:Label>
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm"></asp:TextBox>

                                </div>

                            </div>

                            
                        </div>

                          <div class="row">
                            <div class="col-md-12 col-md-offset-1 center">
                                <div class="form-group">
                                     <asp:Button  runat="server" CssClass="btn btn-success" Text="Guardar"/>

                                </div>

                            </div>

                            
                        </div>


                           <div class="row">
                            <div class="col-md-12 col-md-offset-1 center">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" CssClass="table table-striped"></asp:GridView>

                            </div>

                            
                        </div>



                    </div>
                </section>

            </div>
        </div>

    </section>

</section>
</asp:Content>
