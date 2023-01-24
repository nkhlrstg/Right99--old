<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta name="viewport" content="width=device-width, scale=1.0" />
    <title></title>
    <link rel="stylesheet" href ="css/login.css"/>
     <link rel ="stylesheet" href ="fontcss/all.min.css" />
  
     <style>
            .center {
                text-align: center;
                width: 100%;
            }
        </style>

    <style >
    html { 
background: url(assets/img/8.jpg) no-repeat center center fixed; 
-webkit-background-size: cover;
-moz-background-size: cover;
-o-background-size: cover;
background-size: cover;
}

   </style> 
</head>
<body  >
      


<form id="form2" runat="server" class="body">
     <div> <i class="fa-solid fa-4x fa-user center "></i></div><br />
   <%--   <h1 style="text-align :center ">Login</h1>--%>
  <div class="row" >
    <label for="email">Mobile</label>
    <asp:TextBox ID="emailtxt" runat="server" ></asp:TextBox>
  </div>
  <div class="row">
    <label for="password">Password</label>
      
   <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
      <i class="far fa-eye-slash" id="togglePassword"></i>

  </div>
  <%--<button type="submit">Login</button>--%>
    <asp:Button ID="sbtbtn" runat="server" Text="Login"  />
    <br />
    <asp:Button ID="signupbtn" runat="server" Text="Signup/New User"  />
    <asp:Label ID="LblMesge" runat="server" Visible="False" ForeColor="Red"  ></asp:Label>
    <a href ="passwordreset.aspx" >Forget password ?</a>
    
    </form>
     <script type="text/javascript">

         const togglePassword = document.querySelector("#togglePassword");
         const password = document.querySelector("#Password");

         togglePassword.addEventListener("click", function (e){

             // toggle the type attribute
             const type = password.getAttribute("type") === "Password" ? "text" : "Password";
             password.setAttribute("type", type);

             // toggle the eye icon
             this.classList.toggle('fa-eye');
         });

    </script>
    
</body>
</html>
