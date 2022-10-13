
Imports WellFed.AkagawaTsurunaki.WellFed.Controller
Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Controller
            Public Class Controller

                Private Shared ReadOnly Property LOGIN_CONTROLLER = LoginController.INSTANCE

                Public Shared ReadOnly Property INSTANCE As Controller = New Controller()

                Public Function Init()
                    Service.MemberService.INSTANCE.Init()
                    Service.TagService.Instance.Init()
                    Service.MenuService.Instance.Init()
                End Function

            End Class
        End Namespace
    End Namespace
End Namespace

