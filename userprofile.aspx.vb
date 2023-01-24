Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Configuration
Imports System.Drawing
Partial Class userprofile
    Inherits System.Web.UI.Page
    Dim dbconn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conn").ConnectionString)

    Dim cmd As New SqlCommand()
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("Userid") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If
        cmd = New SqlCommand("select * from  regis where us_id = @nme ", dbconn)
        cmd.Parameters.AddWithValue("nme", Session("Userid"))
        dbconn.Open()
        Dim dr = cmd.ExecuteReader

        If dr.Read Then
            lblname.Text = dr.Item("f_name")
            'lblemail.Text = dr.Item("email")
            lblmob.Text = dr.Item("phn")
            lblpass.Text = dr.Item("pass")
        End If
        dr.Close()
        dbconn.Close()
    End Sub

    Protected Sub btnchgpass_Click(sender As Object, e As EventArgs) Handles btnchgpass.Click
        dbconn.Open()
        cmd = New SqlCommand("update regis set pass =@pas  where us_id=@user ", dbconn)
        cmd.Parameters.AddWithValue("pas", txtchngpass.Text)
        cmd.Parameters.AddWithValue("user", Session("Userid"))
        cmd.ExecuteNonQuery()
        dbconn.Close()
        txtchngpass.Text = ""
    End Sub
End Class
