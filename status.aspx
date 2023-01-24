<%@ Page EnableEventValidation="true" Title="" Language="VB" MasterPageFile="Mainpage.master"     AutoEventWireup="false" CodeFile="status.aspx.vb" Inherits="status" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <script type="text/javascript">
          function preventBack() { window.history.forward(); }
          setTimeout("preventBack()", 0);
          window.onunload = function () { null };
    </script>
        <script type="text/javascript">
            function ShareAPP() {
                Website2APK.shareIntent();
            }
            function CloseAPP() {
                Website2APK.exitApp();
            }
            function AboutAPP() {
                Website2APK.showAboutDialog();
            }
            function UpdateAPP(x) {
                Website2APK.openExternal(x);
            }
            function RateAPP() {
                Website2APK.rateUs();
            }
            function AppVersionNameCode() {
                var verName = Website2APK.getAppVersionName();
                var verCode = Website2APK.getAppVersionCode();
                var about = 'Version : ' + verName + '' + verCode;
                alert(about);
            }
 </script>
    <style >
        .new {
                padding :0px;
                text-decoration: none;
                overflow -y : hidden;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <form id="form1"  runat="server">
         
        
             <asp:GridView ID="gvDetails" CssClass ="table table-hover table-responsive " runat="server" DataKeyNames="sno"  AutoGenerateColumns="False" OnRowDataBound="OnRowDataBound"
    Font-Names="Arial" Font-Size="Small" >
    <Columns>
           <asp:TemplateField HeaderText="SNo">
     <ItemTemplate>
     <span>
     <%#Container.DataItemIndex + 1%>
     </span>
     </ItemTemplate>
     </asp:TemplateField> 
       <%-- <asp:BoundField DataField="sno" HeaderText="Sno" />--%>
        <asp:BoundField DataField="name" HeaderText="Name" />
        <asp:BoundField DataField="ddlval" HeaderText="Document" />
        <asp:BoundField DataField="cdate" HeaderText="Date" />
        <asp:BoundField DataField="status" HeaderText="Status" />
        <asp:TemplateField HeaderText="Download">
            <ItemTemplate   >
                <asp:Label ID="lblpending" Text="Pending" runat="server" />
                 <asp:linkButton ID="btncompleted" CssClass="new   " CommandName="Select" Text="Download"  OnClick ="downloadfile" runat="server" />
                 <asp:Button ID="viewbtn" CssClass="new btn-success" CommandName="Select" Text="View"  OnClick="viewclcik" runat="server" />
            </ItemTemplate>   
                    
        </asp:TemplateField>
      <%-- <asp:TemplateField HeaderText="View">
            <ItemTemplate   >
               
            </ItemTemplate>
        </asp:TemplateField>--%>
    </Columns>
     <EmptyDataTemplate>
        <div align="center">No records found.</div>
    </EmptyDataTemplate>
    <HeaderStyle BackColor="green" Font-Bold="True" ForeColor="#CCCCFF" />
</asp:GridView>
  
    </form>
       

</asp:Content>

