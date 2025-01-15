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

        info_utilisateur.DataGridView1.Columns.Add("Column1", "Nom")
        info_utilisateur.DataGridView1.Columns.Add("Column2", "Prénom")
        info_utilisateur.DataGridView1.Columns.Add("Column3", "Téléphone")
        info_utilisateur.DataGridView1.Columns.Add("Column4", "Destination")
        info_utilisateur.DataGridView1.Columns.Add("Column5", "Date")
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        If ValidateInputs() Then
            flightTable.Rows.Add(TxtBox1.Text, TxtBox2.Text, TxtBox3.Text, TxtBox4.Text, TxtBox5.Text, TxtBox6.Text)
            ClearFields()
            MessageBox.Show("Vol ajouté avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrWhiteSpace(TxtBox1.Text) Then
            MessageBox.Show("Le numéro de vol est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(TxtBox1.Text, "^[A-Z0-9]{3,6}$") Then
            MessageBox.Show("Le numéro de vol doit contenir entre 3 et 6 caractères alphanumériques.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtBox2.Text) Then
            MessageBox.Show("La destination est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtBox3.Text) Then
            MessageBox.Show("La date est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not Date.TryParse(TxtBox3.Text, Nothing) Then
            MessageBox.Show("La date doit être au format valide (ex : 2025-01-15).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtBox4.Text) Then
            MessageBox.Show("L'heure est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(TxtBox4.Text, "^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$") Then
            MessageBox.Show("L'heure doit être au format HH:MM (ex : 14:30).", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtBox5.Text) Then
            MessageBox.Show("Le nombre de places disponibles est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not Integer.TryParse(TxtBox5.Text, Nothing) OrElse CInt(TxtBox5.Text) <= 0 Then
            MessageBox.Show("Le nombre de places doit être un entier positif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If String.IsNullOrWhiteSpace(TxtBox6.Text) Then
            MessageBox.Show("Le prix est obligatoire.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not Decimal.TryParse(TxtBox6.Text, Nothing) OrElse CDec(TxtBox6.Text) <= 0 Then
            MessageBox.Show("Le prix doit être un nombre positif.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    Private Sub ClearFields()
        TxtBox1.Clear()
        TxtBox2.Clear()
        TxtBox3.Clear()
        TxtBox4.Clear()
        TxtBox5.Clear()
        TxtBox6.Clear()
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
            MessageBox.Show("Vol modifié avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à modifier et remplir tous les champs correctement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In DataGridView1.SelectedRows
                DataGridView1.Rows.Remove(row)
            Next
            MessageBox.Show("Vol supprimé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        info_utilisateur.Show()
    End Sub

    Private isClosingConfirmed As Boolean = False

    Private Function ConfirmClose() As Boolean
        If Not isClosingConfirmed Then
            Dim result As DialogResult = MessageBox.Show("Êtes-vous sûr de vouloir fermer l'application ? ",
                                                         "Confirmation de fermeture",
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
