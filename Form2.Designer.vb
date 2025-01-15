<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TxtBox3 = New TextBox()
        TxtBox2 = New TextBox()
        TxtBox4 = New TextBox()
        TxtBox5 = New TextBox()
        TxtBox6 = New TextBox()
        Label6 = New Label()
        Btn1 = New Button()
        Btn2 = New Button()
        Btn3 = New Button()
        TxtBox1 = New TextBox()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(13, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(101, 15)
        Label1.TabIndex = 0
        Label1.Text = "NUM DE VOL       :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(13, 246)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 1
        Label2.Text = "HEURE                 :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(6, 315)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 2
        Label3.Text = "NB DE PLACE:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(6, 101)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 15)
        Label4.TabIndex = 3
        Label4.Text = "DESTINATION        :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(13, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 15)
        Label5.TabIndex = 4
        Label5.Text = "DATE                    :"
        ' 
        ' TxtBox3
        ' 
        TxtBox3.BackColor = Color.Linen
        TxtBox3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox3.Location = New Point(153, 160)
        TxtBox3.Margin = New Padding(3, 2, 3, 2)
        TxtBox3.Name = "TxtBox3"
        TxtBox3.Size = New Size(168, 39)
        TxtBox3.TabIndex = 7
        ' 
        ' TxtBox2
        ' 
        TxtBox2.BackColor = Color.Linen
        TxtBox2.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox2.Location = New Point(153, 86)
        TxtBox2.Margin = New Padding(3, 2, 3, 2)
        TxtBox2.Name = "TxtBox2"
        TxtBox2.Size = New Size(168, 39)
        TxtBox2.TabIndex = 8
        ' 
        ' TxtBox4
        ' 
        TxtBox4.BackColor = Color.Linen
        TxtBox4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox4.Location = New Point(153, 231)
        TxtBox4.Margin = New Padding(3, 2, 3, 2)
        TxtBox4.Name = "TxtBox4"
        TxtBox4.Size = New Size(168, 39)
        TxtBox4.TabIndex = 9
        ' 
        ' TxtBox5
        ' 
        TxtBox5.BackColor = Color.Linen
        TxtBox5.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox5.Location = New Point(153, 300)
        TxtBox5.Margin = New Padding(3, 2, 3, 2)
        TxtBox5.Name = "TxtBox5"
        TxtBox5.Size = New Size(168, 39)
        TxtBox5.TabIndex = 10
        ' 
        ' TxtBox6
        ' 
        TxtBox6.BackColor = Color.Linen
        TxtBox6.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox6.Location = New Point(153, 361)
        TxtBox6.Margin = New Padding(3, 2, 3, 2)
        TxtBox6.Name = "TxtBox6"
        TxtBox6.Size = New Size(168, 39)
        TxtBox6.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(12, 376)
        Label6.Name = "Label6"
        Label6.Size = New Size(97, 15)
        Label6.TabIndex = 12
        Label6.Text = "PRIX                     :"
        ' 
        ' Btn1
        ' 
        Btn1.BackColor = Color.Cornsilk
        Btn1.ForeColor = SystemColors.ActiveCaptionText
        Btn1.Location = New Point(367, 88)
        Btn1.Margin = New Padding(3, 2, 3, 2)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(134, 36)
        Btn1.TabIndex = 13
        Btn1.Text = "Ajouter"
        Btn1.UseVisualStyleBackColor = False
        ' 
        ' Btn2
        ' 
        Btn2.BackColor = Color.Cornsilk
        Btn2.ForeColor = SystemColors.ActiveCaptionText
        Btn2.Location = New Point(367, 27)
        Btn2.Margin = New Padding(3, 2, 3, 2)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(134, 36)
        Btn2.TabIndex = 14
        Btn2.Text = "Modifier"
        Btn2.UseVisualStyleBackColor = False
        ' 
        ' Btn3
        ' 
        Btn3.BackColor = Color.Cornsilk
        Btn3.ForeColor = SystemColors.ActiveCaptionText
        Btn3.Location = New Point(367, 151)
        Btn3.Margin = New Padding(3, 2, 3, 2)
        Btn3.Name = "Btn3"
        Btn3.Size = New Size(134, 36)
        Btn3.TabIndex = 15
        Btn3.Text = "Supprimer"
        Btn3.UseVisualStyleBackColor = False
        ' 
        ' TxtBox1
        ' 
        TxtBox1.BackColor = Color.Linen
        TxtBox1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtBox1.Location = New Point(153, 15)
        TxtBox1.Margin = New Padding(3, 2, 3, 2)
        TxtBox1.Name = "TxtBox1"
        TxtBox1.Size = New Size(168, 39)
        TxtBox1.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cornsilk
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(367, 213)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 36)
        Button1.TabIndex = 18
        Button1.Text = "Liste des réeservation"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(13, 420)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(528, 282)
        DataGridView1.TabIndex = 20
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Moccasin
        ClientSize = New Size(551, 814)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(Btn3)
        Controls.Add(Btn2)
        Controls.Add(Btn1)
        Controls.Add(Label6)
        Controls.Add(TxtBox6)
        Controls.Add(TxtBox5)
        Controls.Add(TxtBox4)
        Controls.Add(TxtBox2)
        Controls.Add(TxtBox3)
        Controls.Add(TxtBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TxtBox3 As TextBox
    Friend WithEvents TxtBox2 As TextBox
    Friend WithEvents TxtBox4 As TextBox
    Friend WithEvents TxtBox5 As TextBox
    Friend WithEvents TxtBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents TxtBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
