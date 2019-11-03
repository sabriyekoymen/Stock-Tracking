<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="KullaniciYonetim.aspx.cs" Inherits="stoktakip2.KullaniciYonetim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Kullanıcı Yönetimi</h3>
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
                <a href="KullaniciEkle.aspx" class="btn btn-success">Kullanıcı Ekle</a>
            </p>
            <%
                }
            %>
            <div class="panel panel-info">
                <div class="panel-heading">
                    Kullanıcı Listesi                       
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">

                    <asp:Repeater ID="rptStok" runat="server">
                        <HeaderTemplate>
                            <table width="100%" class="table table-striped table-bordered table-hover" id="dataTables-example">
                                <thead>
                                    <tr>

                                        <th>Kullanıcı Adı</th>
                                        <th>Kullanıcı Soyadı</th>
                                        <th>E-Mail</th>
                                        <th>Kullanıcı Tipi</th>
                                        <th>Kayıt Tarihi</th>
                                        <%--<th>Değiştirilme Tarihi</th>--%>
                                        <%
                                            if (AdminMi())
                                            {
                                        %>
                                        <th width="10%"></th>


                                        <th width="10%"></th>
                                        <%
                                            }
                                        %>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>

                        <ItemTemplate>
                            <tr class="odd gradeX">

                                <%-- <td><%# Eval("users_id") %></td>--%>
                                <td><%# Eval("users_fname") %></td>
                                <td><%# Eval("users_lname") %></td>
                                <td><%# Eval("Users_mail") %></td>
                                <td><%# Eval("users_type") %></td>
                                <td><%# Eval("u_tarih") %></td>
                               <%-- <td><%# Eval("degistirme_tarihi") %></td>--%>
                                <td><a href="KullaniciDuzenle.aspx?islem=duzenle&pid=<%# Eval("users_id") %>" class="btn btn-warning">Düzenle</a></td>


                                <%
                                    if (AdminMi())
                                    {
                                %>
                                <td>
                                    <a onclick="return confirm('Silmek istediğinize emin misiniz?')" href="?islem=sil&pid=<%# Eval("users_id") %>" class="btn btn-danger">Sil
                                </td>
                                <%
                                    }
                                %>
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

