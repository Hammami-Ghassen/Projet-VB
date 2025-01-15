Public Class flight_list
    Dim flightTable As New DataTable()
    Private Sub flight_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flightTable.Columns.Add("Num de Vol")
        flightTable.Columns.Add("Destination")
        flightTable.Columns.Add("Date")
        flightTable.Columns.Add("Heure")
        flightTable.Columns.Add("Nb de Places Dispo")
        flightTable.Columns.Add("Prix")
        DataGridView1.DataSource = flightTable

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class