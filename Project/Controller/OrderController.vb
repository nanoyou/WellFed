Imports WellFed.AkagawaTsurunaki.WellFed.Service
Imports WellFed.AkagawaTsurunaki.WellFed.Entity
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Controller
            Public Class OrderController
                Public Shared ReadOnly Property INSTANCE As OrderController = New OrderController()

                Private Shared ReadOnly Property ORDER_SERVICE As OrderService = OrderService.INSTANCE
                Private Shared ReadOnly Property MENU_SERVICE As MenuService = MenuService.Instance

                Private Sub New()

                End Sub

                ''' <summary>
                ''' 
                ''' </summary>
                ''' <param name="lv"></param>
                ''' <returns></returns>
                Public Function MakeOrder(tn As TreeNode) As Boolean
                    Dim name = tn.Text.Split(" ").ElementAt(0)
                    Dim mi = MENU_SERVICE.FindMenuByName(name)
                    If mi IsNot Nothing Then
                        ORDER_SERVICE.AddMenuItemToOrder(mi)
                        Return True
                    End If
                    Return False

                End Function
            End Class
        End Namespace
    End Namespace
End Namespace


