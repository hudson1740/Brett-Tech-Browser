<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookmarksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookmarksToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookmarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.MenuStrip2)
        Me.Panel1.Location = New System.Drawing.Point(0, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1846, 36)
        Me.Panel1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.ForeColor = System.Drawing.Color.Navy
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(79, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(708, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "Enter URL"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Black
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.BookmarksToolStripMenuItem1, Me.PrintToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(1237, 12)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(141, 24)
        Me.MenuStrip2.TabIndex = 10
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.BackColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullScreenToolStripMenuItem, Me.NormalSizeToolStripMenuItem})
        Me.FileToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem1.Text = "Edit"
        '
        'FullScreenToolStripMenuItem
        '
        Me.FullScreenToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.FullScreenToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.FullScreenToolStripMenuItem.Name = "FullScreenToolStripMenuItem"
        Me.FullScreenToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.FullScreenToolStripMenuItem.Text = "Full Screen"
        '
        'NormalSizeToolStripMenuItem
        '
        Me.NormalSizeToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.NormalSizeToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.NormalSizeToolStripMenuItem.Name = "NormalSizeToolStripMenuItem"
        Me.NormalSizeToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.NormalSizeToolStripMenuItem.Text = "Normal Size"
        '
        'BookmarksToolStripMenuItem1
        '
        Me.BookmarksToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem, Me.BookmarksToolStripMenuItem2})
        Me.BookmarksToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BookmarksToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime
        Me.BookmarksToolStripMenuItem1.Name = "BookmarksToolStripMenuItem1"
        Me.BookmarksToolStripMenuItem1.Size = New System.Drawing.Size(47, 20)
        Me.BookmarksToolStripMenuItem1.Text = "View"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.HistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'BookmarksToolStripMenuItem2
        '
        Me.BookmarksToolStripMenuItem2.BackColor = System.Drawing.Color.Black
        Me.BookmarksToolStripMenuItem2.ForeColor = System.Drawing.Color.Red
        Me.BookmarksToolStripMenuItem2.Name = "BookmarksToolStripMenuItem2"
        Me.BookmarksToolStripMenuItem2.Size = New System.Drawing.Size(137, 22)
        Me.BookmarksToolStripMenuItem2.Text = "Bookmarks"
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem})
        Me.PrintToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PrintToolStripMenuItem1.ForeColor = System.Drawing.Color.Lime
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(46, 20)
        Me.PrintToolStripMenuItem1.Text = "Print"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.PrintToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.PrintPreviewToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 60)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1385, 675)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuText
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1385, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BookmarksToolStripMenuItem})
        Me.EditToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EditToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'BookmarksToolStripMenuItem
        '
        Me.BookmarksToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.BookmarksToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem"
        Me.BookmarksToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.BookmarksToolStripMenuItem.Text = "Bookmark&s"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreditsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'CreditsToolStripMenuItem
        '
        Me.CreditsToolStripMenuItem.BackColor = System.Drawing.Color.Black
        Me.CreditsToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.CreditsToolStripMenuItem.Name = "CreditsToolStripMenuItem"
        Me.CreditsToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.CreditsToolStripMenuItem.Text = "Credits"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(1278, 741)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "00:00:00:00"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 741)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(318, 14)
        Me.ProgressBar1.TabIndex = 4
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("AR CHRISTY", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(969, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 27)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Brett Tech Browser"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Brett_Tech_Browser.My.Resources.Resources.Search_Button_PNG_File
        Me.PictureBox3.Location = New System.Drawing.Point(795, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(79, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Brett_Tech_Browser.My.Resources.Resources.forward
        Me.PictureBox2.Location = New System.Drawing.Point(42, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Brett_Tech_Browser.My.Resources.Resources.back
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 31)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(306, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1385, 761)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Brett Tech Browser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookmarksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FullScreenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookmarksToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookmarksToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents NormalSizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
End Class
