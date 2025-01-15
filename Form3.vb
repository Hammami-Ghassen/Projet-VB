Imports System.IO

Public Class Form3
    Dim cheminFichier As String = "recu.txt"

    Private Reservations As New List(Of String())
    Private Sub btn_reserver_Click(sender As Object, e As EventArgs) Handles btn_reserver.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Veuillez entrer un nom.")
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Veuillez entrer un prénom.")
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Veuillez entrer un numéro de téléphone.")
            Return
        End If

        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez sélectionner une destination.")
            Return
        End If

        If ComboBox2.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez sélectionner une date.")
            Return
        End If

        If TextBox1.Text.Length > 50 OrElse Not System.Text.RegularExpressions.Regex.IsMatch(TextBox1.Text, "^[a-zA-Z]+$") Then
            MessageBox.Show("Le nom doit contenir uniquement des lettres et ne pas dépasser 50 caractères.")
            Return
        End If

        If TextBox2.Text.Length > 50 OrElse Not System.Text.RegularExpressions.Regex.IsMatch(TextBox2.Text, "^[a-zA-Z]+$") Then
            MessageBox.Show("Le prénom doit contenir uniquement des lettres et ne pas dépasser 50 caractères.")
            Return
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(TextBox3.Text, "^[259]\d{6}$") Then
            MessageBox.Show("Numéro de téléphone invalide.")
            Return
        End If

        Dim reservation = {
            TextBox1.Text,
            TextBox2.Text,
            TextBox3.Text,
            ComboBox1.SelectedItem.ToString,
            ComboBox2.SelectedItem.ToString
        }
        Reservations.Add(reservation)
        info_utilisateur.DataGridView1.Rows.Add(reservation)
        Using writer As New StreamWriter(cheminFichier, True)
            writer.WriteLine("Nom: " & TextBox1.Text)
            writer.WriteLine("Prénom: " & TextBox2.Text)
            writer.WriteLine("Numéro de téléphone: " & TextBox3.Text)
            writer.WriteLine("Destination: " & ComboBox1.SelectedItem.ToString)
            writer.WriteLine("Date: " & ComboBox2.SelectedItem.ToString)
            writer.WriteLine("-----------------------------")
        End Using

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1

        MessageBox.Show("Réservation ajoutée avec succès !")
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(New String() {"Paris", "New York", "Tokyo", "London"})
        ComboBox2.Items.AddRange(New String() {"2025-01-10", "2025-01-15", "2025-02-01", "2025-03-05"})
        info_utilisateur.DataGridView1.Columns.Add("Column1", "Nom")
        info_utilisateur.DataGridView1.Columns.Add("Column2", "Prénom")
        info_utilisateur.DataGridView1.Columns.Add("Column3", "Téléphone")
        info_utilisateur.DataGridView1.Columns.Add("Column4", "Destination")
        info_utilisateur.DataGridView1.Columns.Add("Column5", "Date")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        flight_list.Show()
    End Sub
End Class
