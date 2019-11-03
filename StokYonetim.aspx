<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="StokYonetim.aspx.cs" Inherits="stoktakip2.StokYonetim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Stok Yönetimi</h3>
        </div>
        <!-- /.col-lg-12 -->
    </div>

    <div class="row">

        <div class="col-lg-12">

            <%
                if (AdminMi())
                {
            %>
            <p>
                <a href="StokEkle.aspx" class="btn btn-success">Stok Ekle</a>
            </p>
            <%
                }
            %>
            <div class="panel panel-info">
                <div class="panel-heading">
                    Stok Listesi                       
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">

                    <asp:Repeater ID="rptStok" runat="server">
                        <HeaderTemplate>
                            <table width="100%" class="table table-striped table-bordered table-hover" id="dataTables-example">
                                <thead>
                                    <tr>
                                        <th>Ürün Adı</th>
                                        <%--<th>Ürün Değiştirilme Tarihi</th>--%>
                                        <th>Ürün Detayı</th>
                                        <th>Ürün Kayıt Tarihi</th>

                                        <%if (AdminMi())
                                            { %>
                                        <th width="10%"></th>


                                        <th width="10%"></th>
                                        <%    }    %>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>

                        <ItemTemplate>
                            <tr class="odd gradeX">
                                <td><%# Eval("product_name") %></td>
                                
                               <%-- <td><%# Eval("degistirme_tarihi") %></td>--%>
                                <td><%# Eval("product_detail") %></td>
                                <td><%# Eval("product_date") %></td>

                                <%if (AdminMi())
                                    { %>
                                <td><a href="StokDuzenle.aspx?islem=duzenle&pid=<%# Eval("product_id") %>" class="btn btn-warning">Düzenle</a></td>


                                <td><a onclick="return confirm('Silmek istediğinize emin misiniz?')" href="?islem=sil&pid=<%# Eval("product_id") %>" class="btn btn-danger">Sil</a></td>
                                <%    }    %>
                            </tr>
                        </ItemTemplate>

                        <FooterTemplate>
                            </tbody>
                             </table>
                    <!-- /.table-responsive -->
                        </FooterTemplate>
                    </asp:Repeater>
                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>

</asp:Content>

