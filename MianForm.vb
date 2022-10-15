Imports WellFed.AkagawaTsurunaki.WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Service
Imports WellFed.AkagawaTsurunaki.WellFed.Controller


''' <summary>
''' Github @ AkagawaTsurunaki
''' From Northeastern University in LiaoNing, China
''' </summary>

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

        If Not ("6:00" < TimeOfDay And TimeOfDay < "10:00") Then
            MessageBox.Show("营业时间为6:00~10:00，给您带来不便非常抱歉！", "不在营业时间内", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
        End If

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
        If LbWaitTime.Text = "--" Then
            Return
        End If

        If LbWaitTime.Text > 0 Then
            LbWaitTime.Text -= 1
            Return
        End If

        TimerWait.Stop()
        MessageBox.Show("您的餐品已经准备好了。可以来取餐了！", "取餐时间到", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ORDER_CONTROLLER.ClearOrder(LbCost, LbWaitTime, LVOrder)
    End Sub
End Class
