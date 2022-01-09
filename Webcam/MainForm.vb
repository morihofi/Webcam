Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.TopLevel = False
        Me.Panel2.Controls.Add(Form1)
        Form1.Show()
    End Sub
End Class