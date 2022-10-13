Imports WellFed.AkagawaTsurunaki.WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Service
            Public Class MemberService : Implements Interfaces.PreGenerator
                Public Shared ReadOnly Property INSTANCE As MemberService = New MemberService()

                Public Shared Property MemberLogined As Entity.Member

                Public Sub Init()
                    Mapper.MemberMapper.INSTANCE.Init("member_table")
                    PreGenerate()
                End Sub

                Private Sub New()

                End Sub
                ''' <summary>
                ''' 用户登陆
                ''' </summary>
                ''' <param name="telephone">会员手机号码</param>
                ''' <param name="md5Password">会员密码</param>
                ''' <returns>是否登陆成功</returns>
                Public Function Login(ByVal telephone As String, ByVal md5Password As String) As Boolean
                    Dim member = Mapper.MemberMapper.INSTANCE.SelectMemberByTelephone(telephone)
                    If member Is Nothing Then
                        Return False
                    End If
                    If member.PassWord = md5Password Then
                        MemberLogined = member
                        Return True
                    End If
                    Return False
                End Function

                Public Function Logout() As Boolean
                    MemberLogined = Nothing
                    Return True
                End Function

                Private Sub PreGenerate() Implements PreGenerator.PreGenerate
                    For counter = 1 To 20
                        Dim m = New Entity.Member()

                        m.Telephone = CLng((20000000000 - 10000000000 + 1) * Rnd() + 10000000000).ToString
                        m.Balance = New Decimal(Rnd() * 100)
                        m.PassWord = Int((999999 - 100000 + 1) * Rnd() + 100000).ToString
                        Mapper.MemberMapper.INSTANCE.Insert(m)
                    Next
                    Mapper.MemberMapper.INSTANCE.Print()
                End Sub

                Public Function GetMemberLogined() As Entity.Member
                    Return MemberLogined
                End Function

                Public Function FindMemberByTelephone(tel As String) As Entity.Member
                    Return Mapper.MemberMapper.INSTANCE.SelectMemberByTelephone(tel)
                End Function

            End Class
        End Namespace
    End Namespace
End Namespace

