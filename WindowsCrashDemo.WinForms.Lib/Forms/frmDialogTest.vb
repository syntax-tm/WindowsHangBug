Imports System.Threading

Namespace Forms

    Public Class frmDialogTest

        Private formName As String = "Dialog Test"

        Public ReadOnly CurrentThread As Thread = Thread.CurrentThread
        Public ReadOnly CurrentThreadName As String = $"{CurrentThread.Name} ({CurrentThread.ManagedThreadId})"

        Sub New()

            InitializeComponent()

            UpdateTitle()

        End Sub

        Private Sub chkShowThread_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowThread.CheckedChanged

            UpdateTitle()

        End Sub

        Private Sub UpdateTitle()

            Dim showThread = chkShowThread.Checked
            If showThread
                Me.Text = $"{formName} | {CurrentThreadName}"
            Else
                Me.Text = formName
            End If

        End Sub

        Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
            Close()
        End Sub

        Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
            Close()
        End Sub

    End Class
End NameSpace