<%@ Page Title="" Language="VB" MasterPageFile="~/Mainpage.master" AutoEventWireup="false" CodeFile="userprofile.aspx.vb" Inherits="userprofile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <div class="col-lg-8">
        <div class="card mb-4">
          <div class="card-body">
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Full Name</p>
              </div>
              <div class="col-sm-9">
                <p class="text-muted mb-0">
                    <asp:Label ID="lblname" runat="server" ></asp:Label></p>
              </div>
            </div>
            <hr/>
          <%--  <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Email</p>
              </div>
              <div class="col-sm-9">
                <p class="text-muted mb-0">
                    <asp:Label ID="lblemail" runat="server" ></asp:Label></p>
              </div>
            </div>
            <hr/>--%>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Mobile</p>
              </div>
              <div class="col-sm-9">
                <p class="text-muted mb-0">
                    <asp:Label ID="lblmob" runat="server" ></asp:Label></p>
              </div>
            </div>
            <hr/>
            <div class="row">
              <div class="col-sm-3">
                <p class="mb-0">Password</p>
              </div>
              <div class="col-sm-9">
                <p class="text-muted mb-0">
                    <asp:Label ID="lblpass" runat="server" ></asp:Label></p>
              </div>
            </div>
          
            <hr />
             <div class="row">
              <div class="col-sm-3">
                <p class="mb-0 ">Change Password</p>
              </div>
                   <form runat ="server" >
              <div class="col-sm-9" >
                  
                         <p class=" ml-3 pb-2">
                    <asp:TextBox ID="txtchngpass" cssclass="form-control "  runat="server"></asp:TextBox></p>
                   
              </div>
                <div >
                    <asp:Button ID="btnchgpass" CssClass="btn btn-success " runat="server" Text="Change password"  />
                </div>
                   </form>
            </div>
           
          </div>
       
        </div>
        

</asp:Content>

