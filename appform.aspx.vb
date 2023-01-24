Imports System.IO
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Imports System.Configuration
Imports System.Drawing
Partial Class WebSite1_Default
    Inherits System.Web.UI.Page
    'Dim conn As New SqlConnection(ConfigurationManager.ConnectionStrings["conn"])
    Dim dbconn As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("conn").ConnectionString)

    Dim cmd As New SqlCommand()
    Public Function getlabelname(ByVal id As Integer, ByVal doctypeid As Integer) As String
        Dim labelname As String = ""


        If ddl.SelectedValue = 1 Then
            If doctypeid = 1 Then
                labelname = photolb.Text
            ElseIf doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 3 Then
                labelname = sslb.Text
            ElseIf doctypeid = 4 Then
                labelname = splb.Text
            ElseIf doctypeid = 5 Then
                labelname = rtbcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text

            End If


        End If
        If ddl.SelectedValue = 2 Then
            If doctypeid = 1 Then
                labelname = photolb.Text
            ElseIf doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text
            ElseIf doctypeid = 6 Then
                labelname = mrkshtlb.Text
            ElseIf doctypeid = 7 Then
                labelname = plplb.Text
            ElseIf doctypeid = 4 Then
                labelname = splb.Text
            ElseIf doctypeid = 8 Then
                labelname = rtncrdeblb.Text

            End If
        End If

        If ddl.SelectedValue = 3 Then
            If doctypeid = 1 Then
                labelname = photolb.Text
            ElseIf doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text
            ElseIf doctypeid = 7 Then
                labelname = plplb.Text
            ElseIf doctypeid = 8 Then
                labelname = rtncrdeblb.Text
            ElseIf doctypeid = 4 Then
                labelname = splb.Text

            ElseIf doctypeid = 6 Then
                labelname = mrkshtlb.Text

            End If


        End If
        If ddl.SelectedValue = 4 Then
            If doctypeid = 1 Then
                labelname = photolb.Text
            ElseIf doctypeid = 9 Then
                labelname = adhcrdalcndlb.Text
            ElseIf doctypeid = 10 Then
                labelname = eclb.Text
            ElseIf doctypeid = 11 Then
                labelname = bnkpsklb.Text

            End If
        End If




        If ddl.SelectedValue = 5 Then
            If doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text

            End If


        End If
        If ddl.SelectedValue = 6 Then
            If doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text
            ElseIf doctypeid = 5 Then
                labelname = rtbcrdlb.Text

            End If
        End If
        If ddl.SelectedValue = 7 Then
            If doctypeid = 1 Then
                labelname = photolb.Text
            ElseIf doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text
            ElseIf doctypeid = 12 Then
                labelname = signlb.Text


            End If
        End If

        If ddl.SelectedValue = 8 Then
            If doctypeid = 1 Then
                labelname = photolb.Text
            ElseIf doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text
            ElseIf doctypeid = 16 Then
                labelname = mbpdlb.Text


            End If



        End If
        If ddl.SelectedValue = 9 Then
            If doctypeid = 1 Then
                labelname = photolb.Text
            ElseIf doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text
            ElseIf doctypeid = 11 Then
                labelname = bnkpsklb.Text
            ElseIf doctypeid = 13 Then
                labelname = nadhcrdlb.Text
            ElseIf doctypeid = 14 Then
                labelname = nplb.Text

            End If


        End If
        If ddl.SelectedValue = 10 Then


            If doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text
            ElseIf doctypeid = 17 Then
                labelname = lclb.Text
            End If
        End If

        If ddl.SelectedValue = 11 Then

            If doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text
            ElseIf doctypeid = 17 Then
                labelname = lclb.Text
            ElseIf doctypeid = 11 Then
                labelname = bnkpsklb.Text
            End If


        End If


            If ddl.SelectedValue = 13 Then

                If doctypeid = 15 Then
                    labelname = rclb.Text


                End If
            End If

            If ddl.SelectedValue = 14 Then
                If doctypeid = 15 Then
                    labelname = rclb.Text

                End If
        End If
        If ddl.SelectedValue = 16 Then

            If doctypeid = 2 Then
                labelname = adhcrdlb.Text
            ElseIf doctypeid = 18 Then
                labelname = lbladhrback.Text
            ElseIf doctypeid = 5 Then
                labelname = rtbcrdlb.Text
            End If
        End If

            Return labelname
    End Function
    Public Sub fillsubcast()
        Dim castid As Integer = 0
        Dim cast As String = ""
        If ddlcast.Text = "" Then
            castid = 1
        Else
            castid = CInt(ddlcast.Text)

        End If

        dbconn.Open()


        Dim s As String
        s = "Select SID,CID,Subcast From SubCast WHERE CID='" & castid & "'  Order by SID"
        cmd = New SqlCommand(s, dbconn)
        Dim dr = cmd.ExecuteReader
        ddlsubcast.DataSource = dr
        ddlsubcast.DataTextField = "Subcast"
        ddlsubcast.DataValueField = "SID"
        ddlsubcast.DataBind()
        dr.Close()
        'ex.Close()
        dbconn.Close()

    End Sub
    Public Sub fillthana()
        Dim TID As Integer = 0
        Dim Thana As String = ""
        If ddlcity.Text = "" Then
            TID = 1
        Else
            TID = CInt(ddlcity.Text)

        End If

        dbconn.Open()


        Dim s As String
        s = "Select THID,TID,Thana From THANA WHERE TID='" & TID & "'  Order by THID"
        cmd = New SqlCommand(s, dbconn)
        Dim dr = cmd.ExecuteReader
        ddlthana.DataSource = dr
        ddlthana.DataTextField = "Thana"
        ddlthana.DataValueField = "THID"
        ddlthana.DataBind()
        dr.Close()
        'ex.Close()
        dbconn.Close()
    End Sub
    Public Sub fillvillage()
        Dim VID As Integer = 0
        Dim Village As String = ""
        If ddlcity.Text = "" Then
            VID = 1
        Else
            VID = CInt(ddlcity.Text)

        End If

        dbconn.Open()


        Dim s As String
        s = "Select VID,TID,Village From VILLAGE WHERE TID='" & VID & "'  Order by VID"
        cmd = New SqlCommand(s, dbconn)
        Dim dr = cmd.ExecuteReader
        ddlvill.DataSource = dr
        ddlvill.DataTextField = "Village"
        ddlvill.DataValueField = "VID"
        ddlvill.DataBind()
        dr.Close()
        'ex.Close()
        dbconn.Close()
    End Sub

    Protected Sub ddl_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl.SelectedIndexChanged
        If ddl.SelectedValue = 1 Then
            photolb.Visible = True
            photoupd.Visible = True
            'phtbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True
            'adcrdbtn.Visible = True
            sslb.Visible = True
            ssupd.Visible = True
            ' ssbtn.Visible = True
            splb.Visible = True
            spupd.Visible = True
            '  spbtn.Visible = True
            rtbcrdlb.Visible = True
            rtncrdupd.Visible = True
            ' rtncrdbtn.Visible = True
            txtamt.Text = "75 rs"
            ddlcast.Visible = True
            ddlsubcast.Visible = True
            ddlthana.Visible = True
            ddlvill.Visible = True
            ddlcity.Visible = True
            ctytxt.Visible = False
            fillsubcast()
            fillthana()
            fillvillage()


        End If
        If ddl.SelectedValue = 2 Then
            photolb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True
            ddlcast.Visible = True
            ddlsubcast.Visible = True
            ddlthana.Visible = True
            ddlvill.Visible = True
            ddlcity.Visible = True
            ctytxt.Visible = False
            ' adcrdbtn.Visible = True
            mrkshtlb.Visible = True
            mrkshtupd.Visible = True
            ' mrkshtbtn.Visible = True
            plplb.Visible = True
            ssupd.Visible = True
            ' ssbtn.Visible = True
            splb.Visible = True
            spupd.Visible = True
            ' spbtn.Visible = True
            rtncrdeblb.Visible = True
            rtncrdupd.Visible = True
            ' rtncrdbtn.Visible = True
            txtamt.Text = "75 rs"
            fillsubcast()
            fillthana()
            fillvillage()
        End If
        If ddl.SelectedValue = 3 Then
            photolb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True
            ' adcrdbtn.Visible = True
            plplb.Visible = True
            ssupd.Visible = True
            '  ssbtn.Visible = True
            rtncrdeblb.Visible = True
            rtncrdupd.Visible = True
            ' rtncrdbtn.Visible = True
            splb.Visible = True
            spupd.Visible = True
            '   spbtn.Visible = True
            mrkshtlb.Visible = True
            mrkshtupd.Visible = True
            ' mrkshtbtn.Visible = True

            txtamt.Text = "75 rs"
            ddlcast.Visible = True
            ddlsubcast.Visible = True
            ddlthana.Visible = True
            ddlvill.Visible = True
            ddlcity.Visible = True
            ctytxt.Visible = False
            fillsubcast()
            fillthana()
            fillvillage()


        End If
        If ddl.SelectedValue = 4 Then
            photolb.Visible = True
            photoupd.Visible = True
            '  phtbtn.Visible = True
            adhcrdalcndlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True

            '  adcrdbtn.Visible = True
            eclb.Visible = True
            ssupd.Visible = True
            ' ssbtn.Visible = True
            bnkpsklb.Visible = True
            rtncrdupd.Visible = True
            txtamt.Text = "75 rs"
            ' rtncrdbtn.Visible = True
            'mbnmlb.Visible = True
            'mbnmtxt.Visible = True
            'fmlb.Visible = True
            'mothertxt.Visible = True
            'fathertxt.Visible = True
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True
        End If
        If ddl.SelectedValue = 5 Then
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True
            txtamt.Text = "75 rs"

            ' adcrdbtn.Visible = True
            'rtncrdnmlb.Visible = True
            'rtnnmtxt.Visible = True
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True

        End If
        If ddl.SelectedValue = 6 Then
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True
            ' adcrdbtn.Visible = True
            rtbcrdlb.Visible = True
            rtncrdupd.Visible = True
            ' rtncrdbtn.Visible = True
            txtamt.Text = "75 rs"
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True
        End If
        If ddl.SelectedValue = 7 Then
            photolb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True

            txtamt.Text = "175 rs"
            ' adcrdbtn.Visible = True
            signlb.Visible = True
            ssupd.Visible = True
            ' ssbtn.Visible = True
            'fathertxt.Visible = True
            'mothertxt.Visible = True
            'fmlb.Visible = True
            'mbnmlb.Visible = True
            'mbnmtxt.Visible = True
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True
        End If
        If ddl.SelectedValue = 8 Then
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True

            ' adcrdbtn.Visible = True
            mbpdlb.Visible = True
            mrkshtupd.Visible = True
            '  mrkshtbtn.Visible = True
            photolb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            'mbnmlb.Visible = True
            'mbnmtxt.Visible = True
            signlb.Visible = True
            ssupd.Visible = True
            '  ssbtn.Visible = True
            txtamt.Text = "175 rs"
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True

        End If
        If ddl.SelectedValue = 9 Then
            photolb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True

            updadhrbck.Visible = True
            lbladhrback.Visible = True
            txtamt.Text = "300 rs"
            ' adcrdbtn.Visible = True
            bnkpsklb.Visible = True
            rtncrdupd.Visible = True
            ' rtncrdbtn.Visible = True
            nadhcrdlb.Visible = True
            spupd.Visible = True
            ' spbtn.Visible = True
            'fmlb.Visible = True
            'fathertxt.Visible = True
            'mothertxt.Visible = True
            nplb.Visible = True
            npupd.Visible = True
            ' npbtn.Visible = True
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True
        End If
        If ddl.SelectedValue = 10 Then
            lclb.Visible = True
            photoupd.Visible = True
            'phtbtn.Visible = True
            'npupd.Visible = True
            'npbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True
            txtamt.Text = "50rs per year"
            '  adcrdbtn.Visible = True
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True


        End If
        If ddl.SelectedValue = 11 Then
            lclb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            'npupd.Visible = True
            'npbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True

            '  adcrdbtn.Visible = True
            bnkpsklb.Visible = True
            rtncrdupd.Visible = True
            ' rtncrdbtn.Visible = True
            txtamt.Text = "50rs"
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True
        End If
        If ddl.SelectedValue = 12 Then
            khsnmlb.Visible = True
            khsnmtxt.Visible = True
            cndlb.Visible = True
            cndname.Visible = True
            vlglb.Visible = True
            chsnmtxt.Visible = True
            thnmlb.Visible = True
            rtnnmtxt.Visible = True
            dstlb.Visible = True
            thtxt.Visible = True
            txtamt.Text = "75 rs"
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True

        End If
        If ddl.SelectedValue = 13 Then
            rclb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            engnmlb.Visible = True
            engtxt.Visible = True
            chsnmlb.Visible = True
            chsnmtxt.Visible = True
            'mbnmlb.Visible = True
            'mbnmtxt.Visible = True
            txtamt.Text = "Please wait"
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True
        End If
        If ddl.SelectedValue = 14 Then
            rclb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            engnmlb.Visible = True
            engtxt.Visible = True
            chsnmlb.Visible = True
            chsnmtxt.Visible = True
            'mbnmlb.Visible = True
            'mbnmtxt.Visible = True
            txtamt.Text = "Please wait"
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True
        End If
        If ddl.SelectedValue = 15 Then
            doblb.Visible = True
            dobtxt.Visible = True
            txtamt.Text = "Please wait"
            'mbnmlb.Visible = True
            'mbnmtxt.Visible = True
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True
        End If
        If ddl.SelectedValue = 16 Then
            adhcrdlb.Visible = True
            lbladhrback.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            rtbcrdlb.Visible = True
            rtncrdupd.Visible = True
            txtamt.Text = "Please wait"
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            ddlthana.Visible = False
            ddlvill.Visible = False
            ddlcity.Visible = False
            ctytxt.Visible = True
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("Userid") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If

        If Not IsPostBack Then
            lblform.Visible = False
            If Session("btnsession") = 1 Then
                ddl.SelectedValue = 15
                doblb.Visible = True
                dobtxt.Visible = True
                txtamt.Text = "Please wait"
            ElseIf Session("btnsession") = 2 Then
                ddl.SelectedValue = 7
                photolb.Visible = True
                photoupd.Visible = True
                ' phtbtn.Visible = True
                adhcrdlb.Visible = True
                adcrdupd.Visible = True
                updadhrbck.Visible = True
                lbladhrback.Visible = True
                txtamt.Text = "175 rs"
                signlb.Visible = True
                ssupd.Visible = True
            ElseIf Session("btnsession") = 3 Then
                ddl.SelectedValue = 4
                photolb.Visible = True
                photoupd.Visible = True
                adhcrdalcndlb.Visible = True
                adcrdupd.Visible = True
                updadhrbck.Visible = True
                lbladhrback.Visible = True
                eclb.Visible = True
                ssupd.Visible = True
                bnkpsklb.Visible = True
                rtncrdupd.Visible = True
                txtamt.Text = "75 rs"
            ElseIf Session("btnsession") = 4 Then
                ddl.SelectedValue = 1
                photolb.Visible = True
                photoupd.Visible = True
                'phtbtn.Visible = True
                adhcrdlb.Visible = True
                adcrdupd.Visible = True
                updadhrbck.Visible = True
                lbladhrback.Visible = True
                'adcrdbtn.Visible = True
                sslb.Visible = True
                ssupd.Visible = True
                ' ssbtn.Visible = True
                splb.Visible = True
                spupd.Visible = True
                '  spbtn.Visible = True
                rtbcrdlb.Visible = True
                rtncrdupd.Visible = True
                ' rtncrdbtn.Visible = True
                txtamt.Text = "75 rs"
            ElseIf Session("btnsession") = 5 Then
                ddl.SelectedValue = 2
                photolb.Visible = True
                photoupd.Visible = True
                ' phtbtn.Visible = True
                adhcrdlb.Visible = True
                adcrdupd.Visible = True
                updadhrbck.Visible = True
                lbladhrback.Visible = True
                ddlcast.Visible = True
                ddlsubcast.Visible = True
                ' adcrdbtn.Visible = True
                mrkshtlb.Visible = True
                mrkshtupd.Visible = True
                ' mrkshtbtn.Visible = True
                plplb.Visible = True
                ssupd.Visible = True
                ' ssbtn.Visible = True
                splb.Visible = True
                spupd.Visible = True
                ' spbtn.Visible = True
                rtncrdeblb.Visible = True
                rtncrdupd.Visible = True
                ' rtncrdbtn.Visible = True
                txtamt.Text = "75 rs"
            ElseIf Session("btnsession") = 6 Then
                ddl.SelectedValue = 3
                photolb.Visible = True
                photoupd.Visible = True
                ' phtbtn.Visible = True
                adhcrdlb.Visible = True
                adcrdupd.Visible = True
                updadhrbck.Visible = True
                lbladhrback.Visible = True
                ' adcrdbtn.Visible = True
                plplb.Visible = True
                ssupd.Visible = True
                '  ssbtn.Visible = True
                rtncrdeblb.Visible = True
                rtncrdupd.Visible = True
                ' rtncrdbtn.Visible = True
                splb.Visible = True
                spupd.Visible = True
                '   spbtn.Visible = True
                mrkshtlb.Visible = True
                mrkshtupd.Visible = True
                ' mrkshtbtn.Visible = True

                txtamt.Text = "75 rs"

            ElseIf Session("btnsession") = 7 Then
                ddl.SelectedValue = 8
                adhcrdlb.Visible = True
                adcrdupd.Visible = True
                updadhrbck.Visible = True
                lbladhrback.Visible = True
                mbpdlb.Visible = True
                mrkshtupd.Visible = True
                photolb.Visible = True
                photoupd.Visible = True
                signlb.Visible = True
                ssupd.Visible = True
                txtamt.Text = "175 rs"

            ElseIf Session("btnsession") = 8 Then
                ddl.SelectedValue = 16
                adhcrdlb.Visible = True
                lbladhrback.Visible = True
                adcrdupd.Visible = True
                updadhrbck.Visible = True
                rtbcrdlb.Visible = True
                rtncrdupd.Visible = True
                txtamt.Text = "Please wait"

            ElseIf Session("btnsession") = 9 Then
                ddl.SelectedValue = 9
                photolb.Visible = True
                photoupd.Visible = True
                ' phtbtn.Visible = True
                adhcrdlb.Visible = True
                adcrdupd.Visible = True

                updadhrbck.Visible = True
                lbladhrback.Visible = True
                txtamt.Text = "300 rs"
                ' adcrdbtn.Visible = True
                bnkpsklb.Visible = True
                rtncrdupd.Visible = True
                ' rtncrdbtn.Visible = True
                nadhcrdlb.Visible = True
                spupd.Visible = True
                ' spbtn.Visible = True
                'fmlb.Visible = True
                'fathertxt.Visible = True
                'mothertxt.Visible = True
                nplb.Visible = True
                npupd.Visible = True
                ' npbtn.Visible = True

            ElseIf Session("btnsession") = 10 Then
                ddl.SelectedValue = 13
                rclb.Visible = True
                photoupd.Visible = True
                ' phtbtn.Visible = True
                engnmlb.Visible = True
                engtxt.Visible = True
                chsnmlb.Visible = True
                chsnmtxt.Visible = True
                'mbnmlb.Visible = True
                'mbnmtxt.Visible = True
                txtamt.Text = "Please wait"
            ElseIf Session("btnsession") = 11 Then
                ddl.SelectedValue = 14
                rclb.Visible = True
                photoupd.Visible = True
                ' phtbtn.Visible = True
                engnmlb.Visible = True
                engtxt.Visible = True
                chsnmlb.Visible = True
                chsnmtxt.Visible = True
                'mbnmlb.Visible = True
                'mbnmtxt.Visible = True
                txtamt.Text = "Please wait"


            End If
            'fillsubcast()
        End If
        If IsPostBack Then
            photolb.Visible = False
            photoupd.Visible = False
            '  phtbtn.Visible = False
            adhcrdlb.Visible = False
            adcrdupd.Visible = False
            lbladhrback.Visible = False
            updadhrbck.Visible = False
            '  adcrdbtn.Visible = False
            adhcrdalcndlb.Visible = False
            thtxt.Visible = False
            doblb.Visible = False
            eclb.Visible = False
            sslb.Visible = False
            ssupd.Visible = False
            '  ssbtn.Visible = False
            ddlcast.Visible = False
            ddlsubcast.Visible = False
            splb.Visible = False
            spupd.Visible = False
            '  spbtn.Visible = False
            signlb.Visible = False
            mbpdlb.Visible = False
            rtbcrdlb.Visible = False
            rtncrdupd.Visible = False
            ' rtncrdbtn.Visible = False
            rtncrdeblb.Visible = False
            vlglb.Visible = False
            thnmlb.Visible = False
            lclb.Visible = False
            rclb.Visible = False
            engnmlb.Visible = False
            engtxt.Visible = False
            chsnmlb.Visible = False
            chsnmtxt.Visible = False
            mbnmlb.Visible = False
            bnkpsklb.Visible = False
            nadhcrdlb.Visible = False
            nplb.Visible = False
            npupd.Visible = False
            '  npbtn.Visible = False
            plplb.Visible = False
            mrkshtlb.Visible = False
            mrkshtupd.Visible = False
            '  mrkshtbtn.Visible = False
            mbnmlb.Visible = False
            dobtxt.Visible = False
            khsnmlb.Visible = False
            khsnmtxt.Visible = False
            cndlb.Visible = False
            cndname.Visible = False
            dstlb.Visible = False
            rtnnmtxt.Visible = False
            'ddlcast.Visible = False
            'ddlsubcast.Visible = False
            'ddlthana.Visible = False
            'ddlvill.Visible = False
            'ddlcity.Visible = False
            'ctytxt.Visible = True
            'fillsubcast()
        End If
        If ddl.SelectedIndex > 0 Then
            sbtbtn.Visible = True
        Else
            sbtbtn.Visible = False
        End If

    End Sub

    Protected Sub sbtbtn_Click(sender As Object, e As EventArgs) Handles sbtbtn.Click
        Dim s As String = ""

        Try
            If ddl.SelectedValue = 1 Then
                If faitxt.Text = "" Then
                    lblform.Visible = True
                    lblform.Text = "Application Not Saved "
                    faitxt.Focus()
                    Exit Sub
                End If
                If ddlicm.SelectedIndex = 0 Then
                    lblform.Visible = True
                    lblform.Text = "Application Not Saved. please select income category "
                    ddlicm.Focus()
                    Exit Sub
                End If
                If srcicmtxt.Text = "" Then
                    lblform.Visible = True
                    lblform.Text = "Application Not Saved "
                    srcicmtxt.Focus()
                End If
            End If

            If nametxt.Text = "" Then
                lblform.Visible = True
                lblform.Text = "Application Not Saved "
                nametxt.Focus()
                Exit Sub
            End If
            If fathrtxt.Text = "" Then
                lblform.Visible = True
                lblform.Text = "Application Not Saved "
                fathrtxt.Focus()
                Exit Sub
            End If
            If mothrtxt.Text = "" Then
                lblform.Visible = True
                lblform.Text = "Application Not Saved "
                mothrtxt.Focus()
                Exit Sub
            End If
            If adstxt.Text = "" Then
                lblform.Visible = True
                lblform.Text = "Application Not Saved "
                adstxt.Focus()
                Exit Sub
            End If
            If ddlcity.Text = "" Then
                lblform.Visible = True
                lblform.Text = "Application Not Saved "
                ddlcity.Focus()
                Exit Sub
            End If
            If dsttxt.Text = "" Then
                lblform.Visible = True
                lblform.Text = "Application Not Saved "
                dsttxt.Focus()
                Exit Sub
            End If
            If mbtxt.Text = "" Then
                lblform.Visible = True
                lblform.Text = "Application Not Saved "
                mbtxt.Focus()
                Exit Sub
            End If
            'If fmtxt.Text = "" Then
            '    fmtxt.Focus()
            '    Exit Sub
            'End If
            If txtamt.Text = "" Then
                lblform.Visible = True
                lblform.Text = "Application Not Saved "
                txtamt.Focus()

                Exit Sub
            End If
            If txttrnnum.Text = "" Then
                lblform.Visible = True
                lblform.Text = "Application Not Saved "
                txttrnnum.Focus()

                Exit Sub
            End If

            If photoupd.Visible = True Then
                If Not photoupd.HasFile Then
                    lblform.Visible = True

                    lblform.Text = "submit all files. "
                    Exit Sub
                End If
            End If
            If adcrdupd.Visible = True Then
                If Not adcrdupd.HasFile Then
                    lblform.Visible = True

                    lblform.Text = "submit all files. "
                    Exit Sub
                End If
            End If
            If updadhrbck.Visible = True Then
                If Not updadhrbck.HasFile Then
                    lblform.Visible = True
                    lblform.Text = "submit all files. "
                    Exit Sub
                End If
            End If
            If ssupd.Visible = True Then
                If Not ssupd.HasFile Then
                    lblform.Visible = True

                    lblform.Text = "submit all files. "
                    Exit Sub
                End If
            End If
            If rtncrdupd.Visible = True Then
                If Not rtncrdupd.HasFile Then
                    lblform.Visible = True

                    lblform.Text = "submit all files. "
                    Exit Sub
                End If
            End If
            If spupd.Visible = True Then
                If Not spupd.HasFile Then
                    lblform.Visible = True

                    lblform.Text = "submit all files. "
                    Exit Sub
                End If
            End If
            If mrkshtupd.Visible = True Then
                If Not mrkshtupd.HasFile Then
                    lblform.Visible = True

                    lblform.Text = "submit all files. "
                    Exit Sub
                End If
            End If
            If npupd.Visible = True Then
                If Not npupd.HasFile Then
                    lblform.Visible = True

                    lblform.Text = "submit all files. "
                    Exit Sub
                End If
            End If
            lblform.Visible = True

            dbconn.Open()
            cmd = New SqlCommand("insert into form(name,f_name,m_name,addres,city,district,mob_num,f_anu_income,incmsrc,srcimc,dob,khsm,eng,cname,chsm,rtnm,th,fhtype,us_id,ddlval,status,amount,transactionno,cast,subcast,thana,village,thashil) values(@nme,@faname,@moname,@ads,@cty,@dst,@mb,@fmlyicm,@srctype,@srcimc,@dob,@khsm,@eng,@cname,@chsm,@rtnm,@th,@fhname,@us_id,@ddlval,'1',@amt,@trans,@cast,@subcast,@thana,@village,@thashil); select SCOPE_IDENTITY() ", dbconn)

            cmd.Parameters.AddWithValue("nme", nametxt.Text)
            cmd.Parameters.AddWithValue("faname", fathrtxt.Text)
            cmd.Parameters.AddWithValue("moname", mothrtxt.Text)
            cmd.Parameters.AddWithValue("ads", adstxt.Text)
            cmd.Parameters.AddWithValue("cty", ddlcity.Text)
            cmd.Parameters.AddWithValue("dst", dsttxt.Text)
            cmd.Parameters.AddWithValue("mb", mbtxt.Text)
            'cmd.Parameters.AddWithValue("fmly", fmtxt.Text)
            cmd.Parameters.AddWithValue("fmlyicm", faitxt.Text)
            cmd.Parameters.AddWithValue("srctype", ddlicm.SelectedValue)
            cmd.Parameters.AddWithValue("srcimc", srcicmtxt.Text)
            cmd.Parameters.AddWithValue("dob", dobtxt.Text)
            cmd.Parameters.AddWithValue("khsm", khsnmtxt.Text)
            cmd.Parameters.AddWithValue("eng", engtxt.Text)
            cmd.Parameters.AddWithValue("cname", cndname.Text)
            cmd.Parameters.AddWithValue("chsm", chsnmtxt.Text)
            cmd.Parameters.AddWithValue("rtnm", rtnnmtxt.Text)
            cmd.Parameters.AddWithValue("th", thtxt.Text)
            cmd.Parameters.AddWithValue("fhname", fhtype.SelectedIndex)
            cmd.Parameters.AddWithValue("us_id", Session("Userid"))
            cmd.Parameters.AddWithValue("ddlval", ddl.SelectedValue)
            cmd.Parameters.AddWithValue("amt", txtamt.Text)
            cmd.Parameters.AddWithValue("trans", txttrnnum.Text)
            cmd.Parameters.AddWithValue("cast", ddlcast.Text)
            cmd.Parameters.AddWithValue("subcast", ddlsubcast.Text)
            cmd.Parameters.AddWithValue("thana", ddlthana.Text)
            cmd.Parameters.AddWithValue("village", ddlvill.Text)
            cmd.Parameters.AddWithValue("thashil", ctytxt.Text)
            s = cmd.ExecuteScalar()
            Session("s") = s
            If Session("s") > 0 Then
                lblform.Text = "Application Saved"

            Else
                lblform.Text = "Application Not Saved "
            End If
            dbconn.Close()



        Catch ex As Exception

        End Try



        If photoupd.HasFile Then

            Try

                Dim getlbl As String = ""

                If ddl.SelectedValue = "1" Or ddl.SelectedValue = "2" Or ddl.SelectedValue = "3" Or ddl.SelectedValue = "4" Or ddl.SelectedValue = "7" Or ddl.SelectedValue = "8" Or ddl.SelectedValue = "9" Then
                    getlbl = getlabelname(ddl.SelectedValue, 1).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "13" Then
                    getlbl = getlabelname(ddl.SelectedValue, 15).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "14" Then
                    getlbl = getlabelname(ddl.SelectedValue, 15).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "10" Or ddl.SelectedValue = "11" Then
                    getlbl = getlabelname(ddl.SelectedValue, 17).Replace(" ", "_")

                End If

                Dim fileName1 As String = Path.GetExtension(photoupd.PostedFile.FileName)

                photoupd.PostedFile.SaveAs(Server.MapPath("uploads/" + Session("s") + "_" + getlbl + fileName1))

            Catch ex As Exception

            End Try

        End If

        If adcrdupd.HasFile Then

            Try

                Dim getlbl1 As String = ""

                If ddl.SelectedValue = "1" Or ddl.SelectedValue = "2" Or ddl.SelectedValue = "3" Or ddl.SelectedValue = "5" Or ddl.SelectedValue = "6" Or ddl.SelectedValue = "7" Or ddl.SelectedValue = "8" Or ddl.SelectedValue = "9" Or ddl.SelectedValue = "10" Or ddl.SelectedValue = "11" Or ddl.SelectedValue = "16" Then

                    getlbl1 = getlabelname(ddl.SelectedValue, 2).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "4" Then

                    getlbl1 = getlabelname(ddl.SelectedValue, 9).Replace(" ", "-")

                ElseIf ddl.SelectedValue = "9" Then

                    getlbl1 = getlabelname(ddl.SelectedValue, 9).Replace(" ", "_")

                End If

                Dim fileName2 As String = Path.GetExtension(adcrdupd.PostedFile.FileName)

                adcrdupd.PostedFile.SaveAs(Server.MapPath("uploads/" + Session("s") + "_" + getlbl1 + fileName2))

            Catch ex As Exception

            End Try

        End If
        If updadhrbck.HasFile Then

            Try

                Dim getlbl7 As String = ""

                If ddl.SelectedValue = "1" Or ddl.SelectedValue = "2" Or ddl.SelectedValue = "3" Or ddl.SelectedValue = "5" Or ddl.SelectedValue = "6" Or ddl.SelectedValue = "7" Or ddl.SelectedValue = "8" Or ddl.SelectedValue = "9" Or ddl.SelectedValue = "10" Or ddl.SelectedValue = "11" Or ddl.SelectedValue = "16" Then

                    getlbl7 = getlabelname(ddl.SelectedValue, 18).Replace(" ", "_")

                End If

                Dim fileName7 As String = Path.GetExtension(updadhrbck.PostedFile.FileName)

                updadhrbck.PostedFile.SaveAs(Server.MapPath("uploads/" + Session("s") + "_" + getlbl7 + fileName7))

            Catch ex As Exception

            End Try

        End If

        If ssupd.HasFile Then

            Try

                Dim getlbl2 As String = ""

                If ddl.SelectedValue = "1" Then

                    getlbl2 = getlabelname(ddl.SelectedValue, 3).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "2" Or ddl.SelectedValue = "3" Then

                    getlbl2 = getlabelname(ddl.SelectedValue, 7).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "4" Then

                    getlbl2 = getlabelname(ddl.SelectedValue, 10).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "7" Or ddl.SelectedValue = "8" Then

                    getlbl2 = getlabelname(ddl.SelectedValue, 12).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "9" Then

                    getlbl2 = getlabelname(ddl.SelectedValue, 13).Replace(" ", "_")

                End If

                Dim fileName3 As String = Path.GetExtension(ssupd.PostedFile.FileName)

                ssupd.PostedFile.SaveAs(Server.MapPath("uploads/" + Session("s") + "_" + getlbl2 + fileName3))

            Catch ex As Exception

            End Try
        End If

        If rtncrdupd.HasFile Then

            Try

                Dim getlbl3 As String = ""

                If ddl.SelectedValue = "1" Or ddl.SelectedValue = "6" Or ddl.SelectedValue = "16" Then

                    getlbl3 = getlabelname(ddl.SelectedValue, 5).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "2" Or ddl.SelectedValue = "3" Then

                    getlbl3 = getlabelname(ddl.SelectedValue, 8).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "4" Or ddl.SelectedValue = "9" Or ddl.SelectedValue = "11" Then

                    getlbl3 = getlabelname(ddl.SelectedValue, 11).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "11" Then

                    getlbl3 = getlabelname(ddl.SelectedValue, 11).Replace(" ", "_")

                End If

                Dim fileName4 As String = Path.GetExtension(rtncrdupd.PostedFile.FileName)

                rtncrdupd.PostedFile.SaveAs(Server.MapPath("uploads/" + Session("s") + "_" + getlbl3 + fileName4))

            Catch ex As Exception

            End Try

        End If

        If spupd.HasFile Then

            Try

                Dim getlbl4 As String = ""

                If ddl.SelectedValue = "1" Or ddl.SelectedValue = "2" Or ddl.SelectedValue = "3" Then

                    getlbl4 = getlabelname(ddl.SelectedValue, 4).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "13" Then

                    getlbl4 = getlabelname(ddl.SelectedValue, 13).Replace(" ", "_")

                End If

                Dim fileName5 As String = Path.GetExtension(spupd.PostedFile.FileName)

                spupd.PostedFile.SaveAs(Server.MapPath("uploads/" + Session("s") + "_" + getlbl4 + fileName5))

            Catch ex As Exception

            End Try

        End If


        If mrkshtupd.HasFile Then

            Dim getlbl5 As String = ""

            Try

                If ddl.SelectedValue = "2" Or ddl.SelectedValue = "3" Then

                    getlbl5 = getlabelname(ddl.SelectedValue, 6).Replace(" ", "_")

                ElseIf ddl.SelectedValue = "8" Then

                    getlbl5 = getlabelname(ddl.SelectedValue, 16).Replace(" ", "_")

                End If

                Dim fileName6 As String = Path.GetExtension(mrkshtupd.PostedFile.FileName)

                mrkshtupd.PostedFile.SaveAs(Server.MapPath("uploads/" + Session("s") + "_" + getlbl5 + fileName6))

            Catch ex As Exception

            End Try

        End If

        If npupd.HasFile Then

            Dim getlbl6 As String = ""

            Try

                If ddl.SelectedValue = "9" Then

                    getlbl6 = getlabelname(ddl.SelectedValue, 14).Replace(" ", "_")

                End If

                Dim fileName As String = Path.GetExtension(npupd.PostedFile.FileName)

                npupd.PostedFile.SaveAs(Server.MapPath("uploads/" + Session("s") + "_" + getlbl6 + fileName))

            Catch ex As Exception

            End Try

        End If

        Response.Redirect("printreceipt.aspx")

        newclick()

    End Sub
    Sub newclick()
        nametxt.Text = ""
        fathrtxt.Text = ""
        mothrtxt.Text = ""
        adstxt.Text = ""
        ddlcity.SelectedIndex = 0
        dsttxt.Text = ""
        mbtxt.Text = ""
        'fmtxt.Text = ""
        faitxt.Text = ""
        ddlicm.SelectedIndex = 0
        srcicmtxt.Text = ""
        ddl.SelectedIndex = 0
        dobtxt.Text = ""
        khsnmtxt.Text = ""
        engtxt.Text = ""
        cndname.Text = ""
        chsnmtxt.Text = ""
        rtnnmtxt.Text = ""
        thtxt.Text = ""
        txtamt.Text = ""
        txttrnnum.Text = ""

    End Sub

    'Public Sub phtbtn_Click(sender As Object, e As EventArgs) Handles phtbtn.Click

    '    Dim fileName As String = Path.GetFileName(photoupd.PostedFile.FileName)
    '    photoupd.PostedFile.SaveAs((Server.MapPath("~/WebSite1/uploads/") + fileName))

    'End Sub

    'Protected Sub adcrdbtn_Click(sender As Object, e As EventArgs) Handles adcrdbtn.Click
    '    Dim fileName As String = Path.GetFileName(adcrdupd.PostedFile.FileName)
    '    adcrdupd.PostedFile.SaveAs((Server.MapPath("~/WebSite1/uploads/") + fileName))

    'End Sub

    'Protected Sub ssbtn_Click(sender As Object, e As EventArgs) Handles ssbtn.Click
    '    Dim fileName As String = Path.GetFileName(ssupd.PostedFile.FileName)
    '    ssupd.PostedFile.SaveAs((Server.MapPath("~/WebSite1/uploads/") + fileName))

    'End Sub

    'Protected Sub rtncrdbtn_Click(sender As Object, e As EventArgs) Handles rtncrdbtn.Click
    '    Dim fileName As String = Path.GetFileName(rtncrdupd.PostedFile.FileName)
    '    rtncrdupd.PostedFile.SaveAs((Server.MapPath("~/WebSite1/uploads/") + fileName))

    'End Sub

    'Protected Sub spbtn_Click(sender As Object, e As EventArgs) Handles spbtn.Click
    '    Dim fileName As String = Path.GetFileName(spupd.PostedFile.FileName)
    '    spupd.PostedFile.SaveAs((Server.MapPath("~/WebSite1/uploads/") + fileName))

    'End Sub

    'Protected Sub mrkshtbtn_Click(sender As Object, e As EventArgs) Handles mrkshtbtn.Click
    '    Dim fileName As String = Path.GetFileName(mrkshtupd.PostedFile.FileName)
    '    mrkshtupd.PostedFile.SaveAs((Server.MapPath("~/WebSite1/uploads/") + fileName))

    'End Sub

    'Protected Sub npbtn_Click(sender As Object, e As EventArgs) Handles npbtn.Click
    '    Dim fileName As String = Path.GetFileName(npupd.PostedFile.FileName)
    '    npupd.PostedFile.SaveAs((Server.MapPath("~/WebSite1/uploads/") + fileName))


    'End Sub

    Protected Sub ddlcast_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlcast.SelectedIndexChanged
        'If ddlcast.SelectedIndex = 0 Then
        '    ddlsubcast.Items.Clear()
        '    Exit Sub
        'End If
        If ddl.SelectedValue = 2 Then
            photolb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True
            ddlcast.Visible = True
            ddlsubcast.Visible = True
            ddlthana.Visible = True
            ddlvill.Visible = True
            ddlcity.Visible = True
            ctytxt.Visible = False
            ' adcrdbtn.Visible = True
            mrkshtlb.Visible = True
            mrkshtupd.Visible = True
            ' mrkshtbtn.Visible = True
            plplb.Visible = True
            ssupd.Visible = True
            ' ssbtn.Visible = True
            splb.Visible = True
            spupd.Visible = True
            ' spbtn.Visible = True
            rtncrdeblb.Visible = True
            rtncrdupd.Visible = True
            ' rtncrdbtn.Visible = True
            txtamt.Text = "75 rs"
            fillsubcast()
            fillthana()
            fillvillage()
        End If
        If ddl.SelectedValue = 1 Then
            photolb.Visible = True
            photoupd.Visible = True
            'phtbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True
            'adcrdbtn.Visible = True
            sslb.Visible = True
            ssupd.Visible = True
            ' ssbtn.Visible = True
            splb.Visible = True
            spupd.Visible = True
            '  spbtn.Visible = True
            rtbcrdlb.Visible = True
            rtncrdupd.Visible = True
            ' rtncrdbtn.Visible = True
            txtamt.Text = "75 rs"
            ddlcast.Visible = True
            ddlsubcast.Visible = True
            ddlthana.Visible = True
            ddlvill.Visible = True
            ddlcity.Visible = True
            ctytxt.Visible = False
            fillsubcast()
            fillthana()
            fillvillage()


        End If
        If ddl.SelectedValue = 3 Then
            photolb.Visible = True
            photoupd.Visible = True
            ' phtbtn.Visible = True
            adhcrdlb.Visible = True
            adcrdupd.Visible = True
            updadhrbck.Visible = True
            lbladhrback.Visible = True
            ' adcrdbtn.Visible = True
            plplb.Visible = True
            ssupd.Visible = True
            '  ssbtn.Visible = True
            rtncrdeblb.Visible = True
            rtncrdupd.Visible = True
            ' rtncrdbtn.Visible = True
            splb.Visible = True
            spupd.Visible = True
            '   spbtn.Visible = True
            mrkshtlb.Visible = True
            mrkshtupd.Visible = True
            ' mrkshtbtn.Visible = True

            txtamt.Text = "75 rs"
            ddlcast.Visible = True
            ddlsubcast.Visible = True
            ddlthana.Visible = True
            ddlvill.Visible = True
            ddlcity.Visible = True
            ctytxt.Visible = False
            fillsubcast()
            fillthana()
            fillvillage()


        End If

    End Sub

    Protected Sub ddlcity_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlcity.SelectedIndexChanged
        fillthana()
        fillvillage()
        fillsubcast()
        ddlcast.Visible = True
        ddlsubcast.Visible = True
        ddlthana.Visible = True
        ddlvill.Visible = True
        ddlcity.Visible = True
        ctytxt.Visible = False
    End Sub
End Class
