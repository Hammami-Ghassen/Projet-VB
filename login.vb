Imports System.IO

Public Class login



    Private Function ValidateCredentials(username As String, password As String) As Boolean

        Dim filePath As String = "credentials.txt"


        If Not File.Exists(filePath) Then
            MessageBox.Show("Credentials file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If


        Dim lines() As String = File.ReadAllLines(filePath)


        For Each line As String In lines
            Dim parts() As String = line.Split(":"c)
            If parts.Length = 2 AndAlso parts(0) = username AndAlso parts(1) = password Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub btn_connecter_Click(sender As Object, e As EventArgs) Handles btn_connecter.Click

        Dim username As String = username_txt.Text
        Dim password As String = pwd_txt.Text


        If ValidateCredentials(username, password) Then
            If username.Equals("admin") Then
                Form2.Show()
                Me.Hide()
            Else
                Form3.Show()
                Me.Hide()
            End If

        Else
            MessageBox.Show("Mot de passe incorrecte!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_cancel_login_Click(sender As Object, e As EventArgs) Handles btn_cancel_login.Click
        Me.Close()
    End Sub


    Private Sub Form_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not ConfirmClose() Then
            e.Cancel = True
        End If
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
End Class