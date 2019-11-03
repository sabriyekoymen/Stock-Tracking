<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YeniKayıt.aspx.cs" Inherits="stoktakip2.YeniKayıt" %>



<link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<script src="vendor/jquery/jquery.min.js"></script>
<script src="vendor/bootstrap/js/bootstrap.min.js"></script>



<form id="form1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md col-md-offset-4 " >
                <div style="max-width: 400px;" >




                    <h2 class="form-signin-heading">YeniKayıt</h2>
                    <label for="txtad">
                        Ad</label>
                    <asp:textbox id="txtad" runat="server" cssclass="form-control" placeholder="Ad Giriniz"
                        required />
                    <br />

                    <label for="txtsoyad">
                        SoyAd</label>
                    <asp:textbox id="txtsoyad" runat="server" cssclass="form-control" placeholder="Soyad Giriniz"
                        required />
                    <br />

                    <label for="txtmail">
                        E-Mail</label>
                    <asp:textbox id="txtmail" runat="server" cssclass="form-control" placeholder="Mail Giriniz"  />
                    <br />

                    <%--  <label for="txttip">
                        Tip</label>
                    <asp:textbox id="txttip" runat="server" cssclass="form-control" placeholder="Tip Giriniz"
                        required />
                    <br />--%>

                    <label for="drpUsertype">
                        Tip</label>
                               <asp:dropdownlist id="drpUsertype" runat="server" cssclass="form-control">
                                <asp:ListItem Value="">Tip Seçiniz!</asp:ListItem>
                                <asp:ListItem Value="admin">Admin</asp:ListItem>
                                <asp:ListItem Value="misafir">Misafir</asp:ListItem>
                            </asp:dropdownlist>

                    <label for="txtPassword">
                        Şifre</label>
                    <asp:textbox id="txtPassword" runat="server" textmode="Password" cssclass="form-control"
                        placeholder="Enter Password" required />
                    <br />

                    <asp:button id="btnKaydet" text="Kaydet" runat="server" onclick="btnKaydet1" class="btn btn-primary" />
                    <br />
                    <br />
                    <div class="row">
                        <div class="col-lg-12">
                            <p>
                                <a href="Giris.aspx" class="btn btn-danger">Vazgeç</a>
                            </p>
                            <br />
                            <br />
                            <div id="dvMessage" runat="server" visible="false" class="alert alert-danger">
                                <strong>Error!</strong>
                                <asp:label id="lblMessage" runat="server" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
</form>

