Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Configuration
Imports System.Drawing
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim dbconn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conn").ConnectionString)
    Dim cmd As New SqlCommand()

    Protected Sub lgbtn_Click(sender As Object, e As EventArgs) Handles lgbtn.Click
        Response.Redirect("login.aspx")
    End Sub
    Sub newclick()
        nametext.Text = ""
        phonetext.Text = ""
        passtext.Text = ""
        repasstext.Text = ""
        dobtxt.Text = ""

    End Sub
    Protected Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click


        If nametext.Text = "" Then

            nametext.Focus()
            Exit Sub
        End If
       
        'If emailtext.Text = "" Then
        '    emailtext.Focus()
        '    Exit Sub
        'End If
        If phonetext.Text = "" Then
            phonetext.Focus()
            Exit Sub
        End If
        If passtext.Text = "" Then
            passtext.Focus()
            Exit Sub
        End If
        If repasstext.Text = "" Then
            repasstext.Focus()
            Exit Sub
        End If
        If dobtxt.Text = "" Then
            dobtxt.Focus()
            Exit Sub
        End If
        If Not repasstext.Text = passtext.Text Then
            lblsave.Visible = True
            lblsave.Text = "password not matched."

            repasstext.Focus()
            Exit Sub
        End If
        dbconn.Open()
        cmd = New SqlCommand("select phn from regis where phn=@phn", dbconn)
        'cmd.Parameters.AddWithValue("email", emailtext.Text)
        cmd.Parameters.AddWithValue("phn", phonetext.Text)
        Dim d = cmd.ExecuteReader
        If d.HasRows Then
            lblsave.Visible = True
            lblsave.Text = "Mobile number already exits.."
            d.Close()
            dbconn.Close()
            Exit Sub
        End If
        d.Close()

        Try

       
            cmd = New SqlCommand("insert into regis(f_name,phn,pass,dob) values(@nme,@phone,@pass,@dob) ", dbconn)
        cmd.Parameters.AddWithValue("nme", nametext.Text)
            'cmd.Parameters.AddWithValue("email", emailtext.Text)
        cmd.Parameters.AddWithValue("phone", phonetext.Text)
        cmd.Parameters.AddWithValue("pass", passtext.Text)
        cmd.Parameters.AddWithValue("dob", dobtxt.Text)
        cmd.ExecuteNonQuery()

        lblsave.Visible = True
            lblsave.Text = "Registration Saved. Now click on Login"
      
        dbconn.Close()
        'newclick()
        Catch ex As Exception
            lblsave.Visible = True
            lblsave.Text = "error while save."
        End Try
        newclick()
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        'If IsPostBack Then
        '     ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('checking');window.location.href='Resources.aspx';", true);
        'End If
        If Not IsPostBack Then
            newclick()
        End If
    End Sub
End Class
