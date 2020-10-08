﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Clients.aspx.vb" Inherits="ClientsWebApp.Clients" %>
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
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" ID="ClientName"></asp:TextBox>

                                </div>

                            </div>

                              <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label  Text="Apellido" runat="server"></asp:Label>
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" ID="ClientLastName"></asp:TextBox>

                                </div>

                            </div>
                        </div>

                         <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label  Text="Email" runat="server"></asp:Label>
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" ID="ClientEmail"></asp:TextBox>

                                </div>

                            </div>

                              <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label  Text="Telefono" runat="server"></asp:Label>
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" ID="ClientPhone"></asp:TextBox>

                                </div>

                            </div>
                        </div>


                          <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="form-group">
                                    <asp:Label  Text="Dirección" runat="server"></asp:Label>
                                    <asp:TextBox runat="server" Enabled="true" CssClass="form-control input-sm" ID="ClientAddress"></asp:TextBox>

                                </div>

                            </div>

                            
                        </div>

                          <div class="row">
                            <div class="col-md-12 col-md-offset-1 center">
                                <div class="form-group">
                                     <asp:Button  runat="server" CssClass="btn btn-success" Text="Guardar"  ID="Save_Btn"/>
                                     <asp:Label ID="Respuesta" runat="server" ></asp:Label>
                                </div>

                            </div>

                            
                        </div>


                           <div class="row">
                            <div class="col-md-12 col-md-offset-1 center">
                                <asp:GridView ID="GridView1" runat="server" CssClass="table table-striped"  BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnRowEditing="OnRowEditing" AutoGenerateColumns="False" AutoGenerateEditButton="True">
                                    <AlternatingRowStyle BackColor="#CCCCCC" />
                                    <FooterStyle BackColor="#CCCCCC" />
                                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                    <SortedAscendingHeaderStyle BackColor="#808080" />
                                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                    <SortedDescendingHeaderStyle BackColor="#383838" />
                                    <Columns>
                                      
                                        <asp:TemplateField Visible="false">
                                            <ItemTemplate>
                                                  <asp:Label id="HdnClientId" runat ="server" text='<%# Eval("ClientId")%>'></asp:Label>
                                            

                                                </ItemTemplate>
                                        </asp:TemplateField>
                                       

                                        <asp:TemplateField HeaderText="Nombre" >
                                            <ItemTemplate>
                                                <%#Eval("FirstName") %>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:TextBox ID="FirstName" Text='<%#Eval("FirstName") %>' runat="server"></asp:TextBox>
                                                </EditItemTemplate>
                                        </asp:TemplateField>                                  





                                          <asp:TemplateField HeaderText="Apellido" >
                                            <ItemTemplate>
                                                <%#Eval("LastName") %>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:TextBox ID="LastName" Text='<%#Eval("LastName") %>' runat="server"></asp:TextBox>
                                                </EditItemTemplate>
                                        </asp:TemplateField>
                                                                            


                                             <asp:TemplateField HeaderText="Correo" >
                                            <ItemTemplate>
                                                <%#Eval("Email") %>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:TextBox ID="Email" Text='<%#Eval("Email") %>' runat="server"></asp:TextBox>
                                                </EditItemTemplate>
                                        </asp:TemplateField>


                                               <asp:TemplateField HeaderText="Teléfono" >
                                            <ItemTemplate>
                                                <%#Eval("Phone") %>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:TextBox ID="Phone" Text='<%#Eval("Phone") %>' runat="server"></asp:TextBox>
                                                </EditItemTemplate>
                                        </asp:TemplateField>                  

                                          <asp:TemplateField HeaderText="Teléfono" >
                                            <ItemTemplate>
                                                <%#Eval("OfficeAddress") %>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:TextBox ID="OfficeAddress" Text='<%#Eval("OfficeAddress") %>' runat="server"></asp:TextBox>
                                                </EditItemTemplate>
                                        </asp:TemplateField>



                                    </Columns>
                                </asp:GridView>

                            </div>

                            
                        </div>



                    </div>
                </section>

            </div>
        </div>

    </section>

</section>
</asp:Content>
