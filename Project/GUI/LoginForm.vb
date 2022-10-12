﻿Imports WellFed.AkagawaTsurunaki.WellFed.Controller
Public Class LoginForm
    Private Property isTelInput As Boolean = True
    Private Property password As String = ""
    Private Shared Property controller As Controller = Controller.Instance
    Private Property input As String = ""
    Private Property telephone As String = ""

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If BtnLogin.Text = "登录" Then
            If controller.Login(telephone, password) Then
                MessageBox.Show($"尊敬的会员({telephone})登录成功！您可以立即下单了！", "登录成功", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                Me.Close()
            Else
                Me.Close()
            End If

        End If

        If isTelInput Then
            telephone = input
            input = ""
        End If
        isTelInput = Not isTelInput
        BtnLogin.Text = "登录"

    End Sub

    Private Sub UpdateInputText()
        If isTelInput Then
            TxtBoxTel.Text = input
        Else
            TxtBoxPsw.Text = input
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If input.Length > 0 Then
            input = input.Remove(input.Length - 1)
        End If
        UpdateInputText()
    End Sub
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        input += "0"
        UpdateInputText()
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        input += "1"
        UpdateInputText()
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        input += "2"
        UpdateInputText()
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        input += "3"
        UpdateInputText()
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        input += "4"
        UpdateInputText()
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        input += "5"
        UpdateInputText()
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        input += "6"
        UpdateInputText()
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        input += "7"
        UpdateInputText()
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        input += "8"
        UpdateInputText()
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        input += "9"
        UpdateInputText()
    End Sub
End Class