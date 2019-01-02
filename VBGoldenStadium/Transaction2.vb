
Imports MySql.Data.MySqlClient
Public Class Transaction2
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label11.BackColor = Color.Transparent
        Load_Table()
    End Sub

    Private Sub Load_Table()
        TableEmp.DataSource = dbDataSet

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost;userid=root;password=;database=goldenstadium"
        Dim SDA As New MySqlDataAdapter

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT transacid, employee.name, matchhh.matchh, matchhh.datee, matchhh.timee, seat.tribune_name, seat.gate, transac.quantity, total_price FROM goldenstadium.transac INNER JOIN goldenstadium.employee ON employee.empid = transac.empid INNER JOIN goldenstadium.matchhh ON matchhh.matchid = transac.matchid INNER JOIN goldenstadium.seat ON seat.matchid = transac.matchid"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            TableEmp.DataSource = dbDataSet

            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub



    Private Sub TableEmp_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles TableEmp.CellMouseClick

        If e.RowIndex >= 0 Then

            transacidd.Text = TableEmp.Rows(e.RowIndex).Cells(0).Value.ToString
            e_namee.Text = TableEmp.Rows(e.RowIndex).Cells(1).Value.ToString
            matchhh.Text = TableEmp.Rows(e.RowIndex).Cells(2).Value.ToString
            dateee.Text = TableEmp.Rows(e.RowIndex).Cells(3).Value.ToString
            timeee.Text = TableEmp.Rows(e.RowIndex).Cells(4).Value.ToString
            tribune_namee.Text = TableEmp.Rows(e.RowIndex).Cells(5).Value.ToString
            gatee.Text = TableEmp.Rows(e.RowIndex).Cells(6).Value.ToString
            quantityy.Text = TableEmp.Rows(e.RowIndex).Cells(7).Value.ToString
            total_pricee.Text = TableEmp.Rows(e.RowIndex).Cells(8).Value.ToString

        End If
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Convert(transacid, 'System.String') LIKE '%{0}%' OR Convert(name, 'System.String') LIKE '%{0}%' OR Convert(matchh, 'System.String') LIKE '%{0}%' OR Convert(datee, 'System.String') LIKE '%{0}%' OR Convert(timee, 'System.String') LIKE '%{0}%' OR Convert(tribune_name, 'System.String') LIKE '%{0}%' OR Convert(gate, 'System.String') LIKE '%{0}%' OR Convert(quantity, 'System.String') LIKE '%{0}%' OR Convert(total_price, 'System.String') LIKE '%{0}%'", Search.Text)
        TableEmp.DataSource = DV
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Form1.Show()
        Me.Hide()
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
        Me.Show()
    End Sub
End Class