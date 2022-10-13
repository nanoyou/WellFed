Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Mapper
            Public Class MemberMapper : Inherits Mapper.Mapper(Of Entity.Member)


                Public Shared ReadOnly Property Instance As MemberMapper = New MemberMapper()
                Private Shared Property table As Table(Of Entity.Member)

                Private Sub New()

                End Sub

                ''' <summary>
                ''' 根据手机号查询会员
                ''' </summary>
                ''' <param name="telephone"></param>
                ''' <returns></returns>
                Public Function SelectMemberByTelephone(ByVal telephone As String) As Entity.Member
                    If telephone IsNot Nothing Then
                        For Each member In table.RecordList
                            If member.Telephone = telephone Then
                                Return member
                            End If
                        Next
                    End If
                    Return Nothing
                End Function


            End Class
        End Namespace
    End Namespace

End Namespace

