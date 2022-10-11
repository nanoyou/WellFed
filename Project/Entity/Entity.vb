Imports Microsoft.VisualBasic
Imports System.Collections.Generic

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
                Public Property Tags As List(Of Tag)

                Private Property _id As UInteger

                ' 菜单项的ID
                Public Property Id() As UInteger Implements HasPrimaryKey.PrimaryKey
                    Get
                        Return Id
                    End Get
                    Set(value As UInteger)
                        _id = value
                    End Set
                End Property



                ' 菜单项的构造器
                Public Sub New()
                End Sub


            End Class





            Public Class Order
                Public Property Id As UInteger
                Public Property MenuItemId As UInteger
                Public Property WaitTime As UInteger
            End Class
        End Namespace
    End Namespace
End Namespace