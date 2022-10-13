Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

' @author 软件2107班 张轩赫 20216875 
' @github AkagawaTsurunaki
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Entity
            Public Interface HasPrimaryKey
                Property PrimaryKey As UInteger
            End Interface


            Public Class MenuItem : Implements HasPrimaryKey

                ' 菜单项的名称
                Public Property Name As String

                ' 菜单项的价格
                Public Property Price As Decimal

                ' 菜单项的Tag, 可用来对该项进行标签 
                Public Property TagIds As New List(Of UInteger)

                ' 菜单项的等待时间
                Public Property WaitTime As UInteger

                Private Property menuId As UInteger

                ' 菜单项的ID
                Public Property Id As UInteger Implements HasPrimaryKey.PrimaryKey
                    Get
                        Return menuId
                    End Get
                    Set(value As UInteger)
                        menuId = value
                    End Set
                End Property

                ' 菜单项的构造器
                Public Sub New()
                End Sub

                Public Overrides Function ToString() As String
                    Return $"菜品ID: {menuId}, 菜品名称: {Name}, 菜品价格: {Price}, 菜品标签: {TagIds}"
                End Function

                Public Function ToPlain() As String
                    Return $"{Name} {Price}元/份 {CUInt(WaitTime / 60) }分钟"
                End Function


            End Class


            Public Class Order : Implements HasPrimaryKey
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

                Public Property Id As UInteger Implements HasPrimaryKey.PrimaryKey
                    Get
                        Return orderId
                    End Get
                    Set(value As UInteger)
                        orderId = value
                    End Set
                End Property


            End Class
        End Namespace
    End Namespace
End Namespace