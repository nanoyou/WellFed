Imports WellFed.AkagawaTsurunaki.WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Service
Imports WellFed.AkagawaTsurunaki.WellFed.Controller

Public Class MainForm
    Private Shared Property menuService As Service.MenuService = Service.MenuService.Instance
    Private Shared ReadOnly Property CONTROLLER As Controller = Controller.INSTANCE

    Public Shared Sub Run()
        controller.Init()
    End Sub
    Private Sub Form_Load(ByVal sender As Object,
    ByVal e As System.EventArgs) Handles MyBase.Load
        Run()
        menuService.GetTreeNodeWithAllMenuItems(TreeViewMenu)
        TreeViewMenu.Refresh()

    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        LoginController.INSTANCE.Show(LoginController.WindowType.Telephone)
    End Sub

End Class
