Public Class Admin2
    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Employee2.Show()
        Hide()
    End Sub

    Private Sub btnMatch_Click(sender As Object, e As EventArgs) Handles btnMatch.Click
        MatchManage2.Show()
        Hide()
    End Sub

    Private Sub btnSeat_Click(sender As Object, e As EventArgs) Handles btnSeat.Click
        SeatManage2.Show()
        Hide()
    End Sub

    Private Sub btnTransac_Click(sender As Object, e As EventArgs) Handles btnTransac.Click
        Transaction2.Show()
        Hide()
    End Sub

    Private Sub pnlDashboard_Paint(sender As Object, e As PaintEventArgs) Handles pnlDashboard.Paint

    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) 

    End Sub
End Class