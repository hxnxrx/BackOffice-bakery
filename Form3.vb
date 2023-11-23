Public Class Form3

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim texto, todososregistos As String
        Dim posun As Integer
        If txt_username.Text = "" Or txt_password.Text = "" Or txt_email.Text = "" Then
            MsgBox("Dados não preenchidos!",, "ERRO")
        Else
            ' verifica se já há um utilizador registado com esse username
            todososregistos = My.Computer.FileSystem.ReadAllText("Registro.txt")  'Lê todo o ficheiro 
            posun = InStr(todososregistos, txt_username.Text)                    'Procura o username introduzido no login
            If posun <> 0 Then                                                    'Vê se já existe um username igual
                MsgBox("Esse Username já existe!")
            Else
                'Acrescenta um espaço entre o username e a password e coloca ; no final
                texto = txt_username.Text + " " + txt_password.Text + ";"
                My.Computer.FileSystem.WriteAllText("Registro.txt", texto, True)
                MsgBox("Registo efetuado com sucesso!",, "Registro")
                Form1.username = txt_username.Text
                Form2.txt_usernamelogin.Text = txt_username.Text
            End If
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_username.Text = Form2.username
        txt_password.Text = Form2.password
    End Sub




End Class