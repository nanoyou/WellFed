Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Mapper
            Public Class TagMapper : Inherits Mapper.Mapper(Of Entity.Tag)
                Public Shared ReadOnly Property INSTANCE As TagMapper = New TagMapper()

                ''' <summary>
                ''' 返回根标签
                ''' </summary>
                ''' <returns></returns>
                Public Function SelectRootTag() As Entity.Tag
                    For Each tag In SelectAll()
                        If tag.Id = 1 Then
                            Return tag
                        End If
                    Next
                    Return Nothing
                End Function

                ''' <summary>
                ''' 返回一个指定的Tag的父Tag
                ''' </summary>
                ''' <param name="tagId"></param>
                ''' <returns></returns>
                Public Function SelectParentTag(ByVal tagId As UInteger) As Entity.Tag

                    Dim tag = SelectRecord(tagId)
                    If tag Is Nothing Then
                        Return Nothing
                    End If
                    Return SelectRecord(tag.ParentTagId)
                End Function

                ''' <summary>
                ''' 返回一个列表, 包括了含有父标签id的所有标签
                ''' </summary>
                ''' <param name="tagId"></param>
                ''' <returns></returns>
                Public Function SelectTagsByParentId(ByVal tagId As UInteger) As List(Of Entity.Tag)
                    Dim result As New List(Of Entity.Tag)
                    For Each tag In SelectAll()
                        If tag.ParentTagId = tagId Then
                            result.Add(tag)
                        End If
                    Next
                    Return result
                End Function

                ''' <summary>
                ''' 返回一个列表, 包括了根标签下的最叶标签
                ''' </summary>
                ''' <returns></returns>
                Public Function SelectLeafTags() As List(Of Entity.Tag)
                    Dim result As New List(Of Entity.Tag)
                    For Each tag In SelectAll()
                        If IsLeafTag(tag.Id) Then
                            result.Add(tag)
                        End If
                    Next
                    Return result
                End Function

                ''' <summary>
                ''' 判断标签是否为最叶标签
                ''' </summary>
                ''' <param name="tagId"></param>
                ''' <returns></returns>
                Public Function IsLeafTag(tagId As UInteger) As Boolean
                    For Each tag In SelectAll()
                        If tag.ParentTagId = tagId Then
                            Return False
                        End If
                    Next
                    Return True
                End Function

            End Class
        End Namespace
    End Namespace
End Namespace

