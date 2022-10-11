Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Entity
            Public Class Tag : Implements HasPrimaryKey

                ' 标签的名称
                Public Property Name As String
                ' 标签的父标签ID
                Public Property ParentTagId As UInteger
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

                Public Overrides Function ToString() As String
                    Return $"标签ID: {tagId}, 标签名称: {Name}, 父标签ID: {ParentTagId}"
                End Function


            End Class
        End Namespace
    End Namespace
End Namespace

