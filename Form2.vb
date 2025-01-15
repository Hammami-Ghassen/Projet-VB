Public Class Form2
    Dim flightTable As New DataTable()

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        flightTable.Columns.Add("Num de Vol")
        flightTable.Columns.Add("Destination")
        flightTable.Columns.Add("Date")
        flightTable.Columns.Add("Heure")
        flightTable.Columns.Add("Nb de Places Dispo")
        flightTable.Columns.Add("Prix")
        DataGridView1.DataSource = flightTable


        info_utilisateur.DataGridView1.Columns.Add("Column1", "Name")
        info_utilisateur.DataGridView1.Columns.Add("Column2", "Surname")
        info_utilisateur.DataGridView1.Columns.Add("Column3", "Email")
        info_utilisateur.DataGridView1.Columns.Add("Column4", "Destination")
        info_utilisateur.DataGridView1.Columns.Add("Column5", "Date")
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If ValidateInputs() Then
            flightTable.Rows.Add(TxtBox1.Text, TxtBox2.Text, TxtBox3.Text, TxtBox4.Text, TxtBox5.Text, TxtBox6.Text)
            ClearFields()
        Else
            MessageBox.Show("Veuillez remplir tous les champs correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        If DataGridView1.SelectedRows.Count > 0 AndAlso ValidateInputs() Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            selectedRow.Cells("Destination").Value = TxtBox2.Text
            selectedRow.Cells("Date").Value = TxtBox3.Text
            selectedRow.Cells("Heure").Value = TxtBox4.Text
            selectedRow.Cells("Nb de Places Dispo").Value = TxtBox5.Text
            selectedRow.Cells("Prix").Value = TxtBox6.Text
            ClearFields()
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à modifier et remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function ValidateInputs() As Boolean
        Return Not (String.IsNullOrWhiteSpace(TxtBox1.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtBox2.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtBox3.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtBox4.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtBox5.Text) OrElse
                    String.IsNullOrWhiteSpace(TxtBox6.Text))
    End Function

    Private Sub ClearFields()
        TxtBox1.Clear()
        TxtBox2.Clear()
        TxtBox3.Clear()
        TxtBox4.Clear()
        TxtBox5.Clear()
        TxtBox6.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        info_utilisateur.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private isClosingConfirmed As Boolean = False
    Private Function ConfirmClose() As Boolean
        If Not isClosingConfirmed Then
            Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir fermer l'application ? ",
                                                         "Close Confirmation",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                isClosingConfirmed = True
                Return True
            Else
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub Form_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not ConfirmClose() Then
            e.Cancel = True
        End If
    End Sub
End Class