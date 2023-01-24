<%@ Page Title="" Language="VB" MasterPageFile="Mainpage.master" AutoEventWireup="false" CodeFile="home.aspx.vb" Inherits="WebSite1_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <script type="text/javascript">
         function preventBack() { window.history.forward(); }
         setTimeout("preventBack()", 0);
         window.onunload = function () { null };
    </script>
    <style >
        .brdr{
            align-content :center ;
            text-align :center ;
            border :2px solid silver;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <form runat ="server" >
    <table class="table table-responsive">
       
        <tr>
            <td class="brdr"><asp:ImageButton ID="btnhlth" ImageUrl ="assets/img/healthcard1.jpeg" Width ="100" Height="100" runat="server" /><b>स्वास्थ्य कार्ड</b></td>
            <td class="brdr" ><asp:ImageButton ID="btnpan" ImageUrl ="assets/img/pancard1.jpeg" Width ="100" Height="100"  runat="server" /><b>  पैन कार्ड</b></td>
            <td class="brdr" ><asp:ImageButton ID="btnratn" ImageUrl="assets/img/ration1.jpg" Width ="100" Height="90"  runat="server" /><b>राशन कार्ड </b></td>
        </tr>
        <tr>
            <td class="brdr"> <asp:ImageButton ID="btnicm" ImageUrl="assets/img/incomecard1.jpeg" Width ="100" Height="100"  runat="server" /><b>  आय प्रमाण पत्र</b></td>
            <td class="brdr"><asp:ImageButton ID="btncast" ImageUrl="assets/img/castcard1.jpeg" Width ="100" Height="100"  runat="server" /><b>जाति प्रमाण पत्र</b></td>
            <td class="brdr"><asp:ImageButton ID="btndm" ImageUrl="assets/img/domicilecard1.jpeg" Width ="100" Height="100"  runat="server" /><b>निवासी प्रमाण पत्र</b></td>
        </tr>
        <tr>
            <td class="brdr"><asp:ImageButton ID="btnvoter" ImageUrl="assets/img/voteridcard1.jpeg" Width ="100" Height="100"  runat="server" /><b>मतदाता पहचान पत्र</b></td>
            <td class="brdr"><asp:ImageButton ID="btnayush" ImageUrl="assets/img/ayushmanncard1.jpeg" Width ="100" Height="100"  runat="server" /><b>आयुष्मान कार्ड</b></td>
            <td class="brdr"><asp:ImageButton ID="btnlbr" ImageUrl="assets/img/labourcard1.jpeg" Width ="100" Height="100"  runat="server" /><b>श्रमिक कार्ड</b></td>
        </tr>
        <tr>
            <td class="brdr"><asp:ImageButton ID="btntwo" ImageUrl="assets/img/twowheeler.jpg" Width ="100" Height="100"  runat="server" /><b>बाइक बीमा</b></td>
            <td class="brdr"><asp:ImageButton ID="btnfour" ImageUrl="assets/img/fourwheeler.jpg" Width ="100" Height="100"  runat="server" /><b>कार बीमा</b></td>
              <td class="brdr">
            <asp:LinkButton ID="morelink"  runat="server">More Links....</asp:LinkButton>
              
                 </td>
           

        </tr>
      
    </table>
    </form>

  
</asp:Content>

