<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="stoktakip2.Anasayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-lg-12">

                <h1 class="page-header">Dashboard</h1>
            </div>
            <!-- /.col-lg-12 -->
        </div>
        <!-- /.row -->
        <div class="row">

            <%
                if (AdminMi())
                {
            %>

            <div class="col-md col-md-4">
                <a href="KullaniciYonetim.aspx">
                    <div class="panel panel-yellow">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-3">

                                    <i class="fa fa-user fa-5x"></i>

                                </div>
                                <div class="col-xs-9 text-right">
                                    <div class="huge">
                                        <div>Kullanıcı</div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </a>
            </div>

            <%
                }
            %>


            <div class="col-md col-md-4">
                <a href="StokYonetim.aspx">
                    <div class="panel panel-red">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-3">
                                    <i class="fa fa-cube fa-5x"></i>
                                </div>
                                <div class="col-xs-9 text-right">
                                    <div class="huge">
                                        <div>Stok</div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </a>
            </div>


            <div class="col-md col-md-4">
                <a href="DepoYonetim.aspx">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-3">
                                    <i class="fa fa-cubes fa-5x"></i>
                                </div>
                                <div class="col-xs-9 text-right">
                                    <div class="huge">
                                        <div>Depo</div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </a>
            </div>



        </div>
    </div>
</asp:Content>
