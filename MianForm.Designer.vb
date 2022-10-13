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
        Me.components = New System.ComponentModel.Container()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbCost = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TreeViewMenu = New System.Windows.Forms.TreeView()
        Me.BtnSlct = New System.Windows.Forms.Button()
        Me.LVOrder = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TimerWait = New System.Windows.Forms.Timer(Me.components)
        Me.LbWaitTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnConfirm.Location = New System.Drawing.Point(54, 427)
        Me.BtnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(67, 71)
        Me.BtnConfirm.TabIndex = 6
        Me.BtnConfirm.Text = "我选好了"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("微软雅黑", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(621, 427)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(67, 71)
        Me.BtnClear.TabIndex = 7
        Me.BtnClear.Text = "重新选择"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 427)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "总价格为"
        '
        'LbCost
        '
        Me.LbCost.Font = New System.Drawing.Font("微软雅黑", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LbCost.Location = New System.Drawing.Point(260, 427)
        Me.LbCost.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbCost.Name = "LbCost"
        Me.LbCost.Size = New System.Drawing.Size(221, 50)
        Me.LbCost.TabIndex = 10
        Me.LbCost.Text = "0.0"
        Me.LbCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(485, 427)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 50)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "元"
        '
        'TreeViewMenu
        '
        Me.TreeViewMenu.Location = New System.Drawing.Point(60, 30)
        Me.TreeViewMenu.Name = "TreeViewMenu"
        Me.TreeViewMenu.Size = New System.Drawing.Size(275, 361)
        Me.TreeViewMenu.TabIndex = 16
        '
        'BtnSlct
        '
        Me.BtnSlct.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnSlct.Location = New System.Drawing.Point(348, 181)
        Me.BtnSlct.Name = "BtnSlct"
        Me.BtnSlct.Size = New System.Drawing.Size(66, 69)
        Me.BtnSlct.TabIndex = 17
        Me.BtnSlct.Text = "->"
        Me.BtnSlct.UseVisualStyleBackColor = True
        '
        'LVOrder
        '
        Me.LVOrder.AutoArrange = False
        Me.LVOrder.HideSelection = False
        Me.LVOrder.Location = New System.Drawing.Point(431, 30)
        Me.LVOrder.Name = "LVOrder"
        Me.LVOrder.Size = New System.Drawing.Size(257, 361)
        Me.LVOrder.TabIndex = 18
        Me.LVOrder.UseCompatibleStateImageBehavior = False
        Me.LVOrder.View = System.Windows.Forms.View.List
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 492)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "预计等待"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(485, 492)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 50)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "秒"
        '
        'TimerWait
        '
        Me.TimerWait.Interval = 1000
        '
        'LbWaitTime
        '
        Me.LbWaitTime.Font = New System.Drawing.Font("微软雅黑", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LbWaitTime.Location = New System.Drawing.Point(269, 492)
        Me.LbWaitTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LbWaitTime.Name = "LbWaitTime"
        Me.LbWaitTime.Size = New System.Drawing.Size(212, 50)
        Me.LbWaitTime.TabIndex = 20
        Me.LbWaitTime.Text = "--"
        Me.LbWaitTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 551)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LbWaitTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LVOrder)
        Me.Controls.Add(Me.BtnSlct)
        Me.Controls.Add(Me.TreeViewMenu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LbCost)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LbCost As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TreeViewMenu As TreeView
    Friend WithEvents BtnSlct As Button
    Friend WithEvents LVOrder As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TimerWait As Timer
    Friend WithEvents LbWaitTime As Label
End Class
