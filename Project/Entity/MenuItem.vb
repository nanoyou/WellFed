﻿Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Entity
            Public Class MenuItem : Implements IHasPrimaryKey

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
                Public Property Id As UInteger Implements IHasPrimaryKey.PrimaryKey
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
        End Namespace
    End Namespace
End Namespace