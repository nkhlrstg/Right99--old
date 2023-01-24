
Partial Class WebSite1_home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("Userid") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If
        Session("btnsession") = Nothing
    End Sub
    Protected Sub btnhlth_Click(sender As Object, e As ImageClickEventArgs) Handles btnhlth.Click
        Session("btnsession") = 1
        Response.Redirect("appform.aspx")
    End Sub
    Protected Sub btnpan_Click(sender As Object, e As ImageClickEventArgs) Handles btnpan.Click
        Session("btnsession") = 2
        Response.Redirect("appform.aspx")
    End Sub

    Protected Sub btnratn_Click(sender As Object, e As ImageClickEventArgs) Handles btnratn.Click
        Session("btnsession") = 3
        Response.Redirect("appform.aspx")
    End Sub

    Protected Sub btnicm_Click(sender As Object, e As ImageClickEventArgs) Handles btnicm.Click
        Session("btnsession") = 4
        Response.Redirect("appform.aspx")
    End Sub

    Protected Sub btncast_Click(sender As Object, e As ImageClickEventArgs) Handles btncast.Click
        Session("btnsession") = 5
        Response.Redirect("appform.aspx")
    End Sub

    Protected Sub btndm_Click(sender As Object, e As ImageClickEventArgs) Handles btndm.Click
        Session("btnsession") = 6
        Response.Redirect("appform.aspx")
    End Sub

    Protected Sub btnvoter_Click(sender As Object, e As ImageClickEventArgs) Handles btnvoter.Click
        Session("btnsession") = 7
        Response.Redirect("appform.aspx")
    End Sub

    Protected Sub btnayush_Click(sender As Object, e As ImageClickEventArgs) Handles btnayush.Click
        Session("btnsession") = 8
        Response.Redirect("appform.aspx")
    End Sub

    Protected Sub btnlbr_Click(sender As Object, e As ImageClickEventArgs) Handles btnlbr.Click
        Session("btnsession") = 9
        Response.Redirect("appform.aspx")
    End Sub

   

    Protected Sub btntwo_Click(sender As Object, e As ImageClickEventArgs) Handles btntwo.Click
        Session("btnsession") = 10
        Response.Redirect("appform.aspx")
    End Sub

    Protected Sub btnfour_Click(sender As Object, e As ImageClickEventArgs) Handles btnfour.Click
        Session("btnsession") = 11
        Response.Redirect("appform.aspx")
    End Sub

  
    Protected Sub morelink_Click(ByVal sender As Object, ByVal e As EventArgs) Handles morelink.Click
        Response.Redirect("morelink.aspx")
    End Sub
End Class
