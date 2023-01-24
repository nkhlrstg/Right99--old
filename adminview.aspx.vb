Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Configuration
Imports System.Drawing
Partial Class adminview
    Inherits System.Web.UI.Page
    Dim dbconn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conn").ConnectionString)
    Dim cmd As New SqlCommand()

    Dim i As Integer = 0
    Protected Sub BindUserDetails()
   
        dbconn.Open()
        cmd = New SqlCommand("select sno, name,cdate,case when ddlval = '1' then 'INCOME CERITIFICATE' when ddlval = '2' then 'CAST CERTIFICATE' when ddlval = '3' then 'DOMICIAL CERTIFICATE' when ddlval = '4' then 'RATION CARD' when ddlval = '5' then 'RATION CARD UNIT JOINT' when ddlval = '6' then 'RATION CARD AADHAR SHEED' when ddlval = '7' then 'PAN CARD' when ddlval = '8' then 'VOTER ID CARD'" & _
"when ddlval= '9' then 'LABOUR CARD' when ddlval='10' then 'LABOUR CARD FEES PER YEAR' when ddlval = '11' then 'LOBOUR CARD KYC' when ddlval = '12' then 'KHASRA KHATOUNI(FARAD)' when ddlval = '13' then 'TWO  WHEELER INSURANCE' when ddlval = '14' then 'FOUR WHEELER INSURANCE' when ddlval = '15' then 'HEALTH INSURANCE' when ddlval='16' then 'AYUSHMAN CARD' ELSE NULL END as ddlval, status ,r.f_name from form f , regis r where f.us_id = r.us_id   order by  cdate desc ", dbconn)
        Dim dr = cmd.ExecuteReader

        gvDetails.DataSource = dr
        gvDetails.DataBind()
        dr.Close()
        dbconn.Close()

    End Sub

    Protected Sub OnRowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lbl As Label = TryCast(e.Row.FindControl("lblpending"), Label)
            Dim btn As Button = TryCast(e.Row.FindControl("btncompleted"), Button)

            If e.Row.Cells(3).Text.Trim().ToLower() = "pending" Then
                lbl.Visible = True
                btn.Visible = False
            End If
            If e.Row.Cells(3).Text.Trim().ToLower() = "completed" Then
                lbl.Visible = False
                btn.Visible = True
            End If
      
        End If
    End Sub
    Public Sub viewclcik()
        i = 1
    End Sub
    Public Sub updateclick()
        i = 2
    End Sub
    Public Sub deleteclick()
        i = 3
    End Sub
    Protected Sub OnUpdate(ByVal selctedindex As Integer, ByVal sno As Integer)

        '     Dim row As GridViewRow = TryCast((TryCast(sender, LinkButton)).NamingContainer, GridViewRow)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 61)
            sb.Append(s.Substring(idx, 1))
        Next
        Dim fileName As String = ""
        Dim filename1 As String = ""
        Dim statusid As String = ""

        Dim k = sb.ToString()

        If TryCast(gvDetails.Rows(selctedindex).FindControl("updcert"), FileUpload).HasFile = True Then
            Dim fileup As FileUpload = TryCast(gvDetails.Rows(selctedindex).FindControl("updcert"), FileUpload)

            fileName = Path.GetExtension(fileup.FileName)

            fileup.PostedFile.SaveAs(Server.MapPath("UPLOADS/certificate/" + k + fileName))


            cmd = New SqlCommand("update form set certfilename=@certfile where sno=" & sno & " ", dbconn)

            cmd.Parameters.AddWithValue("certfile", k + fileName)

            dbconn.Open()
            cmd.ExecuteNonQuery()
            dbconn.Close()
        End If
        If TryCast(gvDetails.Rows(selctedindex).FindControl("updrec"), FileUpload).HasFile = True Then
            Dim filerecpt As FileUpload = TryCast(gvDetails.Rows(selctedindex).FindControl("updrec"), FileUpload)
            filename1 = Path.GetExtension(filerecpt.FileName)
            filerecpt.PostedFile.SaveAs(Server.MapPath("UPLOADS/receipt/" + k + filename1))
            cmd = New SqlCommand("update form set receipt=@rec where sno=" & sno & " ", dbconn)

            cmd.Parameters.AddWithValue("rec", k + filename1)

            dbconn.Open()
            cmd.ExecuteNonQuery()
            dbconn.Close()
        End If


        statusid = TryCast(gvDetails.Rows(selctedindex).FindControl("ddlstatus"), DropDownList).SelectedValue

        cmd = New SqlCommand("update form set status =@status  where sno=" & sno & " ", dbconn)

        cmd.Parameters.AddWithValue("status", statusid)
        dbconn.Open()
        cmd.ExecuteNonQuery()
        dbconn.Close()
        Me.BindUserDetails()
    End Sub

  
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("Userid") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If
     
        If Not IsPostBack Then
            If Not IsPostBack Then
                'txtfromdate.Text = DateTime.Now.ToString("dd-MMM-yyyy")
                'txttodate.Text = DateTime.Now.ToString("dd-MMM-yyyy")
            End If
            BindUserDetails()
        End If
    End Sub

    Protected Sub view()
        Response.Redirect("view.aspx")
    End Sub

    Protected Sub gvDetails_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles gvDetails.RowDeleting
        Dim sno As String = gvDetails.DataKeys(e.RowIndex).Value
        dbconn.Open()
        cmd = New SqlCommand("delete  from form where sno ='" & sno & "' ", dbconn)
        cmd.Parameters.AddWithValue("ddlstatus", ddlstatus.SelectedValue)
        cmd.ExecuteNonQuery()
        dbconn.Close()
        BindUserDetails()
    End Sub

   


    Protected Sub gvDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gvDetails.SelectedIndexChanged
        Session("sno") = gvDetails.DataKeys(gvDetails.SelectedIndex).Value

        If i = 1 Then
            view()
        ElseIf i = 2 Then
            OnUpdate(gvDetails.SelectedIndex, Session("sno"))
        Else
            delete()
        End If
     


    End Sub

    Public Sub delete()
       
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
    'Protected Function RandomString() As String
    '    Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
    '    Dim r As New Random
    '    Dim sb As New StringBuilder
    '    For i As Integer = 1 To 8
    '        Dim idx As Integer = r.Next(0, 35)
    '        sb.Append(s.Substring(idx, 1))
    '    Next
    '    Return sb.ToString()
    'End Function
  
   
    Protected Sub search_Click(sender As Object, e As EventArgs) Handles search.Click

        Try
            dbconn.Open()
            cmd = New SqlCommand("select  status,sno,name, case when ddlval = '1' then 'INCOME CERITIFICATE' when ddlval = '2' then 'CAST CERTIFICATE' when ddlval = '3' then 'DOMICIAL CERTIFICATE' when ddlval = '4' then 'RATION CARD' when ddlval = '5' then 'RATION CARD UNIT JOINT' when ddlval = '6' then 'RATION CARD AADHAR SHEED' when ddlval = '7' then 'PAN CARD' when ddlval = '8' then 'VOTER ID CARD'" & _
                "when ddlval= '9' then 'LABOUR CARD' when ddlval='10' then 'LABOUR CARD FEES PER YEAR' when ddlval = '11' then 'LOBOUR CARD KYC' when ddlval = '12' then 'KHASRA KHATOUNI(FARAD)' when ddlval = '13' then 'TWO  WHEELER INSURANCE' when ddlval = '14' then 'FOUR WHEELER INSURANCE' when ddlval = '15' then 'HEALTH INSURANCE' when ddlval='16' then 'AYUSHMAN CARD' ELSE NULL END as ddlval,cdate,r.f_name from form f inner join regis r on f.us_id= r.us_id  where   cdate between @from and @to or status=@ddlstatus or ddlval=@ddlcert ", dbconn)
            cmd.Parameters.AddWithValue("ddlstatus", ddlstatus.SelectedValue)
            cmd.Parameters.AddWithValue("ddlcert", ddlcert.SelectedValue)
            cmd.Parameters.AddWithValue("from", txtfromdate.Text)
            cmd.Parameters.AddWithValue("to", txttodate.Text)
            Dim dr = cmd.ExecuteReader
            gvDetails.DataSource = dr
            gvDetails.DataBind()
            dr.Close()
            dbconn.Close()
        Catch ex As Exception

        End Try
    

        'If ddlstatus.SelectedIndex > 0 Then
        '    dbconn.Open()
        '    cmd = New SqlCommand("select  status,sno,name,ddlval,cdate,f_name from form where status=@ddlstatus ", dbconn)
        '    cmd.Parameters.AddWithValue("ddlstatus", ddlstatus.SelectedValue)
        '    Dim dr = cmd.ExecuteReader
        '    gvDetails.DataSource = dr
        '    gvDetails.DataBind()
        '    dr.Close()
        '    dbconn.Close()
        'End If
        'If ddlcert.SelectedIndex > 0 Then
        '    dbconn.Open()
        '    cmd = New SqlCommand("select * from form where ddlval=@ddlcert ", dbconn)
        '    cmd.Parameters.AddWithValue("ddlcert", ddlcert.SelectedValue)
        '    Dim dr = cmd.ExecuteReader
        '    gvDetails.DataSource = dr
        '    gvDetails.DataBind()
        '    dr.Close()
        '    dbconn.Close()
        'End If
    End Sub

    Protected Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click
        Dim srno As String = ""
        For Each rw As GridViewRow In gvDetails.Rows
            If CType(rw.FindControl("chkbox"), CheckBox).Checked = True Then
                Dim sno As String = gvDetails.DataKeys(rw.RowIndex).Value
                If srno = "" Then
                    srno = sno
                Else
                    srno = srno + "," + sno
                End If

            End If
        Next

        If srno = "" Then
            MsgBox("Please selecte any checkbox")
            Exit Sub
        End If

        dbconn.Open()
        cmd = New SqlCommand("delete  from form where sno in (" & srno & ") ", dbconn)

        cmd.ExecuteNonQuery()
        dbconn.Close()
        BindUserDetails()

    End Sub
End Class
