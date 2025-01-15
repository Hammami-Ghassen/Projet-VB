<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btn_cancel_login = New Button()
        btn_connecter = New Button()
        pwd_txt = New TextBox()
        Label2 = New Label()
        username_txt = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btn_cancel_login
        ' 
        btn_cancel_login.BackColor = Color.Cornsilk
        btn_cancel_login.Location = New Point(111, 128)
        btn_cancel_login.Name = "btn_cancel_login"
        btn_cancel_login.Size = New Size(96, 31)
        btn_cancel_login.TabIndex = 11
        btn_cancel_login.Text = "Annuler"
        btn_cancel_login.UseVisualStyleBackColor = False
        ' 
        ' btn_connecter
        ' 
        btn_connecter.BackColor = Color.Cornsilk
        btn_connecter.Location = New Point(213, 128)
        btn_connecter.Name = "btn_connecter"
        btn_connecter.Size = New Size(96, 31)
        btn_connecter.TabIndex = 10
        btn_connecter.Text = "Se connecter"
        btn_connecter.UseVisualStyleBackColor = False
        ' 
        ' pwd_txt
        ' 
        pwd_txt.BackColor = Color.Linen
        pwd_txt.Location = New Point(134, 81)
        pwd_txt.Name = "pwd_txt"
        pwd_txt.Size = New Size(161, 23)
        pwd_txt.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 15)
        Label2.TabIndex = 8
        Label2.Text = "mot de passe   :"
        ' 
        ' username_txt
        ' 
        username_txt.BackColor = Color.Linen
        username_txt.Location = New Point(134, 35)
        username_txt.Name = "username_txt"
        username_txt.Size = New Size(161, 23)
        username_txt.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(37, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 15)
        Label1.TabIndex = 6
        Label1.Text = "username  :"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(348, 214)
        Controls.Add(btn_cancel_login)
        Controls.Add(btn_connecter)
        Controls.Add(pwd_txt)
        Controls.Add(Label2)
        Controls.Add(username_txt)
        Controls.Add(Label1)
        Name = "login"
        Text = "login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_cancel_login As Button
    Friend WithEvents btn_connecter As Button
    Friend WithEvents pwd_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents username_txt As TextBox
    Friend WithEvents Label1 As Label
End Class
