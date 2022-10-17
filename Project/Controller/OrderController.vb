Imports WellFed.AkagawaTsurunaki.WellFed.Service
Imports WellFed.AkagawaTsurunaki.WellFed.Entity
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Controller
            Public Class OrderController
                Public Shared ReadOnly Property INSTANCE As OrderController = New OrderController()

                Private Shared ReadOnly Property ORDER_SERVICE As OrderService = OrderService.Instance
                Private Shared ReadOnly Property MENU_SERVICE As MenuService = MenuService.Instance
                Private Shared ReadOnly Property MEMBER_SERVICE As MemberService = MemberService.Instance

                Private Sub New()

                End Sub

                ''' <summary>
                ''' 
                ''' </summary>
                ''' <param name="tn"></param>
                ''' <returns></returns>
                Public Function MakeOrder(ByRef tn As TreeNode, ByRef lv As ListView) As Boolean
                    Dim name = tn.Text.Split(" ").ElementAt(0)
                    Dim mi = MENU_SERVICE.FindMenuByName(name)
                    If mi IsNot Nothing Then
                        ORDER_SERVICE.AddMenuItemToOrder(mi)
                        lv.Clear()
                        lv.Items.Clear()
                        For Each desc In ORDER_SERVICE.GetCurrentOrder().ToPlain()
                            lv.Items.Add(desc)
                        Next
                        Return True
                    End If
                    Return False

                End Function

                Public Sub SettleUp(ByRef lb As Label, ByRef tm As Label)
                    lb.Text = ORDER_SERVICE.GetCurrentOrder().Cost
                    tm.Text = ORDER_SERVICE.GetCurrentOrder().WaitTime
                End Sub

                Public Function Pay() As Boolean
                    If MEMBER_SERVICE.GetMemberLogined().Pay(ORDER_SERVICE.GetCurrentOrder().Cost) Then
                        MainForm.TimerWait.Start()
                        Return True
                    End If
                    Return False
                End Function

                Public Sub ClearOrder(ByRef lb As Label, ByRef tm As Label, ByRef lv As ListView)
                    ORDER_SERVICE.ClearOrder()
                    lb.Text = ORDER_SERVICE.GetCurrentOrder().Cost
                    tm.Text = ORDER_SERVICE.GetCurrentOrder().WaitTime
                    lv.Clear()
                End Sub

            End Class
        End Namespace
    End Namespace
End Namespace


