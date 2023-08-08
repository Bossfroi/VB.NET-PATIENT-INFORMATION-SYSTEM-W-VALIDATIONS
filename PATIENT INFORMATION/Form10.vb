Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec
Imports Bytescout.BarCodeReader
Public Class Form10
    WithEvents mywebcam As WebCamCapture
    Dim reader As QRCodeDecoder

    Public Touchless As New TouchlessLib.TouchlessMgr
    Public Camera1 As TouchlessLib.Camera = Touchless.Cameras.ElementAt(0)

    Public Sub detector()

        Try
            reader = New QRCodeDecoder()
            TextBox1.Text = reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MetroFramework.MetroMessageBox.Show(Me, "WAIT FOR A SECOND TO IDENTIFY THIS QR CODE")

            Form5.Show()
            Form5.combosearch.Text = "VERIFICATIONQR"
            Form5.search1.Text = TextBox1.Text
            Form5.SEARCBTN.PerformClick()


        Catch ex As Exception
          
        End Try


    End Sub
    Private Sub startweb()
        Try
            
            mywebcam = New WebCamCapture
            mywebcam.Start(1)

        Catch ex As Exception

        End Try
    End Sub
    Private Sub stopweb()
        Try
           
            mywebcam.Stop()
            mywebcam.Dispose()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub mywebcam_ImageCaptured(ByVal source As Object, ByVal e As WebCam_Capture.WebcamEventArgs) Handles mywebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Me.stopweb()
        Catch ex As Exception

        End Try

        mywebcam.Enabled = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            reader = New QRCodeDecoder()
            TextBox1.Text = reader.decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MetroFramework.MetroMessageBox.Show(Me, "WAIT FOR A SECOND TO IDENTIFY THIS QR CODE")

            Form5.Show()
            Form5.combosearch.Text = "VERIFICATIONQR"
            Form5.search1.Text = TextBox1.Text
            Form5.SEARCBTN.PerformClick()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        cam()
    End Sub
    Private Sub cam()

        Touchless.CurrentCamera = Camera1
        Touchless.CurrentCamera.CaptureHeight = 1080
        Touchless.CurrentCamera.CaptureWidth = 720
        PictureBox1.Image = Touchless.CurrentCamera.GetCurrentImage
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            Dim open As New OpenFileDialog
            open.Filter = "image files (*.png)|*.png"

            open.ShowDialog()
            PictureBox1.Image = Image.FromFile(open.FileName)
            Try
                Dim sc As New Bitmap(PictureBox1.Image)
                reader = New QRCodeDecoder()
                Dim INT As String = reader.decode(New Data.QRCodeBitmapImage(New Bitmap(sc)))
                TextBox1.Text = INT
            Catch ex As Exception
            End Try
            MetroFramework.MetroMessageBox.Show(Me, "WAIT FOR A SECOND TO IDENTIFY THIS QR CODE")

            Form5.Show()
            Form5.combosearch.Text = "ID"
            Form5.SEARCH.Text = TextBox1.Text
            Form5.SEARCBTN.PerformClick()



        Catch ex As Exception
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        
    End Sub

    Private Sub CLOSEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.startweb()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.stopweb()
        Me.Close()
    End Sub
End Class