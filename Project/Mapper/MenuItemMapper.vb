
Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase
Imports WellFed.AkagawaTsurunaki.WellFed.Entity
Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Mapper
            Public Class MenuItemMapper : Inherits Mapper.Mapper(Of Entity.MenuItem)

                Public Shared ReadOnly Property INSTANCE As MenuItemMapper = New MenuItemMapper()

                ''' <summary>
                ''' 根据Tag搜索相关的菜单项
                ''' </summary>
                ''' <param name="tagId"></param>
                ''' <returns></returns>
                Public Function SelectByTag(tagId As UInteger) As List(Of Entity.MenuItem)
                    Dim result = New List(Of Entity.MenuItem)
                    For Each m In table.RecordList
                        For Each tagIdInMenuItem In m.TagIds
                            If tagId = tagIdInMenuItem Then
                                result.Add(m)
                            End If
                        Next
                    Next
                    Return result
                End Function

                ''' <summary>
                ''' 根据名称查询菜单项
                ''' </summary>
                ''' <param name="name"></param>
                ''' <returns></returns>
                Public Function SelectByName(name As String) As MenuItem
                    For Each menuItem In SelectAll()
                        If menuItem.Name = name Then
                            Return menuItem
                        End If
                    Next
                    Return Nothing
                End Function

            End Class

        End Namespace
    End Namespace
End Namespace
