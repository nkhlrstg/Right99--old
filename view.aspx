<%@ Page Title="" Language="VB" MasterPageFile="~/Mainpage.master" AutoEventWireup="false" CodeFile="view.aspx.vb" Inherits="view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
     <link rel ="stylesheet" href ="css/appform.css" />
    <script type="text/javascript">
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
    </script>
      <script >
          function isNumberKey(evt) {
              var charCode = (evt.which) ? evt.which : evt.keyCode;
              if (charCode > 31 && (charCode < 48 || charCode > 57))
                  return false;
              return true;
          };
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
</asp:Content>

   
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div class="container-fluid ">
        <div class="container "> 
        <form id="form1" class="form-control  " runat="server">

            <div class="text-center">
                <h1 class="text-success ">SUBMITTED FORM </h1>
            </div>
            <div>
                <table cellpadding="3" cellspacing="5"  class="auto-style1, table-responsive ">
                    
                    <tr style="width: 600px">
                       <td class="auto-style3"><b>NAME </b><strong>:</strong>
                            <asp:TextBox ID="nametxt" CssClass ="form-control " placeholder="NAME" runat="server" ReadOnly="True"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>FATHER'S/HUSBAND'S NAME </b><strong>:</strong><br />
                            <asp:RadioButtonList ID="fhtype" runat="server">
                                <asp:ListItem>Husband</asp:ListItem>
                                <asp:ListItem>Father</asp:ListItem>
                            </asp:RadioButtonList> <%--<asp:RadioButton ID="fname"  runat="server" Text="FATHER" GroupName="fhname" /><asp:RadioButton ID="hname"  runat="server" Text="HUSBAND" GroupName="fhname" />--%><asp:TextBox ID="fathrtxt" CssClass ="form-control " ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>MOTHER'S NAME </b><strong>:</strong>
                            <asp:TextBox ID="mothrtxt" CssClass ="form-control " ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>FULL ADDRESS </b><strong>:</strong>
                            <asp:TextBox ID="adstxt" CssClass ="form-control " runat="server" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                   
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>CITY </b><strong>:</strong>
                            <asp:TextBox ID="txtthashil" CssClass ="form-control " ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>THASHIL </b><strong>:</strong>
                            <asp:TextBox ID="ctytxt" CssClass ="form-control " ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>THANA </b><strong>:</strong>
                            <asp:TextBox ID="txtthana" CssClass ="form-control " ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>VILLAGE </b><strong>:</strong>
                            <asp:TextBox ID="txtvillage" CssClass ="form-control " ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>DISTRICT </b><strong>:</strong>
                            <asp:TextBox ID="dsttxt" CssClass ="form-control " ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>CAST </b><strong>:</strong>
                            <asp:TextBox ID="txtcast" CssClass ="form-control " ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>SUBCAST </b><strong>:</strong>
                            <asp:TextBox ID="txtsubcast" CssClass ="form-control " ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>MOBILE NUMBER </b><strong>:</strong>
                            <asp:TextBox ID="mbtxt" CssClass ="form-control " onkeypress="return isNumberKey(event)" ReadOnly="True" maxlength="10" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>NUMBER OF FAMILY MEMBER'S</b><strong>:</strong>
                            <asp:TextBox ID="fmtxt" CssClass ="form-control " onkeypress="return isNumberKey(event)" ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>FAMILY ANNUAL INCOME </b><strong>:</strong>
                            <asp:TextBox ID="faitxt" CssClass ="form-control " onkeypress="return isNumberKey(event)" ReadOnly="True" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>FAMILY INCOME CATEGORY </b><strong>:</strong>
                            &nbsp;</td>
                    </tr>
                        <tr style="width: 600px">
                        <td style="width: 500px">
                            <asp:DropDownList ID="ddlicm" class="dropdown btn btn-success  form-control " runat="server" AutoPostBack="false" Enabled="False">
                                <asp:ListItem>SELECT</asp:ListItem>
                                <asp:ListItem>AGRICULTURE</asp:ListItem>
                                <asp:ListItem>PRIVATE JOB</asp:ListItem>
                                 <asp:ListItem>GOVERNMENT JOB</asp:ListItem>
                                <asp:ListItem>BUSSINESS</asp:ListItem>
                                <asp:ListItem>PENSION</asp:ListItem>

                            </asp:DropDownList></td>
                    </tr>
                    <tr >
                        
                        <td >
                            <asp:TextBox ID="srcicmtxt" cssclass="form-control " ReadOnly="True" onkeypress="return isNumberKey(event)" runat="server"></asp:TextBox>

                        </td>
                    </tr>
                  <%--  <tr style="width: 600px">
                        <td class="auto-style3"><b>AGRICULTURE </b><strong>:</strong>
                            <asp:TextBox ID="agtxt" CssClass ="form-control " runat="server"></asp:TextBox><b>BUSSINESS </b><strong>:</strong><asp:TextBox ID="busstxt" CssClass ="form-control " runat="server"></asp:TextBox><b>JOB</b><strong>:</strong>
                            <asp:TextBox ID="jobtxt" CssClass ="form-control " runat="server"></asp:TextBox><b>PENSION </b><strong>:</strong>
                            <asp:TextBox ID="psntxt" CssClass ="form-control " runat="server"></asp:TextBox>
                        </td>
                    </tr>--%>
                </table>
                <table cellpadding="3" cellspacing="5" class="auto-style1,table-responsive">
                        <tr>
                        <td>
                            <b >Document Type  </b><strong>:</strong>
                        </td>
                    </tr>
                    <tr style="width: 600px">
                        <td style="width: 500px">
                         
                               <asp:DropDownList ID="ddl" class="dropdown btn btn-success form-control " runat="server"  Enabled  ="False">
                                <asp:ListItem>SELECT</asp:ListItem>
                                <asp:ListItem Value ="1">INCOME CERITIFICATE</asp:ListItem>
                                <asp:ListItem Value ="2">CAST CERTIFICATE</asp:ListItem>
                                <asp:ListItem Value ="3">DOMICIAL CERTIFICATE</asp:ListItem>
                                <asp:ListItem Value ="4">RATION CARD</asp:ListItem>
                                <asp:ListItem Value ="5">RATION CARD UNIT JOINT</asp:ListItem>
                                <asp:ListItem Value ="6">RATION CARD AADHAR SHEED</asp:ListItem>
                                <asp:ListItem Value ="7">PAN CARD</asp:ListItem>
                                <asp:ListItem Value ="8">VOTER ID CARD</asp:ListItem>
                                <asp:ListItem Value ="9">LABOUR CARD</asp:ListItem>
                                <asp:ListItem Value ="10">LABOUR CARD FEES PER YEAR</asp:ListItem>
                                <asp:ListItem Value ="11">LOBOUR CARD KYC</asp:ListItem>
                                <asp:ListItem Value ="12">KHASRA KHATOUNI(FARAD)</asp:ListItem>
                                <asp:ListItem Value ="13">TWO  WHEELER INSURANCE</asp:ListItem>
                                <asp:ListItem Value ="14">FOUR WHEELER INSURANCE</asp:ListItem>
                                <asp:ListItem Value ="15">HEALTH INSURANCE</asp:ListItem>

                            </asp:DropDownList>
                        </td>
                    </tr>
                  <tr>
                        <td>
                             <b>Deposit Amount </b><strong>:</strong>
                            <asp:TextBox ID="txtamt"  onkeypress="return isNumberKey(event)" ReadOnly="True" MaxLength ="10" CssClass="form-control"  runat="server"></asp:TextBox>
                        </td>
                        </tr>
                       <tr>
                         <td>
                             <b>Transaction Number </b><strong>:</strong>
                             <asp:TextBox ID="txttrnnum" class="form-control" MaxLength ="30" ReadOnly="True" runat="server"></asp:TextBox>
                        </td>
                        </tr>
                     <tr>
                         <td>
                             <b>Download Receipt </b><strong>:</strong>
                            <asp:Button ID="btnrec" runat="server" class="btn btn-success " Text="Download"     />
                              <asp:Label ID="lblrd" runat="server"  ForeColor="Red" Visible="False"></asp:Label>
                        </td>
                        </tr>
                  </table>
                </div>
            <br />
   
    <table width="90%" align="center">
        <tr>
            <td>
                <div>
                    <asp:Panel ID="Panel2" runat="server"   Width="100%" >
                        <asp:GridView ID="GridView1" CssClass="  table table-hover table-responsive-sm table-responsive-md table-responsive-lg " AutoGenerateColumns="False"   EmptyDataText="No Documents Found"  Width="100%" runat="server" >
                            <Columns>

 <asp:BoundField DataField="Text" HeaderText="File Name" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lnkDownload" Text = "Download" CommandArgument = '<%# Eval("Value") %>' runat="server" OnClick = "DownloadFile"></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
      
                            </Columns>

                            <EmptyDataRowStyle HorizontalAlign="Center" />
                        </asp:GridView>
                    </asp:Panel>
                </div>
            </td>
        </tr>
    </table>
                    
</form> 
            
         </div> 


</asp:Content>

