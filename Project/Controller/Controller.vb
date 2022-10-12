
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Controller
            Public Class Controller
                Private Shared Property loginedMember As Entity.Member

                Public Shared ReadOnly Property Instance = New Controller()

                Public Function Init()
                    Service.MemberService.Instance.Init()
                    Service.TagService.Instance.Init()
                    Service.MenuService.Instance.Init()
                End Function


                Public Function Login(ByVal telephone As String, ByVal rawPassword As String)
                    ' md5 加密如果可能
                    Dim md5Password = rawPassword
                    Service.MemberService.Instance.Login(telephone, md5Password)
                End Function

            End Class
        End Namespace
    End Namespace
End Namespace

