<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="stoktakip2.Giris" %>



<link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<script src="vendor/jquery/jquery.min.js"></script>
<script src="vendor/bootstrap/js/bootstrap.min.js"></script>



<form id="form1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md col-md-offset-4">

                <div style="max-width: 400px;">
                    <h2 class="form-signin-heading">Login</h2>
                    <label for="txtUsername">
                        Username</label>
                    <asp:textbox id="txtUsername" runat="server" cssclass="form-control" placeholder="Enter Username"
                        required />
                    <br />
                    <label for="txtPassword">
                        Password</label>
                    <asp:textbox id="txtPassword" runat="server" textmode="Password" cssclass="form-control"
                        placeholder="Enter Password" required oninvalid="this.setCustomValidity(' şifrenizi giriniz!')" oninput="setCustomValidity('')" />
                    <br />

                    <asp:button id="btnLogin" text="Giriş" runat="server" onclick="btnlogin" class="btn btn-primary" />
                    <br />
                    <br />
                    <div class="row">
                        <div class="col-lg-12">
                            <p>
                                <a href="YeniKayıt.aspx" class="btn btn-danger">Yeni Kayıt</a>
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



































