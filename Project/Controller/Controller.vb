
Imports WellFed.AkagawaTsurunaki.WellFed.Controller
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Controller
            Public Class Controller

                Private Shared ReadOnly Property LOGIN_CONTROLLER = LoginController.Instance

                Public Shared ReadOnly Property INSTANCE As Controller = New Controller()

                Public Function Init()
                    Service.MemberService.Instance.Init()
                    Service.TagService.Instance.Init()
                    Service.MenuService.Instance.Init()
                End Function

            End Class
        End Namespace
    End Namespace
End Namespace

