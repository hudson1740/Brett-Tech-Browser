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

    Private Sub BookmarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookmarkToolStripMenuItem.Click
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
End Class
