Imports WellFed.AkagawaTsurunaki.WellFed.Controller
Public Class PasswordForm
    Private Property password As String = ""

    Private Shared Property CONTROLLER As Controller = Controller.Instance

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

    End Sub

    Private Sub UpdateInputText()
        TxtBoxPsw.Text = password
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If password.Length > 0 Then
            password = password.Remove(password.Length - 1)
        End If
        UpdateInputText()
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        password += "0"
        UpdateInputText()
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        password += "1"
        UpdateInputText()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        password += "2"
        UpdateInputText()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        password += "3"
        UpdateInputText()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        password += "4"
        UpdateInputText()
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        password += "5"
        UpdateInputText()
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        password += "6"
        UpdateInputText()
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        password += "7"
        UpdateInputText()
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        password += "8"
        UpdateInputText()
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        password += "9"
        UpdateInputText()
    End Sub

    Private Sub TxtBoxPsw_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxPsw.TextChanged

    End Sub
End Class