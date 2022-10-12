Imports WellFed.AkagawaTsurunaki.WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Service

Public Class MainForm

    Public Shared Sub Run()

        MemberService.Instance.Init()
        TagService.Instance.Init()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Run()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ClearBtn.Click

    End Sub

    Private Sub MenuTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles MenuTreeView.AfterSelect

    End Sub
End Class
