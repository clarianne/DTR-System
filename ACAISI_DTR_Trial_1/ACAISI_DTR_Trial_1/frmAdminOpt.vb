Public Class frmAdminOpt

    Private Sub frmAdminOpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub btnAdminMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminMenu.Click
        Me.Hide()
        frmAdminMenu.Show()
    End Sub

End Class