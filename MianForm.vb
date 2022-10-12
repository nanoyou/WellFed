﻿Imports WellFed.AkagawaTsurunaki.WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Service
Imports WellFed.AkagawaTsurunaki.WellFed.Controller

Public Class MainForm

    Private Shared Property controller As Controller = Controller.Instance

    Public Shared Sub Run()
        controller.Init()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        controller.Rediret("/login")
    End Sub
End Class
