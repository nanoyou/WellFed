Imports Microsoft.VisualBasic
Imports System.Collections.Generic

Public Class MenuItem

    ' 菜单项的ID
    Private _id As UInteger

    Public Property Id As UInteger
        Set(ByVal value As UInteger)
            _id = value
        End Set
        Get
            Return _id;
        End Get
    End Property

    ' 菜单项的名称
    Private _name As String

    Public Property Name As String
        Set(ByVal value As String)
            _name = value
        End Set
        Get
            Return _name
        End Get
    End Property

    ' 菜单项的价格
    Private _price As Decimal

    Public Property Price As Decimal
        Set(ByVal value As Decimal)
            _price = value
        End Set
        Get
            Return _price
        End Get
    End Property

    Private _tags As New List(Of Tag)

    Public Property Tags As New List(Of Tag)
        Get
            Return _tags
        End Get
    End Property


End Class

Public Class Tag
    Private id As UInteger
    Private Name As String
    Private ParentTag As Tag
End Class

Public Class Member
    Private id As UInteger
    Private telephone As String
    Private salt As String
    Private passWord As String
End Class