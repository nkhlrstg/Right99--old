Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Configuration
Imports System.Drawing
Partial Class view
    Inherits System.Web.UI.Page
    Dim dbconn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conn").ConnectionString)
    Dim cmd As New SqlCommand()
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("Userid") Is Nothing Then
            Response.Redirect("login.aspx")
        End If
        If Not IsPostBack Then
            dbconn.Open()
            cmd = New SqlCommand("select form.*,Tashil.*,Cast.*,SubCast.*,THANA.*,VILLAGE.* from form inner join Tashil on Tashil.TID=form.city inner join  Cast  on cast.CID = form.cast inner join SubCast on SubCast.SID=form.subcast inner join THANA  on THANA.TID=Tashil.TID inner join VILLAGE  on VILLAGE.TID=Tashil.TID  where sno = @nme ", dbconn)

            cmd.Parameters.AddWithValue("nme", Session("sno"))
            Dim dr = cmd.ExecuteReader
            Dim city As Integer
            If dr.Read Then
                nametxt.Text = dr.Item("name")
                fhtype.SelectedIndex = dr.Item("fhtype")
                fathrtxt.Text = dr.Item("f_name")
                mothrtxt.Text = dr.Item("m_name")
                adstxt.Text = dr.Item("addres")
                city = dr.Item("city")
                dsttxt.Text = dr.Item("district")
                mbtxt.Text = dr.Item("mob_num")
                'fmtxt.Text = dr.Item("n_family")
                faitxt.Text = dr.Item("f_anu_income")
                ddlicm.SelectedValue = dr.Item("incmsrc")
                srcicmtxt.Text = dr.Item("srcimc")
                ddl.SelectedValue = dr.Item("ddlval")
                txtamt.Text = dr.Item("amount")
                txttrnnum.Text = dr.Item("transactionno")
                txtcast.Text = dr.Item("cast")
                txtsubcast.Text = dr.Item("subcast")
                'cmd = New SqlCommand("select * from Tashil where TID='" & city & "'")

                ctytxt.Text = dr.Item("TName")
                txtcast.Text = dr.Item("CAST")
                txtsubcast.Text = dr.Item("Subcast")
                txtthana.Text = dr.Item("Thana")
                txtvillage.Text = dr.Item("Village")
                txtthashil.Text = dr.Item("thashil")
            End If
            dr.Close()
            GridBind()

            dbconn.Close()
        End If


    End Sub
    Public Sub DownloadFile(ByVal sender As Object, ByVal e As EventArgs)
        Try


            Dim filePath As String = "uploads/" + CType(sender, LinkButton).CommandArgument

            Dim filedownload As String = filePath


            Dim serverip As String = ""
        
            serverip = "http://right99androapp.macerptechnologies.com/"

            'If Cache("androFolder").ToString.Contains("macerptechnologies") = True Or Cache("androFolder").ToString.Contains("macerptech") = True Then
            '    serverip = "http://right99androapp.macerptechnologies.com/"
            'End If


            Dim FILeLINK As String = serverip + filedownload


            If Session("Userid") = 100 Then

                Response.ContentType = ContentType
                Response.AppendHeader("Content-Disposition", ("attachment; filename=" + Path.GetFileName(filedownload)))
                Response.WriteFile(filedownload)
                Response.End()
            Else
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "UpdateAPP", "UpdateAPP('" & FILeLINK & "');", True)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub download()
        Dim k As String = ""
        Try
            dbconn.Open()
            cmd = New SqlCommand("select receipt from form where sno=@sno", dbconn)
            cmd.Parameters.AddWithValue("sno", Session("sno"))
            Dim dr = cmd.ExecuteReader
            If dr.Read Then
                k = dr.Item("receipt")
            End If
            dr.Close()
            dbconn.Close()
            If k = "1" Then
                lblrd.Visible = True
                lblrd.Text = "No record found"
            Else
                Dim filename As String = k
                Dim serverip As String = ""

                serverip = "http://right99androapp.macerptechnologies.com/uploads/receipt/"

                'If Cache("androFolder").ToString.Contains("macerptechnologies") = True Or Cache("androFolder").ToString.Contains("macerptech") = True Then
                '    serverip = "http://right99androapp.macerptechnologies.com/"
                'End If


                Dim FILeLINK As String = serverip + filename
                If Session("Userid") = 100 Then

                    Response.ContentType = ContentType
                    Response.AppendHeader("Content-Disposition", ("attachment; filename=" + Path.GetFileName(filename)))
                    Response.WriteFile(filename)
                    Response.End()
                Else
                    System.Web.UI.ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "UpdateAPP", "UpdateAPP('" & FILeLINK & "');", True)
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub


    Public Sub GridBind()
        Try

            Dim filename As String = Session("sno").ToString + "_"

            Dim filePaths() As String = System.IO.Directory.GetFiles(Server.MapPath("uploads/"), "" & filename & "*")

            Dim files As List(Of ListItem) = New List(Of ListItem)
            For Each filePath As String In filePaths
                files.Add(New ListItem(Replace(Replace(Path.GetFileNameWithoutExtension(filePath), Session("sno").ToString + "_", ""), "Certificate_", "File_"), Path.GetFileName(filePath)))
            Next
            GridView1.DataSource = files
            GridView1.DataBind()

        Catch ex As Exception

        End Try
    End Sub

  
    Protected Sub btnrec_Click(sender As Object, e As EventArgs) Handles btnrec.Click
        download()
    End Sub
End Class
