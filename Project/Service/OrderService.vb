Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Imports WellFed.AkagawaTsurunaki.WellFed.Mapper
Imports WellFed.AkagawaTsurunaki.WellFed.Entity

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Service
            Public Class OrderService : Implements Interfaces.PreGenerator

                Public Shared ReadOnly Property INSTANCE As OrderService = New OrderService()
                Private Shared ReadOnly Property MENU_SERVICE As MenuService = MenuService.Instance
                Private Shared Property selectedMenuItemList As New List(Of MenuItem)

                Private Shared Property order As New Order()

                Private Sub New()

                End Sub

                Public Function AddMenuItemToOrder(menuItem As MenuItem) As Boolean
                    If menuItem IsNot Nothing Then
                        selectedMenuItemList.Add(menuItem)
                        order.AddDish(menuItem)
                        Return True
                    End If
                    Return False
                End Function

                Public Sub PreGenerate() Implements PreGenerator.PreGenerate
                    Dim order = New Order()
                    order.MemberId = 1
                    Dim itm = Mapper.MenuItemMapper.INSTANCE.SelectAll().ElementAt(0)
                    order.DishList.Add(New Order.Dish(itm, 1))

                End Sub


            End Class
        End Namespace
    End Namespace
End Namespace

