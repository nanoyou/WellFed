Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Entity
            Public Class Tag : Implements HasPrimaryKey

                ' 标签的名称
                Public Property Name As String
                ' 标签的父标签ID
                ' 如果一个标签是顶级父标签, 那么它的Id应该设置为1
                Public Property ParentTagId As UInteger = 0
                ' 标签的ID
                Public Property tagId As UInteger

                Public Property Id As UInteger Implements HasPrimaryKey.PrimaryKey
                    Get
                        Return tagId
                    End Get
                    Set(value As UInteger)
                        tagId = value
                    End Set
                End Property

                ' 构造器
                Public Sub New()
                End Sub

                Public Sub New(ByVal name As String)
                    Me.Name = name
                End Sub

                Public Sub New(ByVal name As String, ByVal parentId As UInteger)
                    Me.Name = name
                    Me.ParentTagId = parentId
                End Sub

                Public Function HasParent() As UInteger
                    If Me.ParentTagId = 0 Then
                        Return False
                    End If
                    Return True
                End Function

                Public Function IsRoot() As UInteger
                    If Me.ParentTagId = 1 Then
                        Return True
                    End If
                    Return False
                End Function

                Public Overrides Function ToString() As String
                    Return $"标签ID: {tagId}, 标签名称: {Name}, 父标签ID: {ParentTagId}"
                End Function


            End Class
        End Namespace
    End Namespace
End Namespace

