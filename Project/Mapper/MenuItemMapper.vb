
Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Mapper
            Public Class MenuItemMapper

                Public Shared ReadOnly Property Instance As MenuItemMapper = New MenuItemMapper()
                Private Shared Property menuItemTable As Table(Of Entity.MenuItem)
                Public Sub InsertMember(ByRef menuItem As Entity.MenuItem)
                    menuItemTable.Insert(menuItem)
                End Sub
                Public Sub Init()
                    menuItemTable = Table(Of Entity.MenuItem).Create("menu_item_table")
                End Sub

                Public Sub Print()
                    menuItemTable.Print()
                End Sub
            End Class

        End Namespace
    End Namespace
End Namespace
