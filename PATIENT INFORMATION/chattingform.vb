Imports System.IO
Imports System.Net.Sockets
Imports System.DirectoryServices
Imports System.Net
Imports System.Net.IPHostEntry
Public Class chattingform
    Dim listerner As New TcpListener(44444)
    Dim client As TcpClient
    Dim message As String = ""
    Dim tts


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If listerner.Pending = True Then
            message = ""
            client = listerner.AcceptTcpClient
            Dim reader As New StreamReader(client.GetStream())
            While reader.Peek > -1
                message = message + Convert.ToChar(reader.Read()).ToString
            End While
            Me.Focus()
            message = (message)
            RichTextBox2.Text = RichTextBox2.Text + message + vbCrLf
            notification.Text = "You have a Private Message"
        ElseIf Form6.IsHandleCreated Then
            Form6.notification6.Text = notification.Text
        ElseIf Form3.IsHandleCreated Then
            Form3.notification3.Text = notification.Text
            Form2.notification2.Text = notification.Text
        ElseIf GUESTMODE.IsHandleCreated Then
            GUESTMODE.guestnotif.Text = notification.Text

            guest_view.Viewg.Text = notification.Text
       
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub networkCreator()
        RichTextBox2.Text = RichTextBox1.Text
        If Form1.IsHandleCreated Then
            TextBox1.Text = Form1.LOGINTextBox.Text
        ElseIf Form8.IsHandleCreated Then
            TextBox1.Text = Form8.LOGINTextBox.Text
        End If

        Dim childEntry As DirectoryEntry
        Dim ParentEntry As New DirectoryEntry()
        Try
            ParentEntry.Path = "WinNT:"
            For Each childEntry In ParentEntry.Children
                Dim newNode As New TreeNode(childEntry.Name)
                Select Case childEntry.SchemaClassName
                    Case "Domain"
                        Dim ParentDomain As New TreeNode(childEntry.Name)
                        TreeView1.Nodes.AddRange(New TreeNode() {ParentDomain})
                        Dim SubChildEntry As DirectoryEntry
                        Dim SubParentEntry As New DirectoryEntry()
                        SubParentEntry.Path = "WinNT://" & childEntry.Name
                        For Each SubChildEntry In SubParentEntry.Children
                            Dim newNode1 As New TreeNode(SubChildEntry.Name)
                            Select Case SubChildEntry.SchemaClassName
                                Case "Computer"
                                    ParentDomain.Nodes.Add(newNode1)
                            End Select
                        Next
                End Select
            Next
        Catch Excep As Exception
            MsgBox("Error While Reading Directories")
        Finally
            ParentEntry = Nothing
        End Try
        listerner.Start()
        Timer1.Enabled = True
        Timer1.Start()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        listerner.Stop()
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        TextBox2.Text = GetIPAddress(TreeView1.SelectedNode.Text.ToString)
    End Sub

    Function GetIPAddress(ByVal CompName As String) As String

        Dim oAddr As System.Net.IPAddress
        Dim sAddr As String
        Try
            With System.Net.Dns.Resolve(CompName)
                oAddr = New System.Net.IPAddress(.AddressList(0).Address)
                sAddr = oAddr.ToString
            End With
            GetIPAddress = sAddr
        Catch Excep As Exception
            MsgBox(Excep.Message, MsgBoxStyle.OkOnly, "CHATTING")
        Finally

        End Try
    End Function

    Private Sub RichTextBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.Insert Then
            RichTextBox1.Text = TextBox1.Text + " Chat you : " + RichTextBox1.Text
            RichTextBox1.Text = (RichTextBox1.Text)
            Timer2.Start()
        End If
    End Sub

    Dim ChkXOR As New CheckBox

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        client = New TcpClient(TextBox2.Text, 44444)
        Dim writer As New StreamWriter(client.GetStream())
        writer.Write(RichTextBox1.Text)

        writer.Flush()
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If TextBox2.Text = "" Then
            MessageBox.Show("please choose A Hostname into WorkGroup ", "NetowrkListener")
        Else
            MessageBox.Show("Successfully Send ", "NetworkListener")
            RichTextBox1.Text = TextBox1.Text + "  Chat you : " + RichTextBox1.Text
            RichTextBox1.Text = (RichTextBox1.Text)
            Timer2.Start()
        End If
    End Sub
    Public Sub FEEDBACK()

    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        notification.Text = ""
        If Form6.IsHandleCreated Then
            Form6.notification6.Text = ""
        ElseIf Form3.IsHandleCreated Then
            Form3.notification3.Text = ""
        ElseIf Form2.IsHandleCreated Then
            Form2.notification2.Text = ""
        ElseIf guest_view.IsHandleCreated Then
            guest_view.Viewg.Text = ""
        ElseIf GUESTMODE.IsHandleCreated Then
            GUESTMODE.guestnotif.Text = ""
        End If
        Me.Hide()
    End Sub

    Private Sub RichTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox2.Clear()
    End Sub
End Class
