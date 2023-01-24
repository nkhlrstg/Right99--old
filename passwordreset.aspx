<%@ Page Language="VB" AutoEventWireup="false" CodeFile="passwordreset.aspx.vb" Inherits="WebSite1_passwordreset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="stylesheet" href ="css/bootstrap.min.css" />
     
      <script >
          function isNumberKey(evt) {
              var charCode = (evt.which) ? evt.which : evt.keyCode;
              if (charCode > 31 && (charCode < 48 || charCode > 57))
                  return false;
              return true;
          };
    </script>
    <style > 
        body
        {
             background: linear-gradient(135deg, #86e3ce, #d0e6a5);
 }
         
    </style>
 
</head>
<body>
    
     <div class="container">
    <form id="form1" class ="form-control " runat="server">

        <h1 style="text-align: center"> Check Password</h1>
      <%--  <div>
            <b>Email </b>
            <asp:TextBox ID="emtxt" class="form-control "  runat="server" ></asp:TextBox><asp:RegularExpressionValidator ID="valRegExEmail" runat="server" ControlToValidate="emtxt"
                            Display="Dynamic" ErrorMessage="Please give a valid email address" ValidationGroup="StaffAddValidation" ValidationExpression="^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z\.][a-zA-Z]{1,3}$" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
        </div>--%>
        <div >
            <b>Date Of Birth</b>
            <asp:TextBox ID="dobtxt" class="form-control " runat="server"  placeholder="dd/mmm/yyyy"></asp:TextBox>
        </div>
        <div >
            <b>Mobile Number</b>
            <asp:TextBox ID="mbtxt" class="form-control " MaxLength ="10" onkeypress="return isNumberKey(event)" runat="server"></asp:TextBox>
        </div>
     
        <br />
        <asp:Button ID="sbtbtn" class="btn btn-success  "     runat="server" Text="Confirm" /> <asp:Button ID="btnbck" class="btn btn-success  "     runat="server" Text="Back" />

    </form>
       
          <asp:Label ID="lblemail" runat="server" Text="Label" Visible ="false" Font-Bold="True" ForeColor="#CC0000"></asp:Label><br />
    <asp:Label ID="lblpass" runat="server" Text="Label" Visible ="false" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
       </div> 
    <script src="js/jquery.min.js"></script>

<!-- Latest compiled JavaScript -->
<script src="js/bootstrap.min.js"></script>
        
</body>
</html>
