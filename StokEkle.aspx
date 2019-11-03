<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="StokEkle.aspx.cs" Inherits="stoktakip2.StokEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Stok Ekle</h3>
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
                                <a href="StokYonetim.aspx" class="btn btn-danger">Geri</a>
                            </p>


                            <h2 class="form-signin-heading"></h2>
                            <label for="txtad">
                                Ürün Adı</label>
                            <asp:TextBox ID="txtad" runat="server" CssClass="form-control" placeholder="Ürün Adı Giriniz"
                                required />
                            <br />

                         <%--   <label for="txttarih">
                                Tarih</label>
                            <asp:TextBox ID="txttarih"  runat="server" CssClass="form-control" placeholder="Tarih Giriniz" />
                            <br />--%>

                            <label for="txtdetay">
                                Detay</label>
                            <asp:TextBox ID="txtdetay" runat="server" CssClass="form-control" placeholder="Detay Giriniz"
                                required />
                            <br />


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











































<%--<%@ Page Language="C#" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="StokEkle.aspx.cs" Inherits="stoktakip2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" Text="Detail"></asp:Label>
            <asp:TextBox ID="txtDetay" runat="server"></asp:TextBox>
            <asp:Button ID="buttonKaydet" runat="server" Text="Kaydet" OnClick="Button1_Click" />
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
            <asp:Button ID="buttonVazgec" runat="server" Text="Vazgeç"  OnClick="ButtonVazgec_Click"/>
        </div>
    </form>
</body>
</html>--%>
