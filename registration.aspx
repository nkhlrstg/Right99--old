<%@ Page Language="VB" AutoEventWireup="false" CodeFile="registration.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, scale=1.0" />
    <title></title>
     <link rel="stylesheet" href="css/regis.css"/>
    <script >
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
        };
    </script>
   <%--  <script >
         function ValidateRegForm() {
             var email = document.getElementById("<%=emailtext.ClientID%>");
        var filter = /^([a-zA-Z0-9_.-])+@(([a-zA-Z0-9-])+.)+([a-zA-Z0-9]{2,4})+$/;
        if (!filter.test(email.value)) {
            alert('Please provide a valid email address');
            email.focus;
            return false;
        }
        return true;
    }
</script>--%>
  
</head>
<body>
   
       <div class="container">
  <div style ="text-align :center "><h1>Registration</h1> </div>
  <form id="form1"  runat="server">
      <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      <asp:Label ID="lblsave" runat="server" ForeColor="Red" Visible="False"></asp:Label>
    <div class="user-details">
      <div class="input-box">
        <span class="details">Full Name</span>
        <%--<input type="text" name="" id="nametext" runat="server"  placeholder="Enter your name" />--%>
          <asp:TextBox   ID="nametext" class="input" runat="server" placeholder="Enter your name"></asp:TextBox>
      </div>
     <%-- <div class="input-box">
        <span class="details">Username</span>
        <%--<input type="text" name="" id="unametext" runat="server"  placeholder="Enter your username"  />--%>
          <%--<asp:TextBox ID="unametext" class="input " runat="server" placeholder="Enter your username"></asp:TextBox>
      </div>--%>
    <%--  <div class="input-box">
        <span class="details">Email</span>
        <%--<input type="text" name="" id="emailtext" runat="server"  placeholder="Enter your email"  />--%>
         <%-- <asp:TextBox ID="emailtext" class="input " runat="server" placeholder="Enter your email"></asp:TextBox>  <asp:RegularExpressionValidator ID="valRegExEmail" runat="server" ControlToValidate="emailtext"
                            Display="Dynamic" ErrorMessage="Please give a valid email address" ValidationGroup="StaffAddValidation" ValidationExpression="^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z\.][a-zA-Z]{1,3}$" ForeColor="Red" SetFocusOnError="True"></asp:RegularExpressionValidator>
      </div>--%>
          <div class="input-box" >
            <span class="details">Date Of Birth</span>
            <asp:TextBox ID="dobtxt" class="input" runat="server" formate="dd/mm/yyyy" placeholder="dd/mmm/yyyy" ></asp:TextBox>
        </div>
      <div class="input-box">
        <span class="details">Phone Number</span>
        <%--<input type="text" name="" id="phonetext" runat="server"  placeholder="Enter your number" />--%>
          <asp:TextBox ID="phonetext" class="input " runat="server" MaxLength ="10"  placeholder="Enter number" onkeypress="return isNumberKey(event)" ></asp:TextBox><%--<asp:RegularExpressionValidator ID='vldNumber' ControlToValidate='phonetext' Display='Dynamic' ErrorMessage='ENTER NUMBER ONLY' ValidationExpression='(^([0-9]*|\d*\d{1}?\d*)$)' Runat='server'>--%>
<%--</asp:RegularExpressionValidator>--%>
      </div>
      <div class="input-box">
        <span class="details">Password</span>
        <%--<input type="text" name="" id="passtext" runat="server"  placeholder="Enter your password" required="required"  />--%>
          <asp:TextBox ID="passtext" class="input " runat="server" maxlength="12" TextMode="Password"  placeholder="Enter password" ></asp:TextBox>
      </div>
      <div class="input-box">
        <span class="details">Confirm Password</span>
        <%--<input type="text" name="" id="repasstext" runat="server"  placeholder="Confirm your password"  />--%>
          <asp:TextBox ID="repasstext" class="input "  runat="server" maxlength="12" TextMode="Password"  placeholder="Enter password again"></asp:TextBox><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="No Match" ControlToCompare="passtext" ControlToValidate="repasstext" ForeColor="Red"></asp:CompareValidator>
      </div>
    <div class="button">
    <asp:Button ID="regbtn" class="input " OnClientClick="return ValidateRegForm()" runat="server" Text="Register"  /><br /><br />
            
         <asp:Button ID="lgbtn" class="input " runat="server"  Text="LOGIN"   />   
    </div>
    </div>
  </form>
           
</div>
    

     
</body>
</html>
