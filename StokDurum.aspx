<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="StokDurum.aspx.cs" Inherits="stoktakip2.StokDurum" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Stok Durum</h3>
        </div>
        <!-- /.col-lg-12 -->
    </div>


    <div class="row">

        <div class="col-lg-12">

            <div class="panel panel-info">
                <div class="panel-heading">
                    Stok Durum                       
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <%-- <asp:Repeater ID="rptStok" runat="server">
                        
                    </asp:Repeater>--%>


                    <asp:Repeater ID="Repeater1" runat="server">
                        <HeaderTemplate>

                            <table width="100%" class="table table-striped table-bordered table-hover" id="dataTables-example">
                                <thead>
                                    <tr>

                                        <th>Ürün Adı</th>
                                        <th>Depo Adı</th>
                                        <th>Miktar</th>
                                        <th>Ölçü Birimi</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>

                        <ItemTemplate>
                            <tr class="odd gradeX">

                                <td><%# Eval("urunad") %></td>
                                <td><%# Eval("depoad") %></td>
                                <td><%# Eval("stk_miktar") %></td>
                                <td><%# Eval("durum_olcu") %></td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </tbody>
                             </table>
                    <!-- /.table-responsive -->
                        </FooterTemplate>

                    </asp:Repeater>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
