Imports System.Reflection
Imports WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Entity
Imports WellFed.AkagawaTsurunaki.WellFed.Mapper
Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Service
            Public Class MenuService : Implements Interfaces.IPreGenerator

                Public Shared ReadOnly Property Instance = New MenuService()

                Private Shared ReadOnly Property menuItemMapper As MenuItemMapper = MenuItemMapper.Instance

                Public Sub PreGenerate() Implements IPreGenerator.PreGenerate

                    Dim fun = Sub(ByVal tagName As String, ByRef items As String())
                                  For Each item In items
                                      Dim tagId As UInteger = TagService.Instance.FindTagByName(tagName).First.tagId
                                      Dim menuItem As MenuItem = New MenuItem()
                                      menuItem.Price = New Decimal(Int(Rnd() * 60))
                                      menuItem.Name = item
                                      menuItem.WaitTime = Rnd() * 700
                                      menuItem.TagIds.Add(tagId)
                                      MenuItemMapper.Instance.Insert(menuItem)
                                  Next
                              End Sub

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

                    MenuItemMapper.Instance.Print()
                End Sub

                Public Sub Init()
                    MenuItemMapper.Instance.Init("menu_item_table")
                    PreGenerate()
                End Sub
                ''' <summary>
                ''' 获取一个拥有所有菜单项的TreeView
                ''' </summary>
                Public Sub GetTreeNodeWithAllMenuItems(ByRef tv As TreeView)
                    Dim menuItemList As List(Of MenuItem) = MenuItemMapper.Instance.SelectAll()
                    Dim rootTag = TagMapper.INSTANCE.SelectRootTag()
                    Dim rootNode As New TreeNode(rootTag.Name)
                    tv.Nodes.Add(rootNode)
                    RecursivelyGetTreeNode(tv.Nodes, rootTag, 0)
                    WriteLeafNodeWithMenuItem(rootNode)
                End Sub

                Function RecursivelyGetTreeNode(ByRef nd As TreeNodeCollection, pTag As Entity.Tag, ByVal count As Integer)
                    Dim tagList = Mapper.TagMapper.INSTANCE.SelectTagsByParentId(pTag.Id)
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

                Sub WriteLeafNodeWithMenuItem(ByRef node As TreeNode)

                    Dim leafTagList = Mapper.TagMapper.INSTANCE.SelectLeafTags()

                    For Each tag In leafTagList
                        Dim menuItemList = Mapper.MenuItemMapper.Instance.SelectByTag(tag.Id)

                        For Each m In menuItemList
                            Dim nd = Util.WellFedHelper.FindNode(node, tag.Name)
                            If nd IsNot Nothing Then
                                nd.Nodes.Add(m.ToPlain())
                            End If
                        Next
                    Next


                End Sub

                Public Function FindMenuByName(name As String) As MenuItem
                    Return menuItemMapper.SelectByName(name)
                End Function


            End Class
        End Namespace
    End Namespace
End Namespace

