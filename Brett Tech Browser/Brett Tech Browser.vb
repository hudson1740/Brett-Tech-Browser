Public Class Form1
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate(ComboBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoForward()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WebBrowser1.GoForward()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoHome()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In My.Settings.Bookmarks
            ComboBox1.Items.Add(item)
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        My.Settings.Bookmarks.Add(WebBrowser1.Url.ToString)
        ComboBox1.Items.Add(WebBrowser1.Url.ToString)
        Bookmarks.ListBox1.Items.Add(WebBrowser1.Url.ToString)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Bookmarks.Visible = True
    End Sub

    Private Sub BookmarkToolStripMenuItem_Click(sender As Object, e As EventArgs)
        My.Settings.Bookmarks.Add(WebBrowser1.Url.ToString)
        ComboBox1.Items.Add(WebBrowser1.Url.ToString)
        Bookmarks.ListBox1.Items.Add(WebBrowser1.Url.ToString)
    End Sub

    Private Sub BookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarksToolStripMenuItem.Click
        Bookmarks.Visible = True

    End Sub

    Private Sub BookmarksToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BookmarksToolStripMenuItem2.Click
        Bookmarks.Visible = True
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub CreditsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem.Click
        MsgBox("        Created By Brett Hudson
          Brett Tech Networking
          Brett-TechRepair.Com", MsgBoxStyle.Information, Title:="Credits")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

        Timer1.Start()
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        ProgressBar1.Visible = True
        With ProgressBar1
            .Minimum = 0
            .Maximum = 50
            .Step = 5
        End With
        For index As Integer = 0 To 50 Step 5
            ProgressBar1.Value = index
            System.Threading.Thread.Sleep(35)
        Next
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem1.Click

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub NormalSizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalSizeToolStripMenuItem.Click
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem.Click
        MsgBox("This Feature Is Currently Unavalible, No History Is Recorded", MsgBoxStyle.Critical, Title:="Feature Unavalible")
    End Sub
End Class
