
Imports MySql.Data.MySqlClient
Public Class Transaction
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
        "server=localhost;userid=root;database=goldenstadium"
        Dim SDA As New MySqlDataAdapter

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT goldenstadium.transac.transacid, goldenstadium.employee.name, goldenstadium.matchhh.matchh, goldenstadium.matchhh.datee, goldenstadium.matchhh.timee, goldenstadium.seat.tribune_name, goldenstadium.seat.gate, goldenstadium.seat.capacity, goldenstadium.transac.total_price FROM goldenstadium.transac INNER JOIN goldenstadium.employee ON goldenstadium.employee.empid = goldenstadium.transac.empid INNER JOIN goldenstadium.seat ON goldenstadium.seat.matchid = goldenstadium.transac.matchid INNER JOIN goldenstadium.matchhh ON goldenstadium.matchhh.matchid = goldenstadium.transac.matchid"
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
            Dim row As DataGridViewRow
            row = TableEmp.Rows(e.RowIndex)

            transacidd.Text = row.Cells("transacid").Value.ToString
            e_namee.Text = row.Cells("name").Value.ToString
            matchhh.Text = row.Cells("matchh").Value.ToString
            dateee.Text = row.Cells("datee").Value.ToString
            timeee.Text = row.Cells("timee").Value.ToString
            tribune_namee.Text = row.Cells("tribune_name").Value.ToString
            gatee.Text = row.Cells("gate").Value.ToString
            quantityy.Text = row.Cells("capacity").Value.ToString
            total_pricee.Text = row.Cells("total_price").Value.ToString

        End If
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs)
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("transacid LIKE '%{0}%' 
        OR goldenstadium.employee.name LIKE '%{0}%' OR goldenstadium.matchhh.matchh LIKE '%{0}%' OR goldenstadium.matchhh.date LIKE '%{0}%' OR goldenstadium.matchhh.time LIKE '%{0}%'
        OR goldenstadium.seat.tribune_name LIKE '%{0}%' OR goldenstadium.seat.gate LIKE '%{0}%' OR goldenstadium.seat.capacity LIKE '%{0}%' 
        OR goldenstadium.transac.total_price LIKE '%{0}%'", Search.Text)
        TableEmp.DataSource = DV
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admin.Show()
        Me.Hide()
    End Sub

End Class