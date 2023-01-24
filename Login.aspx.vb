Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Configuration
Imports System.Drawing
Partial Class Login
    Inherits System.Web.UI.Page
    Dim dbconn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conn").ConnectionString)
    Dim cmd As New SqlCommand()
    Dim cmd1 As New SqlCommand()
    Dim null As String
    Protected Sub signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        Response.Redirect("registration.aspx")
    End Sub

    Protected Sub sbtbtn_Click(sender As Object, e As EventArgs) Handles sbtbtn.Click

        dbconn.Open()
        Try


            Dim s As String
            s = "select count(*) from regis where phn='" & emailtxt.Text & "' and pass='" & Password.Text & "'"
            cmd = New SqlCommand(s, dbconn)
            Dim dr = cmd.ExecuteScalar
            If dr > 0 Then
                cmd1 = New SqlCommand("select top 1 f_name,us_id from regis where phn='" & emailtxt.Text & "' and pass='" & Password.Text & "'", dbconn)
                Dim kr = cmd1.ExecuteReader

                If kr.Read Then
                    Session("Userid") = kr.Item("us_id").ToString
                    Session("Name") = kr.Item("f_name")

                End If
                kr.Close()

                dbconn.Close()
                emailtxt.Text = ""
                Password.Text = ""

                'Response.Redirect("appform.aspx?username=" + Session("UserName"))
                Response.Redirect("home.aspx?MAC#")
            Else
                LblMesge.Visible = True
                LblMesge.Text = "Invalid Username or Password"

            End If
            Session("Userid") = Nothing
            Session("Name") = Nothing
            Session("s") = Nothing
        Catch ex As Exception

        End Try

        dbconn.Close()
        emailtxt.Text = ""
        Password.Text = ""


    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Session("Name") = Nothing
            Session("Userid") = Nothing
            Session("s") = Nothing
            LblMesge.Visible = False
        End If



    End Sub
End Class
