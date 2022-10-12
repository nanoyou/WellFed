Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Mapper
            Public Class TagMapper
                Public Shared ReadOnly Property Instance As TagMapper = New TagMapper()
                Private Shared Property tagTable As Table(Of Entity.Tag)
                ''' <summary>
                ''' 初始化TagMapper, 这是必要的
                ''' </summary>
                Public Sub Init()
                    tagTable = Table(Of Entity.Tag).Create("tag_table")
                End Sub
                ''' <summary>
                ''' 添加一个Tag到数据库
                ''' </summary>
                ''' <param name="tag"></param>
                Public Sub AddTag(ByRef tag As Entity.Tag)
                    tagTable.Insert(tag)
                End Sub
                Public Function FindTagById(ByVal id As UInteger) As Entity.Tag
                    Return tagTable.SelectRecord(id)
                End Function

                ''' <summary>
                ''' 获取所有的标签
                ''' </summary>
                ''' <returns></returns>
                Public Function FindTags() As List(Of Entity.Tag)
                    Return tagTable.RecordList
                End Function

                Public Sub Print()
                    tagTable.Print()
                End Sub

                Public Function SelectRootTag() As Entity.Tag
                    For Each tag In FindTags()
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
                    Dim tag = FindTagById(tagId)
                    If tag Is Nothing Then
                        Return Nothing
                    End If
                    Return FindTagById(tag.ParentTagId)
                End Function
                ''' <summary>
                ''' 返回一个列表, 包括了指定父标签id的所有标签
                ''' </summary>
                ''' <param name="tagId"></param>
                ''' <returns></returns>
                Public Function SelectTagsByParentId(ByVal tagId As UInteger) As List(Of Entity.Tag)
                    Dim result As New List(Of Entity.Tag)
                    For Each tag In FindTags()
                        If tag.ParentTagId = tagId Then
                            result.Add(tag)
                        End If
                    Next
                    Return result
                End Function


            End Class

        End Namespace
    End Namespace
End Namespace

