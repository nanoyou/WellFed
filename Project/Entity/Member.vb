Imports WellFed.AkagawaTsurunaki.WellFed.Interfaces

Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Entity
            Public Class Member : Implements IHasPrimaryKey
                ' 会员的电话(会员号)
                Public Property Telephone As String
                ' 会员的密码盐
                Public Property Salt As String
                Public Property PassWord As String
                ' 会员的余额
                Public Property Balance As Decimal
                ' 会员的ID
                Private Property memberId As UInteger
                Public Property Id As UInteger Implements IHasPrimaryKey.PrimaryKey
                    Get
                        Return memberId
                    End Get
                    Set(value As UInteger)
                        memberId = value
                    End Set
                End Property

                ' 构造器
                Public Sub New()
                End Sub

                ''' <summary>
                ''' 会员付款, 如果余额不足返回False
                ''' </summary>
                ''' <param name="money">正数</param>
                ''' <returns></returns>
                Public Function Pay(ByVal money As Decimal) As Boolean
                    If money < 0 Then
                        Throw New ArgumentException("应为正数")
                    End If
                    If money > Balance Then
                        Return False
                    End If
                    Balance -= money
                    Return True
                End Function

                ''' <summary>
                ''' 返回实体的字段信息
                ''' </summary>
                ''' <returns></returns>
                Public Overrides Function ToString() As String
                    Return $"会员ID: {Id}, 电话号码: {Telephone}, 余额: {Balance}, 密码: {PassWord}, 盐: {Salt}"
                End Function

            End Class

        End Namespace

    End Namespace
End Namespace

