Imports WellFed.AkagawaTsurunaki.WellFed
Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces
Imports WellFed.AkagawaTsurunaki.WellFed.WellDataBase

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Service
            Public Class MemberService : Implements Interfaces.PreGenerator
                Public Shared ReadOnly Property Instance As MemberService = New MemberService()

                Public Sub Init()
                    Mapper.MemberMapper.Instance.Init()
                    PreGenerate()
                End Sub

                Private Sub New()

                End Sub

                Private Sub PreGenerate() Implements PreGenerator.PreGenerate
                    For counter = 1 To 20
                        Dim m = New Entity.Member()
                        m.Telephone = CStr(Rnd() * 10000000000)
                        m.Balance = New Decimal(Rnd() * 100)
                        m.PassWord = "psw" + CStr(Rnd() * 1000000000000)
                        Mapper.MemberMapper.Instance.AddMember(m)
                    Next
                    Mapper.MemberMapper.Instance.Print()
                End Sub
            End Class
        End Namespace
    End Namespace
End Namespace

