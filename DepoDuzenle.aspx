<%@ Page Title="" Language="C#" MasterPageFile="MainMaster.Master" AutoEventWireup="true" CodeBehind="DepoDuzenle.aspx.cs" Inherits="stoktakip2.DepoDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row">
        <div class="col-lg-12">
            <h3 class="page-header">Depo Düzenle</h3>
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
                                <a href="DepoYonetim.aspx" class="btn btn-danger">Geri</a>
                            </p>


                            <h2 class="form-signin-heading"></h2>
                            <label for="txtad">
                                Depo Adı</label>
                            <asp:TextBox ID="txtad" runat="server" CssClass="form-control" 
                                 />
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