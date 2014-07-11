Public Class frmLoggedIn

    
    Private Sub frmLoggedIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim currentDate As System.DateTime
        Dim currentHour As Integer

        currentDate = Date.Now()
        currentHour = currentDate.Hour

        'All buttons In & Out are disabled by default
        btnAmIn.Enabled = False
        btnAmOut.Enabled = False
        btnLunIn.Enabled = False
        btnLunOut.Enabled = False
        btnPmIn.Enabled = False
        btnPmOut.Enabled = False
        btnTimeIn.Enabled = False
        btnTimeOut.Enabled = False


        'for AM Break
        If currentHour = 10 Then
            btnAmIn.Enabled = True
            btnAmOut.Enabled = True
            ' for Lunch Break
        ElseIf currentHour = 11 Or currentHour = 12 Or currentHour = 13 Then
            btnLunIn.Enabled = True
            btnLunOut.Enabled = True
            'for PM Break
        ElseIf currentHour = 15 Then
            btnPmIn.Enabled = True
            btnPmOut.Enabled = True
        End If



        'TIME IN (including half day)
        If currentHour > 6 And currentHour < 14 Then
            btnTimeIn.Enabled = True
        End If

        'TIME OUT (including half day)
        If currentHour > 12 And currentHour < 21 Then
            btnTimeOut.Enabled = True
        End If

    End Sub

    Private Sub btnTimeIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeIn.Click

        ' Log In Confirmation
        MessageBox.Show("You have successfully logged in.", "My Application", _
         MessageBoxButtons.OK)
        If DialogResult.OK Then
            Me.Hide()
        End If
    End Sub

    Private Sub btnTimeOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTimeOut.Click

        ' Log Out Confirmation
        MessageBox.Show("You have successfully logged out.", "My Application", _
        MessageBoxButtons.OK)
        If DialogResult.OK Then
            Me.Hide()
        End If
    End Sub
End Class