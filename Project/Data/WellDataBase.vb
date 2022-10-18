Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Namespace AkagawaTsurunaki

    Namespace WellFed
        Namespace WellDataBase
            Public Class Table(Of T As IHasPrimaryKey)

                Public Property TableName As String
                Public Property PrimaryKey As UInteger
                Public Property RecordList As List(Of T)

                Private Sub New()

                End Sub

                Public Shared Function Create(ByVal tableName As String) As Table(Of T)
                    Dim table As New Table(Of T)
                    table.TableName = tableName
                    table.PrimaryKey = 0
                    table.RecordList = New List(Of T)
                    Return table
                End Function

                Public Function InsertRecord(ByRef record As T) As Boolean
                    If record Is Nothing Then
                        Throw New ArgumentNullException("插入的数据不应该为空")
                    End If
                    ' 主键自增
                    PrimaryKey += 1
                    record.PrimaryKey = PrimaryKey
                    RecordList.Add(record)
                    Return True
                End Function

                Public Function SelectRecord(ByVal primaryKey As UInteger) As T
                    For Each record In RecordList
                        If record.PrimaryKey = primaryKey Then
                            Return record
                        End If
                    Next
                    Return Nothing
                End Function

                Public Function SelectRecords() As List(Of T)
                    Return RecordList
                End Function

                Public Sub Print()
                    Console.WriteLine()
                    Console.WriteLine($"表名{TableName}")
                    For Each record In RecordList
                        Console.WriteLine("------------------")
                        Console.WriteLine($"主键{record.PrimaryKey}")
                        Console.WriteLine($"主键{record.ToString()}")
                    Next
                End Sub

            End Class
        End Namespace
    End Namespace
End Namespace