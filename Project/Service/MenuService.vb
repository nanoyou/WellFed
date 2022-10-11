Imports WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Service
            Public Class MenuService : Implements Interfaces.PreGenerator

                Public Sub PreGenerate() Implements PreGenerator.PreGenerate

                    ' 主食
                    Dim porridge As String() = {"小米粥", "皮蛋瘦肉粥", "八宝粥", "黑米粥", "绿豆粥"}




                    Dim baozi As String() = {"猪肉包", "牛肉包", "素菜包", "豆沙包"}
                    Dim huntun As String = "馄饨"
                    Dim pancake As String() = {"葱油饼", "糖饼", "牛肉馅饼", "猪肉馅饼"}



                    ' 菜品
                    Dim liangbancai As String = "凉拌菜"
                    Dim egg As String() = {"白煮蛋", "茶叶蛋", "煎蛋", "咸鸭蛋"}

                    ' 饮品
                    Dim doujiang As String() = {"热豆浆", "凉豆浆"}
                    Dim water As String = "矿泉水"
                    Dim milk As String() = {"热牛奶", "凉牛奶"}
                End Sub

                Public Function Init()
                    Dim menuTable As Table(Of Entity.MenuItem)
                    menuTable = Table(Of Entity.MenuItem).Create("menu_table")
                    Dim menu As New Entity.MenuItem
                    Dim tag1 As New Entity.Tag()

                    menu.Price = New Decimal(5)
                    menu.Name = "小米粥"
                    ' menu.Tags = 

                End Function

                Public Function Create()

                End Function

            End Class



        End Namespace

    End Namespace
End Namespace

