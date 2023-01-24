<%@ Page Title="" Language="VB" MasterPageFile="~/Mainpage.master" AutoEventWireup="false" CodeFile="morelink.aspx.vb" Inherits="morelink" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <style >
        .brdr{
            align-content :center ;
            text-align :center ;
            border :2px solid silver;
        }
    </style>
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<form id="Form1" runat ="server" >
    <table class="table table-responsive">
       
        <tr>
            <td class="brdr"> <a href="https://myaadhaar.uidai.gov.in/genricDownloadAadhaar
" target="_blank">आधार कार्ड प्राप्त करें</a><b>
</b></td>
            <td class="brdr" > <a href="https://www.nvsp.in/ " target="_blank">पहचान पत्र सूची देखें</a><b></b></td>
          
           
        </tr>

        <tr>
           <td class="brdr"> <a href="http://upagriculture.com/Record_Fatch.aspx" target="_blank">किसान पंजीकरण देखें</a><b></b></td>
            <td class="brdr"> <a href="https://electoralsearch.in/" target="_blank">पहचान पत्र सूची</a><b></b></td>
           
           
        </tr>
        <tr>
            <td class="brdr"> <a href="https://ccsuresults.com/ " target="_blank">चौo चरण सिंह विश्वविधालय परीक्षा परिणाम देखें</a><b></b></td>
            <td class="brdr"> <a href="http://upagriculture.com/ " target="_blank">कृषि विभाग उत्तरप्रदेश</a><b></b></td>
          
        </tr>
        <tr>
            <td class="brdr"> <a href="https://pmkisan.gov.in/BeneficiaryStatus.aspx " target="_blank">प्रधान मंत्री किसान सम्मान निधि योजना लाभार्थी स्थिति</a><b></b></td>
            <td class="brdr"> <a href="https://fw.pmkisan.gov.in/aadharekyc.aspx " target="_blank">प्रधान मंत्री किसान सम्मान निधि योजना मे ( K Y C ) करें</a><b></b></td>
             

        </tr>
        <tr>
            <td class="brdr"> <a href="https://www.cowin.gov.in/" target="_blank">कोविड-19 टीकाकरण प्रमाणपत्र डाउनलोड</a><b></b></td>
            <td class="brdr"> <a href="https://selfregistration.cowin.gov.in/" target="_blank">कोविड-19 टीकाकरण पंजीकरण करें</a><b></b></td>
            
          

        </tr>
        <tr>
            <td class="brdr"> <a href="https://upbhulekh.gov.in/public/public_ror/Public_ROR.jsp" target="_blank">भूलेख KHASRA KHATONI (FARAD)</a><b></b></td>
            <td class="brdr"> <a href="https://www.swavlambancard.gov.in/" target="_blank">विकलांग प्रमाण पत्र</a><b></b></td>
             
           

        </tr>
        <tr>
            <td class="brdr"> <a href="https://parivahan.gov.in/parivahan/" target="_blank">परिवहन सेवा</a><b></b></td>
            <td class="brdr"> <a href="https://www.nvsp.in/
" target="_blank">मतदाता सूची देखें
</a><b></b></td>
            
          
             

        </tr>
         <tr>
            <td class="brdr"> <a href="https://www.makemytrip.com/mbus" target="_blank">ट्रेवल साइट /बुक हॉटेल्स, फ्लाइट etc</a><b></b></td>
             <td class="brdr"> <a href="https://enquiry.caneup.in/GrwEnquiry.aspx" target="_blank">गन्ना कैलेण्डर देखें</a><b></b></td>
             
        </tr>
         <tr>
            <td class="brdr"> <a href="https://uppcl.mpower.in/wss/QuickBillPay.htm" target="_blank">बिजली बिल देखें /जमा करें</a><b></b></td>
               <td class="brdr"> <a href="https://upmsp.edu.in/Default.aspx" target="_blank">उत्तरप्रदेश मध्यमिक शिक्षा परिषद्</a><b></b></td>
             
        </tr>
         <tr>
              <td class="brdr"> <a href="https://sbi.co.in/web/personal-banking/investments-deposits/govt-schemes/sukanya-samriddhi-yojana " target="_blank">सुकन्या समृद्धि योजना आवेदन</a><b></b></td>
               <td class="brdr"> <a href="https://maandhan.in/" target="_blank">मानधन योजाना के लिए आवेदन</a><b></b></td>
        </tr>
         <tr>
              <td class="brdr"> <a href="https://unifiedportal-mem.epfindia.gov.in/memberinterface/ " target="_blank">प्राईवेट जॉब P F स्थिति देखें</a><b></b></td>  
               <td class="brdr"> <a href="https://www.passportindia.gov.in/AppOnlineProject/welcomeLink# " target="_blank">पासपोर्ट आवेदन करें</a><b></b></td>
        </tr>
        <tr>
          <td class="brdr"> <a href="https://www.cbse.gov.in/ " target="_blank">केंद्रीय माध्यमिक शिक्षा बोर्ड cbse board</a><b></b></td>
           <td class="brdr"> <a href="https://mksy.up.gov.in/women_welfare/index.php  " target="_blank">सुमंगला योजना के लिए आवेदन</a><b></b></td>
          
          </tr>
          <tr>  <td class="brdr"> <a href="https://exam.ccsuweb.in/ " target="_blank">चौo चरण सिंह विश्वविधालय परीक्षा पत्र आवेदन</a><b></b></td>
           <td class="brdr"> <a href="https://www.sarkariresult.com/2022/up-scholarship-2022/" target="_blank">उत्तर प्रदेश छात्रवृति एवं शुल्क प्रतिपूर्ति आवेदन</a><b></b></td>
          
          </tr>
           <tr>  <td class="brdr"> <a href="https://tin.tin.nsdl.com/pantan/StatusTrack.html " target="_blank">पेन कार्ड स्थिति देखें</a> <b> </b></td> 
          </tr>
    </table>
    </form>
</asp:Content>

