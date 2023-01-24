Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Configuration
Imports System.Drawing
Partial Class status
    Inherits System.Web.UI.Page
    Dim dbconn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conn").ConnectionString)
    Dim cmd As New SqlCommand()
    Dim i As Integer = 0
    Protected Sub BindUserDetails()
       

        dbconn.Open()
        cmd = New SqlCommand("select sno,name,cdate,case when ddlval = '1' then 'INCOME CERITIFICATE' when ddlval = '2' then 'CAST CERTIFICATE' when ddlval = '3' then 'DOMICIAL CERTIFICATE' when ddlval = '4' then 'RATION CARD' when ddlval = '5' then 'RATION CARD UNIT JOINT' when ddlval = '6' then 'RATION CARD AADHAR SHEED' when ddlval = '7' then 'PAN CARD' when ddlval = '8' then 'VOTER ID CARD'" & _
                            "when ddlval= '9' then 'LABOUR CARD' when ddlval='10' then 'LABOUR CARD FEES PER YEAR' when ddlval = '11' then 'LOBOUR CARD KYC' when ddlval = '12' then 'KHASRA KHATOUNI(FARAD)' when ddlval = '13' then 'TWO  WHEELER INSURANCE' when ddlval = '14' then 'FOUR WHEELER INSURANCE' when ddlval = '15' then 'HEALTH INSURANCE' ELSE NULL END as ddlval  ,f_name, case when status ='1' then 'Pending' else 'Completed' end as status from form   where  us_id=" & Session("Userid") & " order by  cdate desc ", dbconn)
        Dim dr = cmd.ExecuteReader
     
        gvDetails.DataSource = dr
        gvDetails.DataBind()
        dr.Close()
        dbconn.Close()

    End Sub
    Public Sub viewclcik()
        i = 1
    End Sub
    Public Sub downloadfile()
        i = 2
    End Sub
    Protected Sub download(ByVal sender As Object, ByVal sno As Integer)
        Dim k As String = ""
        Try
            dbconn.Open()
            cmd = New SqlCommand("select certfilename from form where sno=@sno", dbconn)
            cmd.Parameters.AddWithValue("sno", Session("sno"))
            Dim dr = cmd.ExecuteReader
            If dr.Read Then
                k = dr.Item("certfilename")
            End If
            dr.Close()
            dbconn.Close()
            Dim filename As String = k
            'Dim filePaths() As String = System.IO.Directory.GetFiles(Server.MapPath("uploads/certificate/"), "" & filename & "*")

            'Dim files As List(Of ListItem) = New List(Of ListItem)
            'For Each filePath As String In filePaths
            '    files.Add(New ListItem(Replace(Replace(Path.GetFileNameWithoutExtension(filePath), Session("sno").ToString + "_", ""), "Certificate_", "File_"), Path.GetFileName(filePath)))
            'Next
            'Dim filePath As String = "uploads/certificate/" + CType(sender, LinkButton).CommandArgument

            'Dim filedownload As String = filePaths


            Dim serverip As String = ""

            serverip = "http://right99androapp.macerptechnologies.com/uploads/certificate/"

            'If Cache("androFolder").ToString.Contains("macerptechnologies") = True Or Cache("androFolder").ToString.Contains("macerptech") = True Then
            '    serverip = "http://right99androapp.macerptechnologies.com/"
            'End If


            Dim FILeLINK As String = serverip + filename
            System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "UpdateAPP", "UpdateAPP('" & FILeLINK & "');", True)
            Me.BindUserDetails()
        Catch ex As Exception

        End Try

    End Sub
    Protected Sub OnRowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lbl As Label = TryCast(e.Row.FindControl("lblpending"), Label)
            Dim btn As LinkButton = TryCast(e.Row.FindControl("btncompleted"), LinkButton)

            If e.Row.Cells(4).Text.Trim().ToLower() = "pending" Then
                lbl.Visible = True
                btn.Visible = False
            End If
            If e.Row.Cells(4).Text.Trim().ToLower() = "completed" Then
                lbl.Visible = False
                btn.Visible = True
            End If
         
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("Userid") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If
        If Session("Userid") = 100 Then
            Response.Redirect("adminview.aspx")
        End If
        If Not IsPostBack Then

            BindUserDetails()
        End If
    End Sub

  
    Protected Sub view()
        Response.Redirect("view.aspx")
    End Sub

  

    Protected Sub gvDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvDetails.SelectedIndexChanged
        Session("sno") = gvDetails.DataKeys(gvDetails.SelectedIndex).Value

        If i = 1 Then
            view()
        Else
            download(gvDetails.SelectedIndex, Session("sno"))
        End If


    End Sub

    'Protected Sub download()

    '    Dim filePath As String = Server.MapPath(String.Format("~uploads"))
    '    Dim fileName As String() = System.IO.Directory.GetFiles(filePath)

    '    Response.ContentType = "application/pdf"
    '    Response.AppendHeader("Content-Disposition", ("attachment; filename=" + "fileName"))

    '    Response.WriteFile(filePath)
    '    Response.Flush()
    '    Response.End()
    'End Sub

   
End Class
