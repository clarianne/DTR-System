Public Class frmLogScreen

    Private Sub frmLogScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'System Date Timer
        Timer1.Enabled = True

        Dim currentDate As System.DateTime
        Dim currentHour As Integer

        currentDate = Date.Now()
        currentHour = currentDate.Hour

        MaximizeBox = False
        MinimizeBox = False
        ' CloseBox = False

        'All buttons In & Out are disabled by default
        ' btnAmIn.Enabled = False
        ' btnAmOut.Enabled = False
        ' btnLunIn.Enabled = False
        ' btnLunOut.Enabled = False
        ' btnPmIn.Enabled = False
        ' btnPmOut.Enabled = False
        ' btnTimeIn.Enabled = False
        ' btnTimeOut.Enabled = False


        'for AM Break
        '  If currentHour = 10 Then
        '  btnAmIn.Enabled = True
        ' btnAmOut.Enabled = True
        'for Lunch Break
        '  ElseIf currentHour = 11 Or currentHour = 12 Or currentHour = 13 Then
        '  btnLunIn.Enabled = True
        '  btnLunOut.Enabled = True
        'for PM Break
        '   ElseIf currentHour = 15 Then
        '  btnPmIn.Enabled = True
        '   btnPmOut.Enabled = True
        '   End If



        'TIME IN (including half day)
        'If currentHour > 6 And currentHour < 14 Then
        ' btnTimeIn.Enabled = True
        '  End If

        'TIME OUT (including half day)
        '  If currentHour > 12 And currentHour < 21 Then
        'btnTimeOut.Enabled = True
        '   End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblDay.Text = Date.Now.ToString("dddd")
        lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub btnAdmLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmLogin.Show()
    End Sub

    Private Sub btnTimeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        ' Pop-up dialog box
        frmLoggedIn.Show()
    End Sub


    Private Sub AdminLogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminLogInToolStripMenuItem.Click
        frmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        frmLogin.Show()
    End Sub
End Class