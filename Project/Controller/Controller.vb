
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Controller
            Public Class Controller

                Public Shared ReadOnly Property Instance = New Controller()

                Public Function Init()
                    Service.MemberService.Instance.Init()
                    Service.TagService.Instance.Init()
                    Service.MenuService.Instance.Init()
                End Function
            End Class
        End Namespace
    End Namespace
End Namespace

