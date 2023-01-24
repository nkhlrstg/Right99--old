
Partial Class Mainpage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Lbluser.Text = "WELCOME   " + Session("Name")
    End Sub

  
End Class

