Imports WellFed.AkagawaTsurunaki.WellFed.Controller
Public Class TelephoneForm
    Private Property telephone As String = ""

    Private Shared Property loginController As LoginController = LoginController.Instance

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If loginController.InputTelephone(telephone) Then
            LoginController.Instance.Show(LoginController.WindowType.Password)
            Me.Close()
        End If
        telephone = ""
        UpdateInputText()
    End Sub

    Private Sub UpdateInputText()
        TxtBoxTel.Text = telephone
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If telephone.Length > 0 Then
            telephone = telephone.Remove(telephone.Length - 1)
        End If
        UpdateInputText()
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        telephone += "0"
        UpdateInputText()
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        telephone += "1"
        UpdateInputText()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        telephone += "2"
        UpdateInputText()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        telephone += "3"
        UpdateInputText()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        telephone += "4"
        UpdateInputText()
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        telephone += "5"
        UpdateInputText()
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        telephone += "6"
        UpdateInputText()
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        telephone += "7"
        UpdateInputText()
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        telephone += "8"
        UpdateInputText()
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        telephone += "9"
        UpdateInputText()
    End Sub
End Class