Namespace AkagawaTsurunaki
    Namespace WellFed
        Namespace Util
            Public Class WellFedHelper

                ''' <summary>
                ''' 按照节点名称递归查询节点
                ''' </summary>
                ''' <param name="node"></param>
                ''' <param name="name"></param>
                ''' <returns></returns>
                Public Shared Function FindNode(ByRef node As TreeNode, name As String) As TreeNode
                    Dim ret As TreeNode = Nothing
                    For Each t As TreeNode In node.Nodes
                        If Not t.Nodes.Count = 0 Then
                            ret = FindNode(t, name)
                            If ret IsNot Nothing Then
                                Return ret
                            End If
                        End If
                        If t.Text = name Then
                            Return t
                        End If
                    Next
                    Return ret
                End Function

            End Class

        End Namespace
    End Namespace
End Namespace
