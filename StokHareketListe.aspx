<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="StokHareketListe.aspx.cs" Inherits="stoktakip2.StokHareketListe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Stok Hareket Listesi</h3>
        </div>
        <!-- /.col-lg-12 -->
    </div>


    <div class="row">

        <div class="col-lg-12">
            <p>
                <a href="StokHareket.aspx" class="btn btn-success">Hareket Ekle</a>
            </p>

            <div class="panel panel-info">
                <div class="panel-heading">
                    Liste
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">
                    <asp:Repeater ID="rptStok" runat="server">
                        <HeaderTemplate>

                            <table width="100%" class="table table-striped table-bordered table-hover" id="dataTables-example">
                                <thead>
                                    <tr>

                                        <th>Ürün Adı</th>
                                        <th>Depo Adı</th>
                                        <th>Hareket Türü</th>
                                        <th>Miktar</th>
                                        <th>Ölçü Birimi</th>
                                        <th>Kullanıcı Adı</th>
                                        <th>Hareket Tarihi</th>

                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>


                        <ItemTemplate>
                            <tr class="odd gradeX">

                                <td><%# Eval("urunad") %></td>
                                <td><%# Eval("depoad") %></td>
                                <td><%# Eval("hareket_turu") %></td>
                                <td><%# Eval("stk_miktar")%></td>
                                <td><%# Eval("stk_olcu")%></td>
                                <td><%# Eval("user_name") %></td>
                                <td><%# Eval("hareket_tarih") %></td>


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
