Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Entity
            Public Class Order : Implements IHasPrimaryKey
                Private Property orderId As UInteger
                Public Property MemberId As UInteger
                Public Class Dish

                    Public Sub New(itm As MenuItem, cnt As Integer)
                        Item = itm
                        Count = cnt
                    End Sub

                    Public Property Item As MenuItem
                    Public Property Count As Integer
                End Class

                Public Property DishList As New List(Of Dish)

                ''' <summary>
                ''' 为订单添加一款菜单项, 相同的菜单项将会被合并
                ''' </summary>
                ''' <param name="mi"></param>
                Public Sub AddDish(mi As MenuItem)
                    For Each d In DishList
                        If d.Item.Id = mi.Id Then
                            d.Count += 1
                            Return
                        End If
                    Next
                    DishList.Add(New Dish(mi, 1))
                End Sub


                ' 订单价格
                Public ReadOnly Property Cost As Decimal
                    Get
                        Dim ret As New Decimal(0)
                        For Each d In DishList
                            ret += CDec(d.Count) * d.Item.Price
                        Next
                        Return ret
                    End Get
                End Property

                Public ReadOnly Property WaitTime As UInteger
                    Get
                        Dim ret As UInteger
                        For Each d In DishList
                            ret += d.Item.WaitTime * d.Count
                        Next
                        Return ret
                    End Get
                End Property

                Public Property Id As UInteger Implements IHasPrimaryKey.PrimaryKey
                    Get
                        Return orderId
                    End Get
                    Set(value As UInteger)
                        orderId = value
                    End Set
                End Property

                Public Function ToPlain() As List(Of String)
                    Dim ret As New List(Of String)
                    For Each d In DishList
                        ret.Add($"{d.Item.Name} * {d.Count}")
                    Next
                    Return ret
                End Function

            End Class
        End Namespace
    End Namespace
End Namespace