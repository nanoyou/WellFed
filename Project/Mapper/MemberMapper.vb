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



                Public Function FindMemberByTelephone() As Entity.Member

                End Function
            End Class
        End Namespace
    End Namespace

End Namespace

