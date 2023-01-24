<%@ Page Title="" Language="VB" MasterPageFile="~/Mainpage.master" AutoEventWireup="false" CodeFile="printreceipt.aspx.vb" Inherits="printreceipt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script type="text/javascript">
        function Print() {
            Website2APK.printPage();
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div class="container">
        <div style="justify-content: center; text-align: center">
            <div class="col-lg-8">
                <div class="card mb-4">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-sm-3">
                                <p class="mb-0">Name</p>
                            </div>
                            <div class="col-sm-9">
                                <p class="text-muted mb-0">
                                    <asp:Label ID="lblname" runat="server"></asp:Label>
                                </p>
                            </div>
                        </div>
                        <hr />

                        <div class="row">
                            <div class="col-sm-3">
                                <p class="mb-0">Mobile</p>
                            </div>
                            <div class="col-sm-9">
                                <p class="text-muted mb-0">
                                    <asp:Label ID="lblmob" runat="server"></asp:Label>
                                </p>
                            </div>
                        </div>
                        <hr />
                        <div class="row">
                            <div class="col-sm-3">
                                <p class="mb-0">Document Type</p>
                            </div>
                            <div class="col-sm-9">
                                <p class="text-muted mb-0">
                                    <asp:Label ID="lbldist" runat="server"></asp:Label>
                                </p>
                            </div>
                        </div>

                        <hr />
                        <div class="row">
                            <div class="col-sm-3">
                                <p class="mb-0">Date</p>
                            </div>
                            <div class="col-sm-9">
                                <p class="text-muted mb-0">
                                    <asp:Label ID="lbldate" runat="server"></asp:Label>
                                </p>
                            </div>
                        </div>

                        <hr />
                        <div class="row">
                            <div class="col-sm-3">
                                <p class="mb-0">Transaction Number</p>
                            </div>
                            <div class="col-sm-9">
                                <p class="text-muted mb-0">
                                    <asp:Label ID="lbltrans" runat="server"></asp:Label>
                                </p>
                            </div>
                        </div>
                        <hr />
                        <div class="row">
                            <div class="col-sm-3">
                                <p class="mb-0">Amount</p>
                            </div>
                            <div class="col-sm-9">
                                <p class="text-muted mb-0">
                                    <asp:Label ID="lblamt" runat="server"></asp:Label>
                                </p>
                            </div>
                        </div>
                        <hr />
                        <div class="row">
                            <div class="col-sm-3">
                                <p class="mb-0 ">Application Number</p>
                            </div>
                            <div class="col-sm-9">
                                <p class="text-muted mb-0">
                                    <asp:Label ID="lblappnum" runat="server"></asp:Label>
                                </p>
                            </div>

                        </div>
                        <hr />
                        <form runat="server">
                            <div class="justify-content-center text-center ">
                                <asp:Button ID="btnprint" runat="server" class="btn btn-success " Text="Print" />
                            </div>
                        </form>
                    </div>

                 </div>
                </div>
            </div>
        </div>
   
</asp:Content>

