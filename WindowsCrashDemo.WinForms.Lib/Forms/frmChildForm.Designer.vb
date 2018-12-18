Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmChildForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnOpenModal = New System.Windows.Forms.Button()
        Me.btnOpenForm = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtFormName = New System.Windows.Forms.TextBox()
        Me.txtFormHandle = New System.Windows.Forms.TextBox()
        Me.txtThreadName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDPI = New System.Windows.Forms.TextBox()
        Me.txtParentHandle = New System.Windows.Forms.TextBox()
        Me.txtFormType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkHasParent = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout
        Me.TableLayoutPanel2.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.TableLayoutPanel1.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 426)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Child Forms"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnOpenModal, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnOpenForm, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(254, 407)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btnOpenModal
        '
        Me.btnOpenModal.Location = New System.Drawing.Point(130, 3)
        Me.btnOpenModal.Name = "btnOpenModal"
        Me.btnOpenModal.Size = New System.Drawing.Size(111, 23)
        Me.btnOpenModal.TabIndex = 0
        Me.btnOpenModal.Text = "ShowDialog Form"
        Me.btnOpenModal.UseVisualStyleBackColor = true
        '
        'btnOpenForm
        '
        Me.btnOpenForm.Location = New System.Drawing.Point(3, 3)
        Me.btnOpenForm.Name = "btnOpenForm"
        Me.btnOpenForm.Size = New System.Drawing.Size(107, 23)
        Me.btnOpenForm.TabIndex = 1
        Me.btnOpenForm.Text = "Show Form"
        Me.btnOpenForm.UseVisualStyleBackColor = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 426)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Info"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtFormName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFormHandle, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtThreadName, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtDPI, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.txtParentHandle, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtFormType, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkHasParent, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(504, 407)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtFormName
        '
        Me.txtFormName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtFormName.Location = New System.Drawing.Point(92, 3)
        Me.txtFormName.Name = "txtFormName"
        Me.txtFormName.ReadOnly = true
        Me.txtFormName.Size = New System.Drawing.Size(240, 20)
        Me.txtFormName.TabIndex = 0
        '
        'txtFormHandle
        '
        Me.txtFormHandle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtFormHandle.Location = New System.Drawing.Point(92, 30)
        Me.txtFormHandle.Name = "txtFormHandle"
        Me.txtFormHandle.ReadOnly = true
        Me.txtFormHandle.Size = New System.Drawing.Size(240, 20)
        Me.txtFormHandle.TabIndex = 1
        '
        'txtThreadName
        '
        Me.txtThreadName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtThreadName.Location = New System.Drawing.Point(92, 84)
        Me.txtThreadName.Name = "txtThreadName"
        Me.txtThreadName.ReadOnly = true
        Me.txtThreadName.Size = New System.Drawing.Size(240, 20)
        Me.txtThreadName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(7, 142)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "DPI"
        '
        'txtDPI
        '
        Me.txtDPI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtDPI.Location = New System.Drawing.Point(92, 138)
        Me.txtDPI.Name = "txtDPI"
        Me.txtDPI.ReadOnly = true
        Me.txtDPI.Size = New System.Drawing.Size(240, 20)
        Me.txtDPI.TabIndex = 12
        '
        'txtParentHandle
        '
        Me.txtParentHandle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtParentHandle.Location = New System.Drawing.Point(92, 57)
        Me.txtParentHandle.Name = "txtParentHandle"
        Me.txtParentHandle.ReadOnly = true
        Me.txtParentHandle.Size = New System.Drawing.Size(240, 20)
        Me.txtParentHandle.TabIndex = 5
        '
        'txtFormType
        '
        Me.txtFormType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtFormType.Location = New System.Drawing.Point(92, 111)
        Me.txtFormType.Name = "txtFormType"
        Me.txtFormType.ReadOnly = true
        Me.txtFormType.Size = New System.Drawing.Size(240, 20)
        Me.txtFormType.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(7, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Form Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(7, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Thread Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(7, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Form Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(7, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Parent Handle"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(7, 34)
        Me.Label6.Margin = New System.Windows.Forms.Padding(7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Form Handle"
        '
        'chkHasParent
        '
        Me.chkHasParent.AutoSize = true
        Me.chkHasParent.Enabled = false
        Me.chkHasParent.Location = New System.Drawing.Point(350, 59)
        Me.chkHasParent.Margin = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.chkHasParent.Name = "chkHasParent"
        Me.chkHasParent.Size = New System.Drawing.Size(116, 17)
        Me.chkHasParent.TabIndex = 14
        Me.chkHasParent.Text = "Has Parent Handle"
        Me.chkHasParent.UseVisualStyleBackColor = true
        '
        'frmChildForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmChildForm"
        Me.Text = "frmChildForm"
        Me.GroupBox1.ResumeLayout(false)
        Me.TableLayoutPanel2.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

        Friend WithEvents GroupBox1 As GroupBox
        Friend WithEvents btnOpenForm As Button
        Friend WithEvents btnOpenModal As Button
        Friend WithEvents GroupBox2 As GroupBox
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents txtFormName As TextBox
        Friend WithEvents txtFormHandle As TextBox
        Friend WithEvents txtThreadName As TextBox
        Friend WithEvents Label4 As Label
        Friend WithEvents txtDPI As TextBox
        Friend WithEvents txtParentHandle As TextBox
        Friend WithEvents txtFormType As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents chkHasParent As CheckBox
    End Class
End NameSpace