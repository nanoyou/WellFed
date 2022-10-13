Imports WellFed.AkagawaTsurunaki.WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Service
Imports WellFed.AkagawaTsurunaki.WellFed.Controller

Public Class MainForm
    Private Shared Property menuService As Service.MenuService = Service.MenuService.Instance
    Private Shared ReadOnly Property CONTROLLER As Controller = CONTROLLER.INSTANCE
    Private Shared ReadOnly Property ORDER_CONTROLLER As OrderController = OrderController.INSTANCE

    Private Shared ReadOnly Property isPay As Boolean = False


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

    Private Sub BtnSlct_Click(sender As Object, e As EventArgs) Handles BtnSlct.Click
        Dim node = TreeViewMenu.SelectedNode

        If node Is Nothing Then
            MessageBox.Show("您没有选中任何餐品", "不能加入一个菜单项", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not ORDER_CONTROLLER.MakeOrder(node, LVOrder) Then
            MessageBox.Show("您选中的不是一个具体的菜单项", "不能加入一个菜单项", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ORDER_CONTROLLER.SettleUp(LbCost, LbWaitTime)

    End Sub

    Private Sub TimerWait_Tick(sender As Object, e As EventArgs) Handles TimerWait.Tick
        LbWaitTime.Text -= 1
    End Sub
End Class
