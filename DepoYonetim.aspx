<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="DepoYonetim.aspx.cs" Inherits="stoktakip2.DepoYonetim" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Depo Yönetimi</h3>
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
                <a href="DepoEkle.aspx" class="btn btn-success">Depo Ekle</a>
            </p>
            <%
                }
            %>
            <div class="panel panel-info">
                <div class="panel-heading">
                    Depo Listesi                       
                </div>
                <!-- /.panel-heading -->
                <div class="panel-body">

                    <asp:Repeater ID="rptStok" runat="server">
                        <HeaderTemplate>
                            <table width="100%" class="table table-striped table-bordered table-hover" id="dataTables-example">
                                <thead>
                                    <tr>
                                        <th>Depo Adı</th>

                                        <% if (AdminMi())
                                            { %>
                                        <th width="10%"></th>


                                        <th width="10%"></th>

                                        <%  }    %>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>

                        <ItemTemplate>
                            <tr class="odd gradeX">
                                <td><%# Eval("depo_name") %></td>

                                <% if (AdminMi())
                                    { %>
                                <td><a href="DepoDuzenle.aspx?islem=duzenle&pid=<%# Eval("depo_id") %>" class="btn btn-warning">Düzenle</a></td>


                                <td><a onclick="return confirm('Silmek istediğinize emin misiniz?')" href="?islem=sil&pid=<%# Eval("depo_id") %>" class="btn btn-danger">Sil</a></td>
                                <%  }    %>
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
