Imports System.Reflection
Imports WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Entity
Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Service
            Public Class MenuService : Implements Interfaces.PreGenerator

                Public Shared ReadOnly Property Instance = New MenuService()
                ' Private Shared Property menuTable As Table(Of Entity.MenuItem)

                Public Sub PreGenerate() Implements PreGenerator.PreGenerate

                    Dim fun = Function(ByVal tagName As String, ByRef items As String())
                                  For Each item In items
                                      Dim tagId = TagService.Instance.FindTagByName(tagName).First.tagId
                                      Dim menuItem = New Entity.MenuItem()
                                      menuItem.Price = New Decimal(Int(Rnd() * 60))
                                      menuItem.Name = item
                                      menuItem.WaitTime = Rnd() * 1000
                                      menuItem.TagIds.Add(tagId)
                                      Mapper.MenuItemMapper.Instance.InsertMember(menuItem)
                                  Next
                              End Function

                    ' 主食
                    fun.Invoke("粥", {"小米粥", "皮蛋瘦肉粥", "八宝粥", "黑米粥", "绿豆粥"})
                    fun.Invoke("包子", {"猪肉包", "牛肉包", "素菜包", "豆沙包"})
                    fun.Invoke("馄饨", {"馄饨"})
                    fun.Invoke("饼", {"葱油饼", "糖饼", "牛肉馅饼", "猪肉馅饼"})

                    ' 菜品
                    fun.Invoke("凉拌菜", {"凉拌菜"})
                    fun.Invoke("蛋", {"白煮蛋", "茶叶蛋", "煎蛋", "咸鸭蛋"})

                    ' 饮品
                    fun.Invoke("豆浆", {"热豆浆", "凉豆浆"})
                    fun.Invoke("矿泉水", {"矿泉水"})
                    fun.Invoke("牛奶", {"热牛奶", "凉牛奶"})

                    Mapper.MenuItemMapper.Instance.Print()
                End Sub

                Public Function Init()
                    Mapper.MenuItemMapper.Instance.Init()
                    PreGenerate()
                End Function
                ''' <summary>
                ''' 获取一个拥有所有菜单项的TreeView
                ''' </summary>
                ''' <returns></returns>
                Public Function GetTreeNodeWithAllMenuItems(ByRef tv As TreeView)
                    Dim menuItemList = Mapper.MenuItemMapper.Instance.SelectAll()
                    Dim rootTag = Mapper.TagMapper.Instance.SelectRootTag()
                    Dim rootNode As New TreeNode(rootTag.Name)
                    tv.Nodes.Add(rootNode)
                    RecursivelyGetTreeNode(tv.Nodes, rootTag, 0)
                    fun(rootNode)
                End Function

                Function RecursivelyGetTreeNode(ByRef nd As TreeNodeCollection, pTag As Entity.Tag, ByVal count As Integer)
                    Dim tagList = Mapper.TagMapper.Instance.SelectTagsByParentId(pTag.Id)
                    ' 如果已经递归到底, 则直接返回
                    If tagList.Count = 0 Then
                        Return True
                    End If
                    ' 递归查询所有Tag
                    For Each tag In tagList
                        nd(count).Nodes.Add(tag.Name)
                        ' 叶节点判断
                        RecursivelyGetTreeNode(nd(count).Nodes, tag, tagList.IndexOf(tag))
                    Next
                    Return False
                End Function

                Sub fun(ByRef node As TreeNode)

                    Dim leafTagList = Mapper.TagMapper.Instance.SelectLeafTags()

                    For Each t In leafTagList
                        Dim menuList = Mapper.MenuItemMapper.Instance.SelectMenuItemByTag(t.Id)

                        For Each m In menuList
                            Dim nd = Util.WellFedHelper.FindNode(node, t.Name)
                            If nd IsNot Nothing Then
                                nd.Nodes.Add(m.ToPlain())
                            End If
                        Next
                    Next


                End Sub

            End Class
        End Namespace
    End Namespace
End Namespace

