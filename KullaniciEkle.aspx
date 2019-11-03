<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="KullaniciEkle.aspx.cs" Inherits="stoktakip2.KullaniciEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Kullanıcı Ekle</h3>
        </div>
        <!-- /.col-lg-12 -->
    </div>

    <div class="container">
        <div class="row">
            <div class="col-md ">
                <div style="max-width: 400px;">

                    <div class="row">
                        <div class="col-lg-12">
                            <p>
                                <a href="KullaniciYonetim.aspx" class="btn btn-danger">Geri</a>
                            </p>


                            <h2 class="form-signin-heading"></h2>
                            <label for="txtad">
                                Ad</label>
                            <asp:TextBox ID="txtad" runat="server" CssClass="form-control" placeholder="Ad Giriniz"
                                required />
                            <br />

                            <label for="txtsoyad">
                                SoyAd</label>
                            <asp:TextBox ID="txtsoyad" runat="server" CssClass="form-control" placeholder="Soyad Giriniz"
                                required />
                            <br />

                            <label for="txtmail">
                                E-Mail</label>
                            <asp:TextBox ID="txtmail" runat="server" CssClass="form-control" placeholder="email@example.com" />
                            <br />

                            <%--<label for="txttip">
                                Tip</label>
                            <asp:TextBox ID="txttip" runat="server" CssClass="form-control" placeholder="Tip Giriniz"
                                required />
                            <br />--%>

                            <label for="drpUsertype">
                                Tip</label>
                            <asp:DropDownList ID="drpUsertype" runat="server" CssClass="form-control">
                                <asp:ListItem Value="">Tip Seçiniz!</asp:ListItem>
                                <asp:ListItem Value="admin">Admin</asp:ListItem>
                                <asp:ListItem Value="misafir">Misafir</asp:ListItem>
                            </asp:DropDownList>



                            <label for="txtPassword">
                                Şifre</label>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"
                                placeholder="Enter Password" required />
                            <br />

                            <asp:Button ID="btnKaydet" Text="Kaydet" runat="server" OnClick="btnKaydet1" class="btn btn-primary" />
                            <br />
                            <br />

                            <br />
                            <br />
                            <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                                <strong>Error!</strong>
                                <asp:Label ID="lblMessage" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>



































































<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KullaniciEkle.aspx.cs" Inherits="stoktakip2.KullaniciEkle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblad" runat="server" Text="Ad"></asp:Label>
            <asp:TextBox ID="txtad" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="lblsoyad" runat="server" Text="Soyad"></asp:Label>
        <asp:TextBox ID="txtsoyad" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblmail" runat="server" Text="E-Mail"></asp:Label>
            <asp:TextBox ID="txtmail" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lbltip" runat="server" Text="Kullanıcı Tipi"></asp:Label>
        <asp:TextBox ID="txttip" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblsifre" runat="server" Text="Şifre"></asp:Label>
            <asp:TextBox ID="txtsifre" runat="server"></asp:TextBox>
            </p>
            <asp:Button ID="btnkaydet" runat="server" Text="Kaydet" OnClick="btnkaydet_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnvazgec" runat="server" Text="Vazgeç" OnClick="btnvazgec_Click" />
        </p>
    </form>
</body>
</html>--%>
