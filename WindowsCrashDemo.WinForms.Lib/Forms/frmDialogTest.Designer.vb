Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmDialogTest
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDialogTest))
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.chkShowThread = New System.Windows.Forms.CheckBox()
        Me.gbInfo.SuspendLayout
        Me.SuspendLayout
        '
        'btnOK
        '
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(316, 156)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = true
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(235, 156)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.TextBox1)
        Me.gbInfo.Location = New System.Drawing.Point(12, 12)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbInfo.Size = New System.Drawing.Size(379, 138)
        Me.gbInfo.TabIndex = 5
        Me.gbInfo.TabStop = false
        Me.gbInfo.Text = "Info"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(3, 16)
        Me.TextBox1.Multiline = true
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = true
        Me.TextBox1.Size = New System.Drawing.Size(373, 119)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkShowThread
        '
        Me.chkShowThread.AutoSize = true
        Me.chkShowThread.Checked = true
        Me.chkShowThread.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowThread.Location = New System.Drawing.Point(12, 160)
        Me.chkShowThread.Name = "chkShowThread"
        Me.chkShowThread.Size = New System.Drawing.Size(90, 17)
        Me.chkShowThread.TabIndex = 6
        Me.chkShowThread.Text = "Show Thread"
        Me.chkShowThread.UseVisualStyleBackColor = true
        '
        'frmDialogTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 191)
        Me.Controls.Add(Me.chkShowThread)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDialogTest"
        Me.ShowIcon = false
        Me.Text = "C-C-C-C-CRASH!"
        Me.gbInfo.ResumeLayout(false)
        Me.gbInfo.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

        Friend WithEvents btnOK As Button
        Friend WithEvents btnCancel As Button
        Friend WithEvents gbInfo As GroupBox
        Friend WithEvents TextBox1 As TextBox
        Friend WithEvents chkShowThread As CheckBox
    End Class
End NameSpace