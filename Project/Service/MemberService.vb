﻿Imports WellFed.AkagawaTsurunaki.WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Service
            Public Class MemberService : Implements Interfaces.PreGenerator
                Public Shared ReadOnly Property Instance As MemberService = New MemberService()

                Public Shared Property MemberLogined As Entity.Member

                Public Sub Init()
                    Mapper.MemberMapper.Instance.Init()
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
                    Dim member = Mapper.MemberMapper.Instance.FindMemberByTelephone(telephone)
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
                        m.Telephone = CStr(Rnd() * 10000) + CStr(Rnd() * 100000)
                        m.Balance = New Decimal(Rnd() * 100)
                        m.PassWord = CStr(Rnd() * 1000000)
                        Mapper.MemberMapper.Instance.InsertMember(m)
                    Next
                    Mapper.MemberMapper.Instance.Print()
                End Sub
            End Class
        End Namespace
    End Namespace
End Namespace

