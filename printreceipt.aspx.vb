Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Configuration
Imports System.Drawing
Partial Class printreceipt
    Inherits System.Web.UI.Page
    Dim dbconn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conn").ConnectionString)
    Dim cmd As New SqlCommand()


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("Userid") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If
        dbconn.Open()
        cmd = New SqlCommand(" select name,mob_num,cdate,sno,amount,transactionno,case when ddlval = '1' then 'INCOME CERITIFICATE' when ddlval = '2' then 'CAST CERTIFICATE' when ddlval = '3' then 'DOMICIAL CERTIFICATE' when ddlval = '4' then 'RATION CARD' when ddlval = '5' then 'RATION CARD UNIT JOINT' when ddlval = '6' then 'RATION CARD AADHAR SHEED' when ddlval = '7' then 'PAN CARD' when ddlval = '8' then 'VOTER ID CARD'" & _
"when ddlval= '9' then 'LABOUR CARD' when ddlval='10' then 'LABOUR CARD FEES PER YEAR' when ddlval = '11' then 'LOBOUR CARD KYC' when ddlval = '12' then 'KHASRA KHATOUNI(FARAD)' when ddlval = '13' then 'TWO  WHEELER INSURANCE' when ddlval = '14' then 'FOUR WHEELER INSURANCE' when ddlval = '15' then 'HEALTH INSURANCE' when ddlval='16' then 'AYUSHMAN CARD' ELSE NULL END as ddlval  from form where sno=@serial ", dbconn)
        cmd.Parameters.AddWithValue("serial", Session("s"))
        Dim dr = cmd.ExecuteReader
        While dr.Read
            lblname.Text = dr.Item("name")
            lblmob.Text = dr.Item("mob_num")
            lbldist.Text = dr.Item("ddlval")
            lbldate.Text = dr.Item("cdate")
            lbltrans.Text = dr.Item("transactionno")
            lblappnum.Text = "F000" + dr.Item("sno").ToString
            lblamt.Text = dr.Item("amount")
        End While
        dr.Close()
        dbconn.Close()
    End Sub
    Protected Sub btnprint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnprint.Click

        Try
            System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "Script", "Print();", True)
        Catch ex As Exception
        End Try

    End Sub
End Class
