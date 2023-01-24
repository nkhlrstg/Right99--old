Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Configuration
Imports System.Drawing
Partial Class WebSite1_passwordreset
    Inherits System.Web.UI.Page
    Dim dbconn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conn").ConnectionString)
    Dim cmd As New SqlCommand()
    Protected Sub sbtbtn_Click(sender As Object, e As EventArgs) Handles sbtbtn.Click
        dbconn.Open()
        'If emtxt.Text = "" Then
        '    emtxt.Focus()
        '    Exit Sub
        'End If
        If dobtxt.Text = "" Then
            dobtxt.Focus()
            Exit Sub
        End If
        If mbtxt.Text = "" Then
            mbtxt.Focus()
            Exit Sub
        End If
       
        Dim s As String
        s = "select email,pass,phn from regis where dob='" & dobtxt.Text & "' and phn ='" & mbtxt.Text & "' "
        cmd = New SqlCommand(s, dbconn)
        Dim dr = cmd.ExecuteReader
        If dr.Read Then
            lblemail.Visible = True
            lblpass.Visible = True
            lblemail.Text = "Mobile Number = " + dr.Item("phn").ToString
            lblpass.Text = "Password = " + dr.Item("pass").ToString

        Else
            lblemail.Visible = True
            lblpass.Visible = False
            lblemail.Text = "Invalid details"

        End If
        dr.Close()
        dbconn.Close()
        dobtxt.Text = ""
        mbtxt.Text = ""
    End Sub

    Protected Sub btnbck_Click(sender As Object, e As EventArgs) Handles btnbck.Click
        Response.Redirect("Login.aspx")
    End Sub
End Class
