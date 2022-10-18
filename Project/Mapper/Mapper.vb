Imports WellFed.AkagawaTsurunaki.WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Mapper
            Public Class Mapper(Of T As IHasPrimaryKey)

                Protected Property table As WellDataBase.Table(Of T)

                ''' <summary>
                ''' 保护的构造器
                ''' </summary>
                Protected Sub New()

                End Sub

                ''' <summary>
                ''' 初始化MemberMapper, 这是必要的
                ''' </summary>
                Public Function Init(tableName As String) As Boolean
                    table = WellDataBase.Table(Of T).Create(tableName)
                    Return True
                End Function

                ''' <summary>
                ''' 返回所有的记录
                ''' </summary>
                ''' <returns></returns>
                Public Function SelectAll() As List(Of T)
                    Return table.RecordList
                End Function

                ''' <summary>
                ''' 插入一条记录
                ''' </summary>
                ''' <param name="record"></param>
                ''' <returns></returns>
                Public Function Insert(ByRef record As T)
                    Return table.InsertRecord(record)
                End Function

                ''' <summary>
                ''' 插入若干条记录
                ''' </summary>
                ''' <param name="records"></param>
                ''' <returns></returns>
                Public Function Insert(ByRef records As List(Of T))
                    For Each record In records
                        If Not Insert(record) Then
                            Return False
                        End If
                    Next
                    Return True
                End Function

                ''' <summary>
                ''' 以主键ID查询一个记录
                ''' </summary>
                ''' <param name="id"></param>
                ''' <returns></returns>
                Public Function SelectRecord(ByVal id As UInteger) As T
                    Return table.SelectRecord(id)
                End Function

                ''' <summary>
                ''' 用于测试
                ''' </summary>
                Public Sub Print()
                    table.Print()
                End Sub


            End Class

        End Namespace
    End Namespace
End Namespace

