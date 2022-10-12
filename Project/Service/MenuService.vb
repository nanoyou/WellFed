Imports WellFed
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

                Public Function 

            End Class
        End Namespace
    End Namespace
End Namespace

