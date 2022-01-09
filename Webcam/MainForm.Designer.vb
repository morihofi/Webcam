<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImageButton2 = New Andy.UI.ImageButton()
        Me.ImageButton1 = New Andy.UI.ImageButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Webcam.My.Resources.Resources.toolbar_background2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.ImageButton2)
        Me.Panel1.Controls.Add(Me.ImageButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 38)
        Me.Panel1.TabIndex = 0
        '
        'ImageButton2
        '
        Me.ImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.ImageButton2.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImageButton2.DisabledImage = CType(resources.GetObject("ImageButton2.DisabledImage"), System.Drawing.Image)
        Me.ImageButton2.Dock = System.Windows.Forms.DockStyle.Left
        Me.ImageButton2.HoverImage = CType(resources.GetObject("ImageButton2.HoverImage"), System.Drawing.Image)
        Me.ImageButton2.Location = New System.Drawing.Point(26, 0)
        Me.ImageButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.ImageButton2.Name = "ImageButton2"
        Me.ImageButton2.NormalImage = CType(resources.GetObject("ImageButton2.NormalImage"), System.Drawing.Image)
        Me.ImageButton2.PushedImage = CType(resources.GetObject("ImageButton2.PushedImage"), System.Drawing.Image)
        Me.ImageButton2.Size = New System.Drawing.Size(26, 38)
        Me.ImageButton2.TabIndex = 3
        Me.ImageButton2.Text = "ImageButton2"
        '
        'ImageButton1
        '
        Me.ImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.ImageButton1.Cursor = System.Windows.Forms.Cursors.Default
        Me.ImageButton1.DisabledImage = CType(resources.GetObject("ImageButton1.DisabledImage"), System.Drawing.Image)
        Me.ImageButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ImageButton1.HoverImage = CType(resources.GetObject("ImageButton1.HoverImage"), System.Drawing.Image)
        Me.ImageButton1.Location = New System.Drawing.Point(0, 0)
        Me.ImageButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.ImageButton1.Name = "ImageButton1"
        Me.ImageButton1.NormalImage = CType(resources.GetObject("ImageButton1.NormalImage"), System.Drawing.Image)
        Me.ImageButton1.PushedImage = CType(resources.GetObject("ImageButton1.PushedImage"), System.Drawing.Image)
        Me.ImageButton1.Size = New System.Drawing.Size(26, 38)
        Me.ImageButton1.TabIndex = 2
        Me.ImageButton1.Text = "ImageButton1"
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(1, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(546, 366)
        Me.Panel2.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 405)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImageButton2 As Andy.UI.ImageButton
    Friend WithEvents ImageButton1 As Andy.UI.ImageButton
    Friend WithEvents Panel2 As Panel
End Class
