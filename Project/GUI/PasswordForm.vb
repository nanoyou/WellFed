Imports WellFed.AkagawaTsurunaki.WellFed.Controller
Public Class PasswordForm
    Private Property password As String = ""

    Private Shared Property controller As Controller = Controller.INSTANCE

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If Not password.Length = 6 Then
            MessageBox.Show("密码为6位数字。", "密码格式错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtBoxPsw.Text = ""
            Return
        End If

        LoginController.Instance.InputPassword(password)
        If LoginController.Instance.Login() Then
            If OrderController.INSTANCE.Pay() Then
                MessageBox.Show("支付成功，请耐心等待。当您的餐准备好后，本系统会自动呼叫您！", "支付成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Return
            Else
                MessageBox.Show("支付失败，您的余额不足，请到柜台处办理充值！", "支付失败", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
        Else
            MessageBox.Show("密码不正确。", "无法登录", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtBoxPsw.Text = ""
        End If
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
End Class