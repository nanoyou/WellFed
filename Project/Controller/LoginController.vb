Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Controller
            Public Class LoginController

                Public Shared ReadOnly Property INSTANCE As LoginController = New LoginController()
                Private Shared Property telephone As String
                Private Shared ReadOnly Property MEMBER_SERVICE As Service.MemberService = Service.MemberService.INSTANCE
                Private Shared Property rawPassword As String

                Public Function InputTelephone(ByVal tel As String) As Boolean
                    If tel Is Nothing Or tel Is "" Or (Not tel.Length = 11) Then
                        MessageBox.Show("必须填写长度为11位的手机号。", "参数不足", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                    If MEMBER_SERVICE.FindMemberByTelephone(tel) IsNot Nothing Then
                        telephone = tel
                        Return True
                    End If
                    MessageBox.Show("这个用户不存在。请检查您的手机号是否有误，若确认无误后仍出现此问题，请咨询柜台人员。", "找不到用户", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End Function

                Public Function InputPassword(ByVal rpsw As String) As Boolean
                    If rpsw Is Nothing Or rpsw Is "" Or (Not rpsw.Length = 6) Then
                        rawPassword = ""
                        Return False
                    End If
                    rawPassword = rpsw
                    Return True
                End Function

                Public Function Login() As Boolean
                    If Not MEMBER_SERVICE.Login(telephone, rawPassword) Then
                        rawPassword = ""
                        Return False
                    End If
                    MessageBox.Show("登录成功！准备下单！", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return True
                End Function


                Public Enum WindowType
                    Telephone
                    Password
                End Enum

                Public Function Show(wt As WindowType)
                    Select Case wt
                        Case WindowType.Telephone
                            TelephoneForm.Show()
                        Case WindowType.Password
                            PasswordForm.Show()
                    End Select
                End Function

            End Class
        End Namespace
    End Namespace

End Namespace


