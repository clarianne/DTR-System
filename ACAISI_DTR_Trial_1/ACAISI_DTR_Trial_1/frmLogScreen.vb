Public Class frmLogScreen

    Private Sub frmLogScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'System Date Timer
        Timer1.Enabled = True

        MaximizeBox = False
        MinimizeBox = False


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblDay.Text = Date.Now.ToString("dddd")
        lblDate.Text = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        ' Clears text box entry
        txtPin.Text = ""

        ' Pop-up dialog box
        frmLoggedIn.Show()
    End Sub

    Private Sub AdminLogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminLogInToolStripMenuItem.Click
        frmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        frmLogin.Show()
        frmLogin.btnExit.Hide()
        frmLogin.btnLogin.Text = "EXIT"
    End Sub
End Class