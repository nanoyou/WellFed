
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Controller
            Public Class Controller


                Public Shared ReadOnly Property Instance = New AkagawaTsurunaki.WellFed.Controller.Controller

                Public Function Init()
                    Service.MemberService.Instance.Init()
                    Service.TagService.Instance.Init()
                    Service.MenuService.Instance.Init()
                End Function


                Public Function Login(ByVal telephone As String, ByVal rawPassword As String) As Boolean

                    If telephone Is Nothing Or telephone Is "" Or (Not telephone.Length = 11) Then
                        MessageBox.Show("必须填写长度为11位的手机号。", "参数不足", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                    If rawPassword Is Nothing Or rawPassword Is "" Or (Not rawPassword.Length = 6) Then
                        MessageBox.Show("必须填写完整的6位密码。", "参数不足", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If

                    ' md5 加密如果可能
                    Dim md5Password = rawPassword
                    If Not Service.MemberService.Instance.Login(telephone, md5Password) Then
                        MessageBox.Show("请检查您的手机号和密码是否正确。", "无法登录", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If

                    Return True
                End Function

                Public Function Rediret(ByVal path As String)
                    ' 重定向到登陆界面
                    Select Case path
                        Case "/login"
                            LoginForm.Show()
                        Case "/logout"

                        Case "/"

                    End Select


                End Function

            End Class
        End Namespace
    End Namespace
End Namespace

