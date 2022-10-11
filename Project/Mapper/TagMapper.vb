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

                Public Function FindTags() As List(Of Entity.Tag)
                    Return tagTable.RecordList
                End Function

                Public Sub Print()
                    tagTable.Print()
                End Sub
            End Class

        End Namespace
    End Namespace
End Namespace

