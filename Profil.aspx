<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="Profil.aspx.cs" Inherits="stoktakip2.Profil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Profil</h3>
        </div>
        <!-- /.col-lg-12 -->
    </div>

    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <p>
                    <a href="Anasayfa.aspx" class="btn btn-warning">Geri</a>
                </p>
            </div>
            <div class="col-md-6">
                <div style="max-width: 400px;">

                    <div class="row">
                        <div class="col-lg-12">


                            <div class="panel panel-info">
                                <div class="panel-heading">
                                    <h2 class="form-signin-heading">Kullanıcı Bilgileri</h2>
                                </div>
                                <div class="panel-body">

                                    <label for="txtad">
                                        Ad</label>
                                    <asp:TextBox ID="txtad" runat="server" CssClass="form-control" />
                                    <br />

                                    <label for="txtsoyad">
                                        SoyAd</label>
                                    <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-control" />
                                    <br />

                                    <label for="txtmail">
                                        E-Mail</label>
                                    <asp:TextBox ID="txtmail" runat="server" CssClass="form-control" />
                                    <br />



                                    <asp:Button ID="btnKaydet" Text="Kaydet" runat="server" OnClick="btnKaydet1" class="btn btn-primary" />

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <%-- burdan--%>


            <div class="col-lg-4">
                <div class="panel panel-info">
                    <div class="panel-heading">
                        <h2 class="form-signin-heading">Şifre İşlemleri</h2>
                    </div>
                    <div class="panel-body">
                        Şifre:<asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                        <br />
                        <br />

                        <asp:Button ID="btnsifre" runat="server" Text="Değiştir" OnClick="btnsifre_Click" class="btn btn-primary" />
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
