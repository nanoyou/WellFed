Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase
Imports WellFed.AkagawaTsurunaki.WellFed.Mapper
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Mapper
            Public Class OrderMapper : Inherits Mapper.Mapper(Of Entity.Order)
                Public Shared ReadOnly Property INSTANCE As OrderMapper = New OrderMapper()

                ''' <summary>
                ''' 私有的构造器
                ''' </summary>
                Private Sub New()

                End Sub


            End Class
        End Namespace
    End Namespace
End Namespace


