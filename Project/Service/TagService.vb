﻿Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Imports WellFed.AkagawaTsurunaki.WellFed.Entity

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Service
            Public Class TagService : Implements Interfaces.IPreGenerator
                Public Shared ReadOnly Property Instance As TagService = New TagService()

                Public Sub Init()
                    Mapper.TagMapper.INSTANCE.Init("tag_table")
                    PreGenerate()
                End Sub

                Private Sub New()

                End Sub
                ''' <summary>
                ''' 通过Tag名称查找Tag(可能含多个)
                ''' </summary>
                ''' <param name="name"></param>
                ''' <returns></returns>
                Public Function FindTagByName(ByVal name As String) As List(Of Tag)
                    Dim list As List(Of Tag) = Mapper.TagMapper.INSTANCE.SelectAll()
                    Dim result As New List(Of Tag)
                    For Each tag In list
                        If tag.Name = name Then
                            result.Add(tag)
                        End If
                    Next
                    Return result
                End Function

                Public Sub PreGenerate() Implements IPreGenerator.PreGenerate

                    Dim setSonAndParent = Function(ByVal name As String, ByVal pName As String) As Entity.Tag
                                              Dim t = New Tag(name)
                                              t.ParentTagId = FindTagByName(pName).First.tagId
                                              Return t
                                          End Function
                    Dim rootTag As New Tag("餐饮类别", 1)
                    rootTag.ParentTagId = 0
                    Mapper.TagMapper.INSTANCE.Insert(rootTag)

                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("主食", "餐饮类别"))
                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("菜品", "餐饮类别"))
                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("饮品", "餐饮类别"))

                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("粥", "主食"))
                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("包子", "主食"))
                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("馄饨", "主食"))
                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("饼", "主食"))

                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("凉拌菜", "菜品"))
                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("蛋", "菜品"))

                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("豆浆", "饮品"))
                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("矿泉水", "饮品"))
                    Mapper.TagMapper.INSTANCE.Insert(setSonAndParent.Invoke("牛奶", "饮品"))


                    Mapper.TagMapper.INSTANCE.Print()
                End Sub

            End Class
        End Namespace
    End Namespace
End Namespace


