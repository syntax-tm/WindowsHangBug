Imports System.Threading

Namespace Forms

    Public Class frmChildForm
        
        Public ReadOnly CurrentThread As Thread = Thread.CurrentThread
        Public ReadOnly CurrentThreadName As String = $"{CurrentThread.Name} ({CurrentThread.ManagedThreadId})"

        Sub New()
            InitializeComponent()

            UpdateTitle()
        End Sub
        
        Private Sub UpdateTitle()

            Dim newTitle = $"{NameOf(frmChildForm)} | {CurrentThreadName}"
            If Parent IsNot Nothing Then
                newTitle = newTitle + $"| {Parent.Handle}"
            End If
            Text = newTitle

        End Sub

        Private Sub frmChildForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtThreadName.Text = CurrentThreadName
            txtDPI.Text = DeviceDpi.ToString()
            txtFormName.Text = Name
            txtFormHandle.Text = Handle.ToString()
            chkHasParent.Checked = (Parent IsNot Nothing)
            txtParentHandle.Text = IIf(Parent Is Nothing, String.Empty, Parent.Handle.ToString())
            txtFormType.Text = [GetType].FullName
        End Sub

        Private Sub btnOpenForm_Click(sender As Object, e As EventArgs) Handles btnOpenForm.Click

            Dim frm As New frmDialogTest
            frm.Show(Parent)

        End Sub

        Private Sub btnOpenModal_Click(sender As Object, e As EventArgs) Handles btnOpenModal.Click

            Dim frm As New frmDialogTest
            frm.ShowDialog(Parent)

        End Sub

        Private Sub frmChildForm_ParentChanged(sender As Object, e As EventArgs) Handles MyBase.ParentChanged
            If Parent IsNot Nothing Then
                txtParentHandle.ForeColor = Color.Red
                UpdateTitle()
            End If
        End Sub
    End Class
End NameSpace