<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="StokHareket.aspx.cs" Inherits="stoktakip2.StokHareket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Stok Hareket</h3>
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
                                <a href="StokHareketListe.aspx" class="btn btn-danger">Geri</a>
                            </p>


                            <h2 class="form-signin-heading"></h2>

                            <label for="drpStok">
                                Ürün</label>
                            <asp:DropDownList ID="drpStok" runat="server" CssClass="form-control" AutoPostBack="True" DataTextField="Ad" DataValueField="product_id" OnSelectedIndexChanged="drpStok_SelectedIndexChanged">
                            </asp:DropDownList>

                            <div class="d-inline-block ">
                                <label for="txtolcubirim">
                                    Ölçü Birimi</label>
                                <asp:TextBox ID="txtolcubirim" runat="server" CssClass="form-control" Enabled="False"></asp:TextBox>
                            </div>


                            <label for="drpDepo">
                                Depo</label>
                            <asp:DropDownList ID="drpDepo" runat="server" CssClass="form-control" AutoPostBack="True">
                            </asp:DropDownList>

                            <div class="d-inline-block ">
                                <label for="txtmiktar">
                                    Miktar</label>
                                <asp:TextBox ID="txtmiktar" runat="server" CssClass="form-control" required />

                            </div>








                            <label for="drpHareket">
                                Hareket Türü</label>
                            <asp:DropDownList ID="drpHareket" runat="server" CssClass="form-control">
                                <asp:ListItem Value="">Tip Seçiniz!</asp:ListItem>
                                <asp:ListItem Value="Giris">Giriş</asp:ListItem>
                                <asp:ListItem Value="Cıkıs">Çıkış</asp:ListItem>
                            </asp:DropDownList>



                            <br />



                            <asp:Button ID="btnKaydet" Text="Kaydet" runat="server" OnClick="btnKaydet1" class="btn btn-primary" />


                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
</asp:Content>
