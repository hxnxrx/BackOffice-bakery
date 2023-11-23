Public Class Form2
    Public username, password As String


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        username = txt_usernamelogin.Text
        password = TXT_PasswordLogin.Text
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub txt_username_login_TextChanged(sender As Object, e As EventArgs) Handles txt_usernamelogin.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim todososregistos, passregistada As String
        Dim posun, posesp, pospv As Integer
        username = TXT_UsernameLogin.Text
        password = TXT_PasswordLogin.Text
        If username = "" Or password = "" Then      'sername e a password preenchidos?
            MsgBox("Dados não preenchidos!",, "ERRO")
        Else
            If CheckBox1.Checked = False Then
                MsgBox("Tem que ler e aceitar os termos!",, "ERRO")
            Else
                todososregistos = My.Computer.FileSystem.ReadAllText("Registro.txt")  'Lê todo o ficheiro 
                posun = InStr(todososregistos, username)                             'Procura o username introduzido no login
                If posun = 0 Then                                                    'Vê se não existe o username registado
                    MsgBox("Utilizador inexistente! Tem que se registar.")
                Else
                    todososregistos = Mid(todososregistos, posun)                     'Elimina tudo o que está antes do username encontrado
                    posesp = InStr(todososregistos, " ")                              'Procura o espaço entre o username e a password
                    pospv = InStr(todososregistos, ";")                               'Procura o ; a seguir à password
                    passregistada = Mid(todososregistos, posesp + 1, pospv - posesp - 1)  'Retira a password registada
                    If password = passregistada Then
                        MsgBox("login com Sucesso")
                        Me.Hide()
                        Form1.Show()
                    Else MsgBox("Password Errada!")
                    End If
                End If
            End If
        End If

    End Sub

End Class