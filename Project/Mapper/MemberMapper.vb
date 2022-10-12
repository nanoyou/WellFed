Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Mapper
            Public Class MemberMapper

                Public Shared ReadOnly Property Instance As MemberMapper = New MemberMapper()
                Private Shared Property memberTable As Table(Of Entity.Member)

                ''' <summary>
                ''' 初始化MemberMapper, 这是必要的
                ''' </summary>
                Public Sub Init()
                    memberTable = Table(Of Entity.Member).Create("member_table")
                End Sub

                Public Sub AddMember(ByRef member As Entity.Member)
                    memberTable.Insert(member)
                End Sub

                Public Sub AddMember(ByRef members As List(Of Entity.Member))
                    For Each member In members
                        memberTable.Insert(member)
                    Next
                End Sub

                Private Sub New()

                End Sub

                ' 只是测试
                Public Sub Print()
                    memberTable.Print()
                End Sub


                ''' <summary>
                ''' 根据手机号查询会员
                ''' </summary>
                ''' <param name="telephone"></param>
                ''' <returns></returns>
                Public Function FindMemberByTelephone(ByVal telephone As String) As Entity.Member
                    If telephone IsNot Nothing Then
                        For Each member In memberTable.RecordList
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

