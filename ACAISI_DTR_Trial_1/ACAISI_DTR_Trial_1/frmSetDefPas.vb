Public Class frmSetDefPas

    Private Sub frmSetDefPas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
    End Sub
    
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Hide()
        frmAdminMenu.Show()
    End Sub

   
End Class