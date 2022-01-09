Imports MadMilkman.Ini

Public Class Form1
    'Webcam
    Public Touchless As New TouchlessLib.TouchlessMgr
    Public Camera1 As TouchlessLib.Camera
    Public CameraIndex As Integer
    Public FotoName As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)


        If Touchless.Cameras.Count = 1 Then
            Camera1 = Touchless.Cameras.ElementAt(0)
            ComboBoxItem1.Text = Touchless.Cameras.ElementAt(0).ToString
        End If


        GetCameras()


        Touchless.CurrentCamera = Nothing




    End Sub

    Sub GetCameras()
        ComboBoxItem1.Items.Clear()
        For Each cam In Touchless.Cameras
            ComboBoxItem1.Items.Add(cam)
        Next
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ImgPanel.BackgroundImage = Touchless.CurrentCamera.GetCurrentImage
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim wdth As String
        wdth = "-" & Me.ContextMenuStrip1.Width
        Me.ContextMenuStrip1.Show(Me.PictureBox2, New Point(wdth + PictureBox2.Width, PictureBox2.Height))
    End Sub

    Function LoadImgFormUrl(ByVal url As String) As Bitmap
        Dim wreq As System.Net.HttpWebRequest = System.Net.WebRequest.Create(url)
        Dim wres As System.Net.HttpWebResponse = wreq.GetResponse
        Return System.Drawing.Image.FromStream(wres.GetResponseStream)
    End Function

    Private Sub ComboBoxItem1_Click(sender As Object, e As EventArgs) Handles ComboBoxItem1.Click
        Try
            Timer1.Enabled = False

            Touchless.CurrentCamera = Nothing

            Camera1 = Touchless.Cameras.ElementAt(ComboBoxItem1.SelectedIndex)

            Touchless.CurrentCamera = Camera1
            Touchless.CurrentCamera.CaptureHeight = 480
            Touchless.CurrentCamera.CaptureWidth = 640
            Timer1.Enabled = True
        Catch ex As Exception
            MsgBox("Beim wechseln der Webcam ist ein Fehler aufgetreten: " & ex.Message, vbCritical, "morihofiWebcam")
        End Try

    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        Try
            Dim Fotoname As String
            Dim b As Bitmap
            b = ImgPanel.BackgroundImage
            Fotoname = InputBox("Bitte geben Sie einem Fotonamen ein:")
            b.Save(TextBox1.Text & "\" & Fotoname & ".png")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Fehler")
        End Try

    End Sub

    Private Sub ButtonItem2_Click(sender As Object, e As EventArgs) Handles ButtonItem2.Click
        GetCameras()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
        Dim Fotoname As String
        Dim b As Bitmap
        b = ImgPanel.BackgroundImage
        Fotoname = Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "_" & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second
        b.Save(TextBox1.Text & "\" & Fotoname & ".png")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'My.Computer.Network.DownloadFile("ftp://www8.subdomain.com/Dateiname+Endung", "Speicherort", "Username", "Passwort")
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try


            Dim Fotoname As String
            Dim b As Bitmap
            b = ImgPanel.BackgroundImage
            Fotoname = Date.Now.Year & "-" & Date.Now.Month & "-" & Date.Now.Day & "_" & Date.Now.Hour & "-" & Date.Now.Minute & "-" & Date.Now.Second
            b.Save(TextBox1.Text & "\" & Fotoname & ".png")
            My.Computer.Audio.Play(My.Resources.camera, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox(ex.Message, vbOK + vbCritical, "Fehler")
        End Try
    End Sub
End Class
