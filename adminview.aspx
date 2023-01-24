<%@ Page Title="" Language="VB" MasterPageFile="~/Mainpage.master" AutoEventWireup="false" CodeFile="adminview.aspx.vb" Inherits="adminview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style >
        .btngrp{
            display :inline-block;
            float :left ;
            padding :10px;
            max-width :100%;
           
        }
        .h{
            margin :20px;
        }
    </style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    
     <form id="form1"  runat="server">
     <div style="background-color :green ;overflow :auto  ">
         <div class ="btngrp ">
             <asp:DropDownList ID="ddlstatus" CssClass ="btn btn-success h" runat="server">
                 <asp:ListItem >SELECT</asp:ListItem>
                 <asp:ListItem Value ="1">PENDING</asp:ListItem>
                 <asp:ListItem Value ="2">COMPLETED</asp:ListItem>
             </asp:DropDownList>   <asp:DropDownList ID="ddlcert" CssClass ="btn btn-success h" runat="server">
                 <asp:ListItem >SELECT</asp:ListItem>
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
                                <asp:ListItem Value ="12">KHASRA KHATOUNI(FARAD)/खसरा खतौनी (फराद)</asp:ListItem>
                                <asp:ListItem Value ="13">TWO  WHEELER INSURANCE/दोपहिया वाहन का बीमा</asp:ListItem>
                                <asp:ListItem Value ="14">FOUR WHEELER INSURANCE/चार पहिया बीमा</asp:ListItem>
                                <asp:ListItem Value ="15">HEALTH INSURANCE/स्वास्थ्य बीमा</asp:ListItem>
                                <asp:ListItem Value ="16">AYUSHMAN CARD/आयुष्मान कार्ड</asp:ListItem>
             </asp:DropDownList>
             <asp:TextBox ID="txtfromdate" CssClass ="h" runat="server" TextMode="Date"></asp:TextBox> <asp:TextBox ID="txttodate" CssClass ="h" runat="server" TextMode="Date"></asp:TextBox>  
             <asp:Button ID="search" CssClass="btn btn-success " runat="server" Text="Search" />
                 <asp:Button ID="btndlt" CssClass="btn btn-success " runat="server" Text="Delete" />
         </div>
     </div>
         <br />

             <asp:GridView ID="gvDetails" CssClass ="table  table-hover table-responsive"  runat="server" DataKeyNames="sno"  AutoGenerateColumns="False" OnRowDataBound="OnRowDataBound"
    Font-Names="Arial" Font-Size="Small" >


    <Columns>
        
        <asp:TemplateField>
            <ItemTemplate>
                <asp:CheckBox id="chkbox" runat="server"></asp:CheckBox>
            </ItemTemplate>
        </asp:TemplateField>
           <asp:TemplateField HeaderText="SNo">
     <ItemTemplate>
     <span>
     <%#Container.DataItemIndex + 1%>
     </span>
     </ItemTemplate>
     </asp:TemplateField> 
        <asp:BoundField DataField="name" HeaderText="Name" />
        <asp:BoundField DataField="ddlval" HeaderText="Document" />
        <asp:BoundField DataField="cdate" HeaderText="Date" />
        <asp:BoundField DataField="f_name" HeaderText="Applied By" />
         <asp:TemplateField HeaderText="Show Status">
         <ItemTemplate>  
                        <asp:DropDownList ID="ddlstatus" SelectedValue='<%# Bind("status")%>'  CssClass="btn btn-success" runat="server"> 
                                <asp:ListItem Value ="1" >Pending</asp:ListItem>
                                <asp:ListItem Value ="2" >Completed</asp:ListItem> 
                           
                        </asp:DropDownList>  
         </ItemTemplate>
        </asp:TemplateField>
         
   
        <asp:TemplateField HeaderText="View">
            <ItemTemplate   >
                <asp:Button ID="viewbtn" CssClass="btn btn-success" CommandName="Select" Text="View" runat="server" OnClick="viewclcik"  />
            </ItemTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Document Upload">
            <ItemTemplate   >
                <asp:FileUpload ID="updcert" runat="server" CssClass="btn btn-success"  />
            </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="Receipt Upload">
            <ItemTemplate   >
                <asp:FileUpload ID="updrec" runat="server" CssClass="btn btn-success"  />
            </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="Save">
            <ItemTemplate   >
                <asp:LinkButton Text="Update" runat="server" CssClass="btn btn-success" CommandName="Select" OnClick="updateclick" />
            </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="Delete">
            <ItemTemplate   >
                <asp:LinkButton Text="Delete" runat="server" CssClass="btn btn-success" CommandName="Delete" OnClientClick="return confirm('Do you want to Delete!')"  formnovalidate/>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
     <EmptyDataTemplate>
        <div align="center">No records found.</div>
    </EmptyDataTemplate>
    <HeaderStyle BackColor="green" Font-Bold="True" ForeColor="#CCCCFF" />
</asp:GridView>
  
    </form>
       

</asp:Content>

