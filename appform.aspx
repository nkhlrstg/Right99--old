<%@ Page Title="" Language="VB" MasterPageFile="Mainpage.master" AutoEventWireup="false" CodeFile="appform.aspx.vb" Inherits="WebSite1_Default" %>

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
  <%--  <style >
    .table>:not(caption)>*>* {
    padding: 0;
    background-color: var(--bs-table-bg);
    border-bottom-width: 1px;
    box-shadow: inset 0 0 0 9999px var(--bs-table-accent-bg);
   
}</style>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div class="container-fluid ">
        <div class="container "> 
        <form id="form1" class="form-control  " runat="server">

            <div class="text-center">
                <h1 class="text-success ">APPLICATION FORM </h1>
                <asp:Label ID="lblform" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>
            <div>
                <table cellpadding="3" cellspacing="5"  class="auto-style1 table-responsive ">
                        <tr style="width: 600px">
                        <td style="width: 500px">
                            <asp:DropDownList ID="ddl" class="dropdown btn btn-success form-control " runat="server" AutoPostBack="true">
                                <asp:ListItem>SELECT</asp:ListItem>
                                <asp:ListItem Value ="1">INCOME CERITIFICATE/आय प्रमाण पत्र</asp:ListItem>
                                <asp:ListItem Value ="2">CAST CERTIFICATE/जाति प्रमाण पत्र</asp:ListItem>
                                <asp:ListItem Value ="3">DOMICIAL CERTIFICATE/मूल निवासी प्रमाण पत्र</asp:ListItem>
                                <asp:ListItem Value ="4">RATION CARD/राशन कार्ड</asp:ListItem>
                                <asp:ListItem Value ="5">RATION CARD UNIT JOINT/राशन कार्ड यूनिट संयुक्त</asp:ListItem>
                                <asp:ListItem Value ="6">RATION CARD AADHAR SHEED/राशन कार्ड आधार शीड</asp:ListItem>
                                <asp:ListItem Value ="7">PAN CARD/पैन कार्ड</asp:ListItem>
                                <asp:ListItem Value ="8">VOTER ID CARD/मतदाता पहचान पत्र</asp:ListItem>
                                <asp:ListItem Value ="9">LABOUR CARD/श्रमिक कार्ड</asp:ListItem>
                                <asp:ListItem Value ="10">LABOUR CARD FEES PER YEAR/श्रम कार्ड शुल्क प्रति वर्ष</asp:ListItem>
                                <asp:ListItem Value ="11">LOBOUR CARD KYC/लेबर कार्ड केवाईसी</asp:ListItem>
                             <%--   <asp:ListItem Value ="12">KHASRA KHATOUNI(FARAD)/खसरा खतौनी (फराद)</asp:ListItem>--%>
                                <asp:ListItem Value ="13">TWO  WHEELER INSURANCE/दोपहिया वाहन का बीमा</asp:ListItem>
                                <asp:ListItem Value ="14">FOUR WHEELER INSURANCE/चार पहिया बीमा</asp:ListItem>
                                <asp:ListItem Value ="15">HEALTH INSURANCE/स्वास्थ्य बीमा</asp:ListItem>
                                <asp:ListItem Value ="16">AYUSHMAN CARD/आयुष्मान कार्ड</asp:ListItem>
                            </asp:DropDownList></td>
                    </tr>
                    <tr style="width: 600px">
                       <td class="auto-style3"><b>NAME </b><strong>:</strong>
                            <asp:TextBox ID="nametxt" CssClass ="form-control " placeholder="NAME" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>FATHER'S/HUSBAND'S NAME </b><strong>:</strong><br />
                            <asp:RadioButtonList ID="fhtype" runat="server">
                                <asp:ListItem>Husband</asp:ListItem>
                                <asp:ListItem>Father</asp:ListItem>
                            </asp:RadioButtonList> <asp:TextBox ID="fathrtxt" CssClass ="form-control " placeholder="HUSBAND/FATHER NAME" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>MOTHER'S NAME </b><strong>:</strong>
                            <asp:TextBox ID="mothrtxt" CssClass ="form-control " placeholder="MOTHER NAME" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>FULL ADDRESS </b><strong>:</strong>
                            <asp:TextBox ID="adstxt" CssClass ="form-control " placeholder="ENTER YOUR ADDRESS" runat="server" TextMode="MultiLine"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>TEHSIL </b><strong>:</strong>
                        <asp:TextBox ID="ctytxt" CssClass ="form-control " Text="Meerut" placeholder="CITY" runat="server"></asp:TextBox>

                            <asp:DropDownList ID="ddlcity" CssClass ="form-control " AutoPostBack="true"  placeholder="CITY" Visible="False" DataSourceID="sqlcity" DataTextField="TName"  DataValueField="TID" runat="server">
                            </asp:DropDownList>

                            <asp:SqlDataSource ID="sqlcity" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:conn %>" 
                                SelectCommand="SELECT * FROM [Tashil]"></asp:SqlDataSource>

                            &nbsp;</td>
                    </tr>
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>THANA </b><strong>:</strong>
                         <%--   <asp:TextBox ID="ctytxt" CssClass ="form-control " placeholder="CITY" runat="server"></asp:TextBox>--%>

                            <asp:DropDownList ID="ddlthana" CssClass ="form-control "  placeholder="Thana" Visible="False" DataTextField="Thana"  DataValueField="THID" runat="server">
                            </asp:DropDownList>

                         <%--   <asp:SqlDataSource ID="sqlthana" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:conn %>" 
                                SelectCommand="SELECT * FROM [THANA]"></asp:SqlDataSource>--%>

                            &nbsp;</td>
                    </tr>
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>VILLAGE </b><strong>:</strong>
                         <%--   <asp:TextBox ID="ctytxt" CssClass ="form-control " placeholder="CITY" runat="server"></asp:TextBox>--%>

                            <asp:DropDownList ID="ddlvill" CssClass ="form-control "  placeholder="Village" Visible="False"  DataTextField="village"  DataValueField="VID" runat="server">
                            </asp:DropDownList>

                         <%--   <asp:SqlDataSource ID="sqlvillage" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:conn %>" 
                                SelectCommand="SELECT * FROM [VILLAGE]"></asp:SqlDataSource>--%>

                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>DISTRICT </b><strong>:</strong>
                            <asp:TextBox ID="dsttxt" CssClass ="form-control " placeholder="DISTRICT" Text="Meerut"  runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>CAST </b><strong>:</strong>
                            <asp:DropDownList ID="ddlcast" CssClass ="form-control " AutoPostBack="true" placeholder="CAST" Visible="False"  DataSourceID="sqlcast" DataTextField="CAST"  DataValueField="CID" runat="server">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="sqlcast" runat="server" 
                                ConnectionString="<%$ ConnectionStrings:conn %>" 
                                SelectCommand="SELECT * FROM [Cast]"></asp:SqlDataSource>
                            &nbsp;</td>
                    </tr>
                     <tr style="width: 600px">
                        <td class="auto-style3"><b>SUB CAST </b><strong>:</strong>
                            <asp:DropDownList ID="ddlsubcast" CssClass ="form-control " placeholder="SUB CAST" Visible="False" required="required"  DataTextField="Subcast"  DataValueField="SID" runat="server">
                            </asp:DropDownList>
                          
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>MOBILE NUMBER </b><strong>:</strong>
                            <asp:TextBox ID="mbtxt" CssClass ="form-control " onkeypress="return isNumberKey(event)" maxlength="10" placeholder="MOBILE NUMBER" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>
                   <%-- <tr style="width: 600px">
                        <td class="auto-style3"><b>NUMBER OF FAMILY MEMBER'S</b><strong>:</strong>
                            <asp:TextBox ID="fmtxt" CssClass ="form-control " onkeypress="return isNumberKey(event)" placeholder="NO. OF  MEMBER'S" runat="server"></asp:TextBox>
                            &nbsp;</td>
                    </tr>--%>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>FAMILY ANNUAL INCOME </b><strong>:</strong>
                            <asp:TextBox ID="faitxt" CssClass ="form-control " onkeypress="return isNumberKey(event)" placeholder="ANNUAL INCOME" runat="server"></asp:TextBox><span class ="text-danger " >(Only Income Certificate)</span>
                            &nbsp;</td>
                    </tr>
                    <tr style="width: 600px">
                        <td class="auto-style3"><b>FAMILY INCOME CATEGORY </b><strong>:</strong>
                            &nbsp;</td>
                    </tr>
                        <tr style="width: 600px">
                        <td style="width: 500px">
                            <asp:DropDownList ID="ddlicm" class="dropdown btn btn-success  form-control " runat="server" AutoPostBack="false">
                                <asp:ListItem>SELECT</asp:ListItem>
                                <asp:ListItem>AGRICULTURE</asp:ListItem>
                                 <asp:ListItem>HOUSE WIFE</asp:ListItem>
                                 <asp:ListItem>STUDENT</asp:ListItem>
                                <asp:ListItem>PRIVATE JOB</asp:ListItem>
                                 <asp:ListItem>GOVERNMENT JOB</asp:ListItem>
                                <asp:ListItem>BUSSINESS</asp:ListItem>
                                <asp:ListItem>PENSION</asp:ListItem>

                            </asp:DropDownList></td>
                    </tr>
                    <tr >
                        
                        <td >
                            <asp:TextBox ID="srcicmtxt" cssclass="form-control " onkeypress="return isNumberKey(event)" placeholder="INCOME" runat="server"></asp:TextBox>

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
                   <table cellpadding="3" cellspacing="5"  class="auto-style1 table-responsive">
                        <tr>
                        <td>
                            <b >Browse File For Uploading </b><strong>:</strong>
                        </td>
                    </tr>
                
                
                    <tr>
                        <td>
                            <asp:Label ID="doblb" runat="server"  Text="DATE OF BIRTH" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="lclb" runat="server" Text="LABOUR CARD" Visible="False" Font-Bold="True"></asp:Label>
                            <asp:Label ID="khsnmlb" runat="server" Text="KHASRA NUMBER" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="rclb" runat="server" Text="RC PHOTO" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="photolb" runat="server" Text="PHOTO" Visible="False" Font-Bold="True"></asp:Label>
                            <br />
                            <div >
                                <asp:TextBox ID="dobtxt" class="form-control " runat="server" Visible="False" TextMode="Date"></asp:TextBox>
                                <asp:TextBox ID="khsnmtxt" class ="form-control " Visible="false" runat="server"></asp:TextBox>
                                <asp:FileUpload ID="photoupd" class="form-control " runat="server" Visible="False" /><%--<asp:Button ID="phtbtn" runat="server" class="btn btn-success "  Text="UPLOAD" Visible="False" />--%>
                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="engnmlb" runat="server" Text="ENGINE NUMBER" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="cndlb" runat="server" Text="CANDIDATE NAME" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="adhcrdlb" runat="server" Text="AADHAR CARD FRONT" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="adhcrdalcndlb" runat="server" Text="AADHAR CARD ALL CANDIDATE" Visible="False" Font-Bold="True"></asp:Label><br />
                            
                            <div >
                                <asp:TextBox ID="engtxt" class ="form-control " Visible="false" runat="server"></asp:TextBox>
                                <asp:TextBox ID="cndname" class ="form-control " Visible="false" runat="server"></asp:TextBox>
                                <asp:FileUpload ID="adcrdupd" class="form-control " runat="server" Visible="False" /><%--<asp:Button ID="adcrdbtn" runat="server" class="btn btn-success " Text="UPLOAD" Visible="False" />--%></div>

                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">
                            <asp:Label ID="lbladhrback" runat="server" Text="ADHAR CARD BACK" Visible="False"  Font-Bold="True"></asp:Label><br />
                            <div>
                                  <asp:FileUpload ID="updadhrbck" class="form-control " Visible="False" runat="server"  />
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="chsnmlb" runat="server" Text="CHASIS NUMBER" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="vlglb" runat="server" Text="VILLAGE NAME" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="sslb" runat="server" Text="SALARY SLIP" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="plplb" runat="server" Text="PRADHAN LETTER PAID(CAST)" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="eclb" runat="server" Text="ELECTRICITY BILL" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="signlb" runat="server" Text="SIGNATURE" Visible="False" Font-Bold="True"></asp:Label>
                            <br />
                            <div >
                                <asp:TextBox ID="chsnmtxt" class ="form-control " Visible="false" runat="server"></asp:TextBox>
                                <asp:FileUpload ID="ssupd" class="form-control " runat="server" Visible="False" /><%--<asp:Button ID="ssbtn" runat="server" class="btn btn-success " Text="UPLOAD" Visible="False" />--%></div>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="thnmlb" runat="server" Text="TEHSIL NAME" Visible="False" Font-Bold="True"></asp:Label>
                            <asp:Label ID="rtbcrdlb" runat="server" Text="RATION CARD" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="rtncrdeblb" runat="server" Text="RATION CARD or ELECTRICITY BILL" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="bnkpsklb" runat="server" Text="BANK PASSBOOK" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="rtncrdnmlb" runat="server" Text="RATION CARD NUMBER" Visible="False" Font-Bold="True"></asp:Label>
                            <br />
                            <div >
                                <asp:TextBox ID="rtnnmtxt" class ="form-control" runat="server" Visible="False"></asp:TextBox>
                                <asp:FileUpload ID="rtncrdupd" class="form-control " runat="server" Visible="False" /><%--<asp:Button ID="rtncrdbtn" class="btn btn-success " runat="server" Text="UPLOAD" Visible="False" />--%>

                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="dstlb" runat="server" Text="DISTRICT" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="splb" runat="server" Text="SAPAT PATR" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="mbnmlb" runat="server" Text="MOBILE NUMBER" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="nadhcrdlb" runat="server" Text="NOMINI AADHAR CARD" Visible="False" Font-Bold="True"></asp:Label>
                            <br />
                            <div >
                                <asp:TextBox ID="thtxt" class ="form-control" runat="server" Visible="false"></asp:TextBox>
                                <asp:FileUpload ID="spupd" class="form-control " runat="server" Visible="False" /><%--<asp:Button ID="spbtn" class="btn btn-success " runat="server" Text="UPLOAD" Visible="False" />--%>

                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="mrkshtlb" runat="server" Text="MARKSHEET" Visible="False" Font-Bold="True"></asp:Label><asp:Label ID="mbpdlb" runat="server" Text="MARKSHEET or BANK PASSBOOK or PASSPORT or DL" Visible="False" Font-Bold="True"></asp:Label>
                            <br />
                            <div >
                                <asp:FileUpload ID="mrkshtupd" class="form-control " runat="server" Visible="False" /><%--<asp:Button ID="mrkshtbtn" class="btn btn-success " runat="server" Text="UPLOAD" Visible="False" />--%><br />
                                <br />

                            </div>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="nplb" runat="server" Text="NIYOJAN PATR" Visible="False" Font-Bold="True"></asp:Label>
                            <br />
                            <div >
                                <asp:FileUpload ID="npupd" class="form-control " runat="server" Visible="False" /><%--<asp:Button ID="npbtn" class="btn btn-success " runat="server" Text="UPLOAD" Visible="False" />--%>

                            </div>

                        </td>
                    </tr>
                    
                     <tr style="width: 600px">
                        <td class="auto-style3">
                             <b>Deposit Amount </b><strong>:</strong>
                            <asp:TextBox ID="txtamt"  onkeypress="return isNumberKey(event)"  MaxLength ="10" CssClass="form-control"  runat="server" ReadOnly="true"  ></asp:TextBox>
                        </td>
                        </tr>
                       <tr style="width: 600px">
                         <td class="auto-style3" >
                             <b>Transaction Number </b><strong>:</strong>
                             <asp:TextBox ID="txttrnnum" class="form-control" MaxLength ="30" runat="server"></asp:TextBox>
                        </td>
                        </tr>
                       <tr>
                           <td>
                               <asp:Label ID="lblupi" runat="server" Text="Upi Id = right99service@ybl"></asp:Label>
                        </td>
                    </tr>
                       <tr >
                           <td>         
                               
                                <img src="assets/img/barcode.jpeg"  class="img-thumbnail" alt="barcode" width="304" height="236" />
                               
                              
                           </td> 
                       </tr>
                             <tr>
                        <td>
                            <asp:Button ID="sbtbtn"  runat="server" class="btn btn-success " AutoPostBack="true"  Text="SUBMIT" Visible="false"  OnClientClick="return confirm('Do you want to Save and Print!')" />
                        </td>
                    </tr>

                </table>
             
            </div>
        </form>
            </div> 
    </div>

 











</asp:Content>

