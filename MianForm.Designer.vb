<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ConfirmBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.MenuTreeView = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.Location = New System.Drawing.Point(214, 414)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.Size = New System.Drawing.Size(103, 24)
        Me.ConfirmBtn.TabIndex = 6
        Me.ConfirmBtn.Text = "选好了"
        Me.ConfirmBtn.UseVisualStyleBackColor = True
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(476, 414)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(103, 24)
        Me.ClearBtn.TabIndex = 7
        Me.ClearBtn.Text = "重新选择"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'MenuTreeView
        '
        Me.MenuTreeView.Location = New System.Drawing.Point(149, 67)
        Me.MenuTreeView.Name = "MenuTreeView"
        Me.MenuTreeView.Size = New System.Drawing.Size(494, 311)
        Me.MenuTreeView.TabIndex = 8
        '
        'MianForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuTreeView)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.Name = "MianForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConfirmBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents MenuTreeView As TreeView
End Class
