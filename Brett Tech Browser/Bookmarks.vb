Public Class Bookmarks
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In My.Settings.Bookmarks
            ListBox1.Items.Add(item)
        Next
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Bookmarks.Clear()
        ListBox1.Items.Clear()
        Form1.ComboBox1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Bookmarks.Remove(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        Form1.ComboBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.SelectedItem = False Then
            MsgBox("error")
        Else
            Form1.WebBrowser1.Navigate(ListBox1.SelectedItem)

        End If

    End Sub
End Class