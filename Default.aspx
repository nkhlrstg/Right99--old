<%@ Page Title="" Language="VB" MasterPageFile="~/Mainpage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <form runat ="server" >
    <table class="table table-responsive">
       
        <tr>
            <td><asp:ImageButton ID="btnadhar" ImageUrl ="assets/img/adharicon.png" Width ="100" Height="100"  runat="server" /></td>
            <td><asp:ImageButton ID="btnpan" ImageUrl ="assets/img/pan.jpg" Width ="100" Height="100"  runat="server" /></td>
            <td><asp:ImageButton ID="btnratn" ImageUrl="assets/img/ration.jpg" Width ="100" Height="100"  runat="server" /></td>
        </tr>
        <tr>
            <td> <asp:ImageButton ID="btnicm" ImageUrl="assets/img/income.jpg" Width ="100" Height="100"  runat="server" /></td>
            <td><asp:ImageButton ID="btncast" ImageUrl="assets/img/cast.jpg" Width ="100" Height="100"  runat="server" /></td>
            <td><asp:ImageButton ID="btndm" ImageUrl="assets/img/domicile.jpg" Width ="100" Height="100"  runat="server" /></td>
        </tr>
        <tr>
            <td><asp:ImageButton ID="btnvoter" ImageUrl="assets/img/voterid.jpg" Width ="100" Height="100"  runat="server" /></td>
            <td><asp:ImageButton ID="btnayush" ImageUrl="assets/img/ayushmaan.jpg" Width ="100" Height="100"  runat="server" /></td>
            <td><asp:ImageButton ID="btnlbr" ImageUrl="assets/img/labour.jpg" Width ="100" Height="100"  runat="server" /></td>
        </tr>
        <tr>
            <td>
                <asp:ImageButton ID="btnhlth" ImageUrl="assets/img/healthinsurance.jpg" Width ="100" Height="100"  runat="server" /></td>
            <td><asp:ImageButton ID="btntwo" ImageUrl="assets/img/twowheeler.jpg" Width ="100" Height="100"  runat="server" /></td>
            <td><asp:ImageButton ID="btnfour" ImageUrl="assets/img/fourwheeler.jpg" Width ="100" Height="100"  runat="server" /></td>
        </tr>
      
    </table>
    </form>

    
</asp:Content>

